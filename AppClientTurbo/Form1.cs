using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Collections;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AppClientTurbo
{
    
    public partial class Form1 : Form
    {
        Req req;
        int myTime = -1;
        HttpResponseMessage response;
        string sessionId=null;
        CashList cashList;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            adrServer.Text = Properties.Settings.Default.adrServer;
            adrPort.Text = Properties.Settings.Default.adrPort;
            methodBox.Text = Properties.Settings.Default.methodBox;
            user.Text = Properties.Settings.Default.user;
            password.Text = Properties.Settings.Default.password;
            Refs.Text = Properties.Settings.Default.Refs;
            dataReq.Text = Properties.Settings.Default.dataReq;
            request.Text = Properties.Settings.Default.request;
            jsonFile.Text = Properties.Settings.Default.file; 
            loadCash();
        }
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.dataReq = dataReq.Text;
            Properties.Settings.Default.request = request.Text;
            Properties.Settings.Default.adrServer = adrServer.Text;
            Properties.Settings.Default.adrPort = adrPort.Text;
            Properties.Settings.Default.methodBox = methodBox.Text;
            Properties.Settings.Default.user = user.Text;
            Properties.Settings.Default.password = password.Text;
            Properties.Settings.Default.Refs = Refs.Text;
            Properties.Settings.Default.file = jsonFile.Text;
            Properties.Settings.Default.Save();
            logout(sender,e);
        }
        static bool myClick = true;
        private async void send_Click(object sender, EventArgs e)
        {
            
            if (myClick)
            {
                myTime = 0;
                myClick = false; pictureBox3.BackColor = Color.Yellow;

                try
                {
                    if (sessionId == null) throw new Exception("SessionId empty");
                    {
                        if (methodBox.Text == "POST") req.method = Req.Method.POST;
                        else if (methodBox.Text == "GET") req.method = Req.Method.GET;
                        else if (methodBox.Text == "PUT") req.method = Req.Method.PUT;
                        else if (methodBox.Text == "DELETE") req.method = Req.Method.DELETE;
                        req.data = dataReq.Text;
                        req.request = request.Text;
                        req.content.Headers.Add("sessionID", sessionId);
                        if (request.Text == "userAuth/logout")
                        {
                            Off();
                            response = await req.postRequest(req);
                        }
                        else
                        {
                            try
                            {
                                response = await req.postRequest(req);
                                string responseString = await response.Content.ReadAsStringAsync();
                                if (responseString == "<HTML><BODY><B>401 Unauthorized</B></BODY></HTML>") throw new Exception("Unauthorized");
                                try
                                {
                                    responseTxt.Text = JToken.Parse(responseString).ToString(Formatting.Indented);
                                }
                                catch
                                {
                                    responseString = "[" + responseString + "]";
                                    responseTxt.Text = JToken.Parse(responseString).ToString(Formatting.Indented);
                                }
                                responseTxt.AppendText(Environment.NewLine);
                            }
                            catch (Exception ex)
                            {

                                if (ex.Message == "Unauthorized") throw;
                                responseTxt.AppendText("Не верный запрос!" + Environment.NewLine);

                            }
                        }
                    }
                }
                catch
                {
                    Off();
                    responseTxt.AppendText("Пожалуйста авторизуйтесь!" + Environment.NewLine);
                }
                myClick = true; pictureBox3.BackColor = Color.White;
                
            }
        }
        private async void userauth_Click(object sender, EventArgs e)
        {
            
            if (myClick&&(sessionId==null))
            {
                myClick = false; pictureBox3.BackColor = Color.Yellow;
                if (ForceBox.Checked)
                {
                    req = new Req(Req.Method.POST, @"{""user"": """ + user.Text + "\",\"password\":\"" + password.Text + "\",\"ForceLogin\":true}", 
                        "userauth/login", adrServer.Text, adrPort.Text);//хардкод, возможно будет необходим более гибкий подход
                }
               else
                {
                    req = new Req(Req.Method.POST, @"{""user"": """ + user.Text + "\",\"password\":\"" + password.Text + "\"}",
                       "userauth/login", adrServer.Text, adrPort.Text);//хардкод, возможно будет необходим более гибкий подход
                }
                try
                {
                    response = await req.postRequest(req);
                    try
                    {
                        sessionId = response.Headers.GetValues("sessionId").Last().ToString();
                        responseTxt.AppendText("Успешная авторизация!" + Environment.NewLine);
                        pictureBox2.BackColor = Color.White;
                        pictureBox1.BackColor = Color.Lime;
                        ForceBox.Visible = false;
                        ForceBox.Checked = false;
                        if (timeWithoutClick)
                        {
                            timeWithoutClick = false;
                            Refs.Text = bufRefs;
                            request.Text = bufRequest;
                            dataReq.Text = bufReq;
                        }
                        myTime = 0;
                    }
                    catch
                    {
                        string str = await response.Content.ReadAsStringAsync();
                        responseTxt.AppendText("Не Авторизован!" + Environment.NewLine);
                        responseTxt.AppendText(str + Environment.NewLine);
                        if (str != "Неправильное имя пользователя или пароль")
                        {
                            ForceBox.Visible = true;
                        }
                        Off();
                    }
                }
                catch
                {
                    responseTxt.AppendText("Проверьте адрес и порт сервера!" + Environment.NewLine);
                    Off();
                }
                myClick = true; pictureBox3.BackColor = Color.White;
                
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            responseTxt.Clear();
        }
        string bufRefs;
        string bufRequest;
        string bufReq;
        private void logout(object sender, EventArgs e)
        {
            myTime = -1;
            if (sessionId != null)
            {
                bufRefs = Refs.Text;
                bufRequest = request.Text;
                bufReq = dataReq.Text;
                Refs.Text = "ВЫХОД";
                request.Text = "userAuth/logout";
                dataReq.Text = "";
                send_Click(sender, e);
            }
        }
        private void adrPort_TextChanged(object sender, EventArgs e)
        {
            logout(sender, e);
        }
        private void adrServer_TextChanged(object sender, EventArgs e)
        {
            logout(sender, e);
        }
        private void user_TextChanged(object sender, EventArgs e)
        {
            logout(sender, e);
        }
        private void password_TextChanged(object sender, EventArgs e)
        {
            logout(sender, e);
        }
        private void Off()
        {
            sessionId = null;
            pictureBox2.BackColor = Color.Red;
            pictureBox1.BackColor = Color.White;
        }
        bool timeWithoutClick = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (myTime != -1) {
                if (++myTime > 10000) 
                {
                    timeWithoutClick = true;
                    logout(sender, e);
                }
            }
        }

        private void saveCash_Click(object sender, EventArgs e)
        {
            Cash cash = cashList.listCash.Find(x => x.Name == Refs.Text);
            if (cash == null)
                cashList.listCash.Add(new Cash(Refs.Text, methodBox.Text, request.Text, dataReq.Text));
            else{ 
                cash.Method = methodBox.Text; 
                cash.Request = request.Text; 
                cash.DataReq = dataReq.Text; 
            }
            cashList.save();
            updateRef();
        }
        private void loadCash()
        {
            cashList = new CashList(jsonFile.Text);
            if (cashList.listCash != null) updateRef();
        }
        private void updateRef()
        {
            Refs.Items.Clear();
            foreach (var item in cashList.listCash)
            {
                Refs.Items.Add(item.Name);
            }
            saveCash.Enabled = false;
            deleteCash.Enabled = true;
        }

        private void Refs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cash cash = cashList.listCash.Find(x => x.Name == Refs.Text);
                if (cash == null) { cash = cashList.listCash[0]; Refs.Text = cash.Name; }
                methodBox.Text = cash.Method;
                request.Text = cash.Request;
                dataReq.Text = cash.DataReq;
                saveCash.Enabled = false;
                deleteCash.Enabled = true;
            }
            catch{}
        }

        private void request_TextChanged(object sender, EventArgs e)
        {
            saveCash.Enabled = true;
            deleteCash.Enabled = false;
        }

        private void dataReq_TextChanged(object sender, EventArgs e)
        {
            saveCash.Enabled = true;
            deleteCash.Enabled = false;
        }

        private void Refs_TextChanged(object sender, EventArgs e)
        {
            saveCash.Enabled = true;
            deleteCash.Enabled = false;
        }

        private void deleteCash_Click(object sender, EventArgs e)
        {
            new Form2(cashList.listCash,"Вы действительно хотите удалить запись из списка?",Refs.Text).ShowDialog();
            Refs_SelectedIndexChanged(sender, e);
            saveCash_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                jsonFile.Text = openFileDialog1.FileName;
                loadCash();
                Refs_SelectedIndexChanged(sender, e);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (timeWithoutClick) userauth_Click(sender, e);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (timeWithoutClick) userauth_Click(sender, e);
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if (timeWithoutClick) userauth_Click(sender, e);
        }

        private void splitContainer1_MouseMove(object sender, MouseEventArgs e)
        {
            if (timeWithoutClick) userauth_Click(sender, e);
        }

        private void dataReq_MouseMove(object sender, MouseEventArgs e)
        {
            if (timeWithoutClick) userauth_Click(sender, e);
        }

        private void responseTxt_MouseMove(object sender, MouseEventArgs e)
        {
            if (timeWithoutClick) userauth_Click(sender, e);
        }
    }
}

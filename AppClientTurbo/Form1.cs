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
            dataReqFctb.Text = Properties.Settings.Default.dataReq;
            requestTB.Text = Properties.Settings.Default.request;
            preRequestTB.Text = Properties.Settings.Default.preRequest;
            jsonFile.Text = Properties.Settings.Default.file; 
            loadCash();
        }
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.dataReq = dataReqFctb.Text;
            Properties.Settings.Default.preRequest = preRequestTB.Text;
            Properties.Settings.Default.request = requestTB.Text;
            Properties.Settings.Default.adrServer = adrServer.Text;
            Properties.Settings.Default.adrPort = adrPort.Text;
            Properties.Settings.Default.methodBox = methodBox.Text;
            Properties.Settings.Default.user = user.Text;
            Properties.Settings.Default.password = password.Text;
            Properties.Settings.Default.Refs = Refs.Text;
            Properties.Settings.Default.file = jsonFile.Text;
            Properties.Settings.Default.Save();
            logout();
        }
        static bool myClick = true;
        static bool myClick2 = true;
        private async void send_Click(object sender, EventArgs e)
        {
            
            if (myClick)
            {
                myTime = 0;
                setVisibility(false);
                try
                {
                    if (sessionId == null) throw new Exception("SessionId empty");
                    {
                        if (methodBox.Text == "POST") req.method = Req.Method.POST;
                        else if (methodBox.Text == "GET") req.method = Req.Method.GET;
                        else if (methodBox.Text == "PUT") req.method = Req.Method.PUT;
                        else if (methodBox.Text == "DELETE") req.method = Req.Method.DELETE;
                        req.data = dataReqFctb.Text;
                        req.preRequest = preRequestTB.Text;
                        req.request = requestTB.Text;
                        req.content.Headers.Add("sessionID", sessionId);

                        responseFctb.Text = await senderReq() + Environment.NewLine;
                    }
                }
                catch
                {
                    Off();
                    label17.Text = "Status Code";
                    responseFctb.Text="Пожалуйста авторизуйтесь!" + Environment.NewLine;
                }
                setVisibility(true);
            }
        }
        private async void userauth_Click(object sender, EventArgs e)
        {
            if (myClick){
                myTime = -1;
                setVisibility(false);
                if (sessionId == null) await login(); else await logout();
                setVisibility(true);
            }
        }
        void setVisibility(bool flag)
        {
            myClick = flag;
            label17.Visible = flag;
            pictureBox3.BackColor = flag ? Color.White : Color.Yellow;

        }
        private void Clear_Click(object sender, EventArgs e)
        {
            responseFctb.Clear();
            label17.Text = "Status Code";
        }
        private async Task login()
        {
            req = new Req(Req.Method.POST, @"{""user"": """ + user.Text + "\",\"password\":\"" + password.Text + ((ForceBox.Checked) ? "\",\"ForceLogin\":true}" : "\"}"),
                                       "/api/xcom/userauth/", "login", adrServer.Text, adrPort.Text);
            try
            {
                response = await req.postRequest();
                label17.Text = "Status Code -" + (int)response.StatusCode + " " + response.StatusCode + "-";
                try
                {
                    sessionId = response.Headers.GetValues("sessionId").Last().ToString();
                    responseFctb.Text="Успешная авторизация!" + Environment.NewLine;
                    pictureBox2.BackColor = Color.White;
                    pictureBox1.BackColor = Color.Lime;
                    ForceBox.Visible = false;
                    ForceBox.Checked = false;
                    if (timeWithoutClick)
                    {
                        timeWithoutClick = false;
                    }
                    myTime = 0;
                    userautBtn.Text = "Выход";
                }
                catch
                {
                    responseFctb.Text="Не Авторизован!" + Environment.NewLine;
                    responseFctb.AppendText(await response.Content.ReadAsStringAsync() + Environment.NewLine);
                    ForceBox.Visible = (response.StatusCode != System.Net.HttpStatusCode.Unauthorized);
                    Off();
                }
            }
            catch
            {
                responseFctb.Text="Проверьте адрес и порт сервера!" + Environment.NewLine;
                label17.Text = "Status Code";
                Off();
            }
        }
        private async Task logout()
        {
            if (myClick2)
            {
                myClick2 = false;
                myTime = -1;
                if (sessionId != null)
                {
                    req.method = Req.Method.POST;
                    req.preRequest = "/api/xcom/userAuth/";
                    req.request = "logout";
                    req.data = "";
                    req.content.Headers.Add("sessionID", sessionId);
                    responseFctb.Text=await senderReq() + Environment.NewLine;
                }
                myClick2 = true;
            }
        }
        async Task<string> senderReq()
        {
            try
            {
                response = await req.postRequest();
                label17.Text = "Status Code -" + (int)response.StatusCode+" " + response.StatusCode + "-";
                if (((req.preRequest + req.request).ToLower() == "/api/xcom/userauth/logout") && response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Off();
                    userautBtn.Text = "Вход";
                    return "Сессия завершена!";
                }
                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized) return "Не Авторизован!";
                string responseString = await response.Content.ReadAsStringAsync();
                try
                {
                    return JToken.Parse(responseString).ToString(Formatting.Indented);
                }
                catch
                {
                    responseString = "[" + responseString + "]";
                    return JToken.Parse(responseString).ToString(Formatting.Indented);
                }
            }
            catch
            {
                return "Не верный запрос!"; 
            }
            

        }

        private async void adrPort_TextChanged(object sender, EventArgs e)
        {
            await logout();
        }
        private async void adrServer_TextChanged(object sender, EventArgs e)
        {
            await logout();
        }
        private async void user_TextChanged(object sender, EventArgs e)
        {
            await logout();
        }
        private async void password_TextChanged(object sender, EventArgs e)
        {
            await logout();
        }
        private void Off()
        {
            sessionId = null;
            pictureBox2.BackColor = Color.Red;
            pictureBox1.BackColor = Color.White;
        }
        bool timeWithoutClick = false;
        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (myTime != -1) {
                if (++myTime > 10000) 
                {
                    timeWithoutClick = true;
                    await logout();
                }
            }
        }

        private void saveCash_Click(object sender, EventArgs e)
        {
            Cash cash = cashList.listCash.Find(x => x.Name == Refs.Text);
            if (cash == null)
                cashList.listCash.Add(new Cash(Refs.Text, methodBox.Text, preRequestTB.Text, requestTB.Text, dataReqFctb.Text));
            else{ 
                cash.Method     = methodBox.Text; 
                cash.PreRequest = preRequestTB.Text; 
                cash.Request    = requestTB.Text; 
                cash.DataReq    = dataReqFctb.Text; 
            }
            cashList.save();
            updateRef();
        }
        private void loadCash()
        {
            cashList = new CashList(jsonFile.Text);
            if (cashList.listCash != null) updateRef();
            jsonFile.Text = cashList.path;
        }
        private void updateRef()
        {
            Refs.Items.Clear();
            foreach (var item in cashList.listCash)
            {
                Refs.Items.Add(item.Name);
            }
            saveCashBtn.Enabled = false;
            deleteCashBtn.Enabled = true;
        }

        private void Refs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cash cash = cashList.listCash.Find(x => x.Name == Refs.Text);
                if (cash == null) { cash = cashList.listCash[0]; Refs.Text = cash.Name; }
                methodBox.Text = cash.Method;
                preRequestTB.Text = cash.PreRequest;
                requestTB.Text = cash.Request;
                dataReqFctb.Text = cash.DataReq;
                saveCashBtn.Enabled = false;
                deleteCashBtn.Enabled = true;
            }
            catch{}
        }

        private void request_TextChanged(object sender, EventArgs e)
        {
            saveCashBtn.Enabled = true;
            deleteCashBtn.Enabled = false;
        }

        private void dataReq_TextChanged(object sender, EventArgs e)
        {
            saveCashBtn.Enabled = true;
            deleteCashBtn.Enabled = false;
        }

        private void Refs_TextChanged(object sender, EventArgs e)
        {
            saveCashBtn.Enabled = true;
            deleteCashBtn.Enabled = false;
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

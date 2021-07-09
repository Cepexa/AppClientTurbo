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


namespace AppClientTurbo
{
    public partial class Form1 : Form
    {
        Req req;
        HttpResponseMessage response;
        string sessionId=null;
        List<string> listAll;
        List<string> listRefs;
        List<string> listRequest;
        List<string> listDataReq;
        List<string> listEdit;
        List<string> listRefsEdit;
        public Form1()
        {
            InitializeComponent();
            adrServer.Text = Properties.Settings.Default.adrServer;
            adrPort.Text = Properties.Settings.Default.adrPort;
            methodBox.Text = Properties.Settings.Default.methodBox;
            user.Text = Properties.Settings.Default.user;
            password.Text = Properties.Settings.Default.password;
            listRefs = new List<string>();
            listAll = new List<string>();
            listRequest = new List<string>();
            listDataReq = new List<string>();
            if (!File.Exists("File.txt")) File.Create("File.txt").Close();
            listAll = File.ReadAllLines("File.txt").ToList();
            updateRefs();
            Refs.Text = Properties.Settings.Default.Refs;
            dataReq.Text = Properties.Settings.Default.dataReq;
            request.Text = Properties.Settings.Default.request;
        }
        private void updateRefs()
        {
            listRefs.Clear();
            listRequest.Clear();
            listDataReq.Clear();
            for (int i = 0; i < listAll.Count; ++i)
            {
                if ((i % 3) == 0)
                {
                    listRefs.Add(listAll[i]);
                }
                else if ((i % 3) == 1)
                {
                    listRequest.Add(listAll[i]);
                }
                else if ((i % 3) == 2)
                {
                    listDataReq.Add(listAll[i]);
                }
            }
            
            Refs.DataSource = null;
            Refs.DataSource = listRefs;
        }
        
        private async void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.dataReq = dataReq.Text;
            Properties.Settings.Default.request = request.Text;
            Properties.Settings.Default.adrServer = adrServer.Text;
            Properties.Settings.Default.adrPort = adrPort.Text;
            Properties.Settings.Default.methodBox = methodBox.Text;
            Properties.Settings.Default.user = user.Text;
            Properties.Settings.Default.password = password.Text;
            Properties.Settings.Default.Refs = Refs.Text;
            Properties.Settings.Default.Save();
            logout(sender,e);
            File.WriteAllLines("File.txt", listAll);
        }
        static bool Click = true;
        private async void send_Click(object sender, EventArgs e)
        {
            if (Click)
            {
                Click = false; pictureBox3.BackColor = Color.Yellow;

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
                        if (request.Text == "userAuth/logout") Off();
                        try
                        {
                            response = await req.postRequest(req);
                            string responseString = await response.Content.ReadAsStringAsync();
                            if (responseString == "<HTML><BODY><B>401 Unauthorized</B></BODY></HTML>") throw new Exception("Unauthorized");
                            responseTxt.AppendText(responseString + Environment.NewLine);
                        }
                        catch(Exception ex)
                        {

                            if (ex.Message== "Unauthorized") throw;
                            responseTxt.AppendText("Не верный запрос!" + Environment.NewLine);
                            
                        }
                    }
                }
                catch
                {
                    Off();
                    responseTxt.AppendText("Пожалуйста авторизуйтесь!" + Environment.NewLine);
                }
                Click = true; pictureBox3.BackColor = Color.White;
            }
        }
        private async void userauth_Click(object sender, EventArgs e)
        {
            if (Click&&(sessionId==null))
            {
                Click = false; pictureBox3.BackColor = Color.Yellow;
                req = new Req(Req.Method.POST, @"{""user"": """ + user.Text + "\",\"password\":\"" + password.Text + "\"}",
                    "userauth/login", adrServer.Text, adrPort.Text);//хардкод, возможно будет необходим более гибкий подход
                try
                {
                    response = await req.postRequest(req);
                    try
                    {
                        sessionId = response.Headers.GetValues("sessionId").Last().ToString();
                        responseTxt.AppendText("Успешная авторизация!" + Environment.NewLine);
                        pictureBox2.BackColor = Color.White;
                        pictureBox1.BackColor = Color.Lime;
                    }
                    catch
                    {
                        responseTxt.AppendText("Не Авторизован!" + Environment.NewLine);
                        Off();
                    }
                }
                catch
                {
                    responseTxt.AppendText("Проверьте адрес и порт сервера!" + Environment.NewLine);
                    Off();
                }
                Click = true; pictureBox3.BackColor = Color.White;
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            responseTxt.Clear();
        }
        private void logout(object sender, EventArgs e)
        {
            if (sessionId != null)
            {
                Refs.Text = "-";
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

        private void Refs_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < listRefs.Count; ++i)
            {
                if (Refs.Text == listRefs[i])
                {
                    request.Text = listRequest[i];
                    dataReq.Text = listDataReq[i];
                    break;
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            listAll = listEdit;
            updateRefs();
            groupBox1.Visible = false;
        }

        private void add_Click(object sender, EventArgs e)
        {
            listEdit = new List<string>(listAll);
            listRefsEdit = new List<string>(listRefs);
            listBox1.DataSource = listRefsEdit;
            groupBox1.Visible = !groupBox1.Visible;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Задано пустое значение!");
                return;
            }
            bool flag = true;
            foreach(string el in listRefs)
            {
                if (textBox3.Text == el)
                {
                    MessageBox.Show("Запись уже существует!");
                    flag = false;
                    return;
                }
            }
            if (flag)
            {
                listRefsEdit.Add(textBox3.Text);
                listEdit.Add(textBox3.Text);
                listEdit.Add(textBox2.Text);
                listEdit.Add(textBox1.Text);
                listBox1.DataSource = null;
                listBox1.DataSource = listRefsEdit;
                listBox1.SelectedItem = textBox3.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var str = listBox1.SelectedItem.ToString();
                listRefsEdit.Remove(str);
                listBox1.DataSource = null;
                listBox1.DataSource = listRefsEdit;
                for (int i = 0; i < listEdit.Count; ++i)
                {
                    if (listEdit[i] == str)
                    {
                        listEdit.RemoveAt(i + 2);
                        listEdit.RemoveAt(i + 1);
                        listEdit.RemoveAt(i);
                        return;
                    }
                }
            }
            catch { }
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

    }
}

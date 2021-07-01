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


namespace AppClientTurbo
{
    public partial class Form1 : Form
    {
        Req req;
        HttpResponseMessage response;
        string sessionId;
        public Form1()
        {
            InitializeComponent();
        }
        private async void send_Click(object sender, EventArgs e)
        {
            //responseTxt.AppendText("Привет"+ Environment.NewLine);
            if(sessionId == null)
            {
                responseTxt.AppendText("Пожалуйста авторизуйтесь!" + Environment.NewLine);
            }
            else
            {
                if(methodBox.Text=="POST")req.method = Req.Method.POST;
                else if(methodBox.Text=="GET")req.method = Req.Method.GET;
                else if (methodBox.Text=="PUT")req.method = Req.Method.PUT;
                else if (methodBox.Text=="DELETE")req.method = Req.Method.DELETE;
                req.data = dataReq.Text;
                req.request = request.Text;
                req.content.Headers.Add("sessionID", sessionId);
                try
                {
                    response = await req.postRequest(req);
                    string responseString = await response.Content.ReadAsStringAsync();
                    string str ="";
                    for (int countStr = 0, i = 0; i < responseString.Length; ++i)
                    {

                        if ((responseString[i] == '{') || (responseString[i] == '['))
                        {
                            responseTxt.AppendText(str+Environment.NewLine);
                            str = "";
                            countStr++;
                            for (int j = 1; j < countStr; j++)
                            {
                                responseTxt.AppendText("\t");
                            }

                        }
                        else if ((responseString[i] == '}') || (responseString[i] == ']'))
                        {
                            countStr--;
                        }
                        str+=responseString[i];
                    }
                    if (str != "")
                    {
                        responseTxt.AppendText(str + Environment.NewLine);
                    }
                }
                catch
                {
                    responseTxt.AppendText("Не верный запрос!" + Environment.NewLine);
                }
            }
        }

        private async void userauth_Click(object sender, EventArgs e)
        {
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
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            responseTxt.Clear();
        }

        private void adrPort_TextChanged(object sender, EventArgs e)
        {
            Off();
        }
        private void adrServer_TextChanged(object sender, EventArgs e)
        {
            Off();
        }
        private void Off()
        {
            sessionId = null;
            pictureBox2.BackColor = Color.Red;
            pictureBox1.BackColor = Color.White;
        }
    }
}

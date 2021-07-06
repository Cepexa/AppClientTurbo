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


namespace AppClientTurbo
{
    public partial class Form1 : Form
    {
        Req req;
        HttpResponseMessage response;
        string sessionId;
        ToolTip t,t1;
        public Form1()
        {
            InitializeComponent();
            dataReq.Text = Properties.Settings.Default.dataReq;
            request.Text = Properties.Settings.Default.request;
            adrServer.Text = Properties.Settings.Default.adrServer;
            adrPort.Text = Properties.Settings.Default.adrPort;
            methodBox.Text = Properties.Settings.Default.methodBox;
            user.Text = Properties.Settings.Default.user;
            password.Text = Properties.Settings.Default.password;
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

            Properties.Settings.Default.Save();
        }
        static bool Click = true;
        private async void send_Click(object sender, EventArgs e)
        {
            if (Click)
            {
                Click = false;

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
                        try
                        {
                            response = await req.postRequest(req);
                            string responseString = await response.Content.ReadAsStringAsync();
                            //string str = "";
                            //List<string> arrStr = new List<string>();
                            //for (int countStr = 0, i = 0; i < responseString.Length; ++i)
                            //{

                            //    if ((responseString[i] == '{') || (responseString[i] == '['))
                            //    {

                            //        arrStr.Add(str);
                            //        str = "";
                            //        //countStr++;
                            //        //for (int j = 1; j < countStr; j++)
                            //        //{
                            //        //    str += "\t";
                            //        //}

                            //    }
                            //    else if ((responseString[i] == '}') || (responseString[i] == ']'))
                            //    {
                            //        countStr--;
                            //    }
                            //    str += responseString[i];
                            //}
                            //if (str != "")
                            //{
                            //    arrStr.Add(str);
                            //}
                            if (responseString == "<HTML><BODY><B>401 Unauthorized</B></BODY></HTML>") throw new Exception("Unauthorized");
                            //foreach (string el in arrStr)
                            //{
                            //    responseTxt.AppendText(el + Environment.NewLine);
                            //}
                            responseTxt.AppendText(responseString + Environment.NewLine);
                        }
                        catch(Exception ex)
                        {
                            if ((ex.Message== "Unauthorized")||(ex.InnerException.Message=="Невозможно соединиться с удаленным сервером")) throw;
                            responseTxt.AppendText("Не верный запрос!" + Environment.NewLine);
                            
                        }
                    }
                }
                catch
                {
                    Off();
                    responseTxt.AppendText("Пожалуйста авторизуйтесь!" + Environment.NewLine);
                }
                Click = true;
            }
        }

        private async void userauth_Click(object sender, EventArgs e)
        {
            if (Click)
            {
                Click = false;
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
                Click = true;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.request.TextChanged += new System.EventHandler(this.request_TextChanged);
            t = new ToolTip();
            t.AutoPopDelay = 20000;
            t.InitialDelay = 10;
            t.ReshowDelay = 10;
            update_ToolTip();
            t1 = new ToolTip();
            t1.AutoPopDelay = 20000;
            t1.InitialDelay = 10;
            t1.ReshowDelay = 10;
            t1.SetToolTip(request, "--Подсказка:\n"+
                "RepairService/getDataRef\n"+
                "RepairService/getDataRef1\n"+
                "userAuth/logout\n");
        }
        private void update_ToolTip()
        {
            if (request.Text == "RepairService/getDataRef")
            {
                t.SetToolTip(dataReq, @"--Подсказка:
    {""aRef"":""Ref.Equipment.Classes""}         - Классификатор
    {""aRef"":""Ref.Equipment.Groups""}         - Группы оборудования
    {""aRef"":""Ref.Places.Objects""}                 - Объекты
    {""aRef"":""Ref.Places.Places""}                   - Технические места
    {""aRef"":""Ref.Places.Buildings""}              - Здания
    {""aRef"":""Ref.Places.Departments""}        - Цеха
    {""aRef"":""Ref.Places.Areas""}                     - Участки
    {""aRef"":""Ref.Places.Flows""}                     - Производственные потоки
    {""aRef"":""Ref.Places.Lines""}                      - Производственные линии
    {""aRef"":""FlowCharts.FlowChartsTypes""}- Виды работ
    {""aRef"":""FlowCharts.Operations""}          - Операции
    {""aRef"":""FlowCharts.FlowCharts""}          - Технологические карты
    {""aRef"":""FlowCharts.Norms""}                  - Нормативы
    {""aRef"":""FlowCharts.WorkShift""}            - Длительность смен
    {""aRef"":""Brigade.BrigadeTypes""}             - Типы бригад
    {""aRef"":""Ref.Positions""}                            - Должности
    {""aRef"":""Ref.Priority.Equipment""}           - Приоритеты оборудования
    {""aRef"":""Ref.Priority.Repair""}                   - Приоритеты видов работ
    {""aRef"":""Ref.Priority.Rating""}                   - Оценки приоритетов
    {""aRef"":""Ref.Priority.Matrix""}                   - Матрицы приоритетов
    {""aRef"":""Ref.Attributes.OrderType""}        - Типы заказов
    {""aRef"":""Planes.PlanGroups""}                  - Группы планирования
    {""aRef"":""Ref.UnitOrCurrency""}                - Единицы измерения
    {""aRef"":""Ref.Attributes.DefectType""}      - Типы дефектов
    {""aRef"":""Ref.Attributes.DefectLevel""}      - Уровни дефектов
    {""aRef"":""Ref.Attributes.DefectReason""}  - Причины дефектов
    {""aRef"":""Ref.Attributes.StateType""}          - Виды технических состояний
    {""aRef"":""Ref.Attributes.Parameters""}       - Параметры оборудования");
            }
            else if (request.Text == "RepairService/getDataRef1")
            {
                t.SetToolTip(dataReq, @"--Подсказка:
    {""aRef"":""Справочники.ТМЦ""}       - Запасные части");
            }
            else
            {
                t.SetToolTip(dataReq, @"--Подсказка:");
            }
        }

        private void request_TextChanged(object sender, EventArgs e)
        {
            update_ToolTip();
        }
    }
}

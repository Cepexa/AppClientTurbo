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
            Init_FileExplorer();
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
                    labelStatusCode.Text = "Status Code";
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
            labelStatusCode.Visible = flag;
            pictureBox3.BackColor = flag ? Color.White : Color.Yellow;

        }
        private void Clear_Click(object sender, EventArgs e)
        {
            responseFctb.Clear();
            labelStatusCode.Text = "Status Code";
        }
        private async Task login()
        {
            req = new Req(Req.Method.POST, @"{""user"": """ + user.Text + "\",\"password\":\"" + password.Text + ((ForceBox.Checked) ? "\",\"ForceLogin\":true}" : "\"}"),
                                       "/api/xcom/userauth/", "login", adrServer.Text, adrPort.Text);
            try
            {
                response = await req.postRequest();
                labelStatusCode.Text = "Status Code -" + (int)response.StatusCode + " " + response.StatusCode + "-";
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
                labelStatusCode.Text = "Status Code";
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
                labelStatusCode.Text = "Status Code -" + (int)response.StatusCode+" " + response.StatusCode + "-";
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
        private void dataReqFctb_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
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
        private void jsonFile_TextChanged(object sender, EventArgs e)
        {
            loadCash();
            Refs_SelectedIndexChanged(sender, e);
        }





        #region ФАЙЛОВЫЙ МЕНЕДЖЕР
        ImageList _imageList = new ImageList();
        string pathLoc;
        string pathServ;
        string pathBuff;
        string pathTempBuff = Directory.GetCurrentDirectory() + "\\TempBuff";
        void Init_FileExplorer()
        {
            //подружаем иконки
            _imageList.Images.Add(Image.FromFile("source\\image\\folder.ico"));
            _imageList.Images.Add(Image.FromFile("source\\image\\original.png"));
            _imageList.Images.Add(Image.FromFile("source\\image\\arrow.png"));
            _imageList.Images.Add(Image.FromFile("source\\image\\plus.png"));
            _treeViewLoc.ImageList = _imageList;
            _treeViewServ.ImageList = _imageList;
            _treeViewLoc.SelectedImageIndex = 2;
            _treeViewServ.SelectedImageIndex = 2;
            updatePath();
            updateView();

        }
        void updatePath()
        {
            //добавляем 2 корневые папки
            pathLoc = Directory.GetCurrentDirectory() + "\\Collection";
            if (!Directory.Exists(pathLoc)) Directory.CreateDirectory(pathLoc);
            pathServ = "\\\\172.17.18.50\\Users\\Public\\AppClientTurbo\\v1.2\\Collection";
            if (!Directory.Exists(pathServ))
            {
                MessageBox.Show("Проверьте доступность: " + pathServ);
                try
                {
                    Directory.CreateDirectory(pathServ);
                }
                catch (Exception)
                { }
            }
            pathLocTb.Text = pathLoc;
            pathServTb.Text = pathServ;
        }
        void updateView()
        {
            loadTreeNode(_treeViewLoc.Nodes, pathLoc);
            loadTreeNode(_treeViewServ.Nodes, pathServ);
            try
            {
                _treeViewLoc.Enabled = true;
                _treeView_NodeMouseClick(_treeViewLoc,
                    new TreeNodeMouseClickEventArgs(_treeViewLoc.Nodes[0], MouseButtons.Left, 1, 80, 5));
            }
            catch { _treeViewLoc.Enabled = false; }
            try
            {
                _treeViewServ.Enabled = true;
                _treeView_NodeMouseClick(_treeViewServ,
                     new TreeNodeMouseClickEventArgs(_treeViewServ.Nodes[0], MouseButtons.Left, 1, 80, 5));
                _treeViewLoc.SelectedNode = null;
            }
            catch
            {
                _treeViewServ.Enabled = false;
            }
        }
        private void _listView_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection ic = _listView.SelectedItems;
            if (ic.Count > 0)
            {
                try
                {
                    System.Diagnostics.Process.Start(ic[0].SubItems[3].Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        void loadTreeNode(TreeNodeCollection tnc, string path, bool ToCollapse = true)
        {
            try
            {
                tnc.Clear();
                string[] files = Directory.GetFiles(path);
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    string[] splited = dir.Split('\\');
                    string dirName = splited[splited.Length - 1];
                    TreeNode curTn = tnc.Add(dirName);
                    curTn.ImageIndex = 0;
                    curTn.Name = dir;
                    loadTreeNode(curTn.Nodes, curTn.Name);
                    if (ToCollapse) curTn.Collapse();
                    else curTn.Expand();
                }
                foreach (string file in files)
                {
                    string[] splited = file.Split('\\');
                    string fileName = splited[splited.Length - 1];
                    var ext = fileName.Split('.');
                    if (ext[ext.Length - 1].ToLower() == "json")
                    {
                        TreeNode curTn = tnc.Add(fileName.Replace("." + ext[ext.Length - 1], ""));
                        curTn.ImageIndex = 1;
                        curTn.Name = file;
                    }

                }
                if (tnc.Count == 0)
                {
                    TreeNode curTn = tnc.Add("Нет данных");
                    curTn.ImageIndex = 3;
                    curTn.Name = path + "\\Нет данных";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void setFilesOnce(string file)
        {
            _listView.Items.Clear();
            setFiles(file);
        }
        void setFilesToListFromDir(string path)
        {
            _listView.Items.Clear();
            var dirs = Directory.GetFiles(path);
            foreach (var dir in dirs)
            {
                setFiles(dir);
            }
        }
        void setFiles(string file)
        {
            try
            {
                FileInfo fi = new FileInfo(file);
                string[] name = fi.Name.Split('.');
                for (int i = 1; i < name.Length - 1; i++)
                {
                    name[0] += "." + name[i];
                }
                string[] row = { fi.Length.ToString(), (name.Length > 1 ? name[name.Length - 1] : ""), file };
                _listView.Items.Add(name[0]).SubItems.AddRange(row);

            }
            catch (Exception)
            {
                updateView();
            }
        }
        bool NodeClick = false;
        int TypeContextMenu;
        private void _treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            NodeClick = true;
            TreeNode curTn = e.Node;
            ((TreeView)sender).SelectedNode = curTn;
            if (curTn.ImageIndex == 0)
            {
                setFilesToListFromDir(curTn.Name);
            }
            else if (curTn.ImageIndex == 1)
            {
                setFilesOnce(curTn.Name);
                jsonFile.Text = curTn.Name;


            }
            else
            {
                _listView.Items.Clear();
            }
            bool flag = curTn.ImageIndex == 0 || curTn.ImageIndex == 1;
            вырезатьToolStripMenuItem.Enabled = flag;
            копироватьToolStripMenuItem.Enabled = flag;
            ПереименоватьToolStripMenuItem.Enabled = flag;
            удалитьToolStripMenuItem.Enabled = flag;
        }

        private void _treeViewServ_MouseUp(object sender, MouseEventArgs e)
        {
            _treeViewLoc.SelectedNode = null;
            if (!NodeClick)
            {
                try
                {
                    _treeView_NodeMouseClick(_treeViewServ,
                    new TreeNodeMouseClickEventArgs(_treeViewServ.Nodes[0], MouseButtons.Left, 1, 80, 5));
                }
                catch
                {
                }
            }
            NodeClick = false;
        }

        private void _treeViewLoc_MouseUp(object sender, MouseEventArgs e)
        {
            _treeViewServ.SelectedNode = null;
            if (!NodeClick)
            {
                try
                {
                    _treeView_NodeMouseClick(_treeViewLoc,
                new TreeNodeMouseClickEventArgs(_treeViewLoc.Nodes[0], MouseButtons.Left, 1, 80, 5));
                }
                catch
                {

                }
            }
            NodeClick = false;
        }

        private void _treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            NodeClick = true;
        }

        private void каталогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeContextMenu = 0;
            panel1.Visible = true;
            nameTb.Text = "";
            nameTb.Focus();
        }
        private void коллекциюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeContextMenu = 1;
            panel1.Visible = true;
            nameTb.Text = "";
            nameTb.Focus();
        }
        private void ПереименоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeContextMenu = 2;
            TreeNode curTn = _treeViewServ.SelectedNode;
            if (curTn == null) curTn = _treeViewLoc.SelectedNode;
            if (!(curTn.ImageIndex == 0 || curTn.ImageIndex == 1)) return;
            panel1.Visible = true;
            nameTb.Text = curTn.Text;
            nameTb.Focus();
        }
        private void nameTb_Leave(object sender, EventArgs e)
        {
            panel1.Visible = false;
            if (nameTb.Text.Replace(" ", "") == "") return;//Если мы оставили Имя пустым - ничего не делаем
            TreeNode curTn = _treeViewServ.SelectedNode;
            if (curTn == null) curTn = _treeViewLoc.SelectedNode;
            var parentPath = Directory.GetParent(curTn.Name).FullName;
            var path = parentPath + '\\' + nameTb.Text;
            if (TypeContextMenu == 0)//создать каталог
            {
                path = checkCloneDir(path);
                Directory.CreateDirectory(path);

            }
            else if (TypeContextMenu == 1)//создать файл
            {
                path = checkCloneFile(path);
                File.Create(path);
            }
            else if (TypeContextMenu == 2) //Переименовать
            {
                if (nameTb.Text == curTn.Text) return;
                if (nameTb.Text.ToLower() == curTn.Text.ToLower())
                {
                    if (curTn.ImageIndex == 0)
                    {
                        var temp = checkCloneDir(path);
                        Directory.Move(curTn.Name, temp);
                        Directory.Move(temp, path);
                    }
                    else if (curTn.ImageIndex == 1)
                    {
                        var temp = checkCloneFile(path);
                        File.Move(curTn.Name, temp);
                        File.Move(temp, path);
                    }
                }
                else
                {
                    if (curTn.ImageIndex == 0)
                        Directory.Move(curTn.Name, checkCloneDir(path));
                    else if (curTn.ImageIndex == 1)
                        File.Move(curTn.Name, checkCloneFile(path));
                }
            }
            loadTreeNode((curTn.Parent == null) ? curTn.TreeView.Nodes : curTn.Parent.Nodes, parentPath);
        }
        string checkCloneDir(string path)
        {
            int i = 1;
            var temp = path;
            while (Directory.Exists(temp))
                temp = path + '(' + i++ + ')';
            return temp;
        }
        string checkCloneFile(string path)
        {
            int i = 1;
            var temp = path + ".json";
            while (File.Exists(temp))
                temp = path + '(' + i++ + ')' + ".json";
            return temp;
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode curTn = _treeViewServ.SelectedNode;
                if (curTn == null) curTn = _treeViewLoc.SelectedNode;
                if (curTn.ImageIndex == 0) Directory.Delete(curTn.Name, true);
                else if (curTn.ImageIndex == 1) File.Delete(curTn.Name);
                else return;
                loadTreeNode((curTn.Parent == null) ? curTn.TreeView.Nodes : curTn.Parent.Nodes, Directory.GetParent(curTn.Name).FullName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nameTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TreeNode curTn = _treeViewServ.SelectedNode;
                if (curTn == null) curTn = _treeViewLoc.SelectedNode;
                curTn.TreeView.Focus();
            }
        }
        void ToCopyMove(TreeNode curTn, bool IsMove = false)
        {
            if (!(curTn.ImageIndex == 0 || curTn.ImageIndex == 1)) return;

            if (Directory.Exists(pathTempBuff))
                Directory.Delete(pathTempBuff, true);
            Directory.CreateDirectory(pathTempBuff);

            if (curTn.ImageIndex == 0)
            {
                pathBuff = pathTempBuff + '\\' + curTn.Text;
                copyDir(curTn.Name, pathBuff);
                if (IsMove) Directory.Delete(curTn.Name, true);
            }
            else if (curTn.ImageIndex == 1)
            {
                pathBuff = pathTempBuff + '\\' + curTn.Text + ".json";
                if (IsMove) File.Move(curTn.Name, pathBuff);
                else File.Copy(curTn.Name, pathBuff);
            }
            loadTreeNode((curTn.Parent == null) ? curTn.TreeView.Nodes : curTn.Parent.Nodes, Directory.GetParent(curTn.Name).FullName);

        }
        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode curTn = _treeViewServ.SelectedNode;
                if (curTn == null) curTn = _treeViewLoc.SelectedNode;
                ToCopyMove(curTn, true);
                вставитьToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode curTn = _treeViewServ.SelectedNode;
                if (curTn == null) curTn = _treeViewLoc.SelectedNode;
                ToCopyMove(curTn);
                вставитьToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void copyDir(string fromDir, string toDir)
        {
            Directory.CreateDirectory(toDir);
            string[] files = Directory.GetFiles(fromDir);
            string[] dirs = Directory.GetDirectories(fromDir);
            foreach (string dir in dirs)
            {
                string[] splited = dir.Split('\\');
                string dirName = splited[splited.Length - 1];
                copyDir(dir, toDir + "\\" + dirName);
            }
            foreach (string file in files)
            {
                string[] splited = file.Split('\\');
                string fileName = splited[splited.Length - 1];
                File.Copy(file, toDir + "\\" + fileName);
            }
        }
        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode curTn = _treeViewServ.SelectedNode;
                if (curTn == null) curTn = _treeViewLoc.SelectedNode;
                var parentPath = Directory.GetParent(curTn.Name).FullName;
                var spltPath = pathBuff.Split('\\');
                var nameObj = spltPath[spltPath.Length - 1];
                var spltName = nameObj.Split('.');
                var path = parentPath + '\\' + nameObj;
                if (spltName[spltName.Length - 1].ToLower() == "json")
                {
                    File.Move(pathBuff, checkCloneFile(path.Replace("." + spltName[spltName.Length - 1], "")));
                }
                else
                {
                    copyDir(pathBuff, checkCloneDir(path));
                    Directory.Delete(pathBuff, true);
                }
                loadTreeNode((curTn.Parent == null) ? curTn.TreeView.Nodes : curTn.Parent.Nodes, Directory.GetParent(curTn.Name).FullName);
                вставитьToolStripMenuItem.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            splitContainer4.Visible = !splitContainer4.Visible;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            updateView();
        }

        private void extOkBtn_Click(object sender, EventArgs e)
        {
            pathLoc = pathLocTb.Text;
            pathServ = pathServTb.Text;
            splitContainer4.Visible = false;
            updateView();
        }

        private void extCancelBtn_Click(object sender, EventArgs e)
        {
            pathLocTb.Text = pathLoc;
            pathServTb.Text = pathServ;
            splitContainer4.Visible = false;
        }

        private void defaultServBtn_Click(object sender, EventArgs e)
        {
            pathServTb.Text = "\\\\172.17.18.50\\Users\\Public\\AppClientTurbo\\v1.2\\Collection";
        }
        private void defaultLocBtn_Click(object sender, EventArgs e)
        {
            pathLocTb.Text = Directory.GetCurrentDirectory() + "\\Collection";
        }

        private void openFDServBtn_Click(object sender, EventArgs e)
        {
            if (folderBD.ShowDialog() == DialogResult.OK)
            {
                pathServTb.Text = folderBD.SelectedPath;
            }
        }

        private void openFDLocBtn_Click(object sender, EventArgs e)
        {
            if (folderBD.ShowDialog() == DialogResult.OK)
            {
                pathLocTb.Text = folderBD.SelectedPath;
            }
        }
        #endregion ФАЙЛОВЫЙ МЕНЕДЖЕР

    }
}

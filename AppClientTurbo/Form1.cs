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
            Init_FileExplorer(); //для файлового менеджера 
            timer1.Start();

            if (Properties.Settings.Default.adrServer!="")    tbAdrServer   .Text = Properties.Settings.Default.adrServer;
            if (Properties.Settings.Default.adrPort != "")    tbAdrPort     .Text = Properties.Settings.Default.adrPort;
            if (Properties.Settings.Default.methodBox != "")  comboBoxMethod.Text = Properties.Settings.Default.methodBox;
            if (Properties.Settings.Default.user != "")       tbUser        .Text = Properties.Settings.Default.user;
            if (Properties.Settings.Default.password != "")   tbPassword    .Text = Properties.Settings.Default.password;
            if (Properties.Settings.Default.Refs != "")       comboBoxRefs  .Text = Properties.Settings.Default.Refs;
            if (Properties.Settings.Default.dataReq != "")    fctbDataReq   .Text = Properties.Settings.Default.dataReq;
            if (Properties.Settings.Default.request != "")    tbRequest     .Text = Properties.Settings.Default.request;
            if (Properties.Settings.Default.preRequest != "") tbPreRequest  .Text = Properties.Settings.Default.preRequest;
            if ((Properties.Settings.Default.file != "")
              &&File.Exists(Properties.Settings.Default.file))tbJsonFile  .Text = Properties.Settings.Default.file; 
            
            loadCash();
        }
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.dataReq = fctbDataReq.Text;
            Properties.Settings.Default.preRequest = tbPreRequest.Text;
            Properties.Settings.Default.request = tbRequest.Text;
            Properties.Settings.Default.adrServer = tbAdrServer.Text;
            Properties.Settings.Default.adrPort = tbAdrPort.Text;
            Properties.Settings.Default.methodBox = comboBoxMethod.Text;
            Properties.Settings.Default.user = tbUser.Text;
            Properties.Settings.Default.password = tbPassword.Text;
            Properties.Settings.Default.Refs = comboBoxRefs.Text;
            Properties.Settings.Default.file = tbJsonFile.Text;
            
            #region для файлового менеджера
            Properties.Settings.Default.pathLocSv = pathLoc;
            Properties.Settings.Default.pathServSv = pathServ;
            if(Directory.Exists(pathTempBuff)) Directory.Delete(pathTempBuff, true);
            #endregion
            
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
                        if (comboBoxMethod.Text == "POST") req.method = Req.Method.POST;
                        else if (comboBoxMethod.Text == "GET") req.method = Req.Method.GET;
                        else if (comboBoxMethod.Text == "PUT") req.method = Req.Method.PUT;
                        else if (comboBoxMethod.Text == "DELETE") req.method = Req.Method.DELETE;
                        req.data = fctbDataReq.Text;
                        req.preRequest = tbPreRequest.Text;
                        req.request = tbRequest.Text;
                        req.content.Headers.Add("sessionID", sessionId);

                        fctbResponse.Text = await senderReq() + Environment.NewLine;
                    }
                }
                catch
                {
                    Off();
                    labelStatusCode.Text = "Status Code";
                    fctbResponse.Text="Пожалуйста авторизуйтесь!" + Environment.NewLine;
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
            pictBoxОбработкаЗапроса.BackColor = flag ? Color.White : Color.Yellow;

        }
        private void Clear_Click(object sender, EventArgs e)
        {
            fctbResponse.Clear();
            labelStatusCode.Text = "Status Code";
        }
        private async Task login()
        {
            req = new Req(Req.Method.POST, @"{""user"": """ + tbUser.Text + "\",\"password\":\"" + tbPassword.Text + ((checkBoxForce.Checked) ? "\",\"ForceLogin\":true}" : "\"}"),
                                       "/api/xcom/userauth/", "login", tbAdrServer.Text, tbAdrPort.Text);
            try
            {
                response = await req.postRequest();
                labelStatusCode.Text = "Status Code -" + (int)response.StatusCode + " " + response.StatusCode + "-";
                try
                {
                    sessionId = response.Headers.GetValues("sessionId").Last().ToString();
                    fctbResponse.Text="Успешная авторизация!" + Environment.NewLine;
                    pictBoxOff.BackColor = Color.White;
                    pictBoxOn.BackColor = Color.Lime;
                    checkBoxForce.Visible = false;
                    checkBoxForce.Checked = false;
                    if (timeWithoutClick)
                    {
                        timeWithoutClick = false;
                    }
                    myTime = 0;
                    btnUseraut.Text = "Выход";
                }
                catch
                {
                    fctbResponse.Text="Не Авторизован!" + Environment.NewLine;
                    fctbResponse.AppendText(await response.Content.ReadAsStringAsync() + Environment.NewLine);
                    checkBoxForce.Visible = (response.StatusCode != System.Net.HttpStatusCode.Unauthorized);
                    Off();
                }
            }
            catch
            {
                fctbResponse.Text="Проверьте адрес и порт сервера!" + Environment.NewLine;
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
                    fctbResponse.Text=await senderReq() + Environment.NewLine;
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
                    btnUseraut.Text = "Вход";
                    return "Сессия завершена!";
                }
                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized) {
                    Off();
                    btnUseraut.Text = "Вход";
                    return "Не Авторизован!"; }
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
            pictBoxOff.BackColor = Color.Red;
            pictBoxOn.BackColor = Color.White;
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
            Cash cash = cashList.listCash.Find(x => x.Name == comboBoxRefs.Text);
            if (cash == null)
                cashList.listCash.Add(new Cash(comboBoxRefs.Text, comboBoxMethod.Text, tbPreRequest.Text, tbRequest.Text, fctbDataReq.Text));
            else{ 
                cash.Method     = comboBoxMethod.Text; 
                cash.PreRequest = tbPreRequest.Text; 
                cash.Request    = tbRequest.Text; 
                cash.DataReq    = fctbDataReq.Text; 
            }
            if (cashList.save()) updateView();
            updateRef();
        }
        private void loadCash()
        {
            cashList = new CashList(tbJsonFile.Text);
            if (cashList.listCash != null) updateRef();
            if (cashList.result) updateView();
            tbJsonFile.Text = cashList.path;
        }
        private void updateRef()
        {
            comboBoxRefs.Items.Clear();
            foreach (var item in cashList.listCash)
            {
                comboBoxRefs.Items.Add(item.Name);
            }
            btnSaveCash.Enabled = false;
            btnDeleteCash.Enabled = true;
        }

        private void Refs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cash cash = cashList.listCash.Find(x => x.Name == comboBoxRefs.Text);
                if (cash == null) { cash = cashList.listCash[0]; comboBoxRefs.Text = cash.Name; }
                comboBoxMethod.Text = cash.Method;
                tbPreRequest.Text = cash.PreRequest;
                tbRequest.Text = cash.Request;
                fctbDataReq.Text = cash.DataReq;
                btnSaveCash.Enabled = false;
                btnDeleteCash.Enabled = true;
            }
            catch{}
        }

        private void request_TextChanged(object sender, EventArgs e)
        {
            btnSaveCash.Enabled = true;
            btnDeleteCash.Enabled = false;
        }
        private void dataReqFctb_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            btnSaveCash.Enabled = true;
            btnDeleteCash.Enabled = false;
        }
        private void Refs_TextChanged(object sender, EventArgs e)
        {
            btnSaveCash.Enabled = true;
            btnDeleteCash.Enabled = false;
        }

        private void deleteCash_Click(object sender, EventArgs e)
        {
            new Form2(cashList.listCash,"Вы действительно хотите удалить запись из списка?",comboBoxRefs.Text).ShowDialog();
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
            try
            {
                loadCash();
            Refs_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// ФАЙЛОВЫЙ МЕНЕДЖЕР
        /// </summary>
        #region ФАЙЛОВЫЙ МЕНЕДЖЕР
        ImageList _imageList = new ImageList();
        // как будто константы
        string cPathLoc = Directory.GetCurrentDirectory() + "\\Collections";
        const string cPathServ = "\\\\172.17.18.50\\Users\\Public\\AppClientTurbo\\Collections";
        //переменные
        string pathLoc;
        string pathServ;
        string pathBuff;
        string pathTempBuff = Directory.GetCurrentDirectory() + "\\TempBuff";
        void Init_FileExplorer()
        {
            try
            {
                loadPicture();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }try
            {
                updatePath();
                updateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }
        void loadPicture() //подружаем иконки
        {
            string placeSource = "source\\image\\";
            _imageList.Images.Add(Image.FromFile(placeSource + "folder.ico"));
            _imageList.Images.Add(Image.FromFile(placeSource + "original.png"));
            _imageList.Images.Add(Image.FromFile(placeSource + "arrow.png"));
            _imageList.Images.Add(Image.FromFile(placeSource + "plus.png"));
            treeViewLoc.ImageList = _imageList;
            treeViewServ.ImageList = _imageList;
            treeViewLoc.SelectedImageIndex = 2;
            treeViewServ.SelectedImageIndex = 2;
        }
        void updatePath()
        {
            //добавляем 2 корневые папки
            if (Properties.Settings.Default.pathLocSv != "")
                pathLoc = Properties.Settings.Default.pathLocSv;
            else
                pathLoc = cPathLoc;
            if (!Directory.Exists(pathLoc)) Directory.CreateDirectory(pathLoc);


            if (Properties.Settings.Default.pathServSv != "")
                pathServ = Properties.Settings.Default.pathServSv;
            else
                pathServ = cPathServ;

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
            tbPathLoc.Text = pathLoc;
            tbPathServ.Text = pathServ;
        }
        void updateView()
        {
            loadTreeNode(treeViewLoc.Nodes, pathLoc);
            loadTreeNode(treeViewServ.Nodes, pathServ);
            try
            {
                treeViewLoc.Enabled = true;
                _treeView_NodeMouseClick(treeViewLoc,
                    new TreeNodeMouseClickEventArgs(treeViewLoc.Nodes[0], MouseButtons.Left, 1, 80, 5));
            }
            catch { treeViewLoc.Enabled = false; }
            try
            {
                treeViewServ.Enabled = true;
                _treeView_NodeMouseClick(treeViewServ,
                     new TreeNodeMouseClickEventArgs(treeViewServ.Nodes[0], MouseButtons.Left, 1, 80, 5));
                treeViewLoc.SelectedNode = null;
            }
            catch
            {
                treeViewServ.Enabled = false;
            }
        }
        private void _listView_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection ic = listView.SelectedItems;
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
            listView.Items.Clear();
            setFiles(file);
        }
        void setFilesToListFromDir(string path)
        {
            listView.Items.Clear();
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
                listView.Items.Add(name[0]).SubItems.AddRange(row);

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
            }
            else
            {
                listView.Items.Clear();
            }
            bool flag = curTn.ImageIndex == 0 || curTn.ImageIndex == 1;
            toolStripMenuItemВырезать.Enabled = flag;
            toolStripMenuItemКопировать.Enabled = flag;
            toolStripMenuItemПереименовать.Enabled = flag;
            toolStripMenuItemУдалить.Enabled = flag;
        }

        private void _treeViewServ_MouseUp(object sender, MouseEventArgs e)
        {
            treeViewLoc.SelectedNode = null;
            if (!NodeClick)
            {
                try
                {
                    _treeView_NodeMouseClick(treeViewServ,
                    new TreeNodeMouseClickEventArgs(treeViewServ.Nodes[0], MouseButtons.Left, 1, 80, 5));
                }
                catch
                {
                }
            }
            NodeClick = false;
        }

        private void _treeViewLoc_MouseUp(object sender, MouseEventArgs e)
        {
            treeViewServ.SelectedNode = null;
            if (!NodeClick)
            {
                try
                {
                    _treeView_NodeMouseClick(treeViewLoc,
                new TreeNodeMouseClickEventArgs(treeViewLoc.Nodes[0], MouseButtons.Left, 1, 80, 5));
                }
                catch
                {

                }
            }
            NodeClick = false;
        }

        private void _treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (((TreeView)sender).SelectedNode.ImageIndex == 1)
            {
                var curFile = ((TreeView)sender).SelectedNode.Name;
                if (File.Exists(curFile))
                {
                    tbJsonFile.Text = curFile;
                }
                else
                {
                    MessageBox.Show("Файла " + curFile + " не существует!");
                    updateView();
                }
            }
            NodeClick = true;
        }

        private void каталогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeContextMenu = 0;
            panelИмя.Visible = true;
            tbName.Text = "";
            tbName.Focus();
        }
        private void коллекциюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeContextMenu = 1;
            panelИмя.Visible = true;
            tbName.Text = "";
            tbName.Focus();
        }
        private void ПереименоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeContextMenu = 2;
            TreeNode curTn = treeViewServ.SelectedNode;
            if (curTn == null) curTn = treeViewLoc.SelectedNode;
            if (!(curTn.ImageIndex == 0 || curTn.ImageIndex == 1)) return;
            panelИмя.Visible = true;
            tbName.Text = curTn.Text;
            tbName.Focus();
        }
        private void nameTb_Leave(object sender, EventArgs e)
        {
            panelИмя.Visible = false;
            if (tbName.Text.Replace(" ", "") == "") return;//Если мы оставили Имя пустым - ничего не делаем
            TreeNode curTn = treeViewServ.SelectedNode;
            if (curTn == null) curTn = treeViewLoc.SelectedNode;
            var parentPath = Directory.GetParent(curTn.Name).FullName;
            var path = parentPath + '\\' + tbName.Text;
            if (TypeContextMenu == 0)//создать каталог
            {
                path = checkCloneDir(path);
                Directory.CreateDirectory(path);

            }
            else if (TypeContextMenu == 1)//создать файл
            {
                path = checkCloneFile(path);
                var fs = File.Create(path);
                fs.Close();
            }
            else if (TypeContextMenu == 2) //Переименовать
            {
                if (tbName.Text == curTn.Text) return;
                if (tbName.Text.ToLower() == curTn.Text.ToLower())
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
                        File.Move(temp, path+".json");
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
                TreeNode curTn = treeViewServ.SelectedNode;
                if (curTn == null) curTn = treeViewLoc.SelectedNode;
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
                TreeNode curTn = treeViewServ.SelectedNode;
                if (curTn == null) curTn = treeViewLoc.SelectedNode;
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
                TreeNode curTn = treeViewServ.SelectedNode;
                if (curTn == null) curTn = treeViewLoc.SelectedNode;
                ToCopyMove(curTn, true);
                toolStripMenuItemВставить.Enabled = true;
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
                TreeNode curTn = treeViewServ.SelectedNode;
                if (curTn == null) curTn = treeViewLoc.SelectedNode;
                ToCopyMove(curTn);
                toolStripMenuItemВставить.Enabled = true;
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
                TreeNode curTn = treeViewServ.SelectedNode;
                if (curTn == null) curTn = treeViewLoc.SelectedNode;
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
                toolStripMenuItemВставить.Enabled = false;
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
            pathLoc = tbPathLoc.Text;
            pathServ = tbPathServ.Text;
            splitContainer4.Visible = false;
            updateView();
        }

        private void extCancelBtn_Click(object sender, EventArgs e)
        {
            tbPathLoc.Text = pathLoc;
            tbPathServ.Text = pathServ;
            splitContainer4.Visible = false;
        }

        private void defaultServBtn_Click(object sender, EventArgs e)
        {
            tbPathServ.Text = cPathServ;
        }
        private void defaultLocBtn_Click(object sender, EventArgs e)
        {
            tbPathLoc.Text = cPathLoc;
        }

        private void openFDServBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbPathServ.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void openFDLocBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbPathLoc.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        #endregion ФАЙЛОВЫЙ МЕНЕДЖЕР

    }
}

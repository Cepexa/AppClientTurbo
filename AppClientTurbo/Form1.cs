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
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace AppClientTurbo
{
    
    public partial class Form1 : Form
    {
        Info infoThis = new Info("AppClientTurbo","v3.0");
        Info infoUpdate;
        DialogResult updateNow;

        Req req;
        int myTime = -1;
        HttpResponseMessage response;
        string sessionId=null;
        CashList cashList;
        CancellationTokenSource cts;
        CancellationToken token;
        private ListViewColumnSorter lvwColumnSorter;
        public Form1()
        { 
            InitializeComponent();
            Init_FileExplorer(); //для файлового менеджера 
            timer1.Start();
            var psd = Properties.Settings.Default; 
            if  (psd.adrServer != "")  tbAdrServer   .Text = psd.adrServer;
            if  (psd.adrPort != "")    tbAdrPort     .Text = psd.adrPort;
            if  (psd.user != "")       tbUser        .Text = psd.user;
            if  (psd.password != "")   tbPassword    .Text = psd.password;
            
            loadCash();

            lvwColumnSorter = new ListViewColumnSorter();
            this.listView.ListViewItemSorter = lvwColumnSorter;
            loadTabControl();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = $"{infoThis.NameClient} {infoThis.Version}";
            updateClient();
            loadTabControl_LoadForm();

        }
        string pathUpdate = @"\\172.17.18.50\Users\Public\AppClientTurbo\Update";
        string pathExeUpdate = Directory.GetCurrentDirectory() + @"\Update.exe";
        void updateClient()
        {
            
            string pathUpdateInfo = pathUpdate + @"\info.json";
            if (File.Exists(pathUpdateInfo))
            {
                infoUpdate = JsonConvert.DeserializeObject<Info>(File.ReadAllText(pathUpdateInfo));
                if (infoUpdate.Version != infoThis.Version)
                {
                    updateNow = new Form2($"Доступна версия {infoUpdate.Version}, \nХотите обновить сейчас?", "Обновить", "позже...", $"Обновление {infoUpdate.NameClient}").ShowDialog();
                    if (updateNow == DialogResult.Yes) {
                        this.Close();
                    }
                }
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (updateNow == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(pathExeUpdate);
                return;
            }

            var psd = Properties.Settings.Default;

            psd.adrServer = tbAdrServer.Text;
            psd.adrPort = tbAdrPort.Text;
            psd.user = tbUser.Text;
            psd.password = tbPassword.Text;

            #region для файлового менеджера
            psd.pathLocSv = pathLoc;
            psd.pathServSv = pathServ;
            if (Directory.Exists(pathTempBuff)) Directory.Delete(pathTempBuff, true);
            #endregion

            psd.Save();
            saveListPagesFormClosed();
        }
        static bool canClick = true;
        private async void send_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                try
                {
                    if (sessionId == null) throw new Exception("SessionId empty");
                    setVisibility(false, true);
                    myTime = 0;
                    {
                        if      (comboBoxMethod.Text == "POST")   req.method = Req.Method.POST;
                        else if (comboBoxMethod.Text == "GET")    req.method = Req.Method.GET;
                        else if (comboBoxMethod.Text == "PUT")    req.method = Req.Method.PUT;
                        else if (comboBoxMethod.Text == "DELETE") req.method = Req.Method.DELETE;
                        req.preRequest = tbPreRequest.Text;
                        req.request    = tbRequest.Text;
                        req.data       = fctbDataReq.Text;
                        req.content.Headers.Add("sessionID", sessionId);

                        var txtResponce = await senderReq();
                        if (!token.IsCancellationRequested)
                        fctbResponse.Text = txtResponce + Environment.NewLine;
                    }
                }
                catch
                {
                    sessionId = null;
                    labelStatusCode.Text = "Status Code";
                    fctbResponse   .Text = "Пожалуйста авторизуйтесь!" + Environment.NewLine;
                }
                setVisibility(true,true);
            }
        }
        private async Task Вход_Выход()
        {
            if (canClick){
                pictBoxВход.Image = (sessionId == null) ? Properties.Resources.btnRedOnTest : Properties.Resources.btnGreenOnTest;
                myTime = -1;
                setVisibility(false);
                if (sessionId == null) await login(); else await logout();
                setVisibility(true);
            }
        }
        private async void Выход(object sender, EventArgs e)
        {
            pictBoxВход.Image = (sessionId == null) ? Properties.Resources.btnRedOnTest : Properties.Resources.btnGreenOnTest;
            await logout();
            pictBoxВход.Image = (sessionId == null) ? Properties.Resources.btnRedOff : Properties.Resources.btnGreenOff;

        }

        CancellationTokenSource cts2;
        CancellationToken token2;
        bool  helpОбрЗапроса(Bitmap bm)
        {
            pictBoxОбработкаЗапроса.Image = bm;
            Thread.Sleep(30);
            return token2.IsCancellationRequested;
        }
        void ОбработкаЗапроса()
        {
            while (!token2.IsCancellationRequested)
            {
                if (helpОбрЗапроса(Properties.Resources._60)) return;
                if (helpОбрЗапроса(Properties.Resources._90)) return;
                if (helpОбрЗапроса(Properties.Resources._120)) return;
                if (helpОбрЗапроса(Properties.Resources._150)) return;
                if (helpОбрЗапроса(Properties.Resources._180)) return;
                if (helpОбрЗапроса(Properties.Resources._210)) return;
                if (helpОбрЗапроса(Properties.Resources._240)) return;
                if (helpОбрЗапроса(Properties.Resources._270)) return;
                if (helpОбрЗапроса(Properties.Resources._300)) return;
                if (helpОбрЗапроса(Properties.Resources._330)) return;
                if (helpОбрЗапроса(Properties.Resources._360)) return;
                if (helpОбрЗапроса(Properties.Resources._30)) return;
            }
        }

        void setVisibility(bool flag,bool usualReq = false)
        {
            canClick = flag;
            labelОбработкаЗапроса.Visible = !flag;
            pictBoxОбработкаЗапроса.Visible = !flag;
            if (!flag)
            {
                cts2 = new CancellationTokenSource();
                token2 = cts2.Token;
                Task.Run(() => ОбработкаЗапроса());
            }
            else
            {
                cts2?.Cancel();
                pictBoxВход.Image = (sessionId == null) ? Properties.Resources.btnRedOff : Properties.Resources.btnGreenOff;
            }
            if (usualReq)
            {
                comboBoxRefs.Enabled = flag;
                linkLabel1.Visible = !flag;
                splitContainer2.Panel1.Enabled = flag;
                tabControl1.Enabled = flag;
            }
            else
            {
                tbPassword.Enabled = flag;
                tbAdrServer.Enabled = flag;
                tbAdrPort.Enabled = flag;
                tbUser.Enabled = flag;
            }
        }
        private void linkLabel1_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            setVisibility(true, true);
        }
        private async Task login()
        {
            req = new Req(Req.Method.POST, tbAdrServer.Text, tbAdrPort.Text, "/api/xcom/userauth/", "login",
                          @"{""user"": """ + tbUser.Text + "\",\"password\":\"" + tbPassword.Text + ((checkBoxForce.Checked) ? "\",\"ForceLogin\":true}" : "\"}"));
            try
            {
                cts = new CancellationTokenSource();
                token = cts.Token;
                response = await req.makeRequest(token);
                labelStatusCode.Text = "Status Code -" + (int)response.StatusCode + " " + response.StatusCode + "-";
                try
                {
                    sessionId = response.Headers.GetValues("sessionId").Last().ToString();
                    fctbResponse.Text="Успешная авторизация!" + Environment.NewLine;
                    checkBoxForce.Visible = false;
                    checkBoxForce.Checked = false;
                    if (timeWithoutClick)
                    {
                        timeWithoutClick = false;
                    }
                    myTime = 0;
                    pictBoxВход.Image = Properties.Resources.btnGreenOff;
                }
                catch
                {
                    fctbResponse.Text="Не Авторизован!" + Environment.NewLine;
                    fctbResponse.AppendText(await response.Content.ReadAsStringAsync() + Environment.NewLine);
                    checkBoxForce.Visible = (response.StatusCode != System.Net.HttpStatusCode.Unauthorized);
                    sessionId = null;
                }
            }
            catch
            {
                fctbResponse.Text="Проверьте адрес и порт сервера!" + Environment.NewLine;
                labelStatusCode.Text = "Status Code";
                sessionId = null;
            }
        }

        static bool canClickLogout = true;
        private async Task logout()
        {
            if (canClickLogout)
            {
                canClickLogout = false;
                myTime = -1;
                if (sessionId != null)
                {
                    req.method        = Req.Method.POST;
                    req.preRequest    = "/api/xcom/userAuth/";
                    req.request       = "logout";
                    req.data          = "";
                    req.content.Headers.Add("sessionID", sessionId);
                    fctbResponse.Text = await senderReq() + Environment.NewLine;
                    pictBoxВход.Image = Properties.Resources.btnRedOff;
                }
                canClickLogout = true;
            }
        }
        async Task<string> senderReq()
        {
            try
            {
                cts = new CancellationTokenSource();
                token = cts.Token;
                response = await req.makeRequest(token);
                labelStatusCode.Text = "Status Code -" + (int)response.StatusCode+" " + response.StatusCode + "-";
                if (((req.preRequest + req.request).ToLower() == "/api/xcom/userauth/logout") && response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    sessionId = null;
                    return "Сессия завершена!";
                }
                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized) {
                    sessionId = null;
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
        private void pictBoxClear_Click(object sender, EventArgs e)
        {
            fctbResponse.Clear();
            labelStatusCode.Text = "Status Code";
        }

        bool timeWithoutClick = false;
        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (myTime != -1) {
                if (++myTime > 20000) 
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
        private void deleteCash_Click(object sender, EventArgs e)
        {
            var dialogResult = new Form2("Вы действительно хотите удалить запись из списка?").ShowDialog();
            if (dialogResult == DialogResult.Yes) cashList.delete(comboBoxRefs.Text);
            Refs_SelectedIndexChanged(sender, e);
            updateRef();
        }
        private void loadCash()
        {
            var temp = tbJsonFile.Text;
            cashList = new CashList(temp);
            if (cashList.listCash != null) updateRef();
            if (cashList.result) updateView();
            tbJsonFile.Text = cashList.path;
            if(temp != tbJsonFile.Text)
                grBЗапросыВКоллекции.Text = "Запросы в коллекции \"" + tbJsonFile.Text + "\"";
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
            if ((listPages != null) && (!switchingPage))
            {
                listPages[tabControl1.SelectedIndex].BoolSave = btnSaveCash.Enabled;
            }
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
                if ((listPages != null)&& (!switchingPage))
                {
                    tabControl1.SelectedTab.Text = comboBoxRefs.Text;
                    listPages[tabControl1.SelectedIndex].Header = comboBoxRefs.Text;
                    listPages[tabControl1.SelectedIndex].BoolSave = btnSaveCash.Enabled;
                }
            }
            catch{}
        }
        private void comboBoxRefs_Leave(object sender, EventArgs e)
        {
            if ((listPages != null) && (!switchingPage))
            {
                tabControl1.SelectedTab.Text = comboBoxRefs.Text;
                listPages[tabControl1.SelectedIndex].Header = comboBoxRefs.Text;
                listPages[tabControl1.SelectedIndex].BoolSave = btnSaveCash.Enabled;
            }
        }
        private void request_TextChanged(object sender, EventArgs e)
        {
            btnSaveCash.Enabled = true;
            btnDeleteCash.Enabled = false;
            if ((listPages != null)&& (!switchingPage))
            {
                listPages[tabControl1.SelectedIndex].Prefix = tbPreRequest.Text;
                listPages[tabControl1.SelectedIndex].Request = tbRequest.Text;
                listPages[tabControl1.SelectedIndex].DataReq = fctbDataReq.Text;
                listPages[tabControl1.SelectedIndex].Header = comboBoxRefs.Text;
                listPages[tabControl1.SelectedIndex].BoolSave = btnSaveCash.Enabled;
            }
        }


        private void Form1_Activated(object sender, EventArgs e)
        {
            if (timeWithoutClick) Вход_Выход();
        }
        private void jsonFile_TextChanged(object sender, EventArgs e)
        {
            try
            {
                loadCash();
                Refs_SelectedIndexChanged(sender, e);
                if ((listPages != null) && (!switchingPage))
                    listPages[tabControl1.SelectedIndex].FullPath = tbJsonFile.Text;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBoxMethod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        /// <summary>
        /// ФАЙЛОВЫЙ МЕНЕДЖЕР
        /// </summary>
        #region ФАЙЛОВЫЙ МЕНЕДЖЕР
        ImageList _imageList = new ImageList();
        // как будто константы
        string cPathLoc = Directory.GetCurrentDirectory() + @"\Collections";
        const string cPathServ = @"\\172.17.18.50\Users\Public\AppClientTurbo\Collections";
        //переменные
        bool IsServ;
        string pathLoc;
        string pathServ;
        string pathBuff;
        string pathTempBuff = Directory.GetCurrentDirectory() + @"\TempBuff";
        TreeNode lastServNode;
        TreeNode lastLocNode;
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
            string placeSource = @"source\image\";
            _imageList.Images.Add(Image.FromFile(placeSource + "folder.ico"));
            _imageList.Images.Add(Image.FromFile(placeSource + "original.ico"));
            _imageList.Images.Add(Image.FromFile(placeSource + "arrow.ico"));
            _imageList.Images.Add(Image.FromFile(placeSource + "plus.ico"));
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
        void loadTreeNode(TreeNodeCollection tnc, string path)
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
                }
                foreach (string file in files)
                {
                    string[] splited = file.Split('\\');
                    string fileName = splited[splited.Length - 1];
                    var ext = fileName.Split('.');
                    if (ext[ext.Length - 1].ToLower() == "json")
                    {
                        TreeNode curTn = tnc.Add(fileName.Remove(fileName.Length-5));
                        curTn.ImageIndex = 1;
                        curTn.Name = file;
                    }
                }
                if (tnc.Count == 0)
                {
                    TreeNode curTn = tnc.Add("Нет данных");
                    curTn.ImageIndex = 3;
                    curTn.Name = path + @"\Нет данных";
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
            var dirs = Directory.GetDirectories(path);
            var files = Directory.GetFiles(path);

            foreach (var dir in dirs)
            {
                setDir(dir);
            }
            foreach (var dir in files)
            {
                setFiles(dir);
            }
        }
        void setDir(string file)
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(file);
                string name = d.Name;
                string[] row = { "", "каталог", file };
                listView.Items.Add(name).SubItems.AddRange(row);
            }
            catch (Exception)
            {
                updateView();
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
            if (curTn.TreeView == treeViewLoc) lastLocNode = curTn;
            if (curTn.TreeView == treeViewServ) lastServNode = curTn;
            ((TreeView)sender).SelectedNode = curTn;
            if (curTn.ImageIndex == 0)
            {
                setFilesToListFromDir(curTn.Name);
                grBСодержимое.Text = "Содержимое \"" + curTn.Text + "\"";
            }
            else if (curTn.ImageIndex == 1)
            {
                setFilesOnce(curTn.Name);
                grBСодержимое.Text = "Содержимое \"" + curTn.Text + "\"";
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
            if (!NodeClick) treeViewServ.SelectedNode = (lastServNode == null) ? treeViewServ.TopNode : lastServNode;
            NodeClick = false;
        }
        private void _treeViewLoc_MouseUp(object sender, MouseEventArgs e)
        {
            treeViewServ.SelectedNode = null;
            if (!NodeClick) treeViewLoc.SelectedNode = (lastLocNode == null) ? treeViewLoc.TopNode : lastLocNode;
            NodeClick = false;
        }

        private void _treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var curTn = ((TreeView)sender).SelectedNode;
            if (curTn.ImageIndex == 1)
            {
                addPage();
                var selectPage = listPages.Count - 1;
                tabControl1.TabPages.Insert(selectPage, listPages[selectPage].Header);
                tabControl1.SelectedIndex = selectPage;
                var curFile = curTn.Name;
                if (File.Exists(curFile))
                {
                    tbJsonFile.Text = curFile;
                    grBЗапросыВКоллекции.Text = "Запросы в коллекции \"" + curTn.Text + "\"";
                }
                else
                {
                    MessageBox.Show("Файла " + curFile + " не существует!");
                    updateView();
                }
            }
            else if (curTn.ImageIndex == 3)
            {
                contextMenuStrip1.Show(curTn.TreeView,e.Location);
            }
            NodeClick = true;
        }
        TreeNode curTnName;
        private void каталогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeContextMenu = 0;
            curTnName = treeViewServ.SelectedNode;
            IsServ = curTnName != null;
            if (!IsServ) curTnName = treeViewLoc.SelectedNode;
            panelИмя.Visible = true;
            tbName.Text = "";
            tbName.Focus();
        }
        private void коллекциюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeContextMenu = 1;
            curTnName = treeViewServ.SelectedNode;
            IsServ = curTnName != null;
            if (!IsServ) curTnName = treeViewLoc.SelectedNode;
            panelИмя.Visible = true;
            tbName.Text = "";
            tbName.Focus();
        }
        private void ПереименоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeContextMenu = 2;
            curTnName = treeViewServ.SelectedNode;
            IsServ = curTnName != null;
            if (!IsServ) curTnName = treeViewLoc.SelectedNode;
            if (!(curTnName.ImageIndex == 0 || curTnName.ImageIndex == 1)) return;
            panelИмя.Visible = true;
            tbName.Text = curTnName.Text;
            tbName.Focus();
        }
        private void nameTb_Leave(object sender, EventArgs e)
        {
            panelИмя.Visible = false;
            if (tbName.Text.Replace(" ", "") == "") return;//Если мы оставили Имя пустым - ничего не делаем
            var parentPath = Directory.GetParent(curTnName.Name).FullName;
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
                if (tbName.Text == curTnName.Text) return;
                if (tbName.Text.ToLower() == curTnName.Text.ToLower())
                {
                    if (curTnName.ImageIndex == 0)
                    {
                        var temp = checkCloneDir(path);
                        Directory.Move(curTnName.Name, temp);
                        Directory.Move(temp, path);
                    }
                    else if (curTnName.ImageIndex == 1)
                    {
                        var temp = checkCloneFile(path);
                        File.Move(curTnName.Name, temp);
                        path += ".json";
                        File.Move(temp, path);
                    }
                }
                else
                {
                    if (curTnName.ImageIndex == 0)
                    {
                        path = checkCloneDir(path);
                        Directory.Move(curTnName.Name, path);
                    }
                    else if (curTnName.ImageIndex == 1)
                    {
                        path = checkCloneFile(path);
                        File.Move(curTnName.Name, path);
                    }
                }
                if (curTnName.Name == tbJsonFile.Text)
                {
                    tbJsonFile.Text = path;
                    grBЗапросыВКоллекции.Text = "Запросы в коллекции \"" + tbName.Text + "\"";
                }

            }
            loadTreeNode((curTnName.Parent == null) ? curTnName.TreeView.Nodes : curTnName.Parent.Nodes, parentPath);
            findCurrentNode(path);
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
                IsServ = curTn != null;
                if (!IsServ) curTn = treeViewLoc.SelectedNode;
                if (curTn.ImageIndex == 0) Directory.Delete(curTn.Name, true);
                else if (curTn.ImageIndex == 1) File.Delete(curTn.Name);
                else return;
                changeCurCollection(curTn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nameTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                curTnName.TreeView.Focus();
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
            if (IsMove) changeCurCollection(curTn);
        }
        void changeCurCollection(TreeNode curTn)
        {
            var newTn = (curTn.PrevNode != null && curTn.PrevNode.ImageIndex!=0) ? curTn.PrevNode : curTn.NextNode;
            var path = newTn?.Name;
            if ((curTn.Name == tbJsonFile.Text) && (newTn != null))
            {
                tbJsonFile.Text = path;
                grBЗапросыВКоллекции.Text = "Запросы в коллекции \"" + newTn.Text + "\"";
            }
            loadTreeNode((curTn.Parent == null) ? curTn.TreeView.Nodes : curTn.Parent.Nodes, Directory.GetParent(curTn.Name).FullName);
            if (path != null) findCurrentNode(path);
        }
        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsServ = true;
                TreeNode curTn = treeViewServ.SelectedNode;
                IsServ = curTn != null;
                if (!IsServ) curTn = treeViewLoc.SelectedNode;
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
                IsServ = curTn != null;
                if (!IsServ) curTn = treeViewLoc.SelectedNode;

                var parentPath = Directory.GetParent(curTn.Name).FullName;
                var spltPath = pathBuff.Split('\\');
                var nameObj = spltPath[spltPath.Length - 1];
                var spltName = nameObj.Split('.');
                var path = parentPath + '\\' + nameObj;
                if (spltName[spltName.Length - 1].ToLower() == "json")
                {
                    path = parentPath + '\\' + nameObj.Remove(nameObj.Length - 5);
                    path = checkCloneFile(path);
                    File.Copy(pathBuff, path);
                }
                else
                {
                    path = checkCloneDir(path);
                    copyDir(pathBuff, path);
                }
                loadTreeNode((curTn.Parent == null) ? curTn.TreeView.Nodes : curTn.Parent.Nodes, Directory.GetParent(curTn.Name).FullName);
                findCurrentNode(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void findCurrentNode(string path)
        {
            TreeView temp = (IsServ) ? treeViewServ : treeViewLoc;
            temp.SelectedNode = temp.Nodes.Find(path, true)[0];
            if (temp.SelectedNode?.ImageIndex == 0) temp.SelectedNode?.Expand();
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
      
        #region Подсказки
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = (char)0;
            pictureBoxVisblPswrd.Image = Properties.Resources.eye2;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '*';
            pictureBoxVisblPswrd.Image = Properties.Resources.eye1;
        }

        ToolTip tt = new ToolTip();
        private void pictureBoxVisblPswrd_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(this.pictureBoxVisblPswrd, "Показать пароль");
        }

        private void btnExt_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(this.btnExt, "Расширеные Настройки");
        }

        private void btnRefresh_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(this.btnRefresh, "Обновить Список");
        }

        private void pictBoxClear_MouseEnter(object sender, EventArgs e)
        {
            pictBoxClear.Image=Properties.Resources.clear2;
        }

        private void pictBoxClear_MouseLeave(object sender, EventArgs e)
        {
            pictBoxClear.Image=Properties.Resources.clear;
        }
        #endregion Подсказки

        #region Переброс курсора
        private void tbAdrServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbAdrPort.Focus();
        }

        private void tbAdrPort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbUser.Focus();
        }

        private void tbUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbPassword.Focus();
        }
        private void pictBoxВход_MouseDown(object sender, MouseEventArgs e)
        {
            if (canClick) pictBoxВход.Image = (sessionId == null) ? Properties.Resources.btnRedOnTest : Properties.Resources.btnGreenOnTest;
        }

        private void pictBoxВход_MouseUp(object sender, MouseEventArgs e)
        {
            if (canClick) pictBoxВход.Image = (sessionId == null) ? Properties.Resources.btnRedOff : Properties.Resources.btnGreenOff;
        }

        private async void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && canClick && canClickLogout)
            {
                await Вход_Выход();
                pictBoxВход.Focus();
            }
        }
        private async void pictBoxВход_Click(object sender, EventArgs e)
        {
            await Вход_Выход();
        }
        private void comboBoxRefs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbPreRequest.Focus();
        }
        private void tbPreRequest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbRequest.Focus();
        }
        private void tbRequest_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter)&& canClick)
            send_Click(sender, e);
        }
        
        #endregion

        #region сортировка колонок
        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            // Perform the sort with these new sort options.
            this.listView.Sort();
        }
        #endregion

        #region Система вкладок

        public List<EntityPage>  listPages;
        string pathSavePages = "cash.json";
        void loadTabControl()
        {
            this.tabControl1.TabPages[this.tabControl1.TabCount - 1].Text = "";
            this.tabControl1.Padding = new Point(12, 4);
            this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl1.HandleCreated += tabControl1_HandleCreated;
        }
        void loadTabControl_LoadForm()
        {
            if (File.Exists(pathSavePages))
                listPages = JsonConvert.DeserializeObject<List<EntityPage>>(File.ReadAllText(pathSavePages));
            else
                File.Create(pathSavePages).Close();

            if (listPages == null)
            {
                listPages = new List<EntityPage>(5);
                addPage();
            }
            else
            {
                this.tabControl1.TabPages[0].Text = listPages[0].Header;
                listPages[0].Response = "";
                for (int i = 1; i < listPages.Count; i++)
                {
                    this.tabControl1.TabPages.Insert(i, listPages[i].Header);
                    listPages[i].Response = "";
                }
                loadPage(0);
            }
        }
        void saveListPagesFormClosed()
        {
            string json = JsonConvert.SerializeObject(listPages, Formatting.Indented);
            if(!File.Exists(pathSavePages)) File.Create(pathSavePages).Close();
            File.WriteAllText(pathSavePages, json);
        }
        void addPage(bool includeResponse = false)
        {
            listPages.Add(new EntityPage(fullPath: tbJsonFile.Text,
                                         collection: grBЗапросыВКоллекции.Text,
                                         header: comboBoxRefs.Text,
                                         method: comboBoxMethod.Text,
                                         bSave: btnSaveCash.Enabled,
                                         prefix: tbPreRequest.Text,
                                         request: tbRequest.Text,
                                         dataReq: fctbDataReq.Text,
                                         response: (includeResponse)? fctbResponse.Text:""));
        }
        void loadPage(int index)
        {
            switchingPage = true;
            var curPage = listPages[index];
            tbJsonFile.Text = curPage.FullPath;
            comboBoxRefs.Text = curPage.Header;
            comboBoxMethod.Text = curPage.Method;
            tbPreRequest.Text = curPage.Prefix;
            tbRequest.Text = curPage.Request;
            fctbDataReq.Text = curPage.DataReq;
            fctbResponse.Text = curPage.Response;

            grBЗапросыВКоллекции.Text = curPage.Collection;
            btnSaveCash.Enabled = curPage.BoolSave;
            btnDeleteCash.Enabled = !curPage.BoolSave;
            switchingPage = false;
        }
        void closePage(int index)
        {
            listPages.RemoveAt(index);
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private const int TCM_SETMINTABWIDTH = 0x1300 + 49;
        private void tabControl1_HandleCreated(object sender, EventArgs e)
        {
            SendMessage(this.tabControl1.Handle, TCM_SETMINTABWIDTH, IntPtr.Zero, (IntPtr)16);
        }
        bool switchingPage = false;
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == this.tabControl1.TabCount - 1)
                e.Cancel = true;
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            loadPage(tabControl1.SelectedIndex);
        }
        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            var lastIndex = this.tabControl1.TabCount - 1;
            if (this.tabControl1.GetTabRect(lastIndex).Contains(e.Location))
            {
                addPage();
                this.tabControl1.TabPages.Insert(lastIndex, listPages[lastIndex].Header);
                this.tabControl1.SelectedIndex = lastIndex;
                //this.tabControl1.TabPages[lastIndex].UseVisualStyleBackColor = true;
            }
            else
            {
                for (var i = 0; i < this.tabControl1.TabPages.Count; i++)
                {
                    var tabRect = this.tabControl1.GetTabRect(i);
                    tabRect.Inflate(-2, -2);
                    var closeImage = Properties.Resources.Close;
                    var imageRect = new Rectangle(
                        (tabRect.Right - closeImage.Width),
                        tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                        closeImage.Width,
                        closeImage.Height);
                    if ((imageRect.Contains(e.Location)) && this.tabControl1.TabPages.Count > 2)
                    {
                        closePage(i);
                        this.tabControl1.TabPages.RemoveAt(i);
                        break;
                    }
                }
                
            }
        }
        
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if(e.Index == 0) 
            e.Graphics.FillRegion(new SolidBrush(SystemColors.ControlDarkDark), new Region());
            string text = tabControl1.TabPages[e.Index].Text;
            SizeF sz = e.Graphics.MeasureString(text, e.Font);
            bool bSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            using (SolidBrush b = new SolidBrush(bSelected ? SystemColors.GradientActiveCaption : SystemColors.Control))
                e.Graphics.FillRectangle(b, e.Bounds);
            if (tabControl1.SelectedIndex == e.Index) e.DrawFocusRectangle();
            var tabRect = this.tabControl1.GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);
            var image = (e.Index == this.tabControl1.TabCount - 1) ? Properties.Resources.Add : ((this.tabControl1.TabPages.Count > 2) ? Properties.Resources.Close:null);
            if (image!=null)
            e.Graphics.DrawImage(image,
                (tabRect.Right - image.Width),
                tabRect.Top + (tabRect.Height - image.Height) / 2);
            using (SolidBrush b = new SolidBrush(bSelected ? SystemColors.HighlightText : SystemColors.ControlText))
                e.Graphics.DrawString(text, e.Font, b, e.Bounds.X + 2, e.Bounds.Y + (e.Bounds.Height - sz.Height) / 2);

        }

        private void comboBoxMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSaveCash.Enabled = true;
            btnDeleteCash.Enabled = false;
            if ((listPages != null) && (!switchingPage))
            {
                listPages[tabControl1.SelectedIndex].Method = comboBoxMethod.Text;
                listPages[tabControl1.SelectedIndex].BoolSave = btnSaveCash.Enabled;
            }
        }

        private void fctbResponse_TextChangedDelayed(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if ((listPages != null) && (!switchingPage))
                listPages[tabControl1.SelectedIndex].Response = fctbResponse.Text;
        }

        private void grBЗапросыВКоллекции_TextChanged(object sender, EventArgs e)
        {
            if ((listPages != null) && (!switchingPage))
                listPages[tabControl1.SelectedIndex].Collection = grBЗапросыВКоллекции.Text;
        }


        #endregion Система вкладок

    }
}

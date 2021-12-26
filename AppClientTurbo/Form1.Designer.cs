﻿
namespace AppClientTurbo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelСервер = new System.Windows.Forms.Label();
            this.labelПорт = new System.Windows.Forms.Label();
            this.labelМетод = new System.Windows.Forms.Label();
            this.labelЗапрос = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPswrd = new System.Windows.Forms.Label();
            this.labelОбработкаЗапроса = new System.Windows.Forms.Label();
            this.labelКоллекции = new System.Windows.Forms.Label();
            this.labelПрефикс = new System.Windows.Forms.Label();
            this.labelStatusCode = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnUseraut = new System.Windows.Forms.Button();
            this.tbAdrServer = new System.Windows.Forms.TextBox();
            this.tbAdrPort = new System.Windows.Forms.TextBox();
            this.tbRequest = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grBOnOff = new System.Windows.Forms.GroupBox();
            this.pictBoxOff = new System.Windows.Forms.PictureBox();
            this.pictBoxOn = new System.Windows.Forms.PictureBox();
            this.checkBoxForce = new System.Windows.Forms.CheckBox();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.comboBoxRefs = new System.Windows.Forms.ComboBox();
            this.btnSaveCash = new System.Windows.Forms.Button();
            this.pictBoxОбработкаЗапроса = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grBДанныеЗапроса = new System.Windows.Forms.GroupBox();
            this.fctbDataReq = new FastColoredTextBoxNS.FastColoredTextBox();
            this.grBОтвет = new System.Windows.Forms.GroupBox();
            this.fctbResponse = new FastColoredTextBoxNS.FastColoredTextBox();
            this.btnDeleteCash = new System.Windows.Forms.Button();
            this.tbPreRequest = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panelИмя = new System.Windows.Forms.Panel();
            this.labelИмя = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panelКоллекции = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExt = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.grBОбщиеКоллекции = new System.Windows.Forms.GroupBox();
            this.treeViewServ = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemСоздать = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemКаталог = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemКоллекцию = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemВставить = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemВырезать = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemКопировать = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemПереименовать = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemУдалить = new System.Windows.Forms.ToolStripMenuItem();
            this.grBЛокальныеКоллекции = new System.Windows.Forms.GroupBox();
            this.treeViewLoc = new System.Windows.Forms.TreeView();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.grBСодержимое = new System.Windows.Forms.GroupBox();
            this.listView = new System.Windows.Forms.ListView();
            this.colHeaderFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderFullPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grBТекущаяКоллекция = new System.Windows.Forms.GroupBox();
            this.tbJsonFile = new System.Windows.Forms.TextBox();
            this.btnExtCancel = new System.Windows.Forms.Button();
            this.btnExtOk = new System.Windows.Forms.Button();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.grBНастройкаОбщихКоллекций = new System.Windows.Forms.GroupBox();
            this.btnOpenFDServ = new System.Windows.Forms.Button();
            this.btnDefaultServ = new System.Windows.Forms.Button();
            this.tbPathServ = new System.Windows.Forms.TextBox();
            this.labelПуть = new System.Windows.Forms.Label();
            this.grBНастройкаЛокальныхКоллекций = new System.Windows.Forms.GroupBox();
            this.btnOpenFDLoc = new System.Windows.Forms.Button();
            this.btnDefaultLoc = new System.Windows.Forms.Button();
            this.tbPathLoc = new System.Windows.Forms.TextBox();
            this.labelПуть2 = new System.Windows.Forms.Label();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.grBЗапросыВКоллекции = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.grBOnOff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxОбработкаЗапроса)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grBДанныеЗапроса.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbDataReq)).BeginInit();
            this.grBОтвет.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbResponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelИмя.SuspendLayout();
            this.panelКоллекции.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.grBОбщиеКоллекции.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.grBЛокальныеКоллекции.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.grBСодержимое.SuspendLayout();
            this.grBТекущаяКоллекция.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.grBНастройкаОбщихКоллекций.SuspendLayout();
            this.grBНастройкаЛокальныхКоллекций.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.grBЗапросыВКоллекции.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelСервер
            // 
            this.labelСервер.AutoSize = true;
            this.labelСервер.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelСервер.ForeColor = System.Drawing.Color.Linen;
            this.labelСервер.Location = new System.Drawing.Point(17, 23);
            this.labelСервер.Name = "labelСервер";
            this.labelСервер.Size = new System.Drawing.Size(65, 18);
            this.labelСервер.TabIndex = 4;
            this.labelСервер.Text = "Сервер";
            // 
            // labelПорт
            // 
            this.labelПорт.AutoSize = true;
            this.labelПорт.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelПорт.ForeColor = System.Drawing.Color.Linen;
            this.labelПорт.Location = new System.Drawing.Point(230, 23);
            this.labelПорт.Name = "labelПорт";
            this.labelПорт.Size = new System.Drawing.Size(47, 18);
            this.labelПорт.TabIndex = 5;
            this.labelПорт.Text = "Порт";
            // 
            // labelМетод
            // 
            this.labelМетод.AutoSize = true;
            this.labelМетод.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelМетод.ForeColor = System.Drawing.Color.Linen;
            this.labelМетод.Location = new System.Drawing.Point(26, 59);
            this.labelМетод.Name = "labelМетод";
            this.labelМетод.Size = new System.Drawing.Size(59, 18);
            this.labelМетод.TabIndex = 8;
            this.labelМетод.Text = "Метод";
            // 
            // labelЗапрос
            // 
            this.labelЗапрос.AutoSize = true;
            this.labelЗапрос.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelЗапрос.ForeColor = System.Drawing.Color.Linen;
            this.labelЗапрос.Location = new System.Drawing.Point(20, 117);
            this.labelЗапрос.Name = "labelЗапрос";
            this.labelЗапрос.Size = new System.Drawing.Size(65, 18);
            this.labelЗапрос.TabIndex = 15;
            this.labelЗапрос.Text = "Запрос";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.ForeColor = System.Drawing.Color.Linen;
            this.labelUser.Location = new System.Drawing.Point(127, 56);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(46, 18);
            this.labelUser.TabIndex = 18;
            this.labelUser.Text = "user:";
            // 
            // labelPswrd
            // 
            this.labelPswrd.AutoSize = true;
            this.labelPswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPswrd.ForeColor = System.Drawing.Color.Linen;
            this.labelPswrd.Location = new System.Drawing.Point(87, 84);
            this.labelPswrd.Name = "labelPswrd";
            this.labelPswrd.Size = new System.Drawing.Size(86, 18);
            this.labelPswrd.TabIndex = 19;
            this.labelPswrd.Text = "password:";
            // 
            // labelОбработкаЗапроса
            // 
            this.labelОбработкаЗапроса.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelОбработкаЗапроса.AutoSize = true;
            this.labelОбработкаЗапроса.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelОбработкаЗапроса.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.labelОбработкаЗапроса.ForeColor = System.Drawing.Color.Linen;
            this.labelОбработкаЗапроса.Location = new System.Drawing.Point(470, 17);
            this.labelОбработкаЗапроса.Name = "labelОбработкаЗапроса";
            this.labelОбработкаЗапроса.Size = new System.Drawing.Size(95, 36);
            this.labelОбработкаЗапроса.TabIndex = 27;
            this.labelОбработкаЗапроса.Text = "Обработка\r\nзапроса";
            this.labelОбработкаЗапроса.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelКоллекции
            // 
            this.labelКоллекции.AutoSize = true;
            this.labelКоллекции.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelКоллекции.Location = new System.Drawing.Point(11, 8);
            this.labelКоллекции.Name = "labelКоллекции";
            this.labelКоллекции.Size = new System.Drawing.Size(115, 24);
            this.labelКоллекции.TabIndex = 32;
            this.labelКоллекции.Text = "Коллекции";
            this.labelКоллекции.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelПрефикс
            // 
            this.labelПрефикс.AutoSize = true;
            this.labelПрефикс.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelПрефикс.ForeColor = System.Drawing.Color.Linen;
            this.labelПрефикс.Location = new System.Drawing.Point(6, 87);
            this.labelПрефикс.Name = "labelПрефикс";
            this.labelПрефикс.Size = new System.Drawing.Size(79, 18);
            this.labelПрефикс.TabIndex = 15;
            this.labelПрефикс.Text = "Префикс\r\n";
            // 
            // labelStatusCode
            // 
            this.labelStatusCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatusCode.AutoSize = true;
            this.labelStatusCode.ForeColor = System.Drawing.Color.Black;
            this.labelStatusCode.Location = new System.Drawing.Point(600, -3);
            this.labelStatusCode.Name = "labelStatusCode";
            this.labelStatusCode.Size = new System.Drawing.Size(109, 20);
            this.labelStatusCode.TabIndex = 33;
            this.labelStatusCode.Text = "Status Code";
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.LightSlateGray;
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUser.ForeColor = System.Drawing.Color.White;
            this.tbUser.Location = new System.Drawing.Point(173, 50);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(169, 26);
            this.tbUser.TabIndex = 0;
            this.tbUser.Text = "User01";
            this.tbUser.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.LightSlateGray;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(173, 80);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(169, 26);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // btnUseraut
            // 
            this.btnUseraut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUseraut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUseraut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUseraut.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUseraut.Location = new System.Drawing.Point(173, 112);
            this.btnUseraut.Name = "btnUseraut";
            this.btnUseraut.Size = new System.Drawing.Size(79, 37);
            this.btnUseraut.TabIndex = 2;
            this.btnUseraut.Text = "Вход";
            this.btnUseraut.UseVisualStyleBackColor = false;
            this.btnUseraut.Click += new System.EventHandler(this.userauth_Click);
            // 
            // tbAdrServer
            // 
            this.tbAdrServer.BackColor = System.Drawing.Color.LightSlateGray;
            this.tbAdrServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAdrServer.ForeColor = System.Drawing.Color.White;
            this.tbAdrServer.Location = new System.Drawing.Point(88, 19);
            this.tbAdrServer.MaxLength = 15;
            this.tbAdrServer.Name = "tbAdrServer";
            this.tbAdrServer.Size = new System.Drawing.Size(136, 26);
            this.tbAdrServer.TabIndex = 3;
            this.tbAdrServer.Text = "172.17.18.50";
            this.tbAdrServer.TextChanged += new System.EventHandler(this.adrServer_TextChanged);
            // 
            // tbAdrPort
            // 
            this.tbAdrPort.BackColor = System.Drawing.Color.LightSlateGray;
            this.tbAdrPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAdrPort.ForeColor = System.Drawing.Color.White;
            this.tbAdrPort.Location = new System.Drawing.Point(283, 19);
            this.tbAdrPort.MaxLength = 5;
            this.tbAdrPort.Name = "tbAdrPort";
            this.tbAdrPort.Size = new System.Drawing.Size(59, 26);
            this.tbAdrPort.TabIndex = 6;
            this.tbAdrPort.Text = "81";
            this.tbAdrPort.TextChanged += new System.EventHandler(this.adrPort_TextChanged);
            // 
            // tbRequest
            // 
            this.tbRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRequest.BackColor = System.Drawing.Color.LightSlateGray;
            this.tbRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRequest.ForeColor = System.Drawing.Color.White;
            this.tbRequest.Location = new System.Drawing.Point(91, 114);
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.Size = new System.Drawing.Size(376, 26);
            this.tbRequest.TabIndex = 10;
            this.tbRequest.Text = "Select";
            this.tbRequest.TextChanged += new System.EventHandler(this.request_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSend.Location = new System.Drawing.Point(473, 107);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(92, 34);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "Отправить\r\n";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.send_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.Location = new System.Drawing.Point(822, 291);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 31);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // grBOnOff
            // 
            this.grBOnOff.Controls.Add(this.pictBoxOff);
            this.grBOnOff.Controls.Add(this.pictBoxOn);
            this.grBOnOff.Controls.Add(this.checkBoxForce);
            this.grBOnOff.Controls.Add(this.labelСервер);
            this.grBOnOff.Controls.Add(this.btnUseraut);
            this.grBOnOff.Controls.Add(this.tbAdrPort);
            this.grBOnOff.Controls.Add(this.labelPswrd);
            this.grBOnOff.Controls.Add(this.tbAdrServer);
            this.grBOnOff.Controls.Add(this.labelПорт);
            this.grBOnOff.Controls.Add(this.tbUser);
            this.grBOnOff.Controls.Add(this.tbPassword);
            this.grBOnOff.Controls.Add(this.labelUser);
            this.grBOnOff.Dock = System.Windows.Forms.DockStyle.Right;
            this.grBOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.grBOnOff.ForeColor = System.Drawing.Color.Linen;
            this.grBOnOff.Location = new System.Drawing.Point(0, 0);
            this.grBOnOff.Name = "grBOnOff";
            this.grBOnOff.Size = new System.Drawing.Size(371, 160);
            this.grBOnOff.TabIndex = 20;
            this.grBOnOff.TabStop = false;
            this.grBOnOff.Text = "On/Off";
            // 
            // pictBoxOff
            // 
            this.pictBoxOff.BackColor = System.Drawing.Color.Red;
            this.pictBoxOff.Location = new System.Drawing.Point(292, 112);
            this.pictBoxOff.Name = "pictBoxOff";
            this.pictBoxOff.Size = new System.Drawing.Size(28, 29);
            this.pictBoxOff.TabIndex = 22;
            this.pictBoxOff.TabStop = false;
            // 
            // pictBoxOn
            // 
            this.pictBoxOn.BackColor = System.Drawing.Color.White;
            this.pictBoxOn.Location = new System.Drawing.Point(258, 112);
            this.pictBoxOn.Name = "pictBoxOn";
            this.pictBoxOn.Size = new System.Drawing.Size(28, 29);
            this.pictBoxOn.TabIndex = 21;
            this.pictBoxOn.TabStop = false;
            // 
            // checkBoxForce
            // 
            this.checkBoxForce.AutoSize = true;
            this.checkBoxForce.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxForce.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxForce.ForeColor = System.Drawing.Color.Linen;
            this.checkBoxForce.Location = new System.Drawing.Point(8, 110);
            this.checkBoxForce.Name = "checkBoxForce";
            this.checkBoxForce.Size = new System.Drawing.Size(159, 40);
            this.checkBoxForce.TabIndex = 28;
            this.checkBoxForce.Text = "Принудительный\r\nвход  ";
            this.checkBoxForce.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxForce.UseVisualStyleBackColor = true;
            this.checkBoxForce.Visible = false;
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.BackColor = System.Drawing.Color.LightSlateGray;
            this.comboBoxMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMethod.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "POST",
            "GET",
            "PUT",
            "DELETE"});
            this.comboBoxMethod.Location = new System.Drawing.Point(91, 56);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(76, 24);
            this.comboBoxMethod.TabIndex = 21;
            this.comboBoxMethod.Text = "POST";
            // 
            // comboBoxRefs
            // 
            this.comboBoxRefs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRefs.BackColor = System.Drawing.Color.LightSlateGray;
            this.comboBoxRefs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRefs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRefs.ForeColor = System.Drawing.Color.White;
            this.comboBoxRefs.FormattingEnabled = true;
            this.comboBoxRefs.Location = new System.Drawing.Point(6, 25);
            this.comboBoxRefs.Name = "comboBoxRefs";
            this.comboBoxRefs.Size = new System.Drawing.Size(461, 28);
            this.comboBoxRefs.TabIndex = 22;
            this.comboBoxRefs.Text = "-";
            this.comboBoxRefs.SelectedIndexChanged += new System.EventHandler(this.Refs_SelectedIndexChanged);
            this.comboBoxRefs.TextChanged += new System.EventHandler(this.Refs_TextChanged);
            // 
            // btnSaveCash
            // 
            this.btnSaveCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveCash.Enabled = false;
            this.btnSaveCash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveCash.ForeColor = System.Drawing.Color.Orange;
            this.btnSaveCash.Location = new System.Drawing.Point(329, 59);
            this.btnSaveCash.Name = "btnSaveCash";
            this.btnSaveCash.Size = new System.Drawing.Size(66, 22);
            this.btnSaveCash.TabIndex = 24;
            this.btnSaveCash.Text = "Save";
            this.btnSaveCash.UseVisualStyleBackColor = false;
            this.btnSaveCash.Click += new System.EventHandler(this.saveCash_Click);
            // 
            // pictBoxОбработкаЗапроса
            // 
            this.pictBoxОбработкаЗапроса.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBoxОбработкаЗапроса.BackColor = System.Drawing.Color.White;
            this.pictBoxОбработкаЗапроса.Location = new System.Drawing.Point(500, 54);
            this.pictBoxОбработкаЗапроса.Name = "pictBoxОбработкаЗапроса";
            this.pictBoxОбработкаЗапроса.Size = new System.Drawing.Size(31, 28);
            this.pictBoxОбработкаЗапроса.TabIndex = 26;
            this.pictBoxОбработкаЗапроса.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grBДанныеЗапроса);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grBОтвет);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(950, 516);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.TabIndex = 29;
            this.splitContainer1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseMove);
            // 
            // grBДанныеЗапроса
            // 
            this.grBДанныеЗапроса.Controls.Add(this.labelStatusCode);
            this.grBДанныеЗапроса.Controls.Add(this.fctbDataReq);
            this.grBДанныеЗапроса.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBДанныеЗапроса.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.grBДанныеЗапроса.ForeColor = System.Drawing.Color.Linen;
            this.grBДанныеЗапроса.Location = new System.Drawing.Point(0, 0);
            this.grBДанныеЗапроса.Name = "grBДанныеЗапроса";
            this.grBДанныеЗапроса.Size = new System.Drawing.Size(946, 160);
            this.grBДанныеЗапроса.TabIndex = 35;
            this.grBДанныеЗапроса.TabStop = false;
            this.grBДанныеЗапроса.Text = "Данные запроса";
            // 
            // fctbDataReq
            // 
            this.fctbDataReq.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbDataReq.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.fctbDataReq.AutoScrollMinSize = new System.Drawing.Size(31, 19);
            this.fctbDataReq.BackBrush = null;
            this.fctbDataReq.BackColor = System.Drawing.SystemColors.Info;
            this.fctbDataReq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctbDataReq.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fctbDataReq.CaretColor = System.Drawing.Color.Lime;
            this.fctbDataReq.CharHeight = 19;
            this.fctbDataReq.CharWidth = 10;
            this.fctbDataReq.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbDataReq.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbDataReq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctbDataReq.Font = new System.Drawing.Font("Courier New", 12.75F);
            this.fctbDataReq.ForeColor = System.Drawing.Color.Black;
            this.fctbDataReq.IndentBackColor = System.Drawing.Color.Gray;
            this.fctbDataReq.IsReplaceMode = false;
            this.fctbDataReq.Language = FastColoredTextBoxNS.Language.JSON;
            this.fctbDataReq.LeftBracket = '[';
            this.fctbDataReq.LeftBracket2 = '{';
            this.fctbDataReq.LineNumberColor = System.Drawing.Color.PaleTurquoise;
            this.fctbDataReq.Location = new System.Drawing.Point(3, 22);
            this.fctbDataReq.Name = "fctbDataReq";
            this.fctbDataReq.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbDataReq.RightBracket = ']';
            this.fctbDataReq.RightBracket2 = '}';
            this.fctbDataReq.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fctbDataReq.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbDataReq.ServiceColors")));
            this.fctbDataReq.Size = new System.Drawing.Size(940, 135);
            this.fctbDataReq.TabIndex = 34;
            this.fctbDataReq.Zoom = 100;
            this.fctbDataReq.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.dataReqFctb_TextChanged);
            this.fctbDataReq.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataReq_MouseMove);
            // 
            // grBОтвет
            // 
            this.grBОтвет.Controls.Add(this.btnClear);
            this.grBОтвет.Controls.Add(this.fctbResponse);
            this.grBОтвет.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBОтвет.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.grBОтвет.ForeColor = System.Drawing.Color.Linen;
            this.grBОтвет.Location = new System.Drawing.Point(0, 0);
            this.grBОтвет.Name = "grBОтвет";
            this.grBОтвет.Size = new System.Drawing.Size(946, 344);
            this.grBОтвет.TabIndex = 35;
            this.grBОтвет.TabStop = false;
            this.grBОтвет.Text = "Ответ";
            // 
            // fctbResponse
            // 
            this.fctbResponse.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbResponse.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.fctbResponse.AutoScrollMinSize = new System.Drawing.Size(31, 19);
            this.fctbResponse.BackBrush = null;
            this.fctbResponse.BackColor = System.Drawing.SystemColors.MenuBar;
            this.fctbResponse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctbResponse.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fctbResponse.CaretColor = System.Drawing.Color.Lime;
            this.fctbResponse.CharHeight = 19;
            this.fctbResponse.CharWidth = 10;
            this.fctbResponse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbResponse.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctbResponse.Font = new System.Drawing.Font("Courier New", 12.75F);
            this.fctbResponse.ForeColor = System.Drawing.Color.Black;
            this.fctbResponse.IndentBackColor = System.Drawing.Color.Gray;
            this.fctbResponse.IsReplaceMode = false;
            this.fctbResponse.Language = FastColoredTextBoxNS.Language.JSON;
            this.fctbResponse.LeftBracket = '[';
            this.fctbResponse.LeftBracket2 = '{';
            this.fctbResponse.LineNumberColor = System.Drawing.Color.Cyan;
            this.fctbResponse.Location = new System.Drawing.Point(3, 22);
            this.fctbResponse.Name = "fctbResponse";
            this.fctbResponse.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbResponse.ReadOnly = true;
            this.fctbResponse.RightBracket = ']';
            this.fctbResponse.RightBracket2 = '}';
            this.fctbResponse.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fctbResponse.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbResponse.ServiceColors")));
            this.fctbResponse.Size = new System.Drawing.Size(940, 319);
            this.fctbResponse.TabIndex = 34;
            this.fctbResponse.Zoom = 100;
            this.fctbResponse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.responseTxt_MouseMove);
            // 
            // btnDeleteCash
            // 
            this.btnDeleteCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteCash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteCash.ForeColor = System.Drawing.Color.Orange;
            this.btnDeleteCash.Location = new System.Drawing.Point(401, 59);
            this.btnDeleteCash.Name = "btnDeleteCash";
            this.btnDeleteCash.Size = new System.Drawing.Size(66, 22);
            this.btnDeleteCash.TabIndex = 24;
            this.btnDeleteCash.Text = "Delete";
            this.btnDeleteCash.UseVisualStyleBackColor = false;
            this.btnDeleteCash.Click += new System.EventHandler(this.deleteCash_Click);
            // 
            // tbPreRequest
            // 
            this.tbPreRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPreRequest.BackColor = System.Drawing.Color.LightSlateGray;
            this.tbPreRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPreRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPreRequest.ForeColor = System.Drawing.Color.White;
            this.tbPreRequest.Location = new System.Drawing.Point(91, 84);
            this.tbPreRequest.Name = "tbPreRequest";
            this.tbPreRequest.Size = new System.Drawing.Size(376, 26);
            this.tbPreRequest.TabIndex = 10;
            this.tbPreRequest.Text = "/api/xcom/RepairService/";
            this.tbPreRequest.TextChanged += new System.EventHandler(this.request_TextChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panelИмя);
            this.splitContainer2.Panel1.Controls.Add(this.panelКоллекции);
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel1MinSize = 200;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer7);
            this.splitContainer2.Panel2MinSize = 950;
            this.splitContainer2.Size = new System.Drawing.Size(1155, 680);
            this.splitContainer2.SplitterDistance = 201;
            this.splitContainer2.TabIndex = 33;
            // 
            // panelИмя
            // 
            this.panelИмя.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelИмя.Controls.Add(this.labelИмя);
            this.panelИмя.Controls.Add(this.tbName);
            this.panelИмя.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelИмя.Location = new System.Drawing.Point(0, 36);
            this.panelИмя.Name = "panelИмя";
            this.panelИмя.Size = new System.Drawing.Size(201, 34);
            this.panelИмя.TabIndex = 5;
            this.panelИмя.Visible = false;
            // 
            // labelИмя
            // 
            this.labelИмя.AutoSize = true;
            this.labelИмя.Location = new System.Drawing.Point(6, 7);
            this.labelИмя.Name = "labelИмя";
            this.labelИмя.Size = new System.Drawing.Size(29, 13);
            this.labelИмя.TabIndex = 1;
            this.labelИмя.Text = "Имя";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(41, 4);
            this.tbName.MaxLength = 32;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(154, 20);
            this.tbName.TabIndex = 0;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTb_KeyDown);
            this.tbName.Leave += new System.EventHandler(this.nameTb_Leave);
            // 
            // panelКоллекции
            // 
            this.panelКоллекции.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelКоллекции.Controls.Add(this.btnRefresh);
            this.panelКоллекции.Controls.Add(this.btnExt);
            this.panelКоллекции.Controls.Add(this.labelКоллекции);
            this.panelКоллекции.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelКоллекции.Location = new System.Drawing.Point(0, 0);
            this.panelКоллекции.Name = "panelКоллекции";
            this.panelКоллекции.Size = new System.Drawing.Size(201, 36);
            this.panelКоллекции.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(137, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(26, 26);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // btnExt
            // 
            this.btnExt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExt.FlatAppearance.BorderSize = 0;
            this.btnExt.Image = ((System.Drawing.Image)(resources.GetObject("btnExt.Image")));
            this.btnExt.Location = new System.Drawing.Point(169, 6);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(26, 26);
            this.btnExt.TabIndex = 0;
            this.btnExt.UseVisualStyleBackColor = false;
            this.btnExt.Click += new System.EventHandler(this.extBtn_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.Location = new System.Drawing.Point(0, 36);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.grBОбщиеКоллекции);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.grBЛокальныеКоллекции);
            this.splitContainer3.Size = new System.Drawing.Size(201, 644);
            this.splitContainer3.SplitterDistance = 292;
            this.splitContainer3.TabIndex = 6;
            // 
            // grBОбщиеКоллекции
            // 
            this.grBОбщиеКоллекции.Controls.Add(this.treeViewServ);
            this.grBОбщиеКоллекции.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBОбщиеКоллекции.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBОбщиеКоллекции.ForeColor = System.Drawing.Color.Linen;
            this.grBОбщиеКоллекции.Location = new System.Drawing.Point(0, 0);
            this.grBОбщиеКоллекции.Name = "grBОбщиеКоллекции";
            this.grBОбщиеКоллекции.Size = new System.Drawing.Size(201, 292);
            this.grBОбщиеКоллекции.TabIndex = 5;
            this.grBОбщиеКоллекции.TabStop = false;
            this.grBОбщиеКоллекции.Text = "Общие Коллекции";
            // 
            // treeViewServ
            // 
            this.treeViewServ.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeViewServ.ContextMenuStrip = this.contextMenuStrip1;
            this.treeViewServ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewServ.Location = new System.Drawing.Point(3, 22);
            this.treeViewServ.Name = "treeViewServ";
            this.treeViewServ.Size = new System.Drawing.Size(195, 267);
            this.treeViewServ.TabIndex = 4;
            this.treeViewServ.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.treeView_NodeMouseHover);
            this.treeViewServ.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this._treeView_NodeMouseClick);
            this.treeViewServ.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this._treeView_NodeMouseDoubleClick);
            this.treeViewServ.MouseUp += new System.Windows.Forms.MouseEventHandler(this._treeViewServ_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemСоздать,
            this.toolStripMenuItemВставить,
            this.toolStripMenuItemВырезать,
            this.toolStripMenuItemКопировать,
            this.toolStripMenuItemПереименовать,
            this.toolStripMenuItemУдалить});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 136);
            // 
            // toolStripMenuItemСоздать
            // 
            this.toolStripMenuItemСоздать.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemКаталог,
            this.toolStripMenuItemКоллекцию});
            this.toolStripMenuItemСоздать.Name = "toolStripMenuItemСоздать";
            this.toolStripMenuItemСоздать.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItemСоздать.Text = "Создать";
            // 
            // toolStripMenuItemКаталог
            // 
            this.toolStripMenuItemКаталог.Name = "toolStripMenuItemКаталог";
            this.toolStripMenuItemКаталог.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItemКаталог.Text = "Каталог";
            this.toolStripMenuItemКаталог.Click += new System.EventHandler(this.каталогToolStripMenuItem_Click);
            // 
            // toolStripMenuItemКоллекцию
            // 
            this.toolStripMenuItemКоллекцию.Name = "toolStripMenuItemКоллекцию";
            this.toolStripMenuItemКоллекцию.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItemКоллекцию.Text = "Коллекцию";
            this.toolStripMenuItemКоллекцию.Click += new System.EventHandler(this.коллекциюToolStripMenuItem_Click);
            // 
            // toolStripMenuItemВставить
            // 
            this.toolStripMenuItemВставить.Enabled = false;
            this.toolStripMenuItemВставить.Name = "toolStripMenuItemВставить";
            this.toolStripMenuItemВставить.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItemВставить.Text = "Вставить";
            this.toolStripMenuItemВставить.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // toolStripMenuItemВырезать
            // 
            this.toolStripMenuItemВырезать.Name = "toolStripMenuItemВырезать";
            this.toolStripMenuItemВырезать.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItemВырезать.Text = "Вырезать";
            this.toolStripMenuItemВырезать.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // toolStripMenuItemКопировать
            // 
            this.toolStripMenuItemКопировать.Name = "toolStripMenuItemКопировать";
            this.toolStripMenuItemКопировать.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItemКопировать.Text = "Копировать";
            this.toolStripMenuItemКопировать.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // toolStripMenuItemПереименовать
            // 
            this.toolStripMenuItemПереименовать.Name = "toolStripMenuItemПереименовать";
            this.toolStripMenuItemПереименовать.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItemПереименовать.Text = "Переименовать";
            this.toolStripMenuItemПереименовать.Click += new System.EventHandler(this.ПереименоватьToolStripMenuItem_Click);
            // 
            // toolStripMenuItemУдалить
            // 
            this.toolStripMenuItemУдалить.Name = "toolStripMenuItemУдалить";
            this.toolStripMenuItemУдалить.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItemУдалить.Text = "Удалить";
            this.toolStripMenuItemУдалить.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // grBЛокальныеКоллекции
            // 
            this.grBЛокальныеКоллекции.Controls.Add(this.treeViewLoc);
            this.grBЛокальныеКоллекции.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBЛокальныеКоллекции.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBЛокальныеКоллекции.ForeColor = System.Drawing.Color.Linen;
            this.grBЛокальныеКоллекции.Location = new System.Drawing.Point(0, 0);
            this.grBЛокальныеКоллекции.Name = "grBЛокальныеКоллекции";
            this.grBЛокальныеКоллекции.Size = new System.Drawing.Size(201, 348);
            this.grBЛокальныеКоллекции.TabIndex = 5;
            this.grBЛокальныеКоллекции.TabStop = false;
            this.grBЛокальныеКоллекции.Text = "Локальные Коллекции";
            // 
            // treeViewLoc
            // 
            this.treeViewLoc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeViewLoc.ContextMenuStrip = this.contextMenuStrip1;
            this.treeViewLoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewLoc.Location = new System.Drawing.Point(3, 22);
            this.treeViewLoc.Name = "treeViewLoc";
            this.treeViewLoc.Size = new System.Drawing.Size(195, 323);
            this.treeViewLoc.TabIndex = 4;
            this.treeViewLoc.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.treeView_NodeMouseHover);
            this.treeViewLoc.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this._treeView_NodeMouseClick);
            this.treeViewLoc.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this._treeView_NodeMouseDoubleClick);
            this.treeViewLoc.MouseUp += new System.Windows.Forms.MouseEventHandler(this._treeViewLoc_MouseUp);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.grBСодержимое);
            this.splitContainer4.Panel1.Controls.Add(this.grBТекущаяКоллекция);
            this.splitContainer4.Panel1MinSize = 200;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.btnExtCancel);
            this.splitContainer4.Panel2.Controls.Add(this.btnExtOk);
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Panel2MinSize = 200;
            this.splitContainer4.Size = new System.Drawing.Size(642, 680);
            this.splitContainer4.SplitterDistance = 404;
            this.splitContainer4.TabIndex = 4;
            this.splitContainer4.Visible = false;
            // 
            // grBСодержимое
            // 
            this.grBСодержимое.Controls.Add(this.listView);
            this.grBСодержимое.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBСодержимое.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBСодержимое.ForeColor = System.Drawing.Color.Linen;
            this.grBСодержимое.Location = new System.Drawing.Point(0, 53);
            this.grBСодержимое.Name = "grBСодержимое";
            this.grBСодержимое.Size = new System.Drawing.Size(642, 351);
            this.grBСодержимое.TabIndex = 5;
            this.grBСодержимое.TabStop = false;
            this.grBСодержимое.Text = "Содержимое";
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeaderFile,
            this.colHeaderSize,
            this.colHeaderType,
            this.colHeaderFullPath});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(3, 18);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(636, 330);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.DoubleClick += new System.EventHandler(this._listView_DoubleClick);
            // 
            // colHeaderFile
            // 
            this.colHeaderFile.Text = "Файл";
            this.colHeaderFile.Width = 128;
            // 
            // colHeaderSize
            // 
            this.colHeaderSize.Text = "Размер (байт)";
            this.colHeaderSize.Width = 101;
            // 
            // colHeaderType
            // 
            this.colHeaderType.Text = "Тип";
            this.colHeaderType.Width = 66;
            // 
            // colHeaderFullPath
            // 
            this.colHeaderFullPath.Text = "Полный путь к файлу";
            this.colHeaderFullPath.Width = 700;
            // 
            // grBТекущаяКоллекция
            // 
            this.grBТекущаяКоллекция.Controls.Add(this.tbJsonFile);
            this.grBТекущаяКоллекция.Dock = System.Windows.Forms.DockStyle.Top;
            this.grBТекущаяКоллекция.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBТекущаяКоллекция.ForeColor = System.Drawing.Color.Linen;
            this.grBТекущаяКоллекция.Location = new System.Drawing.Point(0, 0);
            this.grBТекущаяКоллекция.Name = "grBТекущаяКоллекция";
            this.grBТекущаяКоллекция.Size = new System.Drawing.Size(642, 53);
            this.grBТекущаяКоллекция.TabIndex = 4;
            this.grBТекущаяКоллекция.TabStop = false;
            this.grBТекущаяКоллекция.Text = "Текущая Коллекция";
            // 
            // tbJsonFile
            // 
            this.tbJsonFile.BackColor = System.Drawing.Color.LightSlateGray;
            this.tbJsonFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbJsonFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbJsonFile.ForeColor = System.Drawing.Color.White;
            this.tbJsonFile.Location = new System.Drawing.Point(3, 22);
            this.tbJsonFile.Name = "tbJsonFile";
            this.tbJsonFile.ReadOnly = true;
            this.tbJsonFile.Size = new System.Drawing.Size(636, 24);
            this.tbJsonFile.TabIndex = 30;
            this.tbJsonFile.Text = "Collections\\File.json";
            this.tbJsonFile.TextChanged += new System.EventHandler(this.jsonFile_TextChanged);
            // 
            // btnExtCancel
            // 
            this.btnExtCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExtCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtCancel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExtCancel.Location = new System.Drawing.Point(300, 166);
            this.btnExtCancel.Name = "btnExtCancel";
            this.btnExtCancel.Size = new System.Drawing.Size(75, 23);
            this.btnExtCancel.TabIndex = 2;
            this.btnExtCancel.Text = "Отмена";
            this.btnExtCancel.UseVisualStyleBackColor = false;
            this.btnExtCancel.Click += new System.EventHandler(this.extCancelBtn_Click);
            // 
            // btnExtOk
            // 
            this.btnExtOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExtOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtOk.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExtOk.Location = new System.Drawing.Point(223, 166);
            this.btnExtOk.Name = "btnExtOk";
            this.btnExtOk.Size = new System.Drawing.Size(75, 23);
            this.btnExtOk.TabIndex = 2;
            this.btnExtOk.Text = "OK";
            this.btnExtOk.UseVisualStyleBackColor = false;
            this.btnExtOk.Click += new System.EventHandler(this.extOkBtn_Click);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.grBНастройкаОбщихКоллекций);
            this.splitContainer5.Panel1MinSize = 240;
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.grBНастройкаЛокальныхКоллекций);
            this.splitContainer5.Panel2MinSize = 240;
            this.splitContainer5.Size = new System.Drawing.Size(642, 159);
            this.splitContainer5.SplitterDistance = 297;
            this.splitContainer5.TabIndex = 1;
            // 
            // grBНастройкаОбщихКоллекций
            // 
            this.grBНастройкаОбщихКоллекций.Controls.Add(this.btnOpenFDServ);
            this.grBНастройкаОбщихКоллекций.Controls.Add(this.btnDefaultServ);
            this.grBНастройкаОбщихКоллекций.Controls.Add(this.tbPathServ);
            this.grBНастройкаОбщихКоллекций.Controls.Add(this.labelПуть);
            this.grBНастройкаОбщихКоллекций.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBНастройкаОбщихКоллекций.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBНастройкаОбщихКоллекций.ForeColor = System.Drawing.Color.Linen;
            this.grBНастройкаОбщихКоллекций.Location = new System.Drawing.Point(0, 0);
            this.grBНастройкаОбщихКоллекций.Name = "grBНастройкаОбщихКоллекций";
            this.grBНастройкаОбщихКоллекций.Size = new System.Drawing.Size(297, 159);
            this.grBНастройкаОбщихКоллекций.TabIndex = 0;
            this.grBНастройкаОбщихКоллекций.TabStop = false;
            this.grBНастройкаОбщихКоллекций.Text = "Настройка Общих Коллекций";
            // 
            // btnOpenFDServ
            // 
            this.btnOpenFDServ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFDServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpenFDServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFDServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenFDServ.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOpenFDServ.Location = new System.Drawing.Point(218, 74);
            this.btnOpenFDServ.Name = "btnOpenFDServ";
            this.btnOpenFDServ.Size = new System.Drawing.Size(57, 23);
            this.btnOpenFDServ.TabIndex = 2;
            this.btnOpenFDServ.Text = "Обзор";
            this.btnOpenFDServ.UseVisualStyleBackColor = false;
            this.btnOpenFDServ.Click += new System.EventHandler(this.openFDServBtn_Click);
            // 
            // btnDefaultServ
            // 
            this.btnDefaultServ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDefaultServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefaultServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDefaultServ.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDefaultServ.Location = new System.Drawing.Point(118, 74);
            this.btnDefaultServ.Name = "btnDefaultServ";
            this.btnDefaultServ.Size = new System.Drawing.Size(94, 23);
            this.btnDefaultServ.TabIndex = 2;
            this.btnDefaultServ.Text = "По умолчанию";
            this.btnDefaultServ.UseVisualStyleBackColor = false;
            this.btnDefaultServ.Click += new System.EventHandler(this.defaultServBtn_Click);
            // 
            // tbPathServ
            // 
            this.tbPathServ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPathServ.Location = new System.Drawing.Point(10, 48);
            this.tbPathServ.Name = "tbPathServ";
            this.tbPathServ.Size = new System.Drawing.Size(265, 22);
            this.tbPathServ.TabIndex = 1;
            // 
            // labelПуть
            // 
            this.labelПуть.AutoSize = true;
            this.labelПуть.Location = new System.Drawing.Point(7, 31);
            this.labelПуть.Name = "labelПуть";
            this.labelПуть.Size = new System.Drawing.Size(40, 16);
            this.labelПуть.TabIndex = 0;
            this.labelПуть.Text = "Путь";
            // 
            // grBНастройкаЛокальныхКоллекций
            // 
            this.grBНастройкаЛокальныхКоллекций.Controls.Add(this.btnOpenFDLoc);
            this.grBНастройкаЛокальныхКоллекций.Controls.Add(this.btnDefaultLoc);
            this.grBНастройкаЛокальныхКоллекций.Controls.Add(this.tbPathLoc);
            this.grBНастройкаЛокальныхКоллекций.Controls.Add(this.labelПуть2);
            this.grBНастройкаЛокальныхКоллекций.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBНастройкаЛокальныхКоллекций.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBНастройкаЛокальныхКоллекций.ForeColor = System.Drawing.Color.Linen;
            this.grBНастройкаЛокальныхКоллекций.Location = new System.Drawing.Point(0, 0);
            this.grBНастройкаЛокальныхКоллекций.Name = "grBНастройкаЛокальныхКоллекций";
            this.grBНастройкаЛокальныхКоллекций.Size = new System.Drawing.Size(341, 159);
            this.grBНастройкаЛокальныхКоллекций.TabIndex = 0;
            this.grBНастройкаЛокальныхКоллекций.TabStop = false;
            this.grBНастройкаЛокальныхКоллекций.Text = "Настройка Локальных Коллекций";
            // 
            // btnOpenFDLoc
            // 
            this.btnOpenFDLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFDLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpenFDLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFDLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenFDLoc.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOpenFDLoc.Location = new System.Drawing.Point(265, 74);
            this.btnOpenFDLoc.Name = "btnOpenFDLoc";
            this.btnOpenFDLoc.Size = new System.Drawing.Size(55, 23);
            this.btnOpenFDLoc.TabIndex = 2;
            this.btnOpenFDLoc.Text = "Обзор";
            this.btnOpenFDLoc.UseVisualStyleBackColor = false;
            this.btnOpenFDLoc.Click += new System.EventHandler(this.openFDLocBtn_Click);
            // 
            // btnDefaultLoc
            // 
            this.btnDefaultLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDefaultLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefaultLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDefaultLoc.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDefaultLoc.Location = new System.Drawing.Point(164, 74);
            this.btnDefaultLoc.Name = "btnDefaultLoc";
            this.btnDefaultLoc.Size = new System.Drawing.Size(95, 23);
            this.btnDefaultLoc.TabIndex = 2;
            this.btnDefaultLoc.Text = "По умолчанию";
            this.btnDefaultLoc.UseVisualStyleBackColor = false;
            this.btnDefaultLoc.Click += new System.EventHandler(this.defaultLocBtn_Click);
            // 
            // tbPathLoc
            // 
            this.tbPathLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPathLoc.Location = new System.Drawing.Point(19, 48);
            this.tbPathLoc.Name = "tbPathLoc";
            this.tbPathLoc.Size = new System.Drawing.Size(301, 22);
            this.tbPathLoc.TabIndex = 1;
            // 
            // labelПуть2
            // 
            this.labelПуть2.AutoSize = true;
            this.labelПуть2.Location = new System.Drawing.Point(16, 31);
            this.labelПуть2.Name = "labelПуть2";
            this.labelПуть2.Size = new System.Drawing.Size(40, 16);
            this.labelПуть2.TabIndex = 0;
            this.labelПуть2.Text = "Путь";
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer7.IsSplitterFixed = true;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.splitContainer6);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer7.Size = new System.Drawing.Size(950, 680);
            this.splitContainer7.SplitterDistance = 160;
            this.splitContainer7.TabIndex = 30;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.grBЗапросыВКоллекции);
            this.splitContainer6.Panel1MinSize = 570;
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.grBOnOff);
            this.splitContainer6.Panel2MinSize = 355;
            this.splitContainer6.Size = new System.Drawing.Size(950, 160);
            this.splitContainer6.SplitterDistance = 575;
            this.splitContainer6.TabIndex = 30;
            // 
            // grBЗапросыВКоллекции
            // 
            this.grBЗапросыВКоллекции.Controls.Add(this.linkLabel1);
            this.grBЗапросыВКоллекции.Controls.Add(this.btnDeleteCash);
            this.grBЗапросыВКоллекции.Controls.Add(this.btnSaveCash);
            this.grBЗапросыВКоллекции.Controls.Add(this.pictBoxОбработкаЗапроса);
            this.grBЗапросыВКоллекции.Controls.Add(this.comboBoxRefs);
            this.grBЗапросыВКоллекции.Controls.Add(this.labelМетод);
            this.grBЗапросыВКоллекции.Controls.Add(this.labelОбработкаЗапроса);
            this.grBЗапросыВКоллекции.Controls.Add(this.comboBoxMethod);
            this.grBЗапросыВКоллекции.Controls.Add(this.btnSend);
            this.grBЗапросыВКоллекции.Controls.Add(this.labelПрефикс);
            this.grBЗапросыВКоллекции.Controls.Add(this.tbRequest);
            this.grBЗапросыВКоллекции.Controls.Add(this.labelЗапрос);
            this.grBЗапросыВКоллекции.Controls.Add(this.tbPreRequest);
            this.grBЗапросыВКоллекции.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBЗапросыВКоллекции.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBЗапросыВКоллекции.ForeColor = System.Drawing.Color.Linen;
            this.grBЗапросыВКоллекции.Location = new System.Drawing.Point(0, 0);
            this.grBЗапросыВКоллекции.Name = "grBЗапросыВКоллекции";
            this.grBЗапросыВКоллекции.Size = new System.Drawing.Size(575, 160);
            this.grBЗапросыВКоллекции.TabIndex = 34;
            this.grBЗапросыВКоллекции.TabStop = false;
            this.grBЗапросыВКоллекции.Text = "Запросы в коллекции \"File\"";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Location = new System.Drawing.Point(473, 84);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 20);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Отменить";
            this.linkLabel1.Visible = false;
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1155, 680);
            this.Controls.Add(this.splitContainer2);
            this.ForeColor = System.Drawing.Color.Linen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1171, 500);
            this.Name = "Form1";
            this.Text = "AppClientTurbo";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.grBOnOff.ResumeLayout(false);
            this.grBOnOff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxОбработкаЗапроса)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grBДанныеЗапроса.ResumeLayout(false);
            this.grBДанныеЗапроса.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbDataReq)).EndInit();
            this.grBОтвет.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctbResponse)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelИмя.ResumeLayout(false);
            this.panelИмя.PerformLayout();
            this.panelКоллекции.ResumeLayout(false);
            this.panelКоллекции.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.grBОбщиеКоллекции.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.grBЛокальныеКоллекции.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.grBСодержимое.ResumeLayout(false);
            this.grBТекущаяКоллекция.ResumeLayout(false);
            this.grBТекущаяКоллекция.PerformLayout();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.grBНастройкаОбщихКоллекций.ResumeLayout(false);
            this.grBНастройкаОбщихКоллекций.PerformLayout();
            this.grBНастройкаЛокальныхКоллекций.ResumeLayout(false);
            this.grBНастройкаЛокальныхКоллекций.PerformLayout();
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.grBЗапросыВКоллекции.ResumeLayout(false);
            this.grBЗапросыВКоллекции.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnUseraut;
        private System.Windows.Forms.TextBox tbAdrServer;
        private System.Windows.Forms.Label labelСервер;
        private System.Windows.Forms.Label labelПорт;
        private System.Windows.Forms.TextBox tbAdrPort;
        private System.Windows.Forms.Label labelМетод;
        private System.Windows.Forms.TextBox tbRequest;
        private System.Windows.Forms.Label labelЗапрос;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPswrd;
        private System.Windows.Forms.GroupBox grBOnOff;
        private System.Windows.Forms.PictureBox pictBoxOff;
        private System.Windows.Forms.PictureBox pictBoxOn;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.ComboBox comboBoxRefs;
        private System.Windows.Forms.Button btnSaveCash;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictBoxОбработкаЗапроса;
        private System.Windows.Forms.Label labelОбработкаЗапроса;
        private System.Windows.Forms.CheckBox checkBoxForce;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDeleteCash;
        private System.Windows.Forms.Label labelКоллекции;
        private System.Windows.Forms.TextBox tbPreRequest;
        private System.Windows.Forms.Label labelПрефикс;
        private System.Windows.Forms.Label labelStatusCode;
        private FastColoredTextBoxNS.FastColoredTextBox fctbResponse;
        private FastColoredTextBoxNS.FastColoredTextBox fctbDataReq;
        private System.Windows.Forms.GroupBox grBДанныеЗапроса;
        private System.Windows.Forms.GroupBox grBОтвет;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panelИмя;
        private System.Windows.Forms.Label labelИмя;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panelКоллекции;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExt;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox grBОбщиеКоллекции;
        private System.Windows.Forms.TreeView treeViewServ;
        private System.Windows.Forms.GroupBox grBЛокальныеКоллекции;
        private System.Windows.Forms.TreeView treeViewLoc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemСоздать;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemКаталог;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemКоллекцию;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemВставить;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemВырезать;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemКопировать;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemПереименовать;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemУдалить;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox grBЗапросыВКоллекции;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox grBСодержимое;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader colHeaderFile;
        private System.Windows.Forms.ColumnHeader colHeaderSize;
        private System.Windows.Forms.ColumnHeader colHeaderType;
        private System.Windows.Forms.ColumnHeader colHeaderFullPath;
        private System.Windows.Forms.GroupBox grBТекущаяКоллекция;
        private System.Windows.Forms.TextBox tbJsonFile;
        private System.Windows.Forms.Button btnExtCancel;
        private System.Windows.Forms.Button btnExtOk;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.GroupBox grBНастройкаОбщихКоллекций;
        private System.Windows.Forms.Button btnOpenFDServ;
        private System.Windows.Forms.Button btnDefaultServ;
        private System.Windows.Forms.TextBox tbPathServ;
        private System.Windows.Forms.Label labelПуть;
        private System.Windows.Forms.GroupBox grBНастройкаЛокальныхКоллекций;
        private System.Windows.Forms.Button btnOpenFDLoc;
        private System.Windows.Forms.Button btnDefaultLoc;
        private System.Windows.Forms.TextBox tbPathLoc;
        private System.Windows.Forms.Label labelПуть2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


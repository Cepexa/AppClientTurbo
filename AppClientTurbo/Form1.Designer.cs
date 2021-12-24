
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
            this.user = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.userautBtn = new System.Windows.Forms.Button();
            this.adrServer = new System.Windows.Forms.TextBox();
            this.adrPort = new System.Windows.Forms.TextBox();
            this.requestTB = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.onOff = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ForceBox = new System.Windows.Forms.CheckBox();
            this.methodBox = new System.Windows.Forms.ComboBox();
            this.Refs = new System.Windows.Forms.ComboBox();
            this.saveCashBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grBДанныеЗапроса = new System.Windows.Forms.GroupBox();
            this.dataReqFctb = new FastColoredTextBoxNS.FastColoredTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.responseFctb = new FastColoredTextBoxNS.FastColoredTextBox();
            this.deleteCashBtn = new System.Windows.Forms.Button();
            this.preRequestTB = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelИмя = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.extBtn = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._treeViewServ = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каталогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.коллекциюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ПереименоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._treeViewLoc = new System.Windows.Forms.TreeView();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.grBЗапросыВКоллекции = new System.Windows.Forms.GroupBox();
            this.folderBD = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelПуть2 = new System.Windows.Forms.Label();
            this.pathLocTb = new System.Windows.Forms.TextBox();
            this.defaultLocBtn = new System.Windows.Forms.Button();
            this.openFDLocBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelПуть = new System.Windows.Forms.Label();
            this.pathServTb = new System.Windows.Forms.TextBox();
            this.defaultServBtn = new System.Windows.Forms.Button();
            this.openFDServBtn = new System.Windows.Forms.Button();
            this.extOkBtn = new System.Windows.Forms.Button();
            this.extCancelBtn = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.jsonFile = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this._listView = new System.Windows.Forms.ListView();
            this.file = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fullPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.onOff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grBДанныеЗапроса.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataReqFctb)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.responseFctb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.grBЗапросыВКоллекции.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
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
            this.labelStatusCode.Location = new System.Drawing.Point(1061, -2);
            this.labelStatusCode.Name = "labelStatusCode";
            this.labelStatusCode.Size = new System.Drawing.Size(112, 20);
            this.labelStatusCode.TabIndex = 33;
            this.labelStatusCode.Text = "Status Code";
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.LightSlateGray;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(173, 50);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(169, 26);
            this.user.TabIndex = 0;
            this.user.Text = "Пользователь";
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.LightSlateGray;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(173, 80);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(169, 26);
            this.password.TabIndex = 1;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // userautBtn
            // 
            this.userautBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userautBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userautBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userautBtn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.userautBtn.Location = new System.Drawing.Point(173, 112);
            this.userautBtn.Name = "userautBtn";
            this.userautBtn.Size = new System.Drawing.Size(79, 37);
            this.userautBtn.TabIndex = 2;
            this.userautBtn.Text = "Вход";
            this.userautBtn.UseVisualStyleBackColor = false;
            this.userautBtn.Click += new System.EventHandler(this.userauth_Click);
            // 
            // adrServer
            // 
            this.adrServer.BackColor = System.Drawing.Color.LightSlateGray;
            this.adrServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adrServer.ForeColor = System.Drawing.Color.White;
            this.adrServer.Location = new System.Drawing.Point(88, 19);
            this.adrServer.MaxLength = 15;
            this.adrServer.Name = "adrServer";
            this.adrServer.Size = new System.Drawing.Size(136, 26);
            this.adrServer.TabIndex = 3;
            this.adrServer.Text = "127.0.0.1";
            this.adrServer.TextChanged += new System.EventHandler(this.adrServer_TextChanged);
            // 
            // adrPort
            // 
            this.adrPort.BackColor = System.Drawing.Color.LightSlateGray;
            this.adrPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adrPort.ForeColor = System.Drawing.Color.White;
            this.adrPort.Location = new System.Drawing.Point(283, 19);
            this.adrPort.MaxLength = 5;
            this.adrPort.Name = "adrPort";
            this.adrPort.Size = new System.Drawing.Size(59, 26);
            this.adrPort.TabIndex = 6;
            this.adrPort.Text = "81";
            this.adrPort.TextChanged += new System.EventHandler(this.adrPort_TextChanged);
            // 
            // requestTB
            // 
            this.requestTB.BackColor = System.Drawing.Color.LightSlateGray;
            this.requestTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.requestTB.ForeColor = System.Drawing.Color.White;
            this.requestTB.Location = new System.Drawing.Point(91, 114);
            this.requestTB.Name = "requestTB";
            this.requestTB.Size = new System.Drawing.Size(376, 26);
            this.requestTB.TabIndex = 10;
            this.requestTB.Text = "RepairService/getDataRef";
            this.requestTB.TextChanged += new System.EventHandler(this.request_TextChanged);
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendBtn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.sendBtn.Location = new System.Drawing.Point(473, 107);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(92, 34);
            this.sendBtn.TabIndex = 16;
            this.sendBtn.Text = "Отправить\r\n";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.send_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.Location = new System.Drawing.Point(835, 303);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 31);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // onOff
            // 
            this.onOff.Controls.Add(this.pictureBox2);
            this.onOff.Controls.Add(this.pictureBox1);
            this.onOff.Controls.Add(this.ForceBox);
            this.onOff.Controls.Add(this.labelСервер);
            this.onOff.Controls.Add(this.userautBtn);
            this.onOff.Controls.Add(this.adrPort);
            this.onOff.Controls.Add(this.labelPswrd);
            this.onOff.Controls.Add(this.adrServer);
            this.onOff.Controls.Add(this.labelПорт);
            this.onOff.Controls.Add(this.user);
            this.onOff.Controls.Add(this.password);
            this.onOff.Controls.Add(this.labelUser);
            this.onOff.Dock = System.Windows.Forms.DockStyle.Right;
            this.onOff.ForeColor = System.Drawing.Color.Linen;
            this.onOff.Location = new System.Drawing.Point(0, 0);
            this.onOff.Name = "onOff";
            this.onOff.Size = new System.Drawing.Size(371, 160);
            this.onOff.TabIndex = 20;
            this.onOff.TabStop = false;
            this.onOff.Text = "On/Off";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(292, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 29);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(258, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 29);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // ForceBox
            // 
            this.ForceBox.AutoSize = true;
            this.ForceBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ForceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForceBox.ForeColor = System.Drawing.Color.Linen;
            this.ForceBox.Location = new System.Drawing.Point(8, 110);
            this.ForceBox.Name = "ForceBox";
            this.ForceBox.Size = new System.Drawing.Size(159, 40);
            this.ForceBox.TabIndex = 28;
            this.ForceBox.Text = "Принудительный\r\nвход";
            this.ForceBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ForceBox.UseVisualStyleBackColor = true;
            this.ForceBox.Visible = false;
            // 
            // methodBox
            // 
            this.methodBox.BackColor = System.Drawing.Color.LightSlateGray;
            this.methodBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.methodBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.methodBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.methodBox.FormattingEnabled = true;
            this.methodBox.Items.AddRange(new object[] {
            "POST",
            "GET",
            "PUT",
            "DELETE"});
            this.methodBox.Location = new System.Drawing.Point(91, 56);
            this.methodBox.Name = "methodBox";
            this.methodBox.Size = new System.Drawing.Size(76, 24);
            this.methodBox.TabIndex = 21;
            this.methodBox.Text = "POST";
            // 
            // Refs
            // 
            this.Refs.BackColor = System.Drawing.Color.LightSlateGray;
            this.Refs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Refs.ForeColor = System.Drawing.Color.White;
            this.Refs.FormattingEnabled = true;
            this.Refs.Location = new System.Drawing.Point(6, 25);
            this.Refs.Name = "Refs";
            this.Refs.Size = new System.Drawing.Size(461, 28);
            this.Refs.TabIndex = 22;
            this.Refs.Text = "-";
            this.Refs.SelectedIndexChanged += new System.EventHandler(this.Refs_SelectedIndexChanged);
            this.Refs.TextChanged += new System.EventHandler(this.Refs_TextChanged);
            // 
            // saveCashBtn
            // 
            this.saveCashBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saveCashBtn.Enabled = false;
            this.saveCashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveCashBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveCashBtn.ForeColor = System.Drawing.Color.Orange;
            this.saveCashBtn.Location = new System.Drawing.Point(329, 59);
            this.saveCashBtn.Name = "saveCashBtn";
            this.saveCashBtn.Size = new System.Drawing.Size(66, 22);
            this.saveCashBtn.TabIndex = 24;
            this.saveCashBtn.Text = "Save";
            this.saveCashBtn.UseVisualStyleBackColor = false;
            this.saveCashBtn.Click += new System.EventHandler(this.saveCash_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(0, 0);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 0;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(0, 0);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(500, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 28);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
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
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(950, 516);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.TabIndex = 29;
            this.splitContainer1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseMove);
            // 
            // grBДанныеЗапроса
            // 
            this.grBДанныеЗапроса.Controls.Add(this.labelStatusCode);
            this.grBДанныеЗапроса.Controls.Add(this.dataReqFctb);
            this.grBДанныеЗапроса.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBДанныеЗапроса.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBДанныеЗапроса.ForeColor = System.Drawing.Color.Linen;
            this.grBДанныеЗапроса.Location = new System.Drawing.Point(0, 0);
            this.grBДанныеЗапроса.Name = "grBДанныеЗапроса";
            this.grBДанныеЗапроса.Size = new System.Drawing.Size(946, 160);
            this.grBДанныеЗапроса.TabIndex = 35;
            this.grBДанныеЗапроса.TabStop = false;
            this.grBДанныеЗапроса.Text = "Данные запроса";
            // 
            // dataReqFctb
            // 
            this.dataReqFctb.AutoCompleteBracketsList = new char[] {
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
            this.dataReqFctb.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.dataReqFctb.AutoScrollMinSize = new System.Drawing.Size(31, 19);
            this.dataReqFctb.BackBrush = null;
            this.dataReqFctb.BackColor = System.Drawing.SystemColors.Info;
            this.dataReqFctb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataReqFctb.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.dataReqFctb.CaretColor = System.Drawing.Color.Lime;
            this.dataReqFctb.CharHeight = 19;
            this.dataReqFctb.CharWidth = 10;
            this.dataReqFctb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataReqFctb.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dataReqFctb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataReqFctb.Font = new System.Drawing.Font("Courier New", 12.75F);
            this.dataReqFctb.ForeColor = System.Drawing.Color.Black;
            this.dataReqFctb.IndentBackColor = System.Drawing.Color.Gray;
            this.dataReqFctb.IsReplaceMode = false;
            this.dataReqFctb.Language = FastColoredTextBoxNS.Language.JSON;
            this.dataReqFctb.LeftBracket = '[';
            this.dataReqFctb.LeftBracket2 = '{';
            this.dataReqFctb.LineNumberColor = System.Drawing.Color.PaleTurquoise;
            this.dataReqFctb.Location = new System.Drawing.Point(3, 22);
            this.dataReqFctb.Name = "dataReqFctb";
            this.dataReqFctb.Paddings = new System.Windows.Forms.Padding(0);
            this.dataReqFctb.RightBracket = ']';
            this.dataReqFctb.RightBracket2 = '}';
            this.dataReqFctb.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataReqFctb.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("dataReqFctb.ServiceColors")));
            this.dataReqFctb.Size = new System.Drawing.Size(940, 135);
            this.dataReqFctb.TabIndex = 34;
            this.dataReqFctb.Zoom = 100;
            this.dataReqFctb.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.dataReqFctb_TextChanged);
            this.dataReqFctb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataReq_MouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.responseFctb);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.Linen;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(946, 344);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ответ";
            // 
            // responseFctb
            // 
            this.responseFctb.AutoCompleteBracketsList = new char[] {
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
            this.responseFctb.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.responseFctb.AutoScrollMinSize = new System.Drawing.Size(31, 19);
            this.responseFctb.BackBrush = null;
            this.responseFctb.BackColor = System.Drawing.SystemColors.MenuBar;
            this.responseFctb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.responseFctb.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.responseFctb.CaretColor = System.Drawing.Color.Lime;
            this.responseFctb.CharHeight = 19;
            this.responseFctb.CharWidth = 10;
            this.responseFctb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.responseFctb.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.responseFctb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.responseFctb.Font = new System.Drawing.Font("Courier New", 12.75F);
            this.responseFctb.ForeColor = System.Drawing.Color.Black;
            this.responseFctb.IndentBackColor = System.Drawing.Color.Gray;
            this.responseFctb.IsReplaceMode = false;
            this.responseFctb.Language = FastColoredTextBoxNS.Language.JSON;
            this.responseFctb.LeftBracket = '[';
            this.responseFctb.LeftBracket2 = '{';
            this.responseFctb.LineNumberColor = System.Drawing.Color.Cyan;
            this.responseFctb.Location = new System.Drawing.Point(3, 22);
            this.responseFctb.Name = "responseFctb";
            this.responseFctb.Paddings = new System.Windows.Forms.Padding(0);
            this.responseFctb.ReadOnly = true;
            this.responseFctb.RightBracket = ']';
            this.responseFctb.RightBracket2 = '}';
            this.responseFctb.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.responseFctb.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("responseFctb.ServiceColors")));
            this.responseFctb.Size = new System.Drawing.Size(940, 319);
            this.responseFctb.TabIndex = 34;
            this.responseFctb.Zoom = 100;
            this.responseFctb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.responseTxt_MouseMove);
            // 
            // deleteCashBtn
            // 
            this.deleteCashBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteCashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteCashBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteCashBtn.ForeColor = System.Drawing.Color.Orange;
            this.deleteCashBtn.Location = new System.Drawing.Point(401, 59);
            this.deleteCashBtn.Name = "deleteCashBtn";
            this.deleteCashBtn.Size = new System.Drawing.Size(66, 22);
            this.deleteCashBtn.TabIndex = 24;
            this.deleteCashBtn.Text = "Delete";
            this.deleteCashBtn.UseVisualStyleBackColor = false;
            this.deleteCashBtn.Click += new System.EventHandler(this.deleteCash_Click);
            // 
            // preRequestTB
            // 
            this.preRequestTB.BackColor = System.Drawing.Color.LightSlateGray;
            this.preRequestTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preRequestTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.preRequestTB.ForeColor = System.Drawing.Color.White;
            this.preRequestTB.Location = new System.Drawing.Point(91, 84);
            this.preRequestTB.Name = "preRequestTB";
            this.preRequestTB.Size = new System.Drawing.Size(376, 26);
            this.preRequestTB.TabIndex = 10;
            this.preRequestTB.Text = "RepairService/getDataRef";
            this.preRequestTB.TextChanged += new System.EventHandler(this.request_TextChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelИмя);
            this.panel1.Controls.Add(this.nameTb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 34);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
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
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(41, 4);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(154, 20);
            this.nameTb.TabIndex = 0;
            this.nameTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTb_KeyDown);
            this.nameTb.Leave += new System.EventHandler(this.nameTb_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.refreshBtn);
            this.panel2.Controls.Add(this.extBtn);
            this.panel2.Controls.Add(this.labelКоллекции);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 36);
            this.panel2.TabIndex = 0;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.Location = new System.Drawing.Point(137, 6);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(26, 26);
            this.refreshBtn.TabIndex = 0;
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // extBtn
            // 
            this.extBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.extBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.extBtn.FlatAppearance.BorderSize = 0;
            this.extBtn.Image = ((System.Drawing.Image)(resources.GetObject("extBtn.Image")));
            this.extBtn.Location = new System.Drawing.Point(169, 6);
            this.extBtn.Name = "extBtn";
            this.extBtn.Size = new System.Drawing.Size(26, 26);
            this.extBtn.TabIndex = 0;
            this.extBtn.UseVisualStyleBackColor = false;
            this.extBtn.Click += new System.EventHandler(this.extBtn_Click);
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
            this.splitContainer3.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer3.Size = new System.Drawing.Size(201, 644);
            this.splitContainer3.SplitterDistance = 292;
            this.splitContainer3.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._treeViewServ);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.Linen;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 292);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Общие Коллекции";
            // 
            // _treeViewServ
            // 
            this._treeViewServ.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._treeViewServ.ContextMenuStrip = this.contextMenuStrip1;
            this._treeViewServ.Dock = System.Windows.Forms.DockStyle.Fill;
            this._treeViewServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._treeViewServ.Location = new System.Drawing.Point(3, 22);
            this._treeViewServ.Name = "_treeViewServ";
            this._treeViewServ.Size = new System.Drawing.Size(195, 267);
            this._treeViewServ.TabIndex = 4;
            this._treeViewServ.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this._treeView_NodeMouseClick);
            this._treeViewServ.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this._treeView_NodeMouseDoubleClick);
            this._treeViewServ.MouseUp += new System.Windows.Forms.MouseEventHandler(this._treeViewServ_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.ПереименоватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 136);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каталогToolStripMenuItem,
            this.коллекциюToolStripMenuItem});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // каталогToolStripMenuItem
            // 
            this.каталогToolStripMenuItem.Name = "каталогToolStripMenuItem";
            this.каталогToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.каталогToolStripMenuItem.Text = "Каталог";
            this.каталогToolStripMenuItem.Click += new System.EventHandler(this.каталогToolStripMenuItem_Click);
            // 
            // коллекциюToolStripMenuItem
            // 
            this.коллекциюToolStripMenuItem.Name = "коллекциюToolStripMenuItem";
            this.коллекциюToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.коллекциюToolStripMenuItem.Text = "Коллекцию";
            this.коллекциюToolStripMenuItem.Click += new System.EventHandler(this.коллекциюToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Enabled = false;
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // ПереименоватьToolStripMenuItem
            // 
            this.ПереименоватьToolStripMenuItem.Name = "ПереименоватьToolStripMenuItem";
            this.ПереименоватьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ПереименоватьToolStripMenuItem.Text = "Переименовать";
            this.ПереименоватьToolStripMenuItem.Click += new System.EventHandler(this.ПереименоватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._treeViewLoc);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.Color.Linen;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(201, 348);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Локальные Коллекции";
            // 
            // _treeViewLoc
            // 
            this._treeViewLoc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._treeViewLoc.ContextMenuStrip = this.contextMenuStrip1;
            this._treeViewLoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this._treeViewLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._treeViewLoc.Location = new System.Drawing.Point(3, 22);
            this._treeViewLoc.Name = "_treeViewLoc";
            this._treeViewLoc.Size = new System.Drawing.Size(195, 323);
            this._treeViewLoc.TabIndex = 4;
            this._treeViewLoc.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this._treeView_NodeMouseClick);
            this._treeViewLoc.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this._treeView_NodeMouseDoubleClick);
            this._treeViewLoc.MouseUp += new System.Windows.Forms.MouseEventHandler(this._treeViewLoc_MouseUp);
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
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
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
            this.splitContainer6.Panel2.Controls.Add(this.onOff);
            this.splitContainer6.Panel2MinSize = 355;
            this.splitContainer6.Size = new System.Drawing.Size(950, 160);
            this.splitContainer6.SplitterDistance = 575;
            this.splitContainer6.TabIndex = 30;
            // 
            // grBЗапросыВКоллекции
            // 
            this.grBЗапросыВКоллекции.Controls.Add(this.deleteCashBtn);
            this.grBЗапросыВКоллекции.Controls.Add(this.saveCashBtn);
            this.grBЗапросыВКоллекции.Controls.Add(this.pictureBox3);
            this.grBЗапросыВКоллекции.Controls.Add(this.Refs);
            this.grBЗапросыВКоллекции.Controls.Add(this.labelМетод);
            this.grBЗапросыВКоллекции.Controls.Add(this.labelОбработкаЗапроса);
            this.grBЗапросыВКоллекции.Controls.Add(this.methodBox);
            this.grBЗапросыВКоллекции.Controls.Add(this.sendBtn);
            this.grBЗапросыВКоллекции.Controls.Add(this.labelПрефикс);
            this.grBЗапросыВКоллекции.Controls.Add(this.requestTB);
            this.grBЗапросыВКоллекции.Controls.Add(this.labelЗапрос);
            this.grBЗапросыВКоллекции.Controls.Add(this.preRequestTB);
            this.grBЗапросыВКоллекции.Dock = System.Windows.Forms.DockStyle.Left;
            this.grBЗапросыВКоллекции.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBЗапросыВКоллекции.ForeColor = System.Drawing.Color.Linen;
            this.grBЗапросыВКоллекции.Location = new System.Drawing.Point(0, 0);
            this.grBЗапросыВКоллекции.Name = "grBЗапросыВКоллекции";
            this.grBЗапросыВКоллекции.Size = new System.Drawing.Size(574, 160);
            this.grBЗапросыВКоллекции.TabIndex = 34;
            this.grBЗапросыВКоллекции.TabStop = false;
            this.grBЗапросыВКоллекции.Text = "Запросы в коллекции";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer5.Panel1MinSize = 200;
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer5.Panel2MinSize = 200;
            this.splitContainer5.Size = new System.Drawing.Size(642, 159);
            this.splitContainer5.SplitterDistance = 315;
            this.splitContainer5.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.openFDLocBtn);
            this.groupBox6.Controls.Add(this.defaultLocBtn);
            this.groupBox6.Controls.Add(this.pathLocTb);
            this.groupBox6.Controls.Add(this.labelПуть2);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.ForeColor = System.Drawing.Color.Linen;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(323, 159);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Настройка Локальных Коллекций";
            // 
            // labelПуть2
            // 
            this.labelПуть2.AutoSize = true;
            this.labelПуть2.Location = new System.Drawing.Point(16, 31);
            this.labelПуть2.Name = "labelПуть2";
            this.labelПуть2.Size = new System.Drawing.Size(31, 13);
            this.labelПуть2.TabIndex = 0;
            this.labelПуть2.Text = "Путь";
            // 
            // pathLocTb
            // 
            this.pathLocTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathLocTb.Location = new System.Drawing.Point(19, 48);
            this.pathLocTb.Name = "pathLocTb";
            this.pathLocTb.Size = new System.Drawing.Size(283, 20);
            this.pathLocTb.TabIndex = 1;
            // 
            // defaultLocBtn
            // 
            this.defaultLocBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultLocBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.defaultLocBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultLocBtn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.defaultLocBtn.Location = new System.Drawing.Point(150, 74);
            this.defaultLocBtn.Name = "defaultLocBtn";
            this.defaultLocBtn.Size = new System.Drawing.Size(91, 23);
            this.defaultLocBtn.TabIndex = 2;
            this.defaultLocBtn.Text = "По умолчанию";
            this.defaultLocBtn.UseVisualStyleBackColor = false;
            this.defaultLocBtn.Click += new System.EventHandler(this.defaultLocBtn_Click);
            // 
            // openFDLocBtn
            // 
            this.openFDLocBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openFDLocBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openFDLocBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFDLocBtn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.openFDLocBtn.Location = new System.Drawing.Point(247, 74);
            this.openFDLocBtn.Name = "openFDLocBtn";
            this.openFDLocBtn.Size = new System.Drawing.Size(55, 23);
            this.openFDLocBtn.TabIndex = 2;
            this.openFDLocBtn.Text = "Обзор";
            this.openFDLocBtn.UseVisualStyleBackColor = false;
            this.openFDLocBtn.Click += new System.EventHandler(this.openFDLocBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.openFDServBtn);
            this.groupBox5.Controls.Add(this.defaultServBtn);
            this.groupBox5.Controls.Add(this.pathServTb);
            this.groupBox5.Controls.Add(this.labelПуть);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.ForeColor = System.Drawing.Color.Linen;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(315, 159);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Настройка Общих Коллекций";
            // 
            // labelПуть
            // 
            this.labelПуть.AutoSize = true;
            this.labelПуть.Location = new System.Drawing.Point(7, 31);
            this.labelПуть.Name = "labelПуть";
            this.labelПуть.Size = new System.Drawing.Size(31, 13);
            this.labelПуть.TabIndex = 0;
            this.labelПуть.Text = "Путь";
            // 
            // pathServTb
            // 
            this.pathServTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathServTb.Location = new System.Drawing.Point(10, 48);
            this.pathServTb.Name = "pathServTb";
            this.pathServTb.Size = new System.Drawing.Size(283, 20);
            this.pathServTb.TabIndex = 1;
            // 
            // defaultServBtn
            // 
            this.defaultServBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultServBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.defaultServBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultServBtn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.defaultServBtn.Location = new System.Drawing.Point(139, 74);
            this.defaultServBtn.Name = "defaultServBtn";
            this.defaultServBtn.Size = new System.Drawing.Size(91, 23);
            this.defaultServBtn.TabIndex = 2;
            this.defaultServBtn.Text = "По умолчанию";
            this.defaultServBtn.UseVisualStyleBackColor = false;
            this.defaultServBtn.Click += new System.EventHandler(this.defaultServBtn_Click);
            // 
            // openFDServBtn
            // 
            this.openFDServBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openFDServBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openFDServBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFDServBtn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.openFDServBtn.Location = new System.Drawing.Point(236, 74);
            this.openFDServBtn.Name = "openFDServBtn";
            this.openFDServBtn.Size = new System.Drawing.Size(57, 23);
            this.openFDServBtn.TabIndex = 2;
            this.openFDServBtn.Text = "Обзор";
            this.openFDServBtn.UseVisualStyleBackColor = false;
            this.openFDServBtn.Click += new System.EventHandler(this.openFDServBtn_Click);
            // 
            // extOkBtn
            // 
            this.extOkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.extOkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.extOkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extOkBtn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.extOkBtn.Location = new System.Drawing.Point(231, 166);
            this.extOkBtn.Name = "extOkBtn";
            this.extOkBtn.Size = new System.Drawing.Size(75, 23);
            this.extOkBtn.TabIndex = 2;
            this.extOkBtn.Text = "OK";
            this.extOkBtn.UseVisualStyleBackColor = false;
            this.extOkBtn.Click += new System.EventHandler(this.extOkBtn_Click);
            // 
            // extCancelBtn
            // 
            this.extCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.extCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.extCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extCancelBtn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.extCancelBtn.Location = new System.Drawing.Point(312, 166);
            this.extCancelBtn.Name = "extCancelBtn";
            this.extCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.extCancelBtn.TabIndex = 2;
            this.extCancelBtn.Text = "Отмена";
            this.extCancelBtn.UseVisualStyleBackColor = false;
            this.extCancelBtn.Click += new System.EventHandler(this.extCancelBtn_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.jsonFile);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.ForeColor = System.Drawing.Color.Linen;
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(642, 41);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Текущая Коллекция";
            // 
            // jsonFile
            // 
            this.jsonFile.BackColor = System.Drawing.Color.LightSlateGray;
            this.jsonFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jsonFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jsonFile.ForeColor = System.Drawing.Color.White;
            this.jsonFile.Location = new System.Drawing.Point(3, 16);
            this.jsonFile.Name = "jsonFile";
            this.jsonFile.ReadOnly = true;
            this.jsonFile.Size = new System.Drawing.Size(636, 24);
            this.jsonFile.TabIndex = 30;
            this.jsonFile.Text = "File.Json";
            this.jsonFile.TextChanged += new System.EventHandler(this.jsonFile_TextChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this._listView);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.ForeColor = System.Drawing.Color.Linen;
            this.groupBox8.Location = new System.Drawing.Point(0, 41);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(642, 363);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Содержимое";
            // 
            // _listView
            // 
            this._listView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.file,
            this.size,
            this.type,
            this.fullPath});
            this._listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listView.HideSelection = false;
            this._listView.Location = new System.Drawing.Point(3, 16);
            this._listView.Name = "_listView";
            this._listView.Size = new System.Drawing.Size(636, 344);
            this._listView.TabIndex = 3;
            this._listView.UseCompatibleStateImageBehavior = false;
            this._listView.View = System.Windows.Forms.View.Details;
            this._listView.DoubleClick += new System.EventHandler(this._listView_DoubleClick);
            // 
            // file
            // 
            this.file.Text = "Файл";
            this.file.Width = 130;
            // 
            // size
            // 
            this.size.Text = "Размер (МБ)";
            this.size.Width = 76;
            // 
            // type
            // 
            this.type.Text = "Тип";
            this.type.Width = 38;
            // 
            // fullPath
            // 
            this.fullPath.Text = "Полный путь к файлу";
            this.fullPath.Width = 700;
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
            this.splitContainer4.Panel1.Controls.Add(this.groupBox8);
            this.splitContainer4.Panel1.Controls.Add(this.groupBox7);
            this.splitContainer4.Panel1MinSize = 200;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.extCancelBtn);
            this.splitContainer4.Panel2.Controls.Add(this.extOkBtn);
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Panel2MinSize = 200;
            this.splitContainer4.Size = new System.Drawing.Size(642, 680);
            this.splitContainer4.SplitterDistance = 404;
            this.splitContainer4.TabIndex = 4;
            this.splitContainer4.Visible = false;
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
            this.onOff.ResumeLayout(false);
            this.onOff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grBДанныеЗапроса.ResumeLayout(false);
            this.grBДанныеЗапроса.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataReqFctb)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.responseFctb)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
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
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button userautBtn;
        private System.Windows.Forms.TextBox adrServer;
        private System.Windows.Forms.Label labelСервер;
        private System.Windows.Forms.Label labelПорт;
        private System.Windows.Forms.TextBox adrPort;
        private System.Windows.Forms.Label labelМетод;
        private System.Windows.Forms.TextBox requestTB;
        private System.Windows.Forms.Label labelЗапрос;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPswrd;
        private System.Windows.Forms.GroupBox onOff;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox methodBox;
        private System.Windows.Forms.ComboBox Refs;
        private System.Windows.Forms.Button saveCashBtn;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelОбработкаЗапроса;
        private System.Windows.Forms.CheckBox ForceBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button deleteCashBtn;
        private System.Windows.Forms.Label labelКоллекции;
        private System.Windows.Forms.TextBox preRequestTB;
        private System.Windows.Forms.Label labelПрефикс;
        private System.Windows.Forms.Label labelStatusCode;
        private FastColoredTextBoxNS.FastColoredTextBox responseFctb;
        private FastColoredTextBoxNS.FastColoredTextBox dataReqFctb;
        private System.Windows.Forms.GroupBox grBДанныеЗапроса;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelИмя;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button extBtn;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TreeView _treeViewServ;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TreeView _treeViewLoc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каталогToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem коллекциюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ПереименоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBD;
        private System.Windows.Forms.GroupBox grBЗапросыВКоллекции;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ListView _listView;
        private System.Windows.Forms.ColumnHeader file;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader fullPath;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox jsonFile;
        private System.Windows.Forms.Button extCancelBtn;
        private System.Windows.Forms.Button extOkBtn;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button openFDServBtn;
        private System.Windows.Forms.Button defaultServBtn;
        private System.Windows.Forms.TextBox pathServTb;
        private System.Windows.Forms.Label labelПуть;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button openFDLocBtn;
        private System.Windows.Forms.Button defaultLocBtn;
        private System.Windows.Forms.TextBox pathLocTb;
        private System.Windows.Forms.Label labelПуть2;
    }
}


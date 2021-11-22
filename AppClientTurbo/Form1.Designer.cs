
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
            this.user = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.userauth = new System.Windows.Forms.Button();
            this.adrServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adrPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.request = new System.Windows.Forms.TextBox();
            this.dataReq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.responseTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.onOff = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.methodBox = new System.Windows.Forms.ComboBox();
            this.Refs = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.saveCash = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ForceBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.deleteCash = new System.Windows.Forms.Button();
            this.jsonFile = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label15 = new System.Windows.Forms.Label();
            this.onOff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.user.BackColor = System.Drawing.Color.LightSlateGray;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(997, 44);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(169, 26);
            this.user.TabIndex = 0;
            this.user.Text = "Пользователь";
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.password.BackColor = System.Drawing.Color.LightSlateGray;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(997, 76);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(169, 26);
            this.password.TabIndex = 1;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // userauth
            // 
            this.userauth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userauth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userauth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userauth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userauth.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.userauth.Location = new System.Drawing.Point(997, 118);
            this.userauth.Name = "userauth";
            this.userauth.Size = new System.Drawing.Size(79, 37);
            this.userauth.TabIndex = 2;
            this.userauth.Text = "Вход";
            this.userauth.UseVisualStyleBackColor = false;
            this.userauth.Click += new System.EventHandler(this.userauth_Click);
            // 
            // adrServer
            // 
            this.adrServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adrServer.BackColor = System.Drawing.Color.LightSlateGray;
            this.adrServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adrServer.ForeColor = System.Drawing.Color.White;
            this.adrServer.Location = new System.Drawing.Point(921, 12);
            this.adrServer.MaxLength = 15;
            this.adrServer.Name = "adrServer";
            this.adrServer.Size = new System.Drawing.Size(136, 26);
            this.adrServer.TabIndex = 3;
            this.adrServer.Text = "127.0.0.1";
            this.adrServer.TextChanged += new System.EventHandler(this.adrServer_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(860, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сервер";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(1063, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Порт";
            // 
            // adrPort
            // 
            this.adrPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adrPort.BackColor = System.Drawing.Color.LightSlateGray;
            this.adrPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adrPort.ForeColor = System.Drawing.Color.White;
            this.adrPort.Location = new System.Drawing.Point(1107, 12);
            this.adrPort.MaxLength = 5;
            this.adrPort.Name = "adrPort";
            this.adrPort.Size = new System.Drawing.Size(59, 26);
            this.adrPort.TabIndex = 6;
            this.adrPort.Text = "81";
            this.adrPort.TextChanged += new System.EventHandler(this.adrPort_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Linen;
            this.label3.Location = new System.Drawing.Point(5, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Метод";
            // 
            // request
            // 
            this.request.BackColor = System.Drawing.Color.LightSlateGray;
            this.request.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.request.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.request.ForeColor = System.Drawing.Color.White;
            this.request.Location = new System.Drawing.Point(214, 93);
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(291, 26);
            this.request.TabIndex = 10;
            this.request.Text = "RepairService/getDataRef";
            this.request.TextChanged += new System.EventHandler(this.request_TextChanged);
            // 
            // dataReq
            // 
            this.dataReq.BackColor = System.Drawing.Color.DimGray;
            this.dataReq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataReq.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.dataReq.Location = new System.Drawing.Point(0, 0);
            this.dataReq.Multiline = true;
            this.dataReq.Name = "dataReq";
            this.dataReq.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataReq.Size = new System.Drawing.Size(1049, 129);
            this.dataReq.TabIndex = 11;
            this.dataReq.Text = "{\"aRef\":\"FlowCharts.FlowChartsTypes\"}";
            this.dataReq.TextChanged += new System.EventHandler(this.dataReq_TextChanged);
            this.dataReq.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataReq_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Linen;
            this.label5.Location = new System.Drawing.Point(112, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Данные запроса";
            // 
            // responseTxt
            // 
            this.responseTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.responseTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.responseTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.responseTxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.responseTxt.ForeColor = System.Drawing.Color.Lime;
            this.responseTxt.Location = new System.Drawing.Point(0, 0);
            this.responseTxt.MaxLength = 65536;
            this.responseTxt.MinimumSize = new System.Drawing.Size(4, 300);
            this.responseTxt.Multiline = true;
            this.responseTxt.Name = "responseTxt";
            this.responseTxt.ReadOnly = true;
            this.responseTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.responseTxt.Size = new System.Drawing.Size(1049, 340);
            this.responseTxt.TabIndex = 13;
            this.responseTxt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.responseTxt_MouseMove);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Linen;
            this.label6.Location = new System.Drawing.Point(54, 613);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ответ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Linen;
            this.label4.Location = new System.Drawing.Point(143, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Запрос";
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.send.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.send.Location = new System.Drawing.Point(512, 86);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(105, 34);
            this.send.TabIndex = 16;
            this.send.Text = "Отправить";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Clear.Location = new System.Drawing.Point(12, 634);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(95, 32);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Linen;
            this.label7.Location = new System.Drawing.Point(945, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "user:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Linen;
            this.label8.Location = new System.Drawing.Point(905, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "password:";
            // 
            // onOff
            // 
            this.onOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.onOff.Controls.Add(this.pictureBox2);
            this.onOff.Controls.Add(this.pictureBox1);
            this.onOff.ForeColor = System.Drawing.Color.White;
            this.onOff.Location = new System.Drawing.Point(1087, 108);
            this.onOff.Name = "onOff";
            this.onOff.Size = new System.Drawing.Size(79, 56);
            this.onOff.TabIndex = 20;
            this.onOff.TabStop = false;
            this.onOff.Text = "On/Off";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(45, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 29);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 29);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // methodBox
            // 
            this.methodBox.BackColor = System.Drawing.Color.LightSlateGray;
            this.methodBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.methodBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.methodBox.FormattingEnabled = true;
            this.methodBox.Items.AddRange(new object[] {
            "POST",
            "GET",
            "PUT",
            "DELETE"});
            this.methodBox.Location = new System.Drawing.Point(70, 95);
            this.methodBox.Name = "methodBox";
            this.methodBox.Size = new System.Drawing.Size(68, 21);
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
            this.Refs.Location = new System.Drawing.Point(159, 53);
            this.Refs.Name = "Refs";
            this.Refs.Size = new System.Drawing.Size(386, 28);
            this.Refs.TabIndex = 22;
            this.Refs.Text = "-";
            this.Refs.SelectedIndexChanged += new System.EventHandler(this.Refs_SelectedIndexChanged);
            this.Refs.TextChanged += new System.EventHandler(this.Refs_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Linen;
            this.label9.Location = new System.Drawing.Point(5, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Что возвращаем?";
            // 
            // saveCash
            // 
            this.saveCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saveCash.Enabled = false;
            this.saveCash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveCash.ForeColor = System.Drawing.Color.Orange;
            this.saveCash.Location = new System.Drawing.Point(551, 55);
            this.saveCash.Name = "saveCash";
            this.saveCash.Size = new System.Drawing.Size(66, 22);
            this.saveCash.TabIndex = 24;
            this.saveCash.Text = "Save";
            this.saveCash.UseVisualStyleBackColor = false;
            this.saveCash.Click += new System.EventHandler(this.saveCash_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 0;
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
            this.listBox1.Size = new System.Drawing.Size(120, 96);
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
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(214, 138);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Linen;
            this.label13.Location = new System.Drawing.Point(44, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 18);
            this.label13.TabIndex = 27;
            this.label13.Text = "Обработка запроса";
            // 
            // ForceBox
            // 
            this.ForceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ForceBox.AutoSize = true;
            this.ForceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForceBox.ForeColor = System.Drawing.Color.Linen;
            this.ForceBox.Location = new System.Drawing.Point(959, 163);
            this.ForceBox.Name = "ForceBox";
            this.ForceBox.Size = new System.Drawing.Size(201, 22);
            this.ForceBox.TabIndex = 28;
            this.ForceBox.Text = "Принудительный вход";
            this.ForceBox.UseVisualStyleBackColor = true;
            this.ForceBox.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(113, 187);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataReq);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.responseTxt);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1053, 481);
            this.splitContainer1.SplitterDistance = 133;
            this.splitContainer1.TabIndex = 29;
            this.splitContainer1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseMove);
            // 
            // deleteCash
            // 
            this.deleteCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteCash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteCash.ForeColor = System.Drawing.Color.Orange;
            this.deleteCash.Location = new System.Drawing.Point(623, 55);
            this.deleteCash.Name = "deleteCash";
            this.deleteCash.Size = new System.Drawing.Size(66, 22);
            this.deleteCash.TabIndex = 24;
            this.deleteCash.Text = "Delete";
            this.deleteCash.UseVisualStyleBackColor = false;
            this.deleteCash.Click += new System.EventHandler(this.deleteCash_Click);
            // 
            // jsonFile
            // 
            this.jsonFile.BackColor = System.Drawing.Color.LightSlateGray;
            this.jsonFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jsonFile.ForeColor = System.Drawing.Color.White;
            this.jsonFile.Location = new System.Drawing.Point(134, 11);
            this.jsonFile.Name = "jsonFile";
            this.jsonFile.ReadOnly = true;
            this.jsonFile.Size = new System.Drawing.Size(456, 24);
            this.jsonFile.TabIndex = 30;
            this.jsonFile.Text = "File.Json";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(585, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 27);
            this.button3.TabIndex = 31;
            this.button3.Text = "...";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Файлы JSON|*.json";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(5, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 18);
            this.label15.TabIndex = 32;
            this.label15.Text = "Файл подкачки";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1176, 680);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.jsonFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ForceBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.deleteCash);
            this.Controls.Add(this.saveCash);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Refs);
            this.Controls.Add(this.methodBox);
            this.Controls.Add(this.onOff);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.send);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.request);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adrPort);
            this.Controls.Add(this.adrServer);
            this.Controls.Add(this.userauth);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Linen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "Form1";
            this.Text = "AppClientTurbo";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.onOff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button userauth;
        private System.Windows.Forms.TextBox adrServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adrPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox request;
        private System.Windows.Forms.TextBox dataReq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox responseTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox onOff;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox methodBox;
        private System.Windows.Forms.ComboBox Refs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button saveCash;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox ForceBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button deleteCash;
        private System.Windows.Forms.TextBox jsonFile;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label15;
    }
}


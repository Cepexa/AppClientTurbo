
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
            this.add = new System.Windows.Forms.Button();
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
            this.onOff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user.Location = new System.Drawing.Point(923, 53);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(169, 26);
            this.user.TabIndex = 0;
            this.user.Text = "Пользователь";
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(923, 85);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(169, 26);
            this.password.TabIndex = 1;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // userauth
            // 
            this.userauth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userauth.BackColor = System.Drawing.SystemColors.Control;
            this.userauth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userauth.Location = new System.Drawing.Point(923, 117);
            this.userauth.Name = "userauth";
            this.userauth.Size = new System.Drawing.Size(79, 56);
            this.userauth.TabIndex = 2;
            this.userauth.Text = "Вход";
            this.userauth.UseVisualStyleBackColor = false;
            this.userauth.Click += new System.EventHandler(this.userauth_Click);
            // 
            // adrServer
            // 
            this.adrServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adrServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adrServer.Location = new System.Drawing.Point(853, 21);
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
            this.label1.Location = new System.Drawing.Point(796, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сервер";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(995, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Порт";
            // 
            // adrPort
            // 
            this.adrPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adrPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adrPort.Location = new System.Drawing.Point(1033, 21);
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
            this.label3.Location = new System.Drawing.Point(25, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Метод";
            // 
            // request
            // 
            this.request.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.request.Location = new System.Drawing.Point(214, 93);
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(291, 26);
            this.request.TabIndex = 10;
            this.request.Text = "RepairService/getDataRef";
            // 
            // dataReq
            // 
            this.dataReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataReq.Location = new System.Drawing.Point(214, 124);
            this.dataReq.Multiline = true;
            this.dataReq.Name = "dataReq";
            this.dataReq.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataReq.Size = new System.Drawing.Size(420, 83);
            this.dataReq.TabIndex = 11;
            this.dataReq.Text = "{\"aRef\":\"FlowCharts.FlowChartsTypes\"}";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Данные запроса";
            // 
            // responseTxt
            // 
            this.responseTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.responseTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.responseTxt.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.responseTxt.Location = new System.Drawing.Point(96, 237);
            this.responseTxt.MaxLength = 65536;
            this.responseTxt.Multiline = true;
            this.responseTxt.Name = "responseTxt";
            this.responseTxt.ReadOnly = true;
            this.responseTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.responseTxt.Size = new System.Drawing.Size(996, 359);
            this.responseTxt.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ответ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Запрос";
            // 
            // send
            // 
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.send.Location = new System.Drawing.Point(511, 81);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(123, 38);
            this.send.TabIndex = 16;
            this.send.Text = "Отправить";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(96, 602);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(95, 32);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(887, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "user:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(865, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "password:";
            // 
            // onOff
            // 
            this.onOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.onOff.Controls.Add(this.pictureBox2);
            this.onOff.Controls.Add(this.pictureBox1);
            this.onOff.Location = new System.Drawing.Point(1013, 117);
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
            this.methodBox.FormattingEnabled = true;
            this.methodBox.Items.AddRange(new object[] {
            "POST",
            "GET",
            "PUT",
            "DELETE"});
            this.methodBox.Location = new System.Drawing.Point(70, 95);
            this.methodBox.Name = "methodBox";
            this.methodBox.Size = new System.Drawing.Size(91, 21);
            this.methodBox.TabIndex = 21;
            this.methodBox.Text = "POST";
            // 
            // Refs
            // 
            this.Refs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Refs.FormattingEnabled = true;
            this.Refs.Location = new System.Drawing.Point(214, 53);
            this.Refs.Name = "Refs";
            this.Refs.Size = new System.Drawing.Size(291, 28);
            this.Refs.TabIndex = 22;
            this.Refs.Text = "-";
            this.Refs.SelectedValueChanged += new System.EventHandler(this.Refs_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(96, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Что возвращаем?";
            // 
            // add
            // 
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Location = new System.Drawing.Point(512, 53);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(25, 22);
            this.add.TabIndex = 24;
            this.add.Text = "Edit";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.cancel);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(543, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 470);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактировать";
            this.groupBox1.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(136, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "НОВАЯ ЗАПИСЬ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(53, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 28);
            this.button2.TabIndex = 25;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(53, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(89, 251);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(285, 160);
            this.listBox1.TabIndex = 24;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(317, 441);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(57, 23);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(256, 441);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(57, 23);
            this.save.TabIndex = 0;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(18, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Что возвращаем?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Запрос";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Данные запроса";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(136, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(251, 60);
            this.textBox1.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(136, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(251, 21);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(136, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 21);
            this.textBox2.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(143, 194);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Обработка запроса";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 680);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Refs);
            this.Controls.Add(this.methodBox);
            this.Controls.Add(this.onOff);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.send);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.responseTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataReq);
            this.Controls.Add(this.request);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adrPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adrServer);
            this.Controls.Add(this.userauth);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.MinimumSize = new System.Drawing.Size(960, 500);
            this.Name = "Form1";
            this.Text = "AppClientTurbo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.onOff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Button add;
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
    }
}


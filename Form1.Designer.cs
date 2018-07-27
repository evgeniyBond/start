namespace Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Sportsmen = new System.Windows.Forms.ListBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txbpres = new System.Windows.Forms.TextBox();
            this.txbDist_m = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbRost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txbBetweenPlastin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMatMod = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnTrening = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фамилия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 423);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.Sportsmen);
            this.tabPage1.Controls.Add(this.btnOpen);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.btnRemove);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnMatMod);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.btnTrening);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание параметров";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 343);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 110;
            this.textBox1.Text = "Имя Фамилия";
            // 
            // Sportsmen
            // 
            this.Sportsmen.FormattingEnabled = true;
            this.Sportsmen.Location = new System.Drawing.Point(82, 265);
            this.Sportsmen.Name = "Sportsmen";
            this.Sportsmen.Size = new System.Drawing.Size(222, 30);
            this.Sportsmen.TabIndex = 109;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(359, 341);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(164, 39);
            this.btnOpen.TabIndex = 108;
            this.btnOpen.Text = "Загрузить профиль из базы";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 107;
            this.btnAdd.Text = "Add new";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(39, 315);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 106;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.txbpres);
            this.groupBox3.Controls.Add(this.txbDist_m);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(360, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 99);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Общие параметры";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(261, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 16);
            this.label17.TabIndex = 116;
            this.label17.Text = "мм рт ст";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(29, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 16);
            this.label19.TabIndex = 114;
            this.label19.Text = "Давление среды";
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.Location = new System.Drawing.Point(261, 65);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(17, 16);
            this.label32.TabIndex = 113;
            this.label32.Text = "м";
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.Location = new System.Drawing.Point(29, 65);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(78, 16);
            this.label31.TabIndex = 111;
            this.label31.Text = "Дистанция";
            // 
            // txbpres
            // 
            this.txbpres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbpres.Location = new System.Drawing.Point(151, 34);
            this.txbpres.Multiline = true;
            this.txbpres.Name = "txbpres";
            this.txbpres.Size = new System.Drawing.Size(100, 23);
            this.txbpres.TabIndex = 115;
            // 
            // txbDist_m
            // 
            this.txbDist_m.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDist_m.Location = new System.Drawing.Point(151, 63);
            this.txbDist_m.Multiline = true;
            this.txbDist_m.Name = "txbDist_m";
            this.txbDist_m.Size = new System.Drawing.Size(100, 23);
            this.txbDist_m.TabIndex = 112;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txbRost);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(360, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 104);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Характеристики спортсмена";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(190, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 21);
            this.label11.TabIndex = 71;
            this.label11.Text = "см";
            // 
            // txbRost
            // 
            this.txbRost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbRost.Location = new System.Drawing.Point(84, 28);
            this.txbRost.Multiline = true;
            this.txbRost.Name = "txbRost";
            this.txbRost.Size = new System.Drawing.Size(100, 23);
            this.txbRost.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Рост";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 21);
            this.label3.TabIndex = 72;
            this.label3.Text = "Опорная толчковая нога";
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(264, 54);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 25);
            this.radioButton1.TabIndex = 73;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Левая";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(264, 79);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 25);
            this.radioButton2.TabIndex = 74;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Правая";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txbBetweenPlastin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(360, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 70);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характеристики колодок";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(322, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 21);
            this.label16.TabIndex = 88;
            this.label16.Text = "см";
            // 
            // txbBetweenPlastin
            // 
            this.txbBetweenPlastin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbBetweenPlastin.Location = new System.Drawing.Point(216, 36);
            this.txbBetweenPlastin.Multiline = true;
            this.txbBetweenPlastin.Name = "txbBetweenPlastin";
            this.txbBetweenPlastin.Size = new System.Drawing.Size(100, 23);
            this.txbBetweenPlastin.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "Расстояние между колодками";
            // 
            // btnMatMod
            // 
            this.btnMatMod.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatMod.Location = new System.Drawing.Point(529, 341);
            this.btnMatMod.Name = "btnMatMod";
            this.btnMatMod.Size = new System.Drawing.Size(190, 39);
            this.btnMatMod.TabIndex = 62;
            this.btnMatMod.Text = "Рассчитать характеристики";
            this.btnMatMod.UseVisualStyleBackColor = true;
            this.btnMatMod.Click += new System.EventHandler(this.btnMatMod_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(188, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker1.TabIndex = 60;
            // 
            // btnTrening
            // 
            this.btnTrening.Location = new System.Drawing.Point(18, 6);
            this.btnTrening.Name = "btnTrening";
            this.btnTrening.Size = new System.Drawing.Size(153, 23);
            this.btnTrening.TabIndex = 59;
            this.btnTrening.Text = "Дата тренировки";
            this.btnTrening.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnInsert);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Данные";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(589, 343);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(135, 35);
            this.btnInsert.TabIndex = 27;
            this.btnInsert.Text = "Внести данные в БД";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(207, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(340, 29);
            this.label15.TabIndex = 25;
            this.label15.Text = "Данные для оптимизации";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column11});
            this.dataGridView3.Location = new System.Drawing.Point(8, 206);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(728, 116);
            this.dataGridView3.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Имя,
            this.Фамилия,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column7,
            this.Column8});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 145);
            this.dataGridView1.TabIndex = 20;
            // 
            // Имя
            // 
            this.Имя.HeaderText = "Имя";
            this.Имя.Name = "Имя";
            // 
            // Фамилия
            // 
            this.Фамилия.HeaderText = "Фамилия";
            this.Фамилия.Name = "Фамилия";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Рост";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дистанция";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Время";
            this.Column4.Name = "Column4";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Скорость";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Давление";
            this.Column8.Name = "Column8";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Угол наклона колодки, аlfa";
            this.Column12.Name = "Column12";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Расстояние между колодками";
            this.Column11.Name = "Column11";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 423);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Старт";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnMatMod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnTrening;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txbpres;
        private System.Windows.Forms.TextBox txbDist_m;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbRost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txbBetweenPlastin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фамилия;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ListBox Sportsmen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Label label4;
    }
}


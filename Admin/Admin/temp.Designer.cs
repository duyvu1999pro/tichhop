namespace Admin
{
    partial class temp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(temp));
            this.nhan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cc = new System.Windows.Forms.ComboBox();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pan_edit = new System.Windows.Forms.Panel();
            this.but_edit = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.phanloai = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.but2 = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.but_add = new System.Windows.Forms.Button();
            this.search_but = new System.Windows.Forms.Button();
            this.but_home = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.han = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.pan_edit.SuspendLayout();
            this.p2.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // nhan
            // 
            this.nhan.BackColor = System.Drawing.Color.White;
            this.nhan.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(120)))));
            this.nhan.Location = new System.Drawing.Point(703, 81);
            this.nhan.Multiline = true;
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(191, 30);
            this.nhan.TabIndex = 97;
            this.nhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label6.Location = new System.Drawing.Point(691, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 96;
            this.label6.Text = "Nhãn";
            // 
            // cc
            // 
            this.cc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cc.FormattingEnabled = true;
            this.cc.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10"});
            this.cc.Location = new System.Drawing.Point(790, 26);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(48, 28);
            this.cc.TabIndex = 142;
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToResizeColumns = false;
            this.gridView.AllowUserToResizeRows = false;
            this.gridView.BackgroundColor = System.Drawing.Color.White;
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(28)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.ColumnHeadersHeight = 60;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.id,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridView.EnableHeadersVisualStyles = false;
            this.gridView.GridColor = System.Drawing.Color.White;
            this.gridView.Location = new System.Drawing.Point(30, 12);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowTemplate.Height = 40;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(356, 203);
            this.gridView.TabIndex = 273;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "id";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 30;
            // 
            // id
            // 
            this.id.DataPropertyName = "ten";
            this.id.HeaderText = "lorem...";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 200;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "han";
            this.Column1.HeaderText = "lorem....";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // pan_edit
            // 
            this.pan_edit.Controls.Add(this.but_edit);
            this.pan_edit.Controls.Add(this.but_del);
            this.pan_edit.Location = new System.Drawing.Point(152, 339);
            this.pan_edit.Name = "pan_edit";
            this.pan_edit.Size = new System.Drawing.Size(212, 98);
            this.pan_edit.TabIndex = 276;
            this.pan_edit.Visible = false;
            // 
            // but_edit
            // 
            this.but_edit.BackColor = System.Drawing.Color.White;
            this.but_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_edit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.but_edit.FlatAppearance.BorderSize = 0;
            this.but_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_edit.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_edit.ForeColor = System.Drawing.Color.White;
            this.but_edit.Image = global::Admin.Properties.Resources.edit_64_bac;
            this.but_edit.Location = new System.Drawing.Point(15, 8);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(76, 78);
            this.but_edit.TabIndex = 210;
            this.but_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_edit.UseVisualStyleBackColor = false;
            // 
            // but_del
            // 
            this.but_del.BackColor = System.Drawing.Color.White;
            this.but_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_del.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.but_del.FlatAppearance.BorderSize = 0;
            this.but_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_del.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_del.ForeColor = System.Drawing.Color.White;
            this.but_del.Image = global::Admin.Properties.Resources.delete_64;
            this.but_del.Location = new System.Drawing.Point(134, 8);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(65, 78);
            this.but_del.TabIndex = 206;
            this.but_del.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_del.UseVisualStyleBackColor = false;
            // 
            // phanloai
            // 
            this.phanloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.phanloai.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phanloai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.phanloai.FormattingEnabled = true;
            this.phanloai.Items.AddRange(new object[] {
            "Thường",
            "Chuyên ngành"});
            this.phanloai.Location = new System.Drawing.Point(401, 148);
            this.phanloai.Name = "phanloai";
            this.phanloai.Size = new System.Drawing.Size(228, 31);
            this.phanloai.TabIndex = 277;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(591, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 614);
            this.panel1.TabIndex = 278;
            // 
            // p2
            // 
            this.p2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.p2.Controls.Add(this.button1);
            this.p2.Controls.Add(this.button9);
            this.p2.Controls.Add(this.button10);
            this.p2.Controls.Add(this.panel10);
            this.p2.Location = new System.Drawing.Point(214, 255);
            this.p2.MaximumSize = new System.Drawing.Size(200, 180);
            this.p2.MinimumSize = new System.Drawing.Size(1, 60);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(163, 60);
            this.p2.TabIndex = 279;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "3";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(0, 100);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(163, 40);
            this.button9.TabIndex = 4;
            this.button9.Text = "2";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(0, 60);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(163, 40);
            this.button10.TabIndex = 3;
            this.button10.Text = "1";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.but2);
            this.panel10.Controls.Add(this.pictureBox8);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(163, 60);
            this.panel10.TabIndex = 6;
            // 
            // but2
            // 
            this.but2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.but2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but2.Enabled = false;
            this.but2.FlatAppearance.BorderSize = 0;
            this.but2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.but2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.but2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but2.ForeColor = System.Drawing.Color.White;
            this.but2.Image = ((System.Drawing.Image)(resources.GetObject("but2.Image")));
            this.but2.Location = new System.Drawing.Point(32, 0);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(131, 60);
            this.but2.TabIndex = 18;
            this.but2.Text = "Mặt hàng";
            this.but2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but2.UseVisualStyleBackColor = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox8.Location = new System.Drawing.Point(0, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 60);
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // but_add
            // 
            this.but_add.BackColor = System.Drawing.Color.White;
            this.but_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_add.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.but_add.FlatAppearance.BorderSize = 0;
            this.but_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.but_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_add.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_add.ForeColor = System.Drawing.Color.White;
            this.but_add.Image = global::Admin.Properties.Resources.add2;
            this.but_add.Location = new System.Drawing.Point(648, 237);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(141, 139);
            this.but_add.TabIndex = 275;
            this.but_add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_add.UseVisualStyleBackColor = false;
            // 
            // search_but
            // 
            this.search_but.BackColor = System.Drawing.Color.White;
            this.search_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.search_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_but.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.search_but.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.search_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_but.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(106)))), ((int)(((byte)(155)))));
            this.search_but.Image = ((System.Drawing.Image)(resources.GetObject("search_but.Image")));
            this.search_but.Location = new System.Drawing.Point(461, 288);
            this.search_but.Name = "search_but";
            this.search_but.Size = new System.Drawing.Size(42, 38);
            this.search_but.TabIndex = 274;
            this.search_but.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.search_but.UseVisualStyleBackColor = false;
            // 
            // but_home
            // 
            this.but_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.but_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_home.FlatAppearance.BorderSize = 0;
            this.but_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.but_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.but_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_home.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_home.ForeColor = System.Drawing.Color.White;
            this.but_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_home.Location = new System.Drawing.Point(383, 365);
            this.but_home.Name = "but_home";
            this.but_home.Size = new System.Drawing.Size(163, 60);
            this.but_home.TabIndex = 280;
            this.but_home.Text = " Trang chủ";
            this.but_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_home.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(224, 484);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 281;
            // 
            // han
            // 
            this.han.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.han.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.han.Location = new System.Drawing.Point(418, 294);
            this.han.Name = "han";
            this.han.Size = new System.Drawing.Size(129, 26);
            this.han.TabIndex = 282;
            this.han.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(429, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 77);
            this.button2.TabIndex = 283;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 614);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.han);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.but_home);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.phanloai);
            this.Controls.Add(this.pan_edit);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.search_but);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.nhan);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "temp";
            this.Text = "temp";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.pan_edit.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cc;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button search_but;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Panel pan_edit;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.ComboBox phanloai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button but_home;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker han;
        private System.Windows.Forms.Button button2;
    }
}
namespace Admin
{
    partial class Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.gridView = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthuoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.thanhphan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lieuluong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dongia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.donvi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dangthuoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.urlanh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.search_but = new System.Windows.Forms.Button();
            this.pan_edit = new System.Windows.Forms.Panel();
            this.but_edit = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.kind_add = new System.Windows.Forms.Button();
            this.text_add = new System.Windows.Forms.TextBox();
            this.kind = new System.Windows.Forms.ComboBox();
            this.kind_del = new System.Windows.Forms.Button();
            this.but_back = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.congdung = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mota = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.pan_edit.SuspendLayout();
            this.SuspendLayout();
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
            this.Column,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridView.EnableHeadersVisualStyles = false;
            this.gridView.GridColor = System.Drawing.Color.White;
            this.gridView.Location = new System.Drawing.Point(25, 12);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowTemplate.Height = 40;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(353, 590);
            this.gridView.TabIndex = 274;
            this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
            // 
            // Column
            // 
            this.Column.DataPropertyName = "MaSP";
            this.Column.HeaderText = "Mã";
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenSP";
            this.Column1.HeaderText = "Tên thuốc";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // tenthuoc
            // 
            this.tenthuoc.BackColor = System.Drawing.Color.White;
            this.tenthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenthuoc.ForeColor = System.Drawing.Color.Black;
            this.tenthuoc.Location = new System.Drawing.Point(480, 116);
            this.tenthuoc.Multiline = true;
            this.tenthuoc.Name = "tenthuoc";
            this.tenthuoc.Size = new System.Drawing.Size(342, 34);
            this.tenthuoc.TabIndex = 276;
            this.tenthuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label6.Location = new System.Drawing.Point(463, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 275;
            this.label6.Text = "Tên thuốc";
            // 
            // thanhphan
            // 
            this.thanhphan.BackColor = System.Drawing.Color.White;
            this.thanhphan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanhphan.ForeColor = System.Drawing.Color.Black;
            this.thanhphan.Location = new System.Drawing.Point(480, 237);
            this.thanhphan.Multiline = true;
            this.thanhphan.Name = "thanhphan";
            this.thanhphan.Size = new System.Drawing.Size(472, 30);
            this.thanhphan.TabIndex = 278;
            this.thanhphan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(468, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 277;
            this.label1.Text = "Thành phần";
            // 
            // lieuluong
            // 
            this.lieuluong.BackColor = System.Drawing.Color.White;
            this.lieuluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lieuluong.ForeColor = System.Drawing.Color.Black;
            this.lieuluong.Location = new System.Drawing.Point(847, 135);
            this.lieuluong.Multiline = true;
            this.lieuluong.Name = "lieuluong";
            this.lieuluong.Size = new System.Drawing.Size(105, 86);
            this.lieuluong.TabIndex = 280;
            this.lieuluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(836, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 279;
            this.label2.Text = "Liều lượng";
            // 
            // dongia
            // 
            this.dongia.BackColor = System.Drawing.Color.White;
            this.dongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongia.ForeColor = System.Drawing.Color.Black;
            this.dongia.Location = new System.Drawing.Point(704, 294);
            this.dongia.Multiline = true;
            this.dongia.Name = "dongia";
            this.dongia.Size = new System.Drawing.Size(96, 30);
            this.dongia.TabIndex = 282;
            this.dongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(701, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 281;
            this.label3.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(609, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 283;
            this.label4.Text = "Danh mục";
            // 
            // donvi
            // 
            this.donvi.BackColor = System.Drawing.Color.White;
            this.donvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donvi.ForeColor = System.Drawing.Color.Black;
            this.donvi.Location = new System.Drawing.Point(838, 294);
            this.donvi.Multiline = true;
            this.donvi.Name = "donvi";
            this.donvi.Size = new System.Drawing.Size(114, 30);
            this.donvi.TabIndex = 286;
            this.donvi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label5.Location = new System.Drawing.Point(824, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 285;
            this.label5.Text = "Đơn vị";
            // 
            // dangthuoc
            // 
            this.dangthuoc.BackColor = System.Drawing.Color.White;
            this.dangthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangthuoc.ForeColor = System.Drawing.Color.Black;
            this.dangthuoc.Location = new System.Drawing.Point(480, 294);
            this.dangthuoc.Multiline = true;
            this.dangthuoc.Name = "dangthuoc";
            this.dangthuoc.Size = new System.Drawing.Size(191, 30);
            this.dangthuoc.TabIndex = 288;
            this.dangthuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label7.Location = new System.Drawing.Point(468, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 287;
            this.label7.Text = "Dạng thuốc";
            // 
            // urlanh
            // 
            this.urlanh.BackColor = System.Drawing.Color.White;
            this.urlanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlanh.ForeColor = System.Drawing.Color.Black;
            this.urlanh.Location = new System.Drawing.Point(480, 356);
            this.urlanh.Multiline = true;
            this.urlanh.Name = "urlanh";
            this.urlanh.Size = new System.Drawing.Size(191, 30);
            this.urlanh.TabIndex = 290;
            this.urlanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label8.Location = new System.Drawing.Point(466, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 289;
            this.label8.Text = "URL Ảnh";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(446, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 614);
            this.panel1.TabIndex = 291;
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
            this.search_but.Location = new System.Drawing.Point(384, 12);
            this.search_but.Name = "search_but";
            this.search_but.Size = new System.Drawing.Size(42, 38);
            this.search_but.TabIndex = 293;
            this.search_but.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.search_but.UseVisualStyleBackColor = false;
            this.search_but.Click += new System.EventHandler(this.search_but_Click);
            // 
            // pan_edit
            // 
            this.pan_edit.Controls.Add(this.but_edit);
            this.pan_edit.Controls.Add(this.but_del);
            this.pan_edit.Location = new System.Drawing.Point(601, 504);
            this.pan_edit.Name = "pan_edit";
            this.pan_edit.Size = new System.Drawing.Size(212, 98);
            this.pan_edit.TabIndex = 294;
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
            this.but_edit.Click += new System.EventHandler(this.sua);
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
            this.but_del.Click += new System.EventHandler(this.xoa);
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
            this.but_add.Location = new System.Drawing.Point(637, 441);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(141, 139);
            this.but_add.TabIndex = 297;
            this.but_add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_add.UseVisualStyleBackColor = false;
            this.but_add.Click += new System.EventHandler(this.them);
            // 
            // kind_add
            // 
            this.kind_add.BackColor = System.Drawing.Color.White;
            this.kind_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.kind_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kind_add.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.kind_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kind_add.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kind_add.ForeColor = System.Drawing.Color.Black;
            this.kind_add.Location = new System.Drawing.Point(838, 33);
            this.kind_add.Name = "kind_add";
            this.kind_add.Size = new System.Drawing.Size(32, 31);
            this.kind_add.TabIndex = 298;
            this.kind_add.Text = "+";
            this.kind_add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.kind_add.UseVisualStyleBackColor = false;
            this.kind_add.Click += new System.EventHandler(this.open_kind);
            // 
            // text_add
            // 
            this.text_add.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_add.Location = new System.Drawing.Point(540, 33);
            this.text_add.MaxLength = 16;
            this.text_add.Multiline = true;
            this.text_add.Name = "text_add";
            this.text_add.Size = new System.Drawing.Size(291, 31);
            this.text_add.TabIndex = 299;
            this.text_add.Visible = false;
            this.text_add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.add_kind);
            // 
            // kind
            // 
            this.kind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kind.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kind.FormattingEnabled = true;
            this.kind.Location = new System.Drawing.Point(540, 33);
            this.kind.Name = "kind";
            this.kind.Size = new System.Drawing.Size(291, 31);
            this.kind.TabIndex = 300;
            this.kind.SelectedIndexChanged += new System.EventHandler(this.kind_SelectedIndexChanged);
            // 
            // kind_del
            // 
            this.kind_del.BackColor = System.Drawing.Color.White;
            this.kind_del.BackgroundImage = global::Admin.Properties.Resources.del_red;
            this.kind_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kind_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kind_del.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.kind_del.FlatAppearance.BorderSize = 0;
            this.kind_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kind_del.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kind_del.ForeColor = System.Drawing.Color.Black;
            this.kind_del.Location = new System.Drawing.Point(502, 33);
            this.kind_del.Name = "kind_del";
            this.kind_del.Size = new System.Drawing.Size(32, 31);
            this.kind_del.TabIndex = 301;
            this.kind_del.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.kind_del.UseVisualStyleBackColor = false;
            this.kind_del.Visible = false;
            this.kind_del.Click += new System.EventHandler(this.del_kind);
            // 
            // but_back
            // 
            this.but_back.BackColor = System.Drawing.Color.White;
            this.but_back.BackgroundImage = global::Admin.Properties.Resources.back_32;
            this.but_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.but_back.FlatAppearance.BorderSize = 0;
            this.but_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.but_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_back.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_back.ForeColor = System.Drawing.Color.White;
            this.but_back.Location = new System.Drawing.Point(900, 56);
            this.but_back.Name = "but_back";
            this.but_back.Size = new System.Drawing.Size(52, 38);
            this.but_back.TabIndex = 302;
            this.but_back.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_back.UseVisualStyleBackColor = false;
            this.but_back.Visible = false;
            this.but_back.Click += new System.EventHandler(this.but_back_Click);
            // 
            // search_box
            // 
            this.search_box.BackColor = System.Drawing.Color.White;
            this.search_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.search_box.Location = new System.Drawing.Point(222, 56);
            this.search_box.MaxLength = 16;
            this.search_box.Multiline = true;
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(204, 38);
            this.search_box.TabIndex = 303;
            this.search_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search_box.Visible = false;
            this.search_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_box_KeyDown);
            // 
            // congdung
            // 
            this.congdung.BackColor = System.Drawing.Color.White;
            this.congdung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congdung.ForeColor = System.Drawing.Color.Black;
            this.congdung.Location = new System.Drawing.Point(480, 180);
            this.congdung.Multiline = true;
            this.congdung.Name = "congdung";
            this.congdung.Size = new System.Drawing.Size(342, 30);
            this.congdung.TabIndex = 305;
            this.congdung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label10.Location = new System.Drawing.Point(468, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 304;
            this.label10.Text = "Công dụng";
            // 
            // mota
            // 
            this.mota.BackColor = System.Drawing.Color.White;
            this.mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mota.ForeColor = System.Drawing.Color.Black;
            this.mota.Location = new System.Drawing.Point(704, 356);
            this.mota.Multiline = true;
            this.mota.Name = "mota";
            this.mota.Size = new System.Drawing.Size(247, 69);
            this.mota.TabIndex = 307;
            this.mota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label11.Location = new System.Drawing.Point(690, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 18);
            this.label11.TabIndex = 306;
            this.label11.Text = "Mô tả";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 614);
            this.Controls.Add(this.mota);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.congdung);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.but_back);
            this.Controls.Add(this.kind_del);
            this.Controls.Add(this.text_add);
            this.Controls.Add(this.kind);
            this.Controls.Add(this.kind_add);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.pan_edit);
            this.Controls.Add(this.search_but);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.urlanh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dangthuoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.donvi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dongia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lieuluong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.thanhphan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tenthuoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.pan_edit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.TextBox tenthuoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox thanhphan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lieuluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dongia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox donvi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dangthuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox urlanh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button search_but;
        private System.Windows.Forms.Panel pan_edit;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button kind_add;
        private System.Windows.Forms.TextBox text_add;
        private System.Windows.Forms.ComboBox kind;
        private System.Windows.Forms.Button kind_del;
        private System.Windows.Forms.Button but_back;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.TextBox congdung;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox mota;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
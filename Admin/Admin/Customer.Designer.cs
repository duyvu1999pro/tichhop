namespace Admin
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.pan_edit = new System.Windows.Forms.Panel();
            this.but_edit = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ten = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.TextBox();
            this.but_back = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.search_but = new System.Windows.Forms.Button();
            this.pan_edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_edit
            // 
            this.pan_edit.Controls.Add(this.but_edit);
            this.pan_edit.Controls.Add(this.but_del);
            this.pan_edit.Location = new System.Drawing.Point(646, 445);
            this.pan_edit.Name = "pan_edit";
            this.pan_edit.Size = new System.Drawing.Size(212, 98);
            this.pan_edit.TabIndex = 301;
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
            this.but_add.Location = new System.Drawing.Point(683, 416);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(141, 139);
            this.but_add.TabIndex = 300;
            this.but_add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.but_add.UseVisualStyleBackColor = false;
            this.but_add.Click += new System.EventHandler(this.them);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(548, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 296;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(757, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 294;
            this.label1.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label6.Location = new System.Drawing.Point(539, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 18);
            this.label6.TabIndex = 292;
            this.label6.Text = "Số điện thoại";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(516, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 614);
            this.panel1.TabIndex = 291;
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
            this.id,
            this.tenn});
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
            this.gridView.Location = new System.Drawing.Point(64, 12);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowTemplate.Height = 40;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(363, 590);
            this.gridView.TabIndex = 290;
            this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "MaKH";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.HeaderText = "";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // tenn
            // 
            this.tenn.DataPropertyName = "HoTen";
            this.tenn.HeaderText = "Tên Khách hàng";
            this.tenn.Name = "tenn";
            this.tenn.ReadOnly = true;
            this.tenn.Width = 300;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(539, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 302;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(92)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(539, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 304;
            this.label4.Text = "Địa chỉ";
            // 
            // ten
            // 
            this.ten.BackColor = System.Drawing.Color.White;
            this.ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten.ForeColor = System.Drawing.Color.Black;
            this.ten.Location = new System.Drawing.Point(551, 95);
            this.ten.Multiline = true;
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(401, 30);
            this.ten.TabIndex = 305;
            this.ten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sdt
            // 
            this.sdt.BackColor = System.Drawing.Color.White;
            this.sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdt.ForeColor = System.Drawing.Color.Black;
            this.sdt.Location = new System.Drawing.Point(551, 161);
            this.sdt.Multiline = true;
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(191, 30);
            this.sdt.TabIndex = 306;
            this.sdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.White;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.Location = new System.Drawing.Point(551, 219);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(401, 30);
            this.email.TabIndex = 307;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matkhau
            // 
            this.matkhau.BackColor = System.Drawing.Color.White;
            this.matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.ForeColor = System.Drawing.Color.Black;
            this.matkhau.Location = new System.Drawing.Point(760, 161);
            this.matkhau.Multiline = true;
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(192, 30);
            this.matkhau.TabIndex = 308;
            this.matkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // diachi
            // 
            this.diachi.BackColor = System.Drawing.Color.White;
            this.diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diachi.ForeColor = System.Drawing.Color.Black;
            this.diachi.Location = new System.Drawing.Point(551, 276);
            this.diachi.Multiline = true;
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(401, 64);
            this.diachi.TabIndex = 309;
            this.diachi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.but_back.Location = new System.Drawing.Point(900, 37);
            this.but_back.Name = "but_back";
            this.but_back.Size = new System.Drawing.Size(52, 38);
            this.but_back.TabIndex = 310;
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
            this.search_box.Location = new System.Drawing.Point(306, 65);
            this.search_box.MaxLength = 16;
            this.search_box.Multiline = true;
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(204, 38);
            this.search_box.TabIndex = 312;
            this.search_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search_box.Visible = false;
            this.search_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_box_KeyDown);
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
            this.search_but.Location = new System.Drawing.Point(433, 21);
            this.search_but.Name = "search_but";
            this.search_but.Size = new System.Drawing.Size(42, 38);
            this.search_but.TabIndex = 311;
            this.search_but.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.search_but.UseVisualStyleBackColor = false;
            this.search_but.Click += new System.EventHandler(this.search_but_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 614);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.search_but);
            this.Controls.Add(this.but_back);
            this.Controls.Add(this.diachi);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.email);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pan_edit);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Customer";
            this.pan_edit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pan_edit;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ten;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.Button but_back;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button search_but;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenn;
    }
}
namespace _97291_MinhQuang
{
    partial class FrmChucVu
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_find_depart = new System.Windows.Forms.Button();
            this.txt_find_pc = new System.Windows.Forms.TextBox();
            this.cb_find_pc = new System.Windows.Forms.CheckBox();
            this.txt_find_luong = new System.Windows.Forms.TextBox();
            this.cb_find_luong = new System.Windows.Forms.CheckBox();
            this.cb_find_depart = new System.Windows.Forms.CheckBox();
            this.txt_find_id = new System.Windows.Forms.TextBox();
            this.cb_find_id = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_phucap = new System.Windows.Forms.TextBox();
            this.txt_mucluong = new System.Windows.Forms.TextBox();
            this.txt_ma_cv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_load_cv = new System.Windows.Forms.DataGridView();
            this.colMaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMucLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erp_loi = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_find_ten_cv = new System.Windows.Forms.TextBox();
            this.txt_ten_cv = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_load_cv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_loi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_find_ten_cv);
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_find_depart);
            this.groupBox1.Controls.Add(this.txt_find_pc);
            this.groupBox1.Controls.Add(this.cb_find_pc);
            this.groupBox1.Controls.Add(this.txt_find_luong);
            this.groupBox1.Controls.Add(this.cb_find_luong);
            this.groupBox1.Controls.Add(this.cb_find_depart);
            this.groupBox1.Controls.Add(this.txt_find_id);
            this.groupBox1.Controls.Add(this.cb_find_id);
            this.groupBox1.Location = new System.Drawing.Point(11, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 817);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tim Kiem";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(21, 533);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(263, 45);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(21, 482);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(263, 45);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_find_depart
            // 
            this.btn_find_depart.Location = new System.Drawing.Point(24, 431);
            this.btn_find_depart.Name = "btn_find_depart";
            this.btn_find_depart.Size = new System.Drawing.Size(263, 45);
            this.btn_find_depart.TabIndex = 9;
            this.btn_find_depart.Text = "Tim Kiem";
            this.btn_find_depart.UseVisualStyleBackColor = true;
            this.btn_find_depart.Click += new System.EventHandler(this.btn_find_depart_Click);
            // 
            // txt_find_pc
            // 
            this.txt_find_pc.Location = new System.Drawing.Point(22, 382);
            this.txt_find_pc.Name = "txt_find_pc";
            this.txt_find_pc.Size = new System.Drawing.Size(266, 24);
            this.txt_find_pc.TabIndex = 8;
            this.txt_find_pc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_find_pc_KeyPress);
            // 
            // cb_find_pc
            // 
            this.cb_find_pc.AutoSize = true;
            this.cb_find_pc.Location = new System.Drawing.Point(27, 354);
            this.cb_find_pc.Name = "cb_find_pc";
            this.cb_find_pc.Size = new System.Drawing.Size(87, 22);
            this.cb_find_pc.TabIndex = 7;
            this.cb_find_pc.Text = "Phu Cap";
            this.cb_find_pc.UseVisualStyleBackColor = true;
            // 
            // txt_find_luong
            // 
            this.txt_find_luong.Location = new System.Drawing.Point(21, 265);
            this.txt_find_luong.Name = "txt_find_luong";
            this.txt_find_luong.Size = new System.Drawing.Size(266, 24);
            this.txt_find_luong.TabIndex = 6;
            this.txt_find_luong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_find_luong_KeyPress);
            // 
            // cb_find_luong
            // 
            this.cb_find_luong.AutoSize = true;
            this.cb_find_luong.Location = new System.Drawing.Point(22, 237);
            this.cb_find_luong.Name = "cb_find_luong";
            this.cb_find_luong.Size = new System.Drawing.Size(104, 22);
            this.cb_find_luong.TabIndex = 4;
            this.cb_find_luong.Text = "Muc Luong";
            this.cb_find_luong.UseVisualStyleBackColor = true;
            // 
            // cb_find_depart
            // 
            this.cb_find_depart.AutoSize = true;
            this.cb_find_depart.Location = new System.Drawing.Point(27, 126);
            this.cb_find_depart.Name = "cb_find_depart";
            this.cb_find_depart.Size = new System.Drawing.Size(115, 22);
            this.cb_find_depart.TabIndex = 2;
            this.cb_find_depart.Text = "Ten Chuc Vu";
            this.cb_find_depart.UseVisualStyleBackColor = true;
            // 
            // txt_find_id
            // 
            this.txt_find_id.Location = new System.Drawing.Point(22, 53);
            this.txt_find_id.Name = "txt_find_id";
            this.txt_find_id.Size = new System.Drawing.Size(266, 24);
            this.txt_find_id.TabIndex = 1;
            this.txt_find_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_find_id_KeyPress);
            // 
            // cb_find_id
            // 
            this.cb_find_id.AutoSize = true;
            this.cb_find_id.Location = new System.Drawing.Point(27, 25);
            this.cb_find_id.Name = "cb_find_id";
            this.cb_find_id.Size = new System.Drawing.Size(111, 22);
            this.cb_find_id.TabIndex = 0;
            this.cb_find_id.Text = "Ma Chuc Vu";
            this.cb_find_id.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_ten_cv);
            this.groupBox2.Controls.Add(this.txt_phucap);
            this.groupBox2.Controls.Add(this.txt_mucluong);
            this.groupBox2.Controls.Add(this.txt_ma_cv);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(346, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(905, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thong tin ";
            // 
            // txt_phucap
            // 
            this.txt_phucap.Location = new System.Drawing.Point(131, 133);
            this.txt_phucap.Name = "txt_phucap";
            this.txt_phucap.Size = new System.Drawing.Size(266, 24);
            this.txt_phucap.TabIndex = 14;
            this.txt_phucap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phucap_KeyPress);
            // 
            // txt_mucluong
            // 
            this.txt_mucluong.Location = new System.Drawing.Point(131, 96);
            this.txt_mucluong.Name = "txt_mucluong";
            this.txt_mucluong.Size = new System.Drawing.Size(266, 24);
            this.txt_mucluong.TabIndex = 13;
            this.txt_mucluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mucluong_KeyPress);
            // 
            // txt_ma_cv
            // 
            this.txt_ma_cv.Location = new System.Drawing.Point(131, 27);
            this.txt_ma_cv.Name = "txt_ma_cv";
            this.txt_ma_cv.Size = new System.Drawing.Size(266, 24);
            this.txt_ma_cv.TabIndex = 12;
            this.txt_ma_cv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ma_cv_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "PhuCap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "MucLuong";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "TenChucVu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaChucVu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_xoa);
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Location = new System.Drawing.Point(346, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(905, 97);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chuc nang";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(329, 35);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(145, 45);
            this.btn_xoa.TabIndex = 14;
            this.btn_xoa.Text = "Xoa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(178, 35);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(145, 45);
            this.btn_sua.TabIndex = 13;
            this.btn_sua.Text = "Sua";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(27, 35);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(145, 45);
            this.btn_them.TabIndex = 12;
            this.btn_them.Text = "Them";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_load_cv);
            this.groupBox4.Location = new System.Drawing.Point(346, 411);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(905, 412);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Du lieu";
            // 
            // dgv_load_cv
            // 
            this.dgv_load_cv.AllowUserToAddRows = false;
            this.dgv_load_cv.AllowUserToDeleteRows = false;
            this.dgv_load_cv.AllowUserToResizeColumns = false;
            this.dgv_load_cv.AllowUserToResizeRows = false;
            this.dgv_load_cv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_load_cv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaChucVu,
            this.colTenChucVu,
            this.colMucLuong,
            this.colPhuCap});
            this.dgv_load_cv.Location = new System.Drawing.Point(8, 20);
            this.dgv_load_cv.Name = "dgv_load_cv";
            this.dgv_load_cv.ReadOnly = true;
            this.dgv_load_cv.RowHeadersWidth = 51;
            this.dgv_load_cv.RowTemplate.Height = 24;
            this.dgv_load_cv.Size = new System.Drawing.Size(917, 392);
            this.dgv_load_cv.TabIndex = 0;
            this.dgv_load_cv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_load_cv_RowEnter);
            // 
            // colMaChucVu
            // 
            this.colMaChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaChucVu.DataPropertyName = "MaChucVu";
            this.colMaChucVu.HeaderText = "MaChucVu";
            this.colMaChucVu.MinimumWidth = 6;
            this.colMaChucVu.Name = "colMaChucVu";
            this.colMaChucVu.ReadOnly = true;
            // 
            // colTenChucVu
            // 
            this.colTenChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenChucVu.DataPropertyName = "TenChucVu";
            this.colTenChucVu.HeaderText = "TenChucVu";
            this.colTenChucVu.MinimumWidth = 6;
            this.colTenChucVu.Name = "colTenChucVu";
            this.colTenChucVu.ReadOnly = true;
            // 
            // colMucLuong
            // 
            this.colMucLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMucLuong.DataPropertyName = "MucLuong";
            this.colMucLuong.HeaderText = "MucLuong";
            this.colMucLuong.MinimumWidth = 6;
            this.colMucLuong.Name = "colMucLuong";
            this.colMucLuong.ReadOnly = true;
            // 
            // colPhuCap
            // 
            this.colPhuCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhuCap.DataPropertyName = "PhuCap";
            this.colPhuCap.HeaderText = "PhuCap";
            this.colPhuCap.MinimumWidth = 6;
            this.colPhuCap.Name = "colPhuCap";
            this.colPhuCap.ReadOnly = true;
            // 
            // erp_loi
            // 
            this.erp_loi.ContainerControl = this;
            // 
            // txt_find_ten_cv
            // 
            this.txt_find_ten_cv.Location = new System.Drawing.Point(22, 154);
            this.txt_find_ten_cv.Name = "txt_find_ten_cv";
            this.txt_find_ten_cv.Size = new System.Drawing.Size(266, 24);
            this.txt_find_ten_cv.TabIndex = 12;
            this.txt_find_ten_cv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_find_ten_cv_KeyPress);
            // 
            // txt_ten_cv
            // 
            this.txt_ten_cv.Location = new System.Drawing.Point(131, 62);
            this.txt_ten_cv.Name = "txt_ten_cv";
            this.txt_ten_cv.Size = new System.Drawing.Size(266, 24);
            this.txt_ten_cv.TabIndex = 13;
            this.txt_ten_cv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ten_cv_KeyPress);
            // 
            // FrmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 835);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmChucVu";
            this.Text = "FrmChucVu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_load_cv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_loi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_find_pc;
        private System.Windows.Forms.CheckBox cb_find_pc;
        private System.Windows.Forms.TextBox txt_find_luong;
        private System.Windows.Forms.CheckBox cb_find_luong;
        private System.Windows.Forms.CheckBox cb_find_depart;
        private System.Windows.Forms.TextBox txt_find_id;
        private System.Windows.Forms.CheckBox cb_find_id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_find_depart;
        private System.Windows.Forms.TextBox txt_phucap;
        private System.Windows.Forms.TextBox txt_mucluong;
        private System.Windows.Forms.TextBox txt_ma_cv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_load_cv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMucLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhuCap;
        private System.Windows.Forms.ErrorProvider erp_loi;
        private System.Windows.Forms.TextBox txt_find_ten_cv;
        private System.Windows.Forms.TextBox txt_ten_cv;
    }
}
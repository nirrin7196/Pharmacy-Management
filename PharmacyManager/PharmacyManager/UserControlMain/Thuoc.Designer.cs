namespace PharmacyManager.UserControlMain
{
    partial class Thuoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sl = new System.Windows.Forms.TextBox();
            this.lbl_giasauthue = new System.Windows.Forms.Label();
            this.stt = new System.Windows.Forms.Label();
            this.tenthuoc = new System.Windows.Forms.Label();
            this.tongtien = new System.Windows.Forms.TextBox();
            this.btn_less = new System.Windows.Forms.Button();
            this.btn_more = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.loaisl = new System.Windows.Forms.ComboBox();
            this.lbl_masanpham = new System.Windows.Forms.Label();
            this.ngay = new System.Windows.Forms.ComboBox();
            this.thang = new System.Windows.Forms.ComboBox();
            this.nam = new System.Windows.Forms.ComboBox();
            this.lbl_gianhap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sl
            // 
            this.sl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl.ForeColor = System.Drawing.Color.Black;
            this.sl.Location = new System.Drawing.Point(388, 4);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(69, 22);
            this.sl.TabIndex = 4;
            this.sl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sl_KeyPress);
            this.sl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sl_KeyUp);
            // 
            // lbl_giasauthue
            // 
            this.lbl_giasauthue.AutoSize = true;
            this.lbl_giasauthue.BackColor = System.Drawing.Color.White;
            this.lbl_giasauthue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_giasauthue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_giasauthue.Location = new System.Drawing.Point(306, 7);
            this.lbl_giasauthue.Name = "lbl_giasauthue";
            this.lbl_giasauthue.Size = new System.Drawing.Size(40, 16);
            this.lbl_giasauthue.TabIndex = 5;
            this.lbl_giasauthue.Text = "6000";
            // 
            // stt
            // 
            this.stt.AutoSize = true;
            this.stt.BackColor = System.Drawing.Color.White;
            this.stt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.stt.Location = new System.Drawing.Point(13, 6);
            this.stt.Name = "stt";
            this.stt.Size = new System.Drawing.Size(15, 15);
            this.stt.TabIndex = 7;
            this.stt.Text = "1";
            // 
            // tenthuoc
            // 
            this.tenthuoc.AutoSize = true;
            this.tenthuoc.BackColor = System.Drawing.Color.White;
            this.tenthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenthuoc.ForeColor = System.Drawing.Color.Black;
            this.tenthuoc.Location = new System.Drawing.Point(156, 7);
            this.tenthuoc.Name = "tenthuoc";
            this.tenthuoc.Size = new System.Drawing.Size(47, 15);
            this.tenthuoc.TabIndex = 8;
            this.tenthuoc.Text = "label3";
            // 
            // tongtien
            // 
            this.tongtien.BackColor = System.Drawing.Color.White;
            this.tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongtien.ForeColor = System.Drawing.Color.Black;
            this.tongtien.Location = new System.Drawing.Point(566, 4);
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            this.tongtien.Size = new System.Drawing.Size(71, 22);
            this.tongtien.TabIndex = 6;
            // 
            // btn_less
            // 
            this.btn_less.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_less.ForeColor = System.Drawing.Color.White;
            this.btn_less.Location = new System.Drawing.Point(355, 0);
            this.btn_less.Name = "btn_less";
            this.btn_less.Size = new System.Drawing.Size(28, 29);
            this.btn_less.TabIndex = 3;
            this.btn_less.UseVisualStyleBackColor = true;
            this.btn_less.Click += new System.EventHandler(this.btn_less_Click);
            // 
            // btn_more
            // 
            this.btn_more.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_more.ForeColor = System.Drawing.Color.White;
            this.btn_more.Location = new System.Drawing.Point(463, 0);
            this.btn_more.Name = "btn_more";
            this.btn_more.Size = new System.Drawing.Size(28, 29);
            this.btn_more.TabIndex = 2;
            this.btn_more.UseVisualStyleBackColor = true;
            this.btn_more.Click += new System.EventHandler(this.btn_more_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(889, -3);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(29, 29);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "x";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // loaisl
            // 
            this.loaisl.FormattingEnabled = true;
            this.loaisl.Location = new System.Drawing.Point(496, 6);
            this.loaisl.Name = "loaisl";
            this.loaisl.Size = new System.Drawing.Size(58, 21);
            this.loaisl.TabIndex = 10;
            this.loaisl.SelectedIndexChanged += new System.EventHandler(this.loaisl_SelectedIndexChanged);
            // 
            // lbl_masanpham
            // 
            this.lbl_masanpham.AutoSize = true;
            this.lbl_masanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_masanpham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_masanpham.Location = new System.Drawing.Point(60, 8);
            this.lbl_masanpham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_masanpham.Name = "lbl_masanpham";
            this.lbl_masanpham.Size = new System.Drawing.Size(47, 15);
            this.lbl_masanpham.TabIndex = 11;
            this.lbl_masanpham.Text = "label1";
            // 
            // ngay
            // 
            this.ngay.FormattingEnabled = true;
            this.ngay.Location = new System.Drawing.Point(651, 4);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(36, 21);
            this.ngay.TabIndex = 12;
            // 
            // thang
            // 
            this.thang.FormattingEnabled = true;
            this.thang.Location = new System.Drawing.Point(693, 3);
            this.thang.Name = "thang";
            this.thang.Size = new System.Drawing.Size(36, 21);
            this.thang.TabIndex = 13;
            // 
            // nam
            // 
            this.nam.FormattingEnabled = true;
            this.nam.Location = new System.Drawing.Point(735, 2);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(54, 21);
            this.nam.TabIndex = 14;
            this.nam.SelectedIndexChanged += new System.EventHandler(this.nam_SelectedIndexChanged);
            // 
            // lbl_gianhap
            // 
            this.lbl_gianhap.AutoSize = true;
            this.lbl_gianhap.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gianhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gianhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_gianhap.Location = new System.Drawing.Point(238, 6);
            this.lbl_gianhap.Name = "lbl_gianhap";
            this.lbl_gianhap.Size = new System.Drawing.Size(47, 15);
            this.lbl_gianhap.TabIndex = 15;
            this.lbl_gianhap.Text = "label1";
            // 
            // Thuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_gianhap);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.thang);
            this.Controls.Add(this.ngay);
            this.Controls.Add(this.lbl_masanpham);
            this.Controls.Add(this.loaisl);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.tenthuoc);
            this.Controls.Add(this.stt);
            this.Controls.Add(this.tongtien);
            this.Controls.Add(this.lbl_giasauthue);
            this.Controls.Add(this.sl);
            this.Controls.Add(this.btn_less);
            this.Controls.Add(this.btn_more);
            this.Name = "Thuoc";
            this.Size = new System.Drawing.Size(921, 29);
            this.Load += new System.EventHandler(this.Thuoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_more;
        private System.Windows.Forms.Button btn_less;
        private System.Windows.Forms.TextBox sl;
        private System.Windows.Forms.Label lbl_giasauthue;
        private System.Windows.Forms.Label stt;
        private System.Windows.Forms.Label tenthuoc;
        private System.Windows.Forms.TextBox tongtien;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.ComboBox loaisl;
        private System.Windows.Forms.Label lbl_masanpham;
        private System.Windows.Forms.ComboBox ngay;
        private System.Windows.Forms.ComboBox thang;
        private System.Windows.Forms.ComboBox nam;
        private System.Windows.Forms.Label lbl_gianhap;
    }
}

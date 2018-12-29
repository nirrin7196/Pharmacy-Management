namespace PharmacyManager.UserControlMain
{
    partial class BaoCaoBanHang
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
            this.grid_baoCaoBanHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lbl_GiaSauThue = new System.Windows.Forms.Label();
            this.lbl_GiaBan = new System.Windows.Forms.Label();
            this.lbl_AllLai = new System.Windows.Forms.Label();
            this.cbb_LoaiThongKe = new System.Windows.Forms.ComboBox();
            this.nam = new System.Windows.Forms.ComboBox();
            this.thang = new System.Windows.Forms.ComboBox();
            this.ngay = new System.Windows.Forms.ComboBox();
            this.nam_2 = new System.Windows.Forms.ComboBox();
            this.thang_2 = new System.Windows.Forms.ComboBox();
            this.ngay_2 = new System.Windows.Forms.ComboBox();
            this.cbb_DuocSy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_baoCaoBanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_baoCaoBanHang
            // 
            this.grid_baoCaoBanHang.Location = new System.Drawing.Point(21, 174);
            this.grid_baoCaoBanHang.MainView = this.gridView1;
            this.grid_baoCaoBanHang.Name = "grid_baoCaoBanHang";
            this.grid_baoCaoBanHang.Size = new System.Drawing.Size(846, 282);
            this.grid_baoCaoBanHang.TabIndex = 0;
            this.grid_baoCaoBanHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid_baoCaoBanHang.Load += new System.EventHandler(this.grid_baoCaoBanHang_Load);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_baoCaoBanHang;
            this.gridView1.Name = "gridView1";
            // 
            // lbl_GiaSauThue
            // 
            this.lbl_GiaSauThue.AutoSize = true;
            this.lbl_GiaSauThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiaSauThue.Location = new System.Drawing.Point(474, 493);
            this.lbl_GiaSauThue.Name = "lbl_GiaSauThue";
            this.lbl_GiaSauThue.Size = new System.Drawing.Size(57, 20);
            this.lbl_GiaSauThue.TabIndex = 1;
            this.lbl_GiaSauThue.Text = "label1";
            // 
            // lbl_GiaBan
            // 
            this.lbl_GiaBan.AutoSize = true;
            this.lbl_GiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiaBan.Location = new System.Drawing.Point(605, 492);
            this.lbl_GiaBan.Name = "lbl_GiaBan";
            this.lbl_GiaBan.Size = new System.Drawing.Size(57, 20);
            this.lbl_GiaBan.TabIndex = 2;
            this.lbl_GiaBan.Text = "label2";
            // 
            // lbl_AllLai
            // 
            this.lbl_AllLai.AutoSize = true;
            this.lbl_AllLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AllLai.Location = new System.Drawing.Point(730, 491);
            this.lbl_AllLai.Name = "lbl_AllLai";
            this.lbl_AllLai.Size = new System.Drawing.Size(57, 20);
            this.lbl_AllLai.TabIndex = 3;
            this.lbl_AllLai.Text = "label3";
            // 
            // cbb_LoaiThongKe
            // 
            this.cbb_LoaiThongKe.FormattingEnabled = true;
            this.cbb_LoaiThongKe.Items.AddRange(new object[] {
            "Báo Cáo Theo Ngày",
            "Báo Cáo Theo Tháng",
            "Báo Cáo Theo Năm",
            "Bao Cáo Theo Khoảng Thời Gian",
            "Báo Cáo Theo Dược Viên"});
            this.cbb_LoaiThongKe.Location = new System.Drawing.Point(67, 29);
            this.cbb_LoaiThongKe.Name = "cbb_LoaiThongKe";
            this.cbb_LoaiThongKe.Size = new System.Drawing.Size(121, 21);
            this.cbb_LoaiThongKe.TabIndex = 4;
            this.cbb_LoaiThongKe.SelectedIndexChanged += new System.EventHandler(this.cbb_LoaiThongKe_SelectedIndexChanged);
            // 
            // nam
            // 
            this.nam.FormattingEnabled = true;
            this.nam.Location = new System.Drawing.Point(357, 28);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(54, 21);
            this.nam.TabIndex = 17;
            this.nam.SelectedIndexChanged += new System.EventHandler(this.nam_SelectedIndexChanged);
            // 
            // thang
            // 
            this.thang.FormattingEnabled = true;
            this.thang.Location = new System.Drawing.Point(315, 29);
            this.thang.Name = "thang";
            this.thang.Size = new System.Drawing.Size(36, 21);
            this.thang.TabIndex = 16;
            this.thang.SelectedIndexChanged += new System.EventHandler(this.thang_SelectedIndexChanged);
            // 
            // ngay
            // 
            this.ngay.FormattingEnabled = true;
            this.ngay.Location = new System.Drawing.Point(273, 30);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(36, 21);
            this.ngay.TabIndex = 15;
            this.ngay.SelectedIndexChanged += new System.EventHandler(this.ngay_SelectedIndexChanged);
            // 
            // nam_2
            // 
            this.nam_2.FormattingEnabled = true;
            this.nam_2.Location = new System.Drawing.Point(614, 27);
            this.nam_2.Name = "nam_2";
            this.nam_2.Size = new System.Drawing.Size(54, 21);
            this.nam_2.TabIndex = 20;
            // 
            // thang_2
            // 
            this.thang_2.FormattingEnabled = true;
            this.thang_2.Location = new System.Drawing.Point(572, 28);
            this.thang_2.Name = "thang_2";
            this.thang_2.Size = new System.Drawing.Size(36, 21);
            this.thang_2.TabIndex = 19;
            // 
            // ngay_2
            // 
            this.ngay_2.FormattingEnabled = true;
            this.ngay_2.Location = new System.Drawing.Point(530, 29);
            this.ngay_2.Name = "ngay_2";
            this.ngay_2.Size = new System.Drawing.Size(36, 21);
            this.ngay_2.TabIndex = 18;
            // 
            // cbb_DuocSy
            // 
            this.cbb_DuocSy.FormattingEnabled = true;
            this.cbb_DuocSy.Location = new System.Drawing.Point(273, 57);
            this.cbb_DuocSy.Name = "cbb_DuocSy";
            this.cbb_DuocSy.Size = new System.Drawing.Size(121, 21);
            this.cbb_DuocSy.TabIndex = 21;
            this.cbb_DuocSy.SelectedIndexChanged += new System.EventHandler(this.cbb_DuocSy_SelectedIndexChanged);
            // 
            // BaoCaoBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbb_DuocSy);
            this.Controls.Add(this.nam_2);
            this.Controls.Add(this.thang_2);
            this.Controls.Add(this.ngay_2);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.thang);
            this.Controls.Add(this.ngay);
            this.Controls.Add(this.cbb_LoaiThongKe);
            this.Controls.Add(this.lbl_AllLai);
            this.Controls.Add(this.lbl_GiaBan);
            this.Controls.Add(this.lbl_GiaSauThue);
            this.Controls.Add(this.grid_baoCaoBanHang);
            this.Name = "BaoCaoBanHang";
            this.Size = new System.Drawing.Size(893, 560);
            ((System.ComponentModel.ISupportInitialize)(this.grid_baoCaoBanHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid_baoCaoBanHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label lbl_GiaSauThue;
        private System.Windows.Forms.Label lbl_GiaBan;
        private System.Windows.Forms.Label lbl_AllLai;
        private System.Windows.Forms.ComboBox cbb_LoaiThongKe;
        private System.Windows.Forms.ComboBox nam;
        private System.Windows.Forms.ComboBox thang;
        private System.Windows.Forms.ComboBox ngay;
        private System.Windows.Forms.ComboBox nam_2;
        private System.Windows.Forms.ComboBox thang_2;
        private System.Windows.Forms.ComboBox ngay_2;
        private System.Windows.Forms.ComboBox cbb_DuocSy;
    }
}

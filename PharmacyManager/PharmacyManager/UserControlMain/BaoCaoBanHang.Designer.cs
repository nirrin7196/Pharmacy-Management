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
            this.cbb_LoaiThongKe = new System.Windows.Forms.ComboBox();
            this.nam = new System.Windows.Forms.ComboBox();
            this.thang = new System.Windows.Forms.ComboBox();
            this.ngay = new System.Windows.Forms.ComboBox();
            this.nam_2 = new System.Windows.Forms.ComboBox();
            this.thang_2 = new System.Windows.Forms.ComboBox();
            this.ngay_2 = new System.Windows.Forms.ComboBox();
            this.cbb_DuocSy = new System.Windows.Forms.ComboBox();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.txtNam2 = new DevExpress.XtraEditors.LabelControl();
            this.txtThang2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNam1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNgay2 = new DevExpress.XtraEditors.LabelControl();
            this.txtThang1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNgay1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_baoCaoBanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_baoCaoBanHang
            // 
            this.grid_baoCaoBanHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grid_baoCaoBanHang.Location = new System.Drawing.Point(55, 186);
            this.grid_baoCaoBanHang.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grid_baoCaoBanHang.MainView = this.gridView1;
            this.grid_baoCaoBanHang.Name = "grid_baoCaoBanHang";
            this.grid_baoCaoBanHang.Size = new System.Drawing.Size(924, 290);
            this.grid_baoCaoBanHang.TabIndex = 0;
            this.grid_baoCaoBanHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid_baoCaoBanHang.Load += new System.EventHandler(this.grid_baoCaoBanHang_Load);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_baoCaoBanHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // cbb_LoaiThongKe
            // 
            this.cbb_LoaiThongKe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_LoaiThongKe.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LoaiThongKe.FormattingEnabled = true;
            this.cbb_LoaiThongKe.Items.AddRange(new object[] {
            "Báo Cáo Theo Ngày",
            "Báo Cáo Theo Tháng",
            "Báo Cáo Theo Năm",
            "Bao Cáo Theo Khoảng Thời Gian",
            "Báo Cáo Theo Dược Viên"});
            this.cbb_LoaiThongKe.Location = new System.Drawing.Point(81, 132);
            this.cbb_LoaiThongKe.Name = "cbb_LoaiThongKe";
            this.cbb_LoaiThongKe.Size = new System.Drawing.Size(212, 30);
            this.cbb_LoaiThongKe.TabIndex = 4;
            this.cbb_LoaiThongKe.SelectedIndexChanged += new System.EventHandler(this.cbb_LoaiThongKe_SelectedIndexChanged);
            // 
            // nam
            // 
            this.nam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nam.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam.FormattingEnabled = true;
            this.nam.Location = new System.Drawing.Point(656, 132);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(80, 30);
            this.nam.TabIndex = 17;
            this.nam.SelectedIndexChanged += new System.EventHandler(this.nam_SelectedIndexChanged);
            // 
            // thang
            // 
            this.thang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thang.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thang.FormattingEnabled = true;
            this.thang.Location = new System.Drawing.Point(516, 132);
            this.thang.Name = "thang";
            this.thang.Size = new System.Drawing.Size(62, 30);
            this.thang.TabIndex = 16;
            this.thang.SelectedIndexChanged += new System.EventHandler(this.thang_SelectedIndexChanged);
            // 
            // ngay
            // 
            this.ngay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ngay.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay.FormattingEnabled = true;
            this.ngay.Location = new System.Drawing.Point(584, 132);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(62, 30);
            this.ngay.TabIndex = 15;
            this.ngay.SelectedIndexChanged += new System.EventHandler(this.ngay_SelectedIndexChanged);
            // 
            // nam_2
            // 
            this.nam_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nam_2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam_2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nam_2.FormattingEnabled = true;
            this.nam_2.Location = new System.Drawing.Point(882, 132);
            this.nam_2.Name = "nam_2";
            this.nam_2.Size = new System.Drawing.Size(79, 30);
            this.nam_2.TabIndex = 20;
            // 
            // thang_2
            // 
            this.thang_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thang_2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thang_2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.thang_2.FormattingEnabled = true;
            this.thang_2.Location = new System.Drawing.Point(813, 132);
            this.thang_2.Name = "thang_2";
            this.thang_2.Size = new System.Drawing.Size(63, 30);
            this.thang_2.TabIndex = 19;
            // 
            // ngay_2
            // 
            this.ngay_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ngay_2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay_2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ngay_2.FormattingEnabled = true;
            this.ngay_2.Location = new System.Drawing.Point(749, 132);
            this.ngay_2.Name = "ngay_2";
            this.ngay_2.Size = new System.Drawing.Size(58, 30);
            this.ngay_2.TabIndex = 18;
            // 
            // cbb_DuocSy
            // 
            this.cbb_DuocSy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_DuocSy.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_DuocSy.FormattingEnabled = true;
            this.cbb_DuocSy.Location = new System.Drawing.Point(299, 132);
            this.cbb_DuocSy.Name = "cbb_DuocSy";
            this.cbb_DuocSy.Size = new System.Drawing.Size(176, 30);
            this.cbb_DuocSy.TabIndex = 21;
            this.cbb_DuocSy.SelectedIndexChanged += new System.EventHandler(this.cbb_DuocSy_SelectedIndexChanged);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.White;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.txtNam2);
            this.sidePanel1.Controls.Add(this.txtThang2);
            this.sidePanel1.Controls.Add(this.txtNam1);
            this.sidePanel1.Controls.Add(this.txtNgay2);
            this.sidePanel1.Controls.Add(this.txtThang1);
            this.sidePanel1.Controls.Add(this.txtNgay1);
            this.sidePanel1.Controls.Add(this.labelControl3);
            this.sidePanel1.Controls.Add(this.labelControl2);
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Controls.Add(this.nam_2);
            this.sidePanel1.Controls.Add(this.thang_2);
            this.sidePanel1.Controls.Add(this.ngay_2);
            this.sidePanel1.Controls.Add(this.cbb_DuocSy);
            this.sidePanel1.Controls.Add(this.cbb_LoaiThongKe);
            this.sidePanel1.Controls.Add(this.ngay);
            this.sidePanel1.Controls.Add(this.thang);
            this.sidePanel1.Controls.Add(this.nam);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1005, 186);
            this.sidePanel1.TabIndex = 22;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // txtNam2
            // 
            this.txtNam2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNam2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtNam2.Appearance.Options.UseFont = true;
            this.txtNam2.Appearance.Options.UseForeColor = true;
            this.txtNam2.Location = new System.Drawing.Point(890, 107);
            this.txtNam2.Name = "txtNam2";
            this.txtNam2.Size = new System.Drawing.Size(33, 19);
            this.txtNam2.TabIndex = 25;
            this.txtNam2.Text = "Năm";
            // 
            // txtThang2
            // 
            this.txtThang2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtThang2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtThang2.Appearance.Options.UseFont = true;
            this.txtThang2.Appearance.Options.UseForeColor = true;
            this.txtThang2.Location = new System.Drawing.Point(818, 107);
            this.txtThang2.Name = "txtThang2";
            this.txtThang2.Size = new System.Drawing.Size(45, 19);
            this.txtThang2.TabIndex = 25;
            this.txtThang2.Text = "Tháng";
            // 
            // txtNam1
            // 
            this.txtNam1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNam1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtNam1.Appearance.Options.UseFont = true;
            this.txtNam1.Appearance.Options.UseForeColor = true;
            this.txtNam1.Location = new System.Drawing.Point(656, 107);
            this.txtNam1.Name = "txtNam1";
            this.txtNam1.Size = new System.Drawing.Size(33, 19);
            this.txtNam1.TabIndex = 25;
            this.txtNam1.Text = "Năm";
            // 
            // txtNgay2
            // 
            this.txtNgay2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNgay2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtNgay2.Appearance.Options.UseFont = true;
            this.txtNgay2.Appearance.Options.UseForeColor = true;
            this.txtNgay2.Location = new System.Drawing.Point(750, 107);
            this.txtNgay2.Name = "txtNgay2";
            this.txtNgay2.Size = new System.Drawing.Size(36, 19);
            this.txtNgay2.TabIndex = 25;
            this.txtNgay2.Text = "Ngày";
            // 
            // txtThang1
            // 
            this.txtThang1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtThang1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtThang1.Appearance.Options.UseFont = true;
            this.txtThang1.Appearance.Options.UseForeColor = true;
            this.txtThang1.Location = new System.Drawing.Point(584, 107);
            this.txtThang1.Name = "txtThang1";
            this.txtThang1.Size = new System.Drawing.Size(45, 19);
            this.txtThang1.TabIndex = 25;
            this.txtThang1.Text = "Tháng";
            // 
            // txtNgay1
            // 
            this.txtNgay1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNgay1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtNgay1.Appearance.Options.UseFont = true;
            this.txtNgay1.Appearance.Options.UseForeColor = true;
            this.txtNgay1.Location = new System.Drawing.Point(516, 107);
            this.txtNgay1.Name = "txtNgay1";
            this.txtNgay1.Size = new System.Drawing.Size(36, 19);
            this.txtNgay1.TabIndex = 25;
            this.txtNgay1.Text = "Ngày";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(299, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 19);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Chọn Dược Sỹ";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(81, 107);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(138, 19);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Chọn Điều Kiện Lọc";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.Location = new System.Drawing.Point(326, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(385, 32);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "BÁO CÁO THỐNG KÊ BÁN HÀNG";
            // 
            // sidePanel2
            // 
            this.sidePanel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidePanel2.Appearance.Options.UseBackColor = true;
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel2.Location = new System.Drawing.Point(0, 476);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(1005, 84);
            this.sidePanel2.TabIndex = 23;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // BaoCaoBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.grid_baoCaoBanHang);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Name = "BaoCaoBanHang";
            this.Size = new System.Drawing.Size(1005, 560);
            ((System.ComponentModel.ISupportInitialize)(this.grid_baoCaoBanHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid_baoCaoBanHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox cbb_LoaiThongKe;
        private System.Windows.Forms.ComboBox nam;
        private System.Windows.Forms.ComboBox thang;
        private System.Windows.Forms.ComboBox ngay;
        private System.Windows.Forms.ComboBox nam_2;
        private System.Windows.Forms.ComboBox thang_2;
        private System.Windows.Forms.ComboBox ngay_2;
        private System.Windows.Forms.ComboBox cbb_DuocSy;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl txtNam1;
        private DevExpress.XtraEditors.LabelControl txtThang1;
        private DevExpress.XtraEditors.LabelControl txtNgay1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl txtNam2;
        private DevExpress.XtraEditors.LabelControl txtThang2;
        private DevExpress.XtraEditors.LabelControl txtNgay2;
    }
}

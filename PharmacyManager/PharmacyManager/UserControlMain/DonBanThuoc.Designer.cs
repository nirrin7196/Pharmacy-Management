namespace PharmacyManager.UserControlMain
{
    partial class DonBanThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonBanThuoc));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.txtTongCong = new DevExpress.XtraEditors.TextEdit();
            this.lblTongCong = new DevExpress.XtraEditors.LabelControl();
            this.txtTienThue = new DevExpress.XtraEditors.TextEdit();
            this.txtPhiDichVu = new DevExpress.XtraEditors.TextEdit();
            this.lblTienThue = new DevExpress.XtraEditors.LabelControl();
            this.lblPhiDichVu = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.btnInHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.btnThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.btnBot = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.gridControlDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.sidePanel5.SuspendLayout();
            this.sidePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongCong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienThue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhiDichVu.Properties)).BeginInit();
            this.sidePanel2.SuspendLayout();
            this.sidePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(590, 453);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.sidePanel5);
            this.sidePanel1.Controls.Add(this.sidePanel4);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(591, 656);
            this.sidePanel1.TabIndex = 1;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // sidePanel5
            // 
            this.sidePanel5.Controls.Add(this.gridControl);
            this.sidePanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel5.Location = new System.Drawing.Point(0, 0);
            this.sidePanel5.Name = "sidePanel5";
            this.sidePanel5.Size = new System.Drawing.Size(590, 453);
            this.sidePanel5.TabIndex = 2;
            this.sidePanel5.Text = "sidePanel5";
            // 
            // sidePanel4
            // 
            this.sidePanel4.Controls.Add(this.txtTongCong);
            this.sidePanel4.Controls.Add(this.lblTongCong);
            this.sidePanel4.Controls.Add(this.txtTienThue);
            this.sidePanel4.Controls.Add(this.txtPhiDichVu);
            this.sidePanel4.Controls.Add(this.lblTienThue);
            this.sidePanel4.Controls.Add(this.lblPhiDichVu);
            this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel4.Location = new System.Drawing.Point(0, 453);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(590, 203);
            this.sidePanel4.TabIndex = 1;
            this.sidePanel4.Text = "sidePanel4";
            this.sidePanel4.Click += new System.EventHandler(this.sidePanel4_Click);
            // 
            // txtTongCong
            // 
            this.txtTongCong.EditValue = "0";
            this.txtTongCong.Location = new System.Drawing.Point(191, 129);
            this.txtTongCong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTongCong.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtTongCong.Properties.Appearance.Options.UseBackColor = true;
            this.txtTongCong.Properties.Appearance.Options.UseForeColor = true;
            this.txtTongCong.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTongCong.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTongCong.Properties.DisplayFormat.FormatString = "n0";
            this.txtTongCong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTongCong.Properties.ReadOnly = true;
            this.txtTongCong.Size = new System.Drawing.Size(360, 22);
            this.txtTongCong.TabIndex = 20;
            // 
            // lblTongCong
            // 
            this.lblTongCong.Appearance.BackColor = System.Drawing.Color.White;
            this.lblTongCong.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongCong.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblTongCong.Appearance.Options.UseBackColor = true;
            this.lblTongCong.Appearance.Options.UseFont = true;
            this.lblTongCong.Appearance.Options.UseForeColor = true;
            this.lblTongCong.LineColor = System.Drawing.Color.Black;
            this.lblTongCong.Location = new System.Drawing.Point(94, 128);
            this.lblTongCong.Margin = new System.Windows.Forms.Padding(4);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(82, 22);
            this.lblTongCong.TabIndex = 19;
            this.lblTongCong.Text = "Tổng cộng";
            // 
            // txtTienThue
            // 
            this.txtTienThue.EditValue = "0";
            this.txtTienThue.Location = new System.Drawing.Point(191, 88);
            this.txtTienThue.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienThue.Name = "txtTienThue";
            this.txtTienThue.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTienThue.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtTienThue.Properties.Appearance.Options.UseBackColor = true;
            this.txtTienThue.Properties.Appearance.Options.UseForeColor = true;
            this.txtTienThue.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTienThue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTienThue.Properties.DisplayFormat.FormatString = "n0";
            this.txtTienThue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTienThue.Properties.ReadOnly = true;
            this.txtTienThue.Size = new System.Drawing.Size(360, 22);
            this.txtTienThue.TabIndex = 18;
            // 
            // txtPhiDichVu
            // 
            this.txtPhiDichVu.EditValue = "0";
            this.txtPhiDichVu.Location = new System.Drawing.Point(191, 53);
            this.txtPhiDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhiDichVu.Name = "txtPhiDichVu";
            this.txtPhiDichVu.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPhiDichVu.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtPhiDichVu.Properties.Appearance.Options.UseBackColor = true;
            this.txtPhiDichVu.Properties.Appearance.Options.UseForeColor = true;
            this.txtPhiDichVu.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPhiDichVu.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPhiDichVu.Properties.DisplayFormat.FormatString = "n0";
            this.txtPhiDichVu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPhiDichVu.Properties.ReadOnly = true;
            this.txtPhiDichVu.Size = new System.Drawing.Size(360, 22);
            this.txtPhiDichVu.TabIndex = 17;
            // 
            // lblTienThue
            // 
            this.lblTienThue.Appearance.BackColor = System.Drawing.Color.White;
            this.lblTienThue.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienThue.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblTienThue.Appearance.Options.UseBackColor = true;
            this.lblTienThue.Appearance.Options.UseFont = true;
            this.lblTienThue.Appearance.Options.UseForeColor = true;
            this.lblTienThue.LineColor = System.Drawing.Color.Black;
            this.lblTienThue.Location = new System.Drawing.Point(94, 92);
            this.lblTienThue.Margin = new System.Windows.Forms.Padding(4);
            this.lblTienThue.Name = "lblTienThue";
            this.lblTienThue.Size = new System.Drawing.Size(72, 22);
            this.lblTienThue.TabIndex = 15;
            this.lblTienThue.Text = "Tiền thuế";
            // 
            // lblPhiDichVu
            // 
            this.lblPhiDichVu.Appearance.BackColor = System.Drawing.Color.White;
            this.lblPhiDichVu.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhiDichVu.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblPhiDichVu.Appearance.Options.UseBackColor = true;
            this.lblPhiDichVu.Appearance.Options.UseFont = true;
            this.lblPhiDichVu.Appearance.Options.UseForeColor = true;
            this.lblPhiDichVu.LineColor = System.Drawing.Color.Black;
            this.lblPhiDichVu.Location = new System.Drawing.Point(94, 52);
            this.lblPhiDichVu.LookAndFeel.SkinMaskColor = System.Drawing.Color.Black;
            this.lblPhiDichVu.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Black;
            this.lblPhiDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.lblPhiDichVu.Name = "lblPhiDichVu";
            this.lblPhiDichVu.Size = new System.Drawing.Size(89, 22);
            this.lblPhiDichVu.TabIndex = 16;
            this.lblPhiDichVu.Text = "Phí dịch vụ";
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.btnInHoaDon);
            this.sidePanel2.Controls.Add(this.btnThanhToan);
            this.sidePanel2.Controls.Add(this.btnBot);
            this.sidePanel2.Controls.Add(this.btnThem);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel2.Location = new System.Drawing.Point(591, 0);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(132, 656);
            this.sidePanel2.TabIndex = 2;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInHoaDon.ImageOptions.Image")));
            this.btnInHoaDon.Location = new System.Drawing.Point(0, 453);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(132, 70);
            this.btnInHoaDon.TabIndex = 2;
            this.btnInHoaDon.Text = "In hóa đơn";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.ImageOptions.Image")));
            this.btnThanhToan.Location = new System.Drawing.Point(0, 359);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(132, 52);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh Toán";
            // 
            // btnBot
            // 
            this.btnBot.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBot.ImageOptions.Image")));
            this.btnBot.Location = new System.Drawing.Point(0, 228);
            this.btnBot.Name = "btnBot";
            this.btnBot.Size = new System.Drawing.Size(132, 54);
            this.btnBot.TabIndex = 1;
            this.btnBot.Text = "Bớt";
            this.btnBot.Click += new System.EventHandler(this.btnBot_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(0, 94);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 53);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // sidePanel3
            // 
            this.sidePanel3.Controls.Add(this.gridControlDanhSach);
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel3.Location = new System.Drawing.Point(723, 0);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(359, 656);
            this.sidePanel3.TabIndex = 3;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // gridControlDanhSach
            // 
            this.gridControlDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gridControlDanhSach.MainView = this.gridView2;
            this.gridControlDanhSach.Name = "gridControlDanhSach";
            this.gridControlDanhSach.Size = new System.Drawing.Size(359, 656);
            this.gridControlDanhSach.TabIndex = 0;
            this.gridControlDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlDanhSach;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);
            // 
            // DonBanThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sidePanel3);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Name = "DonBanThuoc";
            this.Size = new System.Drawing.Size(1082, 656);
            this.Load += new System.EventHandler(this.DonBanThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel5.ResumeLayout(false);
            this.sidePanel4.ResumeLayout(false);
            this.sidePanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongCong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienThue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhiDichVu.Properties)).EndInit();
            this.sidePanel2.ResumeLayout(false);
            this.sidePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SimpleButton btnInHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnThanhToan;
        private DevExpress.XtraEditors.SimpleButton btnBot;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraGrid.GridControl gridControlDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.TextEdit txtTongCong;
        private DevExpress.XtraEditors.LabelControl lblTongCong;
        private DevExpress.XtraEditors.TextEdit txtTienThue;
        private DevExpress.XtraEditors.TextEdit txtPhiDichVu;
        private DevExpress.XtraEditors.LabelControl lblTienThue;
        private DevExpress.XtraEditors.LabelControl lblPhiDichVu;
        private DevExpress.XtraEditors.SidePanel sidePanel5;
    }
}

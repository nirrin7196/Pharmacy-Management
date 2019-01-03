namespace PharmacyManager.UserControlMain
{
    partial class TraThuocHetHan
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
            this.txt_MaThuoc = new System.Windows.Forms.TextBox();
            this.nam = new System.Windows.Forms.ComboBox();
            this.thang = new System.Windows.Forms.ComboBox();
            this.ngay = new System.Windows.Forms.ComboBox();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grid_DSThuoc = new DevExpress.XtraGrid.GridControl();
            this.grid_DSTraThuoc = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSTraThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            this.sidePanel3.SuspendLayout();
            this.sidePanel4.SuspendLayout();
            this.sidePanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_MaThuoc
            // 
            this.txt_MaThuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaThuoc.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaThuoc.Location = new System.Drawing.Point(399, 48);
            this.txt_MaThuoc.Name = "txt_MaThuoc";
            this.txt_MaThuoc.Size = new System.Drawing.Size(100, 30);
            this.txt_MaThuoc.TabIndex = 1;
            // 
            // nam
            // 
            this.nam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nam.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam.FormattingEnabled = true;
            this.nam.Location = new System.Drawing.Point(721, 48);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(89, 30);
            this.nam.TabIndex = 17;
            // 
            // thang
            // 
            this.thang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thang.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thang.FormattingEnabled = true;
            this.thang.Location = new System.Drawing.Point(649, 48);
            this.thang.Name = "thang";
            this.thang.Size = new System.Drawing.Size(66, 30);
            this.thang.TabIndex = 16;
            // 
            // ngay
            // 
            this.ngay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ngay.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay.FormattingEnabled = true;
            this.ngay.Location = new System.Drawing.Point(586, 48);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(57, 30);
            this.ngay.TabIndex = 15;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_DSThuoc;
            this.gridView1.Name = "gridView1";
            // 
            // grid_DSThuoc
            // 
            this.grid_DSThuoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.grid_DSThuoc.Location = new System.Drawing.Point(0, 0);
            this.grid_DSThuoc.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grid_DSThuoc.MainView = this.gridView1;
            this.grid_DSThuoc.Name = "grid_DSThuoc";
            this.grid_DSThuoc.Size = new System.Drawing.Size(682, 220);
            this.grid_DSThuoc.TabIndex = 0;
            this.grid_DSThuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // grid_DSTraThuoc
            // 
            this.grid_DSTraThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_DSTraThuoc.Location = new System.Drawing.Point(682, 0);
            this.grid_DSTraThuoc.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grid_DSTraThuoc.MainView = this.gridView2;
            this.grid_DSTraThuoc.Name = "grid_DSTraThuoc";
            this.grid_DSTraThuoc.Size = new System.Drawing.Size(566, 220);
            this.grid_DSTraThuoc.TabIndex = 20;
            this.grid_DSTraThuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grid_DSTraThuoc;
            this.gridView2.Name = "gridView2";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.sidePanel3);
            this.sidePanel1.Controls.Add(this.sidePanel2);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1248, 144);
            this.sidePanel1.TabIndex = 21;
            this.sidePanel1.Text = "sidePanel1";
            this.sidePanel1.Click += new System.EventHandler(this.sidePanel1_Click);
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.labelControl5);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel2.Location = new System.Drawing.Point(0, 0);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(1248, 47);
            this.sidePanel2.TabIndex = 19;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // sidePanel3
            // 
            this.sidePanel3.Controls.Add(this.labelControl4);
            this.sidePanel3.Controls.Add(this.labelControl3);
            this.sidePanel3.Controls.Add(this.labelControl1);
            this.sidePanel3.Controls.Add(this.labelControl2);
            this.sidePanel3.Controls.Add(this.simpleButton2);
            this.sidePanel3.Controls.Add(this.txt_MaThuoc);
            this.sidePanel3.Controls.Add(this.thang);
            this.sidePanel3.Controls.Add(this.nam);
            this.sidePanel3.Controls.Add(this.ngay);
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel3.Location = new System.Drawing.Point(0, 47);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(1248, 96);
            this.sidePanel3.TabIndex = 20;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Black;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton2.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.simpleButton2.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton2.ImageOptions.Image = global::PharmacyManager.Properties.Resources.icon_import_;
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(845, 6);
            this.simpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(166, 75);
            this.simpleButton2.TabIndex = 27;
            this.simpleButton2.Text = "NHẬP THUỐC";
            this.simpleButton2.Click += new System.EventHandler(this.btn_NhapThuoc_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(399, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(111, 19);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Nhập Mã Thuốc";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(586, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 19);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Ngày";
            this.labelControl1.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(649, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 19);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "Tháng";
            this.labelControl3.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(721, 19);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 19);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Năm";
            this.labelControl4.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl5.Location = new System.Drawing.Point(544, 9);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(266, 32);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "TRẢ THUỐC HẾT HẠN";
            // 
            // sidePanel4
            // 
            this.sidePanel4.Controls.Add(this.grid_DSTraThuoc);
            this.sidePanel4.Controls.Add(this.grid_DSThuoc);
            this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel4.Location = new System.Drawing.Point(0, 144);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(1248, 220);
            this.sidePanel4.TabIndex = 22;
            this.sidePanel4.Text = "sidePanel4";
            // 
            // sidePanel5
            // 
            this.sidePanel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidePanel5.Appearance.Options.UseBackColor = true;
            this.sidePanel5.Controls.Add(this.simpleButton1);
            this.sidePanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel5.Location = new System.Drawing.Point(0, 364);
            this.sidePanel5.Name = "sidePanel5";
            this.sidePanel5.Size = new System.Drawing.Size(1248, 98);
            this.sidePanel5.TabIndex = 23;
            this.sidePanel5.Text = "sidePanel5";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.ImageOptions.Image = global::PharmacyManager.Properties.Resources.icon_tra_hang;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(588, 4);
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(166, 75);
            this.simpleButton1.TabIndex = 27;
            this.simpleButton1.Text = "TRẢ THUỐC";
            this.simpleButton1.Click += new System.EventHandler(this.btn_NhapThuoc_Click);
            // 
            // TraThuocHetHan
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel4);
            this.Controls.Add(this.sidePanel5);
            this.Controls.Add(this.sidePanel1);
            this.Name = "TraThuocHetHan";
            this.Size = new System.Drawing.Size(1248, 462);
            this.Load += new System.EventHandler(this.TraThuocHetHan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSTraThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel2.ResumeLayout(false);
            this.sidePanel2.PerformLayout();
            this.sidePanel3.ResumeLayout(false);
            this.sidePanel3.PerformLayout();
            this.sidePanel4.ResumeLayout(false);
            this.sidePanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MaThuoc;
        private System.Windows.Forms.ComboBox nam;
        private System.Windows.Forms.ComboBox thang;
        private System.Windows.Forms.ComboBox ngay;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grid_DSThuoc;
        private DevExpress.XtraGrid.GridControl grid_DSTraThuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.SidePanel sidePanel5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

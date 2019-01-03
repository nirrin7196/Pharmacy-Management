namespace PharmacyManager.UserControlMain
{
    partial class KiemKeTheoLo
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
            this.grid_CTDN = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grid_KiemKeTheoLo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KiemKeTheoLo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_CTDN
            // 
            this.grid_CTDN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_CTDN.Location = new System.Drawing.Point(524, 76);
            this.grid_CTDN.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grid_CTDN.MainView = this.gridView2;
            this.grid_CTDN.Name = "grid_CTDN";
            this.grid_CTDN.Size = new System.Drawing.Size(642, 322);
            this.grid_CTDN.TabIndex = 1;
            this.grid_CTDN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grid_CTDN;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsFind.FindNullPrompt = "Tìm kiếm thuốc";
            // 
            // grid_KiemKeTheoLo
            // 
            this.grid_KiemKeTheoLo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_KiemKeTheoLo.Location = new System.Drawing.Point(0, 0);
            this.grid_KiemKeTheoLo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grid_KiemKeTheoLo.MainView = this.gridView1;
            this.grid_KiemKeTheoLo.Name = "grid_KiemKeTheoLo";
            this.grid_KiemKeTheoLo.Size = new System.Drawing.Size(523, 322);
            this.grid_KiemKeTheoLo.TabIndex = 3;
            this.grid_KiemKeTheoLo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid_KiemKeTheoLo.Click += new System.EventHandler(this.grid_KiemKeTheoLo_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_KiemKeTheoLo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Tìm kiếm lô";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1166, 76);
            this.sidePanel1.TabIndex = 4;
            this.sidePanel1.Text = "sidePanel1";
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
            this.labelControl1.Location = new System.Drawing.Point(471, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(223, 32);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "KIỂM KE THEO LÔ";
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.grid_KiemKeTheoLo);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel2.Location = new System.Drawing.Point(0, 76);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(524, 322);
            this.sidePanel2.TabIndex = 5;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // KiemKeTheoLo
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid_CTDN);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Name = "KiemKeTheoLo";
            this.Size = new System.Drawing.Size(1166, 398);
            this.Load += new System.EventHandler(this.KiemKeTheoLo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KiemKeTheoLo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.sidePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid_CTDN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl grid_KiemKeTheoLo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
    }
}

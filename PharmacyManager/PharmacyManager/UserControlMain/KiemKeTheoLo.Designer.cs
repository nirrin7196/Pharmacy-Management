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
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KiemKeTheoLo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_CTDN
            // 
            this.grid_CTDN.Location = new System.Drawing.Point(589, 37);
            this.grid_CTDN.MainView = this.gridView2;
            this.grid_CTDN.Name = "grid_CTDN";
            this.grid_CTDN.Size = new System.Drawing.Size(484, 200);
            this.grid_CTDN.TabIndex = 1;
            this.grid_CTDN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grid_CTDN;
            this.gridView2.Name = "gridView2";
            // 
            // grid_KiemKeTheoLo
            // 
            this.grid_KiemKeTheoLo.Location = new System.Drawing.Point(95, 37);
            this.grid_KiemKeTheoLo.MainView = this.gridView1;
            this.grid_KiemKeTheoLo.Name = "grid_KiemKeTheoLo";
            this.grid_KiemKeTheoLo.Size = new System.Drawing.Size(400, 200);
            this.grid_KiemKeTheoLo.TabIndex = 3;
            this.grid_KiemKeTheoLo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid_KiemKeTheoLo.Click += new System.EventHandler(this.grid_KiemKeTheoLo_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_KiemKeTheoLo;
            this.gridView1.Name = "gridView1";
            // 
            // KiemKeTheoLo
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid_KiemKeTheoLo);
            this.Controls.Add(this.grid_CTDN);
            this.Name = "KiemKeTheoLo";
            this.Size = new System.Drawing.Size(1166, 398);
            this.Load += new System.EventHandler(this.KiemKeTheoLo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KiemKeTheoLo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid_CTDN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl grid_KiemKeTheoLo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}

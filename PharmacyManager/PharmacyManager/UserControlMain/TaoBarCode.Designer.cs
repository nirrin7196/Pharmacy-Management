namespace PharmacyManager.UserControlMain
{
    partial class TaoBarCode
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
            this.img_barcode = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_taoma = new System.Windows.Forms.Button();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.btn_XuatFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_barcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // img_barcode
            // 
            this.img_barcode.BackColor = System.Drawing.Color.White;
            this.img_barcode.Location = new System.Drawing.Point(176, 115);
            this.img_barcode.Name = "img_barcode";
            this.img_barcode.Size = new System.Drawing.Size(266, 163);
            this.img_barcode.TabIndex = 18;
            this.img_barcode.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(99, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 196);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btn_taoma
            // 
            this.btn_taoma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taoma.Location = new System.Drawing.Point(333, 46);
            this.btn_taoma.Name = "btn_taoma";
            this.btn_taoma.Size = new System.Drawing.Size(75, 46);
            this.btn_taoma.TabIndex = 16;
            this.btn_taoma.Text = "Tạo Mã";
            this.btn_taoma.UseVisualStyleBackColor = true;
            this.btn_taoma.Click += new System.EventHandler(this.btn_taoma_Click);
            // 
            // txt_ma
            // 
            this.txt_ma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ma.Location = new System.Drawing.Point(99, 49);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(199, 29);
            this.txt_ma.TabIndex = 15;
            // 
            // btn_XuatFile
            // 
            this.btn_XuatFile.Location = new System.Drawing.Point(437, 49);
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.Size = new System.Drawing.Size(75, 43);
            this.btn_XuatFile.TabIndex = 19;
            this.btn_XuatFile.Text = "Xuất File";
            this.btn_XuatFile.UseVisualStyleBackColor = true;
            this.btn_XuatFile.Click += new System.EventHandler(this.btn_XuatFile_Click);
            // 
            // TaoBarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_XuatFile);
            this.Controls.Add(this.img_barcode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_taoma);
            this.Controls.Add(this.txt_ma);
            this.Name = "TaoBarCode";
            this.Size = new System.Drawing.Size(821, 364);
            ((System.ComponentModel.ISupportInitialize)(this.img_barcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_barcode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_taoma;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Button btn_XuatFile;
    }
}

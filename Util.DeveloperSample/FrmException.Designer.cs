namespace Yaz.Util.DeveloperSample
{
    partial class FrmException
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmException));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ucPanel1 = new Yaz.ControlLibrary.UcPanel();
            this.ucBtn1 = new Yaz.ControlLibrary.UcBtn();
            this.ucBtnKapat = new Yaz.ControlLibrary.UcBtn();
            this.ucBtnGoster = new Yaz.ControlLibrary.UcBtn();
            this.ucBtnGizle = new Yaz.ControlLibrary.UcBtn();
            this.ucRichBase = new Yaz.ControlLibrary.UcRichTxt();
            this.ucBtnDevam = new Yaz.ControlLibrary.UcBtn();
            this.ucPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(21, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Beklenmeyen bir hata oluştu.İşleme devam etmeniz doğru olmayabilir";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(4, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(506, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Error";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucPanel1
            // 
            this.ucPanel1.Controls.Add(this.ucBtnDevam);
            this.ucPanel1.Controls.Add(this.ucBtn1);
            this.ucPanel1.Controls.Add(this.ucBtnKapat);
            this.ucPanel1.Controls.Add(this.ucBtnGoster);
            this.ucPanel1.Controls.Add(this.ucBtnGizle);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel1.Location = new System.Drawing.Point(0, 363);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(517, 34);
            this.ucPanel1.TabIndex = 15;
            this.ucPanel1.xEnabled = true;
            // 
            // ucBtn1
            // 
            this.ucBtn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtn1.Location = new System.Drawing.Point(116, 7);
            this.ucBtn1.Name = "ucBtn1";
            this.ucBtn1.Size = new System.Drawing.Size(90, 24);
            this.ucBtn1.TabIndex = 3;
            this.ucBtn1.Text = "Hatayı Kopyala";
            this.ucBtn1.UseVisualStyleBackColor = true;
            this.ucBtn1.Click += new System.EventHandler(this.ucBtn1_Click);
            // 
            // ucBtnKapat
            // 
            this.ucBtnKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnKapat.Location = new System.Drawing.Point(422, 7);
            this.ucBtnKapat.Name = "ucBtnKapat";
            this.ucBtnKapat.Size = new System.Drawing.Size(73, 24);
            this.ucBtnKapat.TabIndex = 2;
            this.ucBtnKapat.Text = "Çıkış";
            this.ucBtnKapat.UseVisualStyleBackColor = true;
            this.ucBtnKapat.Click += new System.EventHandler(this.ucBtnKapat_Click);
            // 
            // ucBtnGoster
            // 
            this.ucBtnGoster.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnGoster.Image")));
            this.ucBtnGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnGoster.Location = new System.Drawing.Point(12, 7);
            this.ucBtnGoster.Name = "ucBtnGoster";
            this.ucBtnGoster.Size = new System.Drawing.Size(98, 24);
            this.ucBtnGoster.TabIndex = 1;
            this.ucBtnGoster.Text = "&Detay";
            this.ucBtnGoster.UseVisualStyleBackColor = true;
            this.ucBtnGoster.Click += new System.EventHandler(this.ucBtnGoster_Click);
            // 
            // ucBtnGizle
            // 
            this.ucBtnGizle.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnGizle.Image")));
            this.ucBtnGizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnGizle.Location = new System.Drawing.Point(12, 7);
            this.ucBtnGizle.Name = "ucBtnGizle";
            this.ucBtnGizle.Size = new System.Drawing.Size(98, 24);
            this.ucBtnGizle.TabIndex = 0;
            this.ucBtnGizle.Text = "&Detay";
            this.ucBtnGizle.UseVisualStyleBackColor = true;
            this.ucBtnGizle.Click += new System.EventHandler(this.ucBtnGizle_Click);
            // 
            // ucRichBase
            // 
            this.ucRichBase.BackColor = System.Drawing.Color.White;
            this.ucRichBase.Location = new System.Drawing.Point(4, 87);
            this.ucRichBase.Name = "ucRichBase";
            this.ucRichBase.ReadOnly = true;
            this.ucRichBase.Size = new System.Drawing.Size(506, 270);
            this.ucRichBase.TabIndex = 16;
            this.ucRichBase.Text = "";
            this.ucRichBase.xHint = null;
            this.ucRichBase.xRequired = false;
            this.ucRichBase.xText = "";
            // 
            // ucBtnDevam
            // 
            this.ucBtnDevam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnDevam.Location = new System.Drawing.Point(343, 7);
            this.ucBtnDevam.Name = "ucBtnDevam";
            this.ucBtnDevam.Size = new System.Drawing.Size(73, 24);
            this.ucBtnDevam.TabIndex = 4;
            this.ucBtnDevam.Text = "Devam";
            this.ucBtnDevam.UseVisualStyleBackColor = true;
            this.ucBtnDevam.Click += new System.EventHandler(this.ucBtnDevam_Click);
            // 
            // FrmException
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 397);
            this.Controls.Add(this.ucRichBase);
            this.Controls.Add(this.ucPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmException";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilinmeyen Hata";
            this.ucPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Yaz.ControlLibrary.UcPanel ucPanel1;
        private Yaz.ControlLibrary.UcBtn ucBtnGizle;
        private Yaz.ControlLibrary.UcBtn ucBtnGoster;
        private Yaz.ControlLibrary.UcRichTxt ucRichBase;
        private Yaz.ControlLibrary.UcBtn ucBtn1;
        private Yaz.ControlLibrary.UcBtn ucBtnKapat;
        private Yaz.ControlLibrary.UcBtn ucBtnDevam;
    }
}

namespace Yaz.DbSqlExe.Forms
{
    partial class FrmDbSqlExe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDbSqlExe));
            this.sqlCommand = new Yaz.ControlLibrary.UcRichTxt();
            this.sorgu = new Yaz.ControlLibrary.UcLbl();
            this.dataBase = new Yaz.ControlLibrary.UcLbl();
            this.dataGrid = new Yaz.ControlLibrary.UcGrid();
            this.kullanicitxt = new Yaz.ControlLibrary.UcTxt();
            this.dataSec = new System.Windows.Forms.ComboBox();
            this.ucLbl1 = new Yaz.ControlLibrary.UcLbl();
            this.btnrapor = new Yaz.ControlLibrary.UcTypedBtn();
            ((System.ComponentModel.ISupportInitialize)(this.baseErrorProvider)).BeginInit();
            this.basepanel.SuspendLayout();
            this.basepanelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BaseMenu
            // 
            this.BaseMenu.Size = new System.Drawing.Size(800, 34);
            this.BaseMenu.xCustom.ParentMenu = this.BaseMenu;
            this.BaseMenu.xCustom.SorgulaEnabled = true;
            this.BaseMenu.xCustom.Title = Yaz.Util.BaseForm.CustomMenuItemTitles.Sorgula;
            this.BaseMenu.xCustom.Visible = true;
            this.BaseMenu.xCustom2.ParentMenu = this.BaseMenu;
            this.BaseMenu.xCustom2.Visible = false;
            this.BaseMenu.xDuzelt.ParentMenu = this.BaseMenu;
            this.BaseMenu.xDuzelt.SorgulaEnabled = true;
            this.BaseMenu.xDuzelt.Visible = true;
            this.BaseMenu.xIptal.ParentMenu = this.BaseMenu;
            this.BaseMenu.xIptal.SorgulaEnabled = true;
            this.BaseMenu.xIptal.Title = Yaz.Util.BaseForm.IptalItem.IptalTitles.Iptal;
            this.BaseMenu.xIptal.Visible = false;
            this.BaseMenu.xIzle.ParentMenu = this.BaseMenu;
            this.BaseMenu.xIzle.SorgulaEnabled = true;
            this.BaseMenu.xIzle.Visible = false;
            this.BaseMenu.xKaydet.ParentMenu = this.BaseMenu;
            this.BaseMenu.xKaydet.Visible = true;
            this.BaseMenu.xOnay.ParentMenu = this.BaseMenu;
            this.BaseMenu.xOnay.SorgulaEnabled = true;
            this.BaseMenu.xOnay.Visible = false;
            this.BaseMenu.xSil.ParentMenu = this.BaseMenu;
            this.BaseMenu.xSil.SorgulaEnabled = true;
            this.BaseMenu.xSil.Visible = true;
            this.BaseMenu.xSorgula.ParentMenu = this.BaseMenu;
            this.BaseMenu.xSorgula.Visible = true;
            this.BaseMenu.xVazgec.ParentMenu = this.BaseMenu;
            this.BaseMenu.xVazgec.Visible = true;
            this.BaseMenu.xYeni.ParentMenu = this.BaseMenu;
            this.BaseMenu.xYeni.SorgulaEnabled = false;
            this.BaseMenu.xYeni.Title = Yaz.Util.BaseForm.YeniTitles.Yeni;
            this.BaseMenu.xYeni.Visible = true;
            this.BaseMenu.xYukle.ParentMenu = this.BaseMenu;
            this.BaseMenu.xYukle.SorgulaEnabled = false;
            this.BaseMenu.xYukle.Visible = false;
            // 
            // basebtnKapat
            // 
            this.basebtnKapat.FlatAppearance.BorderSize = 0;
            this.basetooltip.SetToolTip(this.basebtnKapat, "Formu Kapat");
            // 
            // basebtnClearForm
            // 
            this.basebtnClearForm.FlatAppearance.BorderSize = 0;
            this.basetooltip.SetToolTip(this.basebtnClearForm, "Formu Temizle");
            // 
            // basebtnYardim
            // 
            this.basebtnYardim.FlatAppearance.BorderSize = 0;
            // 
            // basepanel
            // 
            this.basepanel.Location = new System.Drawing.Point(0, 418);
            this.basepanel.Size = new System.Drawing.Size(800, 32);
            // 
            // baselblAyirac
            // 
            this.baselblAyirac.Size = new System.Drawing.Size(800, 1);
            // 
            // basepanelButton
            // 
            this.basepanelButton.Location = new System.Drawing.Point(660, 1);
            // 
            // basebtnCrm
            // 
            this.basebtnCrm.FlatAppearance.BorderSize = 0;
            // 
            // basebtnDas
            // 
            this.basebtnDas.FlatAppearance.BorderSize = 0;
            // 
            // sqlCommand
            // 
            this.sqlCommand.BackColor = System.Drawing.SystemColors.Menu;
            this.sqlCommand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sqlCommand.Location = new System.Drawing.Point(81, 82);
            this.sqlCommand.Name = "sqlCommand";
            this.sqlCommand.Size = new System.Drawing.Size(280, 139);
            this.sqlCommand.TabIndex = 11;
            this.sqlCommand.Text = "";
            this.sqlCommand.xHint = null;
            this.sqlCommand.xText = "";
            // 
            // sorgu
            // 
            this.sorgu.AutoSize = true;
            this.sorgu.BackColor = System.Drawing.Color.Transparent;
            this.sorgu.Location = new System.Drawing.Point(12, 82);
            this.sorgu.Name = "sorgu";
            this.sorgu.Size = new System.Drawing.Size(43, 13);
            this.sorgu.TabIndex = 12;
            this.sorgu.Text = "SCRIPT";
            this.sorgu.xText = "SCRIPT";
            // 
            // dataBase
            // 
            this.dataBase.AutoSize = true;
            this.dataBase.Location = new System.Drawing.Point(12, 46);
            this.dataBase.Name = "dataBase";
            this.dataBase.Size = new System.Drawing.Size(59, 13);
            this.dataBase.TabIndex = 13;
            this.dataBase.Text = "DATABASE";
            this.dataBase.xText = "DATABASE";
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(54, 248);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(690, 150);
            this.dataGrid.TabIndex = 15;
            // 
            // kullanicitxt
            // 
            this.kullanicitxt.BackColor = System.Drawing.Color.White;
            this.kullanicitxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kullanicitxt.Enabled = false;
            this.kullanicitxt.Location = new System.Drawing.Point(519, 52);
            this.kullanicitxt.Name = "kullanicitxt";
            this.kullanicitxt.Size = new System.Drawing.Size(176, 21);
            this.kullanicitxt.TabIndex = 16;
            this.kullanicitxt.TextChanged += new System.EventHandler(this.kullaniciTxt_TextChanged_1);
            // 
            // dataSec
            // 
            this.dataSec.FormattingEnabled = true;
            this.dataSec.Items.AddRange(new object[] {
            "yazdbdev",
            "yazdbtest",
            "uatyazdbdev",
            "preprodyazdbdev"});
            this.dataSec.Location = new System.Drawing.Point(81, 43);
            this.dataSec.Name = "dataSec";
            this.dataSec.Size = new System.Drawing.Size(280, 21);
            this.dataSec.TabIndex = 17;
            // 
            // ucLbl1
            // 
            this.ucLbl1.AutoSize = true;
            this.ucLbl1.Location = new System.Drawing.Point(462, 54);
            this.ucLbl1.Name = "ucLbl1";
            this.ucLbl1.Size = new System.Drawing.Size(37, 13);
            this.ucLbl1.TabIndex = 18;
            this.ucLbl1.Text = "USER:";
            this.ucLbl1.xText = "USER:";
            // 
            // btnrapor
            // 
            this.btnrapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnrapor.Image = ((System.Drawing.Image)(resources.GetObject("btnrapor.Image")));
            this.btnrapor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrapor.Location = new System.Drawing.Point(610, 82);
            this.btnrapor.Name = "btnrapor";
            this.btnrapor.Size = new System.Drawing.Size(85, 30);
            this.btnrapor.TabIndex = 19;
            this.btnrapor.Text = "Rapor ";
            this.btnrapor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrapor.UseVisualStyleBackColor = true;
            this.btnrapor.xButtonType = Yaz.ControlLibrary.ButtonType.Rapor;
            this.btnrapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // FrmDbSqlExe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnrapor);
            this.Controls.Add(this.ucLbl1);
            this.Controls.Add(this.dataSec);
            this.Controls.Add(this.kullanicitxt);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.dataBase);
            this.Controls.Add(this.sorgu);
            this.Controls.Add(this.sqlCommand);
            this.Name = "FrmDbSqlExe";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.basepanel, 0);
            this.Controls.SetChildIndex(this.BaseMenu, 0);
            this.Controls.SetChildIndex(this.sqlCommand, 0);
            this.Controls.SetChildIndex(this.sorgu, 0);
            this.Controls.SetChildIndex(this.dataBase, 0);
            this.Controls.SetChildIndex(this.dataGrid, 0);
            this.Controls.SetChildIndex(this.kullanicitxt, 0);
            this.Controls.SetChildIndex(this.dataSec, 0);
            this.Controls.SetChildIndex(this.ucLbl1, 0);
            this.Controls.SetChildIndex(this.btnrapor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.baseErrorProvider)).EndInit();
            this.basepanel.ResumeLayout(false);
            this.basepanelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlLibrary.UcRichTxt sqlCommand;
        private ControlLibrary.UcLbl sorgu;
        private ControlLibrary.UcLbl dataBase;
        private ControlLibrary.UcGrid dataGrid;
        private ControlLibrary.UcTxt kullanicitxt;
        private System.Windows.Forms.ComboBox dataSec;
        private ControlLibrary.UcLbl ucLbl1;
        private ControlLibrary.UcTypedBtn btnrapor;
    }
}


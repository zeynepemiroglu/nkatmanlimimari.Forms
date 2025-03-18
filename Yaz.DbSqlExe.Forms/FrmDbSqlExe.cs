using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yaz.DbSql.Services;
using Yaz.Util.BaseForm;
using Yaz.Util.Common.Library;

namespace Yaz.DbSqlExe.Forms
{
    public partial class FrmDbSqlExe : FrmBaseMenu
    {

        SDbsql _sDbsql = new SDbsql();
        public FrmDbSqlExe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGrid.Visible = false;
            kullanicitxt.Text = System.Environment.UserName;
            dataSec.Enabled = false;
            sqlCommand.Enabled = false;

            BaseMenu.xSetMode(MenuMode.Baslangic);
            BaseMenu.xYeni.Click += new xEventHandler(xYeni_Click);
            BaseMenu.xDuzelt.Click += new xEventHandler(xDuzelt_Click);
            //BaseMenu.xIzle.Click += new xEventHandler(xIzle_Click);
            BaseMenu.xIptal.Click += new xEventHandler(xIptal_Click);
            BaseMenu.xSorgula.Click += new xEventHandler(xSorgula_Click);
            BaseMenu.xKaydet.Click += new xEventHandler(xKaydet_Click);
            BaseMenu.xVazgec.Click += new xEventHandler(xVazgec_Click);
        }
        private void xYeni_Click()
        {
            dataSec.Enabled = true;
            sqlCommand.Enabled = true;
            BaseMenu.xSetMode(MenuMode.Yeni);

        }
        private void xDuzelt_Click()
        {
            BaseMenu.xSetMode(MenuMode.Duzelt);
        }
        private void xIptal_Click()
        {
            BaseMenu.xSetMode(MenuMode.Iptal);

        }
        private void xSorgula_Click()
        {
            BaseMenu.xSetMode(MenuMode.Sorgula);

        }


        private void xVazgec_Click()
        {
            BaseMenu.xSetMode(MenuMode.Vazgec);
        }

        

        private  void xKaydet_Click()
        {

            if (dataSec.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen işlem yapacağınız veri tabanını seçiniz.");
                return;
            }
            DataTable dtSelectSonuc = null;
            string opAdi = System.Environment.UserName;
            string machineName = System.Environment.MachineName;
            _sDbsql.Execute(sqlCommand.Text.Trim(), ref dtSelectSonuc, opAdi,machineName );
            if (dtSelectSonuc != null)
            {
                dataGrid.DataSource = dtSelectSonuc;
                dataGrid.Visible = true;
            }

            BaseMenu.xSetMode(MenuMode.Kaydet);    
        }
  

        private void kullaniciTxt_TextChanged_1(object sender, EventArgs e)
        {
            var userName = System.Environment.UserName;
            var machineName = System.Environment.MachineName;
            kullanicitxt.Text = userName;
            
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            //string path = (@"C:\Users\zeynep.emiroglu\Desktop\sql_user_log.txt");
            //_sDbsql.txtYazdir(path);
            
            bool mailGonderildi = _sDbsql.otoMail();
            try
            {
                if (mailGonderildi)
                {
                    MessageBox.Show("Rapor başarıyla e-posta olarak gönderildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Rapor e-posta olarak gönderilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                throw new Exception("Mail gönderilemedi");

            }
        }
    
}

        
    


}


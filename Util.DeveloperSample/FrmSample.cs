/*
 * Created by NKabiloğlu,30/11/2005
 * Remoting de çalışacak uygulamaları client'da test etmek için hazırlandı
 */
using System;
using System.Windows.Forms;
using Yaz.DbSqlExe.Forms;
using Yaz.Util.Common.Library;
using Yaz.Util.Sample;

namespace Yaz.Util.DeveloperSample
{
    public partial class FrmSample : Form
    {
        private string _opAd = "YASINASL";
        private string _passwd = "Abcd+2024";
        private string _dbAd = "YAZDBDEV";
        private int _subeKod = 2;
        private string kanalKod = "FRM";
        private string kisaAd = "DODGR";
        private EkranParam _ep;

        public FrmSample()
        {
         
            //String filename = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            //RemotingConfiguration.Configure(filename, true);
            
            Sampler hs = new Sampler();
            try
            {
                string sonuc = hs.Login(_opAd, _passwd, _subeKod, _dbAd, kanalKod, kisaAd, out _ep);
                if (sonuc != null)
                {
                    MessageBox.Show(sonuc);
                    Application.Exit();
                }
                else
                {
                    InitializeComponent();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void FrmSample_Load(object sender, EventArgs e)
        {
            FdbsqlExe frm = new FdbsqlExe();
            frm.Open(_ep);
            this.Close();  
        }
    }
}
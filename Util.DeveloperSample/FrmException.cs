using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Yaz.Util.DeveloperSample
{
    public partial class FrmException : Form
    {
        public FrmException()
        {
            InitializeComponent();
        }
        Exception _ex;
        public FrmException(Exception ex)
        {
            InitializeComponent();            
            if (ex.InnerException != null)
            {
                _ex = ex.InnerException;
            }
            else
            {
                _ex = ex;
            }
            ucRichBase.Text = _ex.StackTrace;
            label3.Text = _ex.Message;            
            Gizle();

        }

        private void Kopyala()
        {
            StringBuilder str = new StringBuilder();
            str.Append("Hata:" + _ex.Message);
            str.Append(Environment.NewLine);
            str.Append(Environment.NewLine);
            str.Append("Program:" + _ex.Source);
            str.Append(Environment.NewLine);
            str.Append(Environment.NewLine);
            str.Append("Tarih:" + DateTime.Now);
            str.Append(Environment.NewLine);
            str.Append(Environment.NewLine);
            str.Append("Hata Ayrıntısı:");
            str.Append(Environment.NewLine);
            str.Append(_ex.StackTrace);
            Clipboard.SetText(str.ToString(), TextDataFormat.Text);
            //MessageBox.Show(str.ToString());
        }
        private void ucBtnGoster_Click(object sender, EventArgs e)
        {
            ucRichBase.Visible = true;
            ucBtnGoster.Visible = false;
            ucBtnGizle.Visible = true;
            ucBtnGizle.Select();
            this.Size = new Size(525, 431);
        }

        private void ucBtnGizle_Click(object sender, EventArgs e)
        {
            Gizle();
        }

        private void Gizle()
        {
            ucRichBase.Visible = false;
            ucBtnGoster.Visible = true;
            ucBtnGoster.Select();
            ucBtnGizle.Visible = false;
            this.Size = new Size(525, 155);
        }

        private void ucBtn1_Click(object sender, EventArgs e)
        {
            Kopyala();
        }

        private void ucBtnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ucBtnDevam_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
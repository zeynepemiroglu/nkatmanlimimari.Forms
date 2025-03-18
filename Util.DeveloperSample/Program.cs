﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Yaz.Util.DeveloperSample
{
    static class Program
    {        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.Run(new FrmSample());
        }
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            FrmException frmex = new FrmException(e.Exception);
            frmex.ShowDialog();
        }
    }
}
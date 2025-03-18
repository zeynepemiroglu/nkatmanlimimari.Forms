using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yaz.Util.Common.Client;
using Yaz.Util.Common.Library;

namespace Yaz.DbSqlExe.Forms
{
    public class FdbsqlExe
    {
        /// <summary>
        /// The main entry point for the application.
        public object Open(EkranParam ep)
        {
            Client.ShowForm(ep, new FrmDbSqlExe());
            return null;
        }
    }
}

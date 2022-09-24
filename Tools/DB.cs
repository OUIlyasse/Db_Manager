using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using System.Data;

namespace Tools
{
    public class DB
    {
        #region Variables

        private SqlConnection con = new SqlConnection(Properties.Settings.Default.conDB);
        private SqlConnection mCon = new SqlConnection(Properties.Settings.Default.conMaster);

        #endregion Variables

        public static DataTable getInstanceSQL()
        {
            return SmoApplication.EnumAvailableSqlServers(true);
        }

        public static List<string> getDatabases()
        {
            return null;
        }

        public static void Backup()
        {
        }

        public static void Restore()
        {
        }
    }
}
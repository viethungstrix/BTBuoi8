using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.DirectoryServices;

namespace BT1
{
    class ConnectSQL
    {
        SqlConnection connect;
        public ConnectSQL()
        {
            connect = new SqlConnection("Data source = <DESKTOP-CIRH81G>; Initial Catalog = QLSV; UserID=...;Password=...");
        }
        public ConnectSQL(string strcn)
        {
            connect = new SqlConnection(strcn);
        }
    }
    public partial class QLKhoa: Form
    {
        ConnectSQL kn = new ConnectSQL();
        SqlConnection connsql;
        public QLKhoa()
        {
            InitializeComponent();
            connsql = kn.connect;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Magic
{
    public class BlackBox
    {
        private SQLiteConnection con;

        public BlackBox()
        {
            con = new SQLiteConnection("datasource=Database.db");
            con.Open();
        }
    }
}

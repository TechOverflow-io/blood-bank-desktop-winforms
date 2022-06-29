using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System_Layred.DL
{
    class DBConnection
    {
        private SqlConnection con;

        public SqlConnection Con
        {
            get { return con; }
            set { con = value; }
        }
        public DBConnection()
        {

            string Path = Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
            AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);

            String dbCon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + appPath[0] + @"BBMS.mdf;Integrated Security=True";
            con = new SqlConnection(dbCon);


            //String dbCon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename= C:\Users\ShazaiB SarwaR\documents\visual studio 2013\Projects\Blood_Bank_Management_System_Layred\Blood_Bank_Management_System_Layred\BBMS.mdf;Integrated Security=True";

            //string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath[0] + @"SCRS_W3.mdf;Integrated Security=True";
            //string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arslan\source\repos\Lect25_W3_LA\Lect25_W3_LA\SCRS_W3.mdf;Integrated Security=True";
            //con = new SqlConnection(conString);



        }

    }
}

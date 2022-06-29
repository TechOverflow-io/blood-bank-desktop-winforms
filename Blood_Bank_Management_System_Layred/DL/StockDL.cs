using Blood_Bank_Management_System_Layred.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System_Layred.DL
{
    class StockDL
    {
        DBConnection dbconn;

        public StockDL()
        {
            dbconn = new DBConnection();
        }

        public DataSet fetchAllFromDB()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string query = "select * from stock";
                cmd.Connection = dbconn.Con;
                cmd.CommandText = query;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet);
                return dataSet;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        public int UpdateStock(StockDTO sdo)
        {

            try
            {
                dbconn.Con.Open();
                String UpdateQuery = "update stock set quantity=quantity+ " + sdo.Quantity + " where bloodgroup = '" + sdo.BloodGroup + "'";
                SqlCommand com = new SqlCommand(UpdateQuery, dbconn.Con);
                int rowAffected = com.ExecuteNonQuery();
                return rowAffected;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbconn.Con.Close();
            }
        }

        public int DecreaseStockFromDB(StockDTO sdo)
        {

            try
            {
                dbconn.Con.Open();
                String UpdateQuery = "update stock set quantity=quantity- " + sdo.Quantity + " where bloodgroup = '" + sdo.BloodGroup + "'";
                SqlCommand com = new SqlCommand(UpdateQuery, dbconn.Con);
                int rowAffected = com.ExecuteNonQuery();
                return rowAffected;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbconn.Con.Close();
            }
        }
    }
}

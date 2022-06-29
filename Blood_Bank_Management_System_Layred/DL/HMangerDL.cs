using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blood_Bank_Management_System_Layred.DTO;

namespace Blood_Bank_Management_System_Layred.DL
{
    class HMangerDL
    {
        DBConnection dbconn;
        public HMangerDL()
        {
            dbconn = new DBConnection();
        }

        public DataSet FetchAllFromDB()
        {
            try
            {


                SqlCommand cmd = new SqlCommand();

                string query = "select dName, mobile, email, bloodgroup, city, address from Donor";
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
        public DataSet FetchByAddressFromDB(HMangerDTO hmD)
        {
            try
            {


                String query = "select dName, mobile, email, bloodgroup, city, address from Donor where city Like '%" + hmD.City + "%' or address like '%" + hmD.Address + "%' ";
                //String query = "select * from Donor where city Like @City % or address like @Address % ";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@City", hmD.City);
                cmd.Parameters.AddWithValue("@Address", hmD.Address);

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

        public DataSet FetchByBloodGroupFromDB(HMangerDTO hmDTO)
        {
            try
            {


                // String query = "select dName, mobile, email, bloodgroup, city, address from Donor where bloodgroup Like '" + d.Bgroup + "%'  ";
                String query = "select dName, mobile, email, bloodgroup, city, address from Donor where bloodgroup Like @BG  ";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@BG", hmDTO.Bgroup);


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

        public int AddRequest(HMBloodAmmount newD)
        {
            try
            {
                dbconn.Con.Open();
                //String insertDonorQuery = "insert into Donor (dName , fName , mName , dob , mobile , gender , email, bloodgroup , city , address) values ('" + newD.DName + "', '" + newD.Fname + "' , '" + newD.Mname + "' , '" + newD.DoB + "' , '" + newD.Moile + "' , '" + newD.Gender + "' , '" + newD.Email + "' , '" + newD.Bgroup + "' , '" + newD.City + "' , '" + newD.Address + "')";

                String insertDonorQuery = "insert into BloodRequest (BloodGroup, Units) values (@BloodGroup, @Amount)";
                SqlCommand com = new SqlCommand(insertDonorQuery, dbconn.Con);


                com.Parameters.AddWithValue("@BloodGroup", newD.BloodGroup);
                com.Parameters.AddWithValue("@Amount", newD.Amount);


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

        public DataSet fetchAllFromDB()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string query = "select * from BloodRequest";
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
        public int DecreaseStockFromDB(HMBloodAmmount sdo)
        {

            try
            {
                dbconn.Con.Open();
                String UpdateQuery = "update stock set quantity=quantity- " + sdo.Amount + " where bloodgroup = '" + sdo.BloodGroup + "'";
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
        public int DeleteFromRequest(HMBloodAmmount d)
        {

            try
            {
                dbconn.Con.Open();

                //String deleteQuery = "delete from Donor where did = " + d.DiD + "";
                String deleteQuery = "delete from BloodRequest where Id = @DiD";
                SqlCommand com = new SqlCommand(deleteQuery, dbconn.Con);
                com.Parameters.AddWithValue("@DiD", d.ID);
                int rowAffected = com.ExecuteNonQuery();
                return rowAffected;
            }
            catch (SqlException ex)
            {
                throw ex;
                // return 0;
            }
            finally
            {
                dbconn.Con.Close();
            }

        }
    }
}

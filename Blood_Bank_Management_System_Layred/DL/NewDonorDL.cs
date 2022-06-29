using Blood_Bank_Management_System_Layred.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System_Layred.DL
{
    class NewDonorDL
    {
        DBConnection dbconn;

        public NewDonorDL()
        {
            dbconn = new DBConnection();
        }

        public int InsertDonorInDB(NewDonorDTO newD)
        {


            try
            {
                dbconn.Con.Open();
                //String insertDonorQuery = "insert into Donor (dName , fName , mName , dob , mobile , gender , email, bloodgroup , city , address) values ('" + newD.DName + "', '" + newD.Fname + "' , '" + newD.Mname + "' , '" + newD.DoB + "' , '" + newD.Moile + "' , '" + newD.Gender + "' , '" + newD.Email + "' , '" + newD.Bgroup + "' , '" + newD.City + "' , '" + newD.Address + "')";

                String insertDonorQuery = "insert into Donor (dName , fName , mName , dob , mobile , gender , email, bloodgroup , city , address) values (@Dname, @Fname , @Mname ,@DOB , @Mobile , @Gender , @Email, @BloodGroup , @City , @Address)";
                SqlCommand com = new SqlCommand(insertDonorQuery, dbconn.Con);

                com.Parameters.AddWithValue("@Dname", newD.DName);
                com.Parameters.AddWithValue("@Fname", newD.Fname);
                com.Parameters.AddWithValue("@Mname", newD.Mname);
                com.Parameters.AddWithValue("@DOB", newD.DoB);
                com.Parameters.AddWithValue("@Mobile", newD.Moile);
                com.Parameters.AddWithValue("@Gender", newD.Gender);
                com.Parameters.AddWithValue("@Email", newD.Email);
                com.Parameters.AddWithValue("@BloodGroup", newD.Bgroup);
                com.Parameters.AddWithValue("@City", newD.City);
                com.Parameters.AddWithValue("@Address", newD.Address);


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
        public DataSet getMaxIDFromDB()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string query = "select max(did) from Donor";
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
        public DataSet getAllDonorInfoFromDB(NewDonorDTO d)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                //string query = "select * from Donor where did = " + d.DiD + "";
                cmd.Parameters.AddWithValue("@DiD", d.DiD);
                string query = "select * from Donor where did = @DiD";
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
        public int UpdateDonor(NewDonorDTO d)
        {

            try
            {
                dbconn.Con.Open();
                //String UpdateQuery = "update Donor set dName = '" + d.DName + "' , fName = '" + d.Fname + "' , mName = '" + d.Mname + "' , dob = '" + d.DoB + "' , mobile = " + d.Moile + " , gender = '" + d.Gender + "' , email = '" + d.Email + "', bloodgroup = '" + d.Bgroup + "' , city = '" + d.City + "' , address = '" + d.Address + "' where did = " + d.DiD + "";

                String UpdateQuery = "update Donor set dName = @Dname, fName = @Fname, mName = @Mname, dob = @DOB , mobile = @Mobile , gender = @Gender, email = @Email, bloodgroup = @BloodGroup, city = @City, address = @Address where did = @DiD";
                SqlCommand com = new SqlCommand(UpdateQuery, dbconn.Con);
                com.Parameters.AddWithValue("@Dname", d.DName);
                com.Parameters.AddWithValue("@Fname", d.Fname);
                com.Parameters.AddWithValue("@Mname", d.Mname);
                com.Parameters.AddWithValue("@DOB", d.DoB);
                com.Parameters.AddWithValue("@Mobile", d.Moile);
                com.Parameters.AddWithValue("@Gender", d.Gender);
                com.Parameters.AddWithValue("@Email", d.Email);
                com.Parameters.AddWithValue("@BloodGroup", d.Bgroup);
                com.Parameters.AddWithValue("@City", d.City);
                com.Parameters.AddWithValue("@Address", d.Address);
                com.Parameters.AddWithValue("@DiD", d.DiD);

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
        public DataSet FetchAllFromDB()
        {
            try
            {


                SqlCommand cmd = new SqlCommand();

                string query = "select * from Donor";
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
        public DataSet FetchByAddressFromDB(NewDonorDTO d)
        {
            try
            {


                String query = "select * from Donor where city Like '%" + d.City + "%' or address like '%" + d.Address + "%' ";
                //String query = "select * from Donor where city Like @City % or address like @Address % ";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@City", d.City);
                cmd.Parameters.AddWithValue("@Address", d.Address);

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
        public DataSet FetchByBloodGroupFromDB(NewDonorDTO d)
        {
            try
            {


                // String query = "select * from Donor where bloodgroup Like '" + d.Bgroup + "%'  ";
                String query = "select * from Donor where bloodgroup Like @BG  ";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@BG", d.Bgroup);


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

        public int DeleteDonorFromDB(NewDonorDTO d)
        {

            try
            {
                dbconn.Con.Open();

                //String deleteQuery = "delete from Donor where did = " + d.DiD + "";
                String deleteQuery = "delete from Donor where did = @DiD";
                SqlCommand com = new SqlCommand(deleteQuery, dbconn.Con);
                com.Parameters.AddWithValue("@DiD", d.DiD);
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

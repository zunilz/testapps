
using Microsoft.Data.SqlClient;
using System.Data; 
 


namespace DataLayer
{
    public class Datalayer
    {
        private SqlConnection conn;
        private SqlCommand comm;
        string connstring = "database=student;server=.;user=sa;password=wintellect";

        public Datalayer()
        {
            conn = new SqlConnection(connstring);
            conn.Open();


        }

        public void ExecuteCommand()
        {

            comm = new SqlCommand();
            comm.Connection = conn;

            //Creating instance of SqlParameter  
            SqlParameter PmtrRollNo = new SqlParameter();
            PmtrRollNo.ParameterName = "@rn"; // Defining Name  
            PmtrRollNo.SqlDbType = SqlDbType.Int; // Defining DataType  
            PmtrRollNo.Direction = ParameterDirection.Input; // Setting the direction  

            //Creating instance of SqlParameter  
            SqlParameter PmtrName = new SqlParameter();
            PmtrName.ParameterName = "@nm"; // Defining Name  
            PmtrName.SqlDbType = SqlDbType.VarChar; // Defining DataType  
            PmtrName.Direction = ParameterDirection.Input; // Setting the direction  

            //Creating instance of SqlParameter  
            SqlParameter PmtrCity = new SqlParameter();

            PmtrCity.ParameterName = "@ct"; // Defining Name  
            PmtrCity.SqlDbType = SqlDbType.VarChar; // Defining DataType  
            PmtrCity.Direction = ParameterDirection.Input; // Setting the direction  

            // Adding Parameter instances to sqlcommand  

            comm.Parameters.Add(PmtrRollNo);
            comm.Parameters.Add(PmtrName);
            comm.Parameters.Add(PmtrCity);

            // Setting values of Parameter  

            PmtrRollNo.Value = 22;
            PmtrName.Value = "sdad";
            PmtrCity.Value = "ewesdfsdf";

            comm.CommandText = "insert into student_detail values(@rn,@nm,@ct)";

            try
            {
                comm.ExecuteNonQuery();
                Console.WriteLine("Saved");
            }
            catch (Exception)
            {
                Console.WriteLine("Not Saved");
            }
            finally
            {
                conn.Close();
            }


        }
    }
}
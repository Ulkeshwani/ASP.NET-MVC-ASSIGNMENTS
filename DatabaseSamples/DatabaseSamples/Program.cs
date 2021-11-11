using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSamples
{
    class Program
    {

        public SqlConnection sqlConnection = null;
        public SqlCommand sqlCmd = null;
        public SqlDataReader sqlReader;
        string connectionString;
       
        public Program()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Started.....");
            Program ps = new Program();
            //ps.AddDepartment(90, "Development", "Nagpur");
            //ps.ListAllDepartments();
            //ps.UpdateDepartment(90, "Finance", "Nagpur");
            //ps.DeleteDepartment(90);
            ps.ListDeptByCity("Jalgaon");
            Console.WriteLine("Finished.....");
        }

        public void AddDepartment(int deptNo, string deptName, string city)
        {
            SqlCommand sqlCmd = null;
            sqlConnection = new SqlConnection(connectionString);

            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            try
            {
                sqlCmd = new SqlCommand("USP_InsertDept", sqlConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pDeptNo", deptNo);
                sqlCmd.Parameters.AddWithValue("@pDeptName", deptName);
                sqlCmd.Parameters.AddWithValue("@pCity", city);
                int rowCount = sqlCmd.ExecuteNonQuery();
                if (rowCount == -1)
                {
                    Console.WriteLine("New DataRow added Successfully...");
                }
            }
            catch (SqlException exSql)
            {
                Console.WriteLine(exSql.Message);
            }
            catch (Exception exMain)
            {
                Console.WriteLine(exMain.Message);
            }
            finally
            {
                sqlConnection.Close();
                sqlCmd.Dispose();
            }
        }

        public void UpdateDepartment(int deptNo,string deptName,string city)
        {
            SqlCommand sqlCmd = null;
            sqlConnection = new SqlConnection(connectionString);

            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            try
            {
                sqlCmd = new SqlCommand("USP_UpdateDept", sqlConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pDeptNo", deptNo);
                sqlCmd.Parameters.AddWithValue("@pDeptName", deptName);
                sqlCmd.Parameters.AddWithValue("@City", city);
                int rowCount = sqlCmd.ExecuteNonQuery();
                if (rowCount == -1)
                {
                    Console.WriteLine("The Record Updated Successfully...");
                }
            }
            catch (SqlException exSql)
            {
                Console.WriteLine(exSql.Message);
            }
            catch (Exception exMain)
            {
                Console.WriteLine(exMain.Message);
            }

            finally
            {
                sqlCmd.Dispose();
                sqlConnection.Close();
            }

        }

        public void DeleteDepartment(int deptNo)
        {
            SqlCommand sqlCmd = null;
            sqlConnection = new SqlConnection(connectionString);

            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            try
            {

                sqlCmd = new SqlCommand("USP_DeleteDept", sqlConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pDeptNo", deptNo);
                int rowCount = sqlCmd.ExecuteNonQuery();
                if (rowCount == -1)
                {
                    Console.WriteLine("The Record Deleted Successfully...");
                }
                else
                {
                    Console.WriteLine("There Was No Such Related Data Found.....");
                }

            }
            catch (SqlException exSql)
            {
                Console.WriteLine(exSql.Message);
            }
            catch (Exception exMain)
            {
                Console.WriteLine(exMain.Message);
            }

            finally
            {
                sqlCmd.Dispose();
                sqlConnection.Close();
            }
        }

        public void ListDeptByCity(string city)
        {

            SqlCommand sqlCmd = null;
            sqlConnection = new SqlConnection(connectionString);

            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            try
            {
                sqlCmd = new SqlCommand("USP_ListDeptByCity", sqlConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pCity", city);
                sqlReader = sqlCmd.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    Console.WriteLine("Department Name \t\t Department Code \t\t City");
                    Console.WriteLine("================================================================");
                    while (sqlReader.Read())
                    {
                        Console.WriteLine("{0}\t\t {1}\t\t  \t{2}", sqlReader[0], sqlReader[1], sqlReader[2]);
                    }
                }
                else
                {
                    Console.WriteLine("There are no rows being fteched as of now.....!!");
                }
            }
            catch (SqlException exSql)
            {
                Console.WriteLine(exSql.Message);
            }
            catch (Exception exMain)
            {
                Console.WriteLine(exMain.Message);
            }

            finally
            {
                sqlCmd.Dispose();
                sqlConnection.Close();
            }
        }

        public void ListAllDepartments()
        {
            SqlCommand sqlCmd = null;
            sqlConnection = new SqlConnection(connectionString);

            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            try
            {
                sqlCmd = new SqlCommand("USP_ListAllDept", sqlConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCmd.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    Console.WriteLine("Department Code \t\t Department Name \t\t City");
                    Console.WriteLine("================================================================");
                    while (sqlReader.Read())
                    {
                        Console.WriteLine("{0}\t\t {1}\t\t  \t{2}", sqlReader[0], sqlReader[1], sqlReader[2]);
                    }
                }
                else
                {
                    Console.WriteLine("There are no rows being fteched as of now.....!!");
                }
            }
            catch (SqlException exSql)
            {
                Console.WriteLine(exSql.Message);
            }
            catch (Exception exMain)
            {
                Console.WriteLine(exMain.Message);
            }

            finally
            {
                sqlCmd.Dispose();
                sqlConnection.Close();
            }
        }
    }
}

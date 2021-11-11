using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace CRUDDemos 
{
    class Program
    {
        private SqlConnection sqlCon = null;
        private SqlCommand sqlCmd=null;
        private SqlDataReader sqlReader;
        private string str;
        static void Main(string[] args)
        {

            Console.WriteLine("Started");
             // ListAllDepartments();
            //DeptBO dep = new DeptBO() { DeptCode = 400, DeptName = "EventsMgmt", City = "Las Vegas" };
            // DeptBO dep = new DeptBO() { DeptCode = 401, DeptName = "Federal Bureau Inv", City = "New York" };
            // InsertDepartment(dep);
            // PerformDelete(81);
            //ListAllDepartments();
            //  DeptBO dep = new DeptBO() { DeptCode = 401, DeptName = "Crime Sc Investigation", City = "Miami" };
            //  PerformUpdate(dep);
            // ListAllDepartments();
             ListAllDeptsUsingProc();
            // ListAllDeptsByCityUsingProc("Pune");
            //DisconnectedDemos objDisconnected = new DisconnectedDemos();
            //objDisconnected.DisplayAllDepts();
            //// objDisconnected.AddDept(81, "ggg", "city");
            ////objDisconnected.DeleteDept(81);
            //objDisconnected.Upadtedept(81, "dddd", "ccccc");
            //objDisconnected.DisplayAllDepts();
            Console.WriteLine("Done");
            Console.ReadLine();

        }

        
        public static void ListAllDepartments()
        {

            SqlCommand sqlCmd = null;
            //string str = @"Data Source=.\sqlexpress;Initial Catalog=SPFLearning;User ID=sa;Password=sa@123";
            SqlConnection sqlCon = new Program().GetConnection();
            try
            {
                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                }
                string selectQuery = "SELECT * FROM departments";
                sqlCmd = new SqlCommand(selectQuery, sqlCon);
                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    Console.WriteLine("Code \t\t\t Name \t\t\t Location ");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    while (sqlDataReader.Read())
                    {
                        Console.WriteLine("{0}\t\t\t {1}\t\t\t {2}\t\t\t", sqlDataReader[0], sqlDataReader["DeptName"], sqlDataReader[2]);
                    }

                }
                else
                {Console
                    .WriteLine("There are no rows being fteched as of now.....!!");
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
                sqlCon.Close();
            }

        }

        public static void InsertDepartment(DeptBO dep)
        {
            string queryInsert = "INSERT INTO Departments VALUES(@pDeptCode, @pDName, @pLoc)";
            SqlConnection sqlCon = new Program().GetConnection();
            SqlCommand sqlCmd = null;
            int rowCount = 0;
                 
            try
            {
                //Ins ,del and upd -ExecuteNonQuery()
                //parametric queries
                sqlCmd = new SqlCommand(queryInsert, sqlCon);
                sqlCmd.Parameters.AddWithValue("@pDeptCode", dep.DeptCode);
                sqlCmd.Parameters.AddWithValue("@pDName", dep.DeptName);
                sqlCmd.Parameters.AddWithValue("@pLoc", dep.City);
                rowCount = sqlCmd.ExecuteNonQuery();
                if (rowCount == 1)
                {
                    Console.WriteLine("New Department added successfully...");
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
                sqlCon.Close();
                sqlCmd.Dispose();


            }

        }

        public static void PerformDelete(int deptno)
        {
            string queryDelete = "DELETE FROM departments WHERE DEPTCODE=@pDeptCode";
            SqlConnection sqlCon = new Program().GetConnection();
            SqlCommand sqlCmd = null;
            int rowCount = 0;
          
            try
            {

                sqlCmd = new SqlCommand(queryDelete, sqlCon);
                sqlCmd.Parameters.AddWithValue("@pDeptCode", deptno);

                rowCount = sqlCmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    Console.WriteLine("THE Department REMOVED successfully...");
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception exMain)
            {
                Console.WriteLine(exMain.Message);
            }
            finally
            {
                sqlCmd.Dispose();


            }
        }
        public static void PerformUpdate(DeptBO dep)
        {
            SqlConnection sqlCon = new Program().GetConnection();
            SqlCommand sqlCmd = null;
            int rowCount = 0;
            //int deptno = 0;
           
            try
            {
                // sqlCon.Open();
                sqlCmd = new SqlCommand("UPDATE departments SET DEPTNAME=@pDName,city=@pLoc WHERE DEPTCODE=@pDeptCode", sqlCon);
                sqlCmd.Parameters.AddWithValue("@pDeptCode", dep.DeptCode);
                sqlCmd.Parameters.AddWithValue("@pDName", dep.DeptName);
                sqlCmd.Parameters.AddWithValue("@pLoc", dep.City);
                rowCount = sqlCmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    Console.WriteLine("Existing {0} Department Upddated successfully...", dep.DeptName);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                sqlCmd.Dispose();


            }
        }


        public static void ListAllDeptsUsingProc()
        {
            SqlConnection sqlCon = new Program().GetConnection();
            SqlCommand sqlCmd = null;
            SqlDataReader sqlReader = null;
            try
            {
                //sqlCon.Open();
                sqlCmd = new SqlCommand("USP_GetDepartmentDetails", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCmd.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    Console.WriteLine("Code \t\t\t Name \t\t\t Location ");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    while (sqlReader.Read())
                    {
                        Console.WriteLine("{0}\t\t\t {1}\t\t\t {2}", sqlReader[0], sqlReader["DeptName"], sqlReader[2]);
                    }

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception exMain)
            {
                Console.WriteLine(exMain.Message);
            }
            finally
            { sqlCmd.Dispose(); }

        }

        public static void ListAllDeptsByCityUsingProc(string city)
        {
            SqlConnection sqlCon = new Program().GetConnection();
            SqlCommand sqlCmd = null;
            SqlDataReader sqlReader = null;
            try
            {
                //sqlCon.Open();
                sqlCmd = new SqlCommand("USP_listDepartmentsByCity", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pCity", city);
                sqlReader = sqlCmd.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    //Console.WriteLine("Code \t\t\t Name \t\t\t Location ");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    while (sqlReader.Read())
                    {
                        Console.WriteLine("{0} {1} {2}", sqlReader[0], sqlReader[1], sqlReader[2]);
                    }
                    //Console.WriteLine("Code \t\t\t Name \t\t\t Location ");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { sqlCmd.Dispose(); }

        }

        public SqlConnection GetConnection()
        {
            str = ConfigurationManager.ConnectionStrings["CnStr"].ToString();
            sqlCon = new SqlConnection(str);
          //  sqlCon = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=SPFLearning;User ID=sa;Password=sa@123");
            if (sqlCon.State != ConnectionState.Open)
            {
                sqlCon.Open();
            }
            return sqlCon;
        }


    }
}

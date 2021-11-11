using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDemo
{
    class Program
    {
        private SqlConnection sqlCon = null;
        private SqlCommand sqlCmd = null;
        private SqlDataReader sqlReader;
        private string str;

        static void Main(string[] args)
        {
            //@pDeptNo ,@pDeptName,@pCity
            Program obj = new Program();
            obj.AddDepartment(111, "Finance", "Jalgaon");
            Console.ReadLine();
        }

        public void AddDepartment(int deptNo, string deptName,string city)
        {
            SqlCommand sqlCmd = null;
            str = ConfigurationManager.ConnectionStrings["CnStr"].ToString();
            sqlCon = new SqlConnection(str);

            if (sqlCon.State != ConnectionState.Open)
            {
                sqlCon.Open();
            }

            try
            {

                sqlCmd = new SqlCommand("USP_Insertdepartment", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pDeptNo",deptNo);
                sqlCmd.Parameters.AddWithValue("@pDeptName",deptName);
                sqlCmd.Parameters.AddWithValue("@pCity",city);
                int rowCount = sqlCmd.ExecuteNonQuery();
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
    }
}

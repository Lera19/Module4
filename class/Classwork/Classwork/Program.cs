using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Department>();   
            var connectionString = ConfigurationManager.ConnectionStrings["HRSQLService"].ConnectionString;

            var selectDeps = "Select * from departments";
            SqlDataAdapter adapter = new SqlDataAdapter(selectDeps, connectionString);
            DataSet depsSet = new DataSet();

            

            adapter.Fill(depsSet);

            DataTable depTable = depsSet.Tables[0];
            Console.WriteLine("Deps info");

            foreach (DataRow row in depsSet.Tables[0].Rows)
            {
                departments.Add(new Department((int)row[0], (string)row[1]));
            }

            ///////////////////////////////////////////////////
            DataRow newDepRow = depTable.NewRow();
            newDepRow["department_name"] = "TEST5";
            newDepRow["Location_id"] = 1400;

            depTable.Rows.Add(newDepRow);
            var builder = new SqlCommandBuilder(adapter);
            builder.DataAdapter.Update(depTable);
            depsSet.Tables[0].AcceptChanges();
            
            ////////new SqlCommandBuilder(adapter);
            adapter.Update(depTable);
            
            //depsSet.AcceptChanges();
           // adapter.Fill(depsSet);

            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Deps info");

            //foreach (DataRow row in depsSet.Tables[0].Rows)
            //{
            //    departments.Add(new Department((int)row[0], (string)row[1]));
            //}


            departments.ForEach(Console.WriteLine);



            Console.ReadKey();
        }
    }
}




//static void Main(string[] args)
//{
//    var departments = new List<Department>();
//    var connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=HumanResourse;Integrated Security=True";
//    using (SqlConnection scn = new SqlConnection())
//    {
//        scn.ConnectionString = connectionString;
//        scn.Open();


//        string selectEmployees = "Select * From departments";
//        SqlCommand sqlCommand = new SqlCommand(selectEmployees, scn);

//        var dataReader = sqlCommand.ExecuteReader();
//        while (dataReader.Read())
//        {
//            departments.Add(new Department((int)dataReader[0], (string)dataReader[1]));
//        }




//        scn.Close();
//    }
//    departments.ForEach(Console.WriteLine);

//    Console.ReadKey();

//////////////////////////////////////////////////////////////////////////




//class Program
//{
//    static void Main(string[] args)
//    {
//        var departments = new List<Department>();
//        var connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=HumanResourse;Integrated Security=True";
//        using (SqlConnection scn = new SqlConnection())
//        {
//            scn.ConnectionString = connectionString;
//            scn.Open();


//            string selectEmployees = "Select count(*) From departments"; //возвращает количество
//                                                                         //   string selectEmployees = "Select * From departments"; возвращает нулевое значение 
//            SqlCommand sqlCommand = new SqlCommand(selectEmployees, scn);

//            int numOfRecords = (int)sqlCommand.ExecuteScalar();
//            Console.WriteLine(numOfRecords);





//            scn.Close();
//        }


//        Console.ReadKey();
//    }


///////////////////////////////////////////////////////////////////////////
///

//class Program
//{
//    static void Main(string[] args)
//    {
//        var departments = new List<Department>();
//        var connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=HumanResourse;Integrated Security=True";
//        using (SqlConnection scn = new SqlConnection())
//        {
//            scn.ConnectionString = connectionString;
//            scn.Open();



//            string insertDepartment = "INSERT INTO departments (department_name, location_id) VALUES ('TEST1', 1700)";
//            SqlCommand sqlCommand = new SqlCommand(insertDepartment, scn);

//            var nOfAffectedRows = sqlCommand.ExecuteNonQuery();
//            Console.WriteLine(nOfAffectedRows);

//            sqlCommand.CommandText = "Select * From departments";

//            var dataReader = sqlCommand.ExecuteReader();
//            while (dataReader.Read())
//            {
//                departments.Add(new Department((int)dataReader[0], (string)dataReader[1]));
//            }





//            scn.Close();
//        }
//        departments.ForEach(Console.WriteLine);


//        Console.ReadKey();
//    }
//}

/////////////////////////////////////////////////////////////////////



//class Program
//{
//    static void Main(string[] args)
//    {
//        var departments = new List<Department>();
//        var connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=HumanResourse;Integrated Security=True";
//        using (SqlConnection scn = new SqlConnection())
//        {
//            scn.ConnectionString = connectionString;
//            scn.Open();


//            SqlCommand sqlCommand = new SqlCommand("DEMO_PROC", scn);
//            sqlCommand.CommandType = CommandType.StoredProcedure;

//            sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
//            sqlCommand.Parameters["@ID"].Value = 100;

//            var dataReader = sqlCommand.ExecuteReader();
//            while (dataReader.Read())
//            {
//                Console.WriteLine($"Employee {dataReader[1]} {dataReader[2]}");
//            }


//            scn.Close();
//        }
//        departments.ForEach(Console.WriteLine);


//        Console.ReadKey();

    //////////////////////////////////////////////////////////

//    {
//    class Program
//{
//    static void Main(string[] args)
//    {
//        var departments = new List<Department>();
//        var connectionString = ConfigurationManager.ConnectionStrings["HRSQLService"].ConnectionString;
//        using (SqlConnection scn = new SqlConnection())
//        {
//            scn.ConnectionString = connectionString;
//            //scn.Open();


//            SqlCommand sqlCommand = new SqlCommand("DEMO_PROC", scn);
//            sqlCommand.CommandType = CommandType.StoredProcedure;

//            sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
//            sqlCommand.Parameters["@ID"].Value = 100;

//            var dataReader = sqlCommand.ExecuteReader();
//            while (dataReader.Read())
//            {
//                Console.WriteLine($"Employee {dataReader[1]} {dataReader[2]}");
//            }


//            scn.Close();
//        }
//        departments.ForEach(Console.WriteLine);


//        Console.ReadKey();
//    }
//}
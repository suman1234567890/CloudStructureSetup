using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

class Database
{
    
    public Database()

    {
        // TODO: Complete member initialization
    }
    public int InsertIntoDatabase(String sql)
    {
            

        try
        {

            string connStr = "server=172.16.58.71;port=3306;user=root;database=crawler;password=a;";

            //string connStr = "server=208.11.220.249;port=3306;user=suman123456789;database=tgmc11cfb;password='internet';";
            MySqlCommand cmd;
            
            //string sql = "";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            //sql = "insert into result values(@results)";

            cmd = new MySqlCommand(sql + ";SELECT LAST_INSERT_ID()", conn);

            int id = Convert.ToInt32(cmd.ExecuteScalar());
            
           

            
            return (id);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        return 0;
    }
    public MySqlDataReader SelectDataFromDatabase(String sql)
    {
        try
        {

           //string connStr = "server=208.11.220.249;port=3306;user=suman123456789;database=tgmc11cfb;password='internet';";
            string connStr = "server=172.16.58.71;port=3306;user=root;database=crawler;password=a;";

            MySqlCommand cmd;
            MySqlDataReader rdr;
            //string sql = "";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            
            cmd = new MySqlCommand(sql, conn);

            rdr = cmd.ExecuteReader();


            return rdr;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        return null;
    }
    public int UpdateIntoDatabase(String sql)
    {


        try
        {

            //string connStr = "server=208.11.220.249;port=3306;user=suman123456789;database=tgmc11cfb;password=internet;";
            string connStr = "server=172.16.58.71;port=3306;user=root;database=crawler;password=a;";

            MySqlCommand cmd;
            
            //string sql = "";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            //sql = "insert into result values(@results)";

            cmd = new MySqlCommand(sql , conn);

            cmd.ExecuteNonQuery();  




            return 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        return 0;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

class Database
{
    Manager.Home em1 = null;
    
    public Database(Manager.Home em)

    {
        em1 = em;
        // TODO: Complete member initialization
    }
    public Database()
    {
       // em1 = em;
        // TODO: Complete member initialization
    }
    public int InsertIntoDatabase(String sql)
    {
            

        try
        {

            //string connStr = "server=172.16.58.71;port=3306;user=root;database=crawler;password=a;";
            string connStr = "server=208.11.220.249;port=3306;user=suman123456789;database=tgmc11cfb;password=internet;";

            MySqlCommand cmd;
            
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            
            

            cmd = new MySqlCommand(sql + ";SELECT LAST_INSERT_ID()", conn);
            
            int id = Convert.ToInt32(cmd.ExecuteScalar());



            //em1.Status("No Error : Data" + id);
            return (id);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            //em1.Status(ex.ToString());
        }
        return 0;
    }
    public MySqlDataReader SelectDataFromDatabase(String sql)
    {
        try
        {

            //string connStr = "server=172.16.58.71;port=3306;user=root;database=crawler;password=a;";
            string connStr = "server=208.11.220.249;port=3306;user=suman123456789;database=tgmc11cfb;password=internet;";
            MySqlCommand cmd;
            MySqlDataReader rdr;
            
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            
            cmd = new MySqlCommand(sql, conn);

            rdr = cmd.ExecuteReader();


            return rdr;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            //em1.Status(ex.ToString());
        }
        return null;
    }
}
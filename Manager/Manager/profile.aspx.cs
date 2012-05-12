using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace Manager
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            int i=db.InsertIntoDatabase("insert into compileruser(name,username,password) values('"+TextBox1.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"')");
            Session["uesrid"] = i;
            Label1.Text = "Data Inserted Successfully";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            MySqlDataReader i = db.SelectDataFromDatabase("select id from compileruser where username='"+TextBox4.Text+"' and password='"+TextBox5.Text+"'");
            if (i.HasRows)
            {
                if (i.Read())
                {
                    Session["userid"] = i.GetInt32(0);
                    Response.Redirect("compiler.aspx");
                }
                else
                {
                    Label1.Text = "login Unsuccessful";
                }
                
            }
        }
    }
}
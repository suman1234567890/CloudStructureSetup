using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace Manager
{
    public partial class compiler : System.Web.UI.Page
    {
        String type1ip = "127.0.0.1";
        static int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                


                syntax_selection.Items.Clear();
                Button2.Visible = false;
                Database db = new Database();
                MySqlDataReader rdr = db.SelectDataFromDatabase("select name from compilertype");
                if (rdr.HasRows)
                {

                    while (rdr.Read())
                    {
                        //Label6.Text = "Data Result" + rdr.GetString(0);
                        //syntax_selection.Items.Add(rdr.GetString(0));
                        syntax_selection.Items.Add(rdr.GetString(0).ToString());

                    }

                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Label1.Text = textarea1.InnerText +syntax_selection.SelectedIndex.ToString() +syntax_selection.Value.ToString();
            Label1.Text = textarea1.InnerText + syntax_selection.SelectedIndex.ToString() + syntax_selection.SelectedValue.ToString();
            Database db = new Database();
            MySqlDataReader rdr = null;
            rdr = db.SelectDataFromDatabase("select ipaddress from compilertype where name='" + syntax_selection.SelectedValue.ToString() + "'");
            if (rdr.HasRows)
            {

                if (rdr.Read())
                {

                    type1ip = rdr.GetString(0);
                }

            }

            //Label4.Text = "Your chose:" + DropDownList1.SelectedItem.Text + DropDownList1.SelectedIndex.ToString();
            int i = 0;

            i = db.InsertIntoDatabase("insert into crawler(prog,result,operation) values('" + textarea1.InnerText + "','0'," + (syntax_selection.SelectedIndex + 1).ToString() + ")");

            DataSend ds = new DataSend(type1ip, "5212");
            ds.sendData("  " + i.ToString());
            id = i;
            Button2.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            MySqlDataReader rdr = db.SelectDataFromDatabase("select result from crawler where id=" + id);
            Label1.Text = "select result from crawler where id=" + id;
            if (rdr.HasRows)
            {
                if (rdr.Read())
                {
                    textarea2.InnerText = rdr.GetString(0);
                    //Label1.Text = "Data Result" + rdr.GetString(0);

                }
            }
        }
    }
    
}
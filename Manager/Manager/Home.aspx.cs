using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace Manager
{
    public partial class Home : System.Web.UI.Page
    {
        String type1ip = "127.0.0.1";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text == "Sum")
            {
                Label4.Text = "You choose:" + DropDownList1.SelectedItem.Text;
                int i = 0;
                //Database db = new Database();
                //int i=db.InsertIntoDatabase("insert into crawler(value1,value2) values("+TextBox1.Text+","+TextBox2.Text+")");
                
                //Label4.Text ="Not updated"+ i;
                DataSend ds = new DataSend(type1ip, "5212");
                ds.sendData(i.ToString()+"1");
            }
            if (DropDownList1.SelectedItem.Text == "Sub")
            {
                Label4.Text = "You choose:" + DropDownList1.SelectedItem.Text;
            }
            if (DropDownList1.SelectedItem.Text == "Multi")
            {
                Label4.Text = "You choose:" + DropDownList1.SelectedItem.Text;
            }
            if (DropDownList1.SelectedItem.Text == "Div")
            {
                Label4.Text = "You choose:" + DropDownList1.SelectedItem.Text;
            }
        }
    }
}
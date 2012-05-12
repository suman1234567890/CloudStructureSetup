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
        //String type1ip = "172.16.52.126";
        //String type2ip = "172.16.52.126";
        //String type3ip = "172.16.52.126";
        //String type4ip = "172.16.52.126";
        String type1ip = "127.0.0.8";
        //String type2ip = "127.0.0.1";
        //String type3ip = "127.0.0.1";
        //String type4ip = "127.0.0.1";
        
        static int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Button2.Visible = false;
            Database db = new Database(this);
            MySqlDataReader rdr=db.SelectDataFromDatabase("select name from compilertype");
            if (rdr.HasRows)
            {

                while (rdr.Read())
                {
                    //Label6.Text = "Data Result" + rdr.GetString(0);
                    DropDownList1.Items.Add(rdr.GetString(0));
                }
                
            }
        }
        public void Status( String s)
        {
            Label5.Text = s;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Database db = new Database(this);
            MySqlDataReader rdr = null;
            rdr = db.SelectDataFromDatabase("select ipaddress from compilertype where name='" + DropDownList1.SelectedItem.Text + "'");
            if (rdr.HasRows)
            {

                if (rdr.Read())
                {
                    
                    type1ip = rdr.GetString(0);
                }

            }

            Label4.Text = "Your chose:" + DropDownList1.SelectedItem.Text+DropDownList1.SelectedIndex.ToString();
            int i = 0;

            i = db.InsertIntoDatabase("insert into crawler(prog,result,operation) values('" + TextBox1.Text + "','0'," + (DropDownList1.SelectedIndex+1).ToString() + ")");
            
            DataSend ds = new DataSend(type1ip, "5212");
            ds.sendData("  " + i.ToString());
            id = i;
            Button2.Visible = true;
            
            /*
            if (DropDownList1.SelectedItem.Text == "Sum")
            {
                
                rdr = db.SelectDataFromDatabase("select ipaddress from compilertype where name='Sum'");
                if (rdr.HasRows)
                {

                    if (rdr.Read())
                    {
                        //Label6.Text = "Data Result" + rdr.GetString(0);
                        //DropDownList1.Items.Add(rdr.GetString(0));
                        type1ip = rdr.GetString(0);
                    }

                }

                Label4.Text = "You choose:" + DropDownList1.SelectedItem.Text;
                int i = 0;
                
                i = db.InsertIntoDatabase("insert into crawler(prog,result,operation) values('" + TextBox1.Text + "','0',1)");
                Label4.Text = "Not updated" + i;
                DataSend ds = new DataSend(type1ip, "5212");
                ds.sendData("  "+i.ToString());
                id = i;
                Button2.Visible = true;
                
            }
            if (DropDownList1.SelectedItem.Text == "Sub")
            {
                rdr = db.SelectDataFromDatabase("select ipaddress from compilertype where name='Sub'");
                if (rdr.HasRows)
                {

                    if (rdr.Read())
                    {
                        //Label6.Text = "Data Result" + rdr.GetString(0);
                        //DropDownList1.Items.Add(rdr.GetString(0));
                        type2ip = rdr.GetString(0);
                    }

                }
                
                Label4.Text = "You choose:" + DropDownList1.SelectedItem.Text;
                int i = 0;
                db = new Database(this);
                //i = db.InsertIntoDatabase("insert into crawler(value1,value2,result,operation) values(" + TextBox1.Text + "," + TextBox2.Text + ",0,2)");
                i = db.InsertIntoDatabase("insert into crawler(prog,result,operation) values('" + TextBox1.Text + "','0',2)");
                Label4.Text = "Not updated" + i;
                DataSend ds = new DataSend(type2ip, "5212");
                ds.sendData("  " + i.ToString());
                id = i;
                Button2.Visible = true;
            }
            if (DropDownList1.SelectedItem.Text == "Multi")
            {
                rdr = db.SelectDataFromDatabase("select ipaddress from compilertype where name='Multi'");
                if (rdr.HasRows)
                {

                    if (rdr.Read())
                    {
                        //Label6.Text = "Data Result" + rdr.GetString(0);
                        //DropDownList1.Items.Add(rdr.GetString(0));
                        type3ip = rdr.GetString(0);
                    }

                }
                Label4.Text = "You choose:" + DropDownList1.SelectedItem.Text;
                int i = 0;
                db = new Database(this);
                //i = db.InsertIntoDatabase("insert into crawler(value1,value2,result,operation) values(" + TextBox1.Text + "," + TextBox2.Text + ",0,3)");
                i = db.InsertIntoDatabase("insert into crawler(prog,result,operation) values('" + TextBox1.Text + "','0',3)");
                Label4.Text = "Not updated" + i;
                DataSend ds = new DataSend(type3ip, "5212");
                ds.sendData("  " + i.ToString());
                id = i;
                Button2.Visible = true;
            }
            if (DropDownList1.SelectedItem.Text == "Div")
            {
                rdr = db.SelectDataFromDatabase("select ipaddress from compilertype where name='Div'");
                if (rdr.HasRows)
                {

                    if (rdr.Read())
                    {
                        //Label6.Text = "Data Result" + rdr.GetString(0);
                        //DropDownList1.Items.Add(rdr.GetString(0));
                        type4ip = rdr.GetString(0);
                    }

                }
                Label4.Text = "You choose:" + DropDownList1.SelectedItem.Text;
                int i = 0;
                db = new Database(this);
                //i = db.InsertIntoDatabase("insert into crawler(value1,value2,result,operation) values(" + TextBox1.Text + "," + TextBox2.Text + ",0,4)");
                i = db.InsertIntoDatabase("insert into crawler(prog,result,operation) values('" + TextBox1.Text + "','0',4)");
                Label4.Text = "Not updated" + i;
                DataSend ds = new DataSend(type4ip, "5212");
                ds.sendData("  " + i.ToString());
                id = i;
                Button2.Visible = true;
            }*/
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Database db = new Database(this);
            MySqlDataReader rdr=db.SelectDataFromDatabase("select result from crawler where id=" + id);
            Label6.Text = "select result from crawler where id=" + id;
            if (rdr.HasRows)
            {
                if (rdr.Read())
                {
                    Label6.Text = "Data Result"+rdr.GetString(0);

                }
            }
        }
    }
}
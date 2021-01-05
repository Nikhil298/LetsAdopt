using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace LetsAdopt
{
    public partial class UserProfile : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection("server = localhost; Uid = root; password =''; database = letsadopt");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        string gmail;

        string fost;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uid"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            con.Open();
            int n = int.Parse(Session["uid"].ToString());
            string sql2 = "select email from user where uid='" + n + "'";
            MySqlCommand cmd = new MySqlCommand(sql2, con);
            adapter.SelectCommand = new MySqlCommand(sql2, con);
            string mail = cmd.ExecuteScalar().ToString();
            gmail = String.Copy(mail);

            string sql1 = "select * from address where email ='" + mail + "'";
            MySqlCommand cmd1 = new MySqlCommand(sql1, con);
            adapter.SelectCommand = new MySqlCommand(sql1, con);
            adapter.SelectCommand.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();

            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
            cmd1.Dispose();
            con.Close();

            Image1.ImageUrl = "illustrations/address.png";
        }

        protected void update_Click(object sender, EventArgs e)
        {
            if (pno.Text == "" || street.Text == "" || state.Text == "" || city.Text == "" || zip.Text == "" || country.Text == "")
            {
                string msg = "All fields are mandatory.";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);

            }
            else
            {
                if (CheckBox1.Checked == true)
                {
                    fost = "yes";
                }
                else
                {
                    fost = "no";
                }
                con.Open();
                string sql3 = "update address set phone='" + pno.Text + "',lane='" + street.Text + "',city='" + city.Text + "',state='" + state.Text + "',zip='" + zip.Text + "',country='" + country.Text + "',foster='" + fost + "' where email='" + gmail + "'";
                MySqlCommand cmd2 = new MySqlCommand(sql3, con);
                adapter.UpdateCommand = new MySqlCommand(sql3, con);
                adapter.UpdateCommand.ExecuteNonQuery();
                cmd2.Dispose();
                con.Close();

                string sc = "Your address has been updated";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + sc + "');", true);

                pno.Text = "";
                street.Text = "";
                state.Text = "";
                city.Text = "";
                zip.Text = "";
                country.Text = "";
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[1].Text = "E-mail";
                e.Row.Cells[2].Text = "Phone";
                e.Row.Cells[3].Text = "Stret";
                e.Row.Cells[4].Text = "City";
                e.Row.Cells[5].Text = "State";
                e.Row.Cells[6].Text = "Pin";
                e.Row.Cells[7].Text = "Country";
                e.Row.Cells[8].Text = "Fosterer";
                e.Row.Cells[0].Text = "Name";
            }
        }
    }
}
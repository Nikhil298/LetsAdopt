﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;


namespace LetsAdopt
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection("server = localhost; Uid = root; password =''; database = letsadopt");
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["uid"]==null)
            {
                Response.Redirect("Login.aspx");
            }
            if (Page.IsPostBack == false)
            {
                Label mylabelchild = this.Master.MyLabel;
                mylabelchild.Text = Session["name"].ToString();
                int n = int.Parse(Session["uid"].ToString());

                con.Open();


                string sql1 = "select * from post where uid !='" + n + "'";
                MySqlCommand cmd = new MySqlCommand(sql1, con);
                adapter.SelectCommand = new MySqlCommand(sql1, con);
                adapter.SelectCommand.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();

                da.Fill(dt);

                DataList1.DataSource = dt;
                DataList1.DataBind();
                cmd.Dispose();
                con.Close();

            }
        }


        protected void DataList1_ItemCommand1(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "viewdetail")
            {
                 con.Open();
                 string id = e.CommandArgument.ToString();
                 String usrid = Session["uid"].ToString();
                 string sql = "Insert into response(pid,uid) value('" + id + "','" + usrid + "')";
                 MySqlCommand command = new MySqlCommand(sql, con);
                 adapter.InsertCommand = new MySqlCommand(sql, con);
                 adapter.InsertCommand.ExecuteNonQuery();
                 command.Dispose();
                 con.Close();
                
               
            }


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Prog3.App_Code_folder;
using System.Data.SqlClient;
using System.Configuration;

namespace Prog3
{
    public partial class CreateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UWPCS3870ConnectionString1"].ConnectionString);
            conn.Open();
            string insertQuery = "insert into Users(UserName, Password, Email) values (@UID, @UPass, @UEmail)";

            SqlCommand com = new SqlCommand(insertQuery, conn);
            com.Parameters.AddWithValue("@UID", txtUser.Text);
            com.Parameters.AddWithValue("@UPass", txtPassword.Text);
            com.Parameters.AddWithValue("@UEmail", txtEmail.Text);
            com.ExecuteNonQuery();
            Response.Redirect("CreateUser.aspx");

            conn.Close();
        }
    }
}
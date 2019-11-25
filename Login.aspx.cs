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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string Output = "";
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UWPCS3870ConnectionString1"].ConnectionString);
            conn.Open();
            string insertQuery = "Select UserName from Users where UserName = '" + txtUserName.Text + "' and Password = '" + txtPass.Text + "'";

            SqlCommand com = new SqlCommand(insertQuery, conn);

            //com.ExecuteNonQuery();
            SqlDataReader item = com.ExecuteReader();
            while (item.Read())
            {
                Output = item.GetValue(0).ToString();
            }
            conn.Close();
            if (Output == txtUserName.Text)
            {
                Session["Prog5_User"] = txtUserName.Text;
                //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UWPCS3870ConnectionString1"].ConnectionString);
                conn.Open();
                string insertQuery2 = "Delete from ShopingBag where Customer = @keyID";

                SqlCommand com2 = new SqlCommand(insertQuery2, conn);
                com2.Parameters.AddWithValue("@keyID", Session["Prog5_User"]);
                com2.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("Default.aspx");
            }
            else
                Response.Write("invalid login");
                

          
        }
    }
}
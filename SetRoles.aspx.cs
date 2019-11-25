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
    public partial class SetRoles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Output = "";
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UWPCS3870ConnectionString1"].ConnectionString);
            conn.Open();
            string insertQuery = "Select Role from Users where UserName = '" + Session["Prog5_User"] + "'";

            SqlCommand com = new SqlCommand(insertQuery, conn);

            //com.ExecuteNonQuery();
            SqlDataReader item = com.ExecuteReader();
            while (item.Read())
            {
                Output = item.GetValue(0).ToString();
            }
            conn.Close();
            if (!Output.Contains("Admin"))
                Response.Redirect("Default.aspx");
        }
    }
}
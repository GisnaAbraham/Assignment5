using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignment5.Guest
{
    public partial class login : System.Web.UI.Page
    {
        Db db = new Db();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            string sql = "SELECT * FROM login WHERE username='" + uname.Text + "' AND password='" + pswd.Text + "'";
            DataTable dtobj = db.Executedatatable(sql);

            if (dtobj.Rows.Count == 1)
            {

                Session["uid"] = dtobj.Rows[0]["login_id"];
                Session["uname"] = dtobj.Rows[0]["username"].ToString();
                string a = dtobj.Rows[0]["role"].ToString().Trim();

                if (a == "admin")
                {
                    Response.Write("<script>alert('Admin Login ')</script>");
                    Response.Redirect("../admin/confirm.aspx");
                }
                else
                {
                    string c = dtobj.Rows[0]["status"].ToString().Trim();
                    if (c == "Confirm")
                    {
                        Response.Write("<script>alert('Successfully logged in')</script>");
                        Response.Redirect("../employee/details.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Failed to login')</script>");
                        Response.Redirect("../Guest/login.aspx");
                    }
                }
            }
        }

        protected void pswd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
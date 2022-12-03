using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignment5.Guest
{
    public partial class registration : System.Web.UI.Page
    {
        Db db = new Db();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            object ob = db.Executescalar("insert into login values('" + uname.Text + "','" + pswd.Text + "','user','block');select @@IDENTITY");
            db.dbclose();
            if (ob.ToString() != null)
            {
                int i = db.Executenonquery("insert into Employees values('" + name.Text + "','" + mail.Text + "','" + phone.Text + "','" + age.Text + "'," + ob + ")");
                db.dbclose();
                if (i == 1)
                {
                    Response.Write("<script>alert('User Registered Successfully');</script>");
                    Response.Redirect("../guest/login.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Faild');</script>");
                }
            }
        }
    }
}
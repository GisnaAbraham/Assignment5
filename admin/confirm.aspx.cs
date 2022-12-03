
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignment5.admin
{
    public partial class confirm : System.Web.UI.Page
    {
        Db db = new Db();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = db.Executedataset("select * from Employees e inner join login l on e.login_id=l.login_id");
                GridView1.DataBind();

                GridView2.DataSource = db.Executedataset("select * from Employees e inner join login l on e.login_id=l.login_id");
                GridView2.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            db.Executenonquery("update login set status='Confirm' where login_id='" + id + "'");

            GridView1.DataSource = db.Executedataset("select * from Employees e inner join Login l on e.login_id=l.login_id");
            GridView1.DataBind();


        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = GridView2.DataKeys[e.RowIndex].Value.ToString();
            db.Executenonquery("update login set status='Blocked' where login_id='" + id + "'");

            GridView2.DataSource = db.Executedataset("select * from Employees e inner join login l on e.login_id=l.login_id");
            GridView2.DataBind();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace assignment5
{
    public class Db
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();

        public Db()
        {
            con.ConnectionString = "Data Source = NTP-LAP-295\\SQL_SERVER; Initial Catalog = dbase; Integrated Security = True;Pooling = False";
            cmd.Connection = con;
        }



        public SqlConnection Getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void dbclose()
        {
            con.Close();
        }

        public int Executenonquery(String Sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql; //query is sql 
            int i = cmd.ExecuteNonQuery();
            return i;

        }
        public DataSet Executedataset(String sql)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;//pass sql command to command text
            SqlDataAdapter da = new SqlDataAdapter(cmd);//create adapter class because disconnected architecture
            DataSet ds = new DataSet();//create data set
            da.Fill(ds);//fill data to dataset using adapter object
            return ds;//return data set
        }

        public object Executescalar(String sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            object ob = cmd.ExecuteScalar();
            return ob;

        }

        public DataTable Executedatatable(String sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtobj = new DataTable();
            da.Fill(dtobj);
            return dtobj;
        }
        public void fillgrid(String sql, GridView dv)
        {
            dv.DataSource = Executedataset(sql);
            dv.DataBind();
        }

    }
}

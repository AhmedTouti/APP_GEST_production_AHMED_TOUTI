using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace APP_GEST_production_AHMED_TOUTI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Serv1 service = new Serv1();
      
        protected void Page_Load(object sender, EventArgs e)
        {
           
            GridView1.DataSource = service._dt();
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        { 
           
            // Image1.ImageUrl = "data:image/png;base64,"+service.image_url("4")+"";


        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        { int i = e.NewSelectedIndex;
            GridView1.EditIndex = i;
            string dis= ((Label)GridView1.Rows[i].FindControl("Label1")).Text;
            DataTable dta = new DataTable();
            dta = service._dt();
            for (int k = 0; k < dta.Rows.Count; k++)
            { 
                if (dis== dta.Rows[k][1].ToString())
                {
                    //TextBox1.Text = dta.Rows[k][0].ToString();
                     Image1.ImageUrl = "data:image/jpg;base64,"+service.image_url(dta.Rows[k][0].ToString(),"") +"";
                }
            }

        }
    }
}
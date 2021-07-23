using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace APP_GEST_production_AHMED_TOUTI
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection cnx = new SqlConnection("data source =.;initial catalog=gest-prod;integrated security=true");
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        SqlCommand cmd;
        private string ToUp(string str)
        {
            
           return  char.ToUpper( str[0])+str.Substring(1).ToLower();
            

        }
        public void fills()
        {

            da = new SqlDataAdapter("select * from Employes", cnx);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();


        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fills();

            }
            
         
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            cmd = new SqlCommand();
            cnx.Open();
            cmd.CommandText = "delete from Employes where id_employes=@id ";
            cmd.Connection = cnx;
            cmd.Parameters.AddWithValue("@id", ((Label)GridView1.Rows[e.RowIndex].FindControl("Label1")).Text);
            cmd.ExecuteNonQuery();
            cnx.Close();

            fills();
            Response.Write("<script>alert('SUPPRIMER !')</script>");
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int i = e.NewEditIndex;
            GridView1.EditIndex = i;




            fills();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            fills();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
           
            cmd = new SqlCommand();
            cnx.Open();
            int i = e.RowIndex;
            string id = ((Label)GridView1.Rows[i].FindControl("Label1")).Text;
            string name = ((TextBox)GridView1.Rows[i].FindControl("TextBox1")).Text;
            string lastname = ((TextBox)GridView1.Rows[i].FindControl("TextBox2")).Text;
            string datnaiss = ((TextBox)GridView1.Rows[i].FindControl("TextBox3")).Text;
            string adress = ((TextBox)GridView1.Rows[i].FindControl("TextBox4")).Text;
            string email = ((TextBox)GridView1.Rows[i].FindControl("TextBox14")).Text;


            string tel = ((TextBox)GridView1.Rows[i].FindControl("TextBox5")).Text;
            string pass = ((TextBox)GridView1.Rows[i].FindControl("TextBox6")).Text;
          

            if (name!=""&& lastname != "" && email!="" && datnaiss != ""&& adress != "" && pass != ""&& ((DropDownList)GridView1.Rows[i].FindControl("DropDownList1")).SelectedIndex != 0 && tel!="")
            {
                string administartion = ((DropDownList)GridView1.Rows[i].FindControl("DropDownList1")).SelectedValue;



                cmd.Connection = cnx;
            cmd.CommandText = "update Employes set Nom_employes=@nom,Prenom_employes=@first, " +
                "date_naiss_employes=@dtn,Adresse=@add,Tel=@tel,Email=@em,Mot_de_pass=@pass,Admin=@addd where id_employes=@id";



            cmd.Parameters.AddWithValue("@nom",ToUp( name.Trim()));
            cmd.Parameters.AddWithValue("@first", lastname.Trim().ToUpper());
            cmd.Parameters.AddWithValue("@dtn", datnaiss);
            cmd.Parameters.AddWithValue("@add", adress);
            cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@em", email);

                cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@addd", administartion);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            cnx.Close();
            GridView1.EditIndex = -1;
            fills();
            Response.Write("<script>alert('MODIFIER !')</script>");
               
            }
            else
            {
                Response.Write("<script>alert('somting is missing check data !')</script>");

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cnx.Open();
           // int i = e.RowIndex;
            //string id = ((La)GridView1.Rows[i].FindControl("Label1")).Text;
            string name = ((TextBox)GridView1.FooterRow.FindControl("TextBox8")).Text;
            string lastname = ((TextBox)GridView1.FooterRow.FindControl("TextBox13")).Text;
            string datnaiss = ((TextBox)GridView1.FooterRow.FindControl("TextBox9")).Text;
            string adress = ((TextBox)GridView1.FooterRow.FindControl("TextBox10")).Text;
            string email = ((TextBox)GridView1.FooterRow.FindControl("TextBox15")).Text;

            string tel = ((TextBox)GridView1.FooterRow.FindControl("TextBox11")).Text;
            string pass = ((TextBox)GridView1.FooterRow.FindControl("TextBox12")).Text;
            
            if (name != "" && lastname != "" && email!=""&& datnaiss != "" && adress != "" && pass != "" && ((DropDownList)GridView1.FooterRow.FindControl("DropDownList2")).SelectedIndex != 0 && tel != "")
            {
                string administartion = ((DropDownList)GridView1.FooterRow.FindControl("DropDownList2")).SelectedValue;


                cmd.Connection = cnx;
                cmd.CommandText = "insert into Employes values(@nom,@first,@dtn,@add,@tel,@em, @pass,@addd)";
                cmd.Parameters.AddWithValue("@nom",ToUp( name.Trim()));
                cmd.Parameters.AddWithValue("@first", lastname.Trim().ToUpper());
            
                cmd.Parameters.AddWithValue("@dtn", datnaiss);
                cmd.Parameters.AddWithValue("@add", adress);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@em", email);


                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@addd", administartion);

                cmd.ExecuteNonQuery();

                cnx.Close();
                fills();
                Response.Write("<script>alert('bien Ajouter !')</script>");
            }
            else
            {
                Response.Write("<script>alert('somting is missing check data !')</script>");


            }
        }
    }
}
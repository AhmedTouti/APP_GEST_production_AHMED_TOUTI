using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APP_GEST_production_AHMED_TOUTI
{
    public partial class HEADER : System.Web.UI.UserControl
    {
        Serv1 s1 = new Serv1();
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (global.Admin == "2")
            {
                gestEm.Visible = false;
                gestArt.Visible = false;
                txt_serch.Visible = false;
                btn_sub.Visible = false;
               

            }
            else
            {

                gestEm.Visible = true;
                gestArt.Visible = true;
                txt_serch.Visible = true;
                btn_sub.Visible = true;
            }
          

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (txt_serch.Text == "")
            {
                Response.Write("<script>alert('Empty !')</script>");
                GridView1.DataSource = null;
                GridView1.DataBind();


            }
            else
            {
                if (txt_serch.Text== "gestion des emploes" || txt_serch.Text == "gestion des articles" || txt_serch.Text == "liste des articles")
                {
                    if (txt_serch.Text == "gestion des emploes")
                    {
                        Response.Redirect("GEST_EMPLOYES.aspx");
                    }
                    if (txt_serch.Text == "gestion des articles")
                    {
                        Response.Redirect("_Add_art.aspx");
                    }
                    if (txt_serch.Text == "liste des articles")
                    {
                        Response.Redirect("list_art.aspx");
                    }

                }
                else
                {

               
                if (s1.check_name(txt_serch.Text.Trim(), "exist") == 6)
                {
                    GridView1.DataSource = s1.serch(txt_serch.Text.Trim(), "exist", "exist");
                    GridView1.DataBind();

                }
                if (s1.check_name(txt_serch.Text.Trim(), "") == 1)
                {
                    GridView1.DataSource = s1.serch(txt_serch.Text.Trim(), "", "");
                    GridView1.DataBind();

                }
                if (s1.check_name(txt_serch.Text.Trim(), "") == 2)
                {
                    GridView1.DataSource = s1.serch(txt_serch.Text.Trim(), "exist", "");
                    GridView1.DataBind();

                }

                if (s1.check_name(txt_serch.Text.Trim(), "") == 0 && s1.check_name(txt_serch.Text.Trim(), "exist") == 0)
                {
                    Response.Write("<script>alert('Not Exist !')</script>");
                    GridView1.DataSource = null;
                    GridView1.DataBind();

                }

            }
            }
            txt_serch.Text = "";

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
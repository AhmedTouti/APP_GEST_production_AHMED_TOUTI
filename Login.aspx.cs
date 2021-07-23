using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APP_GEST_production_AHMED_TOUTI
{
    public partial class Login : System.Web.UI.Page
    {
        Serv1 serv = new Serv1();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
           

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
         




        }

        protected void ImageButton1_Click(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {

            global.Admin = "";
            if (txtpass.Text == "" && txtnom.Text == "")
            {
                txtnom.Text = "";
                txtpass.Text = "";
                Response.Write("<script>alert('romplie les donner !')</script>");


            }
            else

            {
                if (serv.check(txtnom.Text, txtpass.Text) == 3)
                {
                    global.Admin = "";
                    txtnom.Text = "";
                    txtpass.Text = "";
                    Response.Write("<script>alert('Votre Compt Ne pas a Ete Verifier!!!!')</script>");






                }
                else
                {


                    if (serv.check(txtnom.Text, txtpass.Text) == 2)
                    {
                        string s = "<script>alert('welcom " + txtnom.Text.ToUpper() + " !')</script>";
                        Response.Write(s);
                        global.Admin = "";

                        txtnom.Text = "";
                        txtpass.Text = "";

                        Response.Redirect("list_art.aspx");


                    }
                    else
                    {



                        if (serv.check(txtnom.Text, txtpass.Text) == 1)
                        {

                            string s = "<script>alert('welcom " + txtnom.Text.ToUpper() + " !')</script>";
                            Response.Write(s);
                            global.Admin = "2";
                            txtnom.Text = "";
                            txtpass.Text = "";

                            Response.Redirect("list_art.aspx");



                        }
                        else
                        {
                            txtnom.Text = "";
                            txtpass.Text = "";
                            Response.Write("<script>alert('simting is missing !')</script>");


                        }
                    }
                }
            }
            // global.Admin = "ahmed";

        }

        protected void Btn2_Click(object sender, EventArgs e)
        {
            if (name.Text!=""&& last.Text != "" &&tel.Text != "" &&email.Text != "" &&pass.Text != "" &&conpass.Text != "" &&birth.Text != "" &&adress.Text != ""&&email.Text.Contains("@gmail.com")&& pass.Text.Length==8&&pass.Text==conpass.Text)
            {
                serv.insere(name.Text,last.Text,Convert.ToDateTime(birth.Text),adress.Text,tel.Text,email.Text,pass.Text);
                Response.Write("<script>alert('inscrie !')</script>");
                name.Text = "";
                last.Text = "";
               adress.Text = "";
                birth.Text = "";
                tel.Text = "";
                email.Text = "";
                conpass.Text = "";
                pass.Text = "";


            }
            else
            {
                Response.Write("<script>alert('somting missing !')</script>");
                name.Text = "";
                last.Text = "";
                birth.Text = "";

                adress.Text = "";
                tel.Text = "";
                email.Text = "";
                conpass.Text = "";
                pass.Text = "";

            }
           
        }
    }
}
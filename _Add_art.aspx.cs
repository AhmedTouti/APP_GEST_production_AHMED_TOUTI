using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace APP_GEST_production_AHMED_TOUTI
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Serv1 service = new Serv1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Response.Write("<script>$(document).ready(function () {$('#show').hide(); });</script>");

            }
            {
                // Response.Write("<script>$(document).ready(function () {$('#show').hide(); });</script>");

            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            HttpPostedFile postedFile = FileUpload1.PostedFile;
            




            if (txt_Designation.Text == "" && txt_Prix.Text == "" && txt_qte.Text == "" && postedFile.FileName != "")
                {
                txt_Designation.Text = "tout vide";
                }
                else
                {
                   txt_qte.Text= service.save_art(postedFile, txt_Designation.Text, float.Parse(txt_Prix.Text), int.Parse(txt_qte.Text));
                 Image1.ImageUrl = "data:image/jpg;base64," +service.image_url("",txt_Designation.Text) ;
            }
            
        }
    }
}
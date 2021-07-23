using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using System.IO;


namespace APP_GEST_production_AHMED_TOUTI
{
    /// <summary>
    /// Summary description for Serv1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Serv1 : System.Web.Services.WebService
    {
        //public string Admin = "";
        SqlConnection cnx = new SqlConnection("data source =.;initial catalog=gest-prod;integrated security=true");
       
        [WebMethod]
        public string image_url(string prodact_id,string dis )
        {
            string cmd = "";
            cnx.Open();
            if (dis == "")
            {

               cmd = "select image_Art from article where id_article='" + prodact_id + "'";

            }
            else
            {
                
                 cmd = "select image_Art from article where designation='" + dis + "'";
            }
            SqlCommand cmdd = new SqlCommand(cmd, cnx);
            byte[] bytes=(byte[]) cmdd.ExecuteScalar();
            string img = Convert.ToBase64String(bytes, 0, bytes.Length);
            cnx.Close();
            
            return img;
        }
        private string ToUp(string str)
        {

            return char.ToUpper(str[0]) + str.Substring(1).ToLower();


        }

        [WebMethod]
        public DataTable serch( string sh,string check,string article)
        {
           
            SqlDataAdapter da;
            if (article == "")
            {

            
            if (check=="")
            {

            
             da = new SqlDataAdapter(" select * from Employes where Nom_employes='"+sh+"'", cnx);
            }
            else
            {
                da = new SqlDataAdapter(" select * from Employes where Prenom_employes='" + sh+"'", cnx);


            }
            }
            else
            {
                da = new SqlDataAdapter(" select designation,prix,contity_stock from article where designation='" + sh + "'", cnx);

            }



            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        [WebMethod]
        public DataTable _dt()
        {
            SqlDataAdapter da = new SqlDataAdapter(" select id_article, designation,prix,contity_stock from Article", cnx);
                
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        [WebMethod]
        public string save_art( HttpPostedFile photo,string dis,float prix,int qte)
        {
            cnx.Open();
          
            string filename = Path.GetFileName(photo.FileName);
            string fileEx = Path.GetExtension(filename);
            
            
           // int filesize = photo.ContentLength;
            if (fileEx.ToLower() == ".jpg" || fileEx.ToLower() == ".gif"|| fileEx.ToLower() == ".png" || fileEx.ToLower() == ".bmp")
            {
                
                 Stream st = photo.InputStream;
                BinaryReader br = new BinaryReader(st);
                Byte[] bytes = br.ReadBytes((int)st.Length);
               // string cmd = "insert into article values('"+dis +"','"+ prix+"','"+qte +"',convert(varbinary(max),'"+ bytes+"'))";
                //string cmd = "Insert Into Article(designation,prix ,contity_stock,image_Art)Select '" + dis + "','" + prix + "','" + qte + "', BulkColumn from Openrowset(Bulk '"+ Path.GetFullPath(photo.FileName) + "', Single_Blob) as Image";

                SqlCommand cmdd = new SqlCommand("upload", cnx);
                cmdd.CommandType = CommandType.StoredProcedure;
                SqlParameter pram1 = new SqlParameter()
                { ParameterName = "@des",
                    Value = dis

                };
                cmdd.Parameters.Add(pram1);

               
                cmdd.CommandType = CommandType.StoredProcedure;
                SqlParameter pram2 = new SqlParameter()
                {
                    ParameterName = "@prix",
                    Value = prix

                };
                cmdd.Parameters.Add(pram2);

                
                cmdd.CommandType = CommandType.StoredProcedure;
                SqlParameter pram3 = new SqlParameter()
                {
                    ParameterName = "@contiter",
                    Value = qte

                };
                cmdd.Parameters.Add(pram3);

                cmdd.CommandType = CommandType.StoredProcedure;
                SqlParameter pram4 = new SqlParameter()
                {
                    ParameterName = "@data",
                    Value = bytes

                };
                cmdd.Parameters.Add(pram4);


                // cmdd.Parameters.AddWithValue("@but", bytes);
                cmdd.ExecuteNonQuery();
                cnx.Close();
                return "secces";
            }
            else
            {
                return "somating messing!";


            }


               
        }
        [WebMethod]
        public int check( string name,string pass)
        {
            int cont = 0;
            cnx.Open();

            SqlCommand cmd = new SqlCommand("select * from Employes", cnx);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
            if (dr[1].ToString().Trim()==name&&dr[7].ToString().Trim()==pass)
            {
                    if (dr[8].ToString().Trim() == "yes")
                    {
                        cont++;

                    }
                   
                    if (dr[8].ToString().Trim() == "")
                    {
                        cont++;
                        cont++;



                    }



                    cont++;
                    break;
            }
          
            }
            dr.Close();
            cnx.Close();
            return cont;


        }
        [WebMethod]

        public int check_name(string name,string check)
        {
            int cont = 0;
            int x = 0;
            cnx.Open();
            SqlCommand cmd;
            if (check == "")
            {


                 cmd = new SqlCommand("select * from Employes", cnx);

            }
            else
            {
                 cmd = new SqlCommand("select * from article", cnx);
                x = 2;
            }
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                    if ( dr[1].ToString().Trim() == ToUp(name))
                    {
                        cont=1;
                    break;

                    }
                if (dr[2].ToString().Trim() == name.ToUpper())
                {
                    cont=2;
                    break;
                  

                }
                if (dr[1].ToString().Trim()==name&&x==2)
                {
                    cont = 6;
                    break;

                }



                    
                

            }
            dr.Close();
            cnx.Close();
            return cont;


        }
        [WebMethod]
        public void insere(string name, string last, DateTime dat, string adress, string tel, string email, string pass)
        {
           
            cnx.Open();

            SqlCommand cmd = new SqlCommand("insere", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] pr = new SqlParameter[7];
            pr[0] = new SqlParameter("@name",SqlDbType.VarChar,50);
            pr[0].Value = name;
            pr[1] = new SqlParameter("@last", SqlDbType.VarChar, 50);
            pr[1].Value = last;
            pr[2] = new SqlParameter("@date",SqlDbType.DateTime);
            pr[2].Value =dat;
            pr[3] = new SqlParameter("@adress", SqlDbType.VarChar, 100);
            pr[3].Value = adress;
            pr[4] = new SqlParameter("@tel",SqlDbType.Int);
            pr[4].Value = int.Parse(tel);
            pr[5] = new SqlParameter("@email", SqlDbType.VarChar, 100);
            pr[5].Value =email;
            pr[6] = new SqlParameter("@pass",SqlDbType.Char,8);
            pr[6].Value =int.Parse(pass);
            cmd.Parameters.AddRange(pr);
            cmd.ExecuteNonQuery();
            cnx.Close();
        




        }


    }
}

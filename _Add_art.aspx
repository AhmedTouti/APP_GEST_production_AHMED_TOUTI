<%@ Page Title="" Language="C#" MasterPageFile="~/Master_MAIN.Master" AutoEventWireup="true" CodeBehind="_Add_art.aspx.cs" Inherits="APP_GEST_production_AHMED_TOUTI.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="insert.css">
    		<script  src="jquery-3.4.1.min.js"></script>
     
    <script>
        $(document).ready(function () {
            $("#show").hide();
        });
      
        $(document).ready(function() {

            $(".btn_choisie").hover(function (e) {
            $("#show").slideDown("slow");

            });
            $(".btn_valider").hover(function (e) {
                $("#show").slideUp("slow");

            });


        //    $(".btn_choisie").click(function() {
        //        $("#show").slideDown();
        //    });
        });

    </script>
    
    


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1 class="h11">Adding Article</h1>
        <center>
            <div class="addcontent" id="valider">
                
                 <asp:TextBox ID="txt_Designation" runat="server" CssClass="input_content" placeholder="Designation.."  Font-Bold="True"></asp:TextBox>
                
                <br>
                <hr>
                
                 <asp:TextBox ID="txt_Prix" runat="server" CssClass="input_content" placeholder="Prix.."  Font-Bold="True"></asp:TextBox>

                
                <br>
                <hr>
            
                 <asp:TextBox ID="txt_qte" runat="server" CssClass="input_content" placeholder="contiter-stock.."  Font-Bold="True"></asp:TextBox>
                
                <br>
                <hr>
                <asp:ImageButton ID="btn_choisie" runat="server"  CssClass="btn_choisie" ImageUrl="chisie.png" ImageAlign="NotSet" />
               <%-- <input type="image" src="chisie.png" alt="Submit" class="btn_choisie" placeholder="choisie">--%>
                <asp:ImageButton ID="btn_valider" runat="server" OnClick="ImageButton1_Click" CssClass="btn_valider" ImageUrl="valider.png" ImageAlign="NotSet" />

                <%--<input type="image" src="valider.png" alt="Submit" class="btn_valider" placeholder="valider">--%><br>
                <div id="show">
                    <center>
                        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="fileup" />
                    </center>
                </div>
                 
        </center>
        
    <asp:Image ID="Image1" runat="server"  CssClass="img_holder"/>



        </div>

</asp:Content>

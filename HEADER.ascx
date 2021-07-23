<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HEADER.ascx.cs" Inherits="APP_GEST_production_AHMED_TOUTI.HEADER" %>
<link rel="stylesheet" href="master.css">

    <div class="header">
        <img src="logoleft.png" alt="logo" class="logo">
            <asp:TextBox ID="txt_serch" runat="server" CssClass="input" Font-Bold="True" placeholder="Search.."></asp:TextBox>
         <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 186px; top: 128px; position: absolute; height: 34px; width: 468px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
         <asp:ImageButton ID="btn_sub" runat="server" OnClick="ImageButton1_Click" CssClass="btn" ImageUrl="serch.png" ImageAlign="NotSet" />   
    <asp:HyperLink ID="gestEm" runat="server" CssClass="a" NavigateUrl="GEST_EMPLOYES.aspx"><b>Gestion des Emploés</b></asp:HyperLink>     
    <asp:HyperLink ID="gestArt" runat="server" CssClass="a" NavigateUrl="_Add_art.aspx"><b>Gestion des Articles</b></asp:HyperLink>      
    <asp:HyperLink ID="List" runat="server" CssClass="a" NavigateUrl="list_art.aspx"><b>Liste Des Articles</b></asp:HyperLink>
    <asp:HyperLink ID="logout" runat="server" CssClass="a" NavigateUrl="Login.aspx"><b>LOGOUT</b></asp:HyperLink>



    </div>
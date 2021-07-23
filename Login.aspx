<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="APP_GEST_production_AHMED_TOUTI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>HOME</title>
    <link rel="stylesheet" href="css.css">
</head>
<body>
    <form id="form1" runat="server">
          <div class="hero">
        <div class="form-box">
            <div class="button-box">
                <div id="btn"></div>
                <button type="button" class="btn-re-log" onclick="login()">login</button>
                <button type="button" class="btn-re-log" onclick="register()">Register</button>
            </div>
            <div id="login" class="data">
                <center>
                    <img src="logo.png" alt="logo" class="logo">
                </center>
                 <asp:TextBox ID="txtnom" runat="server" CssClass="text" placeholder="Name.." Font-Bold="True"></asp:TextBox>
                 <asp:TextBox ID="txtpass" runat="server" CssClass="text" Font-Bold="True" type="password" placeholder="pass-word.."></asp:TextBox>
                <input type="checkbox" class="check"><span>Remember Me</span>
             
                 <asp:Button ID="btn1" runat="server" Text="login"  CssClass="sbmit" OnClick="btn1_Click" />

               
            </div>
            <div id="registr" class="data1">
                <asp:TextBox ID="name" runat="server" CssClass="text1" placeholder="Name.." Font-Bold="True" ></asp:TextBox>
                 <asp:TextBox ID="last" runat="server" CssClass="text1" Font-Bold="True"  placeholder="Last-Name.."></asp:TextBox>

                 <asp:TextBox ID="birth" runat="server" CssClass="text1" Font-Bold="True"  placeholder="Birth-Date.."></asp:TextBox>
                 <asp:TextBox ID="adress" runat="server" CssClass="text1" Font-Bold="True"  placeholder="Adresse.."></asp:TextBox>
                 <asp:TextBox ID="tel" runat="server" CssClass="text1" Font-Bold="True"  placeholder="Tel.."></asp:TextBox>
                 <asp:TextBox ID="email" runat="server"  CssClass="text1" Font-Bold="True"  placeholder="Email.."></asp:TextBox>
                 <asp:TextBox ID="pass" runat="server"  CssClass="text1" Font-Bold="True" type="password"  placeholder="Pass-word.."></asp:TextBox>
                 <asp:TextBox ID="conpass" runat="server"  CssClass="text1" Font-Bold="True" type="password"  placeholder="Confirm-Pass-Word.."></asp:TextBox>
                <input type="checkbox" class="check"><span>i agree</span>
                 <asp:Button ID="Btn2" runat="server" Text="Register" CssClass="sbmit1" OnClick="Btn2_Click"  />
        <%--        <button type="button" class="sbmit1">Register</button>--%>
            </div>
        </div>
    </div>
    <script>
        var x = document.getElementById("login");
        var y = document.getElementById("registr");
        var z = document.getElementById("btn");

        function register() {
            x.style.left = "-400px";
            y.style.left = "50px";
            z.style.left = "110px";

        }

        function login() {
            x.style.left = "50px";
            y.style.left = "450px";
            z.style.left = "0px";

        }
    </script>    
    </form>
</body>
</html>

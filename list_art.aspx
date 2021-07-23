<%@ Page Title="" Language="C#" MasterPageFile="~/Master_MAIN.Master" AutoEventWireup="true" CodeBehind="list_art.aspx.cs" Inherits="APP_GEST_production_AHMED_TOUTI.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" href="master.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="h11">List Des Articles</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" style="z-index: 1; left: 89px; top: 294px; position: absolute; height: 114px; width: 323px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:TemplateField HeaderText="Nom Article">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# bind("designation") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Prix">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# bind("prix") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>
    <asp:Image ID="Image1" runat="server" style="z-index: 1; border-style:none; left: 453px; top: 250px; position: absolute" Width="200px" Height="200px" />
</asp:Content>

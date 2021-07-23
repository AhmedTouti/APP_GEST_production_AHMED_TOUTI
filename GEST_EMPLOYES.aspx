<%@ Page Title="" Language="C#" MasterPageFile="~/Master_MAIN.Master" AutoEventWireup="true" CodeBehind="GEST_EMPLOYES.aspx.cs" Inherits="APP_GEST_production_AHMED_TOUTI.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="master.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <center>
      <h1 class="h11">Ajouter un Employer</h1>
    <div class="grid">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" ShowFooter="True" >
        <Columns >
            <asp:CommandField HeaderText="MODIFICATION" ShowEditButton="True" />
            <asp:TemplateField HeaderText="ID" >
                <FooterTemplate>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="AJOUTER" Width="65px" />
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# bind("id_employes") %>' Width="20px"></asp:Label>
                </ItemTemplate>
<HeaderStyle Width="30"/>
<ItemStyle Width="30"  />
<FooterStyle Width="30"/>
                 
            </asp:TemplateField>
            <asp:TemplateField HeaderText="NOM" FooterStyle-CssClass="col" ItemStyle-CssClass="col" HeaderStyle-CssClass="col">
               <HeaderStyle Width="30"/>
<ItemStyle Width="30"  />
<FooterStyle Width="30"/>
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# bind("Nom_employes") %>' Width="70px"></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBox8" runat="server" Width="70px"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label  ID="Label2" runat="server" Text='<%# bind("Nom_employes") %>' CssClass="col" Width="70px"></asp:Label>
                </ItemTemplate>





            </asp:TemplateField>
            <asp:TemplateField HeaderText="PRENOM">
                        <HeaderStyle Width="30"/>
<ItemStyle Width="30"  />
<FooterStyle Width="30"/>
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# bind("Prenom_employes") %>' Width="70px"></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBox13" runat="server" Width="70px"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# bind("Prenom_employes") %>' Width="70px"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="DATE DE NAISS">
                        <HeaderStyle Width="30"/>
<ItemStyle Width="30"  />
<FooterStyle Width="30"/>
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# bind("date_naiss_employes") %>' Width="100px"></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBox9" runat="server" Width="100px"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# bind("date_naiss_employes") %>' Width="100px"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ADRESSE">
                        <HeaderStyle Width="30"/>
<ItemStyle Width="30"  />
<FooterStyle Width="30"/>
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# bind("Adresse") %>' Width="110px"></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBox10" runat="server" Width="110px"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# bind("Adresse") %>' Width="110px"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="TEL">
                        <HeaderStyle Width="30"/>
<ItemStyle Width="30"  />
<FooterStyle Width="30"/>
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox5" runat="server" Text='<%# bind("Tel") %>' Width="70px"></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBox11" runat="server" Width="70px"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# bind("Tel") %>' Width="70px"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Email">
                        <HeaderStyle Width="100"/>
<ItemStyle Width="100"  />
<FooterStyle Width="100"/>
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox14" runat="server" Text='<%# bind("Email") %>' Width="110px"></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBox15" runat="server" Width="110px"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label9" runat="server" Text='<%# bind("Email") %>' Width="110px"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="MOT DE PASS">
                        <HeaderStyle Width="30"/>
<ItemStyle Width="30"  />
<FooterStyle Width="30"/>
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox6" runat="server" Text='<%# bind("Mot_de_pass") %>' Width="70px"></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBox12" runat="server" Width="70px"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# bind("Mot_de_pass") %>' Width="70px"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Administartion">
                        <HeaderStyle Width="30"/>
<ItemStyle Width="30"  />
<FooterStyle Width="30"/>
                <EditItemTemplate>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="45px">
                        <asp:ListItem> </asp:ListItem>
                        <asp:ListItem>yes</asp:ListItem>
                        <asp:ListItem>no</asp:ListItem>
                    </asp:DropDownList>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:DropDownList ID="DropDownList2" runat="server" Width="45px">
                        <asp:ListItem> </asp:ListItem>
                        <asp:ListItem>yes</asp:ListItem>
                        <asp:ListItem>no</asp:ListItem>
                    </asp:DropDownList>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label8" runat="server" Text='<%# bind("Admin") %>' Width="30px"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField HeaderText="DELETING" ShowDeleteButton="True" />

        </Columns>
        <FooterStyle BackColor="#C6C3C6" ForeColor="Black"  />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF"  />
        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right"  />
        <RowStyle BackColor="#DEDFDE" ForeColor="Black"  />
        <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1"  />
        <SortedAscendingHeaderStyle BackColor="#594B9C" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#33276A" />
    </asp:GridView>
        </div>
      </center>
</asp:Content>

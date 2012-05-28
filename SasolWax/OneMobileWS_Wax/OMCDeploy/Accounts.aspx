<%@ Page Language="C#" MasterPageFile="~/OMC.Master" AutoEventWireup="true" CodeBehind="Accounts.aspx.cs" Inherits="Sasol_WaxOMC.Accounts" Title="User Accounts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">

<div style="width: 842px; height: 606px;">
        <div style="height: 67px">
            <h1 style="color:Black; text-decoration:underline ">
               User Details 
            </h1>
        </div>
        
        <div>
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
                BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                DataSourceID="Sql_Server_Accounts" GridLines="Vertical" 
                style="margin-left: 32px" Width="617px">
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <Columns>
                    <asp:BoundField DataField="sUser" HeaderText="sUser" SortExpression="sUser" />
                    <asp:BoundField DataField="sName" HeaderText="sName" SortExpression="sName" />
                    <asp:BoundField DataField="sSurname" HeaderText="sSurname" 
                        SortExpression="sSurname" />
                    <asp:BoundField DataField="sPassExpire" HeaderText="sPassExpire" 
                        SortExpression="sPassExpire" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle BackColor="#DCDCDC" />
            </asp:GridView>
            <asp:SqlDataSource ID="Sql_Server_Accounts" runat="server" 
                ConnectionString="<%$ ConnectionStrings:OneMobileConnectionString %>" 
                SelectCommand="SELECT [sUser], [sName], [sSurname], [sPassExpire] FROM [Users] ORDER BY [sSurname]">
            </asp:SqlDataSource>
        </div>
        <div>
        </div>
        <div>
        </div>
        <div style="margin-top:30px">
            <asp:Button ID="btnNewAccount" runat="server" onclick="btnNewAccount_Click" 
                style="margin-left: 38px" Text="New Account" Width="221px" />
            <asp:Button ID="btnreset" runat="server" onclick="Button1_Click" 
                style="margin-left: 108px" Text="Reset Password" Width="218px" />
        </div>
        
            
        
    </div>
</asp:Content>

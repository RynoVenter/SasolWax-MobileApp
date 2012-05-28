<%@ Page Language="C#" MasterPageFile="~/OMC.Master" AutoEventWireup="true" CodeBehind="StockTake.aspx.cs" Inherits="Sasol_WaxOMC.StockTake" Title="Stock Take Preperation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div>
        <div>
            <h1 style="color:Black; text-decoration:underline ">
            Stock Take Activity
            </h1>
        </div>
        
        <div>
            <asp:Label ID="lblbParam" runat="server" Text="1" Visible="False"></asp:Label>
        </div>
        
         <div style="width: 242px; margin-left: 18px">
        
            <asp:Button ID="cmdActivity" runat="server" onclick="cmdActivity_Click" 
                Text="Register New Activity" />
        
        </div>
        
        <div>
            <h3 style="color:Black">
                Current
                Activities
            </h3>
        </div>
        
        
        <div style="width: 242px; margin-left: 18px">
        
            <asp:GridView ID="GridView1" runat="server" 
                BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" DataSourceID="SQL_Server" GridLines="Vertical" 
                AllowPaging="True" AutoGenerateColumns="False">
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <Columns>
                    <asp:BoundField DataField="sTeamName" HeaderText="sTeamName" 
                        SortExpression="sTeamName" />
                    <asp:BoundField DataField="sDescription" HeaderText="sDescription" 
                        SortExpression="sDescription" />
                    <asp:BoundField DataField="sArea" HeaderText="sArea" 
                        SortExpression="sArea" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle BackColor="#DCDCDC" />
            </asp:GridView>
            <asp:SqlDataSource ID="SQL_Server" runat="server" 
                ConnectionString="<%$ ConnectionStrings:OneMobileConnectionString %>" 
                SelectCommand="SELECT [sDescription], [sArea], [sTeamName] FROM [Version] WHERE [bActive] = '1'">
            </asp:SqlDataSource>
        
        </div>
        <div>
        </div>
        
        
    </div>
</asp:Content>

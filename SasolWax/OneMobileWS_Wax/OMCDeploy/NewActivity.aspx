<%@ Page Language="C#" MasterPageFile="~/OMC.Master" AutoEventWireup="true" CodeBehind="NewActivity.aspx.cs" Inherits="Sasol_WaxOMC.NewActivity" Title="New Activity" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div style="height: 507px">
            <div>
                <h3 style="color:Black">
                    Area :
                </h3>
                    
            </div>
            
            <div>
            
            </div>
                   
            <div style="width: 242px; margin-left: 18px">
                <asp:DropDownList ID="Area" runat="server" DataSourceID="SQL_Server" 
                    DataTextField="sArea" DataValueField="sArea">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SQL_Server" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:OneMobileConnectionString %>" 
                    SelectCommand="SELECT [sArea] FROM [Area]"></asp:SqlDataSource>
            </div>
            
            <div>
            
            <div style="width: 242px; margin-left: 18px">
            </div>
             <div>
                <h3 style="color:Black">
                    Description :
                </h3>
                    
            </div>
            
            <div>
            
            </div>
                   
            <div style="width: 242px; margin-left: 18px">
                <asp:TextBox ID="Description" runat="server" Width="412px"></asp:TextBox>
            </div>
            <div>
            </div>
            <div style="width: 562px; margin-left: 18px">
                <asp:Button ID="cmdNew" runat="server" Text="Save New Activity" 
                    onclick="cmdNew_Click" />
                <asp:Button ID="btnBack" runat="server" onclick="btnBack_Click" 
                    style="margin-left: 71px" Text="Back" Width="185px" />
            </div>
           
            <div>
            </div>
            <div style="margin-left:18px">
            
                <asp:Label ID="lblPageMessage" runat="server" Font-Bold="True" 
                    Font-Size="Large" ForeColor="Maroon" Text="Successful" Visible="False" ></asp:Label>
            
            </div>
     </div>
        
</asp:Content>

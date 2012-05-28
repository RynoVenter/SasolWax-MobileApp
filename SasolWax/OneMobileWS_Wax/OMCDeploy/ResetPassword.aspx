<%@ Page Language="C#" MasterPageFile="~/OMC.Master" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="Sasol_WaxOMC.ResetPassword" Title="Reset Password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div style="height: 435px">
    
     <div style="height: 67px">
            <h1 style="color:Black; text-decoration:underline ">
               User Details 
            </h1>
        </div>
            
        <div>
            <h3>
                Username :
            </h3> 
            <div style="width: 242px; margin-left: 18px">
                <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
            </div>
        </div>
        
        <div>
            <h3>
                New
                Password :
            </h3>
            <div style="width: 242px; margin-left: 18px">
                <asp:TextBox ID="Password" runat="server" TextMode="Password" Wrap="False"></asp:TextBox>
            </div>
        </div>                              
        <div style="height: 59px">
        
            <div style="margin-left: 18px; margin-top: 18px;">
                <asp:Button ID="UserReset" runat="server" Font-Bold="True" 
                    Text="Reset Password" Width="242px" onclick="UserReset_Click"/>
                <asp:Button ID="btnBack" runat="server" onclick="btnBack_Click" 
                    style="margin-left: 73px" Text="Back" Width="242px" />
            </div>
            
        </div>
        
        <div style="margin-left:18px">
            <asp:Label ID="lblPageMessage" runat="server" Font-Bold="True" 
                Font-Size="Medium" ForeColor="Maroon" Text="Success" Visible="False"></asp:Label>
        </div>
    </div>
</asp:Content>

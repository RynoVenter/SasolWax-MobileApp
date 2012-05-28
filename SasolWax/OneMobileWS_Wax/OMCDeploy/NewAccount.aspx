<%@ Page Language="C#" MasterPageFile="~/OMC.Master" AutoEventWireup="true" CodeBehind="NewAccount.aspx.cs" Inherits="Sasol_WaxOMC.NewAccount" Title="New Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div style="width: 842px; height: 606px;">
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
                Name :
            </h3> 
            <div style="width: 242px; margin-left: 18px">
                <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
            </div>
        </div>
        
        <div>
            <h3>
                Surname :
            </h3> 
            <div style="width: 242px; margin-left: 18px">
                <asp:TextBox ID="Surname" runat="server"></asp:TextBox>
            </div>
            
            <div style="margin-left: 18px; margin-top: 18px;">
                <asp:Button ID="NewUser" runat="server" Font-Bold="True" onclick="NewUser_Click" 
                    Text="Save New User" Width="242px" />
                <asp:Button ID="btnBack" runat="server" onclick="btnBack_Click" 
                    style="margin-left: 45px" Text="Back" Width="223px" />
             </div>
        </div>
                                    
        <div style="height: 59px">
            <div style="margin-left:18px">
            
                <asp:Label ID="lblPageMessage" runat="server" Font-Bold="True" 
                    Font-Size="Medium" ForeColor="Maroon" Text="Success" Visible="False"></asp:Label>
            
            </div>
            
        </div>
    </div>
</asp:Content>

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
                                </div>
                                
                                <div style="height: 14px">
                                </div>
                                
                                <div style="height: 67px">
                                    <h1 style="color:Black; text-decoration:underline ">
                                       Reset Password 
                                    </h1>
                                </div>
                                
                                <div>
                                    <h3>
                                        Reset
                                        Password :
                                    </h3>
                                    <div style="width: 242px; margin-left: 18px">
                                        <asp:TextBox ID="Password" runat="server" TextMode="Password" Wrap="False"></asp:TextBox>
                                    </div>
                                </div>                              
                                <div style="height: 59px">
                                
                                    <div style="margin-left: 18px; margin-top: 18px;">
                                        <asp:Button ID="NewUser" runat="server" Font-Bold="True" onclick="Logon_Click" 
                                            Text="New User" Width="242px" />
                                        <asp:Button ID="UserReset" runat="server" Font-Bold="True" 
                                            Text="Reset Password" Width="242px" style="margin-left: 45px"/>
                                    </div>
                                    
                                </div>
                            </div>
</asp:Content>

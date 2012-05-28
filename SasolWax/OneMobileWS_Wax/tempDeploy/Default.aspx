<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Sasol_WaxOMC.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Sasol Wax</title>
    <link href="CSS/Site.css" rel="Stylesheet" type="text/css" />
</head>
<body>
<form id="Default" runat="server">
<div>
            <div class="page">
                <div class="header">
                    <div class="title">
                       <h1>
                            Sasol Wax
                       </h1>
                       <h2>
                            Back Office
                       </h2>
                       <div class="topseperator">
                          
                       </div>
                    </div>
                </div>
                <div class="menu">
                </div>
                <div class="pagecontent">
                    <div class="contentheader">
                        <div class="contentbody">
                             
                            <div style="width: 842px; height: 394px;">
                                <div style="height: 46px">
                                </div>
                                    
                                <div>
                                    <h3>
                                        Username :
                                    </h3> 
                                    <div style="width: 242px; margin-left: 18px">
                                        <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                
                                <div style="height: 33px">
                                </div>
                                
                                <div>
                                    <h3>
                                        Password :
                                    </h3>
                                    <div style="width: 242px; margin-left: 18px">
                                        <asp:TextBox ID="Password" runat="server" TextMode="Password" Wrap="False"></asp:TextBox>
                                    </div>
                                </div>                              
                                <div style="height: 65px">
                                
                                    <div style="margin-left: 18px; margin-top: 18px;">
                                        <asp:Button ID="Logon" runat="server" Font-Bold="True" onclick="Logon_Click" 
                                            Text="Logon" Width="242px" />
                                    </div>
                                    
                                </div>
                            </div>
                        </div>
                        <div class="bottomseperator">
                        </div>
                    </div>
                </div>
                <div class="footer">
                    <h4>
                        Copyright © 2012 Britehouse Specialist SAP Division
                    </h4>
                </div>
            </div>
    </div>
    </form>
</body>
</html>

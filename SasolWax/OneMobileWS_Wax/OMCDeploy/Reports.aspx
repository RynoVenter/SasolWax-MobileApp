<%@ Page Language="C#" MasterPageFile="~/OMC.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="Sasol_WaxOMC.Reports" Title="Stock Take Reports" EnableViewState="True" EnableSessionState="True" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div>

</div>
    <div >
        <div>
        </div>
        
        <div>
            <h2 style ="color:Black ; font-size:medium; font-weight:bold">
                Reports</h2>
            <div>
            
                <asp:DropDownList ID="cmbReports" runat="server" style="margin-left: 25px" 
                    Width="403px" DataSourceID="SQL_Server_Reports" 
                    DataTextField="sReportName" DataValueField="sReportName" 
                    onselectedindexchanged="cmbReports_SelectedIndexChanged" 
                    ontextchanged="cmbReports_TextChanged">
                </asp:DropDownList>
            
                <asp:SqlDataSource ID="SQL_Server_Reports" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:OneMobileConnectionString %>" 
                    SelectCommand="SELECT [sReportName] FROM [Wax_Reports] ORDER BY [iPosition]">
                </asp:SqlDataSource>
            
            </div>
        </div>
        
        <div>
        </div>
        
        <div>
        <h2 style ="color:Black ; font-size:medium; font-weight:bold">
            Area
        </h2>
        </div>
        
        <div>
        
            <asp:DropDownList ID="cmbArea" runat="server" 
                DataSourceID="SQL_Server_Area" DataTextField="sArea" DataValueField="sArea" 
                style="margin-left: 18px" Width="247px" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SQL_Server_Area" runat="server" 
                ConnectionString="<%$ ConnectionStrings:OneMobileConnectionString %>" 
                SelectCommand="SELECT [sArea] FROM [Area]"></asp:SqlDataSource>
        
        </div>
        <div>
        <div>
            
            &nbsp;&nbsp;&nbsp;
            
        </div>
        </div>
        <div>
        <asp:Button ID="btnSearch" runat="server" style="margin-left: 18px" 
                Text="Search" Width="231px" onclick="btnSearch_Click" />
            <asp:Label ID="lblPageMessage" runat="server" Font-Bold="True" 
                Font-Size="Medium" ForeColor="Maroon" Visible="False"></asp:Label>
        </div>
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        
        <div>
            &nbsp;&nbsp;&nbsp;
        </div>
        <div>
            <asp:Button ID="btnMCorrection" runat="server" Font-Bold="True" 
        onclick="btnMCorrection_Click" style="margin-left: 41px" 
        Text="Manual Correction" Width="187px" />
        </div>
    </div>
    <asp:GridView ID="GridViewReports" runat="server" style="margin-left: 29px; margin-top: 0px;" 
        Height="422px" Width="1290px" PageSize="20" 
        onselectedindexchanged="GridViewReports_SelectedIndexChanged" 
        ForeColor="Black">
        <PagerStyle Wrap="False" />
        <HeaderStyle BackColor="#7EA9D3" Font-Bold="True" ForeColor="White" />
        <EditRowStyle HorizontalAlign="Left" Wrap="False" />
        <AlternatingRowStyle BackColor="#CFDFEF" BorderStyle="None" ForeColor="Black" />
    </asp:GridView>
    <asp:Label ID="lblViewName" runat="server"></asp:Label>
    <asp:SqlDataSource ID="SQL_Server" runat="server" 
        ConnectionString="<%$ ConnectionStrings:OneMobileConnectionString %>" 
        
        SelectCommand="SELECT * FROM [WAX_CountedMaterials_SysProVSInventCountVariance]">
    </asp:SqlDataSource>
</asp:Content>

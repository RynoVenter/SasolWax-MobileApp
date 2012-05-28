<%@ Page Language="C#" MasterPageFile="~/OMC.Master" AutoEventWireup="true" CodeBehind="ManualCorrection.aspx.cs" Inherits="Sasol_WaxOMC.ManualCorrection" Title="Manual Correction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div style="height: 801px">
        <div>
        </div>
        
        <div>
            <h2 style ="color:Black ; font-size:medium; font-weight:bold">
                Warehouse</h2>
            <div>
                <asp:DropDownList ID="cmbArea" runat="server" 
                    DataSourceID="SQL_Server_Area" DataTextField="sWarehouseCode" DataValueField="sWarehouseCode" 
                    style="margin-left: 18px" Width="247px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SQL_Server_Area" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:OneMobileConnectionString %>" 
                    SelectCommand="SELECT DISTINCT [sWarehouseCode] FROM [Warehouse]"></asp:SqlDataSource>
            </div>
        </div>
        
        <div>
        </div>
        
        <div>
        <h2 style ="color:Black ; font-size:medium; font-weight:bold">
            Serial Code
        </h2>
        </div>
        
        <div>
        
           
        
            <asp:TextBox ID="txtSerialCode" runat="server" style="margin-left: 18px" 
                Width="248px"></asp:TextBox>
        
           
        
        </div>
        <div>
        </div>
        <div>
            <asp:Button ID="btnSearch" runat="server" style="margin-left: 18px" 
                Text="Search" Width="231px" onclick="btnSearch_Click" />
            <asp:Label ID="lblPageMessage" runat="server" Font-Bold="True" 
                Font-Size="Medium" ForeColor="Maroon" Visible="False"></asp:Label>
        </div>
        <div>
        </div>
        <div class="reports">
            <asp:GridView ID="GridViewReports" runat="server" style="margin-left: 10px" 
                Height="406px" Width="1039px" PageSize="20" 
                onselectedindexchanged="GridViewReports_SelectedIndexChanged" 
                AutoGenerateEditButton="True" AutoGenerateColumns="False">
                <SelectedRowStyle BackColor="#FFCC99" />
                <HeaderStyle BackColor="#7EA9D3" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle BackColor="#CFDFEF" BorderStyle="None" />
            </asp:GridView>
            <asp:SqlDataSource ID="SQL_Server_Inventory" runat="server"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SQL_Server" runat="server" 
                ConnectionString="<%$ ConnectionStrings:OneMobile_SasolInfra_DB001_DEVConnectionString %>" 
                
                
                
                SelectCommand="SELECT [sWarehouse], [sBay], [iCountQuantity], [sSerial], [dBagWeight], [sBUoM], [ipk] FROM [InventoryCount] ORDER BY [sSerial], [sWarehouse]" 
                OldValuesParameterFormatString="original_{0}" 
                ConflictDetection="CompareAllValues" 
                DeleteCommand="DELETE FROM [InventoryCount] WHERE [ipk] = @original_ipk AND [sWarehouse] = @original_sWarehouse AND (([sBay] = @original_sBay) OR ([sBay] IS NULL AND @original_sBay IS NULL)) AND [iCountQuantity] = @original_iCountQuantity AND [sSerial] = @original_sSerial AND (([dBagWeight] = @original_dBagWeight) OR ([dBagWeight] IS NULL AND @original_dBagWeight IS NULL)) AND (([sBUoM] = @original_sBUoM) OR ([sBUoM] IS NULL AND @original_sBUoM IS NULL))" 
                InsertCommand="INSERT INTO [InventoryCount] ([sWarehouse], [sBay], [iCountQuantity], [sSerial], [dBagWeight], [sBUoM]) VALUES (@sWarehouse, @sBay, @iCountQuantity, @sSerial, @dBagWeight, @sBUoM)" 
                UpdateCommand="UPDATE [InventoryCount] SET [sWarehouse] = @sWarehouse, [sBay] = @sBay, [iCountQuantity] = @iCountQuantity, [sSerial] = @sSerial, [dBagWeight] = @dBagWeight, [sBUoM] = @sBUoM WHERE [ipk] = @original_ipk AND [sWarehouse] = @original_sWarehouse AND (([sBay] = @original_sBay) OR ([sBay] IS NULL AND @original_sBay IS NULL)) AND [iCountQuantity] = @original_iCountQuantity AND [sSerial] = @original_sSerial AND (([dBagWeight] = @original_dBagWeight) OR ([dBagWeight] IS NULL AND @original_dBagWeight IS NULL)) AND (([sBUoM] = @original_sBUoM) OR ([sBUoM] IS NULL AND @original_sBUoM IS NULL))">
                <DeleteParameters>
                    <asp:Parameter Name="original_ipk" Type="Int32" />
                    <asp:Parameter Name="original_sWarehouse" Type="String" />
                    <asp:Parameter Name="original_sBay" Type="String" />
                    <asp:Parameter Name="original_iCountQuantity" Type="Int32" />
                    <asp:Parameter Name="original_sSerial" Type="String" />
                    <asp:Parameter Name="original_dBagWeight" Type="Decimal" />
                    <asp:Parameter Name="original_sBUoM" Type="String" />
                </DeleteParameters>
                <UpdateParameters>
                    <asp:Parameter Name="sWarehouse" Type="String" />
                    <asp:Parameter Name="sBay" Type="String" />
                    <asp:Parameter Name="iCountQuantity" Type="Int32" />
                    <asp:Parameter Name="sSerial" Type="String" />
                    <asp:Parameter Name="dBagWeight" Type="Decimal" />
                    <asp:Parameter Name="sBUoM" Type="String" />
                    <asp:Parameter Name="original_ipk" Type="Int32" />
                    <asp:Parameter Name="original_sWarehouse" Type="String" />
                    <asp:Parameter Name="original_sBay" Type="String" />
                    <asp:Parameter Name="original_iCountQuantity" Type="Int32" />
                    <asp:Parameter Name="original_sSerial" Type="String" />
                    <asp:Parameter Name="original_dBagWeight" Type="Decimal" />
                    <asp:Parameter Name="original_sBUoM" Type="String" />
                </UpdateParameters>
                <InsertParameters>
                    <asp:Parameter Name="sWarehouse" Type="String" />
                    <asp:Parameter Name="sBay" Type="String" />
                    <asp:Parameter Name="iCountQuantity" Type="Int32" />
                    <asp:Parameter Name="sSerial" Type="String" />
                    <asp:Parameter Name="dBagWeight" Type="Decimal" />
                    <asp:Parameter Name="sBUoM" Type="String" />
                </InsertParameters>
            </asp:SqlDataSource>
        </div>
    </div>
</asp:Content>

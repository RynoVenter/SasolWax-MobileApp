﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5448
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.5448.
// 
namespace SasolWax.OneMobileWS_Wax {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="OneMobile WebServiceSoap", Namespace="http://www.onemobilews.com/")]
    public partial class OneMobileWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public OneMobileWebService() {
            this.Url = "http://localhost/OneMobileWS_Wax/OneMobileWS_Wax.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.onemobilews.com/Ping", RequestNamespace="http://www.onemobilews.com/", ResponseNamespace="http://www.onemobilews.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Ping() {
            object[] results = this.Invoke("Ping", new object[0]);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginPing(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Ping", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndPing(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.onemobilews.com/HelloWordl", RequestNamespace="http://www.onemobilews.com/", ResponseNamespace="http://www.onemobilews.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWordl() {
            object[] results = this.Invoke("HelloWordl", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginHelloWordl(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("HelloWordl", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndHelloWordl(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.onemobilews.com/GetUsers", RequestNamespace="http://www.onemobilews.com/", ResponseNamespace="http://www.onemobilews.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Users[] GetUsers() {
            object[] results = this.Invoke("GetUsers", new object[0]);
            return ((Users[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetUsers(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetUsers", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public Users[] EndGetUsers(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Users[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.onemobilews.com/GetArea", RequestNamespace="http://www.onemobilews.com/", ResponseNamespace="http://www.onemobilews.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Areas[] GetArea() {
            object[] results = this.Invoke("GetArea", new object[0]);
            return ((Areas[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetArea(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetArea", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public Areas[] EndGetArea(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Areas[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.onemobilews.com/GetWarehouse", RequestNamespace="http://www.onemobilews.com/", ResponseNamespace="http://www.onemobilews.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Warehouses[] GetWarehouse() {
            object[] results = this.Invoke("GetWarehouse", new object[0]);
            return ((Warehouses[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetWarehouse(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetWarehouse", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public Warehouses[] EndGetWarehouse(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Warehouses[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.onemobilews.com/GetStockMasterData", RequestNamespace="http://www.onemobilews.com/", ResponseNamespace="http://www.onemobilews.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public StockMasterData[] GetStockMasterData() {
            object[] results = this.Invoke("GetStockMasterData", new object[0]);
            return ((StockMasterData[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetStockMasterData(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetStockMasterData", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public StockMasterData[] EndGetStockMasterData(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((StockMasterData[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.onemobilews.com/GetVersion", RequestNamespace="http://www.onemobilews.com/", ResponseNamespace="http://www.onemobilews.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Version[] GetVersion() {
            object[] results = this.Invoke("GetVersion", new object[0]);
            return ((Version[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetVersion(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetVersion", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public Version[] EndGetVersion(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Version[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.onemobilews.com/UpdateInventoryCount", RequestNamespace="http://www.onemobilews.com/", ResponseNamespace="http://www.onemobilews.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateInventoryCount(InventoryCount[] inventoryCountList) {
            this.Invoke("UpdateInventoryCount", new object[] {
                        inventoryCountList});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginUpdateInventoryCount(InventoryCount[] inventoryCountList, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("UpdateInventoryCount", new object[] {
                        inventoryCountList}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndUpdateInventoryCount(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onemobilews.com/")]
    public partial class Users {
        
        private int ipkField;
        
        private string sUserField;
        
        private string sPassField;
        
        private string sNameField;
        
        private string sSurnameField;
        
        /// <remarks/>
        public int ipk {
            get {
                return this.ipkField;
            }
            set {
                this.ipkField = value;
            }
        }
        
        /// <remarks/>
        public string sUser {
            get {
                return this.sUserField;
            }
            set {
                this.sUserField = value;
            }
        }
        
        /// <remarks/>
        public string sPass {
            get {
                return this.sPassField;
            }
            set {
                this.sPassField = value;
            }
        }
        
        /// <remarks/>
        public string sName {
            get {
                return this.sNameField;
            }
            set {
                this.sNameField = value;
            }
        }
        
        /// <remarks/>
        public string sSurname {
            get {
                return this.sSurnameField;
            }
            set {
                this.sSurnameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onemobilews.com/")]
    public partial class InventoryCount {
        
        private int ipkField;
        
        private System.DateTime dtCountField;
        
        private int ifkUserField;
        
        private string sStockCodeField;
        
        private string sWarehouseField;
        
        private int iCountQuantityField;
        
        private string sSerialField;
        
        private string sBatchCodeField;
        
        private decimal dBagWeightField;
        
        private string iBagStationField;
        
        private int ifkVersionField;
        
        private System.Guid gUIDField;
        
        /// <remarks/>
        public int ipk {
            get {
                return this.ipkField;
            }
            set {
                this.ipkField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime dtCount {
            get {
                return this.dtCountField;
            }
            set {
                this.dtCountField = value;
            }
        }
        
        /// <remarks/>
        public int ifkUser {
            get {
                return this.ifkUserField;
            }
            set {
                this.ifkUserField = value;
            }
        }
        
        /// <remarks/>
        public string sStockCode {
            get {
                return this.sStockCodeField;
            }
            set {
                this.sStockCodeField = value;
            }
        }
        
        /// <remarks/>
        public string sWarehouse {
            get {
                return this.sWarehouseField;
            }
            set {
                this.sWarehouseField = value;
            }
        }
        
        /// <remarks/>
        public int iCountQuantity {
            get {
                return this.iCountQuantityField;
            }
            set {
                this.iCountQuantityField = value;
            }
        }
        
        /// <remarks/>
        public string sSerial {
            get {
                return this.sSerialField;
            }
            set {
                this.sSerialField = value;
            }
        }
        
        /// <remarks/>
        public string sBatchCode {
            get {
                return this.sBatchCodeField;
            }
            set {
                this.sBatchCodeField = value;
            }
        }
        
        /// <remarks/>
        public decimal dBagWeight {
            get {
                return this.dBagWeightField;
            }
            set {
                this.dBagWeightField = value;
            }
        }
        
        /// <remarks/>
        public string iBagStation {
            get {
                return this.iBagStationField;
            }
            set {
                this.iBagStationField = value;
            }
        }
        
        /// <remarks/>
        public int ifkVersion {
            get {
                return this.ifkVersionField;
            }
            set {
                this.ifkVersionField = value;
            }
        }
        
        /// <remarks/>
        public System.Guid gUID {
            get {
                return this.gUIDField;
            }
            set {
                this.gUIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onemobilews.com/")]
    public partial class Version {
        
        private int ipkField;
        
        private string sVersionField;
        
        private string sDescriptionField;
        
        /// <remarks/>
        public int ipk {
            get {
                return this.ipkField;
            }
            set {
                this.ipkField = value;
            }
        }
        
        /// <remarks/>
        public string sVersion {
            get {
                return this.sVersionField;
            }
            set {
                this.sVersionField = value;
            }
        }
        
        /// <remarks/>
        public string sDescription {
            get {
                return this.sDescriptionField;
            }
            set {
                this.sDescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onemobilews.com/")]
    public partial class StockMasterData {
        
        private int ipkField;
        
        private string sStockCodeField;
        
        private string sAreaField;
        
        private string sWareHouseField;
        
        private string sSerialField;
        
        private string iBagStationField;
        
        private string sBatchCodeField;
        
        private string sBatchCodeSerialField;
        
        /// <remarks/>
        public int ipk {
            get {
                return this.ipkField;
            }
            set {
                this.ipkField = value;
            }
        }
        
        /// <remarks/>
        public string sStockCode {
            get {
                return this.sStockCodeField;
            }
            set {
                this.sStockCodeField = value;
            }
        }
        
        /// <remarks/>
        public string sArea {
            get {
                return this.sAreaField;
            }
            set {
                this.sAreaField = value;
            }
        }
        
        /// <remarks/>
        public string sWareHouse {
            get {
                return this.sWareHouseField;
            }
            set {
                this.sWareHouseField = value;
            }
        }
        
        /// <remarks/>
        public string sSerial {
            get {
                return this.sSerialField;
            }
            set {
                this.sSerialField = value;
            }
        }
        
        /// <remarks/>
        public string iBagStation {
            get {
                return this.iBagStationField;
            }
            set {
                this.iBagStationField = value;
            }
        }
        
        /// <remarks/>
        public string sBatchCode {
            get {
                return this.sBatchCodeField;
            }
            set {
                this.sBatchCodeField = value;
            }
        }
        
        /// <remarks/>
        public string sBatchCodeSerial {
            get {
                return this.sBatchCodeSerialField;
            }
            set {
                this.sBatchCodeSerialField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onemobilews.com/")]
    public partial class Warehouses {
        
        private int ipkField;
        
        private string sAreaField;
        
        private string sWarehouseCodeField;
        
        /// <remarks/>
        public int ipk {
            get {
                return this.ipkField;
            }
            set {
                this.ipkField = value;
            }
        }
        
        /// <remarks/>
        public string sArea {
            get {
                return this.sAreaField;
            }
            set {
                this.sAreaField = value;
            }
        }
        
        /// <remarks/>
        public string sWarehouseCode {
            get {
                return this.sWarehouseCodeField;
            }
            set {
                this.sWarehouseCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.onemobilews.com/")]
    public partial class Areas {
        
        private int ipkField;
        
        private string sAreaField;
        
        /// <remarks/>
        public int ipk {
            get {
                return this.ipkField;
            }
            set {
                this.ipkField = value;
            }
        }
        
        /// <remarks/>
        public string sArea {
            get {
                return this.sAreaField;
            }
            set {
                this.sAreaField = value;
            }
        }
    }
}

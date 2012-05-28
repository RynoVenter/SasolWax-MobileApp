using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

namespace OneMobileWS_Wax
{
    public class Users
    {
        public Int32 ipk = 0;
        public String sUser = String.Empty;
        public String sPass = String.Empty;
        public String sName = String.Empty;
        public String sSurname = String.Empty;
        public String sPassExpire = String.Empty;
        public Int32 iChanged = 0;

    }

    public class Areas
    {
        public Int32 ipk = 0;
        public String sArea = String.Empty;
    }

    public class Warehouses
    {
        public Int32 ipk = 0;
        public String sArea = String.Empty;
        public String sWarehouseCode = String.Empty;
    }

    public class StockBaseLine
    {
        public Int32 ipk = 0;
        public String sStockCode = String.Empty;
        public String sWarehouse = String.Empty;
        public String sSerial = String.Empty;
        public String sArea = String.Empty;
        public String sBUoM = String.Empty;
    }

    public class Version
    {
        public Int32 ipk = 0;
        public String sArea = String.Empty;
        public String sDescription = String.Empty;
        public String sTeamName = String.Empty;
    }

    public class InventoryCount
    {
        public Int32 ipk = 0;
        public DateTime dtCount;
        public int ifkUser = 0;
        public String sStockCode = String.Empty;
        public String sWarehouse = String.Empty;
        public String sBay = String.Empty;
        public String sPackaging = String.Empty;
        public Int32 iCountQuantity = 0;
        public String sBUoM = String.Empty;
        public String sSerial = String.Empty;
        public Decimal dBagWeight = 0M;
        public int ifkVersion = 0;
        public Guid gUID = Guid.Empty;
    }

}
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
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace OneMobileWS_Wax
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://www.onemobilews.com/", Name = "OneMobile WebService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OneMobileWS_Wax : System.Web.Services.WebService
    {

        [WebMethod]
        public bool Ping()
        {
            return true;
        }
        #region Data

        [WebMethod]
        public string HelloWordl()
        {
            return "Hello";
        }

        
        [WebMethod]
        public List<Users> GetUsers()
        {
            DataTable dtUsers = new DataTable();
            var userList = new List<Users>();
            Users user;
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OneMobileConnectionString"].ConnectionString);
            
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", conn);
            
            da.Fill(dtUsers);

            foreach(DataRow dr in dtUsers.Rows)
            {
                user = new Users
                {
                    ipk = Convert.ToInt32(dr["ipk"].ToString()),
                    sUser = dr["sUser"].ToString(),
                    sPass = dr["sPass"].ToString(),
                    sName = dr["sName"].ToString(),
                    sSurname = dr["sSurname"].ToString()
                };
                userList.Add(user);
            }

            return userList;
        }

        [WebMethod]
        public List<Areas> GetArea()
        {
            DataTable dtArea = new DataTable();
            var areaList = new List<Areas>();
            Areas area;
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OneMobileConnectionString"].ConnectionString);

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Area", conn);

            da.Fill(dtArea);

            foreach (DataRow dr in dtArea.Rows)
            {
                area = new Areas
                {
                    ipk = Convert.ToInt32(dr["ipk"].ToString()),
                    sArea = dr["sArea"].ToString()
                };
                areaList.Add(area);
            }

            conn.Close();

            return areaList;
        }

        [WebMethod]
        public List<Warehouses> GetWarehouse()
        {
            DataTable dtWarehouse = new DataTable();
            var warehouseList = new List<Warehouses>();
            Warehouses warehouse;
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OneMobileConnectionString"].ConnectionString);

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Warehouse", conn);

            da.Fill(dtWarehouse);

            foreach (DataRow dr in dtWarehouse.Rows)
            {
                warehouse = new Warehouses
                {
                    ipk = Convert.ToInt32(dr["ipk"].ToString()),
                    sArea = dr["sArea"].ToString(),
                    sWarehouseCode = dr["sWarehouseCode"].ToString()
                };
                warehouseList.Add(warehouse);
            }

            conn.Close();

            return warehouseList;
        }

        [WebMethod]
        public List<StockMasterData> GetStockMasterData()
        {
            DataTable dtStockMasterData = new DataTable();
            var stockMDList = new List<StockMasterData>();
            StockMasterData stockMD;
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OneMobileConnectionString"].ConnectionString);

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Wax_StockMasterData", conn);

            da.Fill(dtStockMasterData);

            foreach (DataRow dr in dtStockMasterData.Rows)
            {
                stockMD = new StockMasterData
                {
                    ipk = Convert.ToInt32(dr["ipk"].ToString()),
                    sStockCode = dr["sStockCode"].ToString(),
                    sArea = dr["sArea"].ToString(),
                    sWareHouse = dr["sWareHouse"].ToString(),
                    sSerial = dr["sSerial"].ToString(),
                    iBagStation = dr["iBagStation"].ToString(),
                    sBatchCode = dr["sBatchCode"].ToString(),
                    sBatchCodeSerial = dr["sBatchCodeSerial"].ToString()

                };
                stockMDList.Add(stockMD);
            }

            conn.Close();

            return stockMDList;
        }

        [WebMethod]
        public List<Version> GetVersion()
        {
            DataTable dtVersion = new DataTable();
            var versionList = new List<Version>();
            Version version;
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OneMobileConnectionString"].ConnectionString);

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Version", conn);

            da.Fill(dtVersion);

            foreach (DataRow dr in dtVersion.Rows)
            {
                version = new Version
                {
                    ipk = Convert.ToInt32(dr["ipk"].ToString()),
                    sVersion = dr["sVersion"].ToString(),
                    sDescription = dr["sDescription"].ToString()

                };
                versionList.Add(version);
            }

            conn.Close();

            return versionList;
        }

        [WebMethod]
        public void UpdateInventoryCount(List<InventoryCount> inventoryCountList)
        {
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OneMobileConnectionString"].ConnectionString);

            SqlCommand cmd = new SqlCommand();
            String sql = String.Empty;

            cmd.Connection = conn;

            conn.Open();

            foreach (InventoryCount inventoryCount in inventoryCountList)
            {
                sql = "INSERT INTO InventoryCount (dtCount,ifkUser,sStockCode,sWarehouse,iCountQuantity,sSerial,sBatchCode,dBagWeight,iBagStation,ifkVersion) VALUES ('"
                    + inventoryCount.dtCount + "', "
                    + inventoryCount.ifkUser + ", '"
                    + inventoryCount.sStockCode + "', '"
                    + inventoryCount.sWarehouse + "', "
                    + inventoryCount.iCountQuantity + ", '"
                    + inventoryCount.sSerial + "', '"
                    + inventoryCount.sBatchCode + "', "
                    + inventoryCount.dBagWeight + ", '"
                    + inventoryCount.iBagStation + "', "
                    + inventoryCount.ifkVersion + ");";

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }

        public DateTime GetServerDateTime()
        {
            DateTime dtNow = DateTime.Now;

            return dtNow;
        }

        #endregion
    }
}

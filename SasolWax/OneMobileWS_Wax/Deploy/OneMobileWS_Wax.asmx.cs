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
                    sSurname = dr["sSurname"].ToString(),
                    sPassExpire = dr["sPassExpire"].ToString(),
                    iChanged = Convert.ToInt32(dr["iChanged"].ToString())
                };
                userList.Add(user);
            }

            return userList;
        }

        [WebMethod]
        public void UpdateUser(int ipk, String sUser, String sPass, String sNewPassExpire)
        {

            String[] sPassExp = sNewPassExpire.Split('/', ' ');
            DateTime sPassExpire = new DateTime(Convert.ToInt32("20" + sPassExp[2].ToString()),
                                                                        Convert.ToInt32(sPassExp[0].ToString()),
                                                                        Convert.ToInt32(sPassExp[1].ToString()));
            
                SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OneMobileConnectionString"].ConnectionString);

                SqlCommand cmd = new SqlCommand();
                String sql = String.Empty;

                cmd.Connection = conn;

                conn.Open();
            try
            {
                cmd.CommandText = "UPDATE Users SET sPass = '" + sPass + "' ,sPassExpire = '" + sPassExpire + "', iChanged = 0 WHERE ipk = " + ipk +" AND sUser = '" +sUser + "';";
                
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            { }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
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
        public List<StockBaseLine> GetStockBaseLine()
        {
            DataTable dtStockBaseLine = new DataTable();
            var stockBLList = new List<StockBaseLine>();
            StockBaseLine stockBL;
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OneMobileConnectionString"].ConnectionString);

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM StockBaseLine", conn);

            da.Fill(dtStockBaseLine);

            foreach (DataRow dr in dtStockBaseLine.Rows)
            {
                stockBL = new StockBaseLine
                {
                    ipk = Convert.ToInt32(dr["ipk"].ToString()),
                    sStockCode = dr["sStockCode"].ToString(),
                    sWarehouse = dr["sWareHouse"].ToString(),
                    sSerial = dr["sSerial"].ToString(),
                    sArea = dr["sArea"].ToString(),
                    sBUoM = dr["sBUoM"].ToString()
                };
                stockBLList.Add(stockBL);
            }

            conn.Close();

            return stockBLList;
        }

        [WebMethod]
        public List<Version> GetVersion(String sArea)
        {
            DataTable dtVersion = new DataTable();
            var versionList = new List<Version>();
            Version version;
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OneMobileConnectionString"].ConnectionString);

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Version WHERE sArea = '" + sArea + "' AND bActive = '1';", conn);

            da.Fill(dtVersion);

            foreach (DataRow dr in dtVersion.Rows)
            {
                version = new Version
                {
                    ipk = Convert.ToInt32(dr["ipk"].ToString()),
                    sArea = dr["sArea"].ToString(),
                    sDescription = dr["sDescription"].ToString(),
                    sTeamName = dr["sTeamName"].ToString()

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

                if (CheckInventoryNotExist(inventoryCount.gUID).Rows.Count == 0)
                {
                    sql = "INSERT INTO InventoryCount (dtCount,ifkUser,sStockCode,sPackaging,sWarehouse,sBay,iCountQuantity,sSerial,dBagWeight,sBUoM,ifkVersion,gUID) VALUES ('"
                        + inventoryCount.dtCount + "', "
                        + inventoryCount.ifkUser + ", '"
                        + inventoryCount.sStockCode + "', '"
                        + inventoryCount.sPackaging + "', '"
                        + inventoryCount.sWarehouse + "', '"
                        + inventoryCount.sBay + "', "
                        + inventoryCount.iCountQuantity + ", '"
                        + inventoryCount.sSerial + "', '"
                        + inventoryCount.dBagWeight + "', '"
                        + inventoryCount.sBUoM + "', "
                        + inventoryCount.ifkVersion + ", '"
                        + inventoryCount.gUID + "');";
                

                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }

            conn.Close();
        }

        public DateTime GetServerDateTime()
        {
            DateTime dtNow = DateTime.Now;

            return dtNow;
        }

        public static DataTable CheckInventoryNotExist(Guid sGUID)
        {
            DataTable dtInventory = new DataTable();

            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OneMobileConnectionString"].ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;

                conn.Open();

                cmd.CommandText = "SELECT * FROM InventoryCount WHERE gUID = '" + sGUID + "';";

                SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, conn);

                da.Fill(dtInventory);
            }
            catch (System.Exception ex)
            {
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

            return dtInventory;
        }

        #endregion
    }
}

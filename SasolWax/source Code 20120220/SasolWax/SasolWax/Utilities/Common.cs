using System;

using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using SasolWax.OneMobileWS_Wax;

namespace SasolWax.Utilities
{
    public class AppSession
    {
        public Int32 sUserIpk = 0;
        public String sUser = String.Empty;
        public String sArea = String.Empty;
        public String sUserPass = String.Empty;
        public String sPreferedMethod = String.Empty;
    }

    public class CountSession
    {
        public String sSerialCode = String.Empty;
        public String sManualBarcode = String.Empty;
        public String sStockBarcode = String.Empty;
        public String sBatchCode = String.Empty;
        public String sCurrentWarehouse = String.Empty;
    }

    public sealed class Common : IDisposable
    {
        public static readonly Common instance = new Common();
        public static string appPath = String.Empty;
        public static SasolWax.OneMobileWS_Wax.OneMobileWebService wsWax;
        public static bool blnOnline = false;                   // assume off-line during startup
        public static DataTable StockWarehouses;
        public static DataTable StockSerialNumbers;
        public static AppSession appSession;
        public static CountSession countSession;
        public static DateTime dtCurrent = new DateTime();
        

        private static System.Windows.Forms.Timer _connectionStateTimer = new System.Windows.Forms.Timer();
        public static System.Windows.Forms.Timer _syncTaskTimer = new System.Windows.Forms.Timer();



        #region Internal

        static Common()
        {
            _connectionStateTimer.Tick += new EventHandler(_connectionStateTimer_Tick);
            _connectionStateTimer.Interval = 5000;
            _connectionStateTimer.Enabled = true;

            _syncTaskTimer.Tick += new EventHandler(_syncTaskTimer_Tick);
            _syncTaskTimer.Interval = 200000;
            _syncTaskTimer.Enabled = true;

        }

        Common()
        {
        }

        public static Common Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        /// Dummy method to create single instance (instance).
        /// </summary>
        public void Start()
        {
        }

        public void Dispose()
        {
            //Save();
        }

        ~Common()
        {
            Dispose();
        }

        #endregion Internal

        #region DB connection


        public static string getDBConnection()
        {
            return "Data Source=" + appPath + "\\SasolWax.s3db;Version=3";
        }

        public static void EnsureLocalDatabaseExist()
        {
            SQLite.EnsureLocalDatabaseExist();
        }

        #endregion

        #region validation

        #endregion

        #region ConnectionState
        /// <summary>
        /// Checks connectivity to OneMobile Server.
        /// </summary>

        public static IAsyncResult CheckConnectionState()
        {
            if (wsWax != null)
            {
                return wsWax.BeginPing(new AsyncCallback(CheckConnectionStateCallback), null);
            }

            return null;
        }

        public static void CheckConnectionStateCallback(IAsyncResult result)
        {
            try
            {
                blnOnline = true;
            }
            catch (System.Exception)
            {
                blnOnline = false;
            }
        }

        private static void _connectionStateTimer_Tick(object sender, EventArgs e)
        {
            CheckConnectionState();            
        }

        private static void _syncTaskTimer_Tick(object sender, EventArgs e)
        {
        }

        public static bool IsNumeric(object num)
        {
            try
            {
                Convert.ToDecimal(num);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion ConnectionState
    }
}

using System;

using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SasolWax.Utilities;
using SasolWax.OneMobileWS_Wax;

namespace SasolWax
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            string tmpAppPath = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            Common.appPath = tmpAppPath.Substring(0, tmpAppPath.LastIndexOf("\\")); ;
            
            try
            {
                
               
                Common.wsWax = new OneMobileWebService();
                // Local Dev Common.wsWax.Url = "http://rynoventer/OneMobileWS_Wax/OneMobileWS_Wax.asmx";
                //Common.wsWax.Url = "http://155.237.98.185/OneMobileWS_Wax/OneMobileWS_Wax.asmx";
                Common.wsWax.Url = "http://155.237.98.185/SasolWax_WS/OneMobileWS_Wax.asmx";
                Common.appSession = new AppSession();
                Common.countSession = new CountSession();
                
            }
            catch (System.Exception ex)
            {
            }
            
            try
            {
                Common.EnsureLocalDatabaseExist();
                if (Common.wsWax != null)
                {
                    try
                    {
                        if (Common.wsWax.Ping())
                            Common.blnOnline = true;
                        else
                            Common.blnOnline = false;
                    }
                    catch (System.Exception ex)
                    {

                    }
                }


                if (Common.blnOnline)
                {
                    SQLite.LoadUsers();
                    SQLite.GetServerAreas();
                    SQLite.GetServerWareHouses();
                }
            }
            catch (System.Exception ex)
            {
                // without settings, the app cannot continue
                throw new System.Exception(ex.Message + "\r\n\r\nReport error to supervisor.");
            }

            Application.Run(new frm_Logon());
        }
    }
}
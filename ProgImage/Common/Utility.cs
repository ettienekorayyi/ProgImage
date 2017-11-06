using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace ProgImage.Common
{
    public class Utility
    {
        public static void ErrorLogger(_Exception exception)
        {
            
            using (StreamWriter writer = new StreamWriter(Constants.LogPath))
            {
                writer.WriteLine("Message :" + exception.Message + "<br/>"
                    + Environment.NewLine + "StackTrace :" + exception.StackTrace +
                    "" + Environment.NewLine + "Date :" + DateTime.Now.ToString());
                writer.WriteLine(Environment.NewLine +
                    "-----------------------------------------------------------------------------"
                    + Environment.NewLine);
                //return true;
            }
           // return false;
        }
    }
}
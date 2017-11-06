using ProgImage.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ProgImage.Common;

namespace ProgImage.Classes
{
    public class Validator
    {
        public static bool ValidateDirectory(string path)
        {
            if (Directory.Exists(path) == false) return false;
            else return true;
        }
        public static bool ValidateFileLength(string imageStr)
        {
            if (((int)new FileInfo(imageStr).Length) > 12000000)
            {
                
                Utility.ErrorLogger(new Exception("Size is too large. Check the log folder."));
                return true;
            }
            return false;
        }
    }
}
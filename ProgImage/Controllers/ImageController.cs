using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net.Http;
using System.Web.Http;
using System.Drawing;
using System.Web;
using ProgImage.Common;
using System.Drawing.Imaging;
using System.Web.Hosting;
using ProgImage.Classes;

namespace ProgImage.Controllers
{
    public class ImageController : ApiController
    {
        public static ImageProcessor Processor { get; set; }

        public ImageController() { Processor = new ImageProcessor(); }
        //single upload
        public IHttpActionResult Post([FromBody]string imageStr)
        {
            Processor.Upload(imageStr);
            return Ok();   
        }

        public bool Post([FromBody]string imageStr, string type ,bool convert)
        {
            if (type == "png")
            {
                if (Processor.ConvertToPng(imageStr) == true) return true;
                else return false;
            }
            else if (type == "jpg")
            {
                if (Processor.ConvertToJpg(imageStr) == true) return true;
                else return false;
                //C:\Users\Stephen\Desktop\TestStv
            }
            else return false;
        }

        public Image Post([FromBody]string imageStr,string rotate)
        {
            if (rotate == "right") return Processor.RightRotation(imageStr);
            else if (rotate == "left") return Processor.LeftRotation(imageStr);
            else return null;
        }

        public string Get()
        {
            return Processor.GetImage();
        }
    }
}

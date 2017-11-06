using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace ProgImage.Models
{
    public class Imaging
    {
        public Image Image { get; set; }
        public Guid Identifier { get; set; }
        public string Extension { get; set; }
        public List<Imaging> Images { get; set; }
    }
}
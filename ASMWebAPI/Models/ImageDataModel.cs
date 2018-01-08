using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASMWebAPI.Models
{
    public class ImageDataModel
    {
        public DateTime date { get; set; }
        public string Time { get; set; }
        public List<IdData> imagepara { get; set; }
    }

    public class IdData
    {
        public string id { get; set; }
        public string filename { get; set; }
    }
}
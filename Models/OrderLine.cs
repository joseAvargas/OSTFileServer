using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSTFileServer.Models
{
    public class OrderLine
    {
        public string LineNumber { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Carrier { get; set; }
        public int Ordered { get; set; }
        public int Shipped { get; set; }


    }
}

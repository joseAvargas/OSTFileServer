using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using OSTFileServer.Models;

namespace OSTFileServer.Controllers
{
    public class FileController : Controller
    {
        List<OrderLine> orderLines = new List<OrderLine>
        {
            new OrderLine {
                LineNumber="1.0",
                Description="Wifi Chassis In Staineless Steel VPN: MYFQ2LL/A SKU: 8HH942",
                Status="In Transit",
                Carrier="FedEx",
                Ordered=300,
                Shipped=300
            },
            new OrderLine {
                LineNumber="2.0",
                Description="Wifi Chassis In Staineless Steel VPN: MYFQ2LL/A SKU: 8HH942",
                Status="In Transit",
                Carrier="FedEx",
                Ordered=150,
                Shipped=150
            },
            new OrderLine {
                LineNumber="2.0",
                Description="Wifi Chassis In Staineless Steel VPN: MYFQ2LL/A SKU: 8HH942",
                Status="In Transit",
                Carrier="FedEx",
                Ordered=100,
                Shipped=100
            },
        };

        public IActionResult DownloadCSV()
        {
            try
            {
                var fileName = "orderLinesTest";

                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("Line,Description,Status,Carrier,Ordered,Shipped");

                foreach (var line in orderLines)
                {
                    stringBuilder.AppendLine($"{line.LineNumber}," +
                        $"{line.Description},{line.Status },{line.Carrier}," +
                        $"{line.Ordered}, {line.Shipped}");
                }
                return File(Encoding.UTF8.GetBytes
                (stringBuilder.ToString()), "text/csv", $"{fileName}.csv");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

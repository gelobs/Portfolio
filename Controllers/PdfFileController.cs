using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PdfFileController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetPdf(string filePath)
        {
            Response.Headers.Add("Content-Disposition", $"inline; filename={Path.GetFileName(filePath)}");
            return File(filePath, "application/pdf");
        }
    }
}
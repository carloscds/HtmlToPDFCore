using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TesteMVC.Models;
using System.Runtime.InteropServices;
using HtmlToPDFCore;
using System.IO;
using System.Reflection;

namespace TesteMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PDF()
        {
            try

            {
                var html = "<html><body><b>TESTE PDF</b></body></html>";

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    html = "<html><body><b>TESTE PDF no Linux</b></body></html>";
                }
                var pdf = new HtmlToPDF();
                var buffer = pdf.ReturnPDF(html);
                var stream = new MemoryStream(buffer);
                return new FileStreamResult(stream, "application/pdf");
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}

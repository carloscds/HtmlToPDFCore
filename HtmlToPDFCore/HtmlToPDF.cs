using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Wkhtmltopdf.NetCore.Options;

namespace HtmlToPDFCore
{
    public class HtmlToPDF
    {
        public PageMargins Margins {get; set;}
        public byte[] ReturnPDF(string html)
        {
            var dir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            dir = Path.Combine(dir,"rotativa");
            Wkhtmltopdf.NetCore.RotativaConfiguration.RotativaPath = dir;
            Wkhtmltopdf.NetCore.RotativaConfiguration.IsWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            var pdf = new Wkhtmltopdf.NetCore.HtmlAsPdf();
            if(Margins != null)
            {
                pdf.PageMargins = new Margins(Margins.top,Margins.right,Margins.bottom, Margins.left);
            }
            var buffer = pdf.GetPDF(html);
            return buffer;
        }
    }
}

using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace HtmlToPDFCore
{
    public class HtmlToPDF
    {
        public byte[] ReturnPDF(string html)
        {
            var dir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            dir = Path.Combine(dir,"rotativa");
            Wkhtmltopdf.NetCore.RotativaConfiguration.RotativaPath = dir;
            Wkhtmltopdf.NetCore.RotativaConfiguration.IsWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            var pdf = new Wkhtmltopdf.NetCore.HtmlAsPdf();
            var buffer = pdf.GetPDF(html);
            return buffer;
        }
    }
}

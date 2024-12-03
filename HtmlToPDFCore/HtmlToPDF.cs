using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Wkhtmltopdf.NetCore;
using Wkhtmltopdf.NetCore.Options;

namespace HtmlToPDFCore
{
    public class HtmlToPDF
    {
        public PageMargins Margins {get; set;}
        public PageOrientation Orientation { get; set; }
        public bool DisableSmartShrinking { get; set; }
        public Size PageSize { get; set; }
        public HtmlToPDF()
        {
            Orientation = PageOrientation.Portrait;
            PageSize = Size.A4;
        }

        public byte[] ReturnPDF(string html)
        {
            var dir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            dir = Path.Combine(dir,"rotativa");
            WkhtmltopdfConfiguration.RotativaPath = dir;
            var pdf = new GeneratePdf(null);
            var convertOptions = new ConvertOptionsExtended();
            if (Margins != null)
            {
                convertOptions.PageMargins = new Margins(Margins.top,Margins.right,Margins.bottom, Margins.left);
            }
            convertOptions.PageOrientation = Orientation;
            convertOptions.DisableSmartShrinking = DisableSmartShrinking;
            convertOptions.PageSize = PageSize;
            pdf.SetConvertOptions(convertOptions);
            var buffer = pdf.GetPDF(html);
            return buffer;
        }
    }
}

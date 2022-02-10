using System;
using System.IO;
using System.Runtime.InteropServices;
using HtmlToPDFCore;

namespace TestePDF
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = "<html><body><b>TESTE PDF</b></body></html>";

            var pdfFile = @"teste.pdf";

            if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                html = "<html><body><b>TESTE PDF no Linux</b></body></html>";
                pdfFile = "teste-linux.pdf";
            }

            var pdf = new HtmlToPDF();
            //pdf.DisableSmartShrinking = true;
            //pdf.Margins = new PageMargins(5,5,5,5);
            var buffer = pdf.ReturnPDF(html);
            if(File.Exists(pdfFile)) File.Delete(pdfFile);
            using(var f = new FileStream(pdfFile,FileMode.Create))
            {
                f.Write(buffer,0,buffer.Length);
                f.Flush();
                f.Close();
            }
        }
    }
}

[![Nuget count](http://img.shields.io/nuget/v/HtmlToPDFCore.svg)](http://www.nuget.org/packages/HtmlToPDFCore/)
[![.NET Core](https://github.com/carloscds/HtmlToPDFCore/workflows/.NET%20Core/badge.svg)](https://github.com/carloscds/HtmlToPDFCore/actions)

# HtmlToPDFCore
Convert HTML to PDF

This package is huge because include Rotativa files for Windows, Linux and MAC. 

Using this tool you can convert a HTML file to PDF file.

### How to use
```csharp
static void Main(string[] args)
{
    var html = @"
        <html>
            <title>PDF</title>
            <body>
                <b>PDF Sample - Carlos dos Santos</b>
            </body>
        </html>";

    var pdf = new HtmlToPDF();
    //pdf.DisableSmartShrinking = true;
    //pdf.Margins = new PageMargins(5,5,5,5);
    //pdf.Orientation = PageOrientation.Landscape;
    //pdf.PageSize = Wkhtmltopdf.NetCore.Options.Size.A4;
    var buffer = pdf.ReturnPDF(html);
    if(File.Exists(pdfFile)) File.Delete(pdfFile);
    using(var f = new FileStream(pdfFile,FileMode.Create))
    {
        f.Write(buffer,0,buffer.Length);
        f.Flush();
        f.Close();
    }
}
```

### Environment Tested

Windows, Linux, Microsoft Azure AppServices using Linux Service Plan, Docker Container

### Contributing

Feel free to use and contribute with this project.

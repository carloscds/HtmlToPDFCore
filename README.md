[![Nuget count](http://img.shields.io/nuget/v/HtmlToPDFCore.svg)](http://www.nuget.org/packages/HtmlToPDFCore/)
[![.NET Core](https://github.com/carloscds/HtmlToPDFCore/workflows/.NET%20Core/badge.svg)](https://github.com/carloscds/HtmlToPDFCore/actions)

# HtmlToPDFCore
Convert HTML to PDF

This package is huge because include Rotativa files for Windows, Linux and MAC. 

Using this tool you can convert an HTML file to PDF file.

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

    var htmlToPdf = new HtmlToPDFCore.HtmlToPDF();
    var pdf = htmlToPdf.ReturnPDF(html);
    //pdf.Margins = new PageMargins(0,0,0,0);

    FileStream fs = new FileStream("teste.pdf",FileMode.CreateNew);
    fs.Write(pdf,0,pdf.Length);
    fs.Close();
}
```

### Environment Tested

Windows, Linux, Microsoft Azure AppServices using Linux Service Plan, Docker Container

### Contributing

Feel free to use and contribute with this project.

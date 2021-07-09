using DinkToPdf;
using DinkToPdf.Contracts;
using DiplomaProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaProject.Services.PdfService
{
    public class ReportService : IReportService
    {
        private readonly IConverter _converter;
       
        public ReportService(IConverter converter)
        {
            _converter = converter;
        }

        public string UserStyleSheet { get; private set; }

        public byte[] GenerateInvoicePdf(TemplateForInvoicePdf invoiceData, int id)
        {

            var clientName = invoiceData.ClientName;
            var buildingNumber = invoiceData.BuildingNumber;
            var streetName = invoiceData.StreetName;
            var city = invoiceData.City;
            var postCode = invoiceData.PostCode;
            var country = invoiceData.Country;
            var projectName = invoiceData.ProjectName;
            var month = invoiceData.Month;
            var amountOfHours = invoiceData.AmountOdHours;
            var pricePerHour = invoiceData.PricePerHour;
            var totalToPay = invoiceData.TotalToPay;
            var dateD = invoiceData.Date.Day;
            var dateM = invoiceData.Date.Month;
            var dateY = invoiceData.Date.Year;
            var timeEntries = invoiceData.TimeEntries.OrderBy(te=>te.Date);

            var sb = new StringBuilder();

            var html = sb.AppendFormat($@"
            <!DOCTYPE html>
            <html lang=""en"">
            
            <head>
           
                <div class='header';span style = 'font-family: Garamond; background-color: #c6e2ff; color:black>
                <span style = 'text-align:left'><h1>Diploma Project</h1></span>
                <!-- <span style = 'text-align:left'><h2>by Dariusz Storka</h2></span>-->
                </div>
            </head>
            <body>
                    <br />  <!-- dodatkowa spacja-->
                    <span style = 'color:blue ; text-align:center'><h1>Invoice # {id}</h1></span>
                    <br />
                    <p style = 'font-size:20px; text-align: right'><strong> Date: {dateD}/{dateM}/{dateY} </strong></p>
                    <span style = 'font-size:20px; color:blue ; text-align:left'><h3>Bill to:</h3></span>
                    
                                    <table align='left'>
                                    <tr>
                                        <th align='left'>Client Name</th>
                                        <td>&nbsp{clientName}</td>
                                    </tr>
                                    <tr>
                                        <th align='left'>Building number</th>
                                        <td>&nbsp{buildingNumber}</td>
                                    </tr>
                                    <tr>
                                        <th align='left'>Street</th>
                                         <td>&nbsp{streetName}td>
                                    </tr>
                                     <tr>
                                        <th align='left'>City</th>
                                         <td>&nbsp{city}</td>
                                    </tr>
                                    <tr>
                                        <th align='left'>Poste code</th>
                                         <td>&nbsp{postCode}</td>
                                    </tr>
                                    <tr>
                                        <th align='left'>Country</th>
                                         <td>&nbsp{country}</td>
                                    </tr>
                                    </table>
                                    
                                    <br /> <br /> <br /> <br /> <br /> <br /> <br /> <br /> <br />
                                    <br /> <br />
                            <span style = 'font-size:20px; color:blue ; text-align:left'><h3>Description:</h3></span>
                                   
                                    <table class='description'; align='left'>
                                    <tr>
                                        <th align='left'>Project Name</th>
                                        <td>&nbsp{projectName}</td>
                                    </tr>
                                    <tr>
                                        <th align='left'>Month / Year</th>
                                         <td>&nbsp{month} / {dateY}</td>
                                    </tr>
                                     <tr>
                                        <th align='left'>Amount of hours</th>
                                         <td>&nbsp{amountOfHours}</td>
                                    </tr>
                                    <tr>
                                        <th align='left'>Price per hour</th>
                                         <td>&nbsp{pricePerHour} PLN</td>
                                    </tr>
                                    <tr>
                                        <th align='left'>Total to pay</th>
                                         <td>&nbsp{totalToPay} PLN</td>
                                    </tr>
                                    </table>

                                    <br /> <br /> <br /> <br /> <br /> <br /> <br /> <br /> <br />
                                    <br />
                           <span style = 'font-size:20px; color:blue ; text-align:left'><h3>Details:</h3></span>");


            sb.Append(@" 
                                     <table class='details'; align='left'>
                                     <tr>
                                     <th>Date and time</th>
                                     <th>Amount of hours</th>
                                     <th>Comment</th>
                                     </tr> ");
            foreach (var timeEntry in timeEntries)
	            {
                sb.AppendFormat(@" <tr>
                                    <td style = 'text-align: center'>{0}</td>
                                    <td style = 'text-align: center'>{1}</td>
                                    <td>{2}</td>   
                                    </tr>", timeEntry.Date, timeEntry.AmountOfHours, timeEntry.Comment);
	            } 
                sb.Append(@"
                                    </table>
                                    ");

                sb.Append(@"
                             <span style = 'font-size:20px; color:blue ; text-align:left'><h3>Terms:</h3></span>
                             <p style = 'font-size:20px'> <strong>Due Upon Receipt </strong></p>
                             <br />  
                             <br />
                             <div class='header';span style = 'font-family: Garamond; font-size: 20px; background-color: #c6e2ff; color:blue>
                             <span style = 'text-align:left ><i><h3>Thank you for your business!</h3></i></span>
                             </div>
                             <br />
               </body>
               </html>
               ");
            GlobalSettings globalSettings = new GlobalSettings();
            globalSettings.ColorMode = ColorMode.Color;
            globalSettings.Orientation = Orientation.Portrait;
            globalSettings.PaperSize = PaperKind.A4;
            globalSettings.Margins = new MarginSettings { Top = 25, Bottom = 25, Left = 25, Right = 25 };
            ObjectSettings objectSettings = new ObjectSettings();
            objectSettings.PagesCount = true;
            objectSettings.HtmlContent = html.ToString();
            WebSettings webSettings = new WebSettings();
            webSettings.DefaultEncoding = "utf-8";
            webSettings.UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "styles.css");
            HeaderSettings headerSettings = new HeaderSettings();
            headerSettings.FontSize = 12;
            headerSettings.FontName = "Garamond";
            headerSettings.Right = "Page [page] of [toPage]";
            headerSettings.Line = true;
            FooterSettings footerSettings = new FooterSettings();
            footerSettings.FontSize = 12;
            footerSettings.FontName = "Garamond";
            footerSettings.Center = "This invoice was created on a computer and is valid without the signature and seal.";
            footerSettings.Line = true;
            objectSettings.HeaderSettings = headerSettings;
            objectSettings.FooterSettings = footerSettings;
            objectSettings.WebSettings = webSettings;

            HtmlToPdfDocument htmlToPdfDocument = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings },
            };
            return _converter.Convert(htmlToPdfDocument);
        }

        public byte[] GeneratePdfReportExample(int id)
        {
            var html = $@"
            <!DOCTYPE html>
            <html lang=""en"">
            <head>
                This is the header of this document.
            </head>
            <body>
            <h1>This is the Heading for demonstration purposes only.</h1>
            <p>This is a Line of text for demonstration purposes only.</p>
            </body>
            </html>
            ";
            GlobalSettings globalSettings = new GlobalSettings();
            globalSettings.ColorMode = ColorMode.Color;
            globalSettings.Orientation = Orientation.Portrait;
            globalSettings.PaperSize = PaperKind.A4;
            globalSettings.Margins = new MarginSettings { Top = 25, Bottom = 25 };
            ObjectSettings objectSettings = new ObjectSettings();
            objectSettings.PagesCount = true;
            objectSettings.HtmlContent = html;
            WebSettings webSettings = new WebSettings();
            webSettings.DefaultEncoding = "utf-8";
           
            HeaderSettings headerSettings = new HeaderSettings();
            headerSettings.FontSize = 10;
            headerSettings.FontName = "Arial";
            headerSettings.Right = "Page [page] of [toPage]";
            headerSettings.Line = true;
            FooterSettings footerSettings = new FooterSettings();
            footerSettings.FontSize = 10;
            footerSettings.FontName = "Arial";
            footerSettings.Center = "This is for Footer demonstration purposes only.";
            footerSettings.Line = true;
            objectSettings.HeaderSettings = headerSettings;
            objectSettings.FooterSettings = footerSettings;
            objectSettings.WebSettings = webSettings;

            HtmlToPdfDocument htmlToPdfDocument = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings },
            };
            return _converter.Convert(htmlToPdfDocument);
        }
    }
}

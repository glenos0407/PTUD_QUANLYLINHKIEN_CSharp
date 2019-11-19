using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BillCreatePDF
    {
       public void CreateBillPDF()
        {
            using(FileStream stream = new FileStream(@"D:\\DemoBillPDF.pdf", FileMode.Create))
            {
                Document pdfDocument = new Document(PageSize.A4, 0.5f, 0.5f, 0.5f, 0.5f);

                PdfWriter.GetInstance(pdfDocument, stream);
                pdfDocument.Open();

                PdfPTable table = new PdfPTable(2);
                table.DefaultCell.Border = Rectangle.NO_BORDER;
                table.WidthPercentage = 100;

                PdfPCell cellLeft = new PdfPCell();
                Paragraph idOrder = new Paragraph("{ID Bill}");
                idOrder.Alignment = Element.ALIGN_LEFT;
                cellLeft.AddElement(idOrder);

                PdfPCell cellRight = new PdfPCell();
                Paragraph shopName = new Paragraph("{Cửa hàng Phát Triển Tương Lai}");
                idOrder.Alignment = Element.ALIGN_RIGHT;
                cellRight.AddElement(idOrder);
                table.AddCell(cellLeft);
                table.AddCell(cellRight);
                pdfDocument.Close();
                stream.Close();
            }

            System.Diagnostics.Process.Start(@"D:\\DemoBillPDF.pdf");

        }
    }
}

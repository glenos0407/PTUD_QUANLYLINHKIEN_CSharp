using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Model;
using System.Reflection;

namespace Dataaccess
{
    public class PDFCreateExtention
    {
        private readonly BaseFont fontRobotoMedium;
        private readonly BaseFont fontRobotoThin;
        private readonly BaseFont fontRobotoRegular;
        private readonly BaseFont fontRobotoBold;
        private readonly OrderPDFCreatingDTO orderPDF;
        public PDFCreateExtention(OrderPDFCreatingDTO _orderPDF)
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            outPutDirectory = outPutDirectory.Replace(@"\QUANLYLINHKIEN_PTUD\bin\Debug", @"\Model\Font");
            string directoryPath = new Uri(outPutDirectory).LocalPath;

            fontRobotoBold = BaseFont.CreateFont(directoryPath + @"\Roboto-Bold.ttf",
                BaseFont.IDENTITY_H,
                BaseFont.EMBEDDED);
            fontRobotoMedium = BaseFont.CreateFont(directoryPath + @"\Roboto-Medium.ttf",
                BaseFont.IDENTITY_H,
                BaseFont.EMBEDDED);
            fontRobotoRegular = BaseFont.CreateFont(directoryPath + @"\Roboto-Regular.ttf",
                BaseFont.IDENTITY_H,
                BaseFont.EMBEDDED);
            fontRobotoThin = BaseFont.CreateFont(directoryPath + @"\Roboto-Thin.ttf",
                BaseFont.IDENTITY_H,
                BaseFont.EMBEDDED);
            orderPDF = _orderPDF;
            CreateBillPDF();
        }
        private Paragraph CustomHeaderCell(string text)
        {
            Paragraph p = new Paragraph(new Chunk(text, new Font(fontRobotoMedium, 11)));
            p.Alignment = Element.ALIGN_CENTER;
            return p;
        }
        private Paragraph CustomCell(string text)
        {
            Paragraph p = new Paragraph(new Chunk(text, new Font(fontRobotoRegular, 11)));
            p.Alignment = Element.ALIGN_LEFT;
            return p;
        }
        private Paragraph CustomCellDG(string text)
        {
            Paragraph p = new Paragraph(new Chunk(text, new Font(fontRobotoBold, 11)));
            p.Alignment = Element.ALIGN_LEFT;
            return p;
        }
        private void AddHeaderCells(List<PdfPCell> cells, PdfPTable table)
        {
            for (int i = 0; i < cells.Count; i++)
                table.AddCell(AddCenterCells(cells[i]));
        }
        private void AddMemberCells(List<PdfPCell> cells, PdfPTable table)
        {
            for (int i = 0; i < cells.Count; i+=7)
            {
                table.AddCell(AddCenterCells(cells[i]));
                table.AddCell(AddLeftCells(cells[i + 1]));
                table.AddCell(AddCenterCells(cells[i + 2]));
                table.AddCell(AddCenterCells(cells[i + 3]));
                table.AddCell(AddRightCells(cells[i + 4])); 
                table.AddCell(AddRightCells(cells[i + 5]));
                table.AddCell(AddCenterCells(cells[i + 6]));
            }
            PdfPCell totalHeaderCell = new PdfPCell(CustomCell("Tổng Thành Tiền"));
            totalHeaderCell.Colspan = 5;
            table.AddCell(AddCenterCells(totalHeaderCell));

            PdfPCell totalCell = new PdfPCell(CustomCell(FormatNumber(orderPDF.Total)));
            table.AddCell(AddRightCells(totalCell));

            PdfPCell cell = new PdfPCell();
            table.AddCell(cell);
        }
        private PdfPCell AddCenterCells(PdfPCell cell)
        {
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_CENTER;
            return cell;
        } 
        private PdfPCell AddLeftCells(PdfPCell cell)
        {
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            return cell;
        }
        private PdfPCell AddRightCells(PdfPCell cell)
        {
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            return cell;
        }    
        private string ChangeNumbersToCharacters(string number)
        {
            string[] Ones = { "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười", "Mười Một", "Mười Hai", "Mười Ba",
                "Mười Bốn", "Mười Lăm", "Mười Sáu", "Mười Bảy", "Mười Tám", "Mười Chín" };
            string[] Tens = { "Mười", "Hai Mươi", "Ba Mươi", "Bốn Mươi", "Năm Mươi", "Sáu Mươi", "Bảy Mươi", "Tám Mươi", "Chín Mươi" };

            bool checkThousand = false;
            bool checkMilions = false;
            bool checkHundred = false;

            int no = int.Parse(number);
            string strWords = "";

            if (no > 999999999)
            {
                int i = no / 1000000000;
                strWords = strWords + Ones[i - 1] + " Tỷ ";
                no = no % 1000000000;
            }

            if (no > 99999999 && no < 1000000000)
            {
                int i = no / 100000000;
                strWords = strWords + Ones[i - 1] + " Trăm ";
                no = no % 100000000;
                checkMilions = true;
            }

            if (no > 9999999 && no < 100000000)
            {
                int i = no / 10000000;
                strWords = strWords + Tens[i - 1] + " ";
                no = no % 10000000;
                checkMilions = true;
            }
            else
            {
                if (checkMilions)
                    strWords += "Lẻ ";
            }

            if (no > 999999 && no < 10000000)
            {
                int i = no / 1000000;
                strWords = strWords + Ones[i - 1] + " Triệu ";
                no = no % 1000000;
            }

            if (!strWords.Contains("Triệu") && checkMilions)
                strWords += " Triệu ";

            if (no > 99999 && no < 1000000)
            {
                int i = no / 100000;
                strWords = strWords + Ones[i - 1] + " Trăm ";
                no = no % 100000;
                checkThousand = true;
            }

            if (no > 9999 && no < 100000)
            {
                int i = no / 10000;
                strWords = strWords + Tens[i - 1] + " ";
                no = no % 10000;
                checkThousand = true;
            }
            else
            {
                if (checkThousand)
                    strWords += "Lẻ ";
            }

            if (no > 999 && no < 10000)
            {
                int i = no / 1000;
                strWords = strWords + Ones[i - 1] + " Ngàn ";
                no = no % 1000;
            }


            if (!strWords.Contains("Ngàn") && checkThousand)
                strWords += "Ngàn ";

            if (no > 99 && no < 1000)
            {
                int i = no / 100;
                strWords = strWords + Ones[i - 1] + " Trăm ";
                no = no % 100;
                checkHundred = true;
            }

            if (no > 19 && no < 100)
            {
                int i = no / 10;
                strWords = strWords + Tens[i - 1] + " ";
                no = no % 10;
            }
            else
            {
                if (checkHundred)
                    strWords += "Lẻ ";
            }

            if (no > 0 && no < 20)
            {
                strWords = strWords + Ones[no - 1] + " ";
            }

            strWords = strWords.Replace("Mươi Năm", "Mươi Lăm");
            strWords += "VNĐ";
            return strWords;
        }
        private PdfPCell CreateCellSignature(string text)
        {
            PdfPCell cell = new PdfPCell();
            Paragraph elements = new Paragraph(text, new Font(fontRobotoMedium, 13));
            elements.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(elements);
            cell.Border = Rectangle.NO_BORDER;
            return cell;
        }
        private PdfPCell CreateCellMergeCol(int numberCol, string text)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text));
            //cell.H
            cell.Colspan = numberCol;
            cell.Border = Rectangle.NO_BORDER;
            cell.FixedHeight = 25;
            return cell;
        }
        private string FormatNumber(string number)
        {
            return string.Format("{0:###,###,###,###}", Convert.ToDouble(number));
        }
        public void CreateBillPDF()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            outPutDirectory = outPutDirectory.Replace(@"\QUANLYLINHKIEN_PTUD\bin\Debug", @"\Dataaccess\OrderPDF\BillPDF.pdf");
            string directoryPath = new Uri(outPutDirectory).LocalPath;

            using (FileStream stream = new FileStream(directoryPath, FileMode.Create))
            {
                Document pdfDocument = new Document(PageSize.A4, 0.5f, 0.5f, 0.5f, 0.5f);

                PdfWriter writer = PdfWriter.GetInstance(pdfDocument, stream);
                pdfDocument.Open();

                PdfPTable table1 = new PdfPTable(2);
                table1.DefaultCell.Border = Rectangle.NO_BORDER;
                table1.WidthPercentage = 98;

                PdfPCell cellLeft = new PdfPCell();
                Paragraph idOrder = new Paragraph("ID: " + orderPDF.Id, new Font(fontRobotoThin, 10));
                idOrder.Alignment = Element.ALIGN_LEFT;
                cellLeft.AddElement(idOrder);
                cellLeft.Border = Rectangle.NO_BORDER;

                PdfPCell cellRight = new PdfPCell();

                Paragraph shopName = new Paragraph("Cửa Hàng Linh Kiện Phát Triển Tương Lai", new Font(fontRobotoThin, 10));
                shopName.Alignment = Element.ALIGN_RIGHT;
                cellRight.AddElement(shopName);
                cellRight.Border = Rectangle.NO_BORDER;

                Paragraph title = new Paragraph("HÓA ĐƠN BÁN HÀNG", new Font(fontRobotoMedium, 24));
                title.SetLeading(0, 2);
                title.Alignment = Element.ALIGN_CENTER;

                Paragraph date = new Paragraph(DateTime.Now.ToString(), new Font(fontRobotoRegular, 12));
                date.Alignment = Element.ALIGN_CENTER;

                Phrase customerName = new Phrase();
                customerName.Add(
                    new Chunk("         Tên Khách Hàng:         ", new Font(fontRobotoMedium, 13))
                    );
                customerName.Add(
                    new Chunk(orderPDF.CustomerName + "\n", new Font(fontRobotoRegular, 13))
                    );
                customerName.SetLeading(0, 3);

                Phrase customerPhone = new Phrase();
                customerPhone.Add(
                    new Chunk("         SĐT Khách Hàng:        ", new Font(fontRobotoMedium, 13))
                    );
                customerPhone.Add(
                    new Chunk(orderPDF.CustomerPhone + "\n", new Font(fontRobotoRegular, 13))
                    );

                Phrase customerAddress = new Phrase();
                customerAddress.Add(
                    new Chunk("         Địa chỉ:                          ", new Font(fontRobotoMedium, 13))
                    );
                customerAddress.Add(
                    new Chunk(orderPDF.CustomerAddress + "\n", new Font(fontRobotoRegular, 13))
                    );

                Phrase staffName = new Phrase();
                staffName.Add(
                    new Chunk("         Nhân Viên Bán Hàng:  ", new Font(fontRobotoMedium, 13))
                    );
                staffName.Add(
                    new Chunk(orderPDF.StaffName + "\n", new Font(fontRobotoRegular, 13))
                    );

                PdfPTable table2 = new PdfPTable(7);
                table2.DefaultCell.Border = Rectangle.ALIGN_BASELINE;
                table2.WidthPercentage = 90;
                table2.TotalWidth = 550f;
                table2.LockedWidth = true;
                table2.SetWidths(new float[] { 30f, 240f, 30f, 30f, 80f, 120f, 20f });


                List<PdfPCell> cellHeaders = new List<PdfPCell> 
                {
                    new PdfPCell(CustomHeaderCell("STT")),
                    new PdfPCell(CustomHeaderCell("Tên Hàng")),
                    new PdfPCell(CustomHeaderCell("ĐVT")),
                    new PdfPCell(CustomHeaderCell("SL")),
                    new PdfPCell(CustomHeaderCell("Đơn Giá")),
                    new PdfPCell(CustomHeaderCell("Thành Tiền")),
                    new PdfPCell(CustomHeaderCell("ĐG"))
                };
                AddHeaderCells(cellHeaders, table2);
                
                int index = 0;
                List<PdfPCell> listCell = new List<PdfPCell>();
                foreach (var item in orderPDF.ListAccessory)
                {
                    index++;
                    listCell.Add(new PdfPCell(CustomCell(index.ToString())));
                    listCell.Add(new PdfPCell(CustomCell(item.Name)));
                    listCell.Add(new PdfPCell(CustomCell(item.CalculationUnit)));
                    listCell.Add(new PdfPCell(CustomCell(item.Quantity.ToString())));

                    string formater = FormatNumber(item.Price.ToString());
                    listCell.Add(new PdfPCell(CustomCell(formater)));

                    formater = FormatNumber(item.Total.ToString());
                    listCell.Add(new PdfPCell(CustomCell(formater)));

                    listCell.Add(new PdfPCell(CustomCellDG("X")));
                }
                AddMemberCells(listCell, table2);
                Paragraph moneyCharacters = new Paragraph(new Chunk("         * Viết bằng chữ: " + ChangeNumbersToCharacters(orderPDF.Total), new Font(fontRobotoMedium, 13)));

                Phrase payment = new Phrase();
                payment.Add(
                    new Chunk("         Hình Thức Thanh Toán Bằng Tiền Mặt Và Nhận Hàng Trực Tiếp Tại Cửa Hàng\n\n", new Font(fontRobotoMedium, 13))
                    );
                payment.SetLeading(0, 2);

                Phrase explaining = new Phrase();
                explaining.Add(
                    new Chunk("            * Giải thích viết tắt:\n" +
                    "                 ĐVT: Đơn Vị Tính\n" +
                    "                 SL: Số lượng\n" +
                    "                 ĐG: Đã Giao (Đánh dấu X vào ô khi đã giao hàng cho khách)", new Font(fontRobotoRegular, 10))
                    );

                PdfContentByte pcb = writer.DirectContent;

                PdfPTable tableSignature = new PdfPTable(3);
                tableSignature.TotalWidth = 560f;

                tableSignature.AddCell(CreateCellSignature("NGƯỜI LẬP HÓA ĐƠN"));
                tableSignature.AddCell(CreateCellSignature("KHÁCH HÀNG"));
                tableSignature.AddCell(CreateCellSignature("NHÂN VIÊN KHO"));

                tableSignature.AddCell(CreateCellMergeCol(3,""));
                tableSignature.AddCell(CreateCellMergeCol(3, ""));
                tableSignature.AddCell(CreateCellMergeCol(3, ""));                
                
                tableSignature.AddCell(CreateCellSignature(orderPDF.StaffName));
                tableSignature.AddCell(CreateCellSignature(""));
                tableSignature.AddCell(CreateCellSignature(""));

                tableSignature.WriteSelectedRows(0, -1, 0, 150, pcb);

                table1.AddCell(cellLeft);
                table1.AddCell(cellRight);

                pdfDocument.Add(table1);
                pdfDocument.Add(title);
                pdfDocument.Add(date);

                pdfDocument.Add(customerName);
                pdfDocument.Add(customerPhone);
                pdfDocument.Add(customerAddress);
                pdfDocument.Add(staffName);

                pdfDocument.Add(table2);

                pdfDocument.Add(moneyCharacters);
                pdfDocument.Add(payment);
                pdfDocument.Add(explaining);

                pdfDocument.Close();
                stream.Close();
            }
            System.Diagnostics.Process.Start(directoryPath);
        }
    }
}

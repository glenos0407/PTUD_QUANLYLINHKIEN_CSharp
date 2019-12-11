﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess
{
    public class OrderDAL : IOrderDAL
    {
        QuanLyLinhKienDBContext db;
        PDFCreateExtention pdfExtention;
        public OrderDAL()
        {
            db = new QuanLyLinhKienDBContext();
        }
        public int CreateOrder(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return order.Id;
        }
        public void PrintOrder(OrderPDFCreatingDTO orderPDF)
        {
            pdfExtention = new PDFCreateExtention(orderPDF);
            pdfExtention.CreateBillPDF();
        }
    }
}

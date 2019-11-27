using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Model
{
    public class AccessoryPDFCreatingDTO
    {
        public string Name { get; set; }
        public string CalculationUnit { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
    }
}
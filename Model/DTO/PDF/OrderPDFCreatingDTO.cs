using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Model
{
    public class OrderPDFCreatingDTO
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public string StaffName { get; set; }
        public string Total { get; set; }
        public List<AccessoryPDFCreatingDTO> ListAccessory { get; set; }
    }
}
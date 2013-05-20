using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemberSuite.SDK
{
    public class ExhibitBoothInfo
    {
        public string BoothID { get; set; }
        public string BoothName { get; set; }

        public string BoothProductID { get; set; }
        public string BoothProductName { get; set; }

        public string BoothTypeID { get; set; }
        public string BoothTypeName { get; set; }
        public decimal BoothCost { get; set; }
        public object UselessObject;
    }
}

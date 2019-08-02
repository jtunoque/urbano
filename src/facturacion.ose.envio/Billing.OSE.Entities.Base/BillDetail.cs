using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.OSE.Entities.Base
{
    public class BillDetail
    {
        public int Id { get; set; }

        public string Code { get; set; }
        public string Description { get; set; }
       
        public double Price { get; set; }

        public double Quantity { get; set; }

        public double TotalAmount { get; set; }
    }
}

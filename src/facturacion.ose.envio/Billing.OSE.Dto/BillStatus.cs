
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.OSE.Dto
{
    public class BillStatus
    {
        public string DocumentNumber { get; set; }
        public string ResponseCode { get; set; }
        public int Status { get; set; }
    }
}

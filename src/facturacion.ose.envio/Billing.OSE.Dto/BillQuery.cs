
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.OSE.Dto
{
    public class BillQuery
    {
        public string DocumentType { get; set; }
        public string DocumentTypeName
        {
            get
            {
                if (this.DocumentType == "01")
                    return "Factura";
                else if (this.DocumentType == "03")
                    return "Boleta";
                else
                    return "";
            }

        }
        public DateTime? DocumentIssueDate { get; set; }
        public string DocumentNumber { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string CDRFileName { get; set; }
        public int Status { get; set; }
        public string StatusDescription
        {
            get
            {
                if (this.Status == 1)
                    return "Correcto";
                else
                    return "Error";

            }
        }
        public DateTime SentDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.OSE.Entities.Base
{
    public class BillDocument
    {
        public int Id { get; set; }
        public string DocumentType { get; set; }
        public DateTime? DocumentIssueDate { get; set; }
        public string DocumentNumber { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string CDRFileName { get; set; }
        public int Status { get; set; }
        public DateTime SentDate { get; set; }

        public string CustomerDocumentType { get; set; }
        public string CustomerDocumentNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }

        public string InvoiceNote { get; set; }

        public string InvoiceCurrency { get; set; }

        public double TaxAmount { get; set; }

        public double TaxableAmount { get; set; }

        public double TotalAmount { get; set; }
    }
}

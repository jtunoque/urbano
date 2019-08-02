using System;

namespace Billing.OSE.Dto
{
    public class BillDocumentSummary
    {
        public DateTime DocumentIssueDate { get; set; }
        public DateTime DocumentIssueTime { get; set; }
        public string DocumentNumber { get; set; }
        public string CustomerDocumentType { get; set; }
        public string CustomerDocumentNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string InvoiceType { get; set; }
            
        public string InvoiceNote { get; set; }

        public string InvoiceCurrency { get; set; }

        public double TaxAmount { get; set; }

        public double TaxableAmount { get; set; }

        public double TotalAmount { get; set; }



    }
}
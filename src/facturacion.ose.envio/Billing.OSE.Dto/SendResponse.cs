using System;

namespace Billing.OSE.Dto
{
    public class SendResponse
    {
        public string DocumentType { get; set; }
        public DateTime DocumentIssueDate { get; set; }
        public DateTime DocumentIssueTime { get; set; }
        public string DocumentNumber { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public byte[] CDRFileContentZip { get; set; }
        public string CDRFileName { get; set; }
        public bool Success { get; set; }

    }
}
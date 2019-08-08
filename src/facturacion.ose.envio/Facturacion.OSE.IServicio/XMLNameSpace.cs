// ReSharper disable InconsistentNaming

namespace Billing.OSE.IService
{
    public static class XMLNameSpace
    {
        public const string xmlnsInvoice = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2";
        public const string xmlnsCreditNote = "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2";
        public const string xmlnsDebitNote = "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2";
        public const string xmlnsVoidedDocuments = "urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1";
        public const string xmlnsSummaryDocuments = "urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1";
        public const string xmlnsRetention = "urn:sunat:names:specification:ubl:peru:schema:xsd:Retention-1";
        public const string xmlnsPerception = "urn:sunat:names:specification:ubl:peru:schema:xsd:Perception-1";
        public const string xmlnsDespatchAdvice = "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2";
        public const string sac = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1";
        public const string cac = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2";
        public const string cbc = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2";
        public const string udt = "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2";
        public const string ccts = "urn:un:unece:uncefact:documentation:2";
        public const string ext = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2";
        public const string qdt = "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2";
        public const string ds = "http://www.w3.org/2000/09/xmldsig#";
        public const string xsi = "http://www.w3.org/2001/XMLSchema-instance";
        public const string ar = "urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2";
        public const string wssecurity =
            "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd";

        public const string nodoId = "/ar:ApplicationResponse/cbc:ID";
        public const string nodoResponseDate = "/ar:ApplicationResponse/cbc:ResponseDate";
        public const string nodoResponseTime = "ar:ApplicationResponse/cbc:ResponseTime";
        public const string nodoResponseCode =
            "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:ResponseCode";
        public const string nodoDescription =
            "/ar:ApplicationResponse/cac:DocumentResponse/cac:Response/cbc:Description";

        public const string nodoDocumentReferenceID =
            "/ar:ApplicationResponse/cac:DocumentResponse/cac:DocumentReference/cbc:ID";

        public const string nodoDocumentReferenceIssueDate =
            "/ar:ApplicationResponse/cac:DocumentResponse/cac:DocumentReference/cbc:IssueDate";

        public const string nodoDocumentReferenceIssueTime =
            "/ar:ApplicationResponse/cac:DocumentResponse/cac:DocumentReference/cbc:IssueTime";

        public const string nodoDocumentReferenceDocumentTypeCode =
            "/ar:ApplicationResponse/cac:DocumentResponse/cac:DocumentReference/cbc:DocumentTypeCode";

        public const string nodoInvoiceID =
           "/inv:Invoice/cbc:ID";

        public const string nodeInvoiceIssueDate =
           "/inv:Invoice/cbc:IssueDate";

        public const string nodeInvoiceIssueTime =
           "/inv:Invoice/cbc:IssueTime";

        public const string nodeCustomerID =
         "/inv:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyIdentification/cbc:ID";

        public const string nodeCustomerAssignedAccountID =
        "/inv:Invoice/cac:AccountingCustomerParty/cbc:CustomerAssignedAccountID";

        public const string nodeAdditionalAccountID =
       "/inv:Invoice/cac:AccountingCustomerParty/cbc:AdditionalAccountID";

        public const string nodeNote1 =
        "/inv:Invoice/cbc:Note";

        public const string nodeCustomerName =
         "/inv:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cbc:RegistrationName";

        public const string nodeCustomerAddress =
         "/inv:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyLegalEntity/cac:RegistrationAddress/cac:AddressLine/cbc:Line";

        public const string nodeTaxAmount =
         "/inv:Invoice/cac:TaxTotal/cbc:TaxAmount";

        public const string nodeTaxableAmount =
         "/inv:Invoice/cac:TaxTotal/cac:TaxSubtotal/cbc:TaxableAmount";

        public const string nodePayableAmount =
         "/inv:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount";

        public const string nodeInvoiceLine =
         "/inv:Invoice/cac:InvoiceLine";
    }
}
using Billing.OSE.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billing.OSE.Dto;
using System.Data.SqlClient;

namespace Billing.OSE.Data
{
    public class BillDocumentDA : DataAccess
    {
        public bool AddDocument(BillDocument entity)
        {
            bool result = false;
            string sql = "INSERT INTO BillDocument(DocumentType,DocumentNumber," +
                "DocumentIssueDate,ResponseCode,ResponseMessage,Status,CDRFileName,SentDate," +
                "CustomerDocumentType, CustomerDocumentNumber, CustomerName, CustomerAddress, InvoiceNote, InvoiceCurrency, TaxAmount, TaxableAmount, TotalAmount)" +
                " VALUES (@DocumentType,@DocumentNumber," +
                "@DocumentIssueDate,@ResponseCode,@ResponseMessage,@Status,@CDRFileName,@SentDate," +
                "@CustomerDocumentType,@CustomerDocumentNumber,@CustomerName,@CustomerAddress,@InvoiceNote,@InvoiceCurrency," +
                "@TaxAmount,@TaxableAmount,@TotalAmount)";

            using (IDbConnection cn = this.DBConnection)
            {
                cn.Open();
                var cmd = cn.CreateCommand();
                cmd.CommandText = sql;
                cmd.CommandTimeout = 120;

                cmd.Parameters.Add(new SqlParameter("@DocumentType", entity.DocumentType));
                cmd.Parameters.Add(new SqlParameter("@DocumentNumber", entity.DocumentNumber));
                cmd.Parameters.Add(new SqlParameter("@DocumentIssueDate", entity.DocumentIssueDate));


                if(string.IsNullOrWhiteSpace(entity.ResponseCode))                
                    cmd.Parameters.Add(new SqlParameter("@ResponseCode", DBNull.Value));
                else
                    cmd.Parameters.Add(new SqlParameter("@ResponseCode", entity.ResponseCode));

                if (string.IsNullOrWhiteSpace(entity.ResponseMessage))
                    cmd.Parameters.Add(new SqlParameter("@ResponseMessage", DBNull.Value));
                else
                    cmd.Parameters.Add(new SqlParameter("@ResponseMessage", entity.ResponseMessage));

                cmd.Parameters.Add(new SqlParameter("@Status", entity.Status));


                if (string.IsNullOrWhiteSpace(entity.CDRFileName))
                    cmd.Parameters.Add(new SqlParameter("@CDRFileName", DBNull.Value));
                else
                    cmd.Parameters.Add(new SqlParameter("@CDRFileName", entity.CDRFileName));

                cmd.Parameters.Add(new SqlParameter("@SentDate", entity.SentDate));
                cmd.Parameters.Add(new SqlParameter("@CustomerDocumentType", entity.CustomerDocumentType));
                cmd.Parameters.Add(new SqlParameter("@CustomerDocumentNumber", entity.CustomerDocumentNumber));
                cmd.Parameters.Add(new SqlParameter("@CustomerName", entity.CustomerName));

                if (string.IsNullOrWhiteSpace(entity.CustomerAddress))
                    cmd.Parameters.Add(new SqlParameter("@CustomerAddress", DBNull.Value));
                else
                    cmd.Parameters.Add(new SqlParameter("@CustomerAddress", entity.CustomerAddress));

                if (string.IsNullOrWhiteSpace(entity.InvoiceNote))
                    cmd.Parameters.Add(new SqlParameter("@InvoiceNote", DBNull.Value));
                else
                    cmd.Parameters.Add(new SqlParameter("@InvoiceNote", entity.InvoiceNote));

                if (string.IsNullOrWhiteSpace(entity.InvoiceCurrency))
                    cmd.Parameters.Add(new SqlParameter("@InvoiceCurrency", DBNull.Value));
                else
                    cmd.Parameters.Add(new SqlParameter("@InvoiceCurrency", entity.InvoiceCurrency));

                cmd.Parameters.Add(new SqlParameter("@TaxAmount", entity.TaxAmount));
                cmd.Parameters.Add(new SqlParameter("@TaxableAmount", entity.TaxableAmount));
                cmd.Parameters.Add(new SqlParameter("@TotalAmount", entity.TotalAmount));

                result = cmd.ExecuteNonQuery() > 0;
            }

            return result;
        }

        public List<BillQuery> GetDocuments(DateTime sentDate1, DateTime sentDate2, int status, string documentNumber)
        {
            documentNumber = string.IsNullOrWhiteSpace(documentNumber) ? "%" : $"%{documentNumber.Trim()}%";

            var result = new List<BillQuery>();
            string sql = "SELECT DocumentType,DocumentNumber," +
                "DocumentIssueDate,ResponseCode,ResponseMessage,Status,CDRFileName,SentDate " +
                " FROM BillDocument" +
                " WHERE (SentDate BETWEEN @sentDate1 AND @sentDate2) " +
                " AND (@status=0 OR Status=@status)" +
                " AND DocumentNumber LIKE @documentNumber " +
                " ORDER BY SentDate DESC, DocumentNumber DESC";

            using (IDbConnection cn = this.DBConnection)
            {
                cn.Open();
                var cmd = cn.CreateCommand();
                cmd.CommandText = sql;
                cmd.CommandTimeout = 120;
                cmd.Parameters.Add(
                    new SqlParameter("@sentDate1", sentDate1)
                    );

                cmd.Parameters.Add(
                    new SqlParameter("@sentDate2", sentDate2)
                    );

                cmd.Parameters.Add(
                    new SqlParameter("@status", status)
                    );

                cmd.Parameters.Add(
                    new SqlParameter("@documentNumber", documentNumber)
                    );

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var bill = new BillQuery();
                    bill.DocumentType = reader.GetString("DocumentType");
                    bill.DocumentNumber = reader.GetString("DocumentNumber");
                    bill.DocumentIssueDate = reader.GetDateTime("DocumentIssueDate");
                    bill.ResponseCode = reader.GetString("ResponseCode");
                    bill.ResponseMessage = reader.GetString("ResponseMessage");
                    bill.Status = reader.GetInt32("Status");
                    bill.CDRFileName = reader.GetString("CDRFileName");
                    bill.SentDate = reader.GetDateTime("SentDate");

                    result.Add(bill);
                }

            }

            return result;
        }

        public List<BillStatus> GetDocumentStatus(string documentType)
        {
            var result = new List<BillStatus>();
            string sql = "SELECT TOP 100000 DocumentNumber,ResponseCode,Status " +
                " FROM BillDocument" +
                " WHERE DocumentType = @documentType AND ResponseCode IS NULL " +
                " AND (DocumentIssueDate BETWEEN GETDATE()-60 AND GETDATE()) ";

            using (IDbConnection cn = this.DBConnection)
            {
                cn.Open();
                var cmd = cn.CreateCommand();
                cmd.CommandText = sql;
                cmd.CommandTimeout = 120;
                cmd.Parameters.Add(
                    new SqlParameter("@documentType", documentType)
                    );

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var bill = new BillStatus();
                    bill.DocumentNumber = reader.GetString("DocumentNumber");
                    bill.ResponseCode = reader.GetString("ResponseCode");
                    bill.Status = reader.GetInt32("Status");

                    result.Add(bill);
                }

            }

            return result;
        }
    }
}

using System;
using Billing.OSE.Dto;
using Billing.OSE.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InvoiceTest
{
    [TestClass]
    public class FormatUnitTest
    {
        [TestMethod]
        public void FormatInputXML()
        {
            byte[] fileContent = System.IO.File.ReadAllBytes(@"D:\URBANO\2019\2019\datos_signed\FT\20403667413-01-F008-00001443.xml");

            var serializator = new Serializator();
            BillDocumentSummary documentSummary = serializator.ReadDocumentXML(fileContent).Result;
        }
    }
}

using Billing.OSE.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.OSE.IServicio
{
    public interface IDocumentService:IService
    {
        Task<SendResponse> SendBill(SendRequest request);
    }
}

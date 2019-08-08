using Billing.OSE.Dto;
using Billing.OSE.IService;
using Billing.OSE.Service.OSE;
using Facturacion.OSE.IServicio;
using System;
using System.Configuration;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Billing.OSE.Service
{
    public class DocumentService : IDocumentService
    {
        private BizlinksOSEClient proxy;
        Serializator serializator = null;

        public Binding CreateBinding()
        {
            var binding = new BasicHttpBinding(BasicHttpSecurityMode.TransportWithMessageCredential);
            var elements = binding.CreateBindingElements();
            elements.Find<SecurityBindingElement>().IncludeTimestamp = false;
            return new CustomBinding(elements);
        }

        public void Initializate()
        {
            serializator = new Serializator();

            System.Net.ServicePointManager.UseNagleAlgorithm = true;
            System.Net.ServicePointManager.Expect100Continue = false;
            System.Net.ServicePointManager.CheckCertificateRevocationList = true;
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            string url = ConfigurationManager.AppSettings["oseWebServiceUrl"];
            string oseUser = ConfigurationManager.AppSettings["oseUser"];
            string osePassword = ConfigurationManager.AppSettings["osePassword"];
            proxy = new BizlinksOSEClient(CreateBinding(), new EndpointAddress(url))

            {
                ClientCredentials =
                {
                    UserName =
                    {
                        UserName = oseUser,
                        Password = osePassword
                    }
                }
            };
        }

        public async Task<SendResponse> SendBill(SendRequest request)
        {
            var response = new SendResponse();
            try
            {
                var content = Convert.FromBase64String(request.ContentFile);

                proxy.Open();
                var billingResponse = await proxy.sendBillAsync(request.FileName, content);

                proxy.Close();

                response = await serializator.BillingResponseFormat(billingResponse.applicationResponse);
                response.Success = true;
            }
            catch (FaultException ex)
            {
                //log.Error("Error al generar el documento:", ex);

                response.ResponseCode = ex.Message;
                int errorCode = 0;

                if (int.TryParse(response.ResponseCode, out errorCode)
                    && BillingConstant.SunatErrors.ContainsKey(errorCode))
                {
                    response.ResponseMessage = BillingConstant.SunatErrors[errorCode];
                }
                else
                {
                    response.ResponseMessage = $"SUNAT error: {ex.Message}";
                }
            }
            catch (Exception ex)
            {
                //log.Error("Error al generar el documento:", ex);
                var msg = string.Concat(ex.InnerException?.Message, ex.Message);
                if (msg.Contains("<faultcode>"))
                {
                    var position = msg.IndexOf("<faultcode>", StringComparison.Ordinal);
                    var errorCode = msg.Substring(position + "<faultcode>".Length, 4);
                    msg = $"El Código de Error es {errorCode}";
                    response.ResponseCode = errorCode;
                }
                response.ResponseCode = null;
                response.ResponseMessage = msg;
            }

            return response;
        }
    }
}
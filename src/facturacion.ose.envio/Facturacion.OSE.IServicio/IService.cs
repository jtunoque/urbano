using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.OSE.IServicio
{
    public interface IService
    {
        Binding CreateBinding();
        
        void Initializate();
    }
}

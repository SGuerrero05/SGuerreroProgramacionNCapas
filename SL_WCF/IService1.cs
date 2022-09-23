using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SL_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string Saludar(string nombre);

        [OperationContract]

        int Suma(int Numero1, int Numero2);

        [OperationContract]

        int Resta(int Numero1, int Numero2);

        [OperationContract]

        int Multipicacion(int Numero1, int Numero2);

        [OperationContract]

        int Division(int Numero1, int Numero2);


        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.

}

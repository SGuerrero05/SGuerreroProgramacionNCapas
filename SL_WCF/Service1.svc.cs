﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SL_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string Saludar(string Nombre)
        {
            return "Hola " + Nombre;
        }

        public int Suma(int Numero1, int Numero2)
        {
            return Numero1 + Numero2;
        }

        public int Resta(int Numero1, int Numero2)
        {
            return Numero1 - Numero2;
        }
        

        public int Multipicacion(int Numero1, int Numero2)
        {
            return Numero1 * Numero2;
        }

        public int Division(int Numero1, int Numero2)
        {
            return Numero1 / Numero2;
        }


    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Registro de Usuarios");
            Console.WriteLine("1.Agregar");
            Console.WriteLine("2.Eliminar");
            Console.WriteLine("3.Modificar");
            Console.WriteLine("4. Operaciones y saludo");
            Console.WriteLine("5.Consultar");
            Console.WriteLine("6.ConsultarPorId");
            //Console.WriteLine("6. Registro de aseguradoras");
            //Console.WriteLine("7. Eliminar Registro de aseguradoras");
            //Console.WriteLine("8. Actualizar Registro en aseguradoras");
            //Console.WriteLine("9. Consultar Aseguradoras");
            //Console.WriteLine("10. Consultar Aseguradoras por ID");
            int opcion;
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {

                case 1:
                    PL.Usuario.Add();
                    break;

                case 2:
                    PL.Usuario.Delete();
                    break;

                case 3:
                    PL.Usuario.Update();
                    break;

                case 4:
                    PL.Usuario.Operaciones();
                    break;
                case 5:
                    PL.Usuario.GetAll();
                    break;

                case 6:
                    PL.Usuario.GetById();
                    break;

                    //    case 7:
                    //        PL.Aseguradora.AseguradoraDeleteEF();
                    //        break;

                    //    case 8:
                    //        PL.Aseguradora.AseguradoraUpdateEF();
                    //        break;

                    //    case 9:
                    //        PL.Aseguradora.AseguradoraGetAllEF();
                    //        break;

                    //    case 10:
                    //        PL.Aseguradora.AseguradoraGetByIdEF();
                    //        break;

                    //}
            }

        }
    }
}


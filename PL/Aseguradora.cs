using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public  class Aseguradora
    {
        public static void AseguradoraAddEF()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            Console.WriteLine("Ingrese el Nombre de la Aseguradora: ");
            aseguradora.Nombre = Console.ReadLine();

            aseguradora.Usuario = new ML.Usuario();

            Console.WriteLine("Ingrese el IdUsuario ");
            aseguradora.Usuario.IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Aseguradora.AseguradoraAddEF(aseguradora);

            if (result.Correct)
            {
                Console.WriteLine("Registro exitoso");
            }
            else
            {
                Console.WriteLine("Ocurrio un error");
            }
            Console.ReadKey();
        }
        public static void AseguradoraDeleteEF()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            Console.WriteLine("Ingrese el Id de la aseguradora que desee eliminar");
            aseguradora.IdAseguradora =int.Parse(Console.ReadLine());
            ML.Result result = BL.Aseguradora.AseguradoraDeleteEF(aseguradora);

            if (result.Correct)
            {
                Console.WriteLine("Se elimino correctemente");
            }
            else
            {
                Console.WriteLine("Ocurrio un error");
            }
            Console.ReadKey();
        }

        public static void AseguradoraUpdateEF()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            Console.WriteLine("Modifique el nombre de la Aseguradora");
            aseguradora.Nombre = Console.ReadLine();

            aseguradora.Usuario = new ML.Usuario();

            Console.WriteLine("Ingrese el Id del Usuario que desee modificar en Aseguradora");
            aseguradora.Usuario.IdUsuario =int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Id de la aseguradora que desee modificar");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());

            ML.Result result = BL.Aseguradora.AseguradoraUpdateEF(aseguradora);

            if (result.Correct)
            {
                Console.WriteLine("Dato actualizado con exito");
            }
            else
            {
                Console.WriteLine("Ocurrio un error al actualizar el dato");
            }
            Console.ReadKey();
        }

        public static void AseguradoraGetAllEF()
        {
            ML.Result result = BL.Aseguradora.AseguradoraGetAllEF();    
            if (result.Correct)
            {
                foreach(ML.Aseguradora aseguradora in result.Objects)
                {
                    Console.WriteLine("IdAseguradora: " + aseguradora.IdAseguradora);
                    Console.WriteLine("Nombre: " + aseguradora.Nombre);
                    Console.WriteLine("FechaCreacion: " + aseguradora.FechaCreacion);
                    Console.WriteLine("FechaModificacion: " + aseguradora.FechaModificacion);
                    Console.WriteLine("IdUsuario: " + aseguradora.Usuario.IdUsuario);
                    Console.WriteLine("------------------------------------------------");

                }
            }
            else
            {
                Console.WriteLine("Ocurrio un error en la consulta");
            }
            Console.ReadKey();
        }

        public static void AseguradoraGetByIdEF()
        {
            Console.WriteLine("Ingrese el Id a consultar: ");
            ML.Result result = BL.Aseguradora.AseguradoraGetByIdEF(int.Parse(Console.ReadLine()));
            if (result.Correct)
            {
                ML.Aseguradora aseguradora = ((ML.Aseguradora)result.Object);
                Console.WriteLine("IdAseguradora: " + aseguradora.IdAseguradora);
                Console.WriteLine("Nombre: "+ aseguradora.Nombre);
                Console.WriteLine("FechaCreacion: " + aseguradora.FechaCreacion);
                Console.WriteLine("FechaModificacion: " + aseguradora.FechaModificacion);
                Console.WriteLine("IdUsuario: "+ aseguradora.Usuario.IdUsuario);
            }
            else
            {
                Console.WriteLine("Ocurrior un error en la consulta");

            }
            Console.ReadKey ();
        }
    }


    }
        

        
    


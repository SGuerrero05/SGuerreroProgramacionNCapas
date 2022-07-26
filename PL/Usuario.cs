using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        public static void Add()
        {
            ML.Usuario usuario = new ML.Usuario();


            Console.WriteLine("Ingrese el Nombre");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el ApellidoPaterno");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingrese el ApellidoMaterno");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingrese su Email");
            usuario.Email = Console.ReadLine();

            ML.Result result = BL.Usuario.Add(usuario);

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
        public static void Delete()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingrese el IdUsuario que desee borrar");
            usuario.IdUsuario = int.Parse(Console.ReadLine());
            ML.Result result = BL.Usuario.Delete(usuario);

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
        public static void Update()
        {
            ML.Usuario usuario = new ML.Usuario();


            Console.WriteLine("Modifique el Nombre");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Modifique el ApellidoPaterno");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Modifique el ApellidoMaterno");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Modifique su Email");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingrese el IdUsuario que desee modificar");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.Update(usuario);

            if (result.Correct)
            {
                Console.WriteLine("Dato actualizado con exito");
            }
            else
            {
                Console.WriteLine("Ocurrio un error");
            }
            Console.ReadKey();
        }
        public static void AddLINQ()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingrese el Nombre");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el ApellidoPaterno");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingrese el ApellidoMaterno");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingrese su Email");
            usuario.Email = Console.ReadLine();

            usuario.Rol = new ML.Rol();

            Console.WriteLine("Ingrese el Id del Rol");
            usuario.Rol.IdRol = byte.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su UserName");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingrese su Password");
            usuario.Password = Console.ReadLine();

            Console.WriteLine("Ingrese su Sexo");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Ingrese su Telefono");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingrese su Celular");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Ingrese su FechaDeNacimiento");
            usuario.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Ingrese su CURP");
            usuario.CURP = Console.ReadLine();

            Console.WriteLine("Inserte una imagen");
            usuario.Imagen = null;

            ML.Result result = BL.Usuario.AddLINQ(usuario);

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
        public static void DeleteLINQ()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingrese el IdUsuario que desee borrar");
            usuario.IdUsuario = int.Parse(Console.ReadLine());
            ML.Result result = BL.Usuario.DeleteLINQ(usuario);

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
        public static void UpdateLINQ()
        {
            ML.Usuario usuario = new ML.Usuario();


            Console.WriteLine("Modifique su Nombre");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Modifique su ApellidoPaterno");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Modifique su ApellidoMaterno");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Modifique su Email");
            usuario.Email = Console.ReadLine();

            usuario.Rol = new ML.Rol();

            Console.WriteLine("Ingrese el Id del Rol que desee modificar");
            usuario.Rol.IdRol = byte.Parse(Console.ReadLine());

            Console.WriteLine("Modifique su UserName");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Modifique su Password");
            usuario.Password = Console.ReadLine();

            Console.WriteLine("Modifique su Sexo");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Modifique su Telefono");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Modifique su Celular");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Modifique su FechaDeNacimiento");
            usuario.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Modifique su CURP");
            usuario.CURP = Console.ReadLine();

            Console.WriteLine("Modifique su imagen");
            usuario.Imagen = null;

            Console.WriteLine("Ingrese el Id del Usuario que desee modificar");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.UpdateLINQ(usuario);

            if (result.Correct)
            {
                Console.WriteLine("Dato actualizado con exito");
            }
            else
            {
                Console.WriteLine("Ocurrio un error");
            }
            Console.ReadKey();
        }
        public static void GetAllEF()

        {
            ML.Result result = BL.Usuario.GetAllEF();
            if (result.Correct)
            {
                foreach(ML.Usuario usuario in result.Objects)
                {
                    Console.WriteLine("IdUsuario: "+usuario.IdUsuario);
                    Console.WriteLine("Nombre: "+usuario.Nombre);
                    Console.WriteLine("ApellidoPaterno: "+usuario.ApellidoPaterno);
                    Console.WriteLine("ApellidoMaterno: " + usuario.ApellidoMaterno);
                    Console.WriteLine("Email: "+usuario.Email);
                    Console.WriteLine("IdRol: "+usuario.Rol.IdRol);
                    Console.WriteLine("NombreRol: " + usuario.Rol.Nombre);
                    Console.WriteLine("UserName: "+usuario.UserName);
                    Console.WriteLine("Password: " + usuario.Password);
                    Console.WriteLine("Sexo: " + usuario.Sexo);
                    Console.WriteLine("Telefono: " + usuario.Telefono);
                    Console.WriteLine("Celular: "+usuario.Celular);
                    Console.WriteLine("FechaNacimiento: " + usuario.FechaNacimiento);
                    Console.WriteLine("CURP: "+usuario.CURP);
                    Console.WriteLine("Imagen: "+usuario.Imagen);

                    Console.WriteLine("----------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Ocurrio un error con la consulta");
            }
            Console.ReadKey();
        }
        public static void GetByIdLINQ()
        {
            Console.WriteLine("Ingrese el Id a consultar: ");
            ML.Result result = BL.Usuario.GetByIdLINQ(int.Parse(Console.ReadLine()));
            if (result.Correct)
            {
                ML.Usuario usuario = ((ML.Usuario)result.Object);
                Console.WriteLine("IdUsuario: " + usuario.IdUsuario);
                Console.WriteLine("Nombre: " + usuario.Nombre);
                Console.WriteLine("ApellidoPaterno: " + usuario.ApellidoPaterno);
                Console.WriteLine("ApellidoMaterno: " + usuario.ApellidoMaterno);
                Console.WriteLine("Email: " + usuario.Email);
                Console.WriteLine("IdRol: " + usuario.Rol.IdRol);
                Console.WriteLine("UserName: " + usuario.UserName);
                Console.WriteLine("Password: " + usuario.Password);
                Console.WriteLine("Sexo: " + usuario.Sexo);
                Console.WriteLine("Telefono: " + usuario.Telefono);
                Console.WriteLine("Celular: " + usuario.Celular);
                Console.WriteLine("FechaNacimiento: " + usuario.FechaNacimiento);
                Console.WriteLine("CURP: " + usuario.CURP);
                Console.WriteLine("Imagen: " + usuario.Imagen);
            }
            else
            {
                Console.WriteLine("Ocurrio un error al realizar la consulta"+result.ErrorMessage);
            }
            Console.ReadKey();
        }

    }
   
    
}
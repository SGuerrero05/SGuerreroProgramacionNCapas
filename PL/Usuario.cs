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

            usuario.Rol = new ML.Rol();
            Console.WriteLine("Ingrese su IdRol");
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

            Console.WriteLine("Ingrese su Fecha de Nacimiento");
            usuario.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Ingrese su CURP");
            usuario.CURP = Console.ReadLine();

            Console.WriteLine("Ingrese su Imagen");
            usuario.Imagen = Console.ReadLine();

            usuario.Direccion = new ML.Direccion();

            Console.WriteLine("Ingrese su Calle");
            usuario.Direccion.Calle = Console.ReadLine();

            Console.WriteLine("Ingrese su Numero Interior");
            usuario.Direccion.NumeroInterior = Console.ReadLine();

            Console.WriteLine("Ingrese su Numero Exterior");
            usuario.Direccion.NumeroExterior = Console.ReadLine();

            usuario.Direccion.Colonia = new ML.Colonia();
            Console.WriteLine("Ingrese su IdColonia");
            usuario.Direccion.Colonia.IdColonia = int.Parse(Console.ReadLine());

            usuario.Status = true;

            UsuarioReference.UsuarioClient obj = new UsuarioReference.UsuarioClient();

            var result = obj.AddEF(usuario);

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
            
            UsuarioReference.UsuarioClient obj = new UsuarioReference.UsuarioClient();
            
            var result = obj.DeleteEF(usuario.IdUsuario);

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

            usuario.Rol = new ML.Rol();

            Console.WriteLine("Modifique su IdRol");
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

            Console.WriteLine("Modifique su Fecha de Nacimiento");
            usuario.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Modifique su CURP");
            usuario.CURP = Console.ReadLine();

            Console.WriteLine("Modifique su Imagen");
            usuario.Imagen = Console.ReadLine();

            usuario.Direccion = new ML.Direccion();

            Console.WriteLine("Modifique su Calle");
            usuario.Direccion.Calle = Console.ReadLine();

            Console.WriteLine("Modifique su Numero Interior");
            usuario.Direccion.NumeroInterior = Console.ReadLine();

            Console.WriteLine("Modifique su Numero Exterior");
            usuario.Direccion.NumeroExterior = Console.ReadLine();

            usuario.Direccion.Colonia = new ML.Colonia();
            Console.WriteLine("Modifique su IdColonia");
            usuario.Direccion.Colonia.IdColonia = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el IdUsuario que desee modificar");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            UsuarioReference.UsuarioClient obj = new UsuarioReference.UsuarioClient();

            var result = obj.UpdateEF(usuario);

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
        public static void GetAll()

        {
            UsuarioReference.UsuarioClient obj = new UsuarioReference.UsuarioClient();

            var result = obj.GetAllEF();
            if (result.Correct)
            {
                foreach (ML.Usuario usuario in result.Objects)
                {
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
                    Console.WriteLine("Calle: " + usuario.Direccion.Calle);
                    Console.WriteLine("Numero Exterior: " + usuario.Direccion.NumeroExterior);
                    Console.WriteLine("Numero Interior: " + usuario.Direccion.NumeroInterior);
                    Console.WriteLine("Colonia: " + usuario.Direccion.Colonia.Nombre);
                    Console.WriteLine("Codigo Postal: " + usuario.Direccion.Colonia.CodigoPostal);
                    Console.WriteLine("Municipio: " + usuario.Direccion.Colonia.Municipio.Nombre);
                    Console.WriteLine("Estado: " + usuario.Direccion.Colonia.Municipio.Estado.Nombre);
                    Console.WriteLine("Pais: " + usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre);
                    Console.WriteLine("Status: " + usuario.Status);

                    Console.WriteLine("----------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Ocurrio un error con la consulta");
            }
            Console.ReadKey();
        }
        public static void GetById()

        {
            ML.Usuario usuarioGet = new ML.Usuario();
            Console.WriteLine("Ingrese el IdUsuario que desee Consultar");
            usuarioGet.IdUsuario = int.Parse(Console.ReadLine());
            UsuarioReference.UsuarioClient obj = new UsuarioReference.UsuarioClient();

            var result = obj.GetByIdEF(usuarioGet.IdUsuario);
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
                Console.WriteLine("Calle: " + usuario.Direccion.Calle);
                Console.WriteLine("Numero Exterior: " + usuario.Direccion.NumeroExterior);
                Console.WriteLine("Numero Interior: " + usuario.Direccion.NumeroInterior);
                Console.WriteLine("Colonia: " + usuario.Direccion.Colonia.Nombre);
                Console.WriteLine("Codigo Postal: " + usuario.Direccion.Colonia.CodigoPostal);
                Console.WriteLine("Municipio: " + usuario.Direccion.Colonia.Municipio.Nombre);
                Console.WriteLine("Estado: " + usuario.Direccion.Colonia.Municipio.Estado.Nombre);
                Console.WriteLine("Pais: " + usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre);
                Console.WriteLine("Status: " + usuario.Status);

            }
            else
            {
                Console.WriteLine("Ocurrio un error al realizar la consulta" + result.ErrorMessage);
            }
            Console.ReadKey();
        }
        public static void Operaciones()
        {
            ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
            string result = obj.Saludar("Salvador");

            Console.WriteLine(result);
            int Numero1 = 5;
            int Numero2 = 5;

            int resultSuma = obj.Suma(Numero1, Numero2);
            int resultResta = obj.Resta(Numero1, Numero2);
            int resultMultiplicacion = obj.Multipicacion(Numero1, Numero2);
            int resultDivision = obj.Division(Numero1, Numero2);

            Console.WriteLine("La Suma es: " + resultSuma);
            Console.WriteLine("La Resta es: " + resultResta);
            Console.WriteLine("La Multiplicacion es: " + resultMultiplicacion);
            Console.WriteLine("La Division es: " + resultDivision);



            Console.ReadKey();
        }

        

    }


}
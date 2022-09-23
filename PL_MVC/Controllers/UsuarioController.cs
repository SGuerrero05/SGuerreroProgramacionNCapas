using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Usuario usuario = new ML.Usuario();
            UsuarioReference.UsuarioClient obj = new UsuarioReference.UsuarioClient();

            var result = obj.GetAllEF();
            if (result.Correct)
            {
                usuario.Usuarios = result.Objects.ToList();
            }
            else
            {
                result.Correct = false;
                ViewBag.Mensaje = "Fallo la consulta";
            }
            return View(usuario);
        }

        [HttpPost]
        public ActionResult GetAll(ML.Usuario usuario)
        {
            ML.Result result = BL.Usuario.GetAllEF(usuario);

            if (result.Correct)
            {
                usuario.Usuarios = result.Objects;
            }
            else
            {
                result.Correct = false;
                ViewBag.Mensaje = "Fallo la consulta";
            }
            return View(usuario);
        }


        [HttpGet]
        public ActionResult Form(int? IdUsuario)
        {
            ML.Usuario usuario = new ML.Usuario();
            usuario.Rol = new ML.Rol();
            ML.Result resultRol = BL.Rol.RolGetAll();
            ML.Result resultPais = BL.Pais.PaisGetAll();
 

            if (resultRol.Correct && resultPais.Correct)
            {
                if (IdUsuario == null)

                {
                    usuario.Rol = new ML.Rol();
                    usuario.Rol.Roles = resultRol.Objects;
                    usuario.Direccion = new ML.Direccion();
                    usuario.Direccion.Colonia = new ML.Colonia();
                    usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                    usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                    usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                    usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;

                    return View(usuario);
                }

                else

                {
                    UsuarioReference.UsuarioClient obj = new UsuarioReference.UsuarioClient();
                    var result = obj.GetByIdEF(IdUsuario.Value);
                    if (result.Correct)
                    {

                        usuario = (ML.Usuario)result.Object;
                        ML.Result resultColonia = BL.Colonia.GetByIdMunicipio(usuario.Direccion.Colonia.IdColonia);
                        ML.Result resultMunicipio = BL.Municipio.GetByIdEstado(usuario.Direccion.Colonia.Municipio.IdMunicipio);
                        ML.Result resultEstado = BL.Estado.GetByIdPais(usuario.Direccion.Colonia.Municipio.Estado.IdEstado);
                        
    
                        usuario.Rol.Roles = resultRol.Objects;
                        usuario.Direccion.Colonia.Colonias = resultColonia.Objects;
                        usuario.Direccion.Colonia.Municipio.Municipios = resultMunicipio.Objects;
                        usuario.Direccion.Colonia.Municipio.Estado.Estados = resultEstado.Objects;
                        usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;
                        return View(usuario);

                    }
                    else
                    {
                        ViewBag.Mensaje = "Ocurrio un error";
                        return View("Modal");
                    }
                                                          
                }
            }
            else
            {
                ViewBag.Mensaje = "Ocurrio un error de consulta";
            }
            return View(usuario);
        }


        [HttpPost]
        public ActionResult Form(ML.Usuario usuario)
        {

            if (usuario.IdUsuario == 0) 
            {
                UsuarioReference.UsuarioClient obj = new UsuarioReference.UsuarioClient();
                var result = obj.AddEF(usuario);

                if (result.Correct)
                {
                    ViewBag.Mensaje = "Registro exitoso";
                }
                else
                {
                    ViewBag.Mensaje = "Ocurrio un error" + result.ErrorMessage;
                }
            }
            else
            {
                UsuarioReference.UsuarioClient obj = new UsuarioReference.UsuarioClient();
                var result = obj.UpdateEF(usuario);

                if (result.Correct)
                {
                    ViewBag.Mensaje = "Modiciacion exitosa";
                }
                else
                {
                    ViewBag.Mensaje = "Ocurrio un error";
                }
                
            }
            return View("Modal");
        }

        [HttpGet]
        public ActionResult Delete(int IdUsuario)
        {
            ML.Usuario usuario = new ML.Usuario();

            usuario.IdUsuario = IdUsuario;

            UsuarioReference.UsuarioClient obj = new UsuarioReference.UsuarioClient();

            var result = obj.DeleteEF(usuario.IdUsuario);

            if (result.Correct)
            {
                ViewBag.Mensaje = "El registro se elimino correctamente";
            }
            else
            {
                ViewBag.Mensaje = "Ocurrio un error";
            }
            return View("Modal");

        }

        public JsonResult EstadoGetByIdPais (int IdPais)
        {
            ML.Result result = BL.Estado.GetByIdPais(IdPais);
            return Json(result.Objects,JsonRequestBehavior.AllowGet);
        }

        public JsonResult MunicipioGetByIdEstado(int IdEstado)
        {
            ML.Result result = BL.Municipio.GetByIdEstado(IdEstado);
            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ColoniaGetByIdMunicipio(int IdMunicipio)
        {
            ML.Result result = BL.Colonia.GetByIdMunicipio(IdMunicipio);
            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }

    }
       
}
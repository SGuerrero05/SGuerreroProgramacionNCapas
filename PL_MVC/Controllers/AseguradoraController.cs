using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class AseguradoraController : Controller
    {
        [HttpGet]
        public ActionResult GetAllAseguradora()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            ML.Result result = BL.Aseguradora.AseguradoraGetAllEF();
            if (result.Correct)
            {
                aseguradora.Aseguradoras = result.Objects;
            }
            else
            {
                result.Correct = false;
                ViewBag.Mensaje = "Fallo la consulta";
            }
            return View(aseguradora);
        }
        [HttpGet]

        public ActionResult FormAseguradora(int? IdAseguradora)
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            aseguradora.Usuario = new ML.Usuario();
            ML.Result resultUsuario = BL.Usuario.GetAllEF();
            if (resultUsuario.Correct)
            {
                if(IdAseguradora == null)
                {
                    ML.Result result = BL.Aseguradora.AseguradoraAddEF(aseguradora);
                    aseguradora.Usuario.Usuarios = resultUsuario.Objects;
                    return View(aseguradora);
                }
                else
                {
                    ML.Result result = BL.Aseguradora.AseguradoraGetByIdEF(IdAseguradora.Value);
                    if (result.Correct)
                    {
                        aseguradora.Usuario = new ML.Usuario();
                        aseguradora = (ML.Aseguradora)result.Object;
                        aseguradora.Usuario.Usuarios=resultUsuario.Objects;
                    }
                    else
                    {
                        ViewBag.Mensaje = "Ocurrio un error";
                    }
                }
            }
            return View(aseguradora);
        }

        [HttpPost] 
        public ActionResult FormAseguradora (ML.Aseguradora aseguradora)
        {
            if (aseguradora.IdAseguradora == 0)
            {
                ML.Result result = BL.Aseguradora.AseguradoraAddEF(aseguradora);
                ViewBag.Mensaje = "Registro exitoso";
            }
            else
            {
                ML.Result result = BL.Aseguradora.AseguradoraUpdateEF(aseguradora);
                ViewBag.Mensaje = "Modificacion exitosa";
            }
            return View("ModalAseguradora");
        }



        [HttpGet]
        public ActionResult DeleteAseguradora(int IdAseguradora)
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            aseguradora.IdAseguradora = IdAseguradora;
            ML.Result result = BL.Aseguradora.AseguradoraDeleteEF(aseguradora);
            if (result.Correct)
            {
                ViewBag.Mensaje = "Se elimino correctamente";
            }
            else
            {
                ViewBag.Mensaje = "Ocurrio un error";
            }
            return View("ModalAseguradora");
        }
    }
    }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Aseguradora
    {
        public static ML.Result AseguradoraAddEF (ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result ();
            try
            {
                    using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
                {
                    var query = context.AseguradoraAdd(aseguradora.Nombre, aseguradora.Usuario.IdUsuario,aseguradora.Imagen);
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se ingreso el registro en aseguradora";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct=false;
                result.ErrorMessage=ex.Message;
            }
            return result;

        }

        public static ML.Result AseguradoraDeleteEF (ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result ();
            try
            {
                using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
                {
                    var query = context.AseguradoraDelete(aseguradora.IdAseguradora);
                    if (query > 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct =false;
                        result.ErrorMessage = "No se elimino el registro de la tabala Aseguradora ";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct=false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result AseguradoraUpdateEF (ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
                {
                    var query = context.AseguradoraUpdate(aseguradora.IdAseguradora, aseguradora.Nombre, aseguradora.Usuario.IdUsuario,aseguradora.Imagen);
                    if (query >=1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage=("No se actualizo el registro de la tabla Aseguradoras");

                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result AseguradoraGetAllEF()
        {
            ML.Result result = new ML.Result ();
            try
            {
                using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
                {
                    var query = context.AseguradoraGetAll().ToList();
                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Aseguradora aseguradora = new ML.Aseguradora();
                            aseguradora.IdAseguradora = obj.IdAseguradora;
                            aseguradora.Nombre = obj.Nombre;
                            aseguradora.FechaCreacion = obj.FechaCreacion.ToString();
                            aseguradora.FechaModificacion = obj.FechaModificacion.ToString();
                            aseguradora.Usuario = new ML.Usuario();
                            aseguradora.Usuario.IdUsuario = obj.IdUsuario.Value;
                          

                            result.Objects.Add(aseguradora);  
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Fallo la consulta";
                    }
                }

            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage= ex.Message;
            }
            return result;
        }

        public static ML.Result AseguradoraGetByIdEF(int IdAseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
                {
                    var obj = context.AseguradoraGetById(IdAseguradora).FirstOrDefault();
                    result.Objects = new List<object>();
                    if (obj != null)
                    {
                        ML.Aseguradora aseguradora = new ML.Aseguradora();
                        aseguradora.IdAseguradora = obj.IdAseguradora;
                        aseguradora.Nombre = obj.Nombre;
                        aseguradora.FechaCreacion = obj.FechaCreacion.ToString();
                        aseguradora.FechaModificacion = obj.FechaModificacion.ToString();
                        aseguradora.Usuario = new ML.Usuario();
                        aseguradora.Usuario.IdUsuario = obj.IdUsuario.Value;

                        result.Object = aseguradora;
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct =false;
                        result.ErrorMessage = "Ocurrio un error de consulta";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct=false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

    }
}

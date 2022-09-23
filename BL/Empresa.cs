using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Empresa
    {
        public static ML.Result EmpresaAdd(ML.Empresa empresa)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
                {
                    var query = context.EmpresaAdd (empresa.Nombre, empresa.Telefono, empresa.Email, empresa.DireccionWeb, empresa.Logo);
                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;

        }

        public static ML.Result EmpresaUpdate(ML.Empresa empresa)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
                {
                    var query = context.EmpresaUpdate(empresa.IdEmpresa, empresa.Nombre, empresa.Telefono, empresa.Email, empresa.DireccionWeb, empresa.Logo);
                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;

        }

        public static ML.Result EmpresaDelete(ML.Empresa empresa)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
                {
                    var query = context.EmpresaDelete(empresa.IdEmpresa);
                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;

        }

        public static ML.Result EmpresaGetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
                {
                    var query = context.EmpresaGetAll().ToList();
                    result.Objects = new List<object>();
                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Empresa empresa = new ML.Empresa();

                            empresa.IdEmpresa = obj.IdEmpresa;
                            empresa.Nombre = obj.Nombre;
                            empresa.Telefono = obj.Telefono;
                            empresa.Email = obj.Email;
                            empresa.DireccionWeb = obj.DireccionWeb;
                            empresa.Logo = obj.Logo;

                            result.Objects.Add(empresa);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;

        }

        public static ML.Result EmpresaGetById(int IdEmpresa)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
                {
                    var obj = context.EmpresaGetById(IdEmpresa).FirstOrDefault();

                    if (obj != null)
                    {
                        ML.Empresa empresa = new ML.Empresa();

                        empresa.IdEmpresa = obj.IdEmpresa;
                        empresa.Nombre = obj.Nombre;
                        empresa.Telefono = obj.Telefono;
                        empresa.Email = obj.Email;
                        empresa.DireccionWeb = obj.DireccionWeb;
                        empresa.Logo = obj.Logo;

                        result.Object = empresa;

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;

        }

    }
}

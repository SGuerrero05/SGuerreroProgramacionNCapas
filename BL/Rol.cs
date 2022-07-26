using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Rol
    {
        public static ML.Result RolGetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
                {
                    var query = context.RolGetAll().ToList();
                    result.Objects = new List<object>();

                    if(query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Rol rol = new ML.Rol();
                            rol.IdRol = obj.IdRol;
                            rol.Nombre = obj.Nombre;

                            result.Objects.Add(rol);
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
            catch (Exception ex)
            {
                result.Correct=false;
                result.ErrorMessage=ex.Message;
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Usuario" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Usuario.svc or Usuario.svc.cs at the Solution Explorer and start debugging.
    public class Usuario : IUsuario
    {
        public SL_WCF.Result AddEF(ML.Usuario usuario)
        {
            ML.Result result = BL.Usuario.AddEF(usuario);
            return new SL_WCF.Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex };
        }
        public SL_WCF.Result UpdateEF(ML.Usuario usuario)
        {
            ML.Result result = BL.Usuario.UpdateEF(usuario);
            return new SL_WCF.Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex };
        } 
 
        public SL_WCF.Result DeleteEF(int IdUsuario)
        {
            ML.Usuario usuario = new ML.Usuario();
            usuario.IdUsuario = IdUsuario;

            ML.Result result = BL.Usuario.DeleteEF(usuario);
            return new SL_WCF.Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex };
        }

        public SL_WCF.Result GetAllEF()
        {
            ML.Usuario usuario = new ML.Usuario();
            ML.Result result = BL.Usuario.GetAllEF(usuario);
            return new SL_WCF.Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex, Object = result.Object, Objects = result.Objects };
        }

        public SL_WCF.Result GetByIdEF(int IdUsuario)
        {
            ML.Usuario usuario = new ML.Usuario();
            usuario.IdUsuario = IdUsuario;

            ML.Result result = BL.Usuario.GetByIdEF(IdUsuario);
            return new SL_WCF.Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex, Object = result.Object, Objects = result.Objects };
        }
    }
}

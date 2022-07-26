using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using ML;

namespace BL
{
    public class Usuario
    {
        //public static ML.Result Add(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            string query = "INSERT INTO [Usuario] ([Nombre], [ApellidoPaterno], [ApellidoMaterno], [Email], [Edad]) VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Email, @Edad)";

        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.Connection = context;
        //                cmd.CommandText = query;


        //                SqlParameter[] collection = new SqlParameter[4];

        //                collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
        //                collection[0].Value = usuario.Nombre;

        //                collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
        //                collection[1].Value = usuario.ApellidoPaterno;

        //                collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
        //                collection[2].Value = usuario.ApellidoMaterno;

        //                collection[3] = new SqlParameter("Email", SqlDbType.VarChar);
        //                collection[3].Value = usuario.Email;


        //                cmd.Parameters.AddRange(collection);

        //                cmd.Connection.Open();

        //                int RowsAffected = cmd.ExecuteNonQuery();

        //                if (RowsAffected > 0)
        //                {
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                }



        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;
        //}
        //public static ML.Result Delete(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            string query = "DELETE FROM [Usuario] WHERE (IdUsuario) = @IdUsuario";

        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.Connection = context;
        //                cmd.CommandText = query;


        //                SqlParameter[] collection = new SqlParameter[1];

        //                collection[0] = new SqlParameter("IdUsuario", SqlDbType.Int);
        //                collection[0].Value = usuario.IdUsuario;

        //                cmd.Parameters.AddRange(collection);

        //                cmd.Connection.Open();

        //                int RowsAffected = cmd.ExecuteNonQuery();

        //                if (RowsAffected > 0)
        //                {
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                }



        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;

        //}
        //public static ML.Result Update(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            string query = "UPDATE [dbo].[Usuario] SET Nombre = @Nombre, ApellidoPaterno = @ApellidoPaterno, ApellidoMaterno = @ApellidoMaterno, Email = @Email, Edad = @Edad WHERE (IdUsuario) = @IdUsuario";

        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.Connection = context;
        //                cmd.CommandText = query;


        //                SqlParameter[] collection = new SqlParameter[5];
        //                collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
        //                collection[0].Value = usuario.Nombre;

        //                collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
        //                collection[1].Value = usuario.ApellidoPaterno;

        //                collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
        //                collection[2].Value = usuario.ApellidoMaterno;

        //                collection[3] = new SqlParameter("Email", SqlDbType.VarChar);
        //                collection[3].Value = usuario.Email;

        //                collection[4] = new SqlParameter("IdUsuario", SqlDbType.Int);
        //                collection[4].Value = usuario.IdUsuario;

        //                cmd.Parameters.AddRange(collection);

        //                cmd.Connection.Open();

        //                int RowsAffected = cmd.ExecuteNonQuery();

        //                if (RowsAffected > 0)
        //                {
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                }



        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;

        //}
        //public static ML.Result AddSP(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            string query = "UsuarioAdd";
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.Connection = context;
        //                cmd.CommandText = query;
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                SqlParameter[] collection = new SqlParameter[5];

        //                collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
        //                collection[0].Value = usuario.Nombre;

        //                collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
        //                collection[1].Value = usuario.ApellidoPaterno;

        //                collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
        //                collection[2].Value = usuario.ApellidoMaterno;

        //                collection[3] = new SqlParameter("Email", SqlDbType.VarChar);
        //                collection[3].Value = usuario.Email;

        //                collection[4] = new SqlParameter("IdRol", SqlDbType.TinyInt);
        //                collection[4].Value = usuario.Rol.IdRol;

        //                cmd.Parameters.AddRange(collection);
        //                cmd.Connection.Open();

        //                int RowsAffected = cmd.ExecuteNonQuery();

        //                if (RowsAffected > 0)
        //                {
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;
        //}
        //public static ML.Result DeleteSP(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            string query = "UsuarioDelete";
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.Connection = context;
        //                cmd.CommandText = query;
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                SqlParameter[] collection = new SqlParameter[1];

        //                collection[0] = new SqlParameter("IdUsuario", SqlDbType.Int);
        //                collection[0].Value = usuario.IdUsuario;

        //                cmd.Parameters.AddRange(collection);

        //                cmd.Connection.Open();

        //                int RowsAffected = cmd.ExecuteNonQuery();

        //                if (RowsAffected > 0)
        //                {
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                }



        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;

        //}
        //public static ML.Result UpdateSP(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            string query = "UsuarioUpdate";
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.Connection = context;
        //                cmd.CommandText = query;
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                SqlParameter[] collection = new SqlParameter[6];
        //                collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
        //                collection[0].Value = usuario.Nombre;

        //                collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
        //                collection[1].Value = usuario.ApellidoPaterno;

        //                collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
        //                collection[2].Value = usuario.ApellidoMaterno;

        //                collection[3] = new SqlParameter("Email", SqlDbType.VarChar);
        //                collection[3].Value = usuario.Email;

        //                collection[4] = new SqlParameter("IdRol", SqlDbType.TinyInt);
        //                collection[4].Value = usuario.Rol.IdRol;

        //                collection[5] = new SqlParameter("IdUsuario", SqlDbType.Int);
        //                collection[5].Value = usuario.IdUsuario;

        //                cmd.Parameters.AddRange(collection);

        //                cmd.Connection.Open();

        //                int RowsAffected = cmd.ExecuteNonQuery();

        //                if (RowsAffected > 0)
        //                {
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                }



        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;

        //}
        //public static ML.Result GetAllSP()
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            string query = "UsuarioGetAll";
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.Connection = context;
        //                cmd.CommandText = query;
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                DataTable tableUsuario = new DataTable();
        //                SqlDataAdapter da = new SqlDataAdapter(cmd);

        //                da.Fill(tableUsuario);

        //                if (tableUsuario.Rows.Count > 0)
        //                {
        //                    result.Objects = new List<object>();
        //                    foreach (DataRow row in tableUsuario.Rows)
        //                    {
        //                        ML.Usuario usuario = new ML.Usuario();
        //                        usuario.IdUsuario = int.Parse(row[0].ToString());
        //                        usuario.Nombre = row[1].ToString();
        //                        usuario.ApellidoPaterno = row[2].ToString();
        //                        usuario.ApellidoMaterno = row[3].ToString();
        //                        usuario.Email = row[4].ToString();


        //                        usuario.Rol = new ML.Rol();
        //                        usuario.Rol.IdRol = byte.Parse(row[5].ToString());

        //                        result.Objects.Add(usuario);
        //                    }
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                }

        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;
        //}
        //public static ML.Result GetByIdSP(int IdUsuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            string query = "UsuarioGetById";
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.Connection = context;
        //                cmd.CommandText = query;
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                SqlParameter[] collection = new SqlParameter[1];

        //                collection[0] = new SqlParameter("IdUsuario", SqlDbType.Int);
        //                collection[0].Value = IdUsuario;

        //                cmd.Parameters.AddRange(collection);

        //                DataTable tableUsuario = new DataTable();
        //                SqlDataAdapter da = new SqlDataAdapter(cmd);
        //                da.Fill(tableUsuario);

        //                if (tableUsuario.Rows.Count > 0)
        //                {
        //                    DataRow row = tableUsuario.Rows[0];

        //                    ML.Usuario usuario = new ML.Usuario();
        //                    usuario.IdUsuario = int.Parse(row[0].ToString());
        //                    usuario.Nombre = row[1].ToString();
        //                    usuario.ApellidoPaterno = row[2].ToString();
        //                    usuario.ApellidoMaterno = row[3].ToString();
        //                    usuario.Email = row[4].ToString();

        //                    usuario.Rol = new ML.Rol();

        //                    usuario.Rol.IdRol = byte.Parse(row[5].ToString());

        //                    result.Object = usuario;

        //                    result.Correct = true;

        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;
        //}
        public static ML.Result AddEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
                {
                    var query = context.UsuarioAdd(usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Email, usuario.Rol.IdRol, usuario.UserName, usuario.Password, usuario.Sexo, usuario.Telefono, usuario.Celular, usuario.FechaNacimiento, usuario.CURP, usuario.Imagen,usuario.Direccion.IdDireccion,usuario.Direccion.Calle,usuario.Direccion.NumeroInterior,usuario.Direccion.NumeroExterior,usuario.Direccion.Colonia.IdColonia);
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se inserto el registro";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
        public static ML.Result DeleteEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
                {
                    var query = context.UsuarioDelete(usuario.IdUsuario);
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se elimino el registro";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
        public static ML.Result UpdateEF(ML.Usuario usuario)    
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
                {
                    var query = context.UsuarioUpdate(usuario.IdUsuario, usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Email, usuario.Rol.IdRol, usuario.UserName, usuario.Password, usuario.Sexo, usuario.Telefono, usuario.Celular, usuario.FechaNacimiento, usuario.CURP, usuario.Imagen,usuario.Direccion.Calle, usuario.Direccion.NumeroInterior, usuario.Direccion.NumeroExterior, usuario.Direccion.Colonia.IdColonia);
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se actualizo correctamente";
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
        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
                {
                    var query = context.UsuarioGetAll().ToList();
                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach(var obj in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.IdUsuario = obj.IdUsuario;
                            usuario.Nombre = obj.NombreUsuario;
                            usuario.ApellidoPaterno = obj.ApellidoPaterno;
                            usuario.ApellidoMaterno = obj.ApellidoMaterno;
                            usuario.Email = obj.Email;
                            usuario.Rol = new ML.Rol();
                            usuario.Rol.Nombre = obj.NombreRol;
                            usuario.UserName = obj.UserName;
                            usuario.Password = obj.Password;
                            usuario.Sexo = obj.Sexo;
                            usuario.Telefono = obj.Telefono;
                            usuario.Celular = obj.Celular;
                            usuario.FechaNacimiento = obj.FechaNacimiento.ToString();
                            usuario.CURP = obj.CURP;
                            usuario.Imagen = obj.Imagen;

                            usuario.Direccion = new ML.Direccion();
                            usuario.Direccion.IdDireccion = obj.IdDireccion;
                            usuario.Direccion.Calle = obj.Calle;
                            usuario.Direccion.NumeroExterior = obj.NumeroExterior;
                            usuario.Direccion.NumeroInterior = obj.NumeroInterior;

                            usuario.Direccion.Colonia = new ML.Colonia();
                            usuario.Direccion.Colonia.IdColonia = obj.IdColonia.Value;
                            usuario.Direccion.Colonia.Nombre = obj.NombreColonia;
                            usuario.Direccion.Colonia.CodigoPostal = obj.CodigoPostal;

                            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                            usuario.Direccion.Colonia.Municipio.IdMunicipio = obj.IdMunicipio.Value;
                            usuario.Direccion.Colonia.Municipio.Nombre = obj.NombreMunicipio;

                            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                            usuario.Direccion.Colonia.Municipio.Estado.IdEstado = obj.IdEstado.Value;
                            usuario.Direccion.Colonia.Municipio.Estado.Nombre = obj.NombreEstado;

                            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                            usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais = obj.IdPais.Value;
                            usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre = obj.NombrePais;


                            result.Objects.Add(usuario);

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
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
        public static ML.Result GetByIdEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
                {
                    var obj = context.UsuarioGetById(IdUsuario).FirstOrDefault();
                    result.Objects = new List<object>();
                    if (obj != null)
                    {
                        ML.Usuario usuario = new ML.Usuario();
                        usuario.IdUsuario = obj.IdUsuario;
                        usuario.Nombre = obj.NombreUsuario;
                        usuario.ApellidoPaterno = obj.ApellidoPaterno;
                        usuario.ApellidoMaterno = obj.ApellidoMaterno;
                        usuario.Email = obj.Email;
                        usuario.Rol = new ML.Rol();
                        usuario.Rol.IdRol = obj.IdRol.Value;
                        usuario.UserName = obj.UserName;
                        usuario.Password = obj.Password;
                        usuario.Sexo = obj.Sexo;
                        usuario.Telefono = obj.Telefono;
                        usuario.Celular = obj.Celular;
                        usuario.FechaNacimiento = obj.FechaNacimiento.ToString();
                        usuario.CURP = obj.CURP;
                        usuario.Imagen = obj.Imagen;

                        usuario.Direccion = new ML.Direccion();
                        usuario.Direccion.IdDireccion = obj.IdDireccion;
                        usuario.Direccion.Calle = obj.Calle;
                        usuario.Direccion.NumeroExterior = obj.NumeroExterior;
                        usuario.Direccion.NumeroInterior = obj.NumeroInterior;

                        usuario.Direccion.Colonia = new ML.Colonia();
                        usuario.Direccion.Colonia.IdColonia = obj.IdColonia.Value;
                        usuario.Direccion.Colonia.Nombre = obj.NombreColonia;
                        usuario.Direccion.Colonia.CodigoPostal = obj.CodigoPostal;

                        usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                        usuario.Direccion.Colonia.Municipio.IdMunicipio = obj.IdMunicipio.Value;
                        usuario.Direccion.Colonia.Municipio.Nombre = obj.NombreMunicipio;

                        usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                        usuario.Direccion.Colonia.Municipio.Estado.IdEstado = obj.IdEstado.Value;
                        usuario.Direccion.Colonia.Municipio.Estado.Nombre = obj.NombreEstado;

                        usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                        usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais = obj.IdPais.Value;
                        usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre = obj.NombrePais;

                        result.Object=usuario;

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrio un error de consulta";
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }
            return result;
        }
        //public static ML.Result AddLINQ (ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
        //        {
        //            DL_EF.Usuario usuarioLINQ = new DL_EF.Usuario();

        //            usuarioLINQ.Nombre = usuario.Nombre;
        //            usuarioLINQ.ApellidoPaterno = usuario.ApellidoPaterno;
        //            usuarioLINQ.ApellidoMaterno = usuario.ApellidoMaterno;
        //            usuarioLINQ.Email = usuario.Email;
        //            //usuario.Rol = new ML.Rol();
        //            usuarioLINQ.IdRol = usuario.Rol.IdRol;
        //            usuarioLINQ.UserName = usuario.UserName;
        //            usuarioLINQ.Password = usuario.Password;
        //            usuarioLINQ.Sexo = usuario.Sexo;
        //            usuarioLINQ.Telefono = usuario.Telefono;
        //            usuarioLINQ.Celular = usuario.Celular;
        //            //usuarioLINQ.FechaNacimiento = DateTime.ParseExact(usuario.FechaNacimiento, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        //            usuarioLINQ.FechaNacimiento = DateTime.Parse(usuario.FechaNacimiento);
        //            usuarioLINQ.CURP = usuario.CURP;
        //            usuarioLINQ.Imagen = usuario.Imagen;

        //            if (usuarioLINQ != null)
        //            {
        //                context.Usuario.Add(usuarioLINQ);
        //                context.SaveChanges();
        //                result.Correct = true; 
        //            }
        //            else
        //            {
        //                result.Correct=false;
        //            }

                    


        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        result.Correct = true;
        //        result.ErrorMessage = ex.Message;
                
        //    }
        //    return result;
        //}
        //public static ML.Result DeleteLINQ (ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
        //        {
        //            var query = (from a in context.Usuario
        //                         where a.IdUsuario == usuario.IdUsuario
        //                         select a).First();

        //            if(query != null)
        //            {
        //                context.Usuario.Remove(query);
        //                context.SaveChanges();
        //                result.Correct = true;
        //            }
                    
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //     result.Correct = false;
        //     result.ErrorMessage=ex.Message;
        //    }
        //    return result;
        //}
        //public static ML.Result UpdateLINQ (ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
        //        {
        //            var query = (from a in context.Usuario
        //                         where a.IdUsuario == usuario.IdUsuario
        //                         select a).SingleOrDefault();
        //            if (query != null)
        //            {
        //                query.Nombre = usuario.Nombre;
        //                query.ApellidoPaterno = usuario.ApellidoPaterno;
        //                query.ApellidoMaterno = usuario.ApellidoMaterno;
        //                query.Email = usuario.Email;
        //                query.IdRol = usuario.Rol.IdRol;
        //                query.UserName = usuario.UserName;
        //                query.Password = usuario.Password;
        //                query.Sexo = usuario.Sexo;
        //                query.Telefono = usuario.Telefono;
        //                query.Celular = usuario.Celular;
        //                query.FechaNacimiento = DateTime.Parse(usuario.FechaNacimiento);
        //                query.CURP = usuario.CURP;
        //                query.Imagen = usuario.Imagen;

        //                context.SaveChanges();
        //                result.Correct = true;

        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "No se actualizo";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;
        //}
        //public static ML.Result GetAllLINQ ()
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
        //        {
        //            var UsuarioList = (from usuario in context.Usuario
        //                               select new
        //                               {
        //                                   usuario.IdUsuario,
        //                                   usuario.Nombre,
        //                                   usuario.ApellidoPaterno,
        //                                   usuario.ApellidoMaterno,
        //                                   usuario.Email,
        //                                   usuario.IdRol,
        //                                   usuario.UserName,
        //                                   usuario.Password,
        //                                   usuario.Sexo,
        //                                   usuario.Telefono,
        //                                   usuario.Celular,
        //                                   usuario.FechaNacimiento,
        //                                   usuario.CURP,
        //                                   usuario.Imagen
        //                               }).ToList();
        //            if (UsuarioList.Count > 1)
        //            {
        //                result.Objects = new List<object>();
        //                foreach(var usuario in UsuarioList)
        //                {
        //                    ML.Usuario usuarioItem = new ML.Usuario();
        //                    usuarioItem.IdUsuario = usuario.IdUsuario;
        //                    usuarioItem.Nombre = usuario.Nombre;
        //                    usuarioItem.ApellidoPaterno = usuario.ApellidoPaterno;
        //                    usuarioItem.ApellidoMaterno = usuario.ApellidoMaterno;
        //                    usuarioItem.Email = usuario.Email;
        //                    usuarioItem.Rol = new ML.Rol();
        //                    usuarioItem.Rol.IdRol = usuario.IdRol.Value;
        //                    usuarioItem.UserName = usuario.UserName;
        //                    usuarioItem.Password = usuario.Password;
        //                    usuarioItem.Sexo = usuario.Sexo;
        //                    usuarioItem.Telefono = usuario.Telefono;
        //                    usuarioItem.Celular = usuario.Celular;
        //                    // usuarioItem.FechaNacimiento = DateTime.ParseExact(usuario.FechaNacimiento, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        //                    usuarioItem.FechaNacimiento = usuario.FechaNacimiento.ToString();
        //                    usuarioItem.CURP = usuario.CURP;
        //                    usuarioItem.Imagen = usuario.Imagen;

        //                    result.Objects.Add(usuarioItem);

        //                }
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }
                
        //    }
        //    catch(Exception ex)
        //    {
        //        result.Correct=false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;
        //}
        //public static ML.Result GetByIdLINQ (int IdUsuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.SGuerreroProgramacionNcapasEntities context = new DL_EF.SGuerreroProgramacionNcapasEntities())
        //        {
        //            var obj = context.UsuarioGetById(IdUsuario).FirstOrDefault();
        //            if (obj != null)
        //            {
        //                ML.Usuario usuario = new ML.Usuario();

        //                usuario.IdUsuario = obj.IdUsuario;
        //                usuario.Nombre = obj.Nombre;
        //                usuario.ApellidoPaterno = obj.ApellidoPaterno;
        //                usuario.ApellidoMaterno = obj.ApellidoMaterno;
        //                usuario.Email = obj.Email;
        //                usuario.Rol = new ML.Rol();
        //                usuario.Rol.IdRol = obj.IdRol.Value;
        //                usuario.UserName =obj.UserName;
        //                usuario.Password = obj.Password;
        //                usuario.Sexo = obj.Sexo;
        //                usuario.Telefono = obj.Telefono;
        //                usuario.Celular = obj.Celular;
        //                // usuarioItem.FechaNacimiento = DateTime.ParseExact(usuario.FechaNacimiento, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        //                usuario.FechaNacimiento = obj.FechaNacimiento.ToString();
        //                usuario.CURP = obj.CURP;
        //                usuario.Imagen = obj.Imagen;

        //                result.Object = usuario;
        //                result.Correct = true;


        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;

        //}

    }
}


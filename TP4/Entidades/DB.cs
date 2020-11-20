using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data.SqlClient;
using System.ComponentModel;
using Excepciones;

namespace Entidades
{
    public static class DB
    {
        const string STRINGCONNEC = "Server=.\\sqlexpress;Database=Negocio;Trusted_Connection=True;";

        static SqlConnection sqlConn;
        static SqlCommand command;

        static DB()
        {
            sqlConn = new SqlConnection();
            sqlConn.ConnectionString = STRINGCONNEC;
            command = new SqlCommand();
            command.Connection = sqlConn;
        }
        /// <summary>
        /// Inserta el Objeto a la DB
        /// </summary>
        /// <typeparam name="T">Cualquier clase que contenga la Interfaz IDb</typeparam>
        /// <param name="objeto">Un objeto de la clase que implemente IDb</param>
        /// <returns></returns>
        public static Boolean Insert<T>(T objeto) where T: IDb
        {
            Boolean rtrn = false;
            objeto.Object_To_DB(ref DB.command);
            try
            {
                if (sqlConn.State == System.Data.ConnectionState.Closed)
                {
                    sqlConn.Open();
                }

                command.ExecuteNonQuery();
                rtrn = true;
                return rtrn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                sqlConn.Close();
            }
            
        }

        /// <summary>
        /// Actualiza el objeto en la DB
        /// </summary>
        /// <typeparam name="T">Cualquier clase que contenga la Interfaz IDb</typeparam>
        /// <param name="objeto">Un objeto de la clase que implemente IDb</param>
        /// <returns></returns>
        public static Boolean Update<T>(T objeto) where T : IDb, new()
        {
            Boolean rtrn = false;
            objeto.DB_UpdateObject(ref DB.command);
            try
            {
                if (sqlConn.State == System.Data.ConnectionState.Closed)
                {
                    sqlConn.Open();
                }
                command.ExecuteNonQuery();
                
                rtrn = true;
                return rtrn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        /// <summary>
        /// Elimina el Objeto en la DB
        /// </summary>
        /// <typeparam name="T">Cualquier clase que contenga la Interfaz IDb</typeparam>
        /// <param name="objeto">Un objeto de la clase que implemente IDb</param>
        /// <returns></returns>
        public static Boolean Delete<T>(T objeto) where T : IDb
        {
            Boolean rtrn = false;
            objeto.DB_Delete_Reg(ref DB.command);
            try
            {
                if (sqlConn.State == System.Data.ConnectionState.Closed)
                {
                    sqlConn.Open();
                }

                command.ExecuteNonQuery();
                rtrn = true;
                return rtrn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                sqlConn.Close();
            }

        }


        /// <summary>
        /// Devuelve una lista, de los elementos de una tabla.
        /// </summary>
        /// <typeparam name="T">Cualquier clase que implemente la Interfaz IDb</typeparam>
        /// <returns></returns>
        public static List<T> GetLista<T>() where T : IDb, new()
        {
            List<T> lista = new List<T>();
            T aux = new T();
            aux.DB_Select_Query(ref DB.command);
            try
            {
                if (sqlConn.State != System.Data.ConnectionState.Open) 
                    sqlConn.Open(); 
                

                SqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    lista.Add((T)aux.DB_GetObjectFromRegistro(rd));
                }
                rd.Close();
                return lista;
            }
            catch(GetListaException getListaException)
            {
                throw new Exception(getListaException.Message, getListaException);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            finally
            {
                sqlConn.Close();
            }
        }
      
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public interface IDb
    {
        /// <summary>
        /// Paso por referencia la sentencia SQL para hacer el INSERT
        /// </summary>
        /// <param name="command">Para guardar la sentencia</param>
        void Object_To_DB(ref SqlCommand command);

        /// <summary>
        /// Paso por referencia la sentencia SQL para hacer el SELECT
        /// </summary>
        /// <param name="command">Para guardar la sentencia</param>
        void DB_Select_Query(ref SqlCommand command);

        /// <summary>
        /// Paso por referencia la sentencia SQL para hacer el UPDATE
        /// </summary>
        /// <param name="command">Para guardar la sentencia</param>
        void DB_UpdateObject(ref SqlCommand command);

        /// <summary>
        /// Paso el SqlDataReader de la clase DB que contiene los datos leidos de la DB
        /// </summary>
        /// <param name="command">Para leer lo que trajo de la DB</param>
        object DB_GetObjectFromRegistro(SqlDataReader reader);

        /// <summary>
        /// Paso por referencia la sentencia SQL para hacer el DELETE
        /// </summary>
        /// <param name="command">Para guardar la sentencia</param>
        void DB_Delete_Reg(ref SqlCommand command);
    }
}

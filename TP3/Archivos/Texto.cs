using System;
using System.Globalization;
using System.IO;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {

        public bool Guardar(string archivo, string datos)
        {
            bool rtrn = false;
            try
            {

                using (StreamWriter escritorArchivo = new StreamWriter(archivo, true))
                {
                    escritorArchivo.WriteLine(datos);
                    escritorArchivo.Close();
                }

            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return rtrn;
        }

        public bool Leer(string archivo, out string datos)
        {
            datos = string.Empty;
            bool rtrn = false;
            try
            {
                if (File.Exists(archivo))
                {
                    using (StreamReader lectorArchivo = new StreamReader(archivo))
                    {
                        datos = lectorArchivo.ReadToEnd();
                        lectorArchivo.Close();
                        rtrn = true;
                    }
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return rtrn;
        }
    }
}

using System;
using System.IO;

namespace Archivos
{
    public class Texto
    {

        public bool Guardar(string archivo, string datos)
        {
            bool rtrn = false;
            try
            {

                using (StreamWriter escritorArchivo = new StreamWriter(archivo, false))
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
                    }
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return rtrn;
        }
    }
}

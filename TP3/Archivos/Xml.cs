using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {

        public bool Guardar(string archivo, T datos)
        {
            bool rtrn = false;
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter(archivo, System.Text.Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(escritor, datos);
                    escritor.Close();
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return rtrn;
        }

        public bool Leer(string archivo, out T datos)
        {
            datos = default(T);
            bool rtrn = false;
            
            try
            {
                using (FileStream lector = new FileStream(archivo, FileMode.Open))
                {
                    XmlSerializer deserializador = new XmlSerializer(typeof(T));
                    datos = (T)deserializador.Deserialize(lector);

                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            
            return rtrn;
        }
    }
}

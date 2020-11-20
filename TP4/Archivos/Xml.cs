using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, List<T> datos)
        {
            bool rtrn = false;
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter(archivo, System.Text.Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                    serializer.Serialize(escritor, datos);
                    escritor.Close();
                }
            }
            catch (Exception e) { throw new Exception(e.Message, e); }
            return rtrn;
        }

        public bool Leer(string archivo, out List<T> datos)
        {
            datos = new List<T>(0);
            bool rtrn = false;
            
            try
            {
                using (FileStream lector = new FileStream(archivo, FileMode.Open))
                {
                    XmlSerializer deserializador = new XmlSerializer(typeof(List<T>));
                    datos = (List<T>)deserializador.Deserialize(lector);
                   
                }
            }
            catch (Exception e) { throw new Exception(e.Message, e); }
            
            return rtrn;
        }
    }
}

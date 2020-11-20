using System;
using System.Collections.Generic;
using System.Text;

namespace Archivos
{
    interface IArchivo<T> { 
        bool Guardar(string archivo, List<T> datos);

        bool Leer(string archivo,out List<T> datos);
    }
}

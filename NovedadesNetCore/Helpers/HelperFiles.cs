using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovedadesNetCore.Helpers
{
    public static class HelperFiles
    {
        //METODO PARA LEER EL CONTENIDO DE UN FICHERO
        public static async Task<string> ReadFileAsync(string path)
        {
            string data = await File.ReadAllTextAsync(path);
            return data;
        }
    }
}

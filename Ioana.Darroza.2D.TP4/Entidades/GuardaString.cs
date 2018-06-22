using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardaString
    {
        public static bool Guardar(this string archivo, string texto)
        {
            bool retorno = false;
            StreamWriter escribir = null;
            try
            {
                escribir = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "--" + archivo);
                escribir.WriteLine(texto);
                escribir.Close();
                retorno = true;
            }
            catch (FileNotFoundException)
            {
                string error = "El archivo ingresado no existe";
                throw new FileNotFoundException(error);
            }
            return retorno;
        }
    }
}
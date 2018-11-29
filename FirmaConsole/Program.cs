using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firma;

namespace FirmaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var documento = FirmaDocumento.FirmarDocumento("C:\\temp\\Firma\\50510231.p12", "Prueba123", "C:\\temp\\Firma\\Documento.xml", "C:\\temp\\Firma");
            if (documento != null)
            {
                Console.WriteLine("Documento firmado correctamente");
            } else
            {
                Console.WriteLine("No se pudo firmar el documento");
            }
            Console.ReadKey();
        }
    }
}

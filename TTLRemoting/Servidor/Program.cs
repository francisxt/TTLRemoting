using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using Componente;

/********************************
   *  Aplicaciones Distribuidas   *
   *  Francisco Gualli            *
   *  Gr1                         *
   *  Practica 05                 *
   *  Servidor                    *
   /*******************************/

//. Juegue con el lease time. Pruebe con distintos valores, nota alguna diferencia?

//Si, se nota la diferencia al instanciar el objeto remoto.
namespace Servidor
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("Servidor.exe.config");
            Utilidades.MostrarTodosLosDatos();
            Log.EsperarParaTerminar("Presione ENTER para detener al servidor...");
        }
    }
}

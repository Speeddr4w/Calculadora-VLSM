using RedesCalculadoraVLSM.Control;
using RedesCalculadoraVLSM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedesCalculadoraVLSM
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Initializer.boot();

        }
    }
}

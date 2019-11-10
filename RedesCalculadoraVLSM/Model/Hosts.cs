using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedesCalculadoraVLSM.Model
{
    class Hosts
    {
        public int Host { get; set; }
        public int Mais2 { get; set; }
        public int ProximaPotencia { get; set; }
        public int BitsEmprestados { get; set; }

        public Hosts(int host, int mais2, int proximapotencia, int bitsemprestados)
        {
            Host = host;
            Mais2 = mais2;
            ProximaPotencia = proximapotencia;
            BitsEmprestados = bitsemprestados;
        }
    }
}

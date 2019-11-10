using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedesCalculadoraVLSM.Model
{
    class Subredes
    {
        public int[] IDRede = new int[4];
        public int[] Broadcast = new int[4];
        public int BitsEmprestados { get; set; }

        public Subredes(int[] idrede, int[] broadcast, int bitsemprestados)
        {
            IDRede = idrede;
            Broadcast = broadcast;
            BitsEmprestados = bitsemprestados;
        }
    }
}

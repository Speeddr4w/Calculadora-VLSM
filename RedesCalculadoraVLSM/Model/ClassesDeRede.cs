using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedesCalculadoraVLSM.Model
{
    class ClassesDeRede
    {
        //Atributos nao estaticos, para os tres tipos de rede

        public int BaseInitialAddress { get; set; }
        public int BaseFinalAddress { get; set; }
        public int[] MascaraPadrao = new int[4];
        public string[] BinarioMascaraPadrao = new string[4];

        public int[] BaseAddress = new int[4];

        //

        //Atributos estaticos, para o endereco inserido pelo usuario

        public static int[] Address = new int[4];
        public static string[] BinaryAddress = new string[4];
        public static bool ValidAddress { get; set; }
        public static string Classe { get; set; }

        //

        public ClassesDeRede(int baseinitialAddress, int basefinalAddress,int[] mascarapadrao, string[] binariomascarapadrao)
        {
            BaseInitialAddress = baseinitialAddress;
            BaseFinalAddress = basefinalAddress;
            MascaraPadrao = mascarapadrao;
            BinarioMascaraPadrao = binariomascarapadrao;
        }
    }
}

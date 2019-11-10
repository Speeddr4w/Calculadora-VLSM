using RedesCalculadoraVLSM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedesCalculadoraVLSM.View
{
    class Mostrar
    {

        public Form1 myform = new Form1();
        public static void ClassesDeRede(ClassesDeRede classea, ClassesDeRede classeb, ClassesDeRede classec)
        {
            /*MessageBox.Show( $"Claase A: {classea.InitialAddress}.0.0.1 até {classea.FinalAddress}.255.255.254 | Máscara: {classea.MascaraPadrao[0]}.{classea.MascaraPadrao[1]}.{classea.MascaraPadrao[2]}.{classea.MascaraPadrao[3]}\n" +
                             $"Claase B: {classeb.InitialAddress}.0.0.1 até {classeb.FinalAddress}.255.255.254 | Máscara: {classeb.MascaraPadrao[0]}.{classeb.MascaraPadrao[1]}.{classeb.MascaraPadrao[2]}.{classeb.MascaraPadrao[3]}\n" +
                             $"Claase C: {classec.InitialAddress}.0.0.1 até {classec.FinalAddress}.255.255.254 | Máscara: {classec.MascaraPadrao[0]}.{classec.MascaraPadrao[1]}.{classec.MascaraPadrao[2]}.{classec.MascaraPadrao[3]}\n");*/
        }

        public static void ErroNoEndereco()
        {
            NoMessageBox("Endereço de IP Inválido");
        }

        public static void NoMessageBox(string texto)
        {
            MessageBox.Show(texto);
        }

        public static string InfosDaRede()
        {
            string texto = string.Empty;


            return null;
        }
        public static void ErroNoHosts()
        {
            NoMessageBox("Quantidade Invalida de Hosts");
        }

       public static string ListaDeSubredes(List<Subredes> listaderede)
       {
            int aux = 1;
            string texto = string.Empty;
            foreach(Subredes subrede in listaderede)
            {
                texto += $"Subrede {aux} \n";
                texto += $"ID Rede {subrede.IDRede[0]}.{subrede.IDRede[1]}.{subrede.IDRede[2]}.{subrede.IDRede[3]} / {32 - subrede.BitsEmprestados} \n";
                texto += $"Broadcast {subrede.Broadcast[0]}.{subrede.Broadcast[1]}.{subrede.Broadcast[2]}.{subrede.Broadcast[3]} \n \n \n";
                aux++;
            }


            return texto;
       }
    }
}

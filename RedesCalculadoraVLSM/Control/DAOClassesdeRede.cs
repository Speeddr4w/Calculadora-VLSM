using RedesCalculadoraVLSM.Model;
using RedesCalculadoraVLSM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedesCalculadoraVLSM.Control
{
    class DAOClassesdeRede
    {
        private static ClassesDeRede classeA = new ClassesDeRede(1, 126, new int[] { 255, 0, 0, 0 }, new string[] { "11111111", "00000000", "00000000", "00000000"});
        private static ClassesDeRede classeB = new ClassesDeRede(128, 191, new int[] { 255, 255, 0, 0 }, new string[] { "11111111", "11111111", "00000000", "00000000" });
        private static ClassesDeRede classeC = new ClassesDeRede(192, 223, new int[] { 255, 255, 255, 0 }, new string[] { "11111111", "11111111", "11111111", "00000000" });

        public static List<Hosts> ListaHosts = new List<Hosts>();
        public static bool ListaValida = false;

        public static List<Subredes> ListaSubredes = new List<Subredes>();





        public static void mostrarClasses()
        {
            Mostrar.ClassesDeRede(classeA, classeB, classeC);
        }

        public static void ClassificarRede(string[] rede)
        {
            if (rede.Count() == 4)
            {
                ConvertArrayStringToInt(rede);
                
            }
            else
            {
                Mostrar.ErroNoEndereco();
                return;
            }


            if (EnderecoValido())
            {
                if (ClassesDeRede.Address[0] >= classeA.BaseInitialAddress && ClassesDeRede.Address[0] <= classeA.BaseFinalAddress)
                {
                    ClassesDeRede.Classe = "A";
                }
                else if (ClassesDeRede.Address[0] >= classeB.BaseInitialAddress && ClassesDeRede.Address[0] <= classeB.BaseFinalAddress)
                {
                    ClassesDeRede.Classe = "B";
                }
                else if (ClassesDeRede.Address[0] >= classeC.BaseInitialAddress && ClassesDeRede.Address[0] <= classeC.BaseFinalAddress)
                {
                    ClassesDeRede.Classe = "C";
                }
            }
            else
            {
                Mostrar.ErroNoEndereco();
                return;
            }


        }

        private static bool EnderecoValido()
        {
            foreach(int quarto in ClassesDeRede.Address)
            {
                if(ClassesDeRede.Address[0] == quarto)
                {
                    if (quarto < classeA.BaseInitialAddress || quarto > classeC.BaseFinalAddress)
                    {
                        return false;
                    }
                }
                else if (quarto < 0 || quarto > 255)
                {
                    return false;
                }
            }
            ClassesDeRede.ValidAddress = true;
            return true;
        }
        
        public static void ConvertArrayStringToInt(string[] rede)
        {
            int i = 0;
            foreach(String quarto in rede)
            {
                ClassesDeRede.Address[i] = Convert.ToInt32(quarto);
                ClassesDeRede.BinaryAddress[i] = ConvertInttoStringBinary(ClassesDeRede.Address[i]);
                i++;
            }
    }

        public static string ConvertInttoStringBinary(int valor)
        {
            int remainder;
            string result = string.Empty;

            while (valor > 0)
            {
                remainder = valor % 2;
                valor /= 2;
                result = remainder.ToString() + result;
            }
            if (result.Length != 8)
            {
                int restante = 8 - result.Length;
                for (int i = 0; i < restante; i++)
                {
                    result = 0 + result;
                }
            }
            return result;

        }

        public static string TextoParaInfoDeRede()
        {
            string texto = string.Empty;

            texto = $"ID da Rede: {ClassesDeRede.Address[0]}.{ClassesDeRede.Address[1]}.{ClassesDeRede.Address[2]}.{ClassesDeRede.Address[3]} \n";
            texto += $"Classe: {ClassesDeRede.Classe} \n";
            switch (ClassesDeRede.Classe)
            {
                case "A":
                    texto += $"Default Mask: {classeA.MascaraPadrao[0]}.{classeA.MascaraPadrao[1]}.{classeA.MascaraPadrao[2]}.{classeA.MascaraPadrao[3]} \n";
                    texto += $"Binary Default Mask: {classeA.BinarioMascaraPadrao[0]}.{classeA.BinarioMascaraPadrao[1]}.{classeA.BinarioMascaraPadrao[2]}.{classeA.BinarioMascaraPadrao[3]} \n";
                    break;
                case "B":
                    texto += $"Default Mask: {classeB.MascaraPadrao[0]}.{classeB.MascaraPadrao[1]}.{classeB.MascaraPadrao[2]}.{classeB.MascaraPadrao[3]} \n";
                    texto += $"Binary Default Mask: {classeB.BinarioMascaraPadrao[0]}.{classeB.BinarioMascaraPadrao[1]}.{classeB.BinarioMascaraPadrao[2]}.{classeB.BinarioMascaraPadrao[3]} \n";
                    break;
                case "C":
                    texto += $"Default Mask: {classeC.MascaraPadrao[0]}.{classeC.MascaraPadrao[1]}.{classeC.MascaraPadrao[2]}.{classeC.MascaraPadrao[3]} \n";
                    texto += $"Binary Default Mask: {classeC.BinarioMascaraPadrao[0]}.{classeC.BinarioMascaraPadrao[1]}.{classeC.BinarioMascaraPadrao[2]}.{classeC.BinarioMascaraPadrao[3]} \n";
                    break;
            }
            texto += $"Binary ID: {ClassesDeRede.BinaryAddress[0]}.{ClassesDeRede.BinaryAddress[1]}.{ClassesDeRede.BinaryAddress[2]}.{ClassesDeRede.BinaryAddress[3]} \n \n \n"; 

           
            return texto;

        }

        public static void AddListaRedes(int host)
        {
            int mais2 = host + 2;

            int proximapotencia = 1;
            int bitsemprestados = 0;

            while (proximapotencia < mais2)
            {
                proximapotencia *= 2;
                bitsemprestados++;
            }

            ListaHosts.Add(new Hosts(host, mais2, proximapotencia, bitsemprestados));
        }

        public static void OrdernarListaRedes()
        {
            ListaHosts = ListaHosts.OrderByDescending(x => x.ProximaPotencia).ToList();
        }

        public static void TotalListaHosts()
        {
            int totallistahost = 0;
            foreach(Hosts host in ListaHosts)
            {
                totallistahost += host.ProximaPotencia;
            }

            switch (ClassesDeRede.Classe)
            {
                case "A":
                    if (totallistahost > 16777216)
                    {
                        ListaValida = false;
                        Mostrar.ErroNoHosts();
                        return;
                    }
                    break;

                case "B":
                    if (totallistahost > 65536)
                    {
                        ListaValida = false;
                        Mostrar.ErroNoHosts();
                        return;
                    }
                    break;

                case "C":
                     if (totallistahost > 256)
                    {
                        ListaValida = false;
                        Mostrar.ErroNoHosts();
                        return;
                    }
                    break;
            }
            ListaValida = true;
            return;
        }

        public static void MakeListSubredes()
        {
            int[] idrede = new int[4];
            int[] broadcast = new int[4];
            foreach (Hosts host in ListaHosts)
            {
                if (host == ListaHosts[0])
                {
                    idrede = new List<int>(ClassesDeRede.Address).ToArray();
                    broadcast = new List<int>(ClassesDeRede.Address).ToArray();
                    broadcast[3] += host.ProximaPotencia; 

                    while(broadcast[3] > 255)
                    {
                        broadcast[3] -= 255;
                        broadcast[2] += 1;

                    }
                    while (broadcast[2] > 255)
                    {
                        broadcast[2] -= 255;
                        broadcast[1] += 1;

                    }


                    ListaSubredes.Add(new Subredes(idrede, broadcast, host.BitsEmprestados));
                }
                else
                {
                    idrede = new List<int>(ListaSubredes[ListaSubredes.Count - 1].Broadcast).ToArray();
                    idrede[3] += 1;

                    while (idrede[3] > 255)
                    {
                        idrede[3] -= 255;
                        idrede[2] += 1;

                    }
                    while (idrede[2] > 255)
                    {
                        idrede[2] -= 255;
                        idrede[1] += 1;

                    }

                    broadcast = new List<int>(ListaSubredes[ListaSubredes.Count - 1].Broadcast).ToArray();
                    broadcast[3] += host.ProximaPotencia;


                    while (broadcast[3] > 255)
                    {
                        broadcast[3] -= 255;
                        broadcast[2] += 1;

                    }
                    while (broadcast[2] > 255)
                    {
                        broadcast[2] -= 255;
                        broadcast[1] += 1;

                    }

                    ListaSubredes.Add(new Subredes(idrede, broadcast, host.BitsEmprestados));
                }
            }
        }

        public static string MostrarSubredes()
        {
          return Mostrar.ListaDeSubredes(ListaSubredes);
        }
        

        public static void resetar()
        {
        ListaHosts = new List<Hosts>();
        ListaValida = false;
        ListaSubredes = new List<Subredes>();
        }
    }
}

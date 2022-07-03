using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Program
    {
        private static string Mesext(int mes)
        {
            string mesextenso;
            mesextenso = null;
            switch (mes)
            {
                case 1:
                    mesextenso = "Janeiro";
                    break;

                case 2:
                    mesextenso = "Fevereiro";
                    break;

                case 3:
                    mesextenso = "Março";
                    break;

                case 4:
                    mesextenso = "Abril";
                    break;

                case 5:
                    mesextenso = "Maio";
                    break;

                case 6:
                    mesextenso = "Junho";
                    break;

                case 7:
                    mesextenso = "Julho";
                    break;

                case 8:
                    mesextenso = "Agosto";
                    break;

                case 9:
                    mesextenso = "Setembro";
                    break;

                case 10:
                    mesextenso = "Outubro";
                    break;

                case 11:
                    mesextenso = "Novembro";
                    break;

                case 12:
                    mesextenso = "Dezembro";
                    break;
            }

            return mesextenso;

        }

        static void Main(string[] args)

        {
            int cid, dia, mes, ano;
            string cid_ext;

            Console.WriteLine("Digite o numero da cidade desejada:\n=============== \n1- Atibaia\n2- Bragança Paulista\n3- Mairiporã\n4- Nazaré\n5- Terra Preta\n6- Extrema\n7- Vargem\n=============== ");
            cid = Convert.ToInt32(Console.ReadLine());


            cid_ext = null;

            switch(cid)
            {
                case 1:
                    cid_ext = "Atibaia";
                break;

                case 2:
                    cid_ext = "Bragança Paulista";
                break;

                case 3:
                    cid_ext = "Mairoporã";
                break;

                case 4:
                    cid_ext = "Nazaré";
                break;

                case 5:
                    cid_ext = "Terra Preta";
                break;

                case 6:
                    cid_ext = "Extrema";
                break;

                case 7:
                    cid_ext = "Vargem";
                break;
            }

            Console.Write("Digite a data que deseja no seguinte formato DD/MM/AAAA :");
            var data = Convert.ToDateTime(Console.ReadLine());
            dia = data.Day;
            mes = data.Month;
            ano = data.Year;

            Console.Write(cid_ext + ", " + dia + " de " + Mesext(mes) + " de " + ano + ".");
            Console.ReadKey();
        }

    }

}

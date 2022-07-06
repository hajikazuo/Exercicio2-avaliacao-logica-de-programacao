using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_avaliacao_logica_de_programacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nilton Kazuo Hasegawa Haji RA:6322507
            // Fazer um programa para que mostre uma lista de cidades para o usuário e que ele informe o código da cidade escolhida.
            // Em seguida pedir uma data para o usuário. Ao final deve ser apresentada em tela a data completa em formato extenso longo,
            // juntamente com a cidade escolhida. 
            // Exemplo: Bragança Paulista, 29 de junho de 2022.

            //A relação das cidades é a seguinte:

            //1 – Atibaia
            //2 – Bragança Paulista
            //3 – Mairiporã
            //4 – Nazaré
            //5 – Terra Preta
            //6 – Extrema
            //7 – Vargem

            //Requisitos: Criar uma função para converter a data em extenso.

            int codigo;
            string cidade = null;
            Console.WriteLine("1 – Atibaia \n2 – Bragança Paulista \n3 – Mairiporã  \n4 – Nazaré \n5 – Terra Preta \n6 – Extrema \n7 – Vargem\n");
            Console.Write("Escolha a cidade informando o número: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    cidade = "Atibaia";
                    break;

                case 2:
                    cidade = "Bragança Paulista";
                    break;

                case 3:
                    cidade = "Mairiporã";
                    break;

                case 4:
                    cidade = "Nazaré";
                    break;

                case 5:
                    cidade = "Terra Preta";
                    break;

                case 6:
                    cidade = "Extrema";
                    break;

                case 7:
                    cidade = "Vargem";
                    break;
            }

            int mes, dia, ano;
            Console.Write("Digite uma Data  (dd/mm/aaaa): ");
            var dataatual = Convert.ToDateTime(Console.ReadLine());
            mes = dataatual.Month;
            dia = dataatual.Day;
            ano = dataatual.Year;

            string datadesejada = Dataextenso(mes);
            Console.WriteLine(cidade + ", " + dia + " de " + datadesejada + " de " + ano);

            Console.ReadKey();
        }
        static public string Dataextenso(int mes)
        {
            string mesextenso = null;
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
            string dataextensa = mesextenso;

            return dataextensa;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class Aluno
    {
        public string Nome;
        public string Mail;
        public int Telefone;
        public Data DataNasc;
    }
    public class Data
    {
        public string Dia;
        public string Mês;
        public string Ano;
    }
    class Program
    {
        static void ExibeAlunos(Aluno[] aluno)
        {
            foreach (Aluno x in aluno)
            {
                Console.WriteLine($"{x.Nome} - Nasceu em {x.DataNasc.Dia} de {x.DataNasc.Mês} de {x.DataNasc.Ano}");
                Console.WriteLine($"Seu telefone é {x.Telefone} e seu email é {x.Mail}");
            }
        }
        static void Main(string[] args)
        {

            Aluno[] aluno = new Aluno[50];

            for (int i = 0; i < 50; i++)
            {
                Aluno x = new Aluno();

                Console.WriteLine("Nome do aluno:");
                x.Nome = Console.ReadLine();

                Console.WriteLine("Email do aluno:");
                x.Mail = Console.ReadLine();

                x.DataNasc = new Data();

                Console.Write("Data de Nascimento - Dia: ");
                x.DataNasc.Dia = Console.ReadLine();

                Console.Write("                     Mês: ");
                x.DataNasc.Mês = Console.ReadLine();

                Console.Write("                     Ano: ");
                x.DataNasc.Ano = Console.ReadLine();

                Console.WriteLine("Telefone do aluno:");
                x.Telefone = int.Parse(Console.ReadLine());

                aluno[i] = x;
            }

            ExibeAlunos(aluno);



            Console.ReadKey();
        }
    }
}

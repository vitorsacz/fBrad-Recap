using Recap.Aluno;
using System.Runtime.CompilerServices;

namespace Recap
{
    class Program
    {
        static DadoAluno[] alunos;

      

        static void Main(string[] args)
        {



            Console.Write("Quantos alunos sua sala possui?");
            int numeroAluno = Int32.Parse(Console.ReadLine());
            alunos = new DadoAluno[numeroAluno];

            for (int i = 0; i < alunos.Length; i++)
            {

                Console.WriteLine("Dados do aluno " + (i +1));

                Console.WriteLine("Qual o nome do seu aluno? ");
                string nome = Console.ReadLine();

                Console.WriteLine("Qual a idade do seu aluno? ");
                int idade = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Qual o curso do seu aluno? ");
                string curso = Console.ReadLine();

                Console.WriteLine("Qual a nota do seu aluno? ");
                float nota = float.Parse(Console.ReadLine());

                Console.WriteLine();

                alunos[i] = new DadoAluno(nome, idade, curso, nota);
                    

            }

            foreach (DadoAluno aluno in alunos )
            {
                Print(aluno.RetornaDadosAluno());
            }

            //Print(alunos[0].RetornaDadosAluno());
            
        }

        public static void Print (string text)
        {
            Console.WriteLine(text);
        }

        
    }   
}

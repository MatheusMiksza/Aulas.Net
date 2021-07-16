using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iforme a opção desejada");
            Console.WriteLine("1- Insira o nome do aluno: ");
            Console.WriteLine("2- Listar alunos: ");
            Console.WriteLine("3- Calcular média geral ");
            Console.WriteLine("4- Sair");
            Console.WriteLine("");

            string opcaoUsuario = Console.ReadLine();

            while (opcaoUsuario != "4")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        //TODO: adicionar usuario
                        break;
                    case "2":
                        //TODO: listar alunos
                        break;
                    case "3":
                        //TODO: média geral
                        break;
                }
            }
          
        }
    }
}

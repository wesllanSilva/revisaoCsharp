﻿using System;

namespace revisaoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X Sair");

            string opcaoUsuario = Console.ReadLine();

            while(opcaoUsuario.ToUpper() != "X"){
                switch(opcaoUsuario)
                {
                    case "1":
                        //TODO: adicinar aluno
                        break;
                    case "2":
                        //TODO: lista alunos
                        break;
                    case "3":
                        //TODO: calcular média geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                Console.WriteLine("Informe a opção desejada:");
                Console.WriteLine("1- Inserir novo aluno");
                Console.WriteLine("2- Listar alunos");
                Console.WriteLine("3- Calcular média geral");
                Console.WriteLine("X Sair");

                opcaoUsuario = Console.ReadLine();
            }
        }
    }
}

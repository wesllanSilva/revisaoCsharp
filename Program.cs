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

            string opcaoUsuario = Console.ReadLine();
        }
    }
}

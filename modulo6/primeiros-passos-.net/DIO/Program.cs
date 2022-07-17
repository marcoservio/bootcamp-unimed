using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //dotnet --help
            //dotnet new --help
            //dotnet new --list
            //code .
            //dotnet restore
            //dotnet build
            //dotnet run

            int numeroDeVezes = 10;

            for(int i = 0; i < numeroDeVezes; i++)
            {
                Console.WriteLine($"Bem-vindo ao curso de .Net {i}");
            }   
        }
    }
}

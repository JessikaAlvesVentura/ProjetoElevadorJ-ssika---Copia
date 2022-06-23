using System;

namespace TesteElevador
{
    internal class Program
    {
        private static int quantPessoas;

        static void Main(string[] args)
        {
            string resposta; //para voltar as respostas do usuário

            Console.WriteLine("Olá! Bem vindo ao Condomínio.");
            Console.WriteLine("Nosso prédio possui 6 andares e a capacidade máxima do elevador é de 5 pessoas.");
            Console.WriteLine(@"Escolha entre:
             E - Entrar no elevador
             S - Sair do programa");
            resposta = Console.ReadLine();//primeiro contato do usuário

            Console.WriteLine(@"Vai subir?
            Sim
            Não");
            resposta = Console.ReadLine();//segundo contato


            Console.WriteLine(@"Quantas pessoas vão entrar?");
            resposta = Console.ReadLine();//qtde de pessoas que entrarão no elevador

            if (quantPessoas < 0) //info de qtde que podem ou não entrar
            {
                Console.WriteLine("Andar indisponível. Tente novamente");
            }
            else if (quantPessoas >= 1)
            {
                Console.WriteLine("Pode entrar!");
            }
            else if (quantPessoas <= 5)
            {
                Console.WriteLine("Pode entrar!Lembre-se que a capacidade máxima é de 5 pessoas.");
            }
            else
            {
                Console.WriteLine("Elevador cheio, favor aguardar.");
            }
            resposta = Console.ReadLine();


            Console.WriteLine(@"Escolha o andar desejado:
            1 - primeiro andar Hall,
            2 - segundo andar Consultório,
            3 - terceiro andar Academia,
            4 - quarto andar Área de Lazer,
            5 - quinto andar Escritório,
            6 - sexto andar Cinema");
            resposta = Console.ReadLine(); //escolher o andar

            int Andar = int.Parse(Console.ReadLine());
            char Elevador = char.Parse(Console.ReadLine());

            if (Andar ==1) //retorno do andar
            {
                Console.WriteLine("Você chegou no Hall.");
            }
            else if (Andar ==2)
            {
                Console.WriteLine("Você chegou no Consultório.");
            }
            else if (Andar==3)
            {
                Console.WriteLine("Você chegou na Academia.");
            }
            else if (Andar ==4)
            {
                Console.WriteLine("Você chegou na Área de Lazer.");
            }
            else if (Andar ==5)
            {
                Console.WriteLine("Você chegou no Escritório.");
            }
            else if (Andar ==6)
            {
                Console.WriteLine("Você chegou no Cinema.");
            }
            else
            {
                Console.WriteLine("Você está no Térreo.");
            }

            Console.WriteLine(Andar); //selecionar o andar 3x para retornar
        }











    
    }
}

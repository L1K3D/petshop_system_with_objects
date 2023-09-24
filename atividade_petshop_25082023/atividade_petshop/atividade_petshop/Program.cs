//CEFSA - Centro Educacional da Fundação Salvador Arena;
//FESA - Faculdade Engenheiro Salvador Arena;
//Heitor Santos Ferreira - RA: 081230042;
//Engenharia de Computação - Terceiro Semestre - EC3;
//Professora: Leide Vieira | POO - Programação Orientada a Objetos;

using System;

namespace petshop___14082023
{
    class Program
    {

        static void Main(string[] args)
        {

            //Exibindo informações do autor do código
            Console.WriteLine("#---------------------------------------------------------------#");
            Console.WriteLine("CEFSA - Centro Educacional da Fundação Salvador Arena");
            Console.WriteLine("FESA - Faculdade Engenheiro Salvador Arena");
            Console.WriteLine("Heitor Santos Ferreira - RA: 081230042");
            Console.WriteLine("Engenharia de Computação - Terceiro Semestre - EC3");
            Console.WriteLine("Professora: Leide Vieira | POO - Programação Orientada a Objetos");
            Console.WriteLine("#---------------------------------------------------------------#");
            Console.WriteLine();

            Animal animalAlterador = new Animal(); //Criando variavel para evocar a lista de animais

            bool sair = false;

            while (!sair)
            {

                //Exibindo menu
                Console.WriteLine("#====Petshop===#");
                Console.WriteLine();
                Console.WriteLine("Escolha uma das opções abaixo:");
                Console.WriteLine("1 - Cadastrar novo animal;");
                Console.WriteLine("2 - Excluir um registro;");
                Console.WriteLine("3 - Alterar Cadastro;");
                Console.WriteLine("4 - Consultar Cadastro;");
                Console.WriteLine("0 - Sair.");
                Console.WriteLine();

                //Capturando a opção digitada pelo usuario
                Console.Write("Digite a opção: ");
                int opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine();

                switch (opcao)
                {

                    //Realizando ação de encerrar o sistema
                    case 0:
                        Console.WriteLine("Encerrando Sistema...");
                        Console.WriteLine();
                        sair = true;
                        break;

                    //Realizando ação de cadastro de animal
                    case 1:
                        animalAlterador.CadastrarAnimal();
                        break;

                    //Realizando ação de excluir registro
                    case 2:
                        animalAlterador.ExcluirRegistro();
                        break;

                    //Realizando alteração de cadastro
                    case 3:
                        animalAlterador.AlterarCadastro();
                        break;

                    //Realizando ação de consultar registro
                    case 4:
                        animalAlterador.ConsultarRegistro();
                        break;

                }
            }

        }
    }
}

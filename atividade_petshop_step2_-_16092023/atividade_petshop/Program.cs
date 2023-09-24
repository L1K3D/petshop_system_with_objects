//CEFSA - Centro Educacional da Fundação Salvador Arena;
//FESA - Faculdade Engenheiro Salvador Arena;
//Heitor Santos Ferreira - RA: 081230042;
//Engenharia de Computação - Terceiro Semestre - EC3;
//Professora: Leide Vieira | POO - Programação Orientada a Objetos;

using System;

namespace petshop
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
            Veterinario veterinarioAlterador = new Veterinario(); //Criando variavel para evocar a lista de veterinarios
            ConsultaMedica consultaMedicaAlterador = new ConsultaMedica(); //Criando variavel para evocar os métodos da classe "ConsulaMedica"

            bool sair = false; //Definindo modelo de saída

            //Definindo os termos que se encontram dentro de uma variuvel que exibem o menu principal do programa, essa variavel então passa a ser marcada como um 'chekpoint', no qual o programa pode retornar para esse mesmo ponto em qualquer momento
            MenuPrincipal:
            Console.WriteLine("#===== Sistema de Petshop =====#");
            Console.WriteLine();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1 - Animais");
            Console.WriteLine("2 - Consulta");
            Console.WriteLine("3 - Veterinarios;");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();

            //Solicitando do usuário uma opção
            Console.Write("Digite a opção: ");
            int opcao_menu_principal = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Criando laço de repetição dinâmico
            while (!sair)
            {

                switch (opcao_menu_principal)
                {
                    //Opção caso o usuário digite 0: Essa opção encerra o programa
                    case 0:
                        Console.WriteLine("Encerrando sistema...");
                        Console.WriteLine();
                        sair = true; //Define a variavel de saida como verdadeira e encerra o programa
                        break;

                    // Opção caso o usuário digite 1: Essa opção executa a exibição do submenu que trata a classe de animais.
                    case 1:
                        //Exibindo menu de animais
                        Console.WriteLine("#====Sistema de animais===#");
                        Console.WriteLine();
                        Console.WriteLine("Escolha uma das opções abaixo:");
                        Console.WriteLine("1 - Cadastrar novo animal;");
                        Console.WriteLine("2 - Excluir um registro;");
                        Console.WriteLine("3 - Alterar Cadastro;");
                        Console.WriteLine("4 - Consultar Cadastro;");
                        Console.WriteLine("5 - Voltar ao menu princpal;");
                        Console.WriteLine("0 - Sair.");
                        Console.WriteLine();

                        //Capturando a opção digitada pelo usuario
                        Console.Write("Digite a opção: ");
                        int opcao_animais = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine();

                        switch (opcao_animais)
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
                                Console.WriteLine();
                                break;

                            //Realizando ação de excluir registro
                            case 2:
                                animalAlterador.ExcluirRegistro();
                                Console.WriteLine();
                                break;

                            //Realizando alteração de cadastro
                            case 3:
                                animalAlterador.AlterarCadastro();
                                Console.WriteLine();
                                break;

                            //Realizando ação de consultar registro
                            case 4:
                                animalAlterador.ConsultarRegistro();
                                Console.WriteLine();
                                break;

                            //Realizando a ação de retonar ao menu principal
                            case 5:
                                Console.WriteLine("Retornando ao menu principal...");
                                Console.WriteLine();
                                goto MenuPrincipal;

                            //Caso o usuário digite uma opção que não está no menu, retorna a mensagem de que a opção não existe/é invalida
                            default:
                                Console.WriteLine("Opção Inválida...");
                                break;

                        }

                        break;

                    //Opção caso o usuário digite 2: Essa opção executa a exibição de sumbenu que trata a classe de ConsultaMedica
                    case 2:
                        //Exibindo menu de consulta
                        Console.WriteLine("#=====Sistema de consulta====#");
                        Console.WriteLine();
                        Console.WriteLine("1 - Registrar consulta;");
                        Console.WriteLine("2 - Exibir Consultas registradas;");
                        Console.WriteLine("3 - Retornar ao menu principal;");
                        Console.WriteLine("0 - Sair");
                        Console.WriteLine();

                        //Capturando a opção digitada pelo usuário
                        Console.Write("Digite a opção: ");
                        int opcao_consulta = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        switch (opcao_consulta)
                        {

                            //Realizando a ação de encerrar o sistema
                            case 0:
                                Console.WriteLine("Encerrando sistema");
                                Console.WriteLine();
                                sair = true;
                                break;

                            //Realizando a ação de registrar uma consulta
                            case 1:
                                consultaMedicaAlterador.RegistraConsulta();
                                Console.WriteLine();
                                break;

                            //Realizando a ação de Exibir uma consulta
                            case 2:
                                consultaMedicaAlterador.ExibirConsulta();
                                Console.WriteLine();
                                break;

                            //Realizando a ação de retornar ao menu principal
                            case 3:
                                Console.WriteLine("Retornando ao menu principal...");
                                Console.WriteLine();
                                goto MenuPrincipal;

                            //Caso o usuário digite uma opção que não está no menu, retorna a mensagem de que a opção não existe/é invalida
                            default:
                                Console.WriteLine("Opção inválida");
                                break;

                        }

                        break;

                    //Opção caso o usuário digite 3: Essa opção executa a exibição de sumbenu que trata a classe de Veterinario
                    case 3:
                        //Exibindo menu de veterinarios
                        Console.WriteLine("#=====Sistema dos Veterinários=====#");
                        Console.WriteLine();
                        Console.WriteLine("1 - Cadastrar novo Veterinário;");
                        Console.WriteLine("2 - Excluir um registro;");
                        Console.WriteLine("3 - Alterar cadastro;");
                        Console.WriteLine("4 - Consultar cadastro;");
                        Console.WriteLine("5 - Voltar para o menu principal;");
                        Console.WriteLine("0 - Sair da aplicação");
                        Console.WriteLine();

                        Console.Write("Digite a opção: ");
                        int opcao_veterinario = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine();

                        switch (opcao_veterinario)
                        {

                            //Realizando ação de encerrar o sistema
                            case 0:
                                Console.WriteLine("Encerrando Sistema...");
                                Console.WriteLine();
                                sair = true;
                                break;

                            //Realizando ação de cadastro de Veterinario
                            case 1:
                                veterinarioAlterador.CadastrarVeterinario();
                                Console.WriteLine();
                                break;

                            //Realizando ação de excluir registro
                            case 2:
                                veterinarioAlterador.ExcluirRegistro();
                                Console.WriteLine();
                                break;

                            //Realizando alteração de cadastro
                            case 3:
                                veterinarioAlterador.AlterarCadastro();
                                Console.WriteLine();
                                break;

                            //Realizando ação de consultar registro
                            case 4:
                                veterinarioAlterador.ConsultarRegistro();
                                Console.WriteLine();
                                break;

                            //Realizando a ação de retornar ao menu principal
                            case 5:
                                Console.WriteLine("Retornando ao menu principal...");
                                Console.WriteLine();
                                goto MenuPrincipal;

                            //Caso o usuário digite uma opção que não está no menu, retorna a mensagem de que a opção não existe/é invalida
                            default:
                                Console.WriteLine("Opção inválida");
                                break;

                        }

                        break;

                    //Caso o usuário digite uma opção que não está no menu, retorna a mensagem de que a opção não existe/é invalida
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }

        }
    }
}

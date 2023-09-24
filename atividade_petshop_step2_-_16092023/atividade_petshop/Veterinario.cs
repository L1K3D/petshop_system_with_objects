//CEFSA - Centro Educacional da Fundação Salvador Arena;
//FESA - Faculdade Engenheiro Salvador Arena;
//Heitor Santos Ferreira - RA: 081230042;
//Engenharia de Computação - Terceiro Semestre - EC3;
//Professora: Leide Vieira | POO - Programação Orientada a Objetos;

using System;
using System.Collections.Generic;

namespace petshop
{
    class Veterinario
    {

        //Declarando atributos da classe
        private string nomeVet;
        private string especialidade;
        private int crmv;
        private string diasTrabalho;

        //Instanciando uma lista para que o programa possa ceriar varios registros de veterinario
        public static List<Veterinario> veterinarios = new List<Veterinario>();

        //Criando método que realiza o cadastro do veterinário
        public void CadastrarVeterinario()
        {
            //Criando um novo item para ser atribuido para a lista
            Veterinario novoVeterinario = new Veterinario();

            Console.WriteLine("#---Sistema de cadastro de novo veterinário---#");
            Console.Write("Digite o nome do veterinario: "); //Capturando o nome do veterinatio
            novoVeterinario.nomeVet = Console.ReadLine().ToUpper();
            Console.Write("Digite a especialidade do veterinario: "); //Capturando a especialidade do veterinario
            novoVeterinario.especialidade = Console.ReadLine().ToUpper();
            Console.Write("Digite o CRMV: "); //Capturando o CRMV do veterinario
            novoVeterinario.crmv = int.Parse(Console.ReadLine());
            Console.Write("Digite os dias em que o veterinario irá trabalhar. Ex: Seg, Ter...: "); //Capturando os dias em que a pessoa trabalha
            novoVeterinario.diasTrabalho = Console.ReadLine();

            //Exibindo os dados cadastrados recentemente
            Console.WriteLine();
            Console.WriteLine("Os dados digitados foram: ");
            Console.WriteLine("Nome do veterinario: " + novoVeterinario.nomeVet);
            Console.WriteLine("Especialidade: " + novoVeterinario.especialidade);
            Console.WriteLine("CRMV: " + novoVeterinario.crmv);
            Console.WriteLine("Dias de trabalho: " + novoVeterinario.diasTrabalho);
            Console.WriteLine();

            //Criando interação com o usuário para confrimação de inserção dos dados cadastrados
            Console.WriteLine("Digite 1 para confirmar ou 0 para descartar os dados digitados");
            Console.WriteLine("Resposta: ");
            int opcao_digitado = int.Parse(Console.ReadLine());

            if (opcao_digitado == 1)
            {
                if (veterinarios == null)
                {
                    veterinarios = new List<Veterinario>();
                }
                veterinarios.Add(novoVeterinario);

                Console.WriteLine("Veterinario cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Dados descartados");
            }

            Console.WriteLine();
        }

        //Criando método que realiza a exclusão de um cadastro de um Veterinário
        public void ExcluirRegistro()
        {
            Console.WriteLine("#---Sistema de exclusão de cadastro de veterinario---#");
            Console.Write("Digite CRMV do veterinário que você deseja excluir do cadastro: ");
            int busca_veterinario_consultado = int.Parse(Console.ReadLine()); //Obtendo resposta digitada

            bool verifica_veterinario_consultado = false; //Criando variavel de condição de checagem

            foreach (Veterinario veterinario in veterinarios) //Criando laço de repetição para checagem dos códigos do Veterinário 
            {
                if (veterinario.crmv == busca_veterinario_consultado) //Caso o CRMV do veterinário digitado seja encontrado, realiza os passos dentro do "if"
                {
                    verifica_veterinario_consultado = true;
                    Console.Write("Tem certeza que você deseja excluir esse cadastro abaixo?");
                    Console.WriteLine();
                    Console.WriteLine("Nome do veterinario:  " + veterinario.nomeVet);
                    Console.WriteLine("Especialidade: " + veterinario.especialidade);
                    Console.WriteLine("CRMV: " + veterinario.crmv);
                    Console.WriteLine("Dias de trabalho: " + veterinario.diasTrabalho);
                    Console.WriteLine();

                    Console.WriteLine("1 -> SIM | 0 -> NÃO");
                    int resposta_pergunta = int.Parse(Console.ReadLine()); //Captura a resposta obtida para variações de "Sim" ou "Não"

                    if (resposta_pergunta == 1)
                    {
                        veterinarios.Remove(veterinario); //Remove o item consultado da lista
                        Console.WriteLine("Cadastro excluido!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Cadastro mantido.");
                        break;
                    }

                }
            }

            if (!verifica_veterinario_consultado) //Caso o CRMV do veterinário digitado não esteja na lista de consulta, retorna a mensagem
            {
                Console.WriteLine("Veterinario não encontrado!");
            }
        }

        //Criando método de alteração de registros de um veterinário
        public void AlterarCadastro()
        {
            Console.WriteLine("#---Sistema de alteração de cadastro de veterinario---#");
            Console.Write("Digite o CRMV do veterinario que você deseja alterar o cadastro: ");
            int busca_veterinario_consultado = int.Parse(Console.ReadLine()); //Obtendo resposta digitada

            bool verifica_veterinario_consultado = false; //Criando variavel de condição de checagem

            foreach (Veterinario veterinario in veterinarios) //Criando laço de repetição para checagem dos códigos do Veterinário 
            {

                if (veterinario.crmv == busca_veterinario_consultado) //Caso o CRMV do veterinário digitado seja encontrado, realiza os passos dentro do "if"
                {

                    //Cria interação com usuário para dupla verificação de alteração de cadastro consultado
                    verifica_veterinario_consultado = true;
                    Console.Write("Tem certeza que você deseja excluir esse cadastro abaixo?");
                    Console.WriteLine();
                    Console.WriteLine("Nome do veterinario:  " + veterinario.nomeVet);
                    Console.WriteLine("Especialidade: " + veterinario.especialidade);
                    Console.WriteLine("CRMV: " + veterinario.crmv);
                    Console.WriteLine("Dias de trabalho: " + veterinario.diasTrabalho);
                    Console.WriteLine();

                    Console.WriteLine("1 -> SIM | 0 -> NÃO");
                    int resposta_pergunta = int.Parse(Console.ReadLine()); //Obtem a resposta digitada

                    if (resposta_pergunta == 1) //Verifica a resposta digitada para inicar o processo de alteração de cadastro ou de mantimento do cadastro
                    {
                        Console.Write("Digite o novo nome do veterinario: ");
                        veterinario.nomeVet = Console.ReadLine().ToUpper();

                        Console.Write("Digite a nova especialidade do veterinario: ");
                        veterinario.especialidade = Console.ReadLine().ToUpper();

                        Console.Write("Digite o novo crmv do veterinario: ");
                        veterinario.crmv = int.Parse(Console.ReadLine());

                        Console.Write("Digite os novos dias trabalhados do veterinario: ");
                        veterinario.diasTrabalho = Console.ReadLine();

                        Console.WriteLine("Cadastro alterado");
                    }
                    else
                    {
                        Console.WriteLine("Cadastro mantido.");
                        break;
                    }
                }

            }

            if (!verifica_veterinario_consultado) //Caso o CRMV do veterinário digitado não esteja na lista de consulta, retorna a mensagem
            {
                Console.WriteLine("Veterinario não encontrado!");
            }
        }

        //Criando método que realiza a consulta de cada registro
        public void ConsultarRegistro()
        {
            Console.WriteLine("#---Sistema de consulta de cadastro de veterinario---#");
            Console.Write("Digite o CRMV do veterinario que você deseja consultar: ");
            int busca_veterinario_consultado = int.Parse(Console.ReadLine()); //Obtendo resposta digitada

            bool verifica_veterinario_consultado = false; //Criando variavel de condição de checagem

            foreach (Veterinario veterinario in veterinarios)  //Criando laço de repetição para checagem dos códigos do Veterinário 
            {
                if (veterinario.crmv == busca_veterinario_consultado) //Caso o CRMV do veterinário digitado seja encontrado, realiza os passos dentro do "if"
                {
                    verifica_veterinario_consultado = true;
                    Console.WriteLine("Veterinario encontrado! Confira as informações abaixo");
                    Console.WriteLine();
                    Console.WriteLine("Nome do veterinario:  " + veterinario.nomeVet);
                    Console.WriteLine("Especialidade: " + veterinario.especialidade);
                    Console.WriteLine("CRMV: " + veterinario.crmv);
                    Console.WriteLine("Dias de trabalho: " + veterinario.diasTrabalho);
                    Console.WriteLine();
                    break;
                }
            }

            if (!verifica_veterinario_consultado)
            {
                Console.WriteLine("Veterinario não encontrado!");
            }

        }

    }
}

//CEFSA - Centro Educacional da Fundação Salvador Arena;
//FESA - Faculdade Engenheiro Salvador Arena;
//Heitor Santos Ferreira - RA: 081230042;
//Engenharia de Computação - Terceiro Semestre - EC3;
//Professora: Leide Vieira | POO - Programação Orientada a Objetos;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop___14082023
{
    class Animal
    {
        //Declarando atributos da classe
        private string nome;
        private string especie;
        private DateTime datanascimento;
        private string raca;
        private double peso;

        public static List<Animal> animais = new List<Animal>();

        //Criando método que realiza cadastro do animal
        public void CadastrarAnimal()
        {

            Animal novoAnimal = new Animal();

            //*OBS -> As condições "if" das respostas são condicionadas a partir de um método que será declarado futuramente, chamado de Limpar dados
            Console.WriteLine("#---Sistema de cadastro de novo animal---#");
            Console.WriteLine("->Pressione '0' a qualquer momento dessa estapa para limpar os dados<-#");
            Console.Write("Digite o nome do animal: "); //Capturando o nome do animal
            novoAnimal.nome = Console.ReadLine().ToUpper();

            if (novoAnimal.nome == "0")
            {
                LimparDados();
            }

            Console.Write("Digite a espécie desse animal: "); //Capturando a especie do animal
            novoAnimal.especie = Console.ReadLine().ToUpper();

            if (novoAnimal.especie == "0")
            {
                LimparDados();
            }

            Console.Write("Digite a data de nascimento desse animal (dd/mm/aaaa): "); //Capturando a data de nascimento do animal
            novoAnimal.datanascimento = DateTime.Parse(Console.ReadLine());

            if (novoAnimal.datanascimento.ToString() == "0")
            {
                LimparDados();
            }

            Console.Write("Digite a raça desse animal: "); //Capturando a raça do animal
            novoAnimal.raca = Console.ReadLine().ToUpper();

            if (novoAnimal.raca == "0")
            {
                LimparDados();
            }

            Console.Write("Digite o peso desse animal: "); //Capturando o peso do animal
            novoAnimal.peso = double.Parse(Console.ReadLine());

            if (novoAnimal.peso.ToString() == "0")
            {
                LimparDados();
            }

            //Exibindo os dados cadastrados recentemente
            Console.WriteLine();
            Console.WriteLine("Os dados digitados foram: ");
            Console.WriteLine("Nome: " + novoAnimal.nome);
            Console.WriteLine("Especie: " + novoAnimal.especie);
            Console.WriteLine("Data de nascimento: " + novoAnimal.datanascimento.ToString("dd/MM/yyyy"));
            Console.WriteLine("Raça: " + novoAnimal.raca);
            Console.WriteLine("Peso: " + novoAnimal.peso);
            Console.WriteLine();

            Console.WriteLine("Digite 1 para confirmar ou 0 para descartar os dados digitados");
            Console.WriteLine("Resposta: ");
            int opcao_digitado = int.Parse(Console.ReadLine());

            if (opcao_digitado == 1)
            {
                if (animais == null)
                {
                    animais = new List<Animal>();
                }
                animais.Add(novoAnimal);

                Console.WriteLine("Animal cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Dados descartados");
            }

            Console.WriteLine();
        }

        //Criando método para Excluir Registro
        public void ExcluirRegistro()
        {
            Console.WriteLine("#---Sistema de exclusão de cadastro de animal---#");
            Console.Write("Digite o nome do animal que você deseja excluir: ");
            string busca_animal_consultado = Console.ReadLine().ToUpper(); //Obtendo resposta digitada

            bool verifica_animal_consultado = false; //Criando variavel de condição de checagem

            foreach (Animal animal in animais) //Criando laço de repetição para checagem dos códigos dos animais 
            {
                if (animal.nome == busca_animal_consultado) //Caso o nome do animal digitado seja encontrado, realiza os passos dentro do "if"
                {
                    verifica_animal_consultado = true;
                    Console.Write("Tem certeza que você deseja excluir esse cadastro abaixo?");
                    Console.WriteLine();
                    Console.WriteLine("Nome do animal: " + animal.nome);
                    Console.WriteLine("Espécie do animal: " + animal.especie);
                    Console.WriteLine("Data de nascimento do animal: " + animal.datanascimento);
                    Console.WriteLine("Raça do animal: " + animal.raca);
                    Console.WriteLine("Peso do animal: " + animal.peso);
                    Console.WriteLine();

                    Console.WriteLine("1 -> SIM | 0 -> NÃO");
                    int resposta_pergunta = int.Parse(Console.ReadLine()); //Captura a resposta obtida para variações de "Sim" ou "Não"

                    if (resposta_pergunta == 1)
                    {
                        animais.Remove(animal); //Remove o item consultado da lista
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

            if (!verifica_animal_consultado) //Caso o nome do animal não esteja na lista de consulta, retorna a mensagem
            {
                Console.WriteLine("Animal não encontrado!");
            }
        }

        //Criando método para limpar os dados inserios
        public void LimparDados()
        {
            nome = null;
            especie = null;
            datanascimento = DateTime.MinValue;
            raca = null;
            peso = 0;
        }

        //Criando método para Alterar Cadastro de um animal especifico presente na lista
        public void AlterarCadastro()
        {
            Console.WriteLine("#---Sistema de alteração de cadastro de animal---#");
            Console.Write("Digite o nome do animal que você deseja alterar o cadastro: ");
            string busca_animal_consultado = Console.ReadLine().ToUpper();

            bool verifica_animal_consultado = false;

            foreach (Animal animal in animais)
            {

                if (animal.nome == busca_animal_consultado)
                {
                    verifica_animal_consultado = true;
                    Console.WriteLine("Tem certeza que você deseja alterar esse cadastro?");
                    Console.WriteLine();
                    Console.WriteLine("Nome do animal: " + animal.nome);
                    Console.WriteLine("Espécie do animal: " + animal.especie);
                    Console.WriteLine("Data de nascimento do animal: " + animal.datanascimento.ToString("dd/MM/yyyy"));
                    Console.WriteLine("Raça do animal: " + animal.raca);
                    Console.WriteLine("Peso do animal: " + animal.peso);
                    Console.WriteLine();

                    Console.WriteLine("1 -> SIM | 0 -> NÃO");
                    int resposta_pergunta = int.Parse(Console.ReadLine());

                    if (resposta_pergunta == 1)
                    {
                        Console.Write("Digite o novo nome do animal: ");
                        animal.nome = Console.ReadLine().ToUpper();

                        Console.Write("Digite a nova espécie do animal: ");
                        animal.especie = Console.ReadLine().ToUpper();

                        Console.Write("Digite a nova data de nascimento do animal: ");
                        animal.datanascimento = DateTime.Parse(Console.ReadLine());

                        Console.Write("Digite a nova raça do animal: ");
                        animal.raca = Console.ReadLine().ToUpper();

                        Console.Write("Digite o novo peso do animal: ");
                        animal.peso = double.Parse(Console.ReadLine());

                        Console.WriteLine("Cadastro alterado");
                    }
                    else
                    {
                        Console.WriteLine("Cadastro mantido.");
                        break;
                    }
                }

            }

            if (!verifica_animal_consultado)
            {
                Console.WriteLine("Animal não encontrado!");
            }
        }

        //Criando método de Consulta de Registro

        public void ConsultarRegistro()
        {
            Console.WriteLine("#---Sistema de consulta de cadastro de animal---#");
            Console.Write("Digite o nome do animal que você deseja consultar: ");
            string busca_animal_consultado = Console.ReadLine().ToUpper();

            bool verifica_animal_consultado = false;

            foreach (Animal animal in animais) //Percorre toda a lista buscando o nome do animal digitado
            {
                if (animal.nome == busca_animal_consultado)
                {
                    verifica_animal_consultado = true;
                    Console.WriteLine("Animal encontrado! Confira as informações abaixo");
                    Console.WriteLine();
                    Console.WriteLine("Nome do animal: " + animal.nome);
                    Console.WriteLine("Espécie do animal: " + animal.especie);
                    Console.WriteLine("Data de nascimento do animal: " + animal.datanascimento.ToString("dd/MM/yyyy"));
                    Console.WriteLine("Raça do animal: " + animal.raca);
                    Console.WriteLine("Peso do animal: " + animal.peso);
                    Console.WriteLine();
                    break;
                }
            }

            if (!verifica_animal_consultado)
            {
                Console.WriteLine("Animal não encontrado!");
            }

        }


    }
}

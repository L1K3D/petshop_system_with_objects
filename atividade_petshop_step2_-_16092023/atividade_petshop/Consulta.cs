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

namespace petshop
{
    class ConsultaMedica
    {

        //Declarando atributos da classe
        private int codigoConsulta;
        private DateTime dataConsulta;
        private string motivoConsulta;
        private string tratamento;

        //Instanciando uma lista para que o programa possa ceriar varios registros de Consultas Médicas
        public static List<ConsultaMedica> consultas = new List<ConsultaMedica>();

        //Criando novo método que registra as consultas
        public void RegistraConsulta()
        {
            //Cria um novo objeto com as caracteristicas da classe de Consulta Médica
            ConsultaMedica novaConsulta = new ConsultaMedica();

            //Cria uma instancia de aletoriedade onde define um número aletario para consulta
            Random random = new Random();
            novaConsulta.codigoConsulta = random.Next(1, 100);

            //Captura a data local e em tempo real/exata em que a consulta ocorre por meio do termo sistêmico "DateTime.Now"
            novaConsulta.dataConsulta = DateTime.Now;

            //Exibe algumas informações obtidas sistemicamente e solicita do usuário novas informações para completar o processo de registro de uma consulta
            Console.WriteLine("#===== Registro de consulta =====#");
            Console.WriteLine("Código da consulta: " + novaConsulta.codigoConsulta);
            Console.WriteLine("Data da consulta: " + novaConsulta.dataConsulta.ToString("dd/mm/yyyy | hh:nn"));
            Console.Write("Digite o motivo da consulta: ");
            novaConsulta.motivoConsulta = Console.ReadLine(); //Capturando o motivo da consulta
            Console.WriteLine("Informe o tratamento indicado ou remédio a ser receitado: ");
            novaConsulta.tratamento = Console.ReadLine(); //Capturando o tratamento sugerido

            //Caso a lista de consultas não esteja instanciada ainda, realiza a criação da mesma
            if (consultas == null)
            {
                consultas = new List<ConsultaMedica>();
            }
            consultas.Add(novaConsulta); //Adiciona o nov cadastro a lista

        }

        //Criando novo método que exibe todas as consultas registradas
        public void ExibirConsulta()
        {

            Console.WriteLine("#=====Consultas registradas=====#");
            Console.WriteLine();

            foreach(ConsultaMedica consulta in consultas) //Cria laço de repetição dinâmico onde percorre toda a lista de consultas e exibe as informações de cada uma delas
            {

                Console.WriteLine("#===== Dados cadastrados =====#");
                Console.WriteLine("Código da consulta: " + consulta.codigoConsulta);
                Console.WriteLine("Data/hora da consulta: " + consulta.dataConsulta);
                Console.WriteLine("Motivo da consulta: " + consulta.motivoConsulta);
                Console.WriteLine("Motivo da consulta: " + consulta.motivoConsulta);
                Console.WriteLine("Tratamento indicado: " + consulta.tratamento);
                Console.WriteLine();

            }

        }
    }
}

using PrincipiosSolid.Models.ISP.QuebrandoRegras;
using PrincipiosSolid.Models.ISP.Solucao;
using PrincipiosSolid.Models.LSP.Solucao;
using PrincipiosSolid.Models.OCP.Solucao;
using PrincipiosSolid.Models.SRP.Solucao;
using System;

namespace PrincipiosSolid
{
    internal class Program
    {
        public static void ImprimirNome(A objeto)
        {
            objeto.GetNome();
        }
        static void Main(string[] args)
        {
            APagamento cliente = new PrincipiosSolid.Models.ISP.Solucao.Cliente();
            Models.ISP.Solucao.IGenerica produto = new PrincipiosSolid.Models.ISP.Solucao.Produto();
            APagamento fornecedor = new PrincipiosSolid.Models.ISP.Solucao.Fornecedor();
            //var objetoA = new A();
            //var objetoB = new B();

            //ImprimirNome(objetoB);
            //IPessoa pessoa = new Fisica();
            //IPessoa pessoaJuridica = new Juridica();

            //var cliente = new Cliente();
            //var repositorioCliente = new ClienteRepositorio();
            //var clienteValidacao = new ClienteValidacao();
            //var sms = new SMS();

            //cliente.Id = 1;
            //cliente.Nome = "Maria";
            //cliente.Telefone = "1499999999";
            //cliente.Cpf = "324234234243";

            //try
            //{
            //    clienteValidacao.ValidandoDados(cliente);
            //    repositorioCliente.Salvar(ref cliente);
            //    sms.EnviarSMS();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Erro ao validar. "+ ex.Message);
            //}

        }
    }
}

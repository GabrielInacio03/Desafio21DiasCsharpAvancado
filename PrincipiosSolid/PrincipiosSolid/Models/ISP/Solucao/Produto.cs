using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.Models.ISP.Solucao
{
    public class Produto : IGenerica
    {
        public int Id { get; set; }

        public Produto() { }

        public void Excluir()
        {
            Console.WriteLine("excluindo");
        }

        public void Salvar()
        {
            Console.WriteLine("Salvando");
        }
        public void Alterar()
        {
            Console.WriteLine("Salvando");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.Models.ISP.QuebrandoRegras
{
    public class Cliente : IGenerica
    {
        public int Id { get; set; }

        public Cliente() { }
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

        public void Pagar()
        {
            throw new NotImplementedException();
        }
    }
}

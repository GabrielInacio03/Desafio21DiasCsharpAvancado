using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PrincipiosSolid.Generics
{
    [Table(Name = "tbl_clientes")]
    internal class Cliente : ABase<Cliente>
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }

        public Cliente() { }

        public bool EnviarSMS()
        {
            Console.WriteLine("Enviando SMS...");
            return true;
        }
        
    }
}

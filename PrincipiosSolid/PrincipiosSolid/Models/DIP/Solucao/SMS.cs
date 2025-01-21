using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.Models.DIP.Solucao
{
    public class SMS : ISMS
    {
        public string De { get; set; }
        public string Para { get; set; }

        public bool EnviarSMS()
        {
            Console.WriteLine($"Enviando SMS De: {this.De} Para: {this.Para}");
            return true;
        }
    }
}

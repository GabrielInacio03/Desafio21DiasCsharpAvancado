using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PrincipiosSolid.Generics
{
    public class Produto : ABase<Produto>
    {
        public string Nome { get; set; }
        
    }
}

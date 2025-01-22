using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PrincipiosSolid.Generics
{
    public class Pedido : ABase<Pedido>
    {
        public double ValorTotal { get; set; }
        
    }
}

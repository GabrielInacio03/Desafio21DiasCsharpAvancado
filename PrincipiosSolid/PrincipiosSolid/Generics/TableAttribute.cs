using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.Generics
{
    public class TableAttribute : Attribute
    {
        public string Name { get; set; }
        public string PrimaryKey { get; set; }
        public string Collection { get; set; }
        public string ForeignKey { get; set; }
        public string IsNotOnDataBase { get; set; }
    }
}

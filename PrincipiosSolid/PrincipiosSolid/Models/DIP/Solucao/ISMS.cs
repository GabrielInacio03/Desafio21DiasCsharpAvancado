using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.Models.DIP.Solucao
{
    public interface ISMS
    {
        string De {  get; set; }
        string Para { get; set; }
        bool EnviarSMS();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.Models.DIP.QuebrandoRegras
{
    public class SMS
    {
        public bool EnviarSMS()
        {
            Console.WriteLine("Enviando SMS...");
            return true;
        }
    }
}

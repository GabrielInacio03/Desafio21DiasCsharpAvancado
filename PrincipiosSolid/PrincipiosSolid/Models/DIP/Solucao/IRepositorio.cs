using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.Models.DIP.Solucao
{
    public interface IRepositorio
    {
        void Salvar(ref Cliente cliente);
    }
}

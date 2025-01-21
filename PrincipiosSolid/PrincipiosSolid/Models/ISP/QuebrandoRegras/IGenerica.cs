using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.Models.ISP.QuebrandoRegras
{
    public interface IGenerica
    {
        int Id { get; set; }

        void Salvar();
        void Excluir();
        void Alterar();
        void Pagar();
    }
}

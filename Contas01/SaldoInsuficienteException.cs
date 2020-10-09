using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas01
{
    class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException(string mesagem)
            : base(mensagem)
        {
             
        }
           
    }
}

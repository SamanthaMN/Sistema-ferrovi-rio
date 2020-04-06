using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Trem
{
    class Classe_da_telaFinal
    {

        public int sorteado;

        public int Sorteio_Numero()
        {
            Random rnd = new Random();
            sorteado = rnd.Next(1, 200);
            return sorteado;
        }
    }
}

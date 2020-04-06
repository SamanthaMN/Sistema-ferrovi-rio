using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Trem
{
    class Classe_de_Pagamento
    {

        public int tagOrigem, tagDestino, numTrechos;
        public double total, valor;

        public void calcular(int tagO, int tagD, int passagens)
        {
            tagOrigem = 1 + tagO;
            tagDestino = 1 + tagD;
            numTrechos = tagDestino - tagOrigem;
            valor = Convert.ToDouble(numTrechos);
            total = valor * 2.50 * passagens;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Trem
{
    public class Classe_dos_destinos
    {
        public int origem_passagem;
        public string origem_nome;
        public int destino_passagem;
        public string destino_nome;

        public static string[] destin = { "Philadelphia", "Pensauken", "Lindenwold", "Atco", "Egg Harbor City", "Atlantic City" };

        public void CidadesOrigem(int Num_Tag)
        {
            if (Num_Tag >= 0)
            {
                string nome;
                //guardando o numero do destino para a passagem
                origem_passagem = Num_Tag + 1;
                nome = destin[Num_Tag];
                origem_nome = nome;
            }
        }
        public void CidadesDestino(int Num_Tag)
        {
            if (Num_Tag >= 0)
            {
                string nome;
                //guardando o numero do destino para a passagem
                destino_passagem = Num_Tag + 1;
                nome = destin[Num_Tag];
                destino_nome = nome;
            }
        }
    }
}

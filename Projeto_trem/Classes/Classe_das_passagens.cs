using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Trem
{
    class Classe_das_passagens
    {
        
        public static int[,] capacidade_trem = new int[14,0];
        public int Quantidade_passagem, Tag_horario;



        public void popular_trem(int taghorario, int QuantTicket)
        {
            Quantidade_passagem = QuantTicket;
            Tag_horario = taghorario;

            foreach (var c in capacidade_trem)
            {
                foreach (var l in capacidade_trem)
                {
                    if (l <= 14 && l == 0 && c == 0)
                    {
                        throw new Exception("Trem cheio");
                    }
                    else
                    {
                        capacidade_trem[taghorario, l] = l + QuantTicket;
                    }
                }

            }
        }   
    }
}


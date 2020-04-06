using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Trem
{
    public partial class Tela_final : Form
    {
        public Tela_final(string origem, string destino, int torigem, int tdestino, int trecho)
        {
            InitializeComponent();
            Classe_da_telaFinal classeFinal = new Classe_da_telaFinal();
            Classe_das_passagens classePassagem = new Classe_das_passagens();

            Label_Torigem.Text = Convert.ToString(torigem);
            label_Tdest.Text = Convert.ToString(tdestino);
            label_Ntrechos.Text = Convert.ToString(trecho);
            Label_Qtrem.Text = Convert.ToString(classePassagem.Quantidade_passagem);
            
            label_embarque.Text = origem;
            label_desembarque.Text = destino;

            num_sorteado.Text = Convert.ToString(classeFinal.Sorteio_Numero());
        }

        private void button_Fcompra_Click(object sender, EventArgs e)
        {
            Tela_Inicial voltar_inicio = new Tela_Inicial();
            voltar_inicio.Show();
            Hide();
        }
    }
}

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
    public partial class Pagamento_passagem : Form
    {
        private string nome_Origem, nome_Destino;
        public int ntrechos, tagOrigem, tagDestino, numero;

        private void ComfPag_botao_Click(object sender, EventArgs e)
        {
            Tela_final chamando_telaFinal = new Tela_final(nome_Origem, nome_Destino, tagOrigem, tagDestino, ntrechos);
            chamando_telaFinal.Show();
            Hide();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            Text_numCartao.Clear();
            Texto_CodSegun.Clear();
        }
        public Pagamento_passagem(string origem, int tagO, string destino,int tagD, int num_passagem)
        {
            InitializeComponent();

            tagOrigem = tagO;
            tagDestino = tagD;

            nome_Origem = origem;
            EmbLabel.Text = nome_Origem;

            nome_Destino = destino;
            DesemLabel.Text = nome_Destino;

            Classe_de_Pagamento informacoesLabel = new Classe_de_Pagamento();
            informacoesLabel.calcular(tagO, tagD, num_passagem);
            ntrechos = informacoesLabel.numTrechos;
            label_Informacoes.Text = "Nº de passagens: " + num_passagem + "\nNº de trechos: " + informacoesLabel.numTrechos + "\nValor total: " + informacoesLabel.total ;
            
        }

        public void Escrever_label(object sender, EventArgs e)
        {
            if (Text_numCartao.Text.Length <= 15)
            {
                Button numBotton = (Button)sender;
                int numero = Convert.ToInt16(numBotton.Tag);
                Text_numCartao.Text += Convert.ToString(numero);
            }
            else if(Texto_CodSegun.Text.Length <= 2)
            {
                Button numBotton = (Button)sender;
                int numero2 = Convert.ToInt16(numBotton.Tag);
                Texto_CodSegun.Text += Convert.ToString(numero2);
            }
        }
     }
}

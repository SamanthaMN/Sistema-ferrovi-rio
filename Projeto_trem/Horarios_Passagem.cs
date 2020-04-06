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
    public partial class Horarios_Passagem : Form
    {
        //atributos para mostrar na label a origem e o destino
        private string nomeOrigem, nomeDestino;

        private Classe_dos_destinos botaovoltar;

        //Instanciando a classe para pegar os obejtos de origem
        Classe_dos_destinos cd = new Classe_dos_destinos();

        public int tagOring, tagDest, botaoVoltar;

        //Mostrando nas label
        public Horarios_Passagem(Classe_dos_destinos o, int tagO , Classe_dos_destinos d, int tagD)
        {
            InitializeComponent();

            nomeOrigem = o.origem_nome.ToString();
            LabelEmbarque.Text = nomeOrigem;

            nomeDestino = d.destino_nome.ToString();
            LabelDesembarque.Text = nomeDestino;

            tagOring = tagO;
            tagDest = tagD;
            desabilitarTemporario();
        }


        private void horarios_botoes(object sender, EventArgs e)
        {
            Button d = (Button)sender;
            //instanciamento para metodo popular
            Classe_das_passagens Tag_passagens = new Classe_das_passagens();
            Tag_passagens.popular_trem(Convert.ToInt32(d.Tag), Convert.ToInt32(NumPassagens.Text));
        }

        private void Comprar_Click(object sender, EventArgs e)
        {
            Pagamento_passagem GuardandoInformacoes = new Pagamento_passagem(nomeOrigem, tagOring, nomeDestino, tagDest, Convert.ToInt32(NumPassagens.Text));
            GuardandoInformacoes.Show();
            Hide();
        }

        private void Voltar3_Click(object sender, EventArgs e)
        {
            EscolhaDestino voltandotela = new EscolhaDestino(botaovoltar, botaoVoltar);
            voltandotela.Show();
            Dispose();
        }

        private void Cancelar3_Click(object sender, EventArgs e)
        {
            //tem que validar esse botão bonita
            Tela_Inicial cancelando = new Tela_Inicial();
            cancelando.Show();
            Hide();
        }



        private void NumPassagens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NumPassagens.SelectedIndex > -1)
            {
                Hor7.Enabled = true;
                Hor8.Enabled = true;
                Hor9.Enabled = true;
                Hor10.Enabled = true;
                Hor11.Enabled = true;
                Hor12.Enabled = true;
                Hor13.Enabled = true;
                Hor14.Enabled = true;
                Hor15.Enabled = true;
                Hor16.Enabled = true;
                Hor17.Enabled = true;
                Hor18.Enabled = true;
                Hor19.Enabled = true;
                Hor20.Enabled = true;
                Hor21.Enabled = true;
            }
        }

        private void desabilitarTemporario()
        {
            if (NumPassagens.SelectedIndex == -1)
            {
                Hor7.Enabled = false;
                Hor8.Enabled = false;
                Hor9.Enabled = false;
                Hor10.Enabled = false;
                Hor11.Enabled = false;
                Hor12.Enabled = false;
                Hor13.Enabled = false;
                Hor14.Enabled = false;
                Hor15.Enabled = false;
                Hor16.Enabled = false;
                Hor17.Enabled = false;
                Hor18.Enabled = false;
                Hor19.Enabled = false;
                Hor20.Enabled = false;
                Hor21.Enabled = false;
            }
        }
    }
}

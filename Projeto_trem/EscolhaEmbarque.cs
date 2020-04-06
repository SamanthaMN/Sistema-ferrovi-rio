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
    public partial class EscolhaEmbarque : Form
    {
        public string nomeBotao;

        public EscolhaEmbarque()
        {
            InitializeComponent();
        }

        private void CanEscolhaEmbar_Click(object sender, EventArgs e)
        {
            Tela_Inicial login = new Tela_Inicial();
            login.Show();
            Hide();
        }
        public void ButtonsEmbarque_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Classe_dos_destinos TagOrigem = new Classe_dos_destinos();
            TagOrigem.CidadesOrigem(Convert.ToInt32(b.Tag));
            nomeBotao = b.Text;

            //Estou mandando para meu valor para o próximo Forms
            EscolhaDestino Guardando_origem = new EscolhaDestino(TagOrigem, Convert.ToInt32(b.Tag));
            Guardando_origem.Show();
            Hide();
        }
    }
}

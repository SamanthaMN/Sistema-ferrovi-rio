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
    public partial class EscolhaDestino : Form
    {
        public Classe_dos_destinos origem;
        public int tagOrig;

        public EscolhaDestino(Classe_dos_destinos o, int tagO)
        {
            InitializeComponent();
            origem = o;
            tagOrig = tagO;
            desabilitaDestino();
        }
        
        private void ButtonsDestino_Click(object sender, EventArgs e)
        {
            Button c = (Button)sender;
            Classe_dos_destinos Destino = new Classe_dos_destinos();
            Destino.CidadesDestino(Convert.ToInt32(c.Tag));

            //Guardando para o próximo
            Horarios_Passagem Guardarlugares = new Horarios_Passagem(origem,tagOrig,Destino, Convert.ToInt32(c.Tag));
            Guardarlugares.Show();
            Hide();
        }
        private void desabilitaDestino()
        {
            switch(tagOrig)
            {
                case 0:
                    PhiladelphiaButton.Enabled = false;
                    break;
                case 1:
                    PensaukenButton.Enabled = false;
                    break;
                case 2:
                    LindenwoldButton.Enabled = false;
                    break;
                case 3:
                    AtcoButton.Enabled = false;
                    break;
                case 4:
                    EggButton.Enabled = false;
                    break;
                case 5:
                    AtlantButton.Enabled = false;
                    break;
            }
        }


        private void CanEscolDestin_Click(object sender, EventArgs e)
        {
            Tela_Inicial login = new Tela_Inicial();
            login.Show();
            Hide();
        }

        private void VoltarTela_Click(object sender, EventArgs e)
        {
            EscolhaEmbarque VoltarTela = new EscolhaEmbarque();
            VoltarTela.Show();
            Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WForm_Trab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Jogador jog;
        Jogador[] vet = new Jogador[10];
        int i = 0;

        private void btmGravar_Click(object sender, EventArgs e)
        {
            if (i < 10)
            {
                jog = new Jogador();
                jog.Nome = txtNome.Text;
                jog.Peso = Convert.ToDouble(txtPeso.Text);
                jog.Altura = Convert.ToDouble(txtAltura.Text);
                jog.Idade = Convert.ToInt32(txtIdade.Text);
                jog.nCamisa = Convert.ToInt32(txtNumero.Text);
                jog.Time = txtTime.Text;
                vet[i] = jog;
                i++;
            }
            else
            {
                MessageBox.Show("Número máximo de jogadores atingido!");
            }


        }

        private void btmPesquisar_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 10; j++)
            {
                if (vet[j].Nome.Equals(txtNome.Text))
                {
                    txtNome.Text = vet[j].Nome;
                    txtPeso.Text = vet[j].Peso.ToString();
                    txtAltura.Text = vet[j].Altura.ToString();
                    txtIdade.Text = vet[j].Idade.ToString();
                    txtNumero.Text = vet[j].nCamisa.ToString();
                    txtTime.Text = vet[j].Time.ToString();
                    j = 9;
                }
                else
                {
                if (j == 9) MessageBox.Show("Jogador não encontrado!");
                }
            }
        }
    }
}

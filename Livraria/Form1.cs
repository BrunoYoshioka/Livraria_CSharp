using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LimparDados()
        {
            txtNomeDoLivro.Clear();
            txtQtdeVendida.Clear();
            cboCategoria.Text = "";
            txtValorPagar.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNomeDoLivro.Text != null && txtQtdeVendida.Text != null && txtValorPagar.Text != null && cboCategoria.Text != null)
            {
                MessageBox.Show("Todos os campos foram preenchidos.");
            }
            else
                MessageBox.Show("Preencha todos os campos!");
        }

        private void btnCalcValor_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // declarando variáveis
                    float valorPagar = 0;
                    int qtde = int.Parse(txtQtdeVendida.Text);
                    float LivroCategoria = 0;

                    if (cboCategoria.Text == "Romance" || cboCategoria.Text == "Aventura")
                        LivroCategoria = 10.00F;
                    else// if(cboCategoria.Text == "Ficção" || cboCategoria.Text == "Técnico" || cboCategoria.Text == "Científico")
                        LivroCategoria = 20.00F;

                    valorPagar = LivroCategoria * qtde;
                    txtValorPagar.Text = valorPagar.ToString();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao calcular: " + erro.Message);
                }
            }
        }
    }
}

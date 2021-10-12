using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_chapeu_seletor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            var lista = new List<string> { "Grifinória", "Lufa-Lufa", "Cornival", "Sonserina" };
            var rnd = new Random();
            var valorAleatorio = lista[rnd.Next(lista.Count)];
            string nome = txtNome.Text;
            MessageBox.Show(valorAleatorio, nome);
            if (valorAleatorio == "Grifinória")
            {
                grifinoria fmrgrifinoria = new grifinoria();
                fmrgrifinoria.Show();
                listNomeGrifinoria.Items.Add(txtNome.Text);
            }
            else
            {
                if (valorAleatorio == "Lufa-Lufa")
                {
                    lufa fmrlufa = new lufa();
                    fmrlufa.Show();
                    listNomeLufa.Items.Add(txtNome.Text);
                }
                else
                {
                    if(valorAleatorio == "Cornival")
                    {
                        cornival fmrcornival = new cornival();
                        fmrcornival.Show();
                        listNomeCornival.Items.Add(txtNome.Text);
                    }
                    else
                    {
                        if(valorAleatorio == "Sonserina")
                        {
                            sonserina fmrsonserina = new sonserina();
                            fmrsonserina.Show();
                            listNomeSonserina.Items.Add(txtNome.Text);
                        }
                    }
                }
            }

            

            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja mesmo sair? ", "Mensagem do sistema ", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sobreToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SobreBox sobre = new SobreBox();
            sobre.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

  


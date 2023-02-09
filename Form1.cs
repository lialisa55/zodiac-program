using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zodiac_prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dia, mes;
            DateTime nascimento;

            try
            {
                nascimento = DateTime.Parse(maskedTextBox1.Text);

                dia = nascimento.Day;
                mes = nascimento.Month;

                if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 20))
                {
                    pictureBox1.Image = Properties.Resources.aries;
                    signo.Text = "Aries";
                }

                else if ((mes == 04 && dia >= 21) || (mes == 05 && dia <= 20))
                {
                    pictureBox1.Image = Properties.Resources.touro;
                    signo.Text = "Touro";
                }

                else if ((mes == 05 && dia >= 21) || (mes == 06 && dia <= 20))
                {
                    pictureBox1.Image = Properties.Resources.gemeos;
                    signo.Text = "Gemeos";
                }

                else if ((mes == 06 && dia >= 21) || (mes == 07 && dia <= 21))
                {
                    pictureBox1.Image = Properties.Resources.cancer;
                    signo.Text = "Câncer";
                }

                else if ((mes == 07 && dia >= 22) || (mes == 08 && dia <= 22))
                {
                    pictureBox1.Image = Properties.Resources.leao;
                    signo.Text = "Leão";
                }

                else if ((mes == 08 && dia >= 23) || (mes == 09 && dia <= 22))
                {
                    pictureBox1.Image = Properties.Resources.virgem;
                    signo.Text = "Virgem";
                }

                else if ((mes == 09 && dia >= 23) || (mes == 10 && dia <= 22))
                {
                    pictureBox1.Image = Properties.Resources.libra;
                    signo.Text = "Libra";
                }

                else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
                {
                    pictureBox1.Image = Properties.Resources.escorpiao;
                    signo.Text = "Escorpião";
                }

                else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
                {
                    pictureBox1.Image = Properties.Resources.sagitario;
                    signo.Text = "Sagitário";
                }

                else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 20))
                {
                    pictureBox1.Image = Properties.Resources.capricornio;
                    signo.Text = "Capricórnio";
                }

                else if ((mes == 01 && dia >= 21) || (mes == 02 && dia <= 19))
                {
                    pictureBox1.Image = Properties.Resources.aquario;
                    signo.Text = "Aquário";
                }

                else if ((mes == 02 && dia >= 20) || (mes == 03 && dia <= 20))
                {
                    pictureBox1.Image = Properties.Resources.peixes;
                    signo.Text = "Peixes";
                }
            }

            catch
            {
                MessageBox.Show("Não é uma data válida.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            signo.Text = "";
            maskedTextBox1.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

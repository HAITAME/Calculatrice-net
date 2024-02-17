using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.Text == "CE")
            {
                Resultat.Text = "0";

            }
            else if (button.Text == "=")
            {
               
                try
                {
                    object result = new DataTable().Compute(Resultat.Text, null);
                    Resultat.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    // Affiche un message en cas d'erreur lors de l'évaluation de l'expression
                    Resultat.Text = "Erreur : "+ex;
                }

            }
            else { 
                    if (Resultat.Text == "0")
                    {
                        Resultat.Text = button.Text;
                    }
                    else
                    {
                        Resultat.Text += button.Text;
                    }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

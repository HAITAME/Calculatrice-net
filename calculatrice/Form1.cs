﻿using System;
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
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            /*
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
                                Resultat.Text = "Erreur ";
                            }

                        }
                        else if (button.Text == "×")
                        {

                            Resultat.Text += "*";

                        }
                        else if (button.Text == "÷")
                        {

                            Resultat.Text += "/";

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
            */
            switch (button.Text)
            {
                case "CE":
                    Resultat.Text = "0";
                    break;
                case "=":
                    try
                    {
                        object result = new DataTable().Compute(Resultat.Text, null);
                        Resultat.Text = result.ToString();
                    }
                    catch (Exception ex)
                    {
                        Resultat.Text = "Math Erreur ";
                    }
                    break;
                case "×":
                    Resultat.Text += "*";
                    break;
                case "÷":
                    Resultat.Text += "/";
                    break;
                default:
                    if (Resultat.Text == "0")
                    {
                        Resultat.Text = button.Text;
                    }
                    else
                    {
                        Resultat.Text += button.Text;
                    }
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

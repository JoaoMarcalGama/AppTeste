using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.XamarinForms.Calculadora
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculadora : ContentPage
    {
        // Valor 1
        float n1 = 0;

        // Representação do Valor 1
        string sn1 = "";

        //Valor 2
        float n2 = 0;

        // Representação do Valor 2
        string sn2 = "";

        //Índice de operação matemática
        int op = 0;

        // Resultado do cálculo
        float resultado = 0;

        public Calculadora()
        {
            InitializeComponent();
            
        }
                      
        // Método do número 0
        private void ButtonNum0(object sender, EventArgs e)
        {
            // Nenhuma operação selecionada
            
            
            if (op == 0)
            {
                
                
                // Nenhum valor atribuído ao primeiro número
                if (n1 != 0)
                {
                    sn1 = n1.ToString() + "0";
                    n1 = float.Parse(sn1);
                    Lbl_Resultado.Text = Lbl_Resultado.Text + "0";
                }
            }
            else
            {
                // Nenhum valor atribuído ao segundo número
                if (n2 != 0)
                {
                    sn2 = sn2 + "0";
                    n2 = float.Parse(sn2);
                    Lbl_Resultado.Text = Lbl_Resultado.Text + "0";
                }
            }
        }

        // Método do número 1
        private void ButtonNum1(object sender, EventArgs e)
        {
            // Nenhuma operação selecionada
            if (op == 0)
            {
                if (resultado != 0)
                {
                    n1 = resultado;
                }
                else
                {
                    if (n1 == 0)
                    {
                        n1 = 1;
                        sn1 = n1.ToString();
                        Lbl_Resultado.Text = "1";
                    }
                    else
                    {
                        sn1 = sn1 + "1";
                        n1 = float.Parse(sn1);
                        Lbl_Resultado.Text = Lbl_Resultado.Text + "1";
                    }
                }

                // Nenhum valor atribuído ao primeiro número
                               
            } 
            else
            {
                if (resultado != 0)
                {
                    n1 = resultado;
                }
                // Nenhum valor atribuído ao segundo número
                if (n2 == 0)
                {
                    n2 = 1;
                    sn2 = n2.ToString();
                    Lbl_Resultado.Text = Lbl_Resultado.Text + "1";
                }
                else
                {
                    sn2 = sn2 + "1";
                    n2 = float.Parse(sn2);
                    Lbl_Resultado.Text = Lbl_Resultado.Text + "1";
                }
                
            }            
        }

        // Método do número 2
        private void ButtonNum2(object sender, EventArgs e)
        {
            // Nenhuma operação selecionada
            if (op == 0)
            {
                if (resultado != 0)
                {
                    n1 = resultado;
                }
                
                    // Nenhum valor atribuído ao primeiro número
                if (n1 == 0)
                {
                    n1 = 2;
                    sn1 = n1.ToString();
                    Lbl_Resultado.Text = "2";
                }
                else
                {
                    sn1 = sn1 + "2";
                    n1 = float.Parse(sn1);
                    Lbl_Resultado.Text = Lbl_Resultado.Text + "2";
                }
                
            }
            else
            {
                if (resultado != 0)
                {
                    n1 = resultado;
                }
                // Nenhum valor atribuído ao segundo número
                if (n2 == 0)
                {
                    n2 = 2;
                    sn2 = n2.ToString();
                    Lbl_Resultado.Text = Lbl_Resultado.Text + "2";
                }
                else
                {
                    sn2 = sn2 + "2";
                    n2 = float.Parse(sn2);
                    Lbl_Resultado.Text = Lbl_Resultado.Text + "2";
                }
            }
        }

        // Método do número 3
        private void ButtonNum3(object sender, EventArgs e)
        {
            // Nenhuma operação selecionada
            if (op == 0)
            {

                if (resultado != 0)
                {
                    n1 = resultado;
                }
                // Nenhum valor atribuído ao primeiro número
                if (n1 == 0)
                {
                    n1 = 3;
                    sn1 = n1.ToString();
                    Lbl_Resultado.Text = "3";
                }
                else
                {
                    sn1 = sn1 + "3";
                    n1 = float.Parse(sn1);
                    Lbl_Resultado.Text = Lbl_Resultado.Text + "3";
                }
            }

            else
            {
                if (resultado != 0)
                {
                    n1 = resultado;
                }
                // Nenhum valor atribuído ao segundo número
                if (n2 == 0)
                {
                    n2 = 3;
                    sn2 = n2.ToString();
                    Lbl_Resultado.Text = Lbl_Resultado.Text + "3";
                }
                else
                {
                    sn2 = sn2 + "3";
                    n2 = float.Parse(sn2);
                    Lbl_Resultado.Text = Lbl_Resultado.Text + "3";
                }
            }
            
        }

        // Método do número 4
        private void ButtonNum4(object sender, EventArgs e)
        {
            
                // Nenhuma operação selecionada
            if (op == 0)
            {
                if (resultado != 0)
                {
                    n1 = resultado;
                }
                // Nenhum valor atribuído ao primeiro número
                if (n1 == 0)
                {
                    n1 = 4;
                    sn1 = n1.ToString();
                    Lbl_Resultado.Text = "4";
                }
                else
                {
                    sn1 = sn1 + "4";
                    n1 = float.Parse(sn1);
                    Lbl_Resultado.Text = Lbl_Resultado.Text + "4";
                }

            }
            else
            {
                if (resultado != 0)
                {
                    n1 = resultado;
                }
                // Nenhum valor atribuído ao segundo número
                if (n2 == 0)
                {
                    n2 = 4;
                    sn2 = n2.ToString();
                    Lbl_Resultado.Text = Lbl_Resultado.Text + "4";
                }
                else
                {
                    sn2 = sn2 + "4";
                    n2 = float.Parse(sn2);
                    Lbl_Resultado.Text = Lbl_Resultado.Text + "4";
                }
            }
            
        }

        // Método do número 5
        private void ButtonNum5(object sender, EventArgs e)
        {

            // Nenhuma operação selecionada
            if (op == 0)
            {
                if (resultado != 0)
                {
                    n1 = resultado;
                }
                // Nenhum valor atribuído ao primeiro número
                if (n1 == 0)
                {
                    n1 = 5;
                    sn1 = n1.ToString();
                    Lbl_Resultado.Text = "5";
                }
                else
                {
                    sn1 = sn1 + "5";
                    n1 = float.Parse(sn1);
                    Lbl_Resultado.Text = Lbl_Resultado.Text + "5";
                }

            }
            else
            {
                if (resultado != 0)
                {
                    n1 = resultado;
                }
                // Nenhum valor atribuído ao segundo número
                if (n2 == 0)
                {
                    n2 = 5;
                    sn2 = n2.ToString();
                    Lbl_Resultado.Text = Lbl_Resultado.Text + "5";
                }
                else
                {
                    sn2 = sn2 + "5";
                    n2 = float.Parse(sn2);
                    Lbl_Resultado.Text = Lbl_Resultado.Text + "5";
                }
            }
            
        }

        // Método do número 6
        private void ButtonNum6(object sender, EventArgs e)
        {
 
                // Nenhuma operação selecionada
            if (op == 0)
            {
                if (resultado != 0)
                {
                    n1 = resultado;
                }
            // Nenhum valor atribuído ao primeiro número
                if (n1 == 0)
                {
                    n1 = 6;
                    sn1 = n1.ToString();
                    Lbl_Resultado.Text = "6";
                }
                else
                {
                    sn1 = sn1 + "6";
                    n1 = float.Parse(sn1);
                    Lbl_Resultado.Text = Lbl_Resultado.Text + "6";
                }

            }
            else
            {
                if (resultado != 0)
                {
                    n1 = resultado;
                }
                // Nenhum valor atribuído ao segundo número
                if (n2 == 0)
                {
                    n2 = 6;
                    sn2 = n2.ToString();
                    Lbl_Resultado.Text = Lbl_Resultado.Text + "6";
                }
                else
                {
                    sn2 = sn2 + "6";
                    n2 = float.Parse(sn2);
                    Lbl_Resultado.Text = Lbl_Resultado.Text + "6";
                }
            }
            
        }

        // Método do número 7
        private void ButtonNum7(object sender, EventArgs e)
        {
                // Nenhuma operação selecionada
                if (op == 0)
                {
                    if (resultado != 0)
                    {
                        n1 = resultado;
                    }
                // Nenhum valor atribuído ao primeiro número
                if (n1 == 0)
                    {
                        n1 = 7;
                        sn1 = n1.ToString();
                        Lbl_Resultado.Text = "7";
                    }
                    else
                    {
                        sn1 = sn1 + "7";
                        n1 = float.Parse(sn1);
                        Lbl_Resultado.Text = Lbl_Resultado.Text + "7";
                    }

                }
                else
                {
                    if (resultado != 0)
                    {
                        n1 = resultado;
                    }
                // Nenhum valor atribuído ao segundo número
                    if (n2 == 0)
                    {
                        n2 = 7;
                        sn2 = n2.ToString();
                        Lbl_Resultado.Text = Lbl_Resultado.Text + "7";
                    }
                    else
                    {
                        sn2 = sn2 + "7";
                        n2 = float.Parse(sn2);
                        Lbl_Resultado.Text = Lbl_Resultado.Text + "7";
                    }
                }
            
        }

        // Método do número 8
        private void ButtonNum8(object sender, EventArgs e)
        {

                // Nenhuma operação selecionada
            if (op == 0)
                {
                    if (resultado != 0)
                    {
                        n1 = resultado;
                }
                // Nenhum valor atribuído ao primeiro número
                 if (n1 == 0)
                    {
                        n1 = 8;
                        sn1 = n1.ToString();
                        Lbl_Resultado.Text = "8";
                    }
                    else
                    {
                        sn1 = sn1 + "8";
                        n1 = float.Parse(sn1);
                        Lbl_Resultado.Text = Lbl_Resultado.Text + "8";
                    }

                }
                else
                {
                    if (resultado != 0)
                    {
                        n1 = resultado;
                    }
                // Nenhum valor atribuído ao segundo número
                    if (n2 == 0)
                    {
                        n2 = 8;
                        sn2 = n2.ToString();
                        Lbl_Resultado.Text = Lbl_Resultado.Text + "8";
                    }
                    else
                    {
                        sn2 = sn2 + "8";
                        n2 = float.Parse(sn2);
                        Lbl_Resultado.Text = Lbl_Resultado.Text + "8";
                    }
                }
            
        }

        // Método do número 9
        private void ButtonNum9(object sender, EventArgs e)
        {

                // Nenhuma operação selecionada
                if (op == 0)
                {
                    if (resultado != 0)
                    {
                        n1 = resultado;
                    }
                    // Nenhum valor atribuído ao primeiro número
                    if (n1 == 0)
                    {
                        n1 = 9;
                        sn1 = n1.ToString();
                        Lbl_Resultado.Text = "9";
                    }
                    else
                    {
                        sn1 = sn1 + "9";
                        n1 = float.Parse(sn1);
                        Lbl_Resultado.Text = Lbl_Resultado.Text + "9";
                    }

                }
                else
                {
                    if (resultado != 0)
                    {
                        n1 = resultado;
                    }
                    // Nenhum valor atribuído ao segundo número
                    if (n2 == 0)
                    {
                        n2 = 9;
                        sn2 = n2.ToString();
                        Lbl_Resultado.Text = Lbl_Resultado.Text + "9";
                    }
                    else
                    {
                        sn2 = sn2 + "9";
                        n2 = float.Parse(sn2);
                        Lbl_Resultado.Text = Lbl_Resultado.Text + "9";
                    }
                }
            
        }

        // Método adicionar vírgula
        private void ButtonVirg(object sender, EventArgs e)
        {
            // Nenhuma operação selecionada
            if (op == 0)
            {
                sn1 = n1.ToString() + ",";
                Lbl_Resultado.Text = Lbl_Resultado.Text + ",";   
            }
            else
            {
                sn2 = n2.ToString() + ",";
                Lbl_Resultado.Text = Lbl_Resultado.Text + ",";
            }
        }

        // Método reiniciar os valores
        private void ButtonAC(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = "0";
            resultado = 0;
            n1 = 0;
            n2 = 0;
            op = 0;
            sn1 = "";
            sn2 = "";

        }
                 
        // Método de soma
        private void ButtonSom(object sender, EventArgs e)
        {           
            if (Lbl_Resultado.Text != "0")
            {
                op = 1;
                Lbl_Resultado.Text = Lbl_Resultado.Text + " + ";
            }
        }

        // Médoto de subtração
        private void ButtonSubt(object sender, EventArgs e)
        {
            if (Lbl_Resultado.Text != "0")
            {
                op = 2;
                Lbl_Resultado.Text = Lbl_Resultado.Text + " - ";
            }
        }

        // Método de multiplicação
        private void ButtonMult(object sender, EventArgs e)
        {           
            if (Lbl_Resultado.Text != "0")
            {
                op = 3;
                Lbl_Resultado.Text = Lbl_Resultado.Text + " x ";
            }
        }

        // Método de divisão
        private void ButtonDiv(object sender, EventArgs e)
        {
            if (Lbl_Resultado.Text != "0")
            {
                op = 4;
                Lbl_Resultado.Text = Lbl_Resultado.Text + " / ";
            }

        }
        private void Button_porcent(object sender, EventArgs e)
        {
            if (Lbl_Resultado.Text != "0")
            {
                op = 5;
                Lbl_Resultado.Text = Lbl_Resultado.Text + " % ";
            }
        }

        // Método de resultado
        private void ButtonResult(object sender, EventArgs e)
        {
           
            
            // Definição das operações baseado no índice (op)
            switch (op)
            {
                case 1:
                    resultado = n1 + n2;
                    break;

                case 2:
                    resultado = n1 - n2;
                    break;

                case 3:
                    resultado = n1 * n2;
                    break;

                case 4:
                    resultado = n1 / n2;
                    break;
                case 5:
                    resultado = (n1 / 100) * n2;
                    break;
            }

            // Arredondamento do resultado
            resultado = (float) Math.Round(resultado, 2);
            Lbl_Resultado.Text = resultado.ToString();

            // Reiniciando as variáveis
            op = 0;
            n1 = 0;
            n2 = 0;
            sn1 = "";
            sn2 = "";
            
        }

        
    }
    }

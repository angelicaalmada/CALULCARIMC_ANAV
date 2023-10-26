using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CALULCARIMC_AGGP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        //float peso;
        //float altura;
        float imc;
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Peso.Text) && !string.IsNullOrEmpty(Altura.Text)) { 
               
                CalulcarIMC(float.Parse(Peso.Text), float.Parse(Altura.Text));

                string rango = "";
                if (imc < 18)
                {
                    rango = "Bajo peso";
                }
                else if (imc <= 24.9)
                {
                    rango = "Peso normal";
                }

                else if (imc > 24.9 && imc < 30)
                {
                    rango = "Sobrepeso";
                }
                else
                {
                    rango = "Obesidad";
                }
                DisplayAlert("Rango de peso", rango, "Salir");
            }
            else
            {
                DisplayAlert("Campos Vacíos", "Ingresa todos los datos", "Salir");
            }
        }
      
        private void CalulcarIMC(float p, float a)
        {
            imc = p / (a * a);
        }


    }
}

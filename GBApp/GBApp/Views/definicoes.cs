using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace GBApp.Views
{
    public class definicoes : ContentPage
    {
        public definicoes()
        {
            Title = "Definições";
            BackgroundColor = Color.Navy;
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Página definicoes"
           
                    }
                }
            };
        }
    }
}

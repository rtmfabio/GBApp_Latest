using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace GBApp.Views
{
    public class pesquisa : ContentPage
    {
        public pesquisa()
        {
            Title = "Pesquisa";
            BackgroundColor = Color.Aqua;
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Página de Pesquisa"
                        
                    }
                }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace GBApp.Views
{
    public class login : ContentPage
    {
        public login()
        {
            Title = "Inicio";
            BackgroundColor = Color.Blue;
            Content = new StackLayout
            {
                Children = {
                    new Label {Text = "página de login",
                    FontAttributes = FontAttributes.Bold,
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center,
                    FontSize = 10,

                                
                    }
                }
            };
        }
    }
}

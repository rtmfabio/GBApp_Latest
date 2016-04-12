using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;   


namespace GBApp
{
    class Tabs : TabbedPage
    {
        public Tabs()
        {
            this.Title = "GetBack App";
            this.Children.Add(new Views.login());
            this.Children.Add(new Views.pesquisa());
            this.Children.Add(new Views.definicoes());
        }
    }
}

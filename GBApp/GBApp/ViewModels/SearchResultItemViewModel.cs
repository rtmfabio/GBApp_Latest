using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GBApp.ViewModels
{
    public class SearchResultItemViewModel : INotifyPropertyChanged
    {

        private Int32 id;
        private String nome;
        private Double longitude;
        private Double latitude;
        private String longlat;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public Double Longitude
        {
            get
            {
                return longitude;
            }

            set
            {
                longitude = value;
                OnPropertyChanged("Longlat");
            }
        }

        public Double Latitude
        {
            get
            {
                return latitude;
            }

            set
            {
                latitude = value;
                OnPropertyChanged("Longlat");
            }
        }

        public string Longlat
        {
            get
            {
                return Longitude.ToString()+" - "+Latitude.ToString();
            }  

            set
            {
                longlat = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public SearchResultItemViewModel()

        {   
        }
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

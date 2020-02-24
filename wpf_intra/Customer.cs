using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel; //INotifyPropertyChange

namespace wpf_intra
{
    class Customer : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Adresse { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private string Info;
    }
}

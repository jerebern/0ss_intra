using System.ComponentModel; //INotifyPropertyChange

namespace Gestionaire_Clients
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

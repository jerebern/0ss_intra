using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel; //INotifyPropertyChange
using System.Runtime.CompilerServices; //[CallerMemberName]


namespace Gestionaire_Clients
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
       public List<Customer> clients { get; set; }
        public MainWindow()
        {

            

            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }


}

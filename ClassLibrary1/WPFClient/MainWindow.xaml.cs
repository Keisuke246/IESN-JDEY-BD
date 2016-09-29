using ClassLibrary1;
//using Model;
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

namespace WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CompanyContext _context = new CompanyContext();
        private Customer _customer;
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _context.Database.Initialize(true);
            _customer = new Customer()
            {
                AccountBalance = 742.84,
                AdressLine1 = "Rue des Prés, 47",
                City = "Namur",
                Country = "Belgium",
                EMail = "bertrand.duchene@gmail.com",
                Id = 75849,
                Name = "Bertrand Duchêne",
                PostCode = "5000"
            };
            _context.Customers.Add(_customer);
            _context.SaveChanges();
            Formulaire.DataContext = _customer;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException("Voir énoncé");
        }
    }
}

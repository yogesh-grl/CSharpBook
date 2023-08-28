using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace SampleWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        private string _buttonContentConnect;
        public string ButtonContentConnect
        {
            get { return _buttonContentConnect; }
            set
            {
                if (_buttonContentConnect == value)
                    return;

                _buttonContentConnect = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ButtonContentConnect)));
            }
        }

        public MainWindow()
        {
            _buttonContentConnect = "Connect";
            InitializeComponent();
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Connect(object sender, RoutedEventArgs e)
        {

            Mouse.OverrideCursor = Cursors.Wait;
            _buttonContentConnect = "Connecting";
            Thread.Sleep(5000);
            this.Resources["btnClr"] = new SolidColorBrush(Colors.Green);
            Mouse.OverrideCursor = Cursors.Arrow;
            _buttonContentConnect = "Connected";
        }

        private void Button_Click_Disconnect(object sender, RoutedEventArgs e)
        {
            this.Resources["btnClr"] = new SolidColorBrush(Colors.Red);
        }

        private void Button_Click_Trigger(object sender, RoutedEventArgs e)
        {

        }
    }
}

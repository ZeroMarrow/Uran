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
using System.Windows.Shapes;

namespace Uran
{
    /// <summary>
    /// Логика взаимодействия для PC.xaml
    /// </summary>
    public partial class PC : Window
    {
        public PC()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
        public string NameComputer
        {
            get { return nameComputer.Text; }
        }
        public float MemoryComputer
        {
            get { return float.Parse(memoryComputer.Text); }
        }
    }
}

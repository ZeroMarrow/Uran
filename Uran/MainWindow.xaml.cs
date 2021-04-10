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

namespace Uran
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Queue<Computer> computers;
        public MainWindow()
        {
            InitializeComponent();
            computers = new Queue<Computer>();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PC add = new PC();
            if (add.ShowDialog()==true)
            {
                string name = add.NameComputer;
                float memory = add.MemoryComputer;
                Computer computer = new Computer(name, memory);
                float total = 0;
                computers.Enqueue(computer);
                foreach (Computer c in computers)
                {
                    total += c.Memory;
                }
                SizePanel.Text = total.ToString();
                UpdateStack();
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            computers.Dequeue();
            UpdateStack();
        }
        private void UpdateStack()
        {
            StackPanel.ItemsSource = null;
            StackPanel.Items.Clear();
            StackPanel.ItemsSource = computers;
        }
    }
}

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

namespace WindowsProgrammingAssignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// test er jeg med
    /// cthp er med
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



        }

        private void ExpandToolbar_Button_Click(object sender, RoutedEventArgs e)
        {
            if (rect.Visibility == System.Windows.Visibility.Collapsed)
            {
                rect.Visibility = System.Windows.Visibility.Visible;
                (sender as Button).Content = "<";
                
            }
            else
            {
                rect.Visibility = System.Windows.Visibility.Collapsed;
                (sender as Button).Content = ">";
            }     
        }

        private void HeaderOpenClicked(object sender, RoutedEventArgs e)
        {
            System.Console.WriteLine("Open!!");
        }
    }
}

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

namespace Задание_практика
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listbox.Items.Add("Проверка");
            }
            catch
            {

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          
            try
            {
                listbox.Items.RemoveAt(listbox.SelectedIndex);
            }
            catch
            {

            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Radiobutton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Radiobutton1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Radiobutton2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Radiobutton3_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.ShowDialog();
            try
            {

            }
            catch
            {

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                
            }
            catch
            {

            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }

        private void Textbox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Listbox_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}

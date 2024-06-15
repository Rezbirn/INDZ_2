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

namespace INDZ_2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private static string[] _textBoxNames = { "one", "two", "three", "four", "five", "six" };
        private MainWindow _mainWindow;
        public Window1(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            var tag = checkBox.Tag;
            if(tag!= null) 
            {
                var index = int.Parse(tag.ToString());
                var name = _textBoxNames[index];
                var textBoxFindByName = _mainWindow.FindName(name);
                if (textBoxFindByName is TextBox textBox)
                {
                    if (checkBox.IsChecked == true)
                        textBox.FontWeight = FontWeights.Bold;
                    else
                        textBox.FontWeight = FontWeights.Normal;
                }
            }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Visibility = Visibility.Hidden;
            e.Cancel = true;
        }
    }
}

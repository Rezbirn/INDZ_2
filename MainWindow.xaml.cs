using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace INDZ_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string[] _checkBoxNames = { "one", "two", "three", "four", "five", "six" };
        Window1 _window1;

        public MainWindow()
        {
            InitializeComponent();
            _window1 = new Window1(this);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            var tag = textBox.Tag;
            if(tag != null) 
            {
                var index = int.Parse(tag.ToString());
                var checkBoxFindByName = _window1.FindName(_checkBoxNames[index]);
                if (checkBoxFindByName is CheckBox checkBox)
                {
                    checkBox.Content = textBox.Text;
                }
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _window1.Owner = this;
            _window1.ShowDialog();
        }
    }
}
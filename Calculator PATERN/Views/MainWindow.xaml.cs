using Calculator_PATERN.ViewModels;
using System.Windows;

namespace Calculator_PATERN
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        //private void Button_Click_Sum(object sender, RoutedEventArgs e)
        //{
        //    var a = int.Parse(TextBoxA.Text);
        //    var b = int.Parse(TextBoxB.Text);
        //    TextBoxSum.Text = (a + b).ToString();
        //}

    }
}

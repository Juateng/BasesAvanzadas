using BasesAvanzadas.MVVM.Model;
using System.Windows;
using System.Windows.Input;

namespace BasesAvanzadas.MVVM.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void ExitButton(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void WindowMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}

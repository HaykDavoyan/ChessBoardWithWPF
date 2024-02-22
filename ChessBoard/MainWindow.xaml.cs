using System.Windows;
using System.Windows.Input;

namespace ChessBoard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point position = e.GetPosition((IInputElement)sender);

            X.Content = $"X: {position.X.ToString("0")}";
            Y.Content = $"Y: {position.Y.ToString("0")}";
        }
    }
}

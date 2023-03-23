using System;
using System.Windows;
namespace DesignProject
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // this.Close();
            App.Current.Shutdown();
        }
    }
}

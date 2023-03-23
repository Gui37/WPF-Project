using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

namespace DesignProject.MVVM.View
{
    /// <summary>
    /// Interação lógica para AppsView.xam
    /// </summary>
    public partial class AppsView : UserControl
    {
        public AppsView()
        {
            InitializeComponent();
        }

        private void spotify_MouseUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Console.WriteLine("\nTrying to launch Spotify");
              ///  Process.Start("C:\\Users\\User\\AppData\\Local\\Programs\\Microsoft VS Code\\code.exe");
            }
            catch (Win32Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

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
    /// Interação lógica para FeaturedView.xam
    /// </summary>
    public partial class FeaturedView : UserControl
    {
        public FeaturedView()
        {
            InitializeComponent();
        }

        private void nttp_MouseUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Console.WriteLine("\nTrying to launch Notepad++ using your login information...");
                Process.Start("C:\\Program Files (x86)\\Notepad++\\notepad++.exe");
            }
            catch (Win32Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

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

namespace View
{
    /// <summary>
    /// Interaktionslogik für HauptView.xaml
    /// </summary>
    public partial class HauptView : Window
    {
        public HauptView()
        {
            InitializeComponent();
        }

        private void buttonAlkohol_Click(object sender, RoutedEventArgs e)
        {
            AlkoholView alkoholView = new AlkoholView();
            alkoholView.Show();
        }

        private void buttonSaft_Click(object sender, RoutedEventArgs e)
        {
            SaftView saftView = new SaftView();
            saftView.Show();
        }

        private void buttonDeko_Click(object sender, RoutedEventArgs e)
        {
            DekoView dekoView = new DekoView();
            dekoView.Show();
        }
    }
}

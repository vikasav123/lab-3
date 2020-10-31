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

namespace lab_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double res = 0;
            double x;
            x = Convert.ToDouble(width.Text) * Convert.ToDouble(height.Text);
            switch(comboBox.SelectedIndex)
            {
                case 0:
                    if ((bool)one.IsChecked)
                        res = x * 0.25;
                    else
                        res = x * 0.30;

                    break;
                case 1:
                    if ((bool)one.IsChecked)
                        res = x * 0.05;
                    else
                        res = x * 0.10;
                    break;
                case 2:
                    if ((bool)one.IsChecked)
                        res = x * 0.15;
                    else
                        res = x * 0.20;
                    break;
            }

            if ((bool)windowsill.IsChecked)
                res += 35;

            result.Text = $"Вартість: {res} гривень";
        }

        
    }
}

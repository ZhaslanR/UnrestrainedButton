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

namespace UnrestrainedButtonWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            if(button.VerticalAlignment == VerticalAlignment.Bottom)
                button.VerticalAlignment = VerticalAlignment.Bottom;
            else
                button.VerticalAlignment = VerticalAlignment.Top;

            if (button.HorizontalAlignment == HorizontalAlignment.Right)
                button.HorizontalAlignment = HorizontalAlignment.Left;
            else
                button.HorizontalAlignment = HorizontalAlignment.Right;
        }
    }
}

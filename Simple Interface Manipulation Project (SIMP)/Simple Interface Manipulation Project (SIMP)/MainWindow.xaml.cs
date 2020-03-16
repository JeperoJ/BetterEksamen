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

namespace Simple_Interface_Manipulation_Project__SIMP_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int count = 1;
            string[] buttonFill = { "*", "/", "Clear", "7", "8", "9", "4", "5", "6", "1", "2", "3", "0", "+", "-" };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button MyControl1 = new Button();
                    MyControl1.Content = buttonFill[count-1];
                    MyControl1.Name = "Button" + count.ToString();
                    MyControl1.HorizontalAlignment = HorizontalAlignment.Stretch;
                    MyControl1.VerticalAlignment = VerticalAlignment.Stretch;

                    Grid.SetColumn(MyControl1, j);
                    Grid.SetRow(MyControl1, i);
                    griddy.Children.Add(MyControl1);

                    count++;
                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
        }
    }
}

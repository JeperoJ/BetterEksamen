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

            int count = 0; //Definerer count variabel til brug i for loop, for at holde styr på hvilket felt vi er i
            string[] buttonFill = { "Plotter", "mod", "n!", "x^y", "/", "7", "8", "9", "*", "4", "5", "6", "+", "1", "2", "3", "-", "0", "Clear", "=" }; // De karakterer som skal være i knapperne
            int margin = 3; //Et variabel, der ændrer margins af label og knapper
            label1.Margin = new Thickness(margin, margin, margin, margin+3); //Sætter margin af label. Gøres her da 4 værdier ellers skulle ændres i XAML-filen, hver gang jeg skulle teste hvordan en anden margin så ud

            for (int i = 0; i < 5; i++)//For loop der looper igennem rows
            {
                for (int j = 0; j < 4; j++)//For loop der looper igennem collumns
                {
                    Button MyControl1 = new Button(); //Initilizer en instance af classen "Button", basicly laver en ny knap
                    MyControl1.Content = buttonFill[count]; //Sætter hvad der står i knappen, efter karakteren i arrayet der på den plads count svarer til
                    MyControl1.Name = "Button" + count.ToString(); //Giver den et navn, den senere kan refereres til med, så man kan give den controls
                    MyControl1.HorizontalAlignment = HorizontalAlignment.Stretch; //Måden man får ting til at stretch til kanten, er ved at sætte dets alignment til stretch.
                    MyControl1.VerticalAlignment = VerticalAlignment.Stretch;
                    MyControl1.Margin = new Thickness(margin,margin,margin,margin); //Sætter størrelsen af margin for knappen, så hvor langt der er fra kanten af knappen til kantens af dens cell
                    MyControl1.BorderThickness = new Thickness(0); 
                    BrushConverter bc = new BrushConverter();
                    Brush brush = (Brush)bc.ConvertFrom("#FFFFFF");
                    MyControl1.Background = brush;

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

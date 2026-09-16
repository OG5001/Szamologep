using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Szamologep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string szam1 = "";
        List szam = new List();
        public MainWindow()
        {
            InitializeComponent();
            GombokElhelyezese();
        }

        private void GombokElhelyezese()
        {
            for (int i = 0; i < 4; i++)
            {
                ButtonGrid.RowDefinitions.Add(new RowDefinition());
                ButtonGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            string[,] feliratok =
            {
                {"7", "8", "9", "/"},
                {"4", "5", "6", "*"},
                {"1", "2", "3", "-"},
                {"C", "0", "=", "+"}
            };
            for (int i = 0;i < 4;i++)
            {
                for(int j = 0;j < 4;j++)
                {
                    string label = feliratok[i, j];
                    Button btn = new Button
                    {
                        Content = label,
                        FontSize = 20,
                        FontWeight = FontWeights.Bold,
                        Margin = new Thickness(3)
                    };
                    if (char.IsDigit(label[0]))
                    {
                        btn.Background = Brushes.WhiteSmoke;
                    }
                    else if (label == "C")
                    {
                        btn.Background = Brushes.IndianRed;
                        btn.Foreground = Brushes.White;
                    }
                    else
                    {
                        btn.Background = Brushes.DodgerBlue;
                        btn.Foreground = Brushes.White;
                    }
                    btn.Click += Button_Click;

                    Grid.SetRow(btn, i);
                    Grid.SetColumn(btn, j);

                    ButtonGrid.Children.Add(btn);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string felirat = button.Content.ToString();
            if (tb_kijelzo.Text == "0")
            {
                tb_kijelzo.Text = felirat;
            }
            else
            {
                tb_kijelzo.Text += felirat;
            }
            
            if (felirat.Contains("C"))
            {
                tb_kijelzo.Text = "0";
            }
            else if (felirat.Contains("1") || felirat.Contains("2") || felirat.Contains("3") || felirat.Contains("4") || felirat.Contains("5") || felirat.Contains("6") || felirat.Contains("7") || felirat.Contains("8") || felirat.Contains("9") || felirat.Contains("0"))
            {
                szam1 += felirat;
            }
            else if (felirat.Contains("+"))
            {
                for (int i = 0; i < szam.; i++) {
            }

        }
    }
}
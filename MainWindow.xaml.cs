using System;
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

namespace zxcMassivWork1._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int N;
        int[] array;
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void BtnCreateArray_Click(object sender, RoutedEventArgs e)
        {
            
            N = int.Parse(TxtN.Text);
            array = new int[N];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                array[i] = rand.Next(-1000, 1000);
                LstArray.Items.Add($"#{i} {array[i]}");
            }
        }
        
        private void BtnSolveArray_Click(object sender, RoutedEventArgs e)
        {
                double sum = 0;
                int count = 0;
                foreach (double num in array)
                {
                    if (num > 3.5)
                    {
                        sum += num;
                        count++;

                    }
                }
                double average = sum / count;
                LstArrayNew.Items.Add($"Среднее арифмитическое этих \n числе равно: {average}");           
        }
    }
}
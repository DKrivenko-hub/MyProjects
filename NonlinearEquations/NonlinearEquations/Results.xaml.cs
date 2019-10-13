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

namespace NonlinearEquations
{
    /// <summary>
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : Window
    {
        public Results(double answer_MSI, double answer_Newt, int steps_MSI, int steps_Newt)
        {
            InitializeComponent();

            label_Numbers_steps_MSI.Content = "Количество шагов = " + steps_MSI.ToString();
            label_Numbers_steps_Newt.Content = "Количество шагов = " + steps_Newt.ToString();

            label_Answer_MSI.Content = "Приближённое решение = " + answer_MSI.ToString();
            label_Answer_Newt.Content = "Приближённое решение = " + answer_Newt.ToString();
        }


        private void button_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

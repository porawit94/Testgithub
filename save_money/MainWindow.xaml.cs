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

namespace save_money
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

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            int moneyIn;
            int moneyOut;
            int saLary;
            int iTem;
            int day;
            string sumDay;

            try
            {
                moneyIn = int.Parse(txt_moneyIn.Text);
                moneyOut = int.Parse(txt_moneyOut.Text);
                saLary = (moneyIn - moneyOut);
                MessageBox.Show("เงินคงเหลือ " + saLary.ToString() + " บาท");
                iTem = int.Parse(txt_item.Text);
                day = (iTem / saLary);
                sumDay = day.ToString();
                txt_sumDay.Text = sumDay;
                txt_saveMoney.Text = saLary.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
                MessageBox.Show("Please enter a number in the box !!!");
            }
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            txt_moneyIn.Clear();
            txt_moneyOut.Clear();
            txt_item.Clear();
            txt_sumDay.Clear();
            txt_saveMoney.Clear();
        }
    }
}

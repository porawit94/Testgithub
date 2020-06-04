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

namespace savemoneyGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int moneyReming;
        int resultDay;
        double income;
        double expenditure;
        double thePrice;

        public MainWindow()
        {
            InitializeComponent();
        }
        //รายรับ
        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {

            txtInput.Text = Console.ReadLine();

        }
        //รายจ่าย
        private void txtInout_TextChanged(object sender, TextChangedEventArgs e)
        {

            txtInout.Text = Console.ReadLine();

        }
        //ราคาของที่อยากได้
        private void txtPrice_TextChanged(object sender, TextChangedEventArgs e)
        {

            txtPrice.Text = Console.ReadLine();

        }
        //Click 
        private void Click_Submit_Click(object sender, RoutedEventArgs e)
        {
            Calculeta();
            ShowData();
        }
        private void Calculeta()
        {
            //Calculeta

            income = double.Parse(txtInput.Text);//รายรับ
            expenditure = double.Parse(txtInout.Text);//รายจ่าย
            thePrice = double.Parse(txtPrice.Text);//ราคาของที่อยากได้
            moneyReming = Convert.ToInt32(income - expenditure);//เงินคงเหลือ
            resultDay = Convert.ToInt32(thePrice / moneyReming);//จำนวนวันที่ต้องเก็บเงิน

        }
        private void ShowData()
        {
            //ShowDataText

            txtSumday.Text = resultDay.ToString();//จำนวนวันที่ต้องเก็บเงิน
            moneySave.Text = moneyReming.ToString();//เงินคงเหลือ
        }
    }
}


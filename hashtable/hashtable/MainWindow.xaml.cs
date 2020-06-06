using System;
using System.Collections;
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

namespace hashtable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;

        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {//key = email/ value = fristname lastname
            hashtable.Add(txtKey.Text,txtValue.Text);
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Remove(txtKeyremove.Text);
        }

        private void showData_Click(object sender, RoutedEventArgs e)
        {
            ICollection collection = hashtable.Keys;

            foreach (string key in collection)
            {
                MessageBox.Show(hashtable[key].ToString());
            }
            MessageBox.Show("Count = " + hashtable.Count);
        }
    }
}

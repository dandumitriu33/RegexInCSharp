using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace RegexInCSharp
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

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidName(txtName.Text))
                MessageBox.Show("The name is invalid (only alphabetical characters are allowed)");
            if (!ValidPhone(txtPhone.Text))
                MessageBox.Show("The phone number is not valid.");
            if (!ValidEmail(txtEmail.Text))
                MessageBox.Show("The Email is not valid.");
            string reformattedPhone = ReformatPhone(txtPhone.Text);
            txtPhone.Text = reformattedPhone;
            MessageBox.Show("All good.");
        }

        private string ReformatPhone(string text)
        {
            var result = Regex.Replace(text, @"(\w{3})(\w{3})(\w{4})", @"($1) $2-$3");
            return result;
        }

        public bool ValidPhone(string text)
        {
            if (!Regex.IsMatch(text, @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$"))
            {
                return false;
            }
            return true;
        }

        public bool ValidEmail(string text)
        {
            if (!Regex.IsMatch(text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                return false;
            }
            return true;
        }

        public bool ValidName(string text)
        {
            if (!Regex.IsMatch(text, @"^([A-Za-z]+\s*)+$"))
            {
                return false;
            }
            return true;
        }
    }
}

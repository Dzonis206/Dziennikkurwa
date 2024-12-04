using dziennik.Services;
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


namespace dziennik.Windows
{
    public partial class AddStudentWindow : Window
    {
        private databaseService _databaseService { get; set; } = new databaseService();

        public AddStudentWindow()
        {
            InitializeComponent();
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            string imie = TextBoxImie.Text;
            string nazwisko = TextBoxNazwisko.Text;
            int pesel;
            int punkty;

            if (!int.TryParse(TextBoxPesel.Text, out pesel))
            {
                MessageBox.Show("Invalid PESEL format.");
                return;
            }

            string klasaId = TextBoxKlasaId.Text;
            if (string.IsNullOrWhiteSpace(klasaId) || klasaId.Length > 10)
            {
                MessageBox.Show("Invalid Klasa ID format.");
                return;
            }

            if (!int.TryParse(TextBoxPunkty.Text, out punkty))
            {
                MessageBox.Show("Invalid Punkty format.");
                return;
            }

            string haslo = PasswordBoxHaslo.Password;

            _databaseService.AddStudent(imie, nazwisko, pesel, haslo, klasaId, punkty);

            MessageBox.Show("Uczeń został dodany.");
            this.Close();
        }


    }
}


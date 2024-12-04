using dziennik.Class;
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
using System.Windows.Shapes;

namespace dziennik.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy TeacherWindow.xaml
    /// </summary>
    public partial class TeacherWindow : Window
    {
        private Teacher dane;
        private databaseService _databaseService { get; set; } = new databaseService();
        public TeacherWindow(int pesel, string password)
        {
            InitializeComponent();

            dane = _databaseService.GetTeacherData(pesel, password);

            // Ustawienie tekstu powitania
            _textblock_witaj.Text = $"Witaj {dane.imie} {dane.nazwisko}";

            LoadClass(dane.PESEL);

            _listBox_uczniowie.SelectionChanged += LoadStudent;

            // Load subjects into the ComboBox
            LoadSubjects();

            // Load grades into the ComboBox
            LoadGrades();

            // Sprawdzenie PESEL i ustawienie widoczności przycisku
            CheckPeselAndSetButtonVisibility(pesel);
        }

        private void CheckPeselAndSetButtonVisibility(int pesel)
        {
            if (pesel == 2137)
            {
                AddStudentButton.Visibility = Visibility.Visible;
            }
            else
            {
                AddStudentButton.Visibility = Visibility.Collapsed;
            }
        }

        private void LoadClass(int id)
        {
            List<Student> students = new List<Student>(_databaseService.GetStudentsFromClass(id));

            students.ForEach(student =>
            {
                _listBox_uczniowie.Items.Add(new ListBoxItem { Content = student.imie + " " + student.nazwisko, Tag = student.PESEL });
            });
        }

        private void LoadStudent(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (_listBox_uczniowie.SelectedItem == null)
            {
                return;
            }

            ListBoxItem itemBox = (ListBoxItem)_listBox_uczniowie.SelectedItem;

            Student student = _databaseService.GetStudentData((int)itemBox.Tag);

            if (student == null)
            {
                MessageBox.Show("Student not found.");
                return;
            }

            _textblock_imie_nazwisko.Text = student.imie + " " + student.nazwisko;
            _textblock_punkty.Text = student.punkty.ToString();
            _textblock_pesel.Text = student.PESEL.ToString();

            _treeView_oceny.Items.Clear();

            student.oceny.GroupBy(o => o.nazwa).ToList().ForEach(group =>
            {
                TreeViewItem przedmiot = new TreeViewItem { Header = group.Key };

                foreach (var item in group)
                {
                    przedmiot.Items.Add(new TreeViewItem { Header = item.ocena });
                }

                _treeView_oceny.Items.Add(przedmiot);
            });
        }


        private void LoadSubjects()
        {
            var subjects = _databaseService.GetSubjects();
            if (subjects != null)
            {
                _comboBox_subjects.ItemsSource = subjects;
            }
            else
            {
                MessageBox.Show("Nie można załadować przedmiotów.");
            }
        }

        private void LoadGrades()
        {
            var grades = new List<string> { "1", "2", "3", "4", "5", "6" };
            _comboBox_grades.ItemsSource = grades;
        }

        private void AddGrade_Click(object sender, RoutedEventArgs e)
        {
            if (_listBox_uczniowie.SelectedItem == null ||
                _comboBox_subjects.SelectedItem == null ||
                _comboBox_grades.SelectedItem == null)
            {
                MessageBox.Show("Please select a student, subject, and grade.");
                return;
            }

            ListBoxItem itemBox = (ListBoxItem)_listBox_uczniowie.SelectedItem;
            int studentPesel = (int)itemBox.Tag;
            string subject = _comboBox_subjects.SelectedItem.ToString();
            string grade = _comboBox_grades.SelectedItem.ToString();

            _databaseService.AddGradeToStudent(studentPesel, subject, grade);

            LoadStudent(null, null);
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            addStudentWindow.ShowDialog();
        }

        private void AddPoints_Click(object sender, RoutedEventArgs e)
        {
            if (_listBox_uczniowie.SelectedItem == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            ListBoxItem itemBox = (ListBoxItem)_listBox_uczniowie.SelectedItem;
            int studentPesel = (int)itemBox.Tag;

            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the number of points to add:", "Add Points", "0");

            if (int.TryParse(input, out int points))
            {
                _databaseService.AddPointsToStudent(studentPesel, points);
                MessageBox.Show("Points added successfully!");
                LoadStudent(null, null);
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }


        private void SubtractPoints_Click(object sender, RoutedEventArgs e)
        {
            if (_listBox_uczniowie.SelectedItem == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            ListBoxItem itemBox = (ListBoxItem)_listBox_uczniowie.SelectedItem;
            int studentPesel = (int)itemBox.Tag;

            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the number of points to subtract:", "Subtract Points", "0");

            if (int.TryParse(input, out int points))
            {
                _databaseService.SubtractPointsFromStudent(studentPesel, points);
                MessageBox.Show("Points subtracted successfully!");
                LoadStudent(null, null);
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

    }
}

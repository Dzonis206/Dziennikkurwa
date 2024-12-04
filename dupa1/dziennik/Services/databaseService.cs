using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Windows;
using dziennik.Class;
using Dapper;
using System.Windows.Controls;
using dziennik.Windows;

namespace dziennik.Services
{
    public class databaseService
    {
        SqlConnection connection { get; set; }
        string connectionString { get; set; }
        public databaseService()
        {
            connectionString = "Data Source=10.100.100.146;Initial Catalog=Szkola;User ID=admin2;Password=zaq1@WSX;TrustServerCertificate=True;Connect Timeout=30;Encrypt=True;";

            connection = new SqlConnection(connectionString);
        }
        public string GetType(int pesel, string password)
        {
            if (!DoesConnected())
            {
                return null;
            }
            string query = $"SELECT COUNT(*) FROM uczen where PESEL = {pesel} AND haslo = ${password}";

            SqlCommand command = new SqlCommand(query, connection);

            string query1 = $"SELECT COUNT(*) FROM nauczyciel where PESEL = {pesel} AND haslo = ${password}";

            SqlCommand command1 = new SqlCommand(query1, connection);

            int rowCount_uczen = (int)command.ExecuteScalar();

            int rowCount_nauczyciel = (int)command1.ExecuteScalar();

            connection.Close();

            if (rowCount_uczen > 0)
            {
                //shorted for uczeń
                return "u";
            }

            if (rowCount_nauczyciel > 0)
            {
                //shorted for nauczyciel
                return "n";
            }

            return "";
        }
        public Student GetStudentData(int pesel)
        {
            if (!DoesConnected())
            {
                return null;
            }
            string query = "SELECT * FROM uczen WHERE pesel = @pesel;";

            Student student = connection.Query<Student>(query, new { pesel }).First();

            string query_grades = "SELECT id_ucznia, ocena, Id_przedmiotu, nazwa FROM ocena JOIN przedmiot ON ocena.Id_przedmiotu = przedmiot.Id WHERE Id_ucznia = @pesel;";

            var grades = connection.Query<Grade>(query_grades, new { pesel });

            student.oceny = new List<Grade>(grades);

            connection.Close();

            return student;
        }
        public IEnumerable<Student> GetStudentsFromClass(int id_nauczyciela)
        {
            if (!DoesConnected())
            {
                return null;
            }

            string query_find_class = "SELECT Id from klasa WHERE wychowawca_id = @id_nauczyciela";

            string klasa = connection.Query<string>(query_find_class, new { id_nauczyciela }).First();

            string query = "SELECT * FROM uczen WHERE klasa_id = @klasa";

            IEnumerable<Student> students = connection.Query<Student>(query, new { klasa });

            connection.Close();

            return students;
        }
        public Teacher GetTeacherData(int pesel, string password)
        {
            if (!DoesConnected())
            {
                return null;
            }
            string query = "SELECT * FROM nauczyciel WHERE pesel = @pesel AND haslo = @password;";

            Teacher teacher = connection.Query<Teacher>(query, new { pesel, password }).First();

            connection.Close();

            return teacher;
        }
        private bool DoesConnected()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd połączenia: {ex.Message}");
                return false;
            }
        }
        public IEnumerable<string> GetSubjects()
        {
            if (!DoesConnected())
            {
                return null;
            }

            string query = "SELECT nazwa FROM przedmiot;";
            IEnumerable<string> subjects = connection.Query<string>(query);

            connection.Close();

            return subjects;
        }


        internal void AddGradeToStudent(int studentPesel, string subject, string grade)
        {
            if (!DoesConnected())
            {
                throw new InvalidOperationException("Nie można połączyć się z bazą danych.");
            }

            string query = "INSERT INTO ocena (Id_ucznia, Id_przedmiotu, ocena) VALUES (@studentPesel, (SELECT TOP 1 Id FROM przedmiot WHERE nazwa = @subject), @grade);";

            connection.Execute(query, new { studentPesel, subject, grade });

            connection.Close();
        }

        public void AddPointsToStudent(int studentPesel, int points)
        {
            if (!DoesConnected())
            {
                throw new InvalidOperationException("Nie można połączyć się z bazą danych.");
            }
            connection.Close();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updatePointsQuery = "UPDATE uczen SET Punkty = Punkty + @points WHERE PESEL = @studentPesel";
                connection.Execute(updatePointsQuery, new { points, studentPesel });

                connection.Close();
            }
        }

        public void SubtractPointsFromStudent(int studentPesel, int points)
        {
            if (!DoesConnected())
            {
                throw new InvalidOperationException("Nie można połączyć się z bazą danych.");
            }
            connection.Close();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updatePointsQuery = "UPDATE uczen SET Punkty = Punkty - @points WHERE PESEL = @studentPesel";
                connection.Execute(updatePointsQuery, new { points, studentPesel });

                connection.Close();
            }
        }


        public void AddStudent(string imie, string nazwisko, int pesel, string haslo, string klasaId, int punkty)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO uczen (Imie, Nazwisko, PESEL, Haslo, Klasa_Id, Punkty) VALUES (@Imie, @Nazwisko, @PESEL, @Haslo, @KlasaId, @Punkty)";
                connection.Execute(query, new { imie, nazwisko, pesel, haslo, klasaId, punkty });
                connection.Close();
            }
        }
    }
}

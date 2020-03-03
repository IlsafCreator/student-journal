using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentJournal
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }

    // Класс студента
    public class Student
    {
        public int id;
        public string fio;
        public string bday;
        public string photo;
        public string mail;
        public string phone;
        public string group;
    }

    // Класс успеваемости
    public class Learning
    {
        public int id;
        public int student;
        public int mark;
    }

    // Класс группы
    public class Groups
    {
        public int id;
        public string name;
    }

    // Мероприятия
    public class Events
    {
        public int id;
        public string title;
        public int student;
    }

    // Класс для соединения с базой данных
    public class Database
    {
        // Параметры сервера
        public string host = "localhost";
        public string database = "journal";
        public string user = "root";
        public string password = "root";

        // Коннектор
        MySqlConnection connector;

        // Функция подключения
        public void Connect()
        {
            string connStr = "server=" + host + ";user=" + user + ";database=" + database + ";password=" + password + ";";
            connector = new MySqlConnection(connStr);

            connector.Open();
        }

        // Функция отключения
        public void Disconnect()
        {
            connector.Close();
        }

        // Выполнение запроса без возврата
        public void QR(string qr)
        {
            MySqlCommand command = new MySqlCommand(qr, connector);
            command.ExecuteScalar();
        }

        // Запрос возвращающий объект MySQLDataReader
        public MySqlDataReader GetReaderQR(string qr)
        {
            MySqlCommand command = new MySqlCommand(qr, connector);
            MySqlDataReader reader = command.ExecuteReader();

            return reader;
        }

        // Запрос возвращающий Лист из строк
        public List<string> GetQR(string qr)
        {
            List<string> tmpList = new List<string>();

            MySqlCommand command = new MySqlCommand(qr, connector);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // ...
            }

            return tmpList;
        }

        // Запрос возвращающий Лист из строк по таблице и столбцу
        public List<string> GetQR(string table, string collumn)
        {
            List<string> tmpList = new List<string>();

            string qr = "SELECT `" + collumn + "` FROM `" + table + "`;";

            MySqlCommand command = new MySqlCommand(qr, connector);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                tmpList.Add(reader[0].ToString());
            }

            reader.Close();

            return tmpList;
        }
    }
}

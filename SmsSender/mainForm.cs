using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace SmsSender
{
    public partial class mainForm : Form
    {   
        // Файл БД, Номер COMпорта Коннектор и SQL запрос. Создаются при загрузки главной формы
        private String dbFile;
        private String comPort;
        private SQLiteConnection dbConn;    
        private SQLiteCommand sqlCmd;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mmExit_Click(object sender, EventArgs e)
        {
            // Выход из программы
            Application.Exit();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //Загрузка главной формы и получение параметров программы
            dbFile = Properties.Settings.Default.dbFile;
            comPort = Properties.Settings.Default.comPport;
            dbConn = new SQLiteConnection();
            sqlCmd = new SQLiteCommand();

            db_connect();
            db_read_all();
            
        }

        private void db_connect()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
                dbConn.ConnectionString = "Data Source=" + dbFile + ";Version=3;";
                dbConn.Open();
                sqlCmd.Connection = dbConn;
                sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS drivers (id INTEGER PRIMARY KEY AUTOINCREMENT, checking BOOL callsing INT, name TEXT, phone TEXT )";
                sqlCmd.ExecuteNonQuery();
            }
            else
            {
                dbConn.ConnectionString = "Data Source=" + dbFile + ";Version=3;";
                dbConn.Open();
                sqlCmd.Connection = dbConn;
            }

        }

        private void db_read_all()
        {

        }
    }
}

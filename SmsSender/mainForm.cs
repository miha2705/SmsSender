using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace SmsSender
{
    public partial class mainForm : Form
    {   
        
        private String dbFile;      // Файл БД
        private String comPort;     // com порт подключения модема
        private SQLiteConnection dbConn;    
        private SQLiteCommand sqlCmd;
        private List<string> lstResivers;   // Список получателей sms

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
            lstResivers = new List<string>();

            db_connect();
            db_read_all();
            format_dbgrid();
            stbComPort.Text = comPort;
        }

        private void db_connect()
        {   
            /* Подключение к БД. Если ЮД нет , то ее создание и подулючение к ней */
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
                dbConn.ConnectionString = "Data Source=" + dbFile + ";Version=3;";
                dbConn.Open();
                sqlCmd.Connection = dbConn;
                sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS drivers (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT, callsing INT, phone TEXT, checking BOLL)";
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
            // Считываем данные с БД
            DataTable d_table = new DataTable();
            String sqlQuery;
            
            if (dbConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Отсутствует подключение к БД");
                Application.Exit();
            }

            sqlQuery = "SELECT checking, callsing, name, phone, id FROM drivers";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConn);
            adapter.Fill(d_table);
            DataGridViewCheckBoxColumn chCol = new DataGridViewCheckBoxColumn();
            dgrDrivers.Columns.Add(chCol);
            
            dgrDrivers.ColumnCount = d_table.Columns.Count;
            for (int i = 0; i < d_table.Rows.Count; i++)
                dgrDrivers.Rows.Add(d_table.Rows[i].ItemArray);
              
        }

        private void format_dbgrid()
        {
            dgrDrivers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgrDrivers.Columns[0].HeaderText = "Выбрать";
            dgrDrivers.Columns[1].HeaderText = "Позывной";
            dgrDrivers.Columns[2].HeaderText = "Фамилия";
            dgrDrivers.Columns[3].HeaderText = "Телефон";
            dgrDrivers.Columns[4].Visible = false;      //Столбец с id делаем невидимым
            dgrDrivers.Columns[1].ReadOnly = true;
            dgrDrivers.Columns[2].ReadOnly = true;
            
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            lstResivers.Clear();    // Очищаем списво получателей

            // Собираем в список lstResivers телефоны получателей sms
            for (int i = 0; i < dgrDrivers.Rows.Count; i++)
            {
                if (dgrDrivers[0, i].Value.ToString() == "True")
                {
                    lstResivers.Add(dgrDrivers[3, i].Value.ToString());
                         
                }
                
            }
            txtMessage.Text = lstResivers[0];
        }

        private void mmSettings_Click(object sender, EventArgs e)
        {
            settingsForm setForm = new settingsForm();
            setForm.ShowDialog();
        }
    }
}

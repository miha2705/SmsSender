using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SmsSender
{
    public partial class FormAddDriver : Form
    {
        private SQLiteConnection dbConn;
        private DataGridView dataGrid;

        public FormAddDriver(SQLiteConnection Conn, DataGridView dgr)
        {
            InitializeComponent();
            dbConn = Conn;
            dataGrid = dgr;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SQLiteCommand sqlCmd = new SQLiteCommand();
            // Проверка подключений и заполненности полей
            if (dbConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Нет Подключения к Базе Данных");
                return;
            }
            if (txtName.Text == "" || txtPhone.Text == "" || txtCallsing.Text == "")
            {
                MessageBox.Show("Заполните все поля!!!");
                return;
            }
            // Формируем SQL запрос
            sqlCmd.CommandText = "INSERT INTO drivers ('name', 'callsing', 'phone') values ('" +
                txtName.Text + "', '" +
                txtCallsing.Text + "', '" +
                txtPhone.Text + "')";
                sqlCmd.Connection = dbConn;
            // Пытаемся выполнить запрос
            try
            {
                sqlCmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }                
    }
}

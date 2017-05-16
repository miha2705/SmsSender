using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace SmsSender
{
    class SmsSending
    {
        private String msg;             // Текст СМС
        private String comPortNum;      // Номер порта
        private string[] resivers;      // Список номеров Для отправки смс
        private SerialPort comPort;     // COM порт подключения модема

        public SmsSending(string[] resivarray, string textsms, string port)
        {
            resivers = resivarray;
            msg = textsms;
            comPortNum = port;
            comPort = new SerialPort();
            
        }

        public void start_sending()
        {
            // Запуск рассылки
            int sum = 0;
            bool result; 

            OpenPort();
            
            ClosePort();
        }

        private bool send_msg(string telnumber, string textsms)     
        {
            return true;
        }

        private void OpenPort()
        {
            if (comPort.IsOpen)
                comPort.Close();
            // Подготовка и открытие COM порта
            comPort.BaudRate = 9600;
            comPort.DataBits = 7;
            comPort.StopBits = StopBits.One;
            comPort.Parity = Parity.Odd;
            comPort.ReadTimeout = 500;
            comPort.WriteTimeout = 500;
            comPort.Encoding = Encoding.GetEncoding("windows-1251");
            comPort.PortName = comPortNum;
           
            try
            {
                comPort.Open();
            }
            catch
            {
                MessageBox.Show("Не удалось открыть порт " + comPortNum);               
            }
        }

        private void ClosePort()
        {
            // Закрытие COM порта
            comPort.Close();
        }    
    }
}

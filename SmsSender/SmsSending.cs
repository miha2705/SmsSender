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
            int s = 0;
            bool result;

            if (!modem_up())
            {
                MessageBox.Show("Рассылка остановлена");
                return;
            }
                
            for (int i = 0; i < resivers.Length; i++)
            {
                result = send_msg(resivers[i]);
                if (result)
                    s++;
                Thread.Sleep(1500);
            }

            MessageBox.Show("Отправлено " + s.ToString() + " сообщений");
            modem_down();
        }

        private bool modem_up()
        {
            // Подготовка модема к рассылке смс

            OpenPort();
            if (!comPort.IsOpen)
            {
                return false;
            }
            string recievedData;
            comPort.WriteLine("AT\r\n");
            Thread.Sleep(500);
            recievedData = comPort.ReadExisting();

            if (!recievedData.Contains("OK"))
            {
                MessageBox.Show("Не удалось подключиться к модему!");
                return false;
            }

            try
            {
                comPort.WriteLine("AT\r\n");  
                Thread.Sleep(500);
                comPort.Write("AT+CMGF=1\r\n");
                Thread.Sleep(500);
            }
            catch
            {
                MessageBox.Show("Не удалось подключиться к модему через " + comPortNum);
                return false;
            }
            return true;
        }

        private void modem_down()
        {
            ClosePort();
        }

        private bool send_msg(string telnumber)     
        {
            try
            {
                comPort.Write("AT+CMGS=\"" + telnumber + "\"" + "\r\n");
                Thread.Sleep(500);
                comPort.Write(msg + char.ConvertFromUtf32(26) + "\r\n");
                Thread.Sleep(2500);
            }
            catch { return false; }

            try
            {
                string recievedData;
                recievedData = comPort.ReadExisting();

                if (recievedData.Contains("ERROR"))
                {
                    return false;
                }

            }
            catch { }

            return true;
        }

        private void OpenPort()
        {
            // Подготовка и открытие COM порта
            comPort.BaudRate = 9600;
            comPort.DataBits = 7;
            comPort.StopBits = StopBits.One;
            comPort.Parity = Parity.Odd;
            comPort.ReadTimeout = 500;
            comPort.WriteTimeout = 500;
            comPort.Encoding = Encoding.GetEncoding("windows-1251");
            comPort.PortName = comPortNum;

            if (comPort.IsOpen)
                comPort.Close();

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

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

            string msgUsc = StringToUCS2(msg);
            OpenPort();


            ClosePort();
            
        }

        private bool send_sms(string phoneNum)     // Заглушка
        {
            // отправка сообщения
            if (!comPort.IsOpen)    // проверка открыт ли порт
                return false;

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
                MessageBox.Show("Не удалось открыть порт " + comPortNum + comPort.IsOpen);               
            }
        }

        private void ClosePort()
        {
            // Закрытие COM порта
            comPort.Close();
        }

        private string EncodePhoneNumber(string PhoneNum)
        {   
            // Перекодирование номера для формата PDU
            string result = "";

            if ((PhoneNum.Length % 2) > 0)
                PhoneNum += "F";
            int i = 0;
            while (i < PhoneNum.Length)
            {
                result += PhoneNum[i + 1].ToString() + PhoneNum[i].ToString();
                i += 2;
            }

            return result.Trim();
        }

        private string StringToUCS2(string str)
        {
            // Перекодирование текста смс в UCS2
            UnicodeEncoding ue = new UnicodeEncoding();
            byte[] ucs2 = ue.GetBytes(str);

            int i = 0;
            while (i < ucs2.Length)
            {
                byte b = ucs2[i + 1];
                ucs2[i + 1] = ucs2[i];
                ucs2[i] = b;
                i += 2;
            }
            return BitConverter.ToString(ucs2).Replace("-", "");
        }
    }
}

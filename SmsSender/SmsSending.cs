using System;
using System.IO.Ports;
using System.Windows.Forms;


namespace SmsSender
{
    class SmsSending
    {
        private String msg;
        private String comPortNum;
        private string[] resivers;

        public SmsSending(string[] resivarray, string textsms, string port)
        {
            resivers = resivarray;
            msg = textsms;
            comPortNum = port;
        }

        public void start_sending()
        {
            // Запуск рассылки
        }

        private void send_sms()
        {
            // отправка сообщения
            
        }
    }
}

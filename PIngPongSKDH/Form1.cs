using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace PIngPongSKDH
{
    public partial class Form1 : Form
    {
        List<string> ports = new List<string> { };
        string Port;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Подключиться")
            {
                Port = FindPort();
                if (Port != null)
                {
                    button1.Text = "Отключиться";
                    CurrentPort.PortName = Port;
                    Success();
                    CurrentPort.Open();

                }
                else
                {
                    Fail();
                }
            }
            else if (button1.Text == "Отключиться")
            {
                button1.Text = "Подключиться";
                if (CurrentPort.IsOpen)
                {
                    CurrentPort.Close();
                    Fail();
                }
                else
                {
                    Port = null;
                    ports.Clear();
                    Fail();
                }
            }
        }

        private void Info_Click(object sender, EventArgs e)
        {

        }

        private string FindPort()
        {
            ports = SerialPort.GetPortNames().ToList();
            string keyWord = "Ping";
            try
            {
                foreach (string port in ports)
                {
                    CurrentPort.PortName = port;
                    Thread.Sleep(10);
                    CurrentPort.Open();
                    if (port != "COM1")
                    {
                        for (int i = 0; i < 100; i++)
                        {
                            CurrentPort.Write(keyWord);

                            string answer = CurrentPort.ReadExisting();
                            Thread.Sleep(10);
                            if (answer.Contains("Pong"))
                            {
                                CurrentPort.Close();
                                return port;
                            }
                        }
                    }
                    CurrentPort.Close();
                }
            }
            catch
            {
                MessageBox.Show("Проверьте подключение стенда");
            }
            return null;
        }

        private void Success()
        {
            Condition.Text = "Успешное подключение";
            Condition.BackColor = Color.Green;
            Condition.ForeColor = Color.Black;
        }

        private void Fail()
        {
            Condition.Text = "Нет подключения";
            Condition.BackColor = Color.Red;
            Condition.ForeColor = Color.Black;
        }
    }
}

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
        bool isFound = false;
        
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

        private void Load_Click(object sender, EventArgs e)
        {
            try
            {
                if (isFound)
                {
                    string data = WaitingAnswer();
                    if (data != null)
                    {
                        textBox1.Text = data;
                    }
                    else
                    {
                        Fail();
                    }
                }
            }
            catch
            {
                Fail();
                MessageBox.Show("Проверьте подключение стенда");
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
                    CurrentPort.Open();
                    if (port != "COM1")
                    {
                        for (int i = 0; i < 100; i++)
                        {
                            CurrentPort.Write(keyWord);
                            Thread.Sleep(10);
                            string answer = CurrentPort.ReadLine();
                            Thread.Sleep(10);
                            if (answer.Contains("Pong"))
                            {
                                CurrentPort.Close();
                                isFound = true;
                                return port;
                            }
                        }
                    }
                    CurrentPort.Close();
                }
            }
            catch
            {
                isFound = false;
                MessageBox.Show("Проверьте подключение стенда");
            }
            isFound = false;
            return null;
        }

        private void Success()
        {
            button1.Text = "Отключиться";
            Load.Visible = true;
            Load.Enabled = true;
            Condition.Text = "Успешное подключение";
            Condition.BackColor = Color.Green;
            Condition.ForeColor = Color.Black;
        }

        private void Fail()
        {
            button1.Text = "Подключиться";
            Load.Visible = false;
            Load.Enabled = false;
            Condition.Text = "Нет подключения";
            Condition.BackColor = Color.Red;
            Condition.ForeColor = Color.Black;
        }

        private string WaitingAnswer()
        {
            for (int i = 0; i < 100; i++)
            {
                CurrentPort.Write("Load");
                Thread.Sleep(10);
                string answer = CurrentPort.ReadLine();
                string message = null;
                if (answer.StartsWith("[") && answer.EndsWith("\r"))
                {
                    message = answer;
                    return answer;
                }
            }
            return null;
        }
    }
}

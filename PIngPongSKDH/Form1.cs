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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindStand();
        }

        private bool FindStand()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                CurrentPort.PortName = port;
                CurrentPort.BaudRate = 9600;
                Thread.Sleep(10);
                CurrentPort.Open();
                if (port != "COM1")
                {
                    for (int i = 0; i < 100; i++)
                    {
                        CurrentPort.Write("Ping");

                        string answer = CurrentPort.ReadLine();
                        Thread.Sleep(10);
                        if (answer.Contains("Pong"))
                        {
                            textBox1.Text = answer;
                            Condition.BackColor = Color.Green;
                            return true;
                        }
                        
                    }
                }
                CurrentPort.Close();
            }

            Condition.BackColor = Color.Red;
            textBox1.Text = "Не найдено подходящего устройства";
            return false;
        }



        private void Load_Click(object sender, EventArgs e)
        {
            string answer = GetData();
            textBox1.Text = answer;
        }

        private string GetData()
        {
            if (CurrentPort.IsOpen)
            {
                for (int i = 0; i < 100; i++)
                {
                    CurrentPort.Write("Load");

                    string answer = CurrentPort.ReadExisting();
                    Thread.Sleep(10);
                    if (answer.Contains("99"))
                    {
                        Condition.BackColor = Color.Green;
                        CurrentPort.Close();
                        return answer;
                    }

                }

            }
            CurrentPort.Close();
            return "Ошибка порта";
        }
    }
}

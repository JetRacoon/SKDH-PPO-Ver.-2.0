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
                SerialPort currentPort = new SerialPort(port, 9600);
                Thread.Sleep(10);
                currentPort.Open();
                currentPort.Write("Ping");
                if (port != "COM1")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        string answer = currentPort.ReadExisting();
                        Thread.Sleep(10);
                        if (answer.Contains("Pong"))
                        {
                            textBox1.Text = answer;
                            Condition.BackColor = Color.Green;
                            currentPort.Close();
                            return true;
                        }
                        textBox1.Text = answer;
                    }
                }
                currentPort.Close();
            }

            Condition.BackColor = Color.Red;
            //textBox1.Text = "Не найдено подходящего устройства";
            return false;
        }
    }
}

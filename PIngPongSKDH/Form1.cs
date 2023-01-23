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
        string data;
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
                    MessageBox.Show("Проверьте подключение стенда");
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
                    data = WaitingAnswer();
                    if (data != null)
                    {
                        MessageBox.Show("Данные успешно получены");
                        Report.Visible = true;
                        Report.Enabled = true;
                        label1.Visible = true;
                        textBox1.Visible = true;
                        textBox1.Text = "";
                        label2.Visible = true;
                        textBox2.Visible = true;
                        label3.Visible = true;
                        textBox3.Visible = true;
                        List<string> dataStand = new List<string>();
                        dataStand = FilterData(data);
                        textBox2.Text = dataStand[0];
                        textBox3.Text = dataStand[1];
                    }
                    else
                    {
                        MessageBox.Show("Данные повреждены. Повторите калибровку и попытайтесь загрузить данные снова");
                    }
                }
            }
            catch
            {
                Fail();
                MessageBox.Show("Проверьте подключение стенда");
            }
        }

        private void Report_Click(object sender, EventArgs e)
        {
            if(data != null)
            {
                saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Word document|*.docx";
                saveFileDialog1.Title = "Выберите путь сохранения";
                if (DialogResult.OK == saveFileDialog1.ShowDialog())
                {
                    string location = saveFileDialog1.FileName;
                    WordHelper helper = new WordHelper();
                    if (helper.WordTemplate(DateTime.Now.ToString(), textBox1.Text, textBox2.Text, textBox3.Text, location)){
                        MessageBox.Show("Отчёт сформирован");
                    }
                    else
                    {
                        MessageBox.Show("Что-то пошло не так. Повторите попытку");
                    }
                }
                
            }
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
                            else
                            {
                                CurrentPort.Close();
                                isFound = false;
                                return null;
                            }
                        }
                    }
                    CurrentPort.Close();
                }
            }
            catch
            {
                isFound = false;

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
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            Report.Visible = false;
            label3.Visible = false;
            textBox3.Visible = false;
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
                else { return null; }
            }
            return null;
        }

        private List<string> FilterData(string data)
        {
            List<string> messages = new List<string>();
            int timeIndex = data.IndexOf('%');
            messages.Add(data.Substring(1, timeIndex-1));
            messages.Add(data.Substring(timeIndex + 1));

            return messages;
        }

        private void Info_Click(object sender, EventArgs e)
        {
            string message = "Прикладное программное обеспечение СКДХ\n" +
                "Версия ППО: 2.0 от 19.01.2023\n" +
                "Разработчик: ЮЗГУ НИЛ 'МиР'\n" +
                "Номер телефона: +7(4712)22-26-26\n" +
                "Email: lab.swsu@gmail.com";

            MessageBox.Show(message);
        }


    }
}

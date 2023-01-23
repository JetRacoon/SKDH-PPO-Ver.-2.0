namespace PIngPongSKDH
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Condition = new System.Windows.Forms.Button();
            this.CurrentPort = new System.IO.Ports.SerialPort(this.components);
            this.Load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Report = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(10, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "Подключиться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(585, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // Condition
            // 
            this.Condition.BackColor = System.Drawing.Color.Red;
            this.Condition.Enabled = false;
            this.Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Condition.ForeColor = System.Drawing.Color.Black;
            this.Condition.Location = new System.Drawing.Point(10, 440);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(275, 70);
            this.Condition.TabIndex = 2;
            this.Condition.Text = "Нет подключения";
            this.Condition.UseVisualStyleBackColor = false;
            // 
            // CurrentPort
            // 
            this.CurrentPort.BaudRate = 115200;
            // 
            // Load
            // 
            this.Load.Enabled = false;
            this.Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Load.Location = new System.Drawing.Point(10, 160);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(275, 95);
            this.Load.TabIndex = 3;
            this.Load.Text = "Загрузка";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Visible = false;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(542, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Серийный номер двигателя:";
            this.label1.Visible = false;
            // 
            // Report
            // 
            this.Report.Enabled = false;
            this.Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report.Location = new System.Drawing.Point(10, 290);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(275, 95);
            this.Report.TabIndex = 5;
            this.Report.Text = "Сформировать отчёт";
            this.Report.UseVisualStyleBackColor = true;
            this.Report.Visible = false;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // Info
            // 
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.Location = new System.Drawing.Point(600, 465);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(275, 45);
            this.Info.TabIndex = 6;
            this.Info.Text = "Информация";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(542, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Дата последней калибровки:";
            this.label2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(585, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(290, 31);
            this.textBox2.TabIndex = 7;
            this.textBox2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(542, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Значение временной задержки:";
            this.label3.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(585, 322);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(290, 31);
            this.textBox3.TabIndex = 9;
            this.textBox3.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 521);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Condition);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система формирования отчётной документации СКДХ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Condition;
        private System.IO.Ports.SerialPort CurrentPort;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}


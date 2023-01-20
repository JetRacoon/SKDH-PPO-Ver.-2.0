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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Condition = new System.Windows.Forms.Button();
            this.CurrentPort = new System.IO.Ports.SerialPort(this.components);
            this.Load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Report = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
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
            this.textBox1.Location = new System.Drawing.Point(582, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 31);
            this.textBox1.TabIndex = 1;
            // 
            // Condition
            // 
            this.Condition.BackColor = System.Drawing.Color.Red;
            this.Condition.Enabled = false;
            this.Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Condition.ForeColor = System.Drawing.Color.White;
            this.Condition.Location = new System.Drawing.Point(10, 440);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(275, 70);
            this.Condition.TabIndex = 2;
            this.Condition.UseVisualStyleBackColor = false;
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
            this.label1.Location = new System.Drawing.Point(577, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Серийный номер двигателя:";
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 518);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Condition);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}


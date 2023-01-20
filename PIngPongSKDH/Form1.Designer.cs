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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Подключиться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Condition
            // 
            this.Condition.BackColor = System.Drawing.Color.Red;
            this.Condition.Enabled = false;
            this.Condition.ForeColor = System.Drawing.Color.White;
            this.Condition.Location = new System.Drawing.Point(12, 176);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(34, 22);
            this.Condition.TabIndex = 2;
            this.Condition.UseVisualStyleBackColor = false;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(12, 84);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(164, 69);
            this.Load.TabIndex = 3;
            this.Load.Text = "Загрузка";
            this.Load.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 210);
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
    }
}


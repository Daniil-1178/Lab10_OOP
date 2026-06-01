namespace Lab10
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
            this.btnStart1 = new System.Windows.Forms.Button();
            this.btnStop1 = new System.Windows.Forms.Button();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.btnStart3 = new System.Windows.Forms.Button();
            this.btnStop3 = new System.Windows.Forms.Button();
            this.btnStartAll = new System.Windows.Forms.Button();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.txtOutput1 = new System.Windows.Forms.TextBox();
            this.txtOutput2 = new System.Windows.Forms.TextBox();
            this.txtOutput3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart1
            // 
            this.btnStart1.Location = new System.Drawing.Point(12, 241);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(220, 23);
            this.btnStart1.TabIndex = 0;
            this.btnStart1.Text = "Запустити потік 1";
            this.btnStart1.UseVisualStyleBackColor = true;
            this.btnStart1.Click += new System.EventHandler(this.btnStart1_Click);
            // 
            // btnStop1
            // 
            this.btnStop1.Location = new System.Drawing.Point(12, 270);
            this.btnStop1.Name = "btnStop1";
            this.btnStop1.Size = new System.Drawing.Size(220, 23);
            this.btnStop1.TabIndex = 1;
            this.btnStop1.Text = "Зупинити потік 1";
            this.btnStop1.UseVisualStyleBackColor = true;
            this.btnStop1.Click += new System.EventHandler(this.btnStop1_Click);
            // 
            // btnStart2
            // 
            this.btnStart2.Location = new System.Drawing.Point(305, 241);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(220, 23);
            this.btnStart2.TabIndex = 2;
            this.btnStart2.Text = "Запустити потік 2";
            this.btnStart2.UseVisualStyleBackColor = true;
            this.btnStart2.Click += new System.EventHandler(this.btnStart2_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.Location = new System.Drawing.Point(305, 270);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(220, 23);
            this.btnStop2.TabIndex = 3;
            this.btnStop2.Text = "Зупинити потік 2";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // btnStart3
            // 
            this.btnStart3.Location = new System.Drawing.Point(558, 241);
            this.btnStart3.Name = "btnStart3";
            this.btnStart3.Size = new System.Drawing.Size(220, 23);
            this.btnStart3.TabIndex = 4;
            this.btnStart3.Text = "Запустити потік 3";
            this.btnStart3.UseVisualStyleBackColor = true;
            this.btnStart3.Click += new System.EventHandler(this.btnStart3_Click);
            // 
            // btnStop3
            // 
            this.btnStop3.Location = new System.Drawing.Point(558, 270);
            this.btnStop3.Name = "btnStop3";
            this.btnStop3.Size = new System.Drawing.Size(220, 23);
            this.btnStop3.TabIndex = 5;
            this.btnStop3.Text = "Зупинити потік 3";
            this.btnStop3.UseVisualStyleBackColor = true;
            this.btnStop3.Click += new System.EventHandler(this.btnStop3_Click);
            // 
            // btnStartAll
            // 
            this.btnStartAll.Location = new System.Drawing.Point(305, 329);
            this.btnStartAll.Name = "btnStartAll";
            this.btnStartAll.Size = new System.Drawing.Size(220, 23);
            this.btnStartAll.TabIndex = 6;
            this.btnStartAll.Text = "Запустити всі потоки";
            this.btnStartAll.UseVisualStyleBackColor = true;
            this.btnStartAll.Click += new System.EventHandler(this.btnStartAll_Click);
            // 
            // btnStopAll
            // 
            this.btnStopAll.Location = new System.Drawing.Point(305, 358);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(220, 23);
            this.btnStopAll.TabIndex = 7;
            this.btnStopAll.Text = "Зупинити всі потоки";
            this.btnStopAll.UseVisualStyleBackColor = true;
            this.btnStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // txtOutput1
            // 
            this.txtOutput1.Location = new System.Drawing.Point(12, 14);
            this.txtOutput1.Multiline = true;
            this.txtOutput1.Name = "txtOutput1";
            this.txtOutput1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput1.Size = new System.Drawing.Size(220, 221);
            this.txtOutput1.TabIndex = 8;
            // 
            // txtOutput2
            // 
            this.txtOutput2.Location = new System.Drawing.Point(305, 14);
            this.txtOutput2.Multiline = true;
            this.txtOutput2.Name = "txtOutput2";
            this.txtOutput2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput2.Size = new System.Drawing.Size(220, 221);
            this.txtOutput2.TabIndex = 9;
            // 
            // txtOutput3
            // 
            this.txtOutput3.Location = new System.Drawing.Point(558, 14);
            this.txtOutput3.Multiline = true;
            this.txtOutput3.Name = "txtOutput3";
            this.txtOutput3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput3.Size = new System.Drawing.Size(220, 221);
            this.txtOutput3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOutput3);
            this.Controls.Add(this.txtOutput2);
            this.Controls.Add(this.txtOutput1);
            this.Controls.Add(this.btnStopAll);
            this.Controls.Add(this.btnStartAll);
            this.Controls.Add(this.btnStop3);
            this.Controls.Add(this.btnStart3);
            this.Controls.Add(this.btnStop2);
            this.Controls.Add(this.btnStart2);
            this.Controls.Add(this.btnStop1);
            this.Controls.Add(this.btnStart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart1;
        private System.Windows.Forms.Button btnStop1;
        private System.Windows.Forms.Button btnStart2;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.Button btnStart3;
        private System.Windows.Forms.Button btnStop3;
        private System.Windows.Forms.Button btnStartAll;
        private System.Windows.Forms.Button btnStopAll;
        private System.Windows.Forms.TextBox txtOutput1;
        private System.Windows.Forms.TextBox txtOutput2;
        private System.Windows.Forms.TextBox txtOutput3;
    }
}


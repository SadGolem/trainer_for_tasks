namespace Trainer
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
            this.TrainingTest_B = new System.Windows.Forms.Button();
            this.Lesson_B = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_B = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TrainingTest_B
            // 
            this.TrainingTest_B.Location = new System.Drawing.Point(163, 238);
            this.TrainingTest_B.Name = "TrainingTest_B";
            this.TrainingTest_B.Size = new System.Drawing.Size(391, 48);
            this.TrainingTest_B.TabIndex = 0;
            this.TrainingTest_B.Text = "Тренировка";
            this.TrainingTest_B.UseVisualStyleBackColor = true;
            this.TrainingTest_B.Click += new System.EventHandler(this.TrainingTest_B_Click);
            // 
            // Lesson_B
            // 
            this.Lesson_B.Location = new System.Drawing.Point(163, 141);
            this.Lesson_B.Name = "Lesson_B";
            this.Lesson_B.Size = new System.Drawing.Size(391, 48);
            this.Lesson_B.TabIndex = 3;
            this.Lesson_B.Text = "Изучить теорию";
            this.Lesson_B.UseVisualStyleBackColor = true;
            this.Lesson_B.Click += new System.EventHandler(this.Lesson_B_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "МЕНЮ";
            // 
            // Exit_B
            // 
            this.Exit_B.Location = new System.Drawing.Point(163, 439);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(391, 48);
            this.Exit_B.TabIndex = 5;
            this.Exit_B.Text = "Выход";
            this.Exit_B.UseVisualStyleBackColor = true;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(391, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Начать тест";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exit_B);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lesson_B);
            this.Controls.Add(this.TrainingTest_B);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TrainingTest_B;
        private System.Windows.Forms.Button Lesson_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit_B;
        private System.Windows.Forms.Button button1;
    }
}


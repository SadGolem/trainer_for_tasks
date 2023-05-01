namespace Trainer
{
    partial class TrainingTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Task_TB = new System.Windows.Forms.TextBox();
            this.Check_B = new System.Windows.Forms.Button();
            this.WhatDoing_B = new System.Windows.Forms.Button();
            this.Check_TB = new System.Windows.Forms.TextBox();
            this.StepNum_L = new System.Windows.Forms.Label();
            this.WhatDoing_TB = new System.Windows.Forms.TextBox();
            this.Back_B = new System.Windows.Forms.Button();
            this.NextTask_B = new System.Windows.Forms.Button();
            this.CountTask_L = new System.Windows.Forms.Label();
            this.Type_task_L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задача";
            // 
            // Task_TB
            // 
            this.Task_TB.Location = new System.Drawing.Point(50, 73);
            this.Task_TB.Multiline = true;
            this.Task_TB.Name = "Task_TB";
            this.Task_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Task_TB.Size = new System.Drawing.Size(444, 167);
            this.Task_TB.TabIndex = 1;
            // 
            // Check_B
            // 
            this.Check_B.Location = new System.Drawing.Point(50, 274);
            this.Check_B.Name = "Check_B";
            this.Check_B.Size = new System.Drawing.Size(142, 42);
            this.Check_B.TabIndex = 2;
            this.Check_B.Text = "Проверить";
            this.Check_B.UseVisualStyleBackColor = true;
            // 
            // WhatDoing_B
            // 
            this.WhatDoing_B.Location = new System.Drawing.Point(50, 350);
            this.WhatDoing_B.Name = "WhatDoing_B";
            this.WhatDoing_B.Size = new System.Drawing.Size(142, 42);
            this.WhatDoing_B.TabIndex = 3;
            this.WhatDoing_B.Text = "Что делать?";
            this.WhatDoing_B.UseVisualStyleBackColor = true;
            // 
            // Check_TB
            // 
            this.Check_TB.Location = new System.Drawing.Point(260, 274);
            this.Check_TB.Multiline = true;
            this.Check_TB.Name = "Check_TB";
            this.Check_TB.Size = new System.Drawing.Size(234, 42);
            this.Check_TB.TabIndex = 4;
            // 
            // StepNum_L
            // 
            this.StepNum_L.AutoSize = true;
            this.StepNum_L.Location = new System.Drawing.Point(257, 258);
            this.StepNum_L.Name = "StepNum_L";
            this.StepNum_L.Size = new System.Drawing.Size(177, 13);
            this.StepNum_L.TabIndex = 5;
            this.StepNum_L.Text = "Выполни 1 шаг в решении задачи\r\n";
            // 
            // WhatDoing_TB
            // 
            this.WhatDoing_TB.Location = new System.Drawing.Point(260, 350);
            this.WhatDoing_TB.Multiline = true;
            this.WhatDoing_TB.Name = "WhatDoing_TB";
            this.WhatDoing_TB.Size = new System.Drawing.Size(234, 42);
            this.WhatDoing_TB.TabIndex = 6;
            // 
            // Back_B
            // 
            this.Back_B.Location = new System.Drawing.Point(50, 449);
            this.Back_B.Name = "Back_B";
            this.Back_B.Size = new System.Drawing.Size(142, 42);
            this.Back_B.TabIndex = 7;
            this.Back_B.Text = "Вернуться в меню";
            this.Back_B.UseVisualStyleBackColor = true;
            this.Back_B.Click += new System.EventHandler(this.Back_B_Click);
            // 
            // NextTask_B
            // 
            this.NextTask_B.Enabled = false;
            this.NextTask_B.Location = new System.Drawing.Point(352, 449);
            this.NextTask_B.Name = "NextTask_B";
            this.NextTask_B.Size = new System.Drawing.Size(142, 42);
            this.NextTask_B.TabIndex = 8;
            this.NextTask_B.Text = "Следующая задача";
            this.NextTask_B.UseVisualStyleBackColor = true;
            // 
            // CountTask_L
            // 
            this.CountTask_L.AutoSize = true;
            this.CountTask_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CountTask_L.Location = new System.Drawing.Point(442, 22);
            this.CountTask_L.Name = "CountTask_L";
            this.CountTask_L.Size = new System.Drawing.Size(52, 31);
            this.CountTask_L.TabIndex = 19;
            this.CountTask_L.Text = "0/5";
            // 
            // Type_task_L
            // 
            this.Type_task_L.AutoSize = true;
            this.Type_task_L.Location = new System.Drawing.Point(214, 40);
            this.Type_task_L.Name = "Type_task_L";
            this.Type_task_L.Size = new System.Drawing.Size(35, 13);
            this.Type_task_L.TabIndex = 20;
            this.Type_task_L.Text = "label2";
            // 
            // TrainingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 503);
            this.Controls.Add(this.Type_task_L);
            this.Controls.Add(this.CountTask_L);
            this.Controls.Add(this.NextTask_B);
            this.Controls.Add(this.Back_B);
            this.Controls.Add(this.WhatDoing_TB);
            this.Controls.Add(this.StepNum_L);
            this.Controls.Add(this.Check_TB);
            this.Controls.Add(this.WhatDoing_B);
            this.Controls.Add(this.Check_B);
            this.Controls.Add(this.Task_TB);
            this.Controls.Add(this.label1);
            this.Name = "TrainingTest";
            this.Text = "TrainingTest";
            this.Load += new System.EventHandler(this.TrainingTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Task_TB;
        private System.Windows.Forms.Button Check_B;
        private System.Windows.Forms.Button WhatDoing_B;
        private System.Windows.Forms.TextBox Check_TB;
        private System.Windows.Forms.Label StepNum_L;
        private System.Windows.Forms.TextBox WhatDoing_TB;
        private System.Windows.Forms.Button Back_B;
        private System.Windows.Forms.Button NextTask_B;
        private System.Windows.Forms.Label CountTask_L;
        private System.Windows.Forms.Label Type_task_L;
    }
}
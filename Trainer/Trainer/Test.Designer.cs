namespace Trainer
{
    partial class Test
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
            this.NextTask_B = new System.Windows.Forms.Button();
            this.Back_B = new System.Windows.Forms.Button();
            this.Otvet_L = new System.Windows.Forms.Label();
            this.Check_TB = new System.Windows.Forms.TextBox();
            this.Check_B = new System.Windows.Forms.Button();
            this.Task_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CountTask_L = new System.Windows.Forms.Label();
            this.Type_task_L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NextTask_B
            // 
            this.NextTask_B.Enabled = false;
            this.NextTask_B.Location = new System.Drawing.Point(335, 427);
            this.NextTask_B.Name = "NextTask_B";
            this.NextTask_B.Size = new System.Drawing.Size(142, 42);
            this.NextTask_B.TabIndex = 17;
            this.NextTask_B.Text = "Следующая задача";
            this.NextTask_B.UseVisualStyleBackColor = true;
            // 
            // Back_B
            // 
            this.Back_B.Location = new System.Drawing.Point(33, 427);
            this.Back_B.Name = "Back_B";
            this.Back_B.Size = new System.Drawing.Size(142, 42);
            this.Back_B.TabIndex = 16;
            this.Back_B.Text = "Вернуться в меню";
            this.Back_B.UseVisualStyleBackColor = true;
            this.Back_B.Click += new System.EventHandler(this.Back_B_Click);
            // 
            // Otvet_L
            // 
            this.Otvet_L.AutoSize = true;
            this.Otvet_L.Location = new System.Drawing.Point(240, 284);
            this.Otvet_L.Name = "Otvet_L";
            this.Otvet_L.Size = new System.Drawing.Size(88, 13);
            this.Otvet_L.TabIndex = 14;
            this.Otvet_L.Text = "Конечный ответ";
            // 
            // Check_TB
            // 
            this.Check_TB.Location = new System.Drawing.Point(243, 300);
            this.Check_TB.Multiline = true;
            this.Check_TB.Name = "Check_TB";
            this.Check_TB.Size = new System.Drawing.Size(234, 42);
            this.Check_TB.TabIndex = 13;
            // 
            // Check_B
            // 
            this.Check_B.Location = new System.Drawing.Point(33, 300);
            this.Check_B.Name = "Check_B";
            this.Check_B.Size = new System.Drawing.Size(142, 42);
            this.Check_B.TabIndex = 11;
            this.Check_B.Text = "Проверить";
            this.Check_B.UseVisualStyleBackColor = true;
            // 
            // Task_TB
            // 
            this.Task_TB.Location = new System.Drawing.Point(33, 51);
            this.Task_TB.Multiline = true;
            this.Task_TB.Name = "Task_TB";
            this.Task_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Task_TB.Size = new System.Drawing.Size(444, 222);
            this.Task_TB.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Задача";
            // 
            // CountTask_L
            // 
            this.CountTask_L.AutoSize = true;
            this.CountTask_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CountTask_L.Location = new System.Drawing.Point(425, 9);
            this.CountTask_L.Name = "CountTask_L";
            this.CountTask_L.Size = new System.Drawing.Size(52, 31);
            this.CountTask_L.TabIndex = 18;
            this.CountTask_L.Text = "0/5";
            // 
            // Type_task_L
            // 
            this.Type_task_L.AutoSize = true;
            this.Type_task_L.Location = new System.Drawing.Point(139, 23);
            this.Type_task_L.Name = "Type_task_L";
            this.Type_task_L.Size = new System.Drawing.Size(35, 13);
            this.Type_task_L.TabIndex = 19;
            this.Type_task_L.Text = "label2";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 482);
            this.Controls.Add(this.Type_task_L);
            this.Controls.Add(this.CountTask_L);
            this.Controls.Add(this.NextTask_B);
            this.Controls.Add(this.Back_B);
            this.Controls.Add(this.Otvet_L);
            this.Controls.Add(this.Check_TB);
            this.Controls.Add(this.Check_B);
            this.Controls.Add(this.Task_TB);
            this.Controls.Add(this.label1);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextTask_B;
        private System.Windows.Forms.Button Back_B;
        private System.Windows.Forms.Label Otvet_L;
        private System.Windows.Forms.TextBox Check_TB;
        private System.Windows.Forms.Button Check_B;
        private System.Windows.Forms.TextBox Task_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CountTask_L;
        private System.Windows.Forms.Label Type_task_L;
    }
}
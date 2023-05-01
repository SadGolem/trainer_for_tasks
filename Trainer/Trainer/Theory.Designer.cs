namespace Trainer
{
    partial class Theory
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
            this.VariantTask_CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Back_B = new System.Windows.Forms.Button();
            this.Theory_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VariantTask_CB
            // 
            this.VariantTask_CB.FormattingEnabled = true;
            this.VariantTask_CB.Location = new System.Drawing.Point(35, 68);
            this.VariantTask_CB.Name = "VariantTask_CB";
            this.VariantTask_CB.Size = new System.Drawing.Size(183, 21);
            this.VariantTask_CB.TabIndex = 0;
            this.VariantTask_CB.Text = "Выбери тип задач";
            this.VariantTask_CB.SelectedIndexChanged += new System.EventHandler(this.VariantTask_CB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Укажи интересующий тебя тип задач";
            // 
            // Back_B
            // 
            this.Back_B.Location = new System.Drawing.Point(35, 389);
            this.Back_B.Name = "Back_B";
            this.Back_B.Size = new System.Drawing.Size(165, 35);
            this.Back_B.TabIndex = 2;
            this.Back_B.Text = "Вернуться в меню";
            this.Back_B.UseVisualStyleBackColor = true;
            this.Back_B.Click += new System.EventHandler(this.Back_B_Click);
            // 
            // Theory_TB
            // 
            this.Theory_TB.Location = new System.Drawing.Point(35, 151);
            this.Theory_TB.Multiline = true;
            this.Theory_TB.Name = "Theory_TB";
            this.Theory_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Theory_TB.Size = new System.Drawing.Size(458, 205);
            this.Theory_TB.TabIndex = 3;
            this.Theory_TB.Text = "Не выбран тип задачи\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Теория";
            // 
            // Theory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Theory_TB);
            this.Controls.Add(this.Back_B);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VariantTask_CB);
            this.Name = "Theory";
            this.Text = "Theory";
            this.Load += new System.EventHandler(this.Theory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox VariantTask_CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back_B;
        private System.Windows.Forms.TextBox Theory_TB;
        private System.Windows.Forms.Label label2;
    }
}
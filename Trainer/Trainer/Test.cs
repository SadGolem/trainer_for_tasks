using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainer
{
    public partial class Test : Form
    {

        int Speed1;
        int Speed2;
        int Time;
        int Way;
        int WayMeet;
        int Type;

        //для счета задачи 
        int counter_tasks = 1;
        int counter_right=0;
        public Test()
        {
            InitializeComponent();
        }

        private void Back_B_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void Test_Load(object sender, EventArgs e)
        {
            NextTask_B.Enabled = false;
            if (counter_tasks == 6)
            {
                MessageBox.Show("Правильных ответов: " + counter_right.ToString() + "/5");
            }
            else
            {
                Tasks tasks = new Tasks();
                Random rnd = new Random();
                Speed1 = rnd.Next(40, 80);
                Speed2 = rnd.Next(40, 80);
                Time = rnd.Next(1, 3);
                Way = rnd.Next(120, 500);
                WayMeet = Way - rnd.Next(60, 100);
                Type = rnd.Next(0, 4);


                Type_task_L.Text = "Тип задачи " + (Type + 1).ToString();
                Task_TB.Text = tasks.Make(WayMeet, Speed1, Speed2, Time, Way, Type);

                CountTask_L.Text = counter_tasks.ToString() + "/5";
                if (Type == 2)
                {
                    Task_TB.Text += "\n Ответ записать в виде двух чисел через запятую.";
                }
            }
            
        }

        private void NextTask_B_Click(object sender, EventArgs e)
        {
            Test_Load(sender, e);
            Check_TB.Text = "";
        }

        private void Check_B_Click(object sender, EventArgs e)
        {
            switch (Type)
            { 
                case 0:
                    if (Check_TB.Text.Replace(" ", "") != (Speed1 * Time).ToString())
                    {
                        counter_tasks++;
                        MessageBox.Show("Ответ засчитан.");
                        NextTask_B.Enabled = true;
                    }
                    else
                    {
                        counter_tasks++;
                        counter_right++;
                        MessageBox.Show("Ответ засчитан.");
                        NextTask_B.Enabled = true;
                    }
                    break;
                case 1:
                    if (Check_TB.Text.Replace(" ", "") != (Way - (Speed1 + Speed2)*Time).ToString())
                    {
                        counter_tasks++;
                        MessageBox.Show("Ответ засчитан.");
                        NextTask_B.Enabled = true;
                    }
                    else
                    {
                        counter_tasks++;
                        counter_right++;
                        MessageBox.Show("Ответ засчитан.");
                        NextTask_B.Enabled = true;
                    }
                    break;

                case 2:
                    if (Check_TB.Text.Replace(" ", "") != ((Way - (Speed1*Time)).ToString() + "," + (Way - (Speed2 * Time)).ToString()) &
                        (Check_TB.Text.Replace(" ", "") != ((Way - (Speed2 * Time)).ToString() + "," + (Way - (Speed1 * Time)).ToString())))
                    {
                        counter_tasks++;
                        MessageBox.Show("Ответ засчитан.");
                        NextTask_B.Enabled = true;
                    }
                    else
                    {
                        counter_tasks++;
                        counter_right++;
                        MessageBox.Show("Ответ засчитан.");
                        NextTask_B.Enabled = true;
                    }
                    break;

                case 3:
                    if (Check_TB.Text.Replace(" ", "") != (Math.Round((double)Way/ (double)(Speed1+Speed2)),0).ToString())
                    {
                        counter_tasks++;
                        MessageBox.Show("Ответ засчитан.");
                        NextTask_B.Enabled = true;
                    }
                    else
                    {
                        counter_tasks++;
                        counter_right++;
                        MessageBox.Show("Ответ засчитан.");
                        NextTask_B.Enabled = true;
                    }
                    break;
                case 4:
                    if (Check_TB.Text.Replace(" ", "") != Math.Round((((double)Way - (double)(Time*Speed1))/ (double)Time),0).ToString())
                    {
                        counter_tasks++;
                        MessageBox.Show("Ответ засчитан.");
                        NextTask_B.Enabled = true;
                    }
                    else
                    {
                        counter_tasks++;
                        counter_right++;
                        MessageBox.Show("Ответ засчитан.");
                        NextTask_B.Enabled = true;
                    }
                    break;

            }
        }

    }
}

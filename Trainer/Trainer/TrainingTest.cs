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
    public partial class TrainingTest : Form
    {
        int Speed1;
        int Speed2;
        int Time;
        int Way;
        int WayMeet;
        int Type;

        //для расчетов
        int Way_1=0; 
        int Way_2=0;
        int d_1=0;
        int d_2=0;

        //для счета задачи 
        int counter_tasks= 1;

        public TrainingTest()
        {
            InitializeComponent();            
        }

        private void Back_B_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        public void TrainingTest_Load(object sender, EventArgs e)
        {
            NextTask_B.Enabled = false;
            if (counter_tasks == 6)
            {
                MessageBox.Show("Молодец, ты сделал все задачи, переходи к тестированию!");
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
                Way_1 = Speed1 * Time;
                d_1 = Way - Way_1;
                Way_2 = Speed2 * Time;
                d_2 = Way - Way_2;


                Type_task_L.Text = "Тип задачи " + (Type + 1).ToString();
                Task_TB.Text = tasks.Make(WayMeet, Speed1, Speed2, Time, Way, Type);
                StepNum_L.Text = "Выполни 1 шаг в решении задачи";

                CountTask_L.Text = counter_tasks.ToString() + "/5";
            }
            
        }
        private void NextTask_B_Click(object sender, EventArgs e)
        {  
            TrainingTest_Load(sender,e);
            CountTask_L.Text = counter_tasks.ToString() + "/5";
            Check_TB.Text = "";
            WhatDoing_TB.Text = "";
        }
        private void LastTaskWasCoplete(object sender, EventArgs e)
        {
            TrainingTest_Load(sender, e);
            CountTask_L.Text ="5/5";
        }

        private void Check_B_Click(object sender, EventArgs e)
        {
            switch (Type)
            {
                
                case 0:
                    if (Check_TB.Text.Replace(" ", "") != (Speed1.ToString() + "*" + Time.ToString() + "=" + (Speed1 * Time).ToString())
                        & Check_TB.Text.Replace(" ", "") != (Time.ToString() + "*" + Speed1.ToString() + "=" + (Speed1 * Time).ToString()))
                        MessageBox.Show("Подумай лучше");
                    else
                    {
                        if (counter_tasks != 6)
                        {
                            MessageBox.Show("Молодец! Ты выполнил задачу!");
                            counter_tasks++;
                            NextTask_B.Enabled = true;
                        }
                        else
                            MessageBox.Show("Молодец! Ты выполнил все задачи, переходи к тестированию!");
                    }
                    break;
                case 1:
                    if (StepNum_L.Text == "Выполни 2 шаг в решении задачи")
                    {
                        if (Check_TB.Text.Replace(" ", "") != ((Speed1 + Speed2).ToString() + "*" + Time.ToString() + "=" + ((Speed1 + Speed2) * Time).ToString())
                            & Check_TB.Text.Replace(" ", "") != (Time.ToString() + "*" + (Speed1 + Speed2).ToString() + "=" + ((Speed1 + Speed2) * Time).ToString()))
                            MessageBox.Show("Подумай лучше");
                        else
                        {
                            MessageBox.Show("Молодец! Приступай к следующему шагу");
                            StepNum_L.Text = "Выполни 3 шаг в решении задачи";
                            Check_TB.Clear();
                            break;
                        }
                    }
                    if (StepNum_L.Text == "Выполни 3 шаг в решении задачи")
                    {
                        if (Check_TB.Text.Replace(" ", "") != (Way.ToString() + "-" + ((Speed1 + Speed2) * Time).ToString() + "=" + (Way - (Speed1 + Speed2) * Time).ToString()))
                            MessageBox.Show("Подумай лучше");
                        else
                        {
                            if (counter_tasks != 6)
                            {
                                MessageBox.Show("Молодец! Ты выполнил задачу!");
                                counter_tasks++;
                                NextTask_B.Enabled = true;
                            }
                            else
                                MessageBox.Show("Молодец! Ты выполнил все задачи, переходи к тестированию!");

                            break;
                        }

                    }
                    if (StepNum_L.Text.Contains("1"))
                    {
                        if (Check_TB.Text.Replace(" ", "") != (Speed1.ToString() + "+" + Speed2.ToString() + "=" + (Speed1 + Speed2).ToString())
                        & Check_TB.Text.Replace(" ", "") != (Speed2.ToString() + "+" + Speed1.ToString() + "=" + (Speed1 + Speed2).ToString()))
                            MessageBox.Show("Подумай лучше");

                        else
                        {
                            MessageBox.Show("Молодец! Приступай к следующему шагу");
                            StepNum_L.Text = "Выполни 2 шаг в решении задачи";
                            Check_TB.Clear();
                            break;
                        }
                    }
                    break;
                 case 2:
                    
                        if (StepNum_L.Text == "Выполни 2 шаг в решении задачи")
                        {
                            if ( Check_TB.Text.Replace(" ", "") != ((Way).ToString() + "-" + (Speed1 * Time).ToString() + "=" + ((Way- (Speed1 * Time))).ToString()))
                                MessageBox.Show("Подумай лучше");
                            else
                            {
                                MessageBox.Show("Молодец! Приступай к следующему шагу");
                                StepNum_L.Text = "Выполни 3 шаг в решении задачи";
                                Check_TB.Clear();
                                break;
                            }
                        }

                        if (StepNum_L.Text == "Выполни 3 шаг в решении задачи")
                        {
                            if (Check_TB.Text.Replace(" ", "") != ((Speed2).ToString() + "*" + (Time).ToString() + "=" + (Speed2*Time).ToString())
                                & Check_TB.Text.Replace(" ", "") != (Time.ToString() + "*" + (Speed2).ToString() + "=" + (Speed2 * Time).ToString()))
                                MessageBox.Show("Подумай лучше");
                            else
                            {
                                MessageBox.Show("Молодец! Приступай к следующему шагу");
                                StepNum_L.Text = "Выполни 4 шаг в решении задачи";
                                Check_TB.Clear();
                                break;
                            }
                        }
                        if (StepNum_L.Text == "Выполни 4 шаг в решении задачи")
                        {
                            if (Check_TB.Text.Replace(" ", "") != ((Way).ToString() + "-" + (Way_2).ToString() + "=" + ((d_2)).ToString()))
                                MessageBox.Show("Подумай лучше");
                            else
                            {
                                if (counter_tasks != 6)
                                {
                                    MessageBox.Show("Молодец! Ты выполнил задачу!");
                                    counter_tasks++;
                                    NextTask_B.Enabled = true;
                                }
                                else
                                    MessageBox.Show("Молодец! Ты выполнил все задачи, переходи к тестированию!");

                                break;
                            }
                        }

                        if (StepNum_L.Text.Contains("1"))
                        {
                            if (Check_TB.Text.Replace(" ", "") != (Speed1.ToString() + "*" + Time.ToString() + "=" + (Speed1 * Time).ToString())
                            & Check_TB.Text.Replace(" ", "") != (Time.ToString() + "+" + Speed1.ToString() + "=" + (Speed1 * Time).ToString()))
                                MessageBox.Show("Подумай лучше");

                            else
                            {
                                MessageBox.Show("Молодец! Приступай к следующему шагу");
                                StepNum_L.Text = "Выполни 2 шаг в решении задачи";
                                Check_TB.Clear();
                                break;
                            }
                        }
                    break;
                case 3:
                    {
                        if (StepNum_L.Text == "Выполни 2 шаг в решении задачи")
                        {
                            if (Check_TB.Text.Replace(" ", "") != (Way).ToString() + "/" + (Speed1 + Speed2).ToString() + "=" + Math.Round(((double)Way / (double)(Speed1 + Speed2))).ToString())
                                MessageBox.Show("Подумай лучше");
                            else
                            {
                                if (counter_tasks != 6)
                                {
                                    MessageBox.Show("Молодец! Ты выполнил задачу!");
                                    counter_tasks++;
                                    NextTask_B.Enabled = true;
                                }
                                else
                                    MessageBox.Show("Молодец! Ты выполнил все задачи, переходи к тестированию!");

                                break;
                            }
                        }
                        if (StepNum_L.Text.Contains("1"))
                        {
                            if (Check_TB.Text.Replace(" ", "") != (Speed1.ToString() + "+" + Speed2.ToString() + "=" + (Speed1 + Speed2).ToString())
                            & Check_TB.Text.Replace(" ", "") != (Speed2.ToString() + "+" + Speed1.ToString() + "=" + (Speed1 + Speed2).ToString()))
                                MessageBox.Show("Подумай лучше");

                            else
                            {
                                MessageBox.Show("Молодец! Приступай к следующему шагу");
                                StepNum_L.Text = "Выполни 2 шаг в решении задачи";
                                Check_TB.Clear();
                                break;
                            }
                        }
                    }
                    break;
                case 4:
                    {
                        if (StepNum_L.Text == "Выполни 2 шаг в решении задачи")
                        {
                            if ( Check_TB.Text.Replace(" ", "") != (Way).ToString() + "-" + (Speed1 * Time).ToString() + "=" + (Way - (Speed1 * Time)).ToString())
                                MessageBox.Show("Подумай лучше");
                            else
                            {
                                MessageBox.Show("Молодец! Приступай к следующему шагу");
                                StepNum_L.Text = "Выполни 3 шаг в решении задачи";
                                Check_TB.Clear();
                                break;
                            }
                        }
                        if (StepNum_L.Text == "Выполни 3 шаг в решении задачи")
                        {
                            if (Check_TB.Text.Replace(" ", "") != (Way - (Speed1 * Time)).ToString() + "/" + (Time).ToString() + "=" 
                                + (Math.Round((((double)Way - ((double)Speed1 * (double)Time))/ (double)Time))).ToString())
                                
                                MessageBox.Show("Подумай лучше");
                            else
                            {
                                if (counter_tasks != 6)
                                {
                                    MessageBox.Show("Молодец! Ты выполнил задачу!");
                                    counter_tasks++;
                                    NextTask_B.Enabled = true;
                                }
                                else
                                    MessageBox.Show("Молодец! Ты выполнил все задачи, переходи к тестированию!");

                                break;
                            }
                        }
                        if (StepNum_L.Text.Contains("1"))
                        {
                            if (Check_TB.Text.Replace(" ", "") != (Speed1.ToString() + "*" + Time.ToString() + "=" + (Speed1 * Time).ToString())
                            & Check_TB.Text.Replace(" ", "") != (Time.ToString() + "*" + Speed1.ToString() + "=" + (Speed1 * Time).ToString()))
                                MessageBox.Show("Подумай лучше");

                            else
                            {
                                MessageBox.Show("Молодец! Приступай к следующему шагу");
                                StepNum_L.Text = "Выполни 2 шаг в решении задачи";
                                Check_TB.Clear();
                                break;
                            }
                        }
                    }
                    break;
            }

        }

        public void WhatDoing_B_Click(object sender, EventArgs e)
        {

            switch (Type)
            {
                case 0:
                    if (StepNum_L.Text.Contains("1"))
                    {
                        WhatDoing_TB.Clear();
                        WhatDoing_TB.Text = "Вычислить произведение этих чисел:" + '\r' + '\n' + " d = V_1  ∙ t_встр";
                    }
                    break;
                case 1:
                    if (StepNum_L.Text.Contains("1"))
                    {
                        WhatDoing_TB.Clear();
                        WhatDoing_TB.Text = "Вычислить сумму скоростей объектов):" + '\r' + '\n' + " V = V_1 + V_2" + '\r' + '\n';
                    }
                    if (StepNum_L.Text.Contains("2"))
                    {
                        WhatDoing_TB.Clear();
                        WhatDoing_TB.Text = "Вычислить произведение суммы скоростей объектов и времени движения:" + '\r' + '\n' + "S_1 = V * t_движ" + '\r' + '\n';
                    }
                    if (StepNum_L.Text.Contains("3"))
                    {
                        WhatDoing_TB.Clear();
                        WhatDoing_TB.Text = "Вычислить разность общего пути и произведения, полученного на предыдущем шаге:" + '\r' + '\n' + " d = S - S_1" + '\r' + '\n';
                    }
                    if (StepNum_L.Text.Contains("4"))
                    {
                        WhatDoing_TB.Clear();
                        WhatDoing_TB.Text = "Оформить ответ с соответствующими единицами измерений" + '\r' + '\n' + "d= S-(V_1+ V_2 )∙t_встр";
                    }
                    break;
                case 2:
                    if (StepNum_L.Text.Contains("1"))
                    {
                        WhatDoing_TB.Clear();
                        WhatDoing_TB.Text = "Для вычисления первого отрезка необходимо вычислить произведение скорости первого объекта и времени движения:" + '\r' + '\n' + "S_1 = V_1 * t_зад" + '\r' + '\n';
                    }
                    if (StepNum_L.Text.Contains("2"))
                    {
                        WhatDoing_TB.Clear();
                        WhatDoing_TB.Text = "Первый отрезок равен разности общего пути и произведения, полученного на предыдущем шаге:" + '\r' + '\n' + "d_1 = S - S_1" + '\r' + '\n';
                    }
                    if (StepNum_L.Text.Contains("3"))
                    {
                        WhatDoing_TB.Clear();
                        WhatDoing_TB.Text = "Для вычисления второго отрезка необходимо провести те же операции, что и для первого отрезка, заменив скорость первого объекта на второй:"
                        + '\r' + '\n' + " S_2 = V_2 * t_зад" + '\r' + '\n';
                    }
                    if (StepNum_L.Text.Contains("4"))
                    {
                        WhatDoing_TB.Clear();
                        WhatDoing_TB.Text = "Оформить ответ с соответствующими единицами измерений:" + '\r' + '\n' + "d_2 = S - S_2";
                    }
                    break;
                case 3:
                    if (StepNum_L.Text.Contains("1"))
                    {
                        WhatDoing_TB.Clear();
                        WhatDoing_TB.Text = "Для вычисления времени необходимо вычислить частное между суммой скоростей и общего пути: " + '\r' + '\n' + " V = V_1 + V_2" + '\r' + '\n';
                    }
                    if (StepNum_L.Text.Contains("2"))
                    {
                        WhatDoing_TB.Clear();
                        WhatDoing_TB.Text = "Оформить ответ с соответствующими единицами измерений:" + '\r' + '\n' + " t_встр = S / V " + '\r' + '\n';
                    }
                    break;
                case 4:
                    if (StepNum_L.Text.Contains("1"))
                    {
                        WhatDoing_TB.Clear();
                        WhatDoing_TB.Text = "Первым шагом, необходимо вычислить произведение скорости первого объекта на время встречи объектов." + '\r' + '\n' + "S_1 = t_встр * V_1" + '\r' + '\n';
                    }
                    if (StepNum_L.Text.Contains("2"))
                    {
                        WhatDoing_TB.Clear();
                        WhatDoing_TB.Text = "Вторым шагом, необходимо отнять значение пути от произведения, полученного на предыдущем этапе." + '\r' + '\n' + "S_2 = S - S_1" + '\r' + '\n';
                    }
                    if (StepNum_L.Text.Contains("3"))
                    {
                        WhatDoing_TB.Clear();
                        WhatDoing_TB.Text = "Для получения ответа необходимо вычислить частное между значением предыдущего этапа и временем встречи." + '\r' + '\n' + "V_2 = S_2/t_встр" + '\r' + '\n';
                    }
                    break;

            }
        }


    }
}

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
    public partial class Theory : Form
    {
        public Theory()
        {
            InitializeComponent();
        }

        private void Theory_Load(object sender, EventArgs e)
        {
            VariantTask_CB.Items.Add("1. На каком расстоянии от пункта произошла встреча, если известны скорости и время движения.");
            VariantTask_CB.Items.Add("2. Найти расстояние между объектами через заданное время.");
            VariantTask_CB.Items.Add("3. На каком расстоянии от пунктов назначения будут находиться объекты в заданное время.");
            VariantTask_CB.Items.Add("4. Найти время встречи объектов, зная скорости и расстояние.");
            VariantTask_CB.Items.Add("5. С какой скоростью должен двигаться второй объект, чтобы встретиться в заданной точке.");
        }

        private void Back_B_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VariantTask_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (VariantTask_CB.SelectedIndex)
            {
                case 0:
                    Theory_TB.Text = "Решение типа 1";
                    break;
                case 1:
                    Theory_TB.Text = "Решение типа 2";
                    break;
                case 2:
                    Theory_TB.Text = "Решение типа 3";
                    break;
                case 3:
                    Theory_TB.Text = "Решение типа 4";
                    break;
                case 4:
                    Theory_TB.Text = "Решение типа 5";
                    break;
                default:
                    Theory_TB.Text = "Не выбран тип задачи";
                    break;
            }
        }
    }
}

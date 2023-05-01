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
            Tasks tasks = new Tasks();
            Random rnd = new Random();

            int Speed1 = rnd.Next(40, 80);
            int Speed2 = rnd.Next(40, 80);
            int Time = rnd.Next(1, 2);
            int Way = rnd.Next(120, 500);
            int WayMeet = Way - rnd.Next(60, 100);
            int Type = rnd.Next(0, 4);

            Type_task_L.Text = "Тип задачи " + (Type+1).ToString();
            Task_TB.Text = tasks.Make(WayMeet, Speed1, Speed2, Time, Way, Type);
        }
    }
}

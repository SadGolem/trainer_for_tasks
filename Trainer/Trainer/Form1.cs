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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*Exit_B.Click() == ON*/
        }

        private void Exit_B_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lesson_B_Click(object sender, EventArgs e)
        {
            Theory newTheory = new Theory();
            newTheory.Show();
        }

        private void TrainingTest_B_Click(object sender, EventArgs e)
        {
            TrainingTest newTraining = new TrainingTest();
            newTraining.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test newTest = new Test();
            newTest.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afterschool
{
    public partial class Schedule : Form
    {
        string task1 = "";
        string task2 = "";
        string task3 = "";
        string task4 = "";
        string task5 = "";
        string task6 = "";

        string[] taskList = {task1, task2, task3, task4, task5, task6};

        public Schedule()
        {
            InitializeComponent();
        }

        public Schedule(string tsk1, string timeReq1, 
                        string tsk2, string timeReq2,
                        string tsk3, string timeReq3,
                        string tsk4, string timeReq4,
                        string tsk5, string timeReq5,
                        string tsk6, string timeReq6,
                        string evn1, string time1,
                        string evn2, string time2)
        {
            InitializeComponent();
            string[] tasks = {tsk1, tsk2, tsk3, tsk4, tsk5, tsk6};
            for task in tasks
                if (task =! null)
                    for taskVar in taskList
                        taskVar = task;
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            this.lblDate.Text = DateTime.Now.ToShortDateString();
        }

    }
}

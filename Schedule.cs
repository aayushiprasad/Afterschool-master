using System;
using System.Collections;
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
        string sTask1 = string.Empty;
        string sTask2 = string.Empty;
        string sTask3 = string.Empty;
        string sTask4 = string.Empty;
        string sTask5 = string.Empty;
        string sTask6 = string.Empty;

        string tTask1 = string.Empty;
        string tTask2 = string.Empty;
        string tTask3 = string.Empty;
        string tTask4 = string.Empty;
        string tTask5 = string.Empty;
        string tTask6 = string.Empty;

        string sEvent1 = string.Empty;
        string sEvent2 = string.Empty;

        string tEvent1 = string.Empty;
        string tEvent2 = string.Empty;

        string[] taskList;
        string[] taskTimeList;
        string[] eventList;
        string[] eventTimeList;

        string tStart = string.Empty;

        ArrayList scheduleText = new ArrayList();
        ArrayList scheduleTimeBlocks = new ArrayList();

        public Schedule()
        {
            InitializeComponent();
        }

        public Schedule(string strStart,
                        string tsk1, string timeReq1, 
                        string tsk2, string timeReq2,
                        string tsk3, string timeReq3,
                        string tsk4, string timeReq4,
                        string tsk5, string timeReq5,
                        string tsk6, string timeReq6,
                        string evn1, string time1,
                        string evn2, string time2)
        {
            InitializeComponent();

            taskList = new string[] { sTask1, sTask2, sTask3, sTask4, sTask5, sTask6 };
            taskTimeList = new string[] { tTask1, tTask2, tTask3, tTask4, tTask5, tTask6 };
            eventList = new string[] { sEvent1, sEvent2 };
            eventTimeList = new string[] { tEvent1, tEvent2 };
            
            string[] tasks = new string[] {tsk1, tsk2, tsk3, tsk4, tsk5, tsk6};
            string[] timeReq = new string[] { timeReq1, timeReq2, timeReq3, timeReq4, timeReq5, timeReq6};
            string[] events = new string[] { evn1, evn2 };
            string[] timeSet = new string[] { time1, time2 };


            foreach (var task in tasks)
            {
                if (task != null)
                    for (int i = 0; i < taskList.Length; i++)
                    {
                        taskList[i] = task;
                    }
            }

            foreach (var tReq in timeReq)
            {
                if (tReq != null)
                    for (int i = 0; i < taskTimeList.Length; i++)
                    {
                        taskList[i] = tReq;
                    }
            }

            foreach (var e in events)
            { 
                if (e != null)
                    for (int i = 0; i < eventList.Length; i++)
                    {
                        eventList[i] = e;
                    }
            }

            foreach (var tSet in timeSet)
            {
                if (tSet != null)
                    for (int i = 0; i < eventTimeList.Length; i++)
                    {
                        eventList[i] = tSet;
                    }
            }
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            this.lblDate.Text = DateTime.Now.ToShortDateString();

            foreach (var e in eventList)
            {

            }



        }

    }
}

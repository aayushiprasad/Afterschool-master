using Afterschool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afterschool
{
    public partial class TaskLog : Form
    {
        int TaskCount = 1;
        int EventCount = 1;
        List<string> timeRequired = new List<string>();
        List<string> timeStart = new List<string>();
        List<string> timeEnd = new List<string>();


        public TaskLog()
        {
            InitializeComponent();
        }

        private void TaskLog_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            this.Size = new Size(773, 467);
            this.pnlTask.Visible = true;
            this.pnlTask.BringToFront();
            this.pnlEvent.Visible = false;
            this.pnlTask.Location = new Point(18, 40);
            this.pnlEvent.Location = new Point(18, 40);

            this.lblDate.Text = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString();
            this.lblDayName.Text = DateTime.Now.DayOfWeek.ToString();
            this.lblMonth.Text = DateTime.Now.ToString("MMMM");

            //Make Panels Invisible
            this.pnlTask1.Visible = false;
            this.pnlTask2.Visible = false;
            this.pnlTask3.Visible = false;
            this.pnlTask4.Visible = false;
            this.pnlTask5.Visible = false;
            this.pnlTask6.Visible = false;
            this.pnlEvent1.Visible = false;
            this.pnlEvent2.Visible = false;

            timeRequired = TimeModel.timeIncrements();
            this.cbTimeRequired.DataSource = timeRequired.ToList();

            timeStart = TimeModel.times();
            this.cbFrom.DataSource = timeStart.ToList();

            timeEnd = TimeModel.times();
            this.cbTo.DataSource = timeEnd.ToList();
        }

        private void rbTask_CheckedChanged(object sender, EventArgs e)
        {

            if (this.rbTask.Checked)
            {
                this.pnlTask.Visible = true;
                this.pnlTask.BringToFront();
                this.pnlEvent.Visible = false;
            }
        }

        private void rbEvent_CheckedChanged(object sender, EventArgs e)
        {

            if (this.rbEvent.Checked)
            {
                this.pnlTask.Visible = false;
                this.pnlEvent.Visible = true;
                this.pnlEvent.BringToFront();
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (TaskCount == 1)
            {
                this.pnlTask1.Visible = true;
                this.chkTaskName1.Text = this.txtTitleName.Text.Trim();
                this.chkTaskName1.Text = this.txtTitleName.Text.Trim();
                this.lblTimeRequired1.Text = this.cbTimeRequired.Text.Trim() + " minutes";
            }
            else if (TaskCount == 2)
            {
                this.pnlTask2.Visible = true;
                this.chkTaskName2.Text = this.txtTitleName.Text.Trim();
                this.lblTimeRequired2.Text = this.cbTimeRequired.Text.Trim() + " minutes";
            }
            else if (TaskCount == 3)
            {
                this.pnlTask3.Visible = true;
                this.chkTaskName3.Text = this.txtTitleName.Text.Trim();
                this.lblTimeRequired3.Text = this.cbTimeRequired.Text.Trim() + " minutes";
            }
            else if (TaskCount == 4)
            {
                this.pnlTask4.Visible = true;
                this.chkTaskName4.Text = this.txtTitleName.Text.Trim();
                this.lblTimeRequired4.Text = this.cbTimeRequired.Text.Trim() + " minutes";
            }
            else if (TaskCount == 5)
            {
                this.pnlTask5.Visible = true;
                this.chkTaskName5.Text = this.txtTitleName.Text.Trim();
                this.lblTimeRequired5.Text = this.cbTimeRequired.Text.Trim() + " minutes";
            }
            else if (TaskCount == 6)
            {
                this.pnlTask6.Visible = true;
                this.chkTaskName6.Text = this.txtTitleName.Text.Trim();
                this.lblTimeRequired6.Text = this.cbTimeRequired.Text.Trim() + " minutes";
            }

            TaskCount += 1;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread schedule = new Thread(new ThreadStart(OpenSchedule));
            schedule.Start();
        }

        private void OpenSchedule()
        {
            Application.Run(new Schedule(this.chkTaskName1.Text,
                                         this.lblTimeRequired1.Text,
                                         this.chkTaskName2.Text,
                                         this.lblTimeRequired2.Text,
                                         this.chkTaskName3.Text,
                                         this.lblTimeRequired3.Text,
                                         this.chkTaskName4.Text,
                                         this.lblTimeRequired4.Text,
                                         this.chkTaskName5.Text,
                                         this.lblTimeRequired5.Text,
                                         this.chkTaskName6.Text,
                                         this.lblTimeRequired6.Text,
                                         this.chkEventName1.Text,
                                         this.lblTime1.Text,
                                         this.chkEventName2.Text,
                                         this.lblTime2.Text));
        }

        private void btnEventAdd_Click(object sender, EventArgs e)
        {
            if (EventCount == 1)
            {
                this.pnlEvent1.Visible = true;
                this.chkEventName1.Text = this.txtEventTitleInput.Text;
                this.lblTime1.Text = this.cbFrom.Text.Trim() + " - " + this.cbTo.Text.Trim() + " PM";
            }
            else if (EventCount == 2)
            {
                this.pnlEvent2.Visible = true;
                this.chkEventName2.Text = this.txtEventTitleInput.Text;
                this.lblTime2.Text = this.cbFrom.Text.Trim() + " - " + this.cbTo.Text.Trim() + " PM";
            }

            EventCount += 1;
        }
    }
}

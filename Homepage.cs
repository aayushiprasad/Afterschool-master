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
    public partial class Homepage : Form
    {
        List<string> times = new List<string>();
        bool bLoad = true;

        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            times = TimeModel.SchoolEndTimes();

            this.cbTime.DataSource = times.ToList();

            this.lblMonth.Text = DateTime.Now.Month.ToString();
            this.lblDay.Text = DateTime.Now.Day.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread taskLog = new Thread(new ThreadStart(OpenTaskLog));
            taskLog.Start();
        }

        private void OpenTaskLog()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new TaskLog(this.cbTime.SelectedValue.ToString()));
        }


        private void SelectedTime_Changed(object sender, EventArgs e)
        {
            string s = this.cbTime.SelectedValue.ToString();

            if (!bLoad)
            {
                MessageBox.Show(this, "You selected " + s + "!", Titles.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bLoad = false;
        }

        private void cboTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Personal_Diary
{
    public partial class Report1 : Form
    {
        CrystalReport1 cr;

        public static Report1 report1;
        public Report1()
        {
            InitializeComponent();
            report1 = this;
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            crystalReportViewer2.ReportSource = cr;
            cr.SetParameterValue(0, textBox1.Text.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

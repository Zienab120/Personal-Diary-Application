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
    public partial class Report2 : Form
    {
        public static Report2 report2;
        CrystalReport2 cr;
        public Report2()
        {
            InitializeComponent();
            report2 = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cr;
        }
    }
}

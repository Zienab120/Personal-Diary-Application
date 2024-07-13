using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Personal_Diary
{
    public partial class Navigation : Form
    {
        public static Navigation instance;
        public string email { set; get; }
        public Navigation()
        {
            InitializeComponent();
            instance = this;
        }

        private void signOut_btn_Click(object sender, EventArgs e)
        {
            LogIn login= new LogIn();
            login.Show();
            instance.Close();

        }

        private void addDiary_btn_Click(object sender, EventArgs e)
        {
            Diary diary = new Diary();
            diary.email = this.email;
            diary.Show();
           // instance.Close();

        }

        private void mySharedDiaries_btn_Click(object sender, EventArgs e)
        {
            SharedDiaries SharedDiaries = new SharedDiaries();
            SharedDiaries.email = this.email;
            SharedDiaries.Show();
            //instance.Close();

        }

        private void Navigation_Load(object sender, EventArgs e)
        {

        }

        private void Report1_Click(object sender, EventArgs e)
        {
            Report1 report = new Report1();
            report.Show();
        }

        private void Report2_Click(object sender, EventArgs e)
        {
            Report2 report2 = new Report2();
            report2.Show();
        }
    }
}

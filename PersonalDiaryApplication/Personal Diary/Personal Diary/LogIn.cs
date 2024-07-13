using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Personal_Diary
{
    public partial class LogIn : Form
    {
        string orclDB = "Data Source =orcl ; User Id= scott; Password=tiger;";
        OracleConnection conn;
        public static LogIn instance;
        
        public LogIn()
        {
            InitializeComponent();
            instance = this;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(orclDB);
            conn.Open();
            email_txtbox.Text = "@gmail.com";
        }

        private void logIn_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select password from users where email=:email";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("email",email_txtbox.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            if (!dr.Read())
            {
                MessageBox.Show("Your Email isn't correct");
            }
            else
            {
                string correctPassword = Convert.ToString(dr[0].ToString());
                string password = password_txtbox.Text;
                bool correct = true;
                if (correctPassword.Length != password.Length)
                    correct = false;
                else
                {
                    
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (password[i] != correctPassword[i])
                        {
                            correct = false;
                            break;
                        }
                    }
                }
                if (correct==true)
                {
                     Navigation navigation = new Navigation();
                    navigation.email = email_txtbox.Text;
                    navigation.ShowDialog();
                    instance.Close();
                }
                else
                {
                    MessageBox.Show("Your password isn't correct please try again");
                }
            }

        }

        
    }
}

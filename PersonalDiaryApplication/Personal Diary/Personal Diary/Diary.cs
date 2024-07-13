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
    public partial class Diary : Form
    {
        public string email { set; get; }
        public static Diary instance;
        string orcldb = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public Diary()
        {
            InitializeComponent();
            instance = this;
        }

        private void Diary_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(orcldb);
            conn.Open();
            date_txtbox.Text = DateTime.Now.ToString();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "get_title";
            cmd.Parameters.Add("title", OracleDbType.RefCursor, ParameterDirection.Output);
            cmd.Parameters.Add("email", email);
            OracleDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
               title_cmbox.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void title_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select diary_content,diary_date,event_location,feeling from diary_post where user_email=:email and diary_title=:title";
            cmd.Parameters.Add("email", email);
            cmd.Parameters.Add("title", title_cmbox.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                diary_txtbox.Text= dr[0].ToString();
                date_txtbox.Text = dr[1].ToString();
                location_txtbox.Text = dr[2].ToString();
                feeling_txtbox.Text = dr[3].ToString();

            }
            dr.Close();
        }

        private void AddDiary_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into   diary_post values (:diaryId,:diaryTitle,:diaryContent,:diaryDate,:diaryLocation,:diaryFeeling,:usermail)";
            cmd.Parameters.Add("diaryId", ID_txtbox.Text);
            cmd.Parameters.Add("diaryTitle", title_cmbox.Text);
            cmd.Parameters.Add("diaryContent", diary_txtbox.Text);
            cmd.Parameters.Add("diaryDate", date_txtbox.Text);
            cmd.Parameters.Add("diaryLocation", location_txtbox.Text );
            cmd.Parameters.Add("diaryFeeling", feeling_txtbox.Text);
            cmd.Parameters.Add("usermail", email);
            try
            {
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                    MessageBox.Show("Diary is added successfully.");
            }
            catch
            {
                MessageBox.Show("This ID is already used, Please enter another ID");
            }



        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation();
            navigation.Show();
            navigation.email = email;
            instance.Close();
        }
    }
}

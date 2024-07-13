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
    public partial class SharedDiaries : Form
    {
        public string email { set; get; }
        OracleDataAdapter dAdapter, tAdapter;
        OracleCommandBuilder dBuilder,tBuilder;
        DataSet ds1,ds2;
        string constr = "Data Source =orcl ; User Id= scott; Password=tiger;";
        OracleConnection conn;
        public static SharedDiaries instance;
        public SharedDiaries()
        {
            InitializeComponent();
            instance = this;
        }

        private void SharedDiaries_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(constr);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select username,email from USERS u ,FRIENDS f where f.friend_email=u.email and f.user_email=:email";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("email", email);
            OracleDataReader dr = cmd.ExecuteReader();
      
            while (dr.Read())
            {
                friends_cmbox.Items.Add(dr[0]);              
            }
            dr.Close();

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "get_friends_count";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("friendsCount", OracleDbType.Int16, ParameterDirection.Output);
            cmd.Parameters.Add("email", email);
            cmd.ExecuteNonQuery();
            friends_label.Text="Your friends is "+ cmd.Parameters["friendsCount"].Value.ToString() +" friend";
        }


        private void friends_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmdstr = "select d.* from DIARY_POST d,TAG_FRIENDS t,USERS u where u.username=:friend and t.friend_mail=u.email and t.user_mail =:email and d.Diary_id =t.taggedDiary_ID ";
            dAdapter = new OracleDataAdapter(cmdstr, constr);
            dAdapter.SelectCommand.Parameters.Add(new OracleParameter("friend", friends_cmbox.SelectedItem));
            dAdapter.SelectCommand.Parameters.Add(new OracleParameter("email", email));
            ds1 = new DataSet();
            dAdapter.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];

            string cmd2str = "select t.* from TAG_FRIENDS t, USERS u where u.username=:friend and t.friend_mail=u.email and t.user_mail =:email ";
            tAdapter = new OracleDataAdapter(cmd2str, constr);
            tAdapter.SelectCommand.Parameters.Add(new OracleParameter("friend", friends_cmbox.SelectedItem));
            tAdapter.SelectCommand.Parameters.Add(new OracleParameter("email", email));
            ds2 = new DataSet();
            tAdapter.Fill(ds2);
            dataGridView2.DataSource = ds2.Tables[0];
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation();
            navigation.Show();
            navigation.email = email;
            instance.Close();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            dBuilder = new OracleCommandBuilder(dAdapter);
            dAdapter.Update(ds1.Tables[0]);
            tBuilder = new OracleCommandBuilder(tAdapter);
            tAdapter.Update(ds2.Tables[0]);
            MessageBox.Show("Row is inserted successfully");
        }


    }
}

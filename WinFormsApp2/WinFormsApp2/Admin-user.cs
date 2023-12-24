using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static WinFormsApp2.Gloable;


namespace WinFormsApp2
{
    public partial class Admin_user : Form
    {
        //MyAccountReg F1 = new MyAccountReg();

        //MyAccountReg.sql;

        SqlConnection con = new SqlConnection(CODB.sql);


        public Admin_user()
        {
            InitializeComponent();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Admin_add_new_user_Click(object sender, EventArgs e)
        {
            string query = "Insert into Users (Name, Password, Phone, Role) Values (@Name, @Password, @Phone, @Role)";
            con.Open();

            string SelectValue = comboBox1.Text;
            SqlCommand cmd =  new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@Name", Admin_add_new_UserName.Text);
            cmd.Parameters.AddWithValue("@Password", textBox1.Text);
            cmd.Parameters.AddWithValue("Phone", textBox2.Text);
            cmd.Parameters.AddWithValue("@Role", SelectValue);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("User Added");

        }

        private void Admin_Bar_Enter(object sender, EventArgs e)
        {
           
        }

        private void Admin_Bar_Layout(object sender, LayoutEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

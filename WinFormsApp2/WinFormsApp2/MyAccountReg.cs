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
using System.Security.Permissions;
using static WinFormsApp2.Gloable;




namespace WinFormsApp2
{
    public partial class MyAccountReg : Form
    {





        SqlConnection con = new SqlConnection(CODB.sql);
        public MyAccountReg()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_sign_up_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO users (Name, Password, Phone) VALUES (@Name, @Password, @Phone)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Name", txt_reg_username.Text);
            cmd.Parameters.AddWithValue("@Password", txt_reg_password.Text);
            cmd.Parameters.AddWithValue("@Phone", txt_reg_phone.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Bar_Layout(object sender, LayoutEventArgs e)
        {
            Admin_Bar.Visible = true;
        }

        private void txt_sign_in_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sign_in_Click(object sender, EventArgs e)
        {

            bool ck_email = false;
            bool ck_password = false;

            string qurey = "Select * FROM Users where(Name = @Name)";

            con.Open();

            SqlCommand cmd = new SqlCommand(qurey, con);
            cmd.Parameters.AddWithValue("@Name", txt_sign_in_username.Text);

            SqlDataReader reader;



            reader = cmd.ExecuteReader();



            if (reader.Read())
            {


                if (reader["Name"].ToString() == txt_sign_in_username.Text)
                {
                    ck_email = true;
                }

                if (reader["Password"].ToString() == txt_sign_in_password.Text)
                {
                    ck_password = true;
                }




                if (!ck_email)
                {
                    MessageBox.Show(txt_reg_username + " not Found");
                }
                else if (!ck_password)
                {
                    MessageBox.Show("Wrong Password");
                }
                else if (ck_email && ck_password)
                {


                    Admin.user_id = int.Parse(reader["id"].ToString());

                    if (reader["Role"].ToString() == "admin")
                    {
                        Admin.admin_bar_visable = true;

                        Admin_Bar.Visible = true;
                      
                    }
           
                }
                else
                {
                    MessageBox.Show("Something went wrong connect with ur IT");
                }






            }

            con.Close();



        }

        private void Admin_Bar_Enter(object sender, EventArgs e)
        {

        }

        private void Admin_Bar_User_Click(object sender, EventArgs e)
        {
            Admin_user admin_user = new Admin_user();

            admin_user.Show();
            Visible = false;
        }
    }

}

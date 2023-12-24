using static WinFormsApp2.Gloable;



namespace WinFormsApp2
{
    partial class Admin_user
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Admin_Bar = new GroupBox();
            Admin_Bar_User = new Button();
            label3 = new Label();
            Admin_add_new_UserName = new TextBox();
            label_admin_name = new Label();
            label_admin_password = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            Admin_add_new_user = new Button();
            Admin_Bar.SuspendLayout();
            SuspendLayout();
            // 
            // Admin_Bar
            // 
            Admin_Bar.Controls.Add(Admin_Bar_User);
            Admin_Bar.Location = new Point(2, 1);
            Admin_Bar.Name = "Admin_Bar";
            Admin_Bar.Size = new Size(797, 53);
            Admin_Bar.TabIndex = 0;
            Admin_Bar.TabStop = false;
            Admin_Bar.Text = "AdminBar";
            Admin_Bar.Visible = false;
            Admin_Bar.Enter += Admin_Bar_Enter;
            Admin_Bar.Layout += Admin_Bar_Layout;
            // 
            // Admin_Bar_User
            // 
            Admin_Bar_User.BackColor = Color.NavajoWhite;
            Admin_Bar_User.Location = new Point(363, 22);
            Admin_Bar_User.Name = "Admin_Bar_User";
            Admin_Bar_User.Size = new Size(75, 23);
            Admin_Bar_User.TabIndex = 0;
            Admin_Bar_User.Text = "User";
            Admin_Bar_User.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(309, 84);
            label3.Name = "label3";
            label3.Size = new Size(178, 37);
            label3.TabIndex = 20;
            label3.Text = "Add new user";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Admin_add_new_UserName
            // 
            Admin_add_new_UserName.Location = new Point(116, 187);
            Admin_add_new_UserName.Name = "Admin_add_new_UserName";
            Admin_add_new_UserName.Size = new Size(286, 23);
            Admin_add_new_UserName.TabIndex = 21;
            // 
            // label_admin_name
            // 
            label_admin_name.AutoSize = true;
            label_admin_name.Location = new Point(45, 190);
            label_admin_name.Name = "label_admin_name";
            label_admin_name.Size = new Size(39, 15);
            label_admin_name.TabIndex = 22;
            label_admin_name.Text = "Name";
            // 
            // label_admin_password
            // 
            label_admin_password.AutoSize = true;
            label_admin_password.Location = new Point(45, 244);
            label_admin_password.Name = "label_admin_password";
            label_admin_password.Size = new Size(57, 15);
            label_admin_password.TabIndex = 24;
            label_admin_password.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 241);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 23);
            textBox1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 289);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 26;
            label2.Text = "Phone";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 286);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 23);
            textBox2.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 349);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 27;
            label1.Text = "Role";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "admin", "customer" });
            comboBox1.Location = new Point(116, 341);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 23);
            comboBox1.TabIndex = 28;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Admin_add_new_user
            // 
            Admin_add_new_user.BackColor = SystemColors.ControlLight;
            Admin_add_new_user.Location = new Point(204, 393);
            Admin_add_new_user.Name = "Admin_add_new_user";
            Admin_add_new_user.Size = new Size(75, 23);
            Admin_add_new_user.TabIndex = 29;
            Admin_add_new_user.Text = "Add User";
            Admin_add_new_user.UseVisualStyleBackColor = false;
            Admin_add_new_user.Click += Admin_add_new_user_Click;
            // 
            // Admin_user
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Admin_add_new_user);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label_admin_password);
            Controls.Add(textBox1);
            Controls.Add(label_admin_name);
            Controls.Add(Admin_add_new_UserName);
            Controls.Add(label3);
            Controls.Add(Admin_Bar);
            Name = "Admin_user";
            Text = "Admin_user";
            Admin_Bar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Admin_Bar;
        private Button Admin_Bar_User;
        private Label label3;
        private TextBox Admin_add_new_UserName;
        private Label label_admin_name;
        private Label label_admin_password;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private ComboBox comboBox1;
        private Button Admin_add_new_user;
    }
}
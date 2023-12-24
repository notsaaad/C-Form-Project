using static WinFormsApp2.Gloable;

namespace WinFormsApp2

{
    partial class MyAccountReg
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
            label3 = new Label();
            txt_reg_phone = new TextBox();
            label2 = new Label();
            btn_sign_up = new Button();
            txt_reg_password = new TextBox();
            txt_reg_username = new TextBox();
            label1 = new Label();
            btn_sign_in = new Button();
            txt_sign_in_password = new TextBox();
            txt_sign_in_username = new TextBox();
            Admin_Bar = new GroupBox();
            Admin_Bar_User = new Button();
            Menu_Cart = new Label();
            Menu_logout = new Label();
            Admin_Bar.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(307, 88);
            label3.Name = "label3";
            label3.Size = new Size(157, 37);
            label3.TabIndex = 19;
            label3.Text = "My Account";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // txt_reg_phone
            // 
            txt_reg_phone.Location = new Point(528, 323);
            txt_reg_phone.Name = "txt_reg_phone";
            txt_reg_phone.PlaceholderText = "Enter Your Phone Number";
            txt_reg_phone.Size = new Size(203, 23);
            txt_reg_phone.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(574, 194);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 17;
            label2.Text = "Registration";
            label2.Click += label2_Click;
            // 
            // btn_sign_up
            // 
            btn_sign_up.Location = new Point(528, 371);
            btn_sign_up.Name = "btn_sign_up";
            btn_sign_up.RightToLeft = RightToLeft.Yes;
            btn_sign_up.Size = new Size(203, 23);
            btn_sign_up.TabIndex = 16;
            btn_sign_up.Text = "Sign Up";
            btn_sign_up.UseVisualStyleBackColor = true;
            btn_sign_up.Click += btn_sign_up_Click;
            // 
            // txt_reg_password
            // 
            txt_reg_password.Location = new Point(528, 277);
            txt_reg_password.Name = "txt_reg_password";
            txt_reg_password.PlaceholderText = "Enter your Password";
            txt_reg_password.Size = new Size(203, 23);
            txt_reg_password.TabIndex = 15;
            // 
            // txt_reg_username
            // 
            txt_reg_username.Location = new Point(528, 237);
            txt_reg_username.Name = "txt_reg_username";
            txt_reg_username.PlaceholderText = "Enter your User Name";
            txt_reg_username.Size = new Size(203, 23);
            txt_reg_username.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 194);
            label1.Name = "label1";
            label1.Size = new Size(205, 25);
            label1.TabIndex = 13;
            label1.Text = "Have Account ? Sign in";
            label1.Click += label1_Click;
            // 
            // btn_sign_in
            // 
            btn_sign_in.Location = new Point(35, 323);
            btn_sign_in.Name = "btn_sign_in";
            btn_sign_in.Size = new Size(203, 23);
            btn_sign_in.TabIndex = 12;
            btn_sign_in.Text = "Sign in ";
            btn_sign_in.UseVisualStyleBackColor = true;
            btn_sign_in.Click += btn_sign_in_Click;
            // 
            // txt_sign_in_password
            // 
            txt_sign_in_password.Location = new Point(35, 277);
            txt_sign_in_password.Name = "txt_sign_in_password";
            txt_sign_in_password.PlaceholderText = "Enter your Password";
            txt_sign_in_password.Size = new Size(203, 23);
            txt_sign_in_password.TabIndex = 11;
            // 
            // txt_sign_in_username
            // 
            txt_sign_in_username.Location = new Point(35, 237);
            txt_sign_in_username.Name = "txt_sign_in_username";
            txt_sign_in_username.PlaceholderText = "Enter your User Name";
            txt_sign_in_username.Size = new Size(203, 23);
            txt_sign_in_username.TabIndex = 10;
            txt_sign_in_username.TextChanged += txt_sign_in_username_TextChanged;
            // 
            // Admin_Bar
            // 
            Admin_Bar.Controls.Add(Admin_Bar_User);
            Admin_Bar.Location = new Point(0, 12);
            Admin_Bar.Name = "Admin_Bar";
            Admin_Bar.Size = new Size(797, 53);
            Admin_Bar.TabIndex = 20;
            Admin_Bar.TabStop = false;
            Admin_Bar.Text = "AdminBar";
            Admin_Bar.Visible = Admin.admin_bar_visable;
            Admin_Bar.Enter += Admin_Bar_Enter;
            Admin_Bar.Layout += Admin_Bar_Layout;
            // 
            // Admin_Bar_User
            // 
            Admin_Bar_User.Location = new Point(352, 22);
            Admin_Bar_User.Name = "Admin_Bar_User";
            Admin_Bar_User.Size = new Size(75, 23);
            Admin_Bar_User.TabIndex = 0;
            Admin_Bar_User.Text = "User";
            Admin_Bar_User.UseVisualStyleBackColor = true;
            Admin_Bar_User.Click += Admin_Bar_User_Click;
            // 
            // Menu_Cart
            // 
            Menu_Cart.AutoSize = true;
            Menu_Cart.Location = new Point(682, 88);
            Menu_Cart.Name = "Menu_Cart";
            Menu_Cart.Size = new Size(29, 15);
            Menu_Cart.TabIndex = 21;
            Menu_Cart.Text = "Cart";
            // 
            // Menu_logout
            // 
            Menu_logout.AutoSize = true;
            Menu_logout.Location = new Point(62, 97);
            Menu_logout.Name = "Menu_logout";
            Menu_logout.Size = new Size(53, 15);
            Menu_logout.TabIndex = 22;
            Menu_logout.Text = "Log out?";
            // 
            // MyAccountReg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Menu_logout);
            Controls.Add(Menu_Cart);
            Controls.Add(Admin_Bar);
            Controls.Add(label3);
            Controls.Add(txt_reg_phone);
            Controls.Add(label2);
            Controls.Add(btn_sign_up);
            Controls.Add(txt_reg_password);
            Controls.Add(txt_reg_username);
            Controls.Add(label1);
            Controls.Add(btn_sign_in);
            Controls.Add(txt_sign_in_password);
            Controls.Add(txt_sign_in_username);
            Name = "MyAccountReg";
            Text = "Form2";
            Admin_Bar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txt_reg_phone;
        private Label label2;
        private Button btn_sign_up;
        private TextBox txt_reg_password;
        private TextBox txt_reg_username;
        private Label label1;
        private Button btn_sign_in;
        private TextBox txt_sign_in_password;
        private TextBox txt_sign_in_username;
        private GroupBox Admin_Bar;
        private Button Admin_Bar_User;
        private Label Menu_Cart;
        private Label Menu_logout;
    }
}
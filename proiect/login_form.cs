using System;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace proiect
{
    public partial class login_form : Form
    {
        new_client_form new_client;
        home_page_form home_page;
        database_ops db_operations;

        public login_form()
        {
            db_operations = new database_ops();
            InitializeComponent();

            // logo image
            logo_pictureBox.Image = Image.FromFile(@"C:\Users\Mihaela\Desktop\II - Industrial Informatics\proiect\logo.jpg");

            logo_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // background image for the form
            Image myimage = new Bitmap(@"C:\Users\Mihaela\Desktop\II - Industrial Informatics\proiect\background.png");

            this.BackgroundImage = myimage;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // check data in the database operations
            // get_client_data(user_tb.Text, password_tb.Text)
            // if that is null message box no such account

            DataSet users = db_operations.get_users();

            foreach (DataRow dr in users.Tables["client"].Rows)
            {
                if (dr.ItemArray.GetValue(4).ToString().Equals(username_tb.Text))
                {
                    byte[] hash;
                    using (HashAlgorithm algorithm = SHA256.Create())
                        hash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(password_tb.Text));

                    StringBuilder hashed_passwd = new StringBuilder();
                    foreach (byte b in hash)
                        hashed_passwd.Append(b.ToString("X2"));

                    // check password
                    if (dr.ItemArray.GetValue(5).ToString().Equals(hashed_passwd.ToString()))
                    {
                        home_page = new home_page_form(db_operations, dr, this);
                        this.Hide();
                        home_page.Show();
                        return ;
                    }
                    else
                    {
                        MessageBox.Show("Wrong password!");
                        return ;
                    }
                }
            }

            MessageBox.Show("No such username!");
        }

        private void new_client_btn_Click(object sender, EventArgs e)
        {
            new_client = new new_client_form(this, db_operations);
            this.Hide();
            new_client.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

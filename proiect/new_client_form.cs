using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace proiect
{
    public partial class new_client_form : Form
    {
        login_form login;
        database_ops db_operations;

        public new_client_form(login_form login, database_ops db_operations)
        {
            InitializeComponent();
            this.db_operations = db_operations;
            this.login = login;

            // background image for the form
            Image myimage = new Bitmap(@"C:\Users\Mihaela\Desktop\II - Industrial Informatics\proiect\background.png");

            this.BackgroundImage = myimage;
        }

        public void new_acc_btn_Click(object sender, EventArgs e)
        {
            // we check if the fields are empty to not add the guy
            if (String.IsNullOrEmpty(nume_tb.Text) || string.IsNullOrEmpty(prenume_tb.Text) || string.IsNullOrEmpty(cnp_tb.Text) || string.IsNullOrEmpty(user_tb.Text) || string.IsNullOrEmpty(password_tb.Text) || string.IsNullOrEmpty(telefon_tb.Text) || string.IsNullOrEmpty(adresa_tb.Text))
            {
                // we color the empty textboxes red and back to white if only some of them are filled
                foreach (Control txtbxs in this.Controls)
                {
                    if (txtbxs is TextBox)
                    {
                        var TBox = (TextBox)txtbxs;
                        if (TBox.Text == string.Empty)
                        {
                            TBox.BackColor = Color.LightCoral;
                        }
                        if (TBox.Modified)
                        {
                            TBox.BackColor = Color.White;
                        }
                    }
                }
                MessageBox.Show("You must fill all the fields before creating the account!");
            }
            // if the value for the first name has not only letters
            else if (!Regex.IsMatch(prenume_tb.Text, @"^[a-zA-Z]+$"))
            {
                color_update();
                prenume_tb.BackColor = Color.LightCoral;
                MessageBox.Show("Invalid First Name!");
            }
            // if the value for the last name has not only letters
            else if (!Regex.IsMatch(nume_tb.Text, @"^[a-zA-Z]+$"))
            {
                color_update();
                nume_tb.BackColor = Color.LightCoral;
                MessageBox.Show("Invalid Last Name!");
            }
            // if the value for the CNP is not numeric or doesn't have length 13 
            else if (!Int64.TryParse(cnp_tb.Text, out long value) || cnp_tb.Text.Length != 13)
            {
                color_update();
                cnp_tb.BackColor = Color.LightCoral;
                MessageBox.Show("Invalid CNP!");
            }
            // if the value for the phone number is not numeric
            else if (!Int32.TryParse(telefon_tb.Text, out int value2))
            {
                color_update();
                telefon_tb.BackColor = Color.LightCoral;
                MessageBox.Show("Invalid phone number!");
            }
            // if everything is right
            else 
            {
                color_update();
                db_operations.add_client(nume_tb.Text, prenume_tb.Text, cnp_tb.Text, user_tb.Text, password_tb.Text, telefon_tb.Text, adresa_tb.Text);
                MessageBox.Show("Account created successfully!");
            }

        }

        public void color_update()
        {
            // we color all the further filled textboxes back to white 
            foreach (Control txtbxs in this.Controls)
            {
                if (txtbxs is TextBox)
                {
                    var TBox = (TextBox)txtbxs;
                    if (TBox.Modified)
                    {
                        TBox.BackColor = Color.White;
                    }
                }
            }
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

        private void login_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }
    }
}

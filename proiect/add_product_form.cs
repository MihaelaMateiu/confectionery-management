using System;
using System.Drawing;
using System.Windows.Forms;

namespace proiect
{
    public partial class add_product_form : Form
    {
        home_page_form home_page;
        database_ops db_operations;
        public add_product_form(home_page_form home_page, database_ops db_operations)
        {
            InitializeComponent();
            this.home_page = home_page;
            this.db_operations = db_operations;

            // background image for the form
            Image myimage = new Bitmap(@"C:\Users\Mihaela\Desktop\II - Industrial Informatics\proiect\background.png");
            this.BackgroundImage = myimage;
        }

        private void add_product_btn_Click(object sender, EventArgs e)
        {
            string product_type;
            //db_operations.add_product(nume_tb.Text, int.Parse(pret_tb.Text), product_type_tb.Text, link_poza_tb.Text);

            //if (product_type_tb.Text == "cake")
            if (cake_rb.Checked)
            {
                product_type = cake_rb.Text;
            }
            //else if (product_type_tb.Text == "cookie")
            else if (cookie_rb.Checked)
            {
                product_type = cookie_rb.Text;
            }
            //else if (product_type_tb.Text == "ice cream")
            else //if (ice_cream_rb.Checked)
            {
                product_type = ice_cream_rb.Text;
            }

            db_operations.add_product(nume_tb.Text, int.Parse(pret_tb.Text), product_type, link_poza_tb.Text);
            home_page.update_cakes_list();
            home_page.update_cookies_list();
            home_page.update_ice_cream_list();

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            home_page.Show();
            this.Hide();
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
    }
}

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace proiect
{
    public partial class client_orders_form : Form
    {
        home_page_form home_page;
        DataRow client_data;
        DataSet orders;
        public client_orders_form(home_page_form home_page, DataRow client_data)
        {
            InitializeComponent();

            this.home_page = home_page;
            this.client_data = client_data;
            update_list();

            // background image for the form
            Image myimage = new Bitmap(@"C:\Users\Mihaela\Desktop\II - Industrial Informatics\proiect\background.png");

            this.BackgroundImage = myimage;
        }

        public void update_list()
        {
            orders = home_page.db_operations.get_orders_by_id(int.Parse(client_data.ItemArray.GetValue(0).ToString()));
            foreach (DataRow dr in orders.Tables[0].Rows)
            {
                // MessageBox.Show("there is something here");
                string name = "Command Id: " + dr.ItemArray.GetValue(0).ToString() + ";     Product Id: " + dr.ItemArray.GetValue(1).ToString() +
                     ";     Product Name: " + dr.ItemArray.GetValue(3).ToString() +
                     ";     Product Type: " + dr.ItemArray.GetValue(4).ToString() + ";     Order State: " + dr.ItemArray.GetValue(8).ToString();

                client_orders_listbox.Items.Add(name);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            home_page.Show();
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

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace proiect
{
    public partial class new_order_form : Form
    {

        DataRow user_data;
        database_ops db_operations;
        home_page_form home_page;
        DataRow selected_cake;

        public new_order_form(DataRow user_data, database_ops db_operations, home_page_form home_page, DataRow selected_cake)
        {
            InitializeComponent();
            this.user_data = user_data;
            this.db_operations = db_operations;
            this.home_page = home_page;
            this.selected_cake = selected_cake;

            // background image for the form
            Image myimage = new Bitmap(@"C:\Users\Mihaela\Desktop\II - Industrial Informatics\proiect\background.png");
            this.BackgroundImage = myimage;

            adresa_tb.Text = user_data.ItemArray.GetValue(7).ToString();
            prod_data_label.Text = selected_cake.ItemArray.GetValue(1).ToString() + "   for  "  +selected_cake.ItemArray.GetValue(2).ToString() + "  ron";
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            db_operations.add_order(int.Parse(selected_cake.ItemArray.GetValue(0).ToString()), int.Parse(user_data.ItemArray.GetValue(0).ToString()));
            home_page.all_orders_form.update_list();
            MessageBox.Show("Your order was placed successfully!");
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

        private void back_btn_Click(object sender, EventArgs e)
        {
            home_page.Show();
            this.Hide();
        }
    }
}

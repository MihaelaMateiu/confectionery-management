using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace proiect
{
    public partial class orders_form : Form
    {
        Form home_page;
        database_ops db_operations;
        DataSet orders;
        DataRow selected_row;
        public orders_form(Form home_page, database_ops db_operations)
        {
            InitializeComponent();
            this.home_page = home_page;
            this.db_operations = db_operations;

            // background image for the form
            Image myimage = new Bitmap(@"C:\Users\Mihaela\Desktop\II - Industrial Informatics\proiect\background.png");
            this.BackgroundImage = myimage;

            update_list();
        }

        public void update_list()
        {
            
            orders = db_operations.get_orders();

            orders_listbox.Items.Clear();

           // MessageBox.Show(orders.ToString());
            foreach (DataRow dr in orders.Tables[0].Rows)
            {
                string name = "Command Id: " + dr.ItemArray.GetValue(0).ToString() + ";     Product Id: " + dr.ItemArray.GetValue(1).ToString() +
                    ";     Client Id: " + dr.ItemArray.GetValue(2).ToString() + ";     Product Name: " + dr.ItemArray.GetValue(3).ToString() +
                    ";     Product Price: " + dr.ItemArray.GetValue(4).ToString() + ";     Client Name: " + dr.ItemArray.GetValue(6).ToString() +
                    ";     Client Address: " + dr.ItemArray.GetValue(7).ToString();
                orders_listbox.Items.Add(name);
            }
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

        private void delivered_btn_Click(object sender, EventArgs e)
        {
            db_operations.deliver_order(int.Parse(selected_row.ItemArray.GetValue(0).ToString()));
            MessageBox.Show("Delivered :  " + int.Parse(selected_row.ItemArray.GetValue(0).ToString()));
        }

        private void orders_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow dr in orders.Tables[0].Rows)
            {   
                string name = "Command Id: " + dr.ItemArray.GetValue(0).ToString() + ";     Product Id: " + dr.ItemArray.GetValue(1).ToString() +
                    ";     Client Id: " + dr.ItemArray.GetValue(2).ToString() + ";     Product Name: " + dr.ItemArray.GetValue(3).ToString() +
                    ";     Product Price: " + dr.ItemArray.GetValue(4).ToString() + ";     Client Name: " + dr.ItemArray.GetValue(6).ToString() + 
                    ";     Client Address: " + dr.ItemArray.GetValue(7).ToString();
                

                if (name.Equals(orders_listbox.SelectedItem.ToString()))
                    selected_row = dr;
            }
        }
    }
}

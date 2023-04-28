using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace proiect
{
    public partial class home_page_form : Form
    {
        add_product_form add_prod_form;
        login_form login;
        public orders_form all_orders_form;
        new_order_form new_order;
        public database_ops db_operations;
        DataSet products;
        DataRow user_data;
        DataRow selected_cake;
        client_orders_form client_orders;

        public home_page_form(database_ops db_operations, DataRow user_data, login_form login)
        {
            InitializeComponent();
            this.db_operations = db_operations;
            this.user_data = user_data;
            this.login = login;

            // background image for the form
            Image myimage = new Bitmap(@"C:\Users\Mihaela\Desktop\II - Industrial Informatics\proiect\background.png");
            this.BackgroundImage = myimage;

            add_prod_form = new add_product_form(this, db_operations);
            all_orders_form = new orders_form(this, db_operations);

            // check and make the add product visible only for admins
            add_product_btn.Visible = false;
            orders_btn.Visible = false;
            if (user_data.ItemArray.GetValue(8).ToString().Equals("yes"))
            {
                add_product_btn.Visible = true;
                orders_btn.Visible = true;
            }

            update_cakes_list();
            update_cookies_list();
            update_ice_cream_list();
        }

        public void update_cakes_list()
        {
            products = db_operations.get_products();

            cakes_listbox.Items.Clear();
            foreach (DataRow dr in products.Tables["produs"].Rows)
            {
                string name = /*"Id " + dr.ItemArray.GetValue(0).ToString() + ": " +*/ dr.ItemArray.GetValue(1).ToString() + "   for   " + dr.ItemArray.GetValue(2).ToString() + "  ron";
                if (dr.ItemArray.GetValue(3).ToString() == "cake")
                {
                    cakes_listbox.Items.Add(name);
                }
            }
        }
        public void update_cookies_list()
        {
            products = db_operations.get_products();

            cookies_listbox.Items.Clear();
            foreach (DataRow dr in products.Tables["produs"].Rows)
            {
                string name = /*"Id " + dr.ItemArray.GetValue(0).ToString() + ": " +*/ dr.ItemArray.GetValue(1).ToString() + "   for   " + dr.ItemArray.GetValue(2).ToString() + "  ron";
                if (dr.ItemArray.GetValue(3).ToString() == "cookie")
                {
                    cookies_listbox.Items.Add(name);
                }
            }
        }

        public void update_ice_cream_list()
        {
            products = db_operations.get_products();

            ice_cream_listbox.Items.Clear();
            foreach (DataRow dr in products.Tables["produs"].Rows)
            {
                string name = /*"Id " + dr.ItemArray.GetValue(0).ToString() + ": " + */ dr.ItemArray.GetValue(1).ToString() + "   for   " + dr.ItemArray.GetValue(2).ToString() + "  ron";

                if (dr.ItemArray.GetValue(3).ToString() == "ice cream")
                {
                    ice_cream_listbox.Items.Add(name);
                }
            }
        }

        private void add_product_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_prod_form.Show();
        }
            
        private void comanda_btn_Click(object sender, EventArgs e)
        {
            new_order = new new_order_form(user_data, db_operations, this, selected_cake); 
            this.Hide();
            new_order.Show();
        }

        private void orders_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            all_orders_form.Show();

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if( e.CloseReason == CloseReason.UserClosing )
                Application.Exit();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if ( e.CloseReason == CloseReason.UserClosing )
                Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }

        private void client_orders_btn_Click(object sender, EventArgs e)
        {
            client_orders = new client_orders_form(this, user_data);
            client_orders.Show();
            this.Hide();
        }

        private void cookies_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow dr in products.Tables["produs"].Rows)
            {

                string name = dr.ItemArray.GetValue(1).ToString() + "   for   " + dr.ItemArray.GetValue(2).ToString() + "  ron";

                if (name.Equals(cookies_listbox.SelectedItem.ToString())) 
                {
                    selected_cake = dr;

                    if (dr.ItemArray.GetValue(4).ToString().Equals("-") || dr.ItemArray.GetValue(4).ToString().Equals("") ||
                        dr.ItemArray.GetValue(4).ToString() == null)
                    {
                        MessageBox.Show("There is no picture!");
                    }
                    else
                    {
                        try
                        {
                            product_photo_pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            product_photo_pb.Image = Image.FromFile("../../" + dr.ItemArray.GetValue(4).ToString());
                        }
                        catch
                        {

                        }
                        return;
                    }
                }
            }

        }

        private void ice_cream_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow dr in products.Tables["produs"].Rows)
            {

                string name = dr.ItemArray.GetValue(1).ToString() + "   for   " + dr.ItemArray.GetValue(2).ToString() + "  ron";

                if (name.Equals(ice_cream_listbox.SelectedItem.ToString())) 
                {
                    selected_cake = dr;

                    if (dr.ItemArray.GetValue(4).ToString().Equals("-") || dr.ItemArray.GetValue(4).ToString().Equals("") ||
                        dr.ItemArray.GetValue(4).ToString() == null)
                    {
                        MessageBox.Show("There is no picture!");
                    }
                    else
                    {
                        try
                        {
                            product_photo_pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            product_photo_pb.Image = Image.FromFile("../../" + dr.ItemArray.GetValue(4).ToString());
                        }
                        catch
                        {

                        }
                        return;
                    }
                }
            }
        }

        private void cakes_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
                // changing the selected should change the photo inside the picture box
                foreach (DataRow dr in products.Tables["produs"].Rows)
                {

                    string name = dr.ItemArray.GetValue(1).ToString() + "   for   " + dr.ItemArray.GetValue(2).ToString() + "  ron";

                    if (name.Equals(cakes_listbox.SelectedItem.ToString()))
                    {
                        selected_cake = dr;

                        if (dr.ItemArray.GetValue(4).ToString().Equals("-") || dr.ItemArray.GetValue(4).ToString().Equals("") ||
                            dr.ItemArray.GetValue(4).ToString() == null)
                        {
                            MessageBox.Show("There is no picture!");
                        }
                        else
                        {
                            // update picture box
                            try
                            {
                                // scale images somehow
                                product_photo_pb.SizeMode = PictureBoxSizeMode.StretchImage;
                                product_photo_pb.Image = Image.FromFile("../../" + dr.ItemArray.GetValue(4).ToString());
                            }
                            catch
                            {

                            }
                            return;
                        }
                    }
                }
        }

    }
}

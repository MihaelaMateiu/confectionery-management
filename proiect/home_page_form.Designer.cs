
namespace proiect
{
    partial class home_page_form
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
            this.cakes_listbox = new System.Windows.Forms.ListBox();
            this.product_photo_pb = new System.Windows.Forms.PictureBox();
            this.comanda_btn = new System.Windows.Forms.Button();
            this.add_product_btn = new System.Windows.Forms.Button();
            this.orders_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.client_orders_btn = new System.Windows.Forms.Button();
            this.cookies_listbox = new System.Windows.Forms.ListBox();
            this.ice_cream_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.product_photo_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // cakes_listbox
            // 
            this.cakes_listbox.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakes_listbox.FormattingEnabled = true;
            this.cakes_listbox.ItemHeight = 18;
            this.cakes_listbox.Location = new System.Drawing.Point(31, 77);
            this.cakes_listbox.Margin = new System.Windows.Forms.Padding(4);
            this.cakes_listbox.Name = "cakes_listbox";
            this.cakes_listbox.Size = new System.Drawing.Size(289, 130);
            this.cakes_listbox.TabIndex = 0;
            this.cakes_listbox.SelectedIndexChanged += new System.EventHandler(this.cakes_listbox_SelectedIndexChanged);
            // 
            // product_photo_pb
            // 
            this.product_photo_pb.BackColor = System.Drawing.Color.White;
            this.product_photo_pb.Location = new System.Drawing.Point(340, 234);
            this.product_photo_pb.Margin = new System.Windows.Forms.Padding(4);
            this.product_photo_pb.Name = "product_photo_pb";
            this.product_photo_pb.Size = new System.Drawing.Size(335, 379);
            this.product_photo_pb.TabIndex = 1;
            this.product_photo_pb.TabStop = false;
            // 
            // comanda_btn
            // 
            this.comanda_btn.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comanda_btn.Location = new System.Drawing.Point(73, 373);
            this.comanda_btn.Margin = new System.Windows.Forms.Padding(4);
            this.comanda_btn.Name = "comanda_btn";
            this.comanda_btn.Size = new System.Drawing.Size(163, 32);
            this.comanda_btn.TabIndex = 2;
            this.comanda_btn.Text = "Place order";
            this.comanda_btn.UseVisualStyleBackColor = true;
            this.comanda_btn.Click += new System.EventHandler(this.comanda_btn_Click);
            // 
            // add_product_btn
            // 
            this.add_product_btn.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product_btn.Location = new System.Drawing.Point(776, 373);
            this.add_product_btn.Margin = new System.Windows.Forms.Padding(4);
            this.add_product_btn.Name = "add_product_btn";
            this.add_product_btn.Size = new System.Drawing.Size(163, 32);
            this.add_product_btn.TabIndex = 3;
            this.add_product_btn.Text = "Add product";
            this.add_product_btn.UseVisualStyleBackColor = true;
            this.add_product_btn.Click += new System.EventHandler(this.add_product_Click);
            // 
            // orders_btn
            // 
            this.orders_btn.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_btn.Location = new System.Drawing.Point(776, 447);
            this.orders_btn.Margin = new System.Windows.Forms.Padding(4);
            this.orders_btn.Name = "orders_btn";
            this.orders_btn.Size = new System.Drawing.Size(163, 32);
            this.orders_btn.TabIndex = 4;
            this.orders_btn.Text = "Show all orders";
            this.orders_btn.UseVisualStyleBackColor = true;
            this.orders_btn.Click += new System.EventHandler(this.orders_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.Location = new System.Drawing.Point(454, 644);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(112, 32);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // client_orders_btn
            // 
            this.client_orders_btn.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_orders_btn.Location = new System.Drawing.Point(73, 447);
            this.client_orders_btn.Margin = new System.Windows.Forms.Padding(4);
            this.client_orders_btn.Name = "client_orders_btn";
            this.client_orders_btn.Size = new System.Drawing.Size(163, 32);
            this.client_orders_btn.TabIndex = 6;
            this.client_orders_btn.Text = "Show my orders";
            this.client_orders_btn.UseVisualStyleBackColor = true;
            this.client_orders_btn.Click += new System.EventHandler(this.client_orders_btn_Click);
            // 
            // cookies_listbox
            // 
            this.cookies_listbox.FormattingEnabled = true;
            this.cookies_listbox.ItemHeight = 18;
            this.cookies_listbox.Location = new System.Drawing.Point(364, 77);
            this.cookies_listbox.Margin = new System.Windows.Forms.Padding(4);
            this.cookies_listbox.Name = "cookies_listbox";
            this.cookies_listbox.Size = new System.Drawing.Size(289, 130);
            this.cookies_listbox.TabIndex = 7;
            this.cookies_listbox.SelectedIndexChanged += new System.EventHandler(this.cookies_listbox_SelectedIndexChanged);
            // 
            // ice_cream_listbox
            // 
            this.ice_cream_listbox.FormattingEnabled = true;
            this.ice_cream_listbox.ItemHeight = 18;
            this.ice_cream_listbox.Location = new System.Drawing.Point(699, 77);
            this.ice_cream_listbox.Margin = new System.Windows.Forms.Padding(4);
            this.ice_cream_listbox.Name = "ice_cream_listbox";
            this.ice_cream_listbox.Size = new System.Drawing.Size(289, 130);
            this.ice_cream_listbox.TabIndex = 8;
            this.ice_cream_listbox.SelectedIndexChanged += new System.EventHandler(this.ice_cream_listbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cakes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cookies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(782, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ice Cream";
            // 
            // home_page_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 710);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ice_cream_listbox);
            this.Controls.Add(this.cookies_listbox);
            this.Controls.Add(this.client_orders_btn);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.orders_btn);
            this.Controls.Add(this.add_product_btn);
            this.Controls.Add(this.comanda_btn);
            this.Controls.Add(this.product_photo_pb);
            this.Controls.Add(this.cakes_listbox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "home_page_form";
            this.ShowIcon = false;
            this.Text = "Home Page";
            ((System.ComponentModel.ISupportInitialize)(this.product_photo_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cakes_listbox;
        private System.Windows.Forms.PictureBox product_photo_pb;
        private System.Windows.Forms.Button comanda_btn;
        private System.Windows.Forms.Button add_product_btn;
        private System.Windows.Forms.Button orders_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button client_orders_btn;
        private System.Windows.Forms.ListBox cookies_listbox;
        private System.Windows.Forms.ListBox ice_cream_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
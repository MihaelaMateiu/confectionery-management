
namespace proiect
{
    partial class client_orders_form
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
            this.client_orders_listbox = new System.Windows.Forms.ListBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // client_orders_listbox
            // 
            this.client_orders_listbox.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_orders_listbox.FormattingEnabled = true;
            this.client_orders_listbox.ItemHeight = 21;
            this.client_orders_listbox.Location = new System.Drawing.Point(94, 58);
            this.client_orders_listbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.client_orders_listbox.Name = "client_orders_listbox";
            this.client_orders_listbox.Size = new System.Drawing.Size(1001, 235);
            this.client_orders_listbox.TabIndex = 0;
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(911, 468);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(184, 63);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Go Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // client_orders_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1201, 623);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.client_orders_listbox);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "client_orders_form";
            this.ShowIcon = false;
            this.Text = "My Orders";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox client_orders_listbox;
        private System.Windows.Forms.Button back_btn;
    }
}
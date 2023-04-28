
namespace proiect
{
    partial class orders_form
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
            this.orders_listbox = new System.Windows.Forms.ListBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.delivered_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orders_listbox
            // 
            this.orders_listbox.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_listbox.FormattingEnabled = true;
            this.orders_listbox.ItemHeight = 21;
            this.orders_listbox.Location = new System.Drawing.Point(59, 87);
            this.orders_listbox.Margin = new System.Windows.Forms.Padding(4);
            this.orders_listbox.Name = "orders_listbox";
            this.orders_listbox.Size = new System.Drawing.Size(1012, 193);
            this.orders_listbox.TabIndex = 0;
            this.orders_listbox.SelectedIndexChanged += new System.EventHandler(this.orders_listbox_SelectedIndexChanged);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(920, 525);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(151, 49);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Go Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // delivered_btn
            // 
            this.delivered_btn.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivered_btn.Location = new System.Drawing.Point(59, 355);
            this.delivered_btn.Margin = new System.Windows.Forms.Padding(4);
            this.delivered_btn.Name = "delivered_btn";
            this.delivered_btn.Size = new System.Drawing.Size(184, 62);
            this.delivered_btn.TabIndex = 2;
            this.delivered_btn.Text = "Deliver Order";
            this.delivered_btn.UseVisualStyleBackColor = true;
            this.delivered_btn.Click += new System.EventHandler(this.delivered_btn_Click);
            // 
            // orders_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1152, 658);
            this.Controls.Add(this.delivered_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.orders_listbox);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "orders_form";
            this.ShowIcon = false;
            this.Text = "All Orders";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox orders_listbox;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button delivered_btn;
    }
}
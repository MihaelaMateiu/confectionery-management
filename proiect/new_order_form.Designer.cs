
namespace proiect
{
    partial class new_order_form
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
            this.confirm_btn = new System.Windows.Forms.Button();
            this.adresa_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prod_data_label = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirm_btn
            // 
            this.confirm_btn.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.Location = new System.Drawing.Point(137, 525);
            this.confirm_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(146, 44);
            this.confirm_btn.TabIndex = 0;
            this.confirm_btn.Text = "Confirm Order";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // adresa_tb
            // 
            this.adresa_tb.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresa_tb.Location = new System.Drawing.Point(138, 182);
            this.adresa_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adresa_tb.Multiline = true;
            this.adresa_tb.Name = "adresa_tb";
            this.adresa_tb.Size = new System.Drawing.Size(403, 72);
            this.adresa_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter your current address:";
            // 
            // prod_data_label
            // 
            this.prod_data_label.AutoSize = true;
            this.prod_data_label.BackColor = System.Drawing.Color.Transparent;
            this.prod_data_label.Location = new System.Drawing.Point(321, 368);
            this.prod_data_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prod_data_label.Name = "prod_data_label";
            this.prod_data_label.Size = new System.Drawing.Size(156, 19);
            this.prod_data_label.TabIndex = 3;
            this.prod_data_label.Text = "nume produs + pret";
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(855, 525);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(146, 44);
            this.back_btn.TabIndex = 4;
            this.back_btn.Text = "Go Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 367);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your order contains: ";
            // 
            // new_order_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.prod_data_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adresa_tb);
            this.Controls.Add(this.confirm_btn);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "new_order_form";
            this.ShowIcon = false;
            this.Text = "New Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.TextBox adresa_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label prod_data_label;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label2;
    }
}
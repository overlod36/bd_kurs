
namespace kurs
{
    partial class customer_delete
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
            this.id_customer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.del_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id_customer
            // 
            this.id_customer.Location = new System.Drawing.Point(196, 122);
            this.id_customer.Name = "id_customer";
            this.id_customer.Size = new System.Drawing.Size(100, 22);
            this.id_customer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID покупателя";
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(158, 171);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(84, 31);
            this.del_button.TabIndex = 2;
            this.del_button.Text = "Удаление";
            this.del_button.UseVisualStyleBackColor = true;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Удаление информации о покупателях";
            // 
            // customer_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 318);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_customer);
            this.Name = "customer_delete";
            this.Text = "customer_delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Label label2;
    }
}
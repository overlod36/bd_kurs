
namespace kurs
{
    partial class order_creater
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
            this.ID_seller = new System.Windows.Forms.TextBox();
            this.ID_customer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.order_status = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID_seller
            // 
            this.ID_seller.Location = new System.Drawing.Point(144, 107);
            this.ID_seller.Name = "ID_seller";
            this.ID_seller.Size = new System.Drawing.Size(191, 22);
            this.ID_seller.TabIndex = 1;
            // 
            // ID_customer
            // 
            this.ID_customer.Location = new System.Drawing.Point(144, 164);
            this.ID_customer.Name = "ID_customer";
            this.ID_customer.Size = new System.Drawing.Size(191, 22);
            this.ID_customer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Статус заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID продавца";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID покупателя";
            // 
            // order_status
            // 
            this.order_status.FormattingEnabled = true;
            this.order_status.Items.AddRange(new object[] {
            "Собирается",
            "Готов"});
            this.order_status.Location = new System.Drawing.Point(155, 53);
            this.order_status.Name = "order_status";
            this.order_status.Size = new System.Drawing.Size(180, 24);
            this.order_status.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.order_status);
            this.groupBox1.Controls.Add(this.ID_seller);
            this.groupBox1.Controls.Add(this.ID_customer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(43, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 221);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Форма для заполнения";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(178, 338);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(103, 35);
            this.add_button.TabIndex = 11;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // order_creater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.groupBox1);
            this.Name = "order_creater";
            this.Text = "order_creater";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ID_seller;
        private System.Windows.Forms.TextBox ID_customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox order_status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button add_button;
    }
}
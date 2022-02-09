
namespace kurs
{
    partial class customers_creater
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
            this.mail_customer = new System.Windows.Forms.TextBox();
            this.card_customer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refresh_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_customer
            // 
            this.id_customer.Location = new System.Drawing.Point(191, 69);
            this.id_customer.Name = "id_customer";
            this.id_customer.Size = new System.Drawing.Size(127, 22);
            this.id_customer.TabIndex = 0;
            // 
            // mail_customer
            // 
            this.mail_customer.Location = new System.Drawing.Point(191, 129);
            this.mail_customer.Name = "mail_customer";
            this.mail_customer.Size = new System.Drawing.Size(160, 22);
            this.mail_customer.TabIndex = 1;
            // 
            // card_customer
            // 
            this.card_customer.Location = new System.Drawing.Point(191, 188);
            this.card_customer.Name = "card_customer";
            this.card_customer.Size = new System.Drawing.Size(137, 22);
            this.card_customer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID покупателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер карты";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.refresh_button);
            this.groupBox1.Controls.Add(this.add_button);
            this.groupBox1.Controls.Add(this.id_customer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mail_customer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.card_customer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 358);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Покупатели";
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(32, 258);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(160, 47);
            this.refresh_button.TabIndex = 7;
            this.refresh_button.Text = "Очистка полей";
            this.refresh_button.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(241, 258);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(122, 47);
            this.add_button.TabIndex = 6;
            this.add_button.Text = "Добавление";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // customers_creater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 379);
            this.Controls.Add(this.groupBox1);
            this.Name = "customers_creater";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox id_customer;
        private System.Windows.Forms.TextBox mail_customer;
        private System.Windows.Forms.TextBox card_customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button add_button;
    }
}
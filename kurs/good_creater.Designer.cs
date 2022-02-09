
namespace kurs
{
    partial class good_creater
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
            this.good_id = new System.Windows.Forms.TextBox();
            this.good_price = new System.Windows.Forms.TextBox();
            this.good_brand = new System.Windows.Forms.ComboBox();
            this.good_type = new System.Windows.Forms.ComboBox();
            this.good_model = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // good_id
            // 
            this.good_id.Location = new System.Drawing.Point(195, 116);
            this.good_id.Name = "good_id";
            this.good_id.Size = new System.Drawing.Size(229, 22);
            this.good_id.TabIndex = 0;
            // 
            // good_price
            // 
            this.good_price.Location = new System.Drawing.Point(194, 158);
            this.good_price.Name = "good_price";
            this.good_price.Size = new System.Drawing.Size(229, 22);
            this.good_price.TabIndex = 1;
            // 
            // good_brand
            // 
            this.good_brand.FormattingEnabled = true;
            this.good_brand.Location = new System.Drawing.Point(194, 203);
            this.good_brand.Name = "good_brand";
            this.good_brand.Size = new System.Drawing.Size(230, 24);
            this.good_brand.TabIndex = 2;
            // 
            // good_type
            // 
            this.good_type.FormattingEnabled = true;
            this.good_type.Items.AddRange(new object[] {
            "Гитара",
            "Усилитель",
            "Педаль"});
            this.good_type.Location = new System.Drawing.Point(194, 246);
            this.good_type.Name = "good_type";
            this.good_type.Size = new System.Drawing.Size(229, 24);
            this.good_type.TabIndex = 3;
            // 
            // good_model
            // 
            this.good_model.Location = new System.Drawing.Point(203, 292);
            this.good_model.Name = "good_model";
            this.good_model.Size = new System.Drawing.Size(219, 22);
            this.good_model.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Цена товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Бренд товара";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тип товара";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Модель товара";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавление";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Добавление товаров";
            // 
            // good_creater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.good_model);
            this.Controls.Add(this.good_type);
            this.Controls.Add(this.good_brand);
            this.Controls.Add(this.good_price);
            this.Controls.Add(this.good_id);
            this.Name = "good_creater";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox good_id;
        private System.Windows.Forms.TextBox good_price;
        private System.Windows.Forms.ComboBox good_brand;
        private System.Windows.Forms.ComboBox good_type;
        private System.Windows.Forms.TextBox good_model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}
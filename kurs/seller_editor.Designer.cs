
namespace kurs
{
    partial class seller_editor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.first_seller_name = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.second_name_seller = new System.Windows.Forms.TextBox();
            this.position_seller = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seller_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.search_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.first_seller_name);
            this.groupBox1.Controls.Add(this.add_button);
            this.groupBox1.Controls.Add(this.second_name_seller);
            this.groupBox1.Controls.Add(this.position_seller);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 247);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Продавцы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Имя продавца";
            // 
            // first_seller_name
            // 
            this.first_seller_name.Enabled = false;
            this.first_seller_name.Location = new System.Drawing.Point(200, 86);
            this.first_seller_name.Name = "first_seller_name";
            this.first_seller_name.Size = new System.Drawing.Size(163, 22);
            this.first_seller_name.TabIndex = 8;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(173, 168);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(126, 53);
            this.add_button.TabIndex = 6;
            this.add_button.Text = "Редактирование";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // second_name_seller
            // 
            this.second_name_seller.Enabled = false;
            this.second_name_seller.Location = new System.Drawing.Point(200, 46);
            this.second_name_seller.Name = "second_name_seller";
            this.second_name_seller.Size = new System.Drawing.Size(163, 22);
            this.second_name_seller.TabIndex = 4;
            // 
            // position_seller
            // 
            this.position_seller.Enabled = false;
            this.position_seller.FormattingEnabled = true;
            this.position_seller.Items.AddRange(new object[] {
            "Стажер",
            "Младший продавец",
            "Старший продавец"});
            this.position_seller.Location = new System.Drawing.Point(187, 125);
            this.position_seller.Name = "position_seller";
            this.position_seller.Size = new System.Drawing.Size(176, 24);
            this.position_seller.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия продавца";
            // 
            // seller_id
            // 
            this.seller_id.Location = new System.Drawing.Point(153, 26);
            this.seller_id.Name = "seller_id";
            this.seller_id.Size = new System.Drawing.Size(145, 22);
            this.seller_id.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID продавца";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.search_button);
            this.groupBox2.Controls.Add(this.seller_id);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 71);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск по ключу";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(351, 24);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 26);
            this.search_button.TabIndex = 6;
            this.search_button.Text = "Поиск";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // seller_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 349);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "seller_editor";
            this.Text = "seller_editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox first_seller_name;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox seller_id;
        private System.Windows.Forms.TextBox second_name_seller;
        private System.Windows.Forms.ComboBox position_seller;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button search_button;
    }
}

namespace kurs
{
    partial class good_editor
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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.good_model = new System.Windows.Forms.TextBox();
            this.good_brand = new System.Windows.Forms.ComboBox();
            this.good_price = new System.Windows.Forms.TextBox();
            this.good_id = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.good_type = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Модель товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Бренд товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Цена товара";
            // 
            // good_model
            // 
            this.good_model.Enabled = false;
            this.good_model.Location = new System.Drawing.Point(195, 121);
            this.good_model.Name = "good_model";
            this.good_model.Size = new System.Drawing.Size(230, 22);
            this.good_model.TabIndex = 16;
            // 
            // good_brand
            // 
            this.good_brand.Enabled = false;
            this.good_brand.FormattingEnabled = true;
            this.good_brand.Location = new System.Drawing.Point(195, 78);
            this.good_brand.Name = "good_brand";
            this.good_brand.Size = new System.Drawing.Size(230, 24);
            this.good_brand.TabIndex = 14;
            // 
            // good_price
            // 
            this.good_price.Enabled = false;
            this.good_price.Location = new System.Drawing.Point(196, 38);
            this.good_price.Name = "good_price";
            this.good_price.Size = new System.Drawing.Size(229, 22);
            this.good_price.TabIndex = 13;
            // 
            // good_id
            // 
            this.good_id.Location = new System.Drawing.Point(107, 52);
            this.good_id.Name = "good_id";
            this.good_id.Size = new System.Drawing.Size(229, 22);
            this.good_id.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.good_type);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.good_price);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.good_brand);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.good_model);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 289);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Товар";
            // 
            // good_type
            // 
            this.good_type.Enabled = false;
            this.good_type.Location = new System.Drawing.Point(195, 170);
            this.good_type.Name = "good_type";
            this.good_type.Size = new System.Drawing.Size(230, 22);
            this.good_type.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Тип товара";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.good_id);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 112);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск по ключу";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID товара";
            // 
            // good_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "good_editor";
            this.Text = "good_editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox good_model;
        private System.Windows.Forms.ComboBox good_brand;
        private System.Windows.Forms.TextBox good_price;
        private System.Windows.Forms.TextBox good_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox good_type;
        private System.Windows.Forms.Label label4;
    }
}

namespace kurs
{
    partial class guitar_editor
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
            this.guitar_orientation = new System.Windows.Forms.ComboBox();
            this.add_button = new System.Windows.Forms.Button();
            this.guitar_scale_length_box = new System.Windows.Forms.TextBox();
            this.number_of_guitar_frets_box = new System.Windows.Forms.TextBox();
            this.guitar_body_color_box = new System.Windows.Forms.TextBox();
            this.guitar_body_material_box = new System.Windows.Forms.TextBox();
            this.guitar_neck_material_box = new System.Windows.Forms.TextBox();
            this.number_of_guitar_string_box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guitar_model_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.search_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.guitar_orientation);
            this.groupBox1.Controls.Add(this.add_button);
            this.groupBox1.Controls.Add(this.guitar_scale_length_box);
            this.groupBox1.Controls.Add(this.number_of_guitar_frets_box);
            this.groupBox1.Controls.Add(this.guitar_body_color_box);
            this.groupBox1.Controls.Add(this.guitar_body_material_box);
            this.groupBox1.Controls.Add(this.guitar_neck_material_box);
            this.groupBox1.Controls.Add(this.number_of_guitar_string_box);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 357);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поля гитары";
            // 
            // guitar_orientation
            // 
            this.guitar_orientation.Enabled = false;
            this.guitar_orientation.FormattingEnabled = true;
            this.guitar_orientation.Items.AddRange(new object[] {
            "Правосторонняя",
            "Левосторонняя"});
            this.guitar_orientation.Location = new System.Drawing.Point(182, 156);
            this.guitar_orientation.Name = "guitar_orientation";
            this.guitar_orientation.Size = new System.Drawing.Size(207, 24);
            this.guitar_orientation.TabIndex = 19;
            // 
            // add_button
            // 
            this.add_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_button.Location = new System.Drawing.Point(172, 259);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(150, 54);
            this.add_button.TabIndex = 18;
            this.add_button.Text = "Редактировать";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // guitar_scale_length_box
            // 
            this.guitar_scale_length_box.Enabled = false;
            this.guitar_scale_length_box.Location = new System.Drawing.Point(210, 184);
            this.guitar_scale_length_box.Name = "guitar_scale_length_box";
            this.guitar_scale_length_box.Size = new System.Drawing.Size(102, 22);
            this.guitar_scale_length_box.TabIndex = 16;
            // 
            // number_of_guitar_frets_box
            // 
            this.number_of_guitar_frets_box.Enabled = false;
            this.number_of_guitar_frets_box.Location = new System.Drawing.Point(216, 130);
            this.number_of_guitar_frets_box.Name = "number_of_guitar_frets_box";
            this.number_of_guitar_frets_box.Size = new System.Drawing.Size(96, 22);
            this.number_of_guitar_frets_box.TabIndex = 14;
            // 
            // guitar_body_color_box
            // 
            this.guitar_body_color_box.Enabled = false;
            this.guitar_body_color_box.Location = new System.Drawing.Point(190, 102);
            this.guitar_body_color_box.Name = "guitar_body_color_box";
            this.guitar_body_color_box.Size = new System.Drawing.Size(265, 22);
            this.guitar_body_color_box.TabIndex = 13;
            // 
            // guitar_body_material_box
            // 
            this.guitar_body_material_box.Enabled = false;
            this.guitar_body_material_box.Location = new System.Drawing.Point(223, 76);
            this.guitar_body_material_box.Name = "guitar_body_material_box";
            this.guitar_body_material_box.Size = new System.Drawing.Size(232, 22);
            this.guitar_body_material_box.TabIndex = 12;
            // 
            // guitar_neck_material_box
            // 
            this.guitar_neck_material_box.Enabled = false;
            this.guitar_neck_material_box.Location = new System.Drawing.Point(209, 48);
            this.guitar_neck_material_box.Name = "guitar_neck_material_box";
            this.guitar_neck_material_box.Size = new System.Drawing.Size(246, 22);
            this.guitar_neck_material_box.TabIndex = 11;
            // 
            // number_of_guitar_string_box
            // 
            this.number_of_guitar_string_box.Enabled = false;
            this.number_of_guitar_string_box.Location = new System.Drawing.Point(216, 212);
            this.number_of_guitar_string_box.Name = "number_of_guitar_string_box";
            this.number_of_guitar_string_box.Size = new System.Drawing.Size(96, 22);
            this.number_of_guitar_string_box.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Количество струн гитары";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Длина мензуры гитары";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ориентация гитары";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество ладов гитары";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цвет корпуса гитары";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Материал корпуса гитары";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Материал грифа гитары";
            // 
            // guitar_model_box
            // 
            this.guitar_model_box.Location = new System.Drawing.Point(143, 32);
            this.guitar_model_box.Name = "guitar_model_box";
            this.guitar_model_box.Size = new System.Drawing.Size(112, 22);
            this.guitar_model_box.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Модель гитары";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.search_button);
            this.groupBox2.Controls.Add(this.guitar_model_box);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 84);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск по модели";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(294, 27);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(96, 32);
            this.search_button.TabIndex = 11;
            this.search_button.Text = "Поиск";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // guitar_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(506, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "guitar_editor";
            this.Text = "guitar_editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox guitar_orientation;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox guitar_scale_length_box;
        private System.Windows.Forms.TextBox number_of_guitar_frets_box;
        private System.Windows.Forms.TextBox guitar_body_color_box;
        private System.Windows.Forms.TextBox guitar_body_material_box;
        private System.Windows.Forms.TextBox guitar_neck_material_box;
        private System.Windows.Forms.TextBox guitar_model_box;
        private System.Windows.Forms.TextBox number_of_guitar_string_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button search_button;
    }
}
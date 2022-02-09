
namespace kurs
{
    partial class guitar_creater
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
            this.add_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.guitar_scale_length_box = new System.Windows.Forms.TextBox();
            this.number_of_guitar_frets_box = new System.Windows.Forms.TextBox();
            this.guitar_body_color_box = new System.Windows.Forms.TextBox();
            this.guitar_body_material_box = new System.Windows.Forms.TextBox();
            this.guitar_neck_material_box = new System.Windows.Forms.TextBox();
            this.guitar_model_box = new System.Windows.Forms.TextBox();
            this.number_of_guitar_string_box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.choose_image_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guitar_orientation = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.guitar_orientation);
            this.groupBox1.Controls.Add(this.add_button);
            this.groupBox1.Controls.Add(this.refresh_button);
            this.groupBox1.Controls.Add(this.guitar_scale_length_box);
            this.groupBox1.Controls.Add(this.number_of_guitar_frets_box);
            this.groupBox1.Controls.Add(this.guitar_body_color_box);
            this.groupBox1.Controls.Add(this.guitar_body_material_box);
            this.groupBox1.Controls.Add(this.guitar_neck_material_box);
            this.groupBox1.Controls.Add(this.guitar_model_box);
            this.groupBox1.Controls.Add(this.number_of_guitar_string_box);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Гитара/Бас гитара";
            // 
            // add_button
            // 
            this.add_button.Image = global::kurs.Properties.Resources.save;
            this.add_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_button.Location = new System.Drawing.Point(240, 274);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(150, 67);
            this.add_button.TabIndex = 18;
            this.add_button.Text = "Добавление ";
            this.add_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Image = global::kurs.Properties.Resources.free_icon_close_button_61155;
            this.refresh_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh_button.Location = new System.Drawing.Point(45, 274);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(159, 67);
            this.refresh_button.TabIndex = 17;
            this.refresh_button.Text = "Очистка полей";
            this.refresh_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // guitar_scale_length_box
            // 
            this.guitar_scale_length_box.Location = new System.Drawing.Point(211, 202);
            this.guitar_scale_length_box.Name = "guitar_scale_length_box";
            this.guitar_scale_length_box.Size = new System.Drawing.Size(102, 22);
            this.guitar_scale_length_box.TabIndex = 16;
            // 
            // number_of_guitar_frets_box
            // 
            this.number_of_guitar_frets_box.Location = new System.Drawing.Point(217, 148);
            this.number_of_guitar_frets_box.Name = "number_of_guitar_frets_box";
            this.number_of_guitar_frets_box.Size = new System.Drawing.Size(96, 22);
            this.number_of_guitar_frets_box.TabIndex = 14;
            // 
            // guitar_body_color_box
            // 
            this.guitar_body_color_box.Location = new System.Drawing.Point(191, 120);
            this.guitar_body_color_box.Name = "guitar_body_color_box";
            this.guitar_body_color_box.Size = new System.Drawing.Size(265, 22);
            this.guitar_body_color_box.TabIndex = 13;
            // 
            // guitar_body_material_box
            // 
            this.guitar_body_material_box.Location = new System.Drawing.Point(224, 94);
            this.guitar_body_material_box.Name = "guitar_body_material_box";
            this.guitar_body_material_box.Size = new System.Drawing.Size(232, 22);
            this.guitar_body_material_box.TabIndex = 12;
            // 
            // guitar_neck_material_box
            // 
            this.guitar_neck_material_box.Location = new System.Drawing.Point(210, 66);
            this.guitar_neck_material_box.Name = "guitar_neck_material_box";
            this.guitar_neck_material_box.Size = new System.Drawing.Size(246, 22);
            this.guitar_neck_material_box.TabIndex = 11;
            // 
            // guitar_model_box
            // 
            this.guitar_model_box.Location = new System.Drawing.Point(167, 39);
            this.guitar_model_box.Name = "guitar_model_box";
            this.guitar_model_box.Size = new System.Drawing.Size(289, 22);
            this.guitar_model_box.TabIndex = 10;
            // 
            // number_of_guitar_string_box
            // 
            this.number_of_guitar_string_box.Location = new System.Drawing.Point(217, 230);
            this.number_of_guitar_string_box.Name = "number_of_guitar_string_box";
            this.number_of_guitar_string_box.Size = new System.Drawing.Size(96, 22);
            this.number_of_guitar_string_box.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Количество струн гитары";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Длина мензуры гитары";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ориентация гитары";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество ладов гитары";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цвет корпуса гитары";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Материал корпуса гитары";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Материал грифа гитары";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Модель гитары";
            // 
            // choose_image_button
            // 
            this.choose_image_button.Image = global::kurs.Properties.Resources.premium_icon_thumbtacks_2672102;
            this.choose_image_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choose_image_button.Location = new System.Drawing.Point(551, 471);
            this.choose_image_button.Name = "choose_image_button";
            this.choose_image_button.Size = new System.Drawing.Size(111, 39);
            this.choose_image_button.TabIndex = 2;
            this.choose_image_button.Text = "Выбрать";
            this.choose_image_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.choose_image_button.UseVisualStyleBackColor = true;
            this.choose_image_button.Click += new System.EventHandler(this.choose_image_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(520, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 442);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // guitar_orientation
            // 
            this.guitar_orientation.FormattingEnabled = true;
            this.guitar_orientation.Items.AddRange(new object[] {
            "Правосторонняя",
            "Левосторонняя"});
            this.guitar_orientation.Location = new System.Drawing.Point(183, 174);
            this.guitar_orientation.Name = "guitar_orientation";
            this.guitar_orientation.Size = new System.Drawing.Size(207, 24);
            this.guitar_orientation.TabIndex = 19;
            // 
            // guitar_creater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(716, 522);
            this.Controls.Add(this.choose_image_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "guitar_creater";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox number_of_guitar_string_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox guitar_model_box;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.TextBox guitar_scale_length_box;
        private System.Windows.Forms.TextBox number_of_guitar_frets_box;
        private System.Windows.Forms.TextBox guitar_body_color_box;
        private System.Windows.Forms.TextBox guitar_body_material_box;
        private System.Windows.Forms.TextBox guitar_neck_material_box;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button choose_image_button;
        private System.Windows.Forms.ComboBox guitar_orientation;
    }
}
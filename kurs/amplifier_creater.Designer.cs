
namespace kurs
{
    partial class amplifier_creater
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
            this.amplifier_power_box = new System.Windows.Forms.TextBox();
            this.number_of_amplifier_channels_box = new System.Windows.Forms.TextBox();
            this.amplifier_speaker_model_box = new System.Windows.Forms.TextBox();
            this.amplifier_model_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.choose_image_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.amplifier_type = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.amplifier_type);
            this.groupBox1.Controls.Add(this.add_button);
            this.groupBox1.Controls.Add(this.refresh_button);
            this.groupBox1.Controls.Add(this.amplifier_power_box);
            this.groupBox1.Controls.Add(this.number_of_amplifier_channels_box);
            this.groupBox1.Controls.Add(this.amplifier_speaker_model_box);
            this.groupBox1.Controls.Add(this.amplifier_model_box);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Усилитель";
            // 
            // add_button
            // 
            this.add_button.Image = global::kurs.Properties.Resources.save;
            this.add_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_button.Location = new System.Drawing.Point(204, 188);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(141, 55);
            this.add_button.TabIndex = 11;
            this.add_button.Text = "Добавление";
            this.add_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Image = global::kurs.Properties.Resources.free_icon_close_button_61155;
            this.refresh_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh_button.Location = new System.Drawing.Point(21, 188);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(160, 55);
            this.refresh_button.TabIndex = 10;
            this.refresh_button.Text = "Очистка полей";
            this.refresh_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // amplifier_power_box
            // 
            this.amplifier_power_box.Location = new System.Drawing.Point(204, 149);
            this.amplifier_power_box.Name = "amplifier_power_box";
            this.amplifier_power_box.Size = new System.Drawing.Size(164, 22);
            this.amplifier_power_box.TabIndex = 9;
            // 
            // number_of_amplifier_channels_box
            // 
            this.number_of_amplifier_channels_box.Location = new System.Drawing.Point(273, 122);
            this.number_of_amplifier_channels_box.Name = "number_of_amplifier_channels_box";
            this.number_of_amplifier_channels_box.Size = new System.Drawing.Size(95, 22);
            this.number_of_amplifier_channels_box.TabIndex = 8;
            // 
            // amplifier_speaker_model_box
            // 
            this.amplifier_speaker_model_box.Location = new System.Drawing.Point(262, 96);
            this.amplifier_speaker_model_box.Name = "amplifier_speaker_model_box";
            this.amplifier_speaker_model_box.Size = new System.Drawing.Size(106, 22);
            this.amplifier_speaker_model_box.TabIndex = 7;
            // 
            // amplifier_model_box
            // 
            this.amplifier_model_box.Location = new System.Drawing.Point(187, 41);
            this.amplifier_model_box.Name = "amplifier_model_box";
            this.amplifier_model_box.Size = new System.Drawing.Size(181, 22);
            this.amplifier_model_box.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Мощность усилителя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Количество каналов усилителя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Модель динамиков усилителя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип усилителя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Модель усилителя";
            // 
            // choose_image_button
            // 
            this.choose_image_button.Image = global::kurs.Properties.Resources.premium_icon_thumbtacks_2672102;
            this.choose_image_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choose_image_button.Location = new System.Drawing.Point(570, 332);
            this.choose_image_button.Name = "choose_image_button";
            this.choose_image_button.Size = new System.Drawing.Size(112, 39);
            this.choose_image_button.TabIndex = 2;
            this.choose_image_button.Text = "Выбрать";
            this.choose_image_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.choose_image_button.UseVisualStyleBackColor = true;
            this.choose_image_button.Click += new System.EventHandler(this.choose_image_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(473, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // amplifier_type
            // 
            this.amplifier_type.FormattingEnabled = true;
            this.amplifier_type.Items.AddRange(new object[] {
            "Ламповый",
            "Транзисторный"});
            this.amplifier_type.Location = new System.Drawing.Point(162, 66);
            this.amplifier_type.Name = "amplifier_type";
            this.amplifier_type.Size = new System.Drawing.Size(206, 24);
            this.amplifier_type.TabIndex = 3;
            // 
            // amplifier_creater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.choose_image_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "amplifier_creater";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amplifier_power_box;
        private System.Windows.Forms.TextBox number_of_amplifier_channels_box;
        private System.Windows.Forms.TextBox amplifier_speaker_model_box;
        private System.Windows.Forms.TextBox amplifier_model_box;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button choose_image_button;
        private System.Windows.Forms.ComboBox amplifier_type;
    }
}
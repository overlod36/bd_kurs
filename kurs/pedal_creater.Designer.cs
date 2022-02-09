
namespace kurs
{
    partial class pedal_creater
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
            this.pedal_effect_box = new System.Windows.Forms.TextBox();
            this.pedal_model_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.choose_image_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pedal_type = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.groupBox1.Controls.Add(this.pedal_type);
            this.groupBox1.Controls.Add(this.add_button);
            this.groupBox1.Controls.Add(this.refresh_button);
            this.groupBox1.Controls.Add(this.pedal_effect_box);
            this.groupBox1.Controls.Add(this.pedal_model_box);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Педаль эффектов";
            // 
            // add_button
            // 
            this.add_button.Image = global::kurs.Properties.Resources.save;
            this.add_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_button.Location = new System.Drawing.Point(213, 182);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(141, 59);
            this.add_button.TabIndex = 6;
            this.add_button.Text = "Добавление";
            this.add_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Image = global::kurs.Properties.Resources.free_icon_close_button_61155;
            this.refresh_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh_button.Location = new System.Drawing.Point(30, 182);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(155, 59);
            this.refresh_button.TabIndex = 5;
            this.refresh_button.Text = "Очистка полей";
            this.refresh_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // pedal_effect_box
            // 
            this.pedal_effect_box.Location = new System.Drawing.Point(157, 119);
            this.pedal_effect_box.Name = "pedal_effect_box";
            this.pedal_effect_box.Size = new System.Drawing.Size(167, 22);
            this.pedal_effect_box.TabIndex = 1;
            // 
            // pedal_model_box
            // 
            this.pedal_model_box.Location = new System.Drawing.Point(154, 41);
            this.pedal_model_box.Name = "pedal_model_box";
            this.pedal_model_box.Size = new System.Drawing.Size(170, 22);
            this.pedal_model_box.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Эффект педали";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип педали";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Модель педали";
            // 
            // choose_image_button
            // 
            this.choose_image_button.Image = global::kurs.Properties.Resources.premium_icon_thumbtacks_2672102;
            this.choose_image_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choose_image_button.Location = new System.Drawing.Point(579, 338);
            this.choose_image_button.Name = "choose_image_button";
            this.choose_image_button.Size = new System.Drawing.Size(109, 40);
            this.choose_image_button.TabIndex = 1;
            this.choose_image_button.Text = "Выбрать";
            this.choose_image_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.choose_image_button.UseVisualStyleBackColor = true;
            this.choose_image_button.Click += new System.EventHandler(this.choose_image_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(496, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pedal_type
            // 
            this.pedal_type.FormattingEnabled = true;
            this.pedal_type.Items.AddRange(new object[] {
            "Аналоговая",
            "Ламповая"});
            this.pedal_type.Location = new System.Drawing.Point(143, 81);
            this.pedal_type.Name = "pedal_type";
            this.pedal_type.Size = new System.Drawing.Size(181, 24);
            this.pedal_type.TabIndex = 7;
            // 
            // pedal_creater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.choose_image_button);
            this.Controls.Add(this.groupBox1);
            this.Name = "pedal_creater";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pedal_effect_box;
        private System.Windows.Forms.TextBox pedal_model_box;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button choose_image_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox pedal_type;
    }
}
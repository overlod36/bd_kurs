
namespace kurs
{
    partial class amplifier_editor
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
            this.amplifier_type = new System.Windows.Forms.ComboBox();
            this.add_button = new System.Windows.Forms.Button();
            this.amplifier_power_box = new System.Windows.Forms.TextBox();
            this.number_of_amplifier_channels_box = new System.Windows.Forms.TextBox();
            this.amplifier_speaker_model_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.amplifier_model = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.amplifier_type);
            this.groupBox1.Controls.Add(this.add_button);
            this.groupBox1.Controls.Add(this.amplifier_power_box);
            this.groupBox1.Controls.Add(this.number_of_amplifier_channels_box);
            this.groupBox1.Controls.Add(this.amplifier_speaker_model_box);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 244);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Усилитель";
            // 
            // amplifier_type
            // 
            this.amplifier_type.Enabled = false;
            this.amplifier_type.FormattingEnabled = true;
            this.amplifier_type.Items.AddRange(new object[] {
            "Ламповый",
            "Транзисторный"});
            this.amplifier_type.Location = new System.Drawing.Point(164, 39);
            this.amplifier_type.Name = "amplifier_type";
            this.amplifier_type.Size = new System.Drawing.Size(206, 24);
            this.amplifier_type.TabIndex = 3;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(146, 168);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(141, 55);
            this.add_button.TabIndex = 11;
            this.add_button.Text = "Редактировать";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // amplifier_power_box
            // 
            this.amplifier_power_box.Enabled = false;
            this.amplifier_power_box.Location = new System.Drawing.Point(206, 122);
            this.amplifier_power_box.Name = "amplifier_power_box";
            this.amplifier_power_box.Size = new System.Drawing.Size(164, 22);
            this.amplifier_power_box.TabIndex = 9;
            // 
            // number_of_amplifier_channels_box
            // 
            this.number_of_amplifier_channels_box.Enabled = false;
            this.number_of_amplifier_channels_box.Location = new System.Drawing.Point(273, 93);
            this.number_of_amplifier_channels_box.Name = "number_of_amplifier_channels_box";
            this.number_of_amplifier_channels_box.Size = new System.Drawing.Size(95, 22);
            this.number_of_amplifier_channels_box.TabIndex = 8;
            // 
            // amplifier_speaker_model_box
            // 
            this.amplifier_speaker_model_box.Enabled = false;
            this.amplifier_speaker_model_box.Location = new System.Drawing.Point(262, 67);
            this.amplifier_speaker_model_box.Name = "amplifier_speaker_model_box";
            this.amplifier_speaker_model_box.Size = new System.Drawing.Size(106, 22);
            this.amplifier_speaker_model_box.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Мощность усилителя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Количество каналов усилителя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Модель динамиков усилителя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип усилителя";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.amplifier_model);
            this.groupBox2.Controls.Add(this.search_button);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 84);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск по модели";
            // 
            // amplifier_model
            // 
            this.amplifier_model.Location = new System.Drawing.Point(160, 35);
            this.amplifier_model.Name = "amplifier_model";
            this.amplifier_model.Size = new System.Drawing.Size(113, 22);
            this.amplifier_model.TabIndex = 12;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(303, 30);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(96, 32);
            this.search_button.TabIndex = 11;
            this.search_button.Text = "Поиск";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Модель усилителя";
            // 
            // amplifier_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(448, 375);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "amplifier_editor";
            this.Text = "amplifier_editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox amplifier_type;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox amplifier_power_box;
        private System.Windows.Forms.TextBox number_of_amplifier_channels_box;
        private System.Windows.Forms.TextBox amplifier_speaker_model_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox amplifier_model;
    }
}
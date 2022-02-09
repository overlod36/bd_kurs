
namespace kurs
{
    partial class pedal_editor
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
            this.pedal_type = new System.Windows.Forms.ComboBox();
            this.add_button = new System.Windows.Forms.Button();
            this.pedal_effect_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pedal_model = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.groupBox1.Controls.Add(this.pedal_type);
            this.groupBox1.Controls.Add(this.add_button);
            this.groupBox1.Controls.Add(this.pedal_effect_box);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Педаль эффектов";
            // 
            // pedal_type
            // 
            this.pedal_type.Enabled = false;
            this.pedal_type.FormattingEnabled = true;
            this.pedal_type.Items.AddRange(new object[] {
            "Аналоговая",
            "Ламповая"});
            this.pedal_type.Location = new System.Drawing.Point(165, 48);
            this.pedal_type.Name = "pedal_type";
            this.pedal_type.Size = new System.Drawing.Size(181, 24);
            this.pedal_type.TabIndex = 7;
            // 
            // add_button
            // 
            this.add_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_button.Location = new System.Drawing.Point(135, 133);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(141, 59);
            this.add_button.TabIndex = 6;
            this.add_button.Text = "Редактировать";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // pedal_effect_box
            // 
            this.pedal_effect_box.Enabled = false;
            this.pedal_effect_box.Location = new System.Drawing.Point(179, 86);
            this.pedal_effect_box.Name = "pedal_effect_box";
            this.pedal_effect_box.Size = new System.Drawing.Size(167, 22);
            this.pedal_effect_box.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Эффект педали";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип педали";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SlateBlue;
            this.groupBox2.Controls.Add(this.pedal_model);
            this.groupBox2.Controls.Add(this.search_button);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 84);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск по модели";
            // 
            // pedal_model
            // 
            this.pedal_model.Location = new System.Drawing.Point(144, 32);
            this.pedal_model.Name = "pedal_model";
            this.pedal_model.Size = new System.Drawing.Size(119, 22);
            this.pedal_model.TabIndex = 12;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Модель педали";
            // 
            // pedal_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(434, 339);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "pedal_editor";
            this.Text = "pedal_editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox pedal_type;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox pedal_effect_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pedal_model;
    }
}
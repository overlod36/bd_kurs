
namespace kurs
{
    partial class inst_menu_show
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
            this.guitar_button = new System.Windows.Forms.Button();
            this.pedal_button = new System.Windows.Forms.Button();
            this.amplifier_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.guitar_button);
            this.groupBox1.Controls.Add(this.pedal_button);
            this.groupBox1.Controls.Add(this.amplifier_button);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню показа инструментария";
            // 
            // guitar_button
            // 
            this.guitar_button.Location = new System.Drawing.Point(99, 107);
            this.guitar_button.Name = "guitar_button";
            this.guitar_button.Size = new System.Drawing.Size(93, 34);
            this.guitar_button.TabIndex = 6;
            this.guitar_button.Text = "Гитары";
            this.guitar_button.UseVisualStyleBackColor = true;
            this.guitar_button.Click += new System.EventHandler(this.guitar_button_Click);
            // 
            // pedal_button
            // 
            this.pedal_button.Location = new System.Drawing.Point(99, 214);
            this.pedal_button.Name = "pedal_button";
            this.pedal_button.Size = new System.Drawing.Size(92, 32);
            this.pedal_button.TabIndex = 8;
            this.pedal_button.Text = "Педали";
            this.pedal_button.UseVisualStyleBackColor = true;
            this.pedal_button.Click += new System.EventHandler(this.pedal_button_Click);
            // 
            // amplifier_button
            // 
            this.amplifier_button.Location = new System.Drawing.Point(99, 159);
            this.amplifier_button.Name = "amplifier_button";
            this.amplifier_button.Size = new System.Drawing.Size(93, 33);
            this.amplifier_button.TabIndex = 7;
            this.amplifier_button.Text = "Усилители";
            this.amplifier_button.UseVisualStyleBackColor = true;
            this.amplifier_button.Click += new System.EventHandler(this.amplifier_button_Click);
            // 
            // inst_menu_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(315, 377);
            this.Controls.Add(this.groupBox1);
            this.Name = "inst_menu_show";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button guitar_button;
        private System.Windows.Forms.Button pedal_button;
        private System.Windows.Forms.Button amplifier_button;
    }
}
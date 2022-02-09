
namespace kurs
{
    partial class sc_editor
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
            this.seller_button = new System.Windows.Forms.Button();
            this.customer_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.seller_button);
            this.groupBox1.Controls.Add(this.customer_button);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 353);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню редактирования людей";
            // 
            // seller_button
            // 
            this.seller_button.Location = new System.Drawing.Point(92, 143);
            this.seller_button.Name = "seller_button";
            this.seller_button.Size = new System.Drawing.Size(103, 34);
            this.seller_button.TabIndex = 6;
            this.seller_button.Text = "Продавцы";
            this.seller_button.UseVisualStyleBackColor = true;
            this.seller_button.Click += new System.EventHandler(this.seller_button_Click);
            // 
            // customer_button
            // 
            this.customer_button.Location = new System.Drawing.Point(92, 195);
            this.customer_button.Name = "customer_button";
            this.customer_button.Size = new System.Drawing.Size(103, 33);
            this.customer_button.TabIndex = 7;
            this.customer_button.Text = "Покупатели";
            this.customer_button.UseVisualStyleBackColor = true;
            this.customer_button.Click += new System.EventHandler(this.customer_button_Click);
            // 
            // sc_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(313, 377);
            this.Controls.Add(this.groupBox1);
            this.Name = "sc_editor";
            this.Text = "sc_editor";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button seller_button;
        private System.Windows.Forms.Button customer_button;
    }
}
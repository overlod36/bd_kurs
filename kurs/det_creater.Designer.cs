
namespace kurs
{
    partial class det_creater
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
            this.add_button = new System.Windows.Forms.Button();
            this.id_order = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_good = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(150, 287);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(111, 36);
            this.add_button.TabIndex = 11;
            this.add_button.Text = "Добавление";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // id_order
            // 
            this.id_order.Location = new System.Drawing.Point(211, 180);
            this.id_order.Name = "id_order";
            this.id_order.Size = new System.Drawing.Size(116, 22);
            this.id_order.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Добавление детализации";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID заказа";
            // 
            // id_good
            // 
            this.id_good.Location = new System.Drawing.Point(211, 231);
            this.id_good.Name = "id_good";
            this.id_good.Size = new System.Drawing.Size(116, 22);
            this.id_good.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID товара";
            // 
            // det_creater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 451);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_good);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.id_order);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "det_creater";
            this.Text = "det_creater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox id_order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_good;
        private System.Windows.Forms.Label label3;
    }
}
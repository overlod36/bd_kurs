
namespace kurs
{
    partial class order_delete
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
            this.del_button = new System.Windows.Forms.Button();
            this.id_order = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(155, 202);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(85, 30);
            this.del_button.TabIndex = 7;
            this.del_button.Text = "Удаление";
            this.del_button.UseVisualStyleBackColor = true;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // id_order
            // 
            this.id_order.Location = new System.Drawing.Point(190, 143);
            this.id_order.Name = "id_order";
            this.id_order.Size = new System.Drawing.Size(113, 22);
            this.id_order.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Удаление заказов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID заказа";
            // 
            // order_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 318);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.id_order);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "order_delete";
            this.Text = "order_delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.TextBox id_order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
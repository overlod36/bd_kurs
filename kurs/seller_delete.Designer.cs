
namespace kurs
{
    partial class seller_delete
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id_seller = new System.Windows.Forms.TextBox();
            this.del_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID продавца";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Удаление информации о продавцах";
            // 
            // id_seller
            // 
            this.id_seller.Location = new System.Drawing.Point(192, 127);
            this.id_seller.Name = "id_seller";
            this.id_seller.Size = new System.Drawing.Size(113, 22);
            this.id_seller.TabIndex = 2;
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(157, 186);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(85, 30);
            this.del_button.TabIndex = 3;
            this.del_button.Text = "Удаление";
            this.del_button.UseVisualStyleBackColor = true;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // seller_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 318);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.id_seller);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "seller_delete";
            this.Text = "seller_delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_seller;
        private System.Windows.Forms.Button del_button;
    }
}
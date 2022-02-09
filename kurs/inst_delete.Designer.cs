
namespace kurs
{
    partial class inst_delete
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
            this.table_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.key_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.del_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // table_box
            // 
            this.table_box.FormattingEnabled = true;
            this.table_box.Items.AddRange(new object[] {
            "Гитары",
            "Усилители",
            "Педали"});
            this.table_box.Location = new System.Drawing.Point(141, 111);
            this.table_box.Name = "table_box";
            this.table_box.Size = new System.Drawing.Size(236, 24);
            this.table_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбор таблицы";
            // 
            // key_box
            // 
            this.key_box.Location = new System.Drawing.Point(141, 158);
            this.key_box.Name = "key_box";
            this.key_box.Size = new System.Drawing.Size(235, 22);
            this.key_box.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ключ";
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(154, 210);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(85, 35);
            this.del_button.TabIndex = 6;
            this.del_button.Text = "Удаление";
            this.del_button.UseVisualStyleBackColor = true;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Удаление в отделение инструментария";
            // 
            // inst_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 274);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.key_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table_box);
            this.Name = "inst_delete";
            this.Text = "inst_delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox table_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox key_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Label label3;
    }
}
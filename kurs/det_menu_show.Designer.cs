
namespace kurs
{
    partial class det_menu_show
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
            this.goods_button = new System.Windows.Forms.Button();
            this.det_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.goods_button);
            this.groupBox1.Controls.Add(this.det_button);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 353);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню вывода детализации";
            // 
            // goods_button
            // 
            this.goods_button.Location = new System.Drawing.Point(87, 141);
            this.goods_button.Name = "goods_button";
            this.goods_button.Size = new System.Drawing.Size(124, 34);
            this.goods_button.TabIndex = 0;
            this.goods_button.Text = "Поиск";
            this.goods_button.UseVisualStyleBackColor = true;
            this.goods_button.Click += new System.EventHandler(this.goods_button_Click);
            // 
            // det_button
            // 
            this.det_button.Location = new System.Drawing.Point(87, 193);
            this.det_button.Name = "det_button";
            this.det_button.Size = new System.Drawing.Size(124, 33);
            this.det_button.TabIndex = 1;
            this.det_button.Text = "Вывод всех дет.";
            this.det_button.UseVisualStyleBackColor = true;
            this.det_button.Click += new System.EventHandler(this.det_button_Click);
            // 
            // det_menu_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(315, 377);
            this.Controls.Add(this.groupBox1);
            this.Name = "det_menu_show";
            this.Text = "det_menu_show";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button goods_button;
        private System.Windows.Forms.Button det_button;
    }
}
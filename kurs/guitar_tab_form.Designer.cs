
namespace kurs
{
    partial class guitar_tab_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guitar_tab_form));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guitarmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guitarpickuptypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guitarneckmaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guitarbodymaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guitarbodycolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofguitarfretsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guitarorientationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guitarscalelengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofguitarstringsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guitarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDataSet = new kurs.baseDataSet();
            this.guitarsTableAdapter = new kurs.baseDataSetTableAdapters.GuitarsTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guitarmodelDataGridViewTextBoxColumn,
            this.guitarpickuptypeDataGridViewTextBoxColumn,
            this.guitarneckmaterialDataGridViewTextBoxColumn,
            this.guitarbodymaterialDataGridViewTextBoxColumn,
            this.guitarbodycolorDataGridViewTextBoxColumn,
            this.numberofguitarfretsDataGridViewTextBoxColumn,
            this.guitarorientationDataGridViewTextBoxColumn,
            this.guitarscalelengthDataGridViewTextBoxColumn,
            this.numberofguitarstringsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.guitarsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 143);
            this.dataGridView1.TabIndex = 1;
            // 
            // guitarmodelDataGridViewTextBoxColumn
            // 
            this.guitarmodelDataGridViewTextBoxColumn.DataPropertyName = "guitar_model";
            this.guitarmodelDataGridViewTextBoxColumn.HeaderText = "guitar_model";
            this.guitarmodelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guitarmodelDataGridViewTextBoxColumn.Name = "guitarmodelDataGridViewTextBoxColumn";
            this.guitarmodelDataGridViewTextBoxColumn.Width = 125;
            // 
            // guitarpickuptypeDataGridViewTextBoxColumn
            // 
            this.guitarpickuptypeDataGridViewTextBoxColumn.DataPropertyName = "guitar_pickup_type";
            this.guitarpickuptypeDataGridViewTextBoxColumn.HeaderText = "guitar_pickup_type";
            this.guitarpickuptypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guitarpickuptypeDataGridViewTextBoxColumn.Name = "guitarpickuptypeDataGridViewTextBoxColumn";
            this.guitarpickuptypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // guitarneckmaterialDataGridViewTextBoxColumn
            // 
            this.guitarneckmaterialDataGridViewTextBoxColumn.DataPropertyName = "guitar_neck_material";
            this.guitarneckmaterialDataGridViewTextBoxColumn.HeaderText = "guitar_neck_material";
            this.guitarneckmaterialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guitarneckmaterialDataGridViewTextBoxColumn.Name = "guitarneckmaterialDataGridViewTextBoxColumn";
            this.guitarneckmaterialDataGridViewTextBoxColumn.Width = 125;
            // 
            // guitarbodymaterialDataGridViewTextBoxColumn
            // 
            this.guitarbodymaterialDataGridViewTextBoxColumn.DataPropertyName = "guitar_body_material";
            this.guitarbodymaterialDataGridViewTextBoxColumn.HeaderText = "guitar_body_material";
            this.guitarbodymaterialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guitarbodymaterialDataGridViewTextBoxColumn.Name = "guitarbodymaterialDataGridViewTextBoxColumn";
            this.guitarbodymaterialDataGridViewTextBoxColumn.Width = 125;
            // 
            // guitarbodycolorDataGridViewTextBoxColumn
            // 
            this.guitarbodycolorDataGridViewTextBoxColumn.DataPropertyName = "guitar_body_color";
            this.guitarbodycolorDataGridViewTextBoxColumn.HeaderText = "guitar_body_color";
            this.guitarbodycolorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guitarbodycolorDataGridViewTextBoxColumn.Name = "guitarbodycolorDataGridViewTextBoxColumn";
            this.guitarbodycolorDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberofguitarfretsDataGridViewTextBoxColumn
            // 
            this.numberofguitarfretsDataGridViewTextBoxColumn.DataPropertyName = "number_of_guitar_frets";
            this.numberofguitarfretsDataGridViewTextBoxColumn.HeaderText = "number_of_guitar_frets";
            this.numberofguitarfretsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberofguitarfretsDataGridViewTextBoxColumn.Name = "numberofguitarfretsDataGridViewTextBoxColumn";
            this.numberofguitarfretsDataGridViewTextBoxColumn.Width = 125;
            // 
            // guitarorientationDataGridViewTextBoxColumn
            // 
            this.guitarorientationDataGridViewTextBoxColumn.DataPropertyName = "guitar_orientation";
            this.guitarorientationDataGridViewTextBoxColumn.HeaderText = "guitar_orientation";
            this.guitarorientationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guitarorientationDataGridViewTextBoxColumn.Name = "guitarorientationDataGridViewTextBoxColumn";
            this.guitarorientationDataGridViewTextBoxColumn.Width = 125;
            // 
            // guitarscalelengthDataGridViewTextBoxColumn
            // 
            this.guitarscalelengthDataGridViewTextBoxColumn.DataPropertyName = "guitar_scale_length";
            this.guitarscalelengthDataGridViewTextBoxColumn.HeaderText = "guitar_scale_length";
            this.guitarscalelengthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guitarscalelengthDataGridViewTextBoxColumn.Name = "guitarscalelengthDataGridViewTextBoxColumn";
            this.guitarscalelengthDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberofguitarstringsDataGridViewTextBoxColumn
            // 
            this.numberofguitarstringsDataGridViewTextBoxColumn.DataPropertyName = "number_of_guitar_strings";
            this.numberofguitarstringsDataGridViewTextBoxColumn.HeaderText = "number_of_guitar_strings";
            this.numberofguitarstringsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberofguitarstringsDataGridViewTextBoxColumn.Name = "numberofguitarstringsDataGridViewTextBoxColumn";
            this.numberofguitarstringsDataGridViewTextBoxColumn.Width = 125;
            // 
            // guitarsBindingSource
            // 
            this.guitarsBindingSource.DataMember = "Guitars";
            this.guitarsBindingSource.DataSource = this.baseDataSet;
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "baseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guitarsTableAdapter
            // 
            this.guitarsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1222, 31);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // guitar_tab_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 450);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "guitar_tab_form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private baseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource guitarsBindingSource;
        private baseDataSetTableAdapters.GuitarsTableAdapter guitarsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn guitarmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guitarpickuptypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guitarneckmaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guitarbodymaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guitarbodycolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofguitarfretsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guitarorientationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guitarscalelengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofguitarstringsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}


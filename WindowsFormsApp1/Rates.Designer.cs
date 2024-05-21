namespace WindowsFormsApp1
{
    partial class Rates
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label rate_NameLabel;
            System.Windows.Forms.Label rate_Coast_Per_MonthLabel;
            System.Windows.Forms.Label numbers_of_FilmsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rates));
            this.медиатекаDataSet = new WindowsFormsApp1.МедиатекаDataSet();
            this.ratesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ratesTableAdapter = new WindowsFormsApp1.МедиатекаDataSetTableAdapters.RatesTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.МедиатекаDataSetTableAdapters.TableAdapterManager();
            this.ratesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ratesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rate_NameTextBox = new System.Windows.Forms.TextBox();
            this.rate_Coast_Per_MonthTextBox = new System.Windows.Forms.TextBox();
            this.numbers_of_FilmsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            rate_NameLabel = new System.Windows.Forms.Label();
            rate_Coast_Per_MonthLabel = new System.Windows.Forms.Label();
            numbers_of_FilmsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.медиатекаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratesBindingNavigator)).BeginInit();
            this.ratesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // rate_NameLabel
            // 
            rate_NameLabel.AutoSize = true;
            rate_NameLabel.Location = new System.Drawing.Point(53, 132);
            rate_NameLabel.Name = "rate_NameLabel";
            rate_NameLabel.Size = new System.Drawing.Size(64, 13);
            rate_NameLabel.TabIndex = 1;
            rate_NameLabel.Text = "Rate Name:";
            // 
            // rate_Coast_Per_MonthLabel
            // 
            rate_Coast_Per_MonthLabel.AutoSize = true;
            rate_Coast_Per_MonthLabel.Location = new System.Drawing.Point(53, 182);
            rate_Coast_Per_MonthLabel.Name = "rate_Coast_Per_MonthLabel";
            rate_Coast_Per_MonthLabel.Size = new System.Drawing.Size(115, 13);
            rate_Coast_Per_MonthLabel.TabIndex = 3;
            rate_Coast_Per_MonthLabel.Text = "Rate Coast Per Month:";
            // 
            // numbers_of_FilmsLabel
            // 
            numbers_of_FilmsLabel.AutoSize = true;
            numbers_of_FilmsLabel.Location = new System.Drawing.Point(53, 230);
            numbers_of_FilmsLabel.Name = "numbers_of_FilmsLabel";
            numbers_of_FilmsLabel.Size = new System.Drawing.Size(90, 13);
            numbers_of_FilmsLabel.TabIndex = 5;
            numbers_of_FilmsLabel.Text = "Numbers of Films:";
            // 
            // медиатекаDataSet
            // 
            this.медиатекаDataSet.DataSetName = "МедиатекаDataSet";
            this.медиатекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ratesBindingSource
            // 
            this.ratesBindingSource.DataMember = "Rates";
            this.ratesBindingSource.DataSource = this.медиатекаDataSet;
            // 
            // ratesTableAdapter
            // 
            this.ratesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilmsTableAdapter = null;
            this.tableAdapterManager.GenreTableAdapter = null;
            this.tableAdapterManager.Purchase_TableAdapter = null;
            this.tableAdapterManager.RatesTableAdapter = this.ratesTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.МедиатекаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // ratesBindingNavigator
            // 
            this.ratesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ratesBindingNavigator.BindingSource = this.ratesBindingSource;
            this.ratesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ratesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ratesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.ratesBindingNavigatorSaveItem});
            this.ratesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ratesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ratesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ratesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ratesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ratesBindingNavigator.Name = "ratesBindingNavigator";
            this.ratesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ratesBindingNavigator.Size = new System.Drawing.Size(352, 25);
            this.ratesBindingNavigator.TabIndex = 0;
            this.ratesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ratesBindingNavigatorSaveItem
            // 
            this.ratesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ratesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ratesBindingNavigatorSaveItem.Image")));
            this.ratesBindingNavigatorSaveItem.Name = "ratesBindingNavigatorSaveItem";
            this.ratesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ratesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.ratesBindingNavigatorSaveItem.Click += new System.EventHandler(this.ratesBindingNavigatorSaveItem_Click);
            // 
            // rate_NameTextBox
            // 
            this.rate_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ratesBindingSource, "Rate_Name", true));
            this.rate_NameTextBox.Location = new System.Drawing.Point(174, 125);
            this.rate_NameTextBox.Name = "rate_NameTextBox";
            this.rate_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.rate_NameTextBox.TabIndex = 2;
            // 
            // rate_Coast_Per_MonthTextBox
            // 
            this.rate_Coast_Per_MonthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ratesBindingSource, "Rate_Coast_Per_Month", true));
            this.rate_Coast_Per_MonthTextBox.Location = new System.Drawing.Point(174, 179);
            this.rate_Coast_Per_MonthTextBox.Name = "rate_Coast_Per_MonthTextBox";
            this.rate_Coast_Per_MonthTextBox.Size = new System.Drawing.Size(100, 20);
            this.rate_Coast_Per_MonthTextBox.TabIndex = 4;
            // 
            // numbers_of_FilmsTextBox
            // 
            this.numbers_of_FilmsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ratesBindingSource, "Numbers_of_Films", true));
            this.numbers_of_FilmsTextBox.Location = new System.Drawing.Point(174, 227);
            this.numbers_of_FilmsTextBox.Name = "numbers_of_FilmsTextBox";
            this.numbers_of_FilmsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numbers_of_FilmsTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "таблица \"оценки\"";
            // 
            // Rates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(numbers_of_FilmsLabel);
            this.Controls.Add(this.numbers_of_FilmsTextBox);
            this.Controls.Add(rate_Coast_Per_MonthLabel);
            this.Controls.Add(this.rate_Coast_Per_MonthTextBox);
            this.Controls.Add(rate_NameLabel);
            this.Controls.Add(this.rate_NameTextBox);
            this.Controls.Add(this.ratesBindingNavigator);
            this.Name = "Rates";
            this.Text = "Rates";
            this.Load += new System.EventHandler(this.Rates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.медиатекаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratesBindingNavigator)).EndInit();
            this.ratesBindingNavigator.ResumeLayout(false);
            this.ratesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private МедиатекаDataSet медиатекаDataSet;
        private System.Windows.Forms.BindingSource ratesBindingSource;
        private МедиатекаDataSetTableAdapters.RatesTableAdapter ratesTableAdapter;
        private МедиатекаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ratesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ratesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox rate_NameTextBox;
        private System.Windows.Forms.TextBox rate_Coast_Per_MonthTextBox;
        private System.Windows.Forms.TextBox numbers_of_FilmsTextBox;
        private System.Windows.Forms.Label label1;
    }
}
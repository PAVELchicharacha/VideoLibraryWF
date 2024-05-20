namespace WindowsFormsApp1
{
    partial class Purchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase));
            System.Windows.Forms.Label id_PurchaseLabel;
            System.Windows.Forms.Label id_UserLabel;
            System.Windows.Forms.Label id_FilmLabel;
            System.Windows.Forms.Label id_RateLabel;
            System.Windows.Forms.Label purchase_CoastLabel;
            this.медиатекаDataSet = new WindowsFormsApp1.МедиатекаDataSet();
            this.purchase_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_TableAdapter = new WindowsFormsApp1.МедиатекаDataSetTableAdapters.Purchase_TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.МедиатекаDataSetTableAdapters.TableAdapterManager();
            this.purchase_BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.purchase_BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_PurchaseTextBox = new System.Windows.Forms.TextBox();
            this.id_UserTextBox = new System.Windows.Forms.TextBox();
            this.id_FilmTextBox = new System.Windows.Forms.TextBox();
            this.id_RateTextBox = new System.Windows.Forms.TextBox();
            this.purchase_CoastTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            id_PurchaseLabel = new System.Windows.Forms.Label();
            id_UserLabel = new System.Windows.Forms.Label();
            id_FilmLabel = new System.Windows.Forms.Label();
            id_RateLabel = new System.Windows.Forms.Label();
            purchase_CoastLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.медиатекаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_BindingNavigator)).BeginInit();
            this.purchase_BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // медиатекаDataSet
            // 
            this.медиатекаDataSet.DataSetName = "МедиатекаDataSet";
            this.медиатекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchase_BindingSource
            // 
            this.purchase_BindingSource.DataMember = "Purchase ";
            this.purchase_BindingSource.DataSource = this.медиатекаDataSet;
            // 
            // purchase_TableAdapter
            // 
            this.purchase_TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilmsTableAdapter = null;
            this.tableAdapterManager.GenreTableAdapter = null;
            this.tableAdapterManager.Purchase_TableAdapter = this.purchase_TableAdapter;
            this.tableAdapterManager.RatesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.МедиатекаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // purchase_BindingNavigator
            // 
            this.purchase_BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.purchase_BindingNavigator.BindingSource = this.purchase_BindingSource;
            this.purchase_BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.purchase_BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.purchase_BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.purchase_BindingNavigatorSaveItem});
            this.purchase_BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.purchase_BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.purchase_BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.purchase_BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.purchase_BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.purchase_BindingNavigator.Name = "purchase_BindingNavigator";
            this.purchase_BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.purchase_BindingNavigator.Size = new System.Drawing.Size(409, 25);
            this.purchase_BindingNavigator.TabIndex = 0;
            this.purchase_BindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // purchase_BindingNavigatorSaveItem
            // 
            this.purchase_BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.purchase_BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("purchase_BindingNavigatorSaveItem.Image")));
            this.purchase_BindingNavigatorSaveItem.Name = "purchase_BindingNavigatorSaveItem";
            this.purchase_BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.purchase_BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.purchase_BindingNavigatorSaveItem.Click += new System.EventHandler(this.purchase_BindingNavigatorSaveItem_Click);
            // 
            // id_PurchaseLabel
            // 
            id_PurchaseLabel.AutoSize = true;
            id_PurchaseLabel.Location = new System.Drawing.Point(86, 128);
            id_PurchaseLabel.Name = "id_PurchaseLabel";
            id_PurchaseLabel.Size = new System.Drawing.Size(67, 13);
            id_PurchaseLabel.TabIndex = 1;
            id_PurchaseLabel.Text = "Id Purchase:";
            // 
            // id_PurchaseTextBox
            // 
            this.id_PurchaseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_BindingSource, "Id_Purchase", true));
            this.id_PurchaseTextBox.Location = new System.Drawing.Point(159, 125);
            this.id_PurchaseTextBox.Name = "id_PurchaseTextBox";
            this.id_PurchaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_PurchaseTextBox.TabIndex = 2;
            // 
            // id_UserLabel
            // 
            id_UserLabel.AutoSize = true;
            id_UserLabel.Location = new System.Drawing.Point(86, 174);
            id_UserLabel.Name = "id_UserLabel";
            id_UserLabel.Size = new System.Drawing.Size(44, 13);
            id_UserLabel.TabIndex = 3;
            id_UserLabel.Text = "Id User:";
            // 
            // id_UserTextBox
            // 
            this.id_UserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_BindingSource, "Id_User", true));
            this.id_UserTextBox.Location = new System.Drawing.Point(136, 171);
            this.id_UserTextBox.Name = "id_UserTextBox";
            this.id_UserTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_UserTextBox.TabIndex = 4;
            // 
            // id_FilmLabel
            // 
            id_FilmLabel.AutoSize = true;
            id_FilmLabel.Location = new System.Drawing.Point(86, 215);
            id_FilmLabel.Name = "id_FilmLabel";
            id_FilmLabel.Size = new System.Drawing.Size(40, 13);
            id_FilmLabel.TabIndex = 5;
            id_FilmLabel.Text = "Id Film:";
            // 
            // id_FilmTextBox
            // 
            this.id_FilmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_BindingSource, "Id_Film", true));
            this.id_FilmTextBox.Location = new System.Drawing.Point(132, 212);
            this.id_FilmTextBox.Name = "id_FilmTextBox";
            this.id_FilmTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_FilmTextBox.TabIndex = 6;
            // 
            // id_RateLabel
            // 
            id_RateLabel.AutoSize = true;
            id_RateLabel.Location = new System.Drawing.Point(86, 252);
            id_RateLabel.Name = "id_RateLabel";
            id_RateLabel.Size = new System.Drawing.Size(45, 13);
            id_RateLabel.TabIndex = 7;
            id_RateLabel.Text = "Id Rate:";
            // 
            // id_RateTextBox
            // 
            this.id_RateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_BindingSource, "Id_Rate", true));
            this.id_RateTextBox.Location = new System.Drawing.Point(137, 249);
            this.id_RateTextBox.Name = "id_RateTextBox";
            this.id_RateTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_RateTextBox.TabIndex = 8;
            // 
            // purchase_CoastLabel
            // 
            purchase_CoastLabel.AutoSize = true;
            purchase_CoastLabel.Location = new System.Drawing.Point(86, 294);
            purchase_CoastLabel.Name = "purchase_CoastLabel";
            purchase_CoastLabel.Size = new System.Drawing.Size(85, 13);
            purchase_CoastLabel.TabIndex = 9;
            purchase_CoastLabel.Text = "Purchase Coast:";
            // 
            // purchase_CoastTextBox
            // 
            this.purchase_CoastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_BindingSource, "Purchase_Coast", true));
            this.purchase_CoastTextBox.Location = new System.Drawing.Point(177, 291);
            this.purchase_CoastTextBox.Name = "purchase_CoastTextBox";
            this.purchase_CoastTextBox.Size = new System.Drawing.Size(100, 20);
            this.purchase_CoastTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "таблица\"покупки\"";
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(purchase_CoastLabel);
            this.Controls.Add(this.purchase_CoastTextBox);
            this.Controls.Add(id_RateLabel);
            this.Controls.Add(this.id_RateTextBox);
            this.Controls.Add(id_FilmLabel);
            this.Controls.Add(this.id_FilmTextBox);
            this.Controls.Add(id_UserLabel);
            this.Controls.Add(this.id_UserTextBox);
            this.Controls.Add(id_PurchaseLabel);
            this.Controls.Add(this.id_PurchaseTextBox);
            this.Controls.Add(this.purchase_BindingNavigator);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.медиатекаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_BindingNavigator)).EndInit();
            this.purchase_BindingNavigator.ResumeLayout(false);
            this.purchase_BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private МедиатекаDataSet медиатекаDataSet;
        private System.Windows.Forms.BindingSource purchase_BindingSource;
        private МедиатекаDataSetTableAdapters.Purchase_TableAdapter purchase_TableAdapter;
        private МедиатекаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator purchase_BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton purchase_BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_PurchaseTextBox;
        private System.Windows.Forms.TextBox id_UserTextBox;
        private System.Windows.Forms.TextBox id_FilmTextBox;
        private System.Windows.Forms.TextBox id_RateTextBox;
        private System.Windows.Forms.TextBox purchase_CoastTextBox;
        private System.Windows.Forms.Label label1;
    }
}
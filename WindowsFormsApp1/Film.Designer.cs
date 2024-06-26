﻿namespace WindowsFormsApp1
{
    partial class Form2
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label year_of_IssueLabel;
            System.Windows.Forms.Label directorLabel;
            System.Windows.Forms.Label main_ActorLabel;
            System.Windows.Forms.Label user_RateLabel;
            System.Windows.Forms.Label id_RateLabel;
            System.Windows.Forms.Label film_CoastLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.медиатекаDataSet = new WindowsFormsApp1.МедиатекаDataSet();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsTableAdapter = new WindowsFormsApp1.МедиатекаDataSetTableAdapters.FilmsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.МедиатекаDataSetTableAdapters.TableAdapterManager();
            this.filmsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.filmsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.year_of_IssueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.main_ActorTextBox = new System.Windows.Forms.TextBox();
            this.user_RateTextBox = new System.Windows.Forms.TextBox();
            this.id_RateTextBox = new System.Windows.Forms.TextBox();
            this.film_CoastTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            year_of_IssueLabel = new System.Windows.Forms.Label();
            directorLabel = new System.Windows.Forms.Label();
            main_ActorLabel = new System.Windows.Forms.Label();
            user_RateLabel = new System.Windows.Forms.Label();
            id_RateLabel = new System.Windows.Forms.Label();
            film_CoastLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.медиатекаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingNavigator)).BeginInit();
            this.filmsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(55, 154);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(53, 259);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(39, 13);
            genreLabel.TabIndex = 6;
            genreLabel.Text = "Genre:";
            // 
            // year_of_IssueLabel
            // 
            year_of_IssueLabel.AutoSize = true;
            year_of_IssueLabel.Location = new System.Drawing.Point(53, 192);
            year_of_IssueLabel.Name = "year_of_IssueLabel";
            year_of_IssueLabel.Size = new System.Drawing.Size(72, 13);
            year_of_IssueLabel.TabIndex = 8;
            year_of_IssueLabel.Text = "Year of Issue:";
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Location = new System.Drawing.Point(53, 121);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new System.Drawing.Size(47, 13);
            directorLabel.TabIndex = 10;
            directorLabel.Text = "Director:";
            // 
            // main_ActorLabel
            // 
            main_ActorLabel.AutoSize = true;
            main_ActorLabel.Location = new System.Drawing.Point(55, 225);
            main_ActorLabel.Name = "main_ActorLabel";
            main_ActorLabel.Size = new System.Drawing.Size(61, 13);
            main_ActorLabel.TabIndex = 12;
            main_ActorLabel.Text = "Main Actor:";
            // 
            // user_RateLabel
            // 
            user_RateLabel.AutoSize = true;
            user_RateLabel.Location = new System.Drawing.Point(53, 297);
            user_RateLabel.Name = "user_RateLabel";
            user_RateLabel.Size = new System.Drawing.Size(58, 13);
            user_RateLabel.TabIndex = 14;
            user_RateLabel.Text = "User Rate:";
            // 
            // id_RateLabel
            // 
            id_RateLabel.AutoSize = true;
            id_RateLabel.Location = new System.Drawing.Point(55, 334);
            id_RateLabel.Name = "id_RateLabel";
            id_RateLabel.Size = new System.Drawing.Size(45, 13);
            id_RateLabel.TabIndex = 16;
            id_RateLabel.Text = "Id Rate:";
            // 
            // film_CoastLabel
            // 
            film_CoastLabel.AutoSize = true;
            film_CoastLabel.Location = new System.Drawing.Point(53, 369);
            film_CoastLabel.Name = "film_CoastLabel";
            film_CoastLabel.Size = new System.Drawing.Size(58, 13);
            film_CoastLabel.TabIndex = 18;
            film_CoastLabel.Text = "Film Coast:";
            // 
            // медиатекаDataSet
            // 
            this.медиатекаDataSet.DataSetName = "МедиатекаDataSet";
            this.медиатекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "Films";
            this.filmsBindingSource.DataSource = this.медиатекаDataSet;
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilmsTableAdapter = this.filmsTableAdapter;
            this.tableAdapterManager.GenreTableAdapter = null;
            this.tableAdapterManager.Purchase_TableAdapter = null;
            this.tableAdapterManager.RatesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.МедиатекаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // filmsBindingNavigator
            // 
            this.filmsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.filmsBindingNavigator.BindingSource = this.filmsBindingSource;
            this.filmsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.filmsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.filmsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.filmsBindingNavigatorSaveItem});
            this.filmsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.filmsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.filmsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.filmsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.filmsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.filmsBindingNavigator.Name = "filmsBindingNavigator";
            this.filmsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.filmsBindingNavigator.Size = new System.Drawing.Size(403, 25);
            this.filmsBindingNavigator.TabIndex = 1;
            this.filmsBindingNavigator.Text = "bindingNavigator1";
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
            // filmsBindingNavigatorSaveItem
            // 
            this.filmsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filmsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("filmsBindingNavigatorSaveItem.Image")));
            this.filmsBindingNavigatorSaveItem.Name = "filmsBindingNavigatorSaveItem";
            this.filmsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.filmsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.filmsBindingNavigatorSaveItem.Click += new System.EventHandler(this.filmsBindingNavigatorSaveItem_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(131, 147);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // genreTextBox
            // 
            this.genreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "Genre", true));
            this.genreTextBox.Location = new System.Drawing.Point(131, 256);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(200, 20);
            this.genreTextBox.TabIndex = 7;
            // 
            // year_of_IssueDateTimePicker
            // 
            this.year_of_IssueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.filmsBindingSource, "Year_of_Issue", true));
            this.year_of_IssueDateTimePicker.Location = new System.Drawing.Point(131, 192);
            this.year_of_IssueDateTimePicker.Name = "year_of_IssueDateTimePicker";
            this.year_of_IssueDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.year_of_IssueDateTimePicker.TabIndex = 9;
            // 
            // directorTextBox
            // 
            this.directorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "Director", true));
            this.directorTextBox.Location = new System.Drawing.Point(131, 114);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(200, 20);
            this.directorTextBox.TabIndex = 11;
            this.directorTextBox.TextChanged += new System.EventHandler(this.directorTextBox_TextChanged);
            // 
            // main_ActorTextBox
            // 
            this.main_ActorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "Main_Actor", true));
            this.main_ActorTextBox.Location = new System.Drawing.Point(131, 225);
            this.main_ActorTextBox.Name = "main_ActorTextBox";
            this.main_ActorTextBox.Size = new System.Drawing.Size(200, 20);
            this.main_ActorTextBox.TabIndex = 13;
            // 
            // user_RateTextBox
            // 
            this.user_RateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "User_Rate", true));
            this.user_RateTextBox.Location = new System.Drawing.Point(131, 294);
            this.user_RateTextBox.Name = "user_RateTextBox";
            this.user_RateTextBox.Size = new System.Drawing.Size(200, 20);
            this.user_RateTextBox.TabIndex = 15;
            // 
            // id_RateTextBox
            // 
            this.id_RateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "Id_Rate", true));
            this.id_RateTextBox.Location = new System.Drawing.Point(131, 327);
            this.id_RateTextBox.Name = "id_RateTextBox";
            this.id_RateTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_RateTextBox.TabIndex = 17;
            // 
            // film_CoastTextBox
            // 
            this.film_CoastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "Film_Coast", true));
            this.film_CoastTextBox.Location = new System.Drawing.Point(131, 366);
            this.film_CoastTextBox.Name = "film_CoastTextBox";
            this.film_CoastTextBox.Size = new System.Drawing.Size(200, 20);
            this.film_CoastTextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "таблица\"фильмы\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Первый";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Предыдущий";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(283, 420);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(50, 459);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Последний";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(162, 459);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Следующий";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(283, 459);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(162, 499);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 23);
            this.button8.TabIndex = 28;
            this.button8.Text = "Сохранить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(50, 499);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 23);
            this.button7.TabIndex = 29;
            this.button7.Text = "Таблица";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 553);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(film_CoastLabel);
            this.Controls.Add(this.film_CoastTextBox);
            this.Controls.Add(id_RateLabel);
            this.Controls.Add(this.id_RateTextBox);
            this.Controls.Add(user_RateLabel);
            this.Controls.Add(this.user_RateTextBox);
            this.Controls.Add(main_ActorLabel);
            this.Controls.Add(this.main_ActorTextBox);
            this.Controls.Add(directorLabel);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(year_of_IssueLabel);
            this.Controls.Add(this.year_of_IssueDateTimePicker);
            this.Controls.Add(genreLabel);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.filmsBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.медиатекаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingNavigator)).EndInit();
            this.filmsBindingNavigator.ResumeLayout(false);
            this.filmsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private МедиатекаDataSet медиатекаDataSet;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private МедиатекаDataSetTableAdapters.FilmsTableAdapter filmsTableAdapter;
        private МедиатекаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator filmsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton filmsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.DateTimePicker year_of_IssueDateTimePicker;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.TextBox main_ActorTextBox;
        private System.Windows.Forms.TextBox user_RateTextBox;
        private System.Windows.Forms.TextBox id_RateTextBox;
        private System.Windows.Forms.TextBox film_CoastTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
    }
}
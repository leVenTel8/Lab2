namespace Lab2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label nUMLabel;
            System.Windows.Forms.Label lNAMELabel;
            System.Windows.Forms.Label fNAMELabel;
            System.Windows.Forms.Label sNAMELabel;
            System.Windows.Forms.Label bDAYLabel;
            System.Windows.Forms.Label pOSTLabel;
            System.Windows.Forms.Label aDRESLabel;
            System.Windows.Forms.Label pHONELabel;
            System.Windows.Forms.Label pAYLabel;
            this.dataSet1 = new Lab2.DataSet1();
            this.pERSONALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONALTableAdapter = new Lab2.DataSet1TableAdapters.PERSONALTableAdapter();
            this.tableAdapterManager = new Lab2.DataSet1TableAdapters.TableAdapterManager();
            this.pERSONALBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pERSONALBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pERSONALDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.образованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUMTextBox = new System.Windows.Forms.TextBox();
            this.lNAMETextBox = new System.Windows.Forms.TextBox();
            this.fNAMETextBox = new System.Windows.Forms.TextBox();
            this.sNAMETextBox = new System.Windows.Forms.TextBox();
            this.bDAYDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pOSTTextBox = new System.Windows.Forms.TextBox();
            this.aDRESTextBox = new System.Windows.Forms.TextBox();
            this.pHONETextBox = new System.Windows.Forms.TextBox();
            this.pAYTextBox = new System.Windows.Forms.TextBox();
            nUMLabel = new System.Windows.Forms.Label();
            lNAMELabel = new System.Windows.Forms.Label();
            fNAMELabel = new System.Windows.Forms.Label();
            sNAMELabel = new System.Windows.Forms.Label();
            bDAYLabel = new System.Windows.Forms.Label();
            pOSTLabel = new System.Windows.Forms.Label();
            aDRESLabel = new System.Windows.Forms.Label();
            pHONELabel = new System.Windows.Forms.Label();
            pAYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONALBindingNavigator)).BeginInit();
            this.pERSONALBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONALDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERSONALBindingSource
            // 
            this.pERSONALBindingSource.DataMember = "PERSONAL";
            this.pERSONALBindingSource.DataSource = this.dataSet1;
            // 
            // pERSONALTableAdapter
            // 
            this.pERSONALTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DEPARTMENTTableAdapter = null;
            this.tableAdapterManager.PERSONALTableAdapter = this.pERSONALTableAdapter;
            this.tableAdapterManager.UpdateOrder = Lab2.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pERSONALBindingNavigator
            // 
            this.pERSONALBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pERSONALBindingNavigator.BindingSource = this.pERSONALBindingSource;
            this.pERSONALBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pERSONALBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pERSONALBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pERSONALBindingNavigatorSaveItem});
            this.pERSONALBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.pERSONALBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pERSONALBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pERSONALBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pERSONALBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pERSONALBindingNavigator.Name = "pERSONALBindingNavigator";
            this.pERSONALBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pERSONALBindingNavigator.Size = new System.Drawing.Size(794, 25);
            this.pERSONALBindingNavigator.TabIndex = 1;
            this.pERSONALBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pERSONALBindingNavigatorSaveItem
            // 
            this.pERSONALBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pERSONALBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pERSONALBindingNavigatorSaveItem.Image")));
            this.pERSONALBindingNavigatorSaveItem.Name = "pERSONALBindingNavigatorSaveItem";
            this.pERSONALBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pERSONALBindingNavigatorSaveItem.Text = "Save Data";
            this.pERSONALBindingNavigatorSaveItem.Click += new System.EventHandler(this.pERSONALBindingNavigatorSaveItem_Click);
            // 
            // pERSONALDataGridView
            // 
            this.pERSONALDataGridView.AllowUserToAddRows = false;
            this.pERSONALDataGridView.AllowUserToDeleteRows = false;
            this.pERSONALDataGridView.AutoGenerateColumns = false;
            this.pERSONALDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pERSONALDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.pERSONALDataGridView.DataSource = this.pERSONALBindingSource;
            this.pERSONALDataGridView.Location = new System.Drawing.Point(12, 55);
            this.pERSONALDataGridView.MultiSelect = false;
            this.pERSONALDataGridView.Name = "pERSONALDataGridView";
            this.pERSONALDataGridView.ReadOnly = true;
            this.pERSONALDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pERSONALDataGridView.Size = new System.Drawing.Size(242, 432);
            this.pERSONALDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NUM";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LNAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отделыToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.образованиеToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // отделыToolStripMenuItem
            // 
            this.отделыToolStripMenuItem.Name = "отделыToolStripMenuItem";
            this.отделыToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.отделыToolStripMenuItem.Text = "Отделы";
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.должностиToolStripMenuItem.Text = "Должности";
            // 
            // образованиеToolStripMenuItem
            // 
            this.образованиеToolStripMenuItem.Name = "образованиеToolStripMenuItem";
            this.образованиеToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.образованиеToolStripMenuItem.Text = "Образование";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // nUMLabel
            // 
            nUMLabel.AutoSize = true;
            nUMLabel.Location = new System.Drawing.Point(336, 91);
            nUMLabel.Name = "nUMLabel";
            nUMLabel.Size = new System.Drawing.Size(35, 13);
            nUMLabel.TabIndex = 3;
            nUMLabel.Text = "NUM:";
            // 
            // nUMTextBox
            // 
            this.nUMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "NUM", true));
            this.nUMTextBox.Location = new System.Drawing.Point(407, 88);
            this.nUMTextBox.Name = "nUMTextBox";
            this.nUMTextBox.Size = new System.Drawing.Size(200, 20);
            this.nUMTextBox.TabIndex = 4;
            // 
            // lNAMELabel
            // 
            lNAMELabel.AutoSize = true;
            lNAMELabel.Location = new System.Drawing.Point(336, 117);
            lNAMELabel.Name = "lNAMELabel";
            lNAMELabel.Size = new System.Drawing.Size(47, 13);
            lNAMELabel.TabIndex = 5;
            lNAMELabel.Text = "LNAME:";
            // 
            // lNAMETextBox
            // 
            this.lNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "LNAME", true));
            this.lNAMETextBox.Location = new System.Drawing.Point(407, 114);
            this.lNAMETextBox.Name = "lNAMETextBox";
            this.lNAMETextBox.Size = new System.Drawing.Size(200, 20);
            this.lNAMETextBox.TabIndex = 6;
            // 
            // fNAMELabel
            // 
            fNAMELabel.AutoSize = true;
            fNAMELabel.Location = new System.Drawing.Point(336, 143);
            fNAMELabel.Name = "fNAMELabel";
            fNAMELabel.Size = new System.Drawing.Size(47, 13);
            fNAMELabel.TabIndex = 7;
            fNAMELabel.Text = "FNAME:";
            // 
            // fNAMETextBox
            // 
            this.fNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "FNAME", true));
            this.fNAMETextBox.Location = new System.Drawing.Point(407, 140);
            this.fNAMETextBox.Name = "fNAMETextBox";
            this.fNAMETextBox.Size = new System.Drawing.Size(200, 20);
            this.fNAMETextBox.TabIndex = 8;
            // 
            // sNAMELabel
            // 
            sNAMELabel.AutoSize = true;
            sNAMELabel.Location = new System.Drawing.Point(336, 169);
            sNAMELabel.Name = "sNAMELabel";
            sNAMELabel.Size = new System.Drawing.Size(48, 13);
            sNAMELabel.TabIndex = 9;
            sNAMELabel.Text = "SNAME:";
            // 
            // sNAMETextBox
            // 
            this.sNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "SNAME", true));
            this.sNAMETextBox.Location = new System.Drawing.Point(407, 166);
            this.sNAMETextBox.Name = "sNAMETextBox";
            this.sNAMETextBox.Size = new System.Drawing.Size(200, 20);
            this.sNAMETextBox.TabIndex = 10;
            // 
            // bDAYLabel
            // 
            bDAYLabel.AutoSize = true;
            bDAYLabel.Location = new System.Drawing.Point(336, 196);
            bDAYLabel.Name = "bDAYLabel";
            bDAYLabel.Size = new System.Drawing.Size(39, 13);
            bDAYLabel.TabIndex = 11;
            bDAYLabel.Text = "BDAY:";
            // 
            // bDAYDateTimePicker
            // 
            this.bDAYDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pERSONALBindingSource, "BDAY", true));
            this.bDAYDateTimePicker.Location = new System.Drawing.Point(407, 192);
            this.bDAYDateTimePicker.Name = "bDAYDateTimePicker";
            this.bDAYDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.bDAYDateTimePicker.TabIndex = 12;
            // 
            // pOSTLabel
            // 
            pOSTLabel.AutoSize = true;
            pOSTLabel.Location = new System.Drawing.Point(336, 221);
            pOSTLabel.Name = "pOSTLabel";
            pOSTLabel.Size = new System.Drawing.Size(39, 13);
            pOSTLabel.TabIndex = 13;
            pOSTLabel.Text = "POST:";
            // 
            // pOSTTextBox
            // 
            this.pOSTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "POST", true));
            this.pOSTTextBox.Location = new System.Drawing.Point(407, 218);
            this.pOSTTextBox.Name = "pOSTTextBox";
            this.pOSTTextBox.Size = new System.Drawing.Size(200, 20);
            this.pOSTTextBox.TabIndex = 14;
            // 
            // aDRESLabel
            // 
            aDRESLabel.AutoSize = true;
            aDRESLabel.Location = new System.Drawing.Point(336, 247);
            aDRESLabel.Name = "aDRESLabel";
            aDRESLabel.Size = new System.Drawing.Size(47, 13);
            aDRESLabel.TabIndex = 15;
            aDRESLabel.Text = "ADRES:";
            // 
            // aDRESTextBox
            // 
            this.aDRESTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "ADRES", true));
            this.aDRESTextBox.Location = new System.Drawing.Point(407, 244);
            this.aDRESTextBox.Name = "aDRESTextBox";
            this.aDRESTextBox.Size = new System.Drawing.Size(200, 20);
            this.aDRESTextBox.TabIndex = 16;
            // 
            // pHONELabel
            // 
            pHONELabel.AutoSize = true;
            pHONELabel.Location = new System.Drawing.Point(336, 273);
            pHONELabel.Name = "pHONELabel";
            pHONELabel.Size = new System.Drawing.Size(48, 13);
            pHONELabel.TabIndex = 17;
            pHONELabel.Text = "PHONE:";
            // 
            // pHONETextBox
            // 
            this.pHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "PHONE", true));
            this.pHONETextBox.Location = new System.Drawing.Point(407, 270);
            this.pHONETextBox.Name = "pHONETextBox";
            this.pHONETextBox.Size = new System.Drawing.Size(200, 20);
            this.pHONETextBox.TabIndex = 18;
            // 
            // pAYLabel
            // 
            pAYLabel.AutoSize = true;
            pAYLabel.Location = new System.Drawing.Point(336, 299);
            pAYLabel.Name = "pAYLabel";
            pAYLabel.Size = new System.Drawing.Size(31, 13);
            pAYLabel.TabIndex = 19;
            pAYLabel.Text = "PAY:";
            // 
            // pAYTextBox
            // 
            this.pAYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "PAY", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.pAYTextBox.Location = new System.Drawing.Point(407, 296);
            this.pAYTextBox.Name = "pAYTextBox";
            this.pAYTextBox.Size = new System.Drawing.Size(200, 20);
            this.pAYTextBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 507);
            this.Controls.Add(nUMLabel);
            this.Controls.Add(this.nUMTextBox);
            this.Controls.Add(lNAMELabel);
            this.Controls.Add(this.lNAMETextBox);
            this.Controls.Add(fNAMELabel);
            this.Controls.Add(this.fNAMETextBox);
            this.Controls.Add(sNAMELabel);
            this.Controls.Add(this.sNAMETextBox);
            this.Controls.Add(bDAYLabel);
            this.Controls.Add(this.bDAYDateTimePicker);
            this.Controls.Add(pOSTLabel);
            this.Controls.Add(this.pOSTTextBox);
            this.Controls.Add(aDRESLabel);
            this.Controls.Add(this.aDRESTextBox);
            this.Controls.Add(pHONELabel);
            this.Controls.Add(this.pHONETextBox);
            this.Controls.Add(pAYLabel);
            this.Controls.Add(this.pAYTextBox);
            this.Controls.Add(this.pERSONALDataGridView);
            this.Controls.Add(this.pERSONALBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FromClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONALBindingNavigator)).EndInit();
            this.pERSONALBindingNavigator.ResumeLayout(false);
            this.pERSONALBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONALDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pERSONALBindingSource;
        private DataSet1TableAdapters.PERSONALTableAdapter pERSONALTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pERSONALBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pERSONALBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pERSONALDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem образованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TextBox nUMTextBox;
        private System.Windows.Forms.TextBox lNAMETextBox;
        private System.Windows.Forms.TextBox fNAMETextBox;
        private System.Windows.Forms.TextBox sNAMETextBox;
        private System.Windows.Forms.DateTimePicker bDAYDateTimePicker;
        private System.Windows.Forms.TextBox pOSTTextBox;
        private System.Windows.Forms.TextBox aDRESTextBox;
        private System.Windows.Forms.TextBox pHONETextBox;
        private System.Windows.Forms.TextBox pAYTextBox;
    }
}


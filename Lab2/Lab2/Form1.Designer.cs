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
            System.Windows.Forms.Label nUMLabel;
            System.Windows.Forms.Label lNAMELabel;
            System.Windows.Forms.Label fNAMELabel;
            System.Windows.Forms.Label sNAMELabel;
            System.Windows.Forms.Label bDAYLabel;
            System.Windows.Forms.Label pOSTLabel;
            System.Windows.Forms.Label aDRESLabel;
            System.Windows.Forms.Label pHONELabel;
            System.Windows.Forms.Label pAYLabel;
            System.Windows.Forms.Label mARITALLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.mARITALComboBox = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dEPARTMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPARTMENTTableAdapter = new Lab2.DataSet1TableAdapters.DEPARTMENTTableAdapter();
            nUMLabel = new System.Windows.Forms.Label();
            lNAMELabel = new System.Windows.Forms.Label();
            fNAMELabel = new System.Windows.Forms.Label();
            sNAMELabel = new System.Windows.Forms.Label();
            bDAYLabel = new System.Windows.Forms.Label();
            pOSTLabel = new System.Windows.Forms.Label();
            aDRESLabel = new System.Windows.Forms.Label();
            pHONELabel = new System.Windows.Forms.Label();
            pAYLabel = new System.Windows.Forms.Label();
            mARITALLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONALBindingNavigator)).BeginInit();
            this.pERSONALBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONALDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nUMLabel
            // 
            nUMLabel.AutoSize = true;
            nUMLabel.Location = new System.Drawing.Point(306, 88);
            nUMLabel.Name = "nUMLabel";
            nUMLabel.Size = new System.Drawing.Size(44, 13);
            nUMLabel.TabIndex = 3;
            nUMLabel.Text = "Номер:";
            // 
            // lNAMELabel
            // 
            lNAMELabel.AutoSize = true;
            lNAMELabel.Location = new System.Drawing.Point(306, 114);
            lNAMELabel.Name = "lNAMELabel";
            lNAMELabel.Size = new System.Drawing.Size(59, 13);
            lNAMELabel.TabIndex = 5;
            lNAMELabel.Text = "Фамилия:";
            // 
            // fNAMELabel
            // 
            fNAMELabel.AutoSize = true;
            fNAMELabel.Location = new System.Drawing.Point(306, 143);
            fNAMELabel.Name = "fNAMELabel";
            fNAMELabel.Size = new System.Drawing.Size(32, 13);
            fNAMELabel.TabIndex = 7;
            fNAMELabel.Text = "Имя:";
            // 
            // sNAMELabel
            // 
            sNAMELabel.AutoSize = true;
            sNAMELabel.Location = new System.Drawing.Point(306, 173);
            sNAMELabel.Name = "sNAMELabel";
            sNAMELabel.Size = new System.Drawing.Size(57, 13);
            sNAMELabel.TabIndex = 9;
            sNAMELabel.Text = "Отчество:";
            // 
            // bDAYLabel
            // 
            bDAYLabel.AutoSize = true;
            bDAYLabel.Location = new System.Drawing.Point(306, 198);
            bDAYLabel.Name = "bDAYLabel";
            bDAYLabel.Size = new System.Drawing.Size(89, 13);
            bDAYLabel.TabIndex = 11;
            bDAYLabel.Text = "Дата рождения:";
            // 
            // pOSTLabel
            // 
            pOSTLabel.AutoSize = true;
            pOSTLabel.Location = new System.Drawing.Point(306, 221);
            pOSTLabel.Name = "pOSTLabel";
            pOSTLabel.Size = new System.Drawing.Size(68, 13);
            pOSTLabel.TabIndex = 13;
            pOSTLabel.Text = "Должность:";
            // 
            // aDRESLabel
            // 
            aDRESLabel.AutoSize = true;
            aDRESLabel.Location = new System.Drawing.Point(306, 247);
            aDRESLabel.Name = "aDRESLabel";
            aDRESLabel.Size = new System.Drawing.Size(41, 13);
            aDRESLabel.TabIndex = 15;
            aDRESLabel.Text = "Адрес:";
            // 
            // pHONELabel
            // 
            pHONELabel.AutoSize = true;
            pHONELabel.Location = new System.Drawing.Point(306, 323);
            pHONELabel.Name = "pHONELabel";
            pHONELabel.Size = new System.Drawing.Size(55, 13);
            pHONELabel.TabIndex = 17;
            pHONELabel.Text = "Телефон:";
            // 
            // pAYLabel
            // 
            pAYLabel.AutoSize = true;
            pAYLabel.Location = new System.Drawing.Point(307, 349);
            pAYLabel.Name = "pAYLabel";
            pAYLabel.Size = new System.Drawing.Size(42, 13);
            pAYLabel.TabIndex = 19;
            pAYLabel.Text = "Оклад:";
            // 
            // mARITALLabel
            // 
            mARITALLabel.AutoSize = true;
            mARITALLabel.Location = new System.Drawing.Point(306, 391);
            mARITALLabel.Name = "mARITALLabel";
            mARITALLabel.Size = new System.Drawing.Size(66, 13);
            mARITALLabel.TabIndex = 21;
            mARITALLabel.Text = "положение:";
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
            this.pERSONALBindingNavigator.CountItemFormat = "из {0}";
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
            this.bindingNavigatorAddNewItem.ToolTipText = "Добавить новую запись";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
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
            this.bindingNavigatorDeleteItem.ToolTipText = "Удалить выбранную запись";
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
            this.pERSONALBindingNavigatorSaveItem.ToolTipText = "Сохранить изменения";
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
            this.отделыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.отделыToolStripMenuItem.Text = "Отделы";
            this.отделыToolStripMenuItem.Click += new System.EventHandler(this.отделыToolStripMenuItem_Click);
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
            // nUMTextBox
            // 
            this.nUMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "NUM", true));
            this.nUMTextBox.Location = new System.Drawing.Point(407, 88);
            this.nUMTextBox.Name = "nUMTextBox";
            this.nUMTextBox.Size = new System.Drawing.Size(200, 20);
            this.nUMTextBox.TabIndex = 4;
            // 
            // lNAMETextBox
            // 
            this.lNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "LNAME", true));
            this.lNAMETextBox.Location = new System.Drawing.Point(407, 114);
            this.lNAMETextBox.Name = "lNAMETextBox";
            this.lNAMETextBox.Size = new System.Drawing.Size(200, 20);
            this.lNAMETextBox.TabIndex = 6;
            // 
            // fNAMETextBox
            // 
            this.fNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "FNAME", true));
            this.fNAMETextBox.Location = new System.Drawing.Point(407, 140);
            this.fNAMETextBox.Name = "fNAMETextBox";
            this.fNAMETextBox.Size = new System.Drawing.Size(200, 20);
            this.fNAMETextBox.TabIndex = 8;
            // 
            // sNAMETextBox
            // 
            this.sNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "SNAME", true));
            this.sNAMETextBox.Location = new System.Drawing.Point(407, 166);
            this.sNAMETextBox.Name = "sNAMETextBox";
            this.sNAMETextBox.Size = new System.Drawing.Size(200, 20);
            this.sNAMETextBox.TabIndex = 10;
            // 
            // bDAYDateTimePicker
            // 
            this.bDAYDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pERSONALBindingSource, "BDAY", true));
            this.bDAYDateTimePicker.Location = new System.Drawing.Point(407, 192);
            this.bDAYDateTimePicker.Name = "bDAYDateTimePicker";
            this.bDAYDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.bDAYDateTimePicker.TabIndex = 12;
            // 
            // pOSTTextBox
            // 
            this.pOSTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "POST", true));
            this.pOSTTextBox.Location = new System.Drawing.Point(407, 218);
            this.pOSTTextBox.Name = "pOSTTextBox";
            this.pOSTTextBox.Size = new System.Drawing.Size(200, 20);
            this.pOSTTextBox.TabIndex = 14;
            // 
            // aDRESTextBox
            // 
            this.aDRESTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "ADRES", true));
            this.aDRESTextBox.Location = new System.Drawing.Point(407, 247);
            this.aDRESTextBox.Multiline = true;
            this.aDRESTextBox.Name = "aDRESTextBox";
            this.aDRESTextBox.Size = new System.Drawing.Size(200, 67);
            this.aDRESTextBox.TabIndex = 16;
            // 
            // pHONETextBox
            // 
            this.pHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "PHONE", true));
            this.pHONETextBox.Location = new System.Drawing.Point(407, 320);
            this.pHONETextBox.Name = "pHONETextBox";
            this.pHONETextBox.Size = new System.Drawing.Size(200, 20);
            this.pHONETextBox.TabIndex = 18;
            // 
            // pAYTextBox
            // 
            this.pAYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "PAY", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.pAYTextBox.Location = new System.Drawing.Point(407, 346);
            this.pAYTextBox.Name = "pAYTextBox";
            this.pAYTextBox.Size = new System.Drawing.Size(200, 20);
            this.pAYTextBox.TabIndex = 20;
            // 
            // mARITALComboBox
            // 
            this.mARITALComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pERSONALBindingSource, "MARITAL", true));
            this.mARITALComboBox.FormattingEnabled = true;
            this.mARITALComboBox.Items.AddRange(new object[] {
            "женат",
            "замужем",
            "не женат",
            "не замужем"});
            this.mARITALComboBox.Location = new System.Drawing.Point(407, 388);
            this.mARITALComboBox.Name = "mARITALComboBox";
            this.mARITALComboBox.Size = new System.Drawing.Size(121, 21);
            this.mARITALComboBox.TabIndex = 22;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pERSONALBindingSource, "CHILD", true));
            this.checkBox1.Location = new System.Drawing.Point(407, 415);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Есть дети:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Семейное";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pERSONALBindingSource, "DEP_CODE", true));
            this.comboBox1.DataSource = this.dEPARTMENTBindingSource;
            this.comboBox1.DisplayMember = "NAME";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(407, 453);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.ValueMember = "ID";
            // 
            // dEPARTMENTBindingSource
            // 
            this.dEPARTMENTBindingSource.DataMember = "DEPARTMENT";
            this.dEPARTMENTBindingSource.DataSource = this.dataSet1;
            // 
            // dEPARTMENTTableAdapter
            // 
            this.dEPARTMENTTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 507);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(mARITALLabel);
            this.Controls.Add(this.mARITALComboBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox mARITALComboBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource dEPARTMENTBindingSource;
        private DataSet1TableAdapters.DEPARTMENTTableAdapter dEPARTMENTTableAdapter;
    }
}


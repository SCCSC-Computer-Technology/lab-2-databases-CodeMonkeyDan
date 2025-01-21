namespace DSchiefer_Lab_1_Population_Database
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
            this.cityPopulationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.cityPopulationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityPopulationDBDataSet = new DSchiefer_Lab_1_Population_Database.CityPopulationDBDataSet();
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
            this.cityPopulationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cityPopulationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleLbl = new System.Windows.Forms.Label();
            this.cityPopulationTableAdapter = new DSchiefer_Lab_1_Population_Database.CityPopulationDBDataSetTableAdapters.CityPopulationTableAdapter();
            this.tableAdapterManager = new DSchiefer_Lab_1_Population_Database.CityPopulationDBDataSetTableAdapters.TableAdapterManager();
            this.displayGrpBx = new System.Windows.Forms.GroupBox();
            this.totalPopulationRdBtn = new System.Windows.Forms.RadioButton();
            this.averagePopulationRdBtn = new System.Windows.Forms.RadioButton();
            this.minPopulationRdBtn = new System.Windows.Forms.RadioButton();
            this.maxPopulationRdBtn = new System.Windows.Forms.RadioButton();
            this.numberOfCitiesRdBtn = new System.Windows.Forms.RadioButton();
            this.displayBtn = new System.Windows.Forms.Button();
            this.searchGrpBx = new System.Windows.Forms.GroupBox();
            this.searchTxtBx = new System.Windows.Forms.TextBox();
            this.stateSearchRdBtn = new System.Windows.Forms.RadioButton();
            this.countrySearchRdBtn = new System.Windows.Forms.RadioButton();
            this.citySearchRdBtn = new System.Windows.Forms.RadioButton();
            this.searchBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.sortByGrpBx = new System.Windows.Forms.GroupBox();
            this.sortBtn = new System.Windows.Forms.Button();
            this.sortByOrderGrpBx = new System.Windows.Forms.GroupBox();
            this.descendingSortRdBtn = new System.Windows.Forms.RadioButton();
            this.ascendingSortRdBtn = new System.Windows.Forms.RadioButton();
            this.sortByFieldGrpBx = new System.Windows.Forms.GroupBox();
            this.populationSortRdBtn = new System.Windows.Forms.RadioButton();
            this.countrySortRdBtn = new System.Windows.Forms.RadioButton();
            this.stateSortRdBtn = new System.Windows.Forms.RadioButton();
            this.citySortRdBtn = new System.Windows.Forms.RadioButton();
            this.cityIDSortRdBtn = new System.Windows.Forms.RadioButton();
            this.resetBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cityPopulationBindingNavigator)).BeginInit();
            this.cityPopulationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityPopulationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityPopulationDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityPopulationDataGridView)).BeginInit();
            this.displayGrpBx.SuspendLayout();
            this.searchGrpBx.SuspendLayout();
            this.sortByGrpBx.SuspendLayout();
            this.sortByOrderGrpBx.SuspendLayout();
            this.sortByFieldGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // cityPopulationBindingNavigator
            // 
            this.cityPopulationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cityPopulationBindingNavigator.BindingSource = this.cityPopulationBindingSource;
            this.cityPopulationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cityPopulationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cityPopulationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cityPopulationBindingNavigatorSaveItem});
            this.cityPopulationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cityPopulationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cityPopulationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cityPopulationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cityPopulationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cityPopulationBindingNavigator.Name = "cityPopulationBindingNavigator";
            this.cityPopulationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cityPopulationBindingNavigator.Size = new System.Drawing.Size(902, 25);
            this.cityPopulationBindingNavigator.TabIndex = 0;
            this.cityPopulationBindingNavigator.Text = "bindingNavigator1";
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
            // cityPopulationBindingSource
            // 
            this.cityPopulationBindingSource.DataMember = "CityPopulation";
            this.cityPopulationBindingSource.DataSource = this.cityPopulationDBDataSet;
            // 
            // cityPopulationDBDataSet
            // 
            this.cityPopulationDBDataSet.DataSetName = "CityPopulationDBDataSet";
            this.cityPopulationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // cityPopulationBindingNavigatorSaveItem
            // 
            this.cityPopulationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cityPopulationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cityPopulationBindingNavigatorSaveItem.Image")));
            this.cityPopulationBindingNavigatorSaveItem.Name = "cityPopulationBindingNavigatorSaveItem";
            this.cityPopulationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cityPopulationBindingNavigatorSaveItem.Text = "Save Data";
            this.cityPopulationBindingNavigatorSaveItem.Click += new System.EventHandler(this.cityPopulationBindingNavigatorSaveItem_Click);
            // 
            // cityPopulationDataGridView
            // 
            this.cityPopulationDataGridView.AutoGenerateColumns = false;
            this.cityPopulationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityPopulationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.cityPopulationDataGridView.DataSource = this.cityPopulationBindingSource;
            this.cityPopulationDataGridView.Location = new System.Drawing.Point(50, 81);
            this.cityPopulationDataGridView.Name = "cityPopulationDataGridView";
            this.cityPopulationDataGridView.Size = new System.Drawing.Size(562, 250);
            this.cityPopulationDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CityID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CityID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn2.HeaderText = "City";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn3.HeaderText = "State";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn4.HeaderText = "Country";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn5.HeaderText = "Population";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(299, 44);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(306, 22);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "City Population Data Analyzer";
            // 
            // cityPopulationTableAdapter
            // 
            this.cityPopulationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityPopulationTableAdapter = this.cityPopulationTableAdapter;
            this.tableAdapterManager.UpdateOrder = DSchiefer_Lab_1_Population_Database.CityPopulationDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // displayGrpBx
            // 
            this.displayGrpBx.Controls.Add(this.totalPopulationRdBtn);
            this.displayGrpBx.Controls.Add(this.averagePopulationRdBtn);
            this.displayGrpBx.Controls.Add(this.minPopulationRdBtn);
            this.displayGrpBx.Controls.Add(this.maxPopulationRdBtn);
            this.displayGrpBx.Controls.Add(this.numberOfCitiesRdBtn);
            this.displayGrpBx.Controls.Add(this.displayBtn);
            this.displayGrpBx.Location = new System.Drawing.Point(640, 81);
            this.displayGrpBx.Name = "displayGrpBx";
            this.displayGrpBx.Size = new System.Drawing.Size(215, 228);
            this.displayGrpBx.TabIndex = 3;
            this.displayGrpBx.TabStop = false;
            this.displayGrpBx.Text = "Stats";
            // 
            // totalPopulationRdBtn
            // 
            this.totalPopulationRdBtn.AutoSize = true;
            this.totalPopulationRdBtn.Location = new System.Drawing.Point(35, 62);
            this.totalPopulationRdBtn.Name = "totalPopulationRdBtn";
            this.totalPopulationRdBtn.Size = new System.Drawing.Size(132, 22);
            this.totalPopulationRdBtn.TabIndex = 5;
            this.totalPopulationRdBtn.TabStop = true;
            this.totalPopulationRdBtn.Text = "Total Population";
            this.totalPopulationRdBtn.UseVisualStyleBackColor = true;
            // 
            // averagePopulationRdBtn
            // 
            this.averagePopulationRdBtn.AutoSize = true;
            this.averagePopulationRdBtn.Location = new System.Drawing.Point(35, 90);
            this.averagePopulationRdBtn.Name = "averagePopulationRdBtn";
            this.averagePopulationRdBtn.Size = new System.Drawing.Size(152, 22);
            this.averagePopulationRdBtn.TabIndex = 4;
            this.averagePopulationRdBtn.TabStop = true;
            this.averagePopulationRdBtn.Text = "Average Population";
            this.averagePopulationRdBtn.UseVisualStyleBackColor = true;
            // 
            // minPopulationRdBtn
            // 
            this.minPopulationRdBtn.AutoSize = true;
            this.minPopulationRdBtn.Location = new System.Drawing.Point(35, 146);
            this.minPopulationRdBtn.Name = "minPopulationRdBtn";
            this.minPopulationRdBtn.Size = new System.Drawing.Size(125, 22);
            this.minPopulationRdBtn.TabIndex = 3;
            this.minPopulationRdBtn.TabStop = true;
            this.minPopulationRdBtn.Text = "Min Population";
            this.minPopulationRdBtn.UseVisualStyleBackColor = true;
            // 
            // maxPopulationRdBtn
            // 
            this.maxPopulationRdBtn.AutoSize = true;
            this.maxPopulationRdBtn.Location = new System.Drawing.Point(35, 118);
            this.maxPopulationRdBtn.Name = "maxPopulationRdBtn";
            this.maxPopulationRdBtn.Size = new System.Drawing.Size(126, 22);
            this.maxPopulationRdBtn.TabIndex = 2;
            this.maxPopulationRdBtn.TabStop = true;
            this.maxPopulationRdBtn.Text = "Max Population";
            this.maxPopulationRdBtn.UseVisualStyleBackColor = true;
            // 
            // numberOfCitiesRdBtn
            // 
            this.numberOfCitiesRdBtn.AutoSize = true;
            this.numberOfCitiesRdBtn.Location = new System.Drawing.Point(35, 34);
            this.numberOfCitiesRdBtn.Name = "numberOfCitiesRdBtn";
            this.numberOfCitiesRdBtn.Size = new System.Drawing.Size(138, 22);
            this.numberOfCitiesRdBtn.TabIndex = 1;
            this.numberOfCitiesRdBtn.TabStop = true;
            this.numberOfCitiesRdBtn.Text = "Number of Cities";
            this.numberOfCitiesRdBtn.UseVisualStyleBackColor = true;
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(64, 187);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(87, 27);
            this.displayBtn.TabIndex = 0;
            this.displayBtn.Text = "&Display";
            this.toolTip1.SetToolTip(this.displayBtn, "Click to display stats");
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // searchGrpBx
            // 
            this.searchGrpBx.Controls.Add(this.searchTxtBx);
            this.searchGrpBx.Controls.Add(this.stateSearchRdBtn);
            this.searchGrpBx.Controls.Add(this.countrySearchRdBtn);
            this.searchGrpBx.Controls.Add(this.citySearchRdBtn);
            this.searchGrpBx.Controls.Add(this.searchBtn);
            this.searchGrpBx.Location = new System.Drawing.Point(525, 348);
            this.searchGrpBx.Name = "searchGrpBx";
            this.searchGrpBx.Size = new System.Drawing.Size(330, 185);
            this.searchGrpBx.TabIndex = 4;
            this.searchGrpBx.TabStop = false;
            this.searchGrpBx.Text = "Search By";
            // 
            // searchTxtBx
            // 
            this.searchTxtBx.Location = new System.Drawing.Point(18, 51);
            this.searchTxtBx.Name = "searchTxtBx";
            this.searchTxtBx.Size = new System.Drawing.Size(294, 23);
            this.searchTxtBx.TabIndex = 5;
            // 
            // stateSearchRdBtn
            // 
            this.stateSearchRdBtn.AutoSize = true;
            this.stateSearchRdBtn.Location = new System.Drawing.Point(130, 99);
            this.stateSearchRdBtn.Name = "stateSearchRdBtn";
            this.stateSearchRdBtn.Size = new System.Drawing.Size(61, 22);
            this.stateSearchRdBtn.TabIndex = 4;
            this.stateSearchRdBtn.TabStop = true;
            this.stateSearchRdBtn.Text = "State";
            this.stateSearchRdBtn.UseVisualStyleBackColor = true;
            // 
            // countrySearchRdBtn
            // 
            this.countrySearchRdBtn.AutoSize = true;
            this.countrySearchRdBtn.Location = new System.Drawing.Point(227, 99);
            this.countrySearchRdBtn.Name = "countrySearchRdBtn";
            this.countrySearchRdBtn.Size = new System.Drawing.Size(79, 22);
            this.countrySearchRdBtn.TabIndex = 3;
            this.countrySearchRdBtn.TabStop = true;
            this.countrySearchRdBtn.Text = "Country";
            this.countrySearchRdBtn.UseVisualStyleBackColor = true;
            // 
            // citySearchRdBtn
            // 
            this.citySearchRdBtn.AutoSize = true;
            this.citySearchRdBtn.Location = new System.Drawing.Point(18, 99);
            this.citySearchRdBtn.Name = "citySearchRdBtn";
            this.citySearchRdBtn.Size = new System.Drawing.Size(53, 22);
            this.citySearchRdBtn.TabIndex = 2;
            this.citySearchRdBtn.TabStop = true;
            this.citySearchRdBtn.Text = "City";
            this.citySearchRdBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(130, 142);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(87, 27);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "&Search";
            this.toolTip1.SetToolTip(this.searchBtn, "Click to search for data");
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(474, 549);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(87, 27);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitBtn, "Click to exit program");
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // sortByGrpBx
            // 
            this.sortByGrpBx.Controls.Add(this.sortBtn);
            this.sortByGrpBx.Controls.Add(this.sortByOrderGrpBx);
            this.sortByGrpBx.Controls.Add(this.sortByFieldGrpBx);
            this.sortByGrpBx.Location = new System.Drawing.Point(50, 348);
            this.sortByGrpBx.Name = "sortByGrpBx";
            this.sortByGrpBx.Size = new System.Drawing.Size(421, 185);
            this.sortByGrpBx.TabIndex = 6;
            this.sortByGrpBx.TabStop = false;
            this.sortByGrpBx.Text = "Sort By";
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(174, 142);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(87, 27);
            this.sortBtn.TabIndex = 2;
            this.sortBtn.Text = "Sor&t";
            this.toolTip1.SetToolTip(this.sortBtn, "Click to sort data");
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // sortByOrderGrpBx
            // 
            this.sortByOrderGrpBx.Controls.Add(this.descendingSortRdBtn);
            this.sortByOrderGrpBx.Controls.Add(this.ascendingSortRdBtn);
            this.sortByOrderGrpBx.Location = new System.Drawing.Point(281, 27);
            this.sortByOrderGrpBx.Name = "sortByOrderGrpBx";
            this.sortByOrderGrpBx.Size = new System.Drawing.Size(116, 106);
            this.sortByOrderGrpBx.TabIndex = 1;
            this.sortByOrderGrpBx.TabStop = false;
            this.sortByOrderGrpBx.Text = "Order";
            // 
            // descendingSortRdBtn
            // 
            this.descendingSortRdBtn.AutoSize = true;
            this.descendingSortRdBtn.Location = new System.Drawing.Point(10, 69);
            this.descendingSortRdBtn.Name = "descendingSortRdBtn";
            this.descendingSortRdBtn.Size = new System.Drawing.Size(103, 22);
            this.descendingSortRdBtn.TabIndex = 1;
            this.descendingSortRdBtn.TabStop = true;
            this.descendingSortRdBtn.Text = "Descending";
            this.descendingSortRdBtn.UseVisualStyleBackColor = true;
            // 
            // ascendingSortRdBtn
            // 
            this.ascendingSortRdBtn.AutoSize = true;
            this.ascendingSortRdBtn.Location = new System.Drawing.Point(10, 33);
            this.ascendingSortRdBtn.Name = "ascendingSortRdBtn";
            this.ascendingSortRdBtn.Size = new System.Drawing.Size(94, 22);
            this.ascendingSortRdBtn.TabIndex = 0;
            this.ascendingSortRdBtn.TabStop = true;
            this.ascendingSortRdBtn.Text = "Ascending";
            this.ascendingSortRdBtn.UseVisualStyleBackColor = true;
            // 
            // sortByFieldGrpBx
            // 
            this.sortByFieldGrpBx.Controls.Add(this.populationSortRdBtn);
            this.sortByFieldGrpBx.Controls.Add(this.countrySortRdBtn);
            this.sortByFieldGrpBx.Controls.Add(this.stateSortRdBtn);
            this.sortByFieldGrpBx.Controls.Add(this.citySortRdBtn);
            this.sortByFieldGrpBx.Controls.Add(this.cityIDSortRdBtn);
            this.sortByFieldGrpBx.Location = new System.Drawing.Point(21, 27);
            this.sortByFieldGrpBx.Name = "sortByFieldGrpBx";
            this.sortByFieldGrpBx.Size = new System.Drawing.Size(240, 106);
            this.sortByFieldGrpBx.TabIndex = 0;
            this.sortByFieldGrpBx.TabStop = false;
            this.sortByFieldGrpBx.Text = "Field";
            // 
            // populationSortRdBtn
            // 
            this.populationSortRdBtn.AutoSize = true;
            this.populationSortRdBtn.Location = new System.Drawing.Point(123, 69);
            this.populationSortRdBtn.Name = "populationSortRdBtn";
            this.populationSortRdBtn.Size = new System.Drawing.Size(95, 22);
            this.populationSortRdBtn.TabIndex = 4;
            this.populationSortRdBtn.TabStop = true;
            this.populationSortRdBtn.Text = "Population";
            this.populationSortRdBtn.UseVisualStyleBackColor = true;
            // 
            // countrySortRdBtn
            // 
            this.countrySortRdBtn.AutoSize = true;
            this.countrySortRdBtn.Location = new System.Drawing.Point(27, 69);
            this.countrySortRdBtn.Name = "countrySortRdBtn";
            this.countrySortRdBtn.Size = new System.Drawing.Size(79, 22);
            this.countrySortRdBtn.TabIndex = 3;
            this.countrySortRdBtn.TabStop = true;
            this.countrySortRdBtn.Text = "Country";
            this.countrySortRdBtn.UseVisualStyleBackColor = true;
            // 
            // stateSortRdBtn
            // 
            this.stateSortRdBtn.AutoSize = true;
            this.stateSortRdBtn.Location = new System.Drawing.Point(166, 33);
            this.stateSortRdBtn.Name = "stateSortRdBtn";
            this.stateSortRdBtn.Size = new System.Drawing.Size(61, 22);
            this.stateSortRdBtn.TabIndex = 2;
            this.stateSortRdBtn.TabStop = true;
            this.stateSortRdBtn.Text = "State";
            this.stateSortRdBtn.UseVisualStyleBackColor = true;
            // 
            // citySortRdBtn
            // 
            this.citySortRdBtn.AutoSize = true;
            this.citySortRdBtn.Location = new System.Drawing.Point(98, 33);
            this.citySortRdBtn.Name = "citySortRdBtn";
            this.citySortRdBtn.Size = new System.Drawing.Size(53, 22);
            this.citySortRdBtn.TabIndex = 1;
            this.citySortRdBtn.TabStop = true;
            this.citySortRdBtn.Text = "City";
            this.citySortRdBtn.UseVisualStyleBackColor = true;
            // 
            // cityIDSortRdBtn
            // 
            this.cityIDSortRdBtn.AutoSize = true;
            this.cityIDSortRdBtn.Location = new System.Drawing.Point(18, 33);
            this.cityIDSortRdBtn.Name = "cityIDSortRdBtn";
            this.cityIDSortRdBtn.Size = new System.Drawing.Size(68, 22);
            this.cityIDSortRdBtn.TabIndex = 0;
            this.cityIDSortRdBtn.TabStop = true;
            this.cityIDSortRdBtn.Text = "CityID";
            this.cityIDSortRdBtn.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(338, 549);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(87, 27);
            this.resetBtn.TabIndex = 7;
            this.resetBtn.Text = "&Reset";
            this.toolTip1.SetToolTip(this.resetBtn, "Click to reset form");
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(902, 594);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.sortByGrpBx);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.searchGrpBx);
            this.Controls.Add(this.displayGrpBx);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.cityPopulationDataGridView);
            this.Controls.Add(this.cityPopulationBindingNavigator);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSchiefer Lab #2 - Population Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityPopulationBindingNavigator)).EndInit();
            this.cityPopulationBindingNavigator.ResumeLayout(false);
            this.cityPopulationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityPopulationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityPopulationDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityPopulationDataGridView)).EndInit();
            this.displayGrpBx.ResumeLayout(false);
            this.displayGrpBx.PerformLayout();
            this.searchGrpBx.ResumeLayout(false);
            this.searchGrpBx.PerformLayout();
            this.sortByGrpBx.ResumeLayout(false);
            this.sortByOrderGrpBx.ResumeLayout(false);
            this.sortByOrderGrpBx.PerformLayout();
            this.sortByFieldGrpBx.ResumeLayout(false);
            this.sortByFieldGrpBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CityPopulationDBDataSet cityPopulationDBDataSet;
        private System.Windows.Forms.BindingSource cityPopulationBindingSource;
        private CityPopulationDBDataSetTableAdapters.CityPopulationTableAdapter cityPopulationTableAdapter;
        private CityPopulationDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cityPopulationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cityPopulationBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cityPopulationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.GroupBox displayGrpBx;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.RadioButton totalPopulationRdBtn;
        private System.Windows.Forms.RadioButton averagePopulationRdBtn;
        private System.Windows.Forms.RadioButton minPopulationRdBtn;
        private System.Windows.Forms.RadioButton maxPopulationRdBtn;
        private System.Windows.Forms.RadioButton numberOfCitiesRdBtn;
        private System.Windows.Forms.GroupBox searchGrpBx;
        private System.Windows.Forms.RadioButton stateSearchRdBtn;
        private System.Windows.Forms.RadioButton countrySearchRdBtn;
        private System.Windows.Forms.RadioButton citySearchRdBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTxtBx;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox sortByGrpBx;
        private System.Windows.Forms.GroupBox sortByFieldGrpBx;
        private System.Windows.Forms.RadioButton stateSortRdBtn;
        private System.Windows.Forms.RadioButton citySortRdBtn;
        private System.Windows.Forms.RadioButton cityIDSortRdBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.GroupBox sortByOrderGrpBx;
        private System.Windows.Forms.RadioButton descendingSortRdBtn;
        private System.Windows.Forms.RadioButton ascendingSortRdBtn;
        private System.Windows.Forms.RadioButton populationSortRdBtn;
        private System.Windows.Forms.RadioButton countrySortRdBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


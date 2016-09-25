namespace Fantasy_Football_Value
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.fantasy_FootballDataSet = new Fantasy_Football_Value.Fantasy_FootballDataSet();
            this.hybridFinalTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hybridFinalTableTableAdapter = new Fantasy_Football_Value.Fantasy_FootballDataSetTableAdapters.HybridFinalTableTableAdapter();
            this.tableAdapterManager = new Fantasy_Football_Value.Fantasy_FootballDataSetTableAdapters.TableAdapterManager();
            this.hybridFinalTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.hybridFinalTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hybridFinalTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.TargetPointsLabel = new System.Windows.Forms.Label();
            this.QbNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.QbLabel = new System.Windows.Forms.Label();
            this.RbLabel = new System.Windows.Forms.Label();
            this.WrLabel = new System.Windows.Forms.Label();
            this.TeLabel = new System.Windows.Forms.Label();
            this.KLabel = new System.Windows.Forms.Label();
            this.DStLabel = new System.Windows.Forms.Label();
            this.DStNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.KNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WrNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RbNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NumPlayersGroupBox = new System.Windows.Forms.GroupBox();
            this.FanDuelNumPositionsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.OptimizeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fantasy_FootballDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hybridFinalTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hybridFinalTableBindingNavigator)).BeginInit();
            this.hybridFinalTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hybridFinalTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QbNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DStNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WrNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RbNumericUpDown)).BeginInit();
            this.NumPlayersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fantasy_FootballDataSet
            // 
            this.fantasy_FootballDataSet.DataSetName = "Fantasy_FootballDataSet";
            this.fantasy_FootballDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hybridFinalTableBindingSource
            // 
            this.hybridFinalTableBindingSource.DataMember = "HybridFinalTable";
            this.hybridFinalTableBindingSource.DataSource = this.fantasy_FootballDataSet;
            // 
            // hybridFinalTableTableAdapter
            // 
            this.hybridFinalTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FANDUELTableAdapter = null;
            this.tableAdapterManager.FFAPROJECTIONSTableAdapter = null;
            this.tableAdapterManager.HybridDefenseTableTableAdapter = null;
            this.tableAdapterManager.HybridFinalTableTableAdapter = this.hybridFinalTableTableAdapter;
            this.tableAdapterManager.HybridPLayersTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Fantasy_Football_Value.Fantasy_FootballDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hybridFinalTableBindingNavigator
            // 
            this.hybridFinalTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hybridFinalTableBindingNavigator.BindingSource = this.hybridFinalTableBindingSource;
            this.hybridFinalTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hybridFinalTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hybridFinalTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hybridFinalTableBindingNavigatorSaveItem});
            this.hybridFinalTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hybridFinalTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hybridFinalTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hybridFinalTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hybridFinalTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hybridFinalTableBindingNavigator.Name = "hybridFinalTableBindingNavigator";
            this.hybridFinalTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hybridFinalTableBindingNavigator.Size = new System.Drawing.Size(923, 25);
            this.hybridFinalTableBindingNavigator.TabIndex = 0;
            this.hybridFinalTableBindingNavigator.Text = "bindingNavigator1";
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
            // hybridFinalTableBindingNavigatorSaveItem
            // 
            this.hybridFinalTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hybridFinalTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hybridFinalTableBindingNavigatorSaveItem.Image")));
            this.hybridFinalTableBindingNavigatorSaveItem.Name = "hybridFinalTableBindingNavigatorSaveItem";
            this.hybridFinalTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hybridFinalTableBindingNavigatorSaveItem.Text = "Save Data";
            this.hybridFinalTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.hybridFinalTableBindingNavigatorSaveItem_Click);
            // 
            // hybridFinalTableDataGridView
            // 
            this.hybridFinalTableDataGridView.AutoGenerateColumns = false;
            this.hybridFinalTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hybridFinalTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.hybridFinalTableDataGridView.DataSource = this.hybridFinalTableBindingSource;
            this.hybridFinalTableDataGridView.Location = new System.Drawing.Point(0, 28);
            this.hybridFinalTableDataGridView.Name = "hybridFinalTableDataGridView";
            this.hybridFinalTableDataGridView.Size = new System.Drawing.Size(710, 259);
            this.hybridFinalTableDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "First_Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "First_Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Last_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Last_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn3.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn4.HeaderText = "Position";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn5.HeaderText = "Team";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Points";
            this.dataGridViewTextBoxColumn6.HeaderText = "Points";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "$/Point";
            this.dataGridViewTextBoxColumn7.HeaderText = "$/Point";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(143, 309);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown1.TabIndex = 2;
            // 
            // TargetPointsLabel
            // 
            this.TargetPointsLabel.AutoSize = true;
            this.TargetPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetPointsLabel.Location = new System.Drawing.Point(12, 311);
            this.TargetPointsLabel.Name = "TargetPointsLabel";
            this.TargetPointsLabel.Size = new System.Drawing.Size(125, 24);
            this.TargetPointsLabel.TabIndex = 3;
            this.TargetPointsLabel.Text = "Target Points:";
            // 
            // QbNumericUpDown
            // 
            this.QbNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QbNumericUpDown.Location = new System.Drawing.Point(86, 20);
            this.QbNumericUpDown.Name = "QbNumericUpDown";
            this.QbNumericUpDown.Size = new System.Drawing.Size(46, 29);
            this.QbNumericUpDown.TabIndex = 4;
            this.QbNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // QbLabel
            // 
            this.QbLabel.AutoSize = true;
            this.QbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QbLabel.Location = new System.Drawing.Point(38, 22);
            this.QbLabel.Name = "QbLabel";
            this.QbLabel.Size = new System.Drawing.Size(42, 24);
            this.QbLabel.TabIndex = 11;
            this.QbLabel.Text = "QB:";
            // 
            // RbLabel
            // 
            this.RbLabel.AutoSize = true;
            this.RbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbLabel.Location = new System.Drawing.Point(40, 57);
            this.RbLabel.Name = "RbLabel";
            this.RbLabel.Size = new System.Drawing.Size(40, 24);
            this.RbLabel.TabIndex = 12;
            this.RbLabel.Text = "RB:";
            // 
            // WrLabel
            // 
            this.WrLabel.AutoSize = true;
            this.WrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrLabel.Location = new System.Drawing.Point(34, 92);
            this.WrLabel.Name = "WrLabel";
            this.WrLabel.Size = new System.Drawing.Size(46, 24);
            this.WrLabel.TabIndex = 13;
            this.WrLabel.Text = "WR:";
            // 
            // TeLabel
            // 
            this.TeLabel.AutoSize = true;
            this.TeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeLabel.Location = new System.Drawing.Point(40, 127);
            this.TeLabel.Name = "TeLabel";
            this.TeLabel.Size = new System.Drawing.Size(40, 24);
            this.TeLabel.TabIndex = 14;
            this.TeLabel.Text = "TE:";
            // 
            // KLabel
            // 
            this.KLabel.AutoSize = true;
            this.KLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KLabel.Location = new System.Drawing.Point(53, 162);
            this.KLabel.Name = "KLabel";
            this.KLabel.Size = new System.Drawing.Size(27, 24);
            this.KLabel.TabIndex = 15;
            this.KLabel.Text = "K:";
            // 
            // DStLabel
            // 
            this.DStLabel.AutoSize = true;
            this.DStLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DStLabel.Location = new System.Drawing.Point(23, 197);
            this.DStLabel.Name = "DStLabel";
            this.DStLabel.Size = new System.Drawing.Size(57, 24);
            this.DStLabel.TabIndex = 16;
            this.DStLabel.Text = "D/ST:";
            // 
            // DStNumericUpDown
            // 
            this.DStNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DStNumericUpDown.Location = new System.Drawing.Point(86, 195);
            this.DStNumericUpDown.Name = "DStNumericUpDown";
            this.DStNumericUpDown.Size = new System.Drawing.Size(46, 29);
            this.DStNumericUpDown.TabIndex = 17;
            this.DStNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // KNumericUpDown
            // 
            this.KNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KNumericUpDown.Location = new System.Drawing.Point(86, 160);
            this.KNumericUpDown.Name = "KNumericUpDown";
            this.KNumericUpDown.Size = new System.Drawing.Size(46, 29);
            this.KNumericUpDown.TabIndex = 18;
            this.KNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TeNumericUpDown
            // 
            this.TeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeNumericUpDown.Location = new System.Drawing.Point(86, 125);
            this.TeNumericUpDown.Name = "TeNumericUpDown";
            this.TeNumericUpDown.Size = new System.Drawing.Size(46, 29);
            this.TeNumericUpDown.TabIndex = 19;
            this.TeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WrNumericUpDown
            // 
            this.WrNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrNumericUpDown.Location = new System.Drawing.Point(86, 90);
            this.WrNumericUpDown.Name = "WrNumericUpDown";
            this.WrNumericUpDown.Size = new System.Drawing.Size(46, 29);
            this.WrNumericUpDown.TabIndex = 20;
            this.WrNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // RbNumericUpDown
            // 
            this.RbNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbNumericUpDown.Location = new System.Drawing.Point(86, 55);
            this.RbNumericUpDown.Name = "RbNumericUpDown";
            this.RbNumericUpDown.Size = new System.Drawing.Size(46, 29);
            this.RbNumericUpDown.TabIndex = 21;
            this.RbNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // NumPlayersGroupBox
            // 
            this.NumPlayersGroupBox.Controls.Add(this.FanDuelNumPositionsButton);
            this.NumPlayersGroupBox.Controls.Add(this.QbNumericUpDown);
            this.NumPlayersGroupBox.Controls.Add(this.RbNumericUpDown);
            this.NumPlayersGroupBox.Controls.Add(this.QbLabel);
            this.NumPlayersGroupBox.Controls.Add(this.WrNumericUpDown);
            this.NumPlayersGroupBox.Controls.Add(this.RbLabel);
            this.NumPlayersGroupBox.Controls.Add(this.TeNumericUpDown);
            this.NumPlayersGroupBox.Controls.Add(this.WrLabel);
            this.NumPlayersGroupBox.Controls.Add(this.KNumericUpDown);
            this.NumPlayersGroupBox.Controls.Add(this.TeLabel);
            this.NumPlayersGroupBox.Controls.Add(this.DStNumericUpDown);
            this.NumPlayersGroupBox.Controls.Add(this.KLabel);
            this.NumPlayersGroupBox.Controls.Add(this.DStLabel);
            this.NumPlayersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPlayersGroupBox.Location = new System.Drawing.Point(533, 311);
            this.NumPlayersGroupBox.Name = "NumPlayersGroupBox";
            this.NumPlayersGroupBox.Size = new System.Drawing.Size(177, 285);
            this.NumPlayersGroupBox.TabIndex = 22;
            this.NumPlayersGroupBox.TabStop = false;
            this.NumPlayersGroupBox.Text = "Number of Players";
            this.NumPlayersGroupBox.Enter += new System.EventHandler(this.NumPlayersGroupBox_Enter);
            // 
            // FanDuelNumPositionsButton
            // 
            this.FanDuelNumPositionsButton.Location = new System.Drawing.Point(19, 230);
            this.FanDuelNumPositionsButton.Name = "FanDuelNumPositionsButton";
            this.FanDuelNumPositionsButton.Size = new System.Drawing.Size(139, 36);
            this.FanDuelNumPositionsButton.TabIndex = 22;
            this.FanDuelNumPositionsButton.Text = "FanDuel Default";
            this.FanDuelNumPositionsButton.UseVisualStyleBackColor = true;
            this.FanDuelNumPositionsButton.Click += new System.EventHandler(this.FanDuelNumPositionsButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OptimizeButton
            // 
            this.OptimizeButton.Location = new System.Drawing.Point(80, 471);
            this.OptimizeButton.Name = "OptimizeButton";
            this.OptimizeButton.Size = new System.Drawing.Size(75, 23);
            this.OptimizeButton.TabIndex = 24;
            this.OptimizeButton.Text = "Optimize";
            this.OptimizeButton.UseVisualStyleBackColor = true;
            this.OptimizeButton.Click += new System.EventHandler(this.OptimizeButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 694);
            this.Controls.Add(this.OptimizeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumPlayersGroupBox);
            this.Controls.Add(this.TargetPointsLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.hybridFinalTableDataGridView);
            this.Controls.Add(this.hybridFinalTableBindingNavigator);
            this.Name = "Home";
            this.Text = "QB";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fantasy_FootballDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hybridFinalTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hybridFinalTableBindingNavigator)).EndInit();
            this.hybridFinalTableBindingNavigator.ResumeLayout(false);
            this.hybridFinalTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hybridFinalTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QbNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DStNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WrNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RbNumericUpDown)).EndInit();
            this.NumPlayersGroupBox.ResumeLayout(false);
            this.NumPlayersGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Fantasy_FootballDataSet fantasy_FootballDataSet;
        private System.Windows.Forms.BindingSource hybridFinalTableBindingSource;
        private Fantasy_FootballDataSetTableAdapters.HybridFinalTableTableAdapter hybridFinalTableTableAdapter;
        private Fantasy_FootballDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hybridFinalTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hybridFinalTableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hybridFinalTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label TargetPointsLabel;
        private System.Windows.Forms.NumericUpDown QbNumericUpDown;
        private System.Windows.Forms.Label QbLabel;
        private System.Windows.Forms.Label RbLabel;
        private System.Windows.Forms.Label WrLabel;
        private System.Windows.Forms.Label TeLabel;
        private System.Windows.Forms.Label KLabel;
        private System.Windows.Forms.Label DStLabel;
        private System.Windows.Forms.NumericUpDown DStNumericUpDown;
        private System.Windows.Forms.NumericUpDown KNumericUpDown;
        private System.Windows.Forms.NumericUpDown TeNumericUpDown;
        private System.Windows.Forms.NumericUpDown WrNumericUpDown;
        private System.Windows.Forms.NumericUpDown RbNumericUpDown;
        private System.Windows.Forms.GroupBox NumPlayersGroupBox;
        private System.Windows.Forms.Button FanDuelNumPositionsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button OptimizeButton;
    }
}


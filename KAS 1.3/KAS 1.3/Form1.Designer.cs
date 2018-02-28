namespace KAS_1._3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьПредложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьТеущееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКатегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбранноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownAQuantity = new System.Windows.Forms.NumericUpDown();
            this.categoriesDT = new System.Windows.Forms.DataGridView();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryLevelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kAS_DB_1_3DataSet = new KAS_1._3.KAS_DB_1_3DataSet();
            this.merchDT = new System.Windows.Forms.DataGridView();
            this.MerchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MerchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MerchLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MerchLevelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MerchPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDelete = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.ShownName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShownID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.AddDT = new System.Windows.Forms.DataGridView();
            this.AName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMerchPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AWorkPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownConsumables = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOffer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelPropertiesNames = new System.Windows.Forms.TableLayoutPanel();
            this.labelTextID = new System.Windows.Forms.Label();
            this.labelTextWorkPrice = new System.Windows.Forms.Label();
            this.labelTextMerchPrice = new System.Windows.Forms.Label();
            this.labelTextUnits = new System.Windows.Forms.Label();
            this.labelTextDescription = new System.Windows.Forms.Label();
            this.labelTextName = new System.Windows.Forms.Label();
            this.labelTextCode = new System.Windows.Forms.Label();
            this.labelTextQuantity = new System.Windows.Forms.Label();
            this.tableLayoutPanelPropertiesValues = new System.Windows.Forms.TableLayoutPanel();
            this.labelID = new System.Windows.Forms.Label();
            this.numericUpDownWorkPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.textBoxUnits = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.numericUpDownMerchPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.categoriesTableAdapter = new KAS_1._3.KAS_DB_1_3DataSetTableAdapters.CategoriesTableAdapter();
            this.merchTableAdapter = new KAS_1._3.KAS_DB_1_3DataSetTableAdapters.MerchTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kAS_DB_1_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchBindingSource)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddDT)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConsumables)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanelPropertiesNames.SuspendLayout();
            this.tableLayoutPanelPropertiesValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMerchPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьПредложениеToolStripMenuItem,
            this.сохранитьТеущееToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.добавитьТоварToolStripMenuItem,
            this.добавитьКатегориюToolStripMenuItem,
            this.удалитьВыбранноеToolStripMenuItem,
            this.сменитьПользователяToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // показатьПредложениеToolStripMenuItem
            // 
            this.показатьПредложениеToolStripMenuItem.Name = "показатьПредложениеToolStripMenuItem";
            this.показатьПредложениеToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.показатьПредложениеToolStripMenuItem.Text = "Показать предложение";
            this.показатьПредложениеToolStripMenuItem.Click += new System.EventHandler(this.показатьПредложениеToolStripMenuItem_Click);
            // 
            // сохранитьТеущееToolStripMenuItem
            // 
            this.сохранитьТеущееToolStripMenuItem.Name = "сохранитьТеущееToolStripMenuItem";
            this.сохранитьТеущееToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.сохранитьТеущееToolStripMenuItem.Text = "Сохранить текущее";
            this.сохранитьТеущееToolStripMenuItem.Click += new System.EventHandler(this.сохранитьТеущееToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // добавитьТоварToolStripMenuItem
            // 
            this.добавитьТоварToolStripMenuItem.Name = "добавитьТоварToolStripMenuItem";
            this.добавитьТоварToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.добавитьТоварToolStripMenuItem.Text = "Добавить товар";
            this.добавитьТоварToolStripMenuItem.Click += new System.EventHandler(this.добавитьТоварToolStripMenuItem_Click);
            // 
            // добавитьКатегориюToolStripMenuItem
            // 
            this.добавитьКатегориюToolStripMenuItem.Name = "добавитьКатегориюToolStripMenuItem";
            this.добавитьКатегориюToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.добавитьКатегориюToolStripMenuItem.Text = "Добавить категорию";
            this.добавитьКатегориюToolStripMenuItem.Click += new System.EventHandler(this.добавитьКатегориюToolStripMenuItem_Click);
            // 
            // удалитьВыбранноеToolStripMenuItem
            // 
            this.удалитьВыбранноеToolStripMenuItem.Name = "удалитьВыбранноеToolStripMenuItem";
            this.удалитьВыбранноеToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.удалитьВыбранноеToolStripMenuItem.Text = "Удалить выбранное";
            this.удалитьВыбранноеToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыбранноеToolStripMenuItem_Click);
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1006, 693);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00249F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.9975F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.listView1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1000, 437);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.buttonAdd, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.numericUpDownAQuantity, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.categoriesDT, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.merchDT, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.buttonDelete, 0, 4);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(618, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(64, 431);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(3, 218);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(58, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = ">>";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Кол-во";
            // 
            // numericUpDownAQuantity
            // 
            this.numericUpDownAQuantity.Location = new System.Drawing.Point(3, 188);
            this.numericUpDownAQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownAQuantity.Name = "numericUpDownAQuantity";
            this.numericUpDownAQuantity.Size = new System.Drawing.Size(58, 22);
            this.numericUpDownAQuantity.TabIndex = 2;
            this.numericUpDownAQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // categoriesDT
            // 
            this.categoriesDT.AutoGenerateColumns = false;
            this.categoriesDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryID,
            this.CategoryName,
            this.CategoryLevel,
            this.CategoryLevelID});
            this.categoriesDT.DataSource = this.categoriesBindingSource;
            this.categoriesDT.Location = new System.Drawing.Point(3, 3);
            this.categoriesDT.Name = "categoriesDT";
            this.categoriesDT.RowTemplate.Height = 24;
            this.categoriesDT.Size = new System.Drawing.Size(58, 116);
            this.categoriesDT.TabIndex = 3;
            this.categoriesDT.Visible = false;
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "category_id";
            this.CategoryID.HeaderText = "category_id";
            this.CategoryID.Name = "CategoryID";
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "category_name";
            this.CategoryName.HeaderText = "category_name";
            this.CategoryName.Name = "CategoryName";
            // 
            // CategoryLevel
            // 
            this.CategoryLevel.DataPropertyName = "category_level";
            this.CategoryLevel.HeaderText = "category_level";
            this.CategoryLevel.Name = "CategoryLevel";
            // 
            // CategoryLevelID
            // 
            this.CategoryLevelID.DataPropertyName = "category_level_id";
            this.CategoryLevelID.HeaderText = "category_level_id";
            this.CategoryLevelID.Name = "CategoryLevelID";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.kAS_DB_1_3DataSet;
            // 
            // kAS_DB_1_3DataSet
            // 
            this.kAS_DB_1_3DataSet.DataSetName = "KAS_DB_1_3DataSet";
            this.kAS_DB_1_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // merchDT
            // 
            this.merchDT.AutoGenerateColumns = false;
            this.merchDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.merchDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MerchID,
            this.ParentID,
            this.MerchName,
            this.MerchLevel,
            this.MerchLevelID,
            this.Code,
            this.Description,
            this.Units,
            this.MerchPrice,
            this.WorkPrice,
            this.Quantity});
            this.merchDT.DataSource = this.merchBindingSource;
            this.merchDT.Location = new System.Drawing.Point(3, 278);
            this.merchDT.Name = "merchDT";
            this.merchDT.RowTemplate.Height = 24;
            this.merchDT.Size = new System.Drawing.Size(58, 116);
            this.merchDT.TabIndex = 4;
            this.merchDT.Visible = false;
            // 
            // MerchID
            // 
            this.MerchID.DataPropertyName = "merch_id";
            this.MerchID.HeaderText = "merch_id";
            this.MerchID.Name = "MerchID";
            // 
            // ParentID
            // 
            this.ParentID.DataPropertyName = "parent_id";
            this.ParentID.HeaderText = "parent_id";
            this.ParentID.Name = "ParentID";
            // 
            // MerchName
            // 
            this.MerchName.DataPropertyName = "merch_name";
            this.MerchName.HeaderText = "merch_name";
            this.MerchName.Name = "MerchName";
            // 
            // MerchLevel
            // 
            this.MerchLevel.DataPropertyName = "merch_level";
            this.MerchLevel.HeaderText = "merch_level";
            this.MerchLevel.Name = "MerchLevel";
            // 
            // MerchLevelID
            // 
            this.MerchLevelID.DataPropertyName = "merch_level_id";
            this.MerchLevelID.HeaderText = "merch_level_id";
            this.MerchLevelID.Name = "MerchLevelID";
            // 
            // Code
            // 
            this.Code.DataPropertyName = "code";
            this.Code.HeaderText = "code";
            this.Code.Name = "Code";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "description";
            this.Description.HeaderText = "description";
            this.Description.Name = "Description";
            // 
            // Units
            // 
            this.Units.DataPropertyName = "units";
            this.Units.HeaderText = "units";
            this.Units.Name = "Units";
            // 
            // MerchPrice
            // 
            this.MerchPrice.DataPropertyName = "merch_price";
            this.MerchPrice.HeaderText = "merch_price";
            this.MerchPrice.Name = "MerchPrice";
            // 
            // WorkPrice
            // 
            this.WorkPrice.DataPropertyName = "work_price";
            this.WorkPrice.HeaderText = "work_price";
            this.WorkPrice.Name = "WorkPrice";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "quantity";
            this.Quantity.HeaderText = "quantity";
            this.Quantity.Name = "Quantity";
            // 
            // merchBindingSource
            // 
            this.merchBindingSource.DataMember = "Merch";
            this.merchBindingSource.DataSource = this.kAS_DB_1_3DataSet;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(3, 248);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(58, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "<<";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(294, 431);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.gif");
            this.imageList1.Images.SetKeyName(1, "dock-stack-highlight.png");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ShownName,
            this.Type,
            this.ShownID});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(303, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(309, 431);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // ShownName
            // 
            this.ShownName.Text = "Название";
            this.ShownName.Width = 300;
            // 
            // Type
            // 
            this.Type.Text = "Тип";
            // 
            // ShownID
            // 
            this.ShownID.Text = "Идентификатор";
            this.ShownID.Width = 117;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.AddDT, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(688, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(309, 431);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // AddDT
            // 
            this.AddDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AName,
            this.ADescription,
            this.AUnits,
            this.AQuantity,
            this.AMerchPrice,
            this.AWorkPrice,
            this.AID});
            this.AddDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddDT.Location = new System.Drawing.Point(3, 183);
            this.AddDT.Name = "AddDT";
            this.AddDT.RowTemplate.Height = 24;
            this.AddDT.Size = new System.Drawing.Size(303, 245);
            this.AddDT.TabIndex = 3;
            this.AddDT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddDT_CellContentClick);
            this.AddDT.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddDT_CellContentDoubleClick);
            // 
            // AName
            // 
            this.AName.HeaderText = "Названия продуктов";
            this.AName.Name = "AName";
            this.AName.Width = 320;
            // 
            // ADescription
            // 
            this.ADescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ADescription.HeaderText = "Описание";
            this.ADescription.MinimumWidth = 320;
            this.ADescription.Name = "ADescription";
            // 
            // AUnits
            // 
            this.AUnits.HeaderText = "Ед. изм.";
            this.AUnits.Name = "AUnits";
            this.AUnits.Width = 60;
            // 
            // AQuantity
            // 
            this.AQuantity.HeaderText = "Количество";
            this.AQuantity.Name = "AQuantity";
            this.AQuantity.Width = 60;
            // 
            // AMerchPrice
            // 
            this.AMerchPrice.HeaderText = "Цена продукта";
            this.AMerchPrice.Name = "AMerchPrice";
            this.AMerchPrice.Width = 60;
            // 
            // AWorkPrice
            // 
            this.AWorkPrice.HeaderText = "Цена монтажа";
            this.AWorkPrice.Name = "AWorkPrice";
            this.AWorkPrice.Width = 60;
            // 
            // AID
            // 
            this.AID.HeaderText = "Column1";
            this.AID.Name = "AID";
            this.AID.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.numericUpDownConsumables, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.textBoxOffer, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.textBoxDate, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(303, 174);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // numericUpDownConsumables
            // 
            this.numericUpDownConsumables.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownConsumables.DecimalPlaces = 2;
            this.numericUpDownConsumables.Location = new System.Drawing.Point(3, 146);
            this.numericUpDownConsumables.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownConsumables.Name = "numericUpDownConsumables";
            this.numericUpDownConsumables.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownConsumables.TabIndex = 12;
            this.numericUpDownConsumables.ThousandsSeparator = true;
            this.numericUpDownConsumables.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Стоимость расходных материалов: ";
            // 
            // textBoxOffer
            // 
            this.textBoxOffer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxOffer.Location = new System.Drawing.Point(3, 87);
            this.textBoxOffer.Name = "textBoxOffer";
            this.textBoxOffer.Size = new System.Drawing.Size(228, 22);
            this.textBoxOffer.TabIndex = 10;
            this.textBoxOffer.Text = "установку оборудования";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Технико-коммерческое предложение на";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDate.Location = new System.Drawing.Point(3, 31);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(228, 22);
            this.textBoxDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата составления документа:";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanelPropertiesNames, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanelPropertiesValues, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 446);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1000, 244);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // tableLayoutPanelPropertiesNames
            // 
            this.tableLayoutPanelPropertiesNames.ColumnCount = 1;
            this.tableLayoutPanelPropertiesNames.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            this.tableLayoutPanelPropertiesNames.Controls.Add(this.labelTextID, 0, 1);
            this.tableLayoutPanelPropertiesNames.Controls.Add(this.labelTextWorkPrice, 0, 7);
            this.tableLayoutPanelPropertiesNames.Controls.Add(this.labelTextMerchPrice, 0, 6);
            this.tableLayoutPanelPropertiesNames.Controls.Add(this.labelTextUnits, 0, 5);
            this.tableLayoutPanelPropertiesNames.Controls.Add(this.labelTextDescription, 0, 4);
            this.tableLayoutPanelPropertiesNames.Controls.Add(this.labelTextName, 0, 3);
            this.tableLayoutPanelPropertiesNames.Controls.Add(this.labelTextCode, 0, 2);
            this.tableLayoutPanelPropertiesNames.Controls.Add(this.labelTextQuantity, 0, 8);
            this.tableLayoutPanelPropertiesNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPropertiesNames.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelPropertiesNames.Name = "tableLayoutPanelPropertiesNames";
            this.tableLayoutPanelPropertiesNames.RowCount = 9;
            this.tableLayoutPanelPropertiesNames.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPropertiesNames.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPropertiesNames.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPropertiesNames.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPropertiesNames.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPropertiesNames.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPropertiesNames.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPropertiesNames.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPropertiesNames.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPropertiesNames.Size = new System.Drawing.Size(294, 238);
            this.tableLayoutPanelPropertiesNames.TabIndex = 2;
            this.tableLayoutPanelPropertiesNames.Visible = false;
            // 
            // labelTextID
            // 
            this.labelTextID.AutoSize = true;
            this.labelTextID.Location = new System.Drawing.Point(3, -2);
            this.labelTextID.Name = "labelTextID";
            this.labelTextID.Size = new System.Drawing.Size(114, 17);
            this.labelTextID.TabIndex = 0;
            this.labelTextID.Text = "Идентификатор";
            // 
            // labelTextWorkPrice
            // 
            this.labelTextWorkPrice.AutoSize = true;
            this.labelTextWorkPrice.Location = new System.Drawing.Point(3, 178);
            this.labelTextWorkPrice.Name = "labelTextWorkPrice";
            this.labelTextWorkPrice.Size = new System.Drawing.Size(104, 17);
            this.labelTextWorkPrice.TabIndex = 5;
            this.labelTextWorkPrice.Text = "Цена монтажа";
            // 
            // labelTextMerchPrice
            // 
            this.labelTextMerchPrice.AutoSize = true;
            this.labelTextMerchPrice.Location = new System.Drawing.Point(3, 148);
            this.labelTextMerchPrice.Name = "labelTextMerchPrice";
            this.labelTextMerchPrice.Size = new System.Drawing.Size(93, 17);
            this.labelTextMerchPrice.TabIndex = 4;
            this.labelTextMerchPrice.Text = "Цена товара";
            // 
            // labelTextUnits
            // 
            this.labelTextUnits.AutoSize = true;
            this.labelTextUnits.Location = new System.Drawing.Point(3, 118);
            this.labelTextUnits.Name = "labelTextUnits";
            this.labelTextUnits.Size = new System.Drawing.Size(196, 17);
            this.labelTextUnits.TabIndex = 3;
            this.labelTextUnits.Text = "Валюта/единицы измерения";
            // 
            // labelTextDescription
            // 
            this.labelTextDescription.AutoSize = true;
            this.labelTextDescription.Location = new System.Drawing.Point(3, 88);
            this.labelTextDescription.Name = "labelTextDescription";
            this.labelTextDescription.Size = new System.Drawing.Size(74, 17);
            this.labelTextDescription.TabIndex = 2;
            this.labelTextDescription.Text = "Описание";
            // 
            // labelTextName
            // 
            this.labelTextName.AutoSize = true;
            this.labelTextName.Location = new System.Drawing.Point(3, 58);
            this.labelTextName.Name = "labelTextName";
            this.labelTextName.Size = new System.Drawing.Size(72, 17);
            this.labelTextName.TabIndex = 1;
            this.labelTextName.Text = "Название";
            // 
            // labelTextCode
            // 
            this.labelTextCode.AutoSize = true;
            this.labelTextCode.Location = new System.Drawing.Point(3, 28);
            this.labelTextCode.Name = "labelTextCode";
            this.labelTextCode.Size = new System.Drawing.Size(33, 17);
            this.labelTextCode.TabIndex = 6;
            this.labelTextCode.Text = "Код";
            // 
            // labelTextQuantity
            // 
            this.labelTextQuantity.AutoSize = true;
            this.labelTextQuantity.Location = new System.Drawing.Point(3, 208);
            this.labelTextQuantity.Name = "labelTextQuantity";
            this.labelTextQuantity.Size = new System.Drawing.Size(86, 17);
            this.labelTextQuantity.TabIndex = 7;
            this.labelTextQuantity.Text = "Количество";
            // 
            // tableLayoutPanelPropertiesValues
            // 
            this.tableLayoutPanelPropertiesValues.ColumnCount = 1;
            this.tableLayoutPanelPropertiesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPropertiesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPropertiesValues.Controls.Add(this.labelID, 0, 1);
            this.tableLayoutPanelPropertiesValues.Controls.Add(this.numericUpDownWorkPrice, 0, 7);
            this.tableLayoutPanelPropertiesValues.Controls.Add(this.numericUpDownQuantity, 0, 8);
            this.tableLayoutPanelPropertiesValues.Controls.Add(this.textBoxUnits, 0, 5);
            this.tableLayoutPanelPropertiesValues.Controls.Add(this.textBoxDescription, 0, 4);
            this.tableLayoutPanelPropertiesValues.Controls.Add(this.textBoxName, 0, 3);
            this.tableLayoutPanelPropertiesValues.Controls.Add(this.textBoxCode, 0, 2);
            this.tableLayoutPanelPropertiesValues.Controls.Add(this.numericUpDownMerchPrice, 0, 6);
            this.tableLayoutPanelPropertiesValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPropertiesValues.Location = new System.Drawing.Point(303, 3);
            this.tableLayoutPanelPropertiesValues.Name = "tableLayoutPanelPropertiesValues";
            this.tableLayoutPanelPropertiesValues.RowCount = 9;
            this.tableLayoutPanelPropertiesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPropertiesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPropertiesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPropertiesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPropertiesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPropertiesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPropertiesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPropertiesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPropertiesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPropertiesValues.Size = new System.Drawing.Size(344, 238);
            this.tableLayoutPanelPropertiesValues.TabIndex = 1;
            this.tableLayoutPanelPropertiesValues.Visible = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(3, -2);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(54, 17);
            this.labelID.TabIndex = 8;
            this.labelID.Text = "label13";
            // 
            // numericUpDownWorkPrice
            // 
            this.numericUpDownWorkPrice.DecimalPlaces = 2;
            this.numericUpDownWorkPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownWorkPrice.Location = new System.Drawing.Point(3, 181);
            this.numericUpDownWorkPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownWorkPrice.Name = "numericUpDownWorkPrice";
            this.numericUpDownWorkPrice.Size = new System.Drawing.Size(338, 22);
            this.numericUpDownWorkPrice.TabIndex = 10;
            this.numericUpDownWorkPrice.ValueChanged += new System.EventHandler(this.numericUpDownWorkPrice_ValueChanged);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownQuantity.Location = new System.Drawing.Point(3, 211);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(338, 22);
            this.numericUpDownQuantity.TabIndex = 11;
            this.numericUpDownQuantity.ValueChanged += new System.EventHandler(this.numericUpDownQuantity_ValueChanged);
            // 
            // textBoxUnits
            // 
            this.textBoxUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUnits.Location = new System.Drawing.Point(3, 121);
            this.textBoxUnits.Name = "textBoxUnits";
            this.textBoxUnits.Size = new System.Drawing.Size(338, 22);
            this.textBoxUnits.TabIndex = 12;
            this.textBoxUnits.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUnits_KeyDown);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(3, 91);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(338, 22);
            this.textBoxDescription.TabIndex = 13;
            this.textBoxDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDescription_KeyDown);
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(3, 61);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(338, 22);
            this.textBoxName.TabIndex = 14;
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyDown);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCode.Location = new System.Drawing.Point(3, 31);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(338, 22);
            this.textBoxCode.TabIndex = 15;
            this.textBoxCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCode_KeyDown);
            // 
            // numericUpDownMerchPrice
            // 
            this.numericUpDownMerchPrice.DecimalPlaces = 2;
            this.numericUpDownMerchPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownMerchPrice.Location = new System.Drawing.Point(3, 151);
            this.numericUpDownMerchPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownMerchPrice.Name = "numericUpDownMerchPrice";
            this.numericUpDownMerchPrice.Size = new System.Drawing.Size(338, 22);
            this.numericUpDownMerchPrice.TabIndex = 9;
            this.numericUpDownMerchPrice.ValueChanged += new System.EventHandler(this.numericUpDownMerchPrice_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // merchTableAdapter
            // 
            this.merchTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "KAS 1.3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kAS_DB_1_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchBindingSource)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddDT)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConsumables)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanelPropertiesNames.ResumeLayout(false);
            this.tableLayoutPanelPropertiesNames.PerformLayout();
            this.tableLayoutPanelPropertiesValues.ResumeLayout(false);
            this.tableLayoutPanelPropertiesValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMerchPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader ShownName;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader ShownID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.NumericUpDown numericUpDownConsumables;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOffer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownAQuantity;
        private System.Windows.Forms.DataGridView categoriesDT;
        private KAS_DB_1_3DataSet kAS_DB_1_3DataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private KAS_DB_1_3DataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.DataGridView merchDT;
        private System.Windows.Forms.BindingSource merchBindingSource;
        private KAS_DB_1_3DataSetTableAdapters.MerchTableAdapter merchTableAdapter;
        private System.Windows.Forms.DataGridView AddDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryLevelID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPropertiesValues;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.NumericUpDown numericUpDownWorkPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.TextBox textBoxUnits;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.NumericUpDown numericUpDownMerchPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPropertiesNames;
        private System.Windows.Forms.Label labelTextID;
        private System.Windows.Forms.Label labelTextWorkPrice;
        private System.Windows.Forms.Label labelTextMerchPrice;
        private System.Windows.Forms.Label labelTextUnits;
        private System.Windows.Forms.Label labelTextDescription;
        private System.Windows.Forms.Label labelTextName;
        private System.Windows.Forms.Label labelTextCode;
        private System.Windows.Forms.Label labelTextQuantity;
        private System.Windows.Forms.ToolStripMenuItem показатьПредложениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьТеущееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКатегориюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбранноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn AName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn AQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMerchPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AWorkPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AID;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn MerchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MerchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MerchLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MerchLevelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn MerchPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Label label5;
    }
}


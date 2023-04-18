namespace AgNedv
{
    partial class Potrebnost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Potrebnost));
            System.Windows.Forms.Label idPotrebnostiLabel;
            System.Windows.Forms.Label tipObjLabel;
            System.Windows.Forms.Label gorodLabel;
            System.Windows.Forms.Label ylicaLabel;
            System.Windows.Forms.Label nomerDomaLabel;
            System.Windows.Forms.Label etazhLabel;
            System.Windows.Forms.Label kolvoKomnatLabel;
            System.Windows.Forms.Label ploshadLabel;
            System.Windows.Forms.Label etazhnostLabel;
            System.Windows.Forms.Label budzhetLabel;
            System.Windows.Forms.Label idRieltoraLabel;
            System.Windows.Forms.Label idClientaLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.agNedvDataSet = new AgNedv.AgNedvDataSet();
            this.potrebnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.potrebnostTableAdapter = new AgNedv.AgNedvDataSetTableAdapters.PotrebnostTableAdapter();
            this.tableAdapterManager = new AgNedv.AgNedvDataSetTableAdapters.TableAdapterManager();
            this.potrebnostBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.potrebnostBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idPotrebnostiTextBox = new System.Windows.Forms.TextBox();
            this.gorodTextBox = new System.Windows.Forms.TextBox();
            this.ylicaTextBox = new System.Windows.Forms.TextBox();
            this.nomerDomaTextBox = new System.Windows.Forms.TextBox();
            this.etazhTextBox = new System.Windows.Forms.TextBox();
            this.kolvoKomnatTextBox = new System.Windows.Forms.TextBox();
            this.ploshadTextBox = new System.Windows.Forms.TextBox();
            this.etazhnostTextBox = new System.Windows.Forms.TextBox();
            this.budzhetTextBox = new System.Windows.Forms.TextBox();
            this.idRieltoraTextBox = new System.Windows.Forms.TextBox();
            this.idClientaTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.agNedvDataSet1 = new AgNedv.AgNedvDataSet();
            this.tipObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipObjTableAdapter = new AgNedv.AgNedvDataSetTableAdapters.TipObjTableAdapter();
            idPotrebnostiLabel = new System.Windows.Forms.Label();
            tipObjLabel = new System.Windows.Forms.Label();
            gorodLabel = new System.Windows.Forms.Label();
            ylicaLabel = new System.Windows.Forms.Label();
            nomerDomaLabel = new System.Windows.Forms.Label();
            etazhLabel = new System.Windows.Forms.Label();
            kolvoKomnatLabel = new System.Windows.Forms.Label();
            ploshadLabel = new System.Windows.Forms.Label();
            etazhnostLabel = new System.Windows.Forms.Label();
            budzhetLabel = new System.Windows.Forms.Label();
            idRieltoraLabel = new System.Windows.Forms.Label();
            idClientaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agNedvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potrebnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potrebnostBindingNavigator)).BeginInit();
            this.potrebnostBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agNedvDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipObjBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(idClientaLabel);
            this.groupBox1.Controls.Add(idPotrebnostiLabel);
            this.groupBox1.Controls.Add(this.idPotrebnostiTextBox);
            this.groupBox1.Controls.Add(this.idClientaTextBox);
            this.groupBox1.Controls.Add(etazhLabel);
            this.groupBox1.Controls.Add(idRieltoraLabel);
            this.groupBox1.Controls.Add(this.etazhTextBox);
            this.groupBox1.Controls.Add(this.idRieltoraTextBox);
            this.groupBox1.Controls.Add(this.kolvoKomnatTextBox);
            this.groupBox1.Controls.Add(nomerDomaLabel);
            this.groupBox1.Controls.Add(budzhetLabel);
            this.groupBox1.Controls.Add(kolvoKomnatLabel);
            this.groupBox1.Controls.Add(tipObjLabel);
            this.groupBox1.Controls.Add(this.nomerDomaTextBox);
            this.groupBox1.Controls.Add(this.budzhetTextBox);
            this.groupBox1.Controls.Add(this.ploshadTextBox);
            this.groupBox1.Controls.Add(this.gorodTextBox);
            this.groupBox1.Controls.Add(ylicaLabel);
            this.groupBox1.Controls.Add(etazhnostLabel);
            this.groupBox1.Controls.Add(ploshadLabel);
            this.groupBox1.Controls.Add(gorodLabel);
            this.groupBox1.Controls.Add(this.ylicaTextBox);
            this.groupBox1.Controls.Add(this.etazhnostTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 516);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберете критерии";
            // 
            // agNedvDataSet
            // 
            this.agNedvDataSet.DataSetName = "AgNedvDataSet";
            this.agNedvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // potrebnostBindingSource
            // 
            this.potrebnostBindingSource.DataMember = "Potrebnost";
            this.potrebnostBindingSource.DataSource = this.agNedvDataSet;
            // 
            // potrebnostTableAdapter
            // 
            this.potrebnostTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.KodSdelkiTableAdapter = null;
            this.tableAdapterManager.Objekt_NedTableAdapter = null;
            this.tableAdapterManager.PotrebnostTableAdapter = this.potrebnostTableAdapter;
            this.tableAdapterManager.PredlozhenieTableAdapter = null;
            this.tableAdapterManager.rieltorTableAdapter = null;
            this.tableAdapterManager.TipObjTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AgNedv.AgNedvDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // potrebnostBindingNavigator
            // 
            this.potrebnostBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.potrebnostBindingNavigator.BindingSource = this.potrebnostBindingSource;
            this.potrebnostBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.potrebnostBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.potrebnostBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.potrebnostBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.potrebnostBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.potrebnostBindingNavigatorSaveItem});
            this.potrebnostBindingNavigator.Location = new System.Drawing.Point(0, 532);
            this.potrebnostBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.potrebnostBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.potrebnostBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.potrebnostBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.potrebnostBindingNavigator.Name = "potrebnostBindingNavigator";
            this.potrebnostBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.potrebnostBindingNavigator.Size = new System.Drawing.Size(430, 27);
            this.potrebnostBindingNavigator.TabIndex = 1;
            this.potrebnostBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // potrebnostBindingNavigatorSaveItem
            // 
            this.potrebnostBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.potrebnostBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("potrebnostBindingNavigatorSaveItem.Image")));
            this.potrebnostBindingNavigatorSaveItem.Name = "potrebnostBindingNavigatorSaveItem";
            this.potrebnostBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.potrebnostBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.potrebnostBindingNavigatorSaveItem.Click += new System.EventHandler(this.potrebnostBindingNavigatorSaveItem_Click);
            // 
            // idPotrebnostiLabel
            // 
            idPotrebnostiLabel.AutoSize = true;
            idPotrebnostiLabel.Location = new System.Drawing.Point(7, 44);
            idPotrebnostiLabel.Name = "idPotrebnostiLabel";
            idPotrebnostiLabel.Size = new System.Drawing.Size(157, 25);
            idPotrebnostiLabel.TabIndex = 0;
            idPotrebnostiLabel.Text = "id Потребности";
            // 
            // idPotrebnostiTextBox
            // 
            this.idPotrebnostiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.potrebnostBindingSource, "idPotrebnosti", true));
            this.idPotrebnostiTextBox.Location = new System.Drawing.Point(170, 41);
            this.idPotrebnostiTextBox.Name = "idPotrebnostiTextBox";
            this.idPotrebnostiTextBox.Size = new System.Drawing.Size(118, 30);
            this.idPotrebnostiTextBox.TabIndex = 1;
            // 
            // tipObjLabel
            // 
            tipObjLabel.AutoSize = true;
            tipObjLabel.Location = new System.Drawing.Point(36, 80);
            tipObjLabel.Name = "tipObjLabel";
            tipObjLabel.Size = new System.Drawing.Size(128, 25);
            tipObjLabel.TabIndex = 2;
            tipObjLabel.Text = "Тип объекта";
            // 
            // gorodLabel
            // 
            gorodLabel.AutoSize = true;
            gorodLabel.Location = new System.Drawing.Point(96, 119);
            gorodLabel.Name = "gorodLabel";
            gorodLabel.Size = new System.Drawing.Size(69, 25);
            gorodLabel.TabIndex = 4;
            gorodLabel.Text = "Город";
            // 
            // gorodTextBox
            // 
            this.gorodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.potrebnostBindingSource, "gorod", true));
            this.gorodTextBox.Location = new System.Drawing.Point(170, 116);
            this.gorodTextBox.Name = "gorodTextBox";
            this.gorodTextBox.Size = new System.Drawing.Size(165, 30);
            this.gorodTextBox.TabIndex = 5;
            // 
            // ylicaLabel
            // 
            ylicaLabel.AutoSize = true;
            ylicaLabel.Location = new System.Drawing.Point(96, 155);
            ylicaLabel.Name = "ylicaLabel";
            ylicaLabel.Size = new System.Drawing.Size(69, 25);
            ylicaLabel.TabIndex = 6;
            ylicaLabel.Text = "Улица";
            // 
            // ylicaTextBox
            // 
            this.ylicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.potrebnostBindingSource, "ylica", true));
            this.ylicaTextBox.Location = new System.Drawing.Point(170, 152);
            this.ylicaTextBox.Name = "ylicaTextBox";
            this.ylicaTextBox.Size = new System.Drawing.Size(165, 30);
            this.ylicaTextBox.TabIndex = 7;
            // 
            // nomerDomaLabel
            // 
            nomerDomaLabel.AutoSize = true;
            nomerDomaLabel.Location = new System.Drawing.Point(34, 191);
            nomerDomaLabel.Name = "nomerDomaLabel";
            nomerDomaLabel.Size = new System.Drawing.Size(130, 25);
            nomerDomaLabel.TabIndex = 8;
            nomerDomaLabel.Text = "nomer Doma:";
            // 
            // nomerDomaTextBox
            // 
            this.nomerDomaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.potrebnostBindingSource, "nomerDoma", true));
            this.nomerDomaTextBox.Location = new System.Drawing.Point(170, 188);
            this.nomerDomaTextBox.Name = "nomerDomaTextBox";
            this.nomerDomaTextBox.Size = new System.Drawing.Size(165, 30);
            this.nomerDomaTextBox.TabIndex = 9;
            // 
            // etazhLabel
            // 
            etazhLabel.AutoSize = true;
            etazhLabel.Location = new System.Drawing.Point(98, 227);
            etazhLabel.Name = "etazhLabel";
            etazhLabel.Size = new System.Drawing.Size(66, 25);
            etazhLabel.TabIndex = 10;
            etazhLabel.Text = "etazh:";
            // 
            // etazhTextBox
            // 
            this.etazhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.potrebnostBindingSource, "etazh", true));
            this.etazhTextBox.Location = new System.Drawing.Point(170, 224);
            this.etazhTextBox.Name = "etazhTextBox";
            this.etazhTextBox.Size = new System.Drawing.Size(165, 30);
            this.etazhTextBox.TabIndex = 11;
            // 
            // kolvoKomnatLabel
            // 
            kolvoKomnatLabel.AutoSize = true;
            kolvoKomnatLabel.Location = new System.Drawing.Point(27, 265);
            kolvoKomnatLabel.Name = "kolvoKomnatLabel";
            kolvoKomnatLabel.Size = new System.Drawing.Size(137, 25);
            kolvoKomnatLabel.TabIndex = 12;
            kolvoKomnatLabel.Text = "kolvo Komnat:";
            // 
            // kolvoKomnatTextBox
            // 
            this.kolvoKomnatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.potrebnostBindingSource, "kolvoKomnat", true));
            this.kolvoKomnatTextBox.Location = new System.Drawing.Point(170, 260);
            this.kolvoKomnatTextBox.Name = "kolvoKomnatTextBox";
            this.kolvoKomnatTextBox.Size = new System.Drawing.Size(165, 30);
            this.kolvoKomnatTextBox.TabIndex = 13;
            // 
            // ploshadLabel
            // 
            ploshadLabel.AutoSize = true;
            ploshadLabel.Location = new System.Drawing.Point(77, 299);
            ploshadLabel.Name = "ploshadLabel";
            ploshadLabel.Size = new System.Drawing.Size(87, 25);
            ploshadLabel.TabIndex = 14;
            ploshadLabel.Text = "ploshad:";
            // 
            // ploshadTextBox
            // 
            this.ploshadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.potrebnostBindingSource, "ploshad", true));
            this.ploshadTextBox.Location = new System.Drawing.Point(170, 296);
            this.ploshadTextBox.Name = "ploshadTextBox";
            this.ploshadTextBox.Size = new System.Drawing.Size(165, 30);
            this.ploshadTextBox.TabIndex = 15;
            // 
            // etazhnostLabel
            // 
            etazhnostLabel.AutoSize = true;
            etazhnostLabel.Location = new System.Drawing.Point(61, 335);
            etazhnostLabel.Name = "etazhnostLabel";
            etazhnostLabel.Size = new System.Drawing.Size(103, 25);
            etazhnostLabel.TabIndex = 16;
            etazhnostLabel.Text = "etazhnost:";
            // 
            // etazhnostTextBox
            // 
            this.etazhnostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.potrebnostBindingSource, "etazhnost", true));
            this.etazhnostTextBox.Location = new System.Drawing.Point(170, 332);
            this.etazhnostTextBox.Name = "etazhnostTextBox";
            this.etazhnostTextBox.Size = new System.Drawing.Size(165, 30);
            this.etazhnostTextBox.TabIndex = 17;
            // 
            // budzhetLabel
            // 
            budzhetLabel.AutoSize = true;
            budzhetLabel.Location = new System.Drawing.Point(76, 371);
            budzhetLabel.Name = "budzhetLabel";
            budzhetLabel.Size = new System.Drawing.Size(88, 25);
            budzhetLabel.TabIndex = 18;
            budzhetLabel.Text = "budzhet:";
            // 
            // budzhetTextBox
            // 
            this.budzhetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.potrebnostBindingSource, "budzhet", true));
            this.budzhetTextBox.Location = new System.Drawing.Point(170, 368);
            this.budzhetTextBox.Name = "budzhetTextBox";
            this.budzhetTextBox.Size = new System.Drawing.Size(165, 30);
            this.budzhetTextBox.TabIndex = 19;
            // 
            // idRieltoraLabel
            // 
            idRieltoraLabel.AutoSize = true;
            idRieltoraLabel.Location = new System.Drawing.Point(61, 407);
            idRieltoraLabel.Name = "idRieltoraLabel";
            idRieltoraLabel.Size = new System.Drawing.Size(103, 25);
            idRieltoraLabel.TabIndex = 20;
            idRieltoraLabel.Text = "id Rieltora:";
            // 
            // idRieltoraTextBox
            // 
            this.idRieltoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.potrebnostBindingSource, "idRieltora", true));
            this.idRieltoraTextBox.Location = new System.Drawing.Point(170, 404);
            this.idRieltoraTextBox.Name = "idRieltoraTextBox";
            this.idRieltoraTextBox.Size = new System.Drawing.Size(165, 30);
            this.idRieltoraTextBox.TabIndex = 21;
            // 
            // idClientaLabel
            // 
            idClientaLabel.AutoSize = true;
            idClientaLabel.Location = new System.Drawing.Point(65, 443);
            idClientaLabel.Name = "idClientaLabel";
            idClientaLabel.Size = new System.Drawing.Size(99, 25);
            idClientaLabel.TabIndex = 22;
            idClientaLabel.Text = "id Clienta:";
            idClientaLabel.Click += new System.EventHandler(this.idClientaLabel_Click);
            // 
            // idClientaTextBox
            // 
            this.idClientaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.potrebnostBindingSource, "idClienta", true));
            this.idClientaTextBox.Location = new System.Drawing.Point(170, 440);
            this.idClientaTextBox.Name = "idClientaTextBox";
            this.idClientaTextBox.Size = new System.Drawing.Size(165, 30);
            this.idClientaTextBox.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.potrebnostBindingSource, "TipObj", true));
            this.comboBox1.DataSource = this.tipObjBindingSource;
            this.comboBox1.DisplayMember = "NameTipa";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 33);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.ValueMember = "KodTipa";
            // 
            // agNedvDataSet1
            // 
            this.agNedvDataSet1.DataSetName = "AgNedvDataSet";
            this.agNedvDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipObjBindingSource
            // 
            this.tipObjBindingSource.DataMember = "TipObj";
            this.tipObjBindingSource.DataSource = this.agNedvDataSet1;
            // 
            // tipObjTableAdapter
            // 
            this.tipObjTableAdapter.ClearBeforeFill = true;
            // 
            // Potrebnost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 559);
            this.Controls.Add(this.potrebnostBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "Potrebnost";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Potrebnost_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agNedvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potrebnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potrebnostBindingNavigator)).EndInit();
            this.potrebnostBindingNavigator.ResumeLayout(false);
            this.potrebnostBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agNedvDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipObjBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private AgNedvDataSet agNedvDataSet;
        private System.Windows.Forms.BindingSource potrebnostBindingSource;
        private AgNedvDataSetTableAdapters.PotrebnostTableAdapter potrebnostTableAdapter;
        private AgNedvDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator potrebnostBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton potrebnostBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idPotrebnostiTextBox;
        private System.Windows.Forms.TextBox idClientaTextBox;
        private System.Windows.Forms.TextBox etazhTextBox;
        private System.Windows.Forms.TextBox idRieltoraTextBox;
        private System.Windows.Forms.TextBox kolvoKomnatTextBox;
        private System.Windows.Forms.TextBox nomerDomaTextBox;
        private System.Windows.Forms.TextBox budzhetTextBox;
        private System.Windows.Forms.TextBox ploshadTextBox;
        private System.Windows.Forms.TextBox gorodTextBox;
        private System.Windows.Forms.TextBox ylicaTextBox;
        private System.Windows.Forms.TextBox etazhnostTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private AgNedvDataSet agNedvDataSet1;
        private System.Windows.Forms.BindingSource tipObjBindingSource;
        private AgNedvDataSetTableAdapters.TipObjTableAdapter tipObjTableAdapter;
    }
}
namespace AgNedv
{
    partial class clientNew
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
            System.Windows.Forms.Label familyLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label otchestvoLabel;
            System.Windows.Forms.Label nomer_telefonaLabel;
            System.Windows.Forms.Label el_pochtaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientNew));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.el_pochtaTextBox = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agNedvDataSet = new AgNedv.AgNedvDataSet();
            this.nomer_telefonaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.otchestvoTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.familyTextBox = new System.Windows.Forms.TextBox();
            this.clientTableAdapter = new AgNedv.AgNedvDataSetTableAdapters.clientTableAdapter();
            this.tableAdapterManager = new AgNedv.AgNedvDataSetTableAdapters.TableAdapterManager();
            this.clientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            familyLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            otchestvoLabel = new System.Windows.Forms.Label();
            nomer_telefonaLabel = new System.Windows.Forms.Label();
            el_pochtaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agNedvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingNavigator)).BeginInit();
            this.clientBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // familyLabel
            // 
            familyLabel.AutoSize = true;
            familyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            familyLabel.Location = new System.Drawing.Point(99, 24);
            familyLabel.Name = "familyLabel";
            familyLabel.Size = new System.Drawing.Size(103, 25);
            familyLabel.TabIndex = 0;
            familyLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(148, 60);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(54, 25);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Имя";
            // 
            // otchestvoLabel
            // 
            otchestvoLabel.AutoSize = true;
            otchestvoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            otchestvoLabel.Location = new System.Drawing.Point(98, 96);
            otchestvoLabel.Name = "otchestvoLabel";
            otchestvoLabel.Size = new System.Drawing.Size(104, 25);
            otchestvoLabel.TabIndex = 4;
            otchestvoLabel.Text = "Отчество";
            // 
            // nomer_telefonaLabel
            // 
            nomer_telefonaLabel.AutoSize = true;
            nomer_telefonaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nomer_telefonaLabel.Location = new System.Drawing.Point(25, 132);
            nomer_telefonaLabel.Name = "nomer_telefonaLabel";
            nomer_telefonaLabel.Size = new System.Drawing.Size(177, 25);
            nomer_telefonaLabel.TabIndex = 6;
            nomer_telefonaLabel.Text = "Номер телефона";
            // 
            // el_pochtaLabel
            // 
            el_pochtaLabel.AutoSize = true;
            el_pochtaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            el_pochtaLabel.Location = new System.Drawing.Point(6, 168);
            el_pochtaLabel.Name = "el_pochtaLabel";
            el_pochtaLabel.Size = new System.Drawing.Size(196, 25);
            el_pochtaLabel.TabIndex = 8;
            el_pochtaLabel.Text = "Электронная почта";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(el_pochtaLabel);
            this.groupBox1.Controls.Add(this.el_pochtaTextBox);
            this.groupBox1.Controls.Add(nomer_telefonaLabel);
            this.groupBox1.Controls.Add(this.nomer_telefonaMaskedTextBox);
            this.groupBox1.Controls.Add(otchestvoLabel);
            this.groupBox1.Controls.Add(this.otchestvoTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(familyLabel);
            this.groupBox1.Controls.Add(this.familyTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новая запись";
            // 
            // el_pochtaTextBox
            // 
            this.el_pochtaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "el_pochta", true));
            this.el_pochtaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.el_pochtaTextBox.Location = new System.Drawing.Point(230, 165);
            this.el_pochtaTextBox.Name = "el_pochtaTextBox";
            this.el_pochtaTextBox.Size = new System.Drawing.Size(226, 30);
            this.el_pochtaTextBox.TabIndex = 9;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.agNedvDataSet;
            // 
            // agNedvDataSet
            // 
            this.agNedvDataSet.DataSetName = "AgNedvDataSet";
            this.agNedvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nomer_telefonaMaskedTextBox
            // 
            this.nomer_telefonaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "nomer_telefona", true));
            this.nomer_telefonaMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomer_telefonaMaskedTextBox.Location = new System.Drawing.Point(230, 129);
            this.nomer_telefonaMaskedTextBox.Mask = "+7 (999) 000-00-00";
            this.nomer_telefonaMaskedTextBox.Name = "nomer_telefonaMaskedTextBox";
            this.nomer_telefonaMaskedTextBox.Size = new System.Drawing.Size(226, 30);
            this.nomer_telefonaMaskedTextBox.TabIndex = 7;
            // 
            // otchestvoTextBox
            // 
            this.otchestvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "otchestvo", true));
            this.otchestvoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otchestvoTextBox.Location = new System.Drawing.Point(230, 93);
            this.otchestvoTextBox.Name = "otchestvoTextBox";
            this.otchestvoTextBox.Size = new System.Drawing.Size(226, 30);
            this.otchestvoTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(230, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(226, 30);
            this.nameTextBox.TabIndex = 3;
            // 
            // familyTextBox
            // 
            this.familyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "family", true));
            this.familyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.familyTextBox.Location = new System.Drawing.Point(230, 21);
            this.familyTextBox.Name = "familyTextBox";
            this.familyTextBox.Size = new System.Drawing.Size(226, 30);
            this.familyTextBox.TabIndex = 1;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.rieltorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AgNedv.AgNedvDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // clientBindingNavigator
            // 
            this.clientBindingNavigator.AddNewItem = null;
            this.clientBindingNavigator.BindingSource = this.clientBindingSource;
            this.clientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientBindingNavigator.DeleteItem = null;
            this.clientBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clientBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.clientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton2});
            this.clientBindingNavigator.Location = new System.Drawing.Point(0, 419);
            this.clientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientBindingNavigator.Name = "clientBindingNavigator";
            this.clientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientBindingNavigator.Size = new System.Drawing.Size(659, 31);
            this.clientBindingNavigator.TabIndex = 1;
            this.clientBindingNavigator.Text = "bindingNavigator1";
            this.clientBindingNavigator.RefreshItems += new System.EventHandler(this.clientBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(87, 28);
            this.toolStripButton1.Text = "Сохранить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(80, 28);
            this.toolStripButton3.Text = "Добавить";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(57, 28);
            this.toolStripButton2.Text = "Выйти";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // clientNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.clientBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "clientNew";
            this.Text = "esoft Таблица \"Клиенты\" Добавление новой записи";
            this.Activated += new System.EventHandler(this.clientNew_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.clientNew_FormClosed);
            this.Load += new System.EventHandler(this.clientNew_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agNedvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingNavigator)).EndInit();
            this.clientBindingNavigator.ResumeLayout(false);
            this.clientBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private AgNedvDataSet agNedvDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private AgNedvDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private AgNedvDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox familyTextBox;
        private System.Windows.Forms.TextBox el_pochtaTextBox;
        private System.Windows.Forms.MaskedTextBox nomer_telefonaMaskedTextBox;
        private System.Windows.Forms.TextBox otchestvoTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}
namespace AgNedv
{
    partial class rieltorNew
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
            System.Windows.Forms.Label dolyaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rieltorNew));
            this.agNedvDataSet = new AgNedv.AgNedvDataSet();
            this.rieltorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rieltorTableAdapter = new AgNedv.AgNedvDataSetTableAdapters.rieltorTableAdapter();
            this.tableAdapterManager = new AgNedv.AgNedvDataSetTableAdapters.TableAdapterManager();
            this.rieltorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.familyTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.otchestvoTextBox = new System.Windows.Forms.TextBox();
            this.dolyaTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            familyLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            otchestvoLabel = new System.Windows.Forms.Label();
            dolyaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agNedvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorBindingNavigator)).BeginInit();
            this.rieltorBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // familyLabel
            // 
            familyLabel.AutoSize = true;
            familyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            familyLabel.Location = new System.Drawing.Point(99, 24);
            familyLabel.Name = "familyLabel";
            familyLabel.Size = new System.Drawing.Size(103, 25);
            familyLabel.TabIndex = 1;
            familyLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nameLabel.Location = new System.Drawing.Point(148, 60);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(54, 25);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Имя";
            // 
            // otchestvoLabel
            // 
            otchestvoLabel.AutoSize = true;
            otchestvoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            otchestvoLabel.Location = new System.Drawing.Point(98, 96);
            otchestvoLabel.Name = "otchestvoLabel";
            otchestvoLabel.Size = new System.Drawing.Size(104, 25);
            otchestvoLabel.TabIndex = 5;
            otchestvoLabel.Text = "Отчество";
            // 
            // dolyaLabel
            // 
            dolyaLabel.AutoSize = true;
            dolyaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dolyaLabel.Location = new System.Drawing.Point(139, 132);
            dolyaLabel.Name = "dolyaLabel";
            dolyaLabel.Size = new System.Drawing.Size(63, 25);
            dolyaLabel.TabIndex = 7;
            dolyaLabel.Text = "Доля";
            // 
            // agNedvDataSet
            // 
            this.agNedvDataSet.DataSetName = "AgNedvDataSet";
            this.agNedvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rieltorBindingSource
            // 
            this.rieltorBindingSource.DataMember = "rieltor";
            this.rieltorBindingSource.DataSource = this.agNedvDataSet;
            // 
            // rieltorTableAdapter
            // 
            this.rieltorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.rieltorTableAdapter = this.rieltorTableAdapter;
            this.tableAdapterManager.UpdateOrder = AgNedv.AgNedvDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // rieltorBindingNavigator
            // 
            this.rieltorBindingNavigator.AddNewItem = null;
            this.rieltorBindingNavigator.BindingSource = this.rieltorBindingSource;
            this.rieltorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rieltorBindingNavigator.DeleteItem = null;
            this.rieltorBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rieltorBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rieltorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton2});
            this.rieltorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rieltorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rieltorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rieltorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rieltorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rieltorBindingNavigator.Name = "rieltorBindingNavigator";
            this.rieltorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rieltorBindingNavigator.Size = new System.Drawing.Size(506, 29);
            this.rieltorBindingNavigator.TabIndex = 0;
            this.rieltorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 26);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 26);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 26);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 29);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 26);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 26);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(87, 26);
            this.toolStripButton1.Text = "Сохранить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(57, 26);
            this.toolStripButton2.Text = "Выйти";
            // 
            // familyTextBox
            // 
            this.familyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rieltorBindingSource, "family", true));
            this.familyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.familyTextBox.Location = new System.Drawing.Point(230, 21);
            this.familyTextBox.Name = "familyTextBox";
            this.familyTextBox.Size = new System.Drawing.Size(226, 30);
            this.familyTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rieltorBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(230, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(226, 30);
            this.nameTextBox.TabIndex = 4;
            // 
            // otchestvoTextBox
            // 
            this.otchestvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rieltorBindingSource, "otchestvo", true));
            this.otchestvoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otchestvoTextBox.Location = new System.Drawing.Point(230, 93);
            this.otchestvoTextBox.Name = "otchestvoTextBox";
            this.otchestvoTextBox.Size = new System.Drawing.Size(226, 30);
            this.otchestvoTextBox.TabIndex = 6;
            // 
            // dolyaTextBox
            // 
            this.dolyaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rieltorBindingSource, "dolya", true));
            this.dolyaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dolyaTextBox.Location = new System.Drawing.Point(230, 129);
            this.dolyaTextBox.Name = "dolyaTextBox";
            this.dolyaTextBox.Size = new System.Drawing.Size(226, 30);
            this.dolyaTextBox.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rieltorBindingNavigator);
            this.panel1.Location = new System.Drawing.Point(12, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 29);
            this.panel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dolyaTextBox);
            this.groupBox1.Controls.Add(this.familyTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(dolyaLabel);
            this.groupBox1.Controls.Add(this.otchestvoTextBox);
            this.groupBox1.Controls.Add(familyLabel);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(otchestvoLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 401);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новая запись";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rieltorNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "rieltorNew";
            this.Text = "esoft Таблица \"Риелторы\" Добавление новой записи";
            this.Load += new System.EventHandler(this.rieltorNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agNedvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorBindingNavigator)).EndInit();
            this.rieltorBindingNavigator.ResumeLayout(false);
            this.rieltorBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AgNedvDataSet agNedvDataSet;
        private System.Windows.Forms.BindingSource rieltorBindingSource;
        private AgNedvDataSetTableAdapters.rieltorTableAdapter rieltorTableAdapter;
        private AgNedvDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rieltorBindingNavigator;
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
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox otchestvoTextBox;
        private System.Windows.Forms.TextBox dolyaTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}
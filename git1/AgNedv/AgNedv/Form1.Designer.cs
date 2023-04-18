namespace AgNedv
{
    partial class Avtorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtLogin = new System.Windows.Forms.TextBox();
            this.mtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.agNedvDataSet = new AgNedv.AgNedvDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new AgNedv.AgNedvDataSetTableAdapters.usersTableAdapter();
            this.tableAdapterManager = new AgNedv.AgNedvDataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agNedvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Пароль";
            // 
            // mtLogin
            // 
            this.mtLogin.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtLogin.Location = new System.Drawing.Point(114, 56);
            this.mtLogin.Multiline = true;
            this.mtLogin.Name = "mtLogin";
            this.mtLogin.Size = new System.Drawing.Size(185, 38);
            this.mtLogin.TabIndex = 1;
            // 
            // mtPassword
            // 
            this.mtPassword.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtPassword.Location = new System.Drawing.Point(114, 112);
            this.mtPassword.Multiline = true;
            this.mtPassword.Name = "mtPassword";
            this.mtPassword.Size = new System.Drawing.Size(185, 38);
            this.mtPassword.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.mtLogin);
            this.groupBox1.Controls.Add(this.mtPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 317);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Авторизация";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(19, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(19, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // agNedvDataSet
            // 
            this.agNedvDataSet.DataSetName = "AgNedvDataSet";
            this.agNedvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.agNedvDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.rieltorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AgNedv.AgNedvDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // Avtorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(343, 334);
            this.Controls.Add(this.groupBox1);
            this.Name = "Avtorization";
            this.Text = "Esoft";
            this.Load += new System.EventHandler(this.Avtorization_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agNedvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mtLogin;
        private System.Windows.Forms.TextBox mtPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private AgNedvDataSet agNedvDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private AgNedvDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private AgNedvDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}


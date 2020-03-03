namespace StudentJournal
{
    partial class FormMain
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
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.gridStudents = new System.Windows.Forms.DataGridView();
            this.gridLearning = new System.Windows.Forms.DataGridView();
            this.gridAttention = new System.Windows.Forms.DataGridView();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.btnEventAdd = new System.Windows.Forms.Button();
            this.btnGroupAdd = new System.Windows.Forms.Button();
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblAttention = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabLearning = new System.Windows.Forms.TabPage();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEvents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLearning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttention)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabLearning.SuspendLayout();
            this.tabEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(12, 25);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(177, 21);
            this.cmbGroup.TabIndex = 0;
            // 
            // gridStudents
            // 
            this.gridStudents.AllowUserToAddRows = false;
            this.gridStudents.AllowUserToDeleteRows = false;
            this.gridStudents.AllowUserToResizeColumns = false;
            this.gridStudents.AllowUserToResizeRows = false;
            this.gridStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName});
            this.gridStudents.Location = new System.Drawing.Point(12, 65);
            this.gridStudents.MultiSelect = false;
            this.gridStudents.Name = "gridStudents";
            this.gridStudents.ReadOnly = true;
            this.gridStudents.RowHeadersVisible = false;
            this.gridStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStudents.Size = new System.Drawing.Size(177, 335);
            this.gridStudents.TabIndex = 1;
            // 
            // gridLearning
            // 
            this.gridLearning.AllowUserToAddRows = false;
            this.gridLearning.AllowUserToDeleteRows = false;
            this.gridLearning.AllowUserToResizeColumns = false;
            this.gridLearning.AllowUserToResizeRows = false;
            this.gridLearning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLearning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLearning.Location = new System.Drawing.Point(0, 0);
            this.gridLearning.Margin = new System.Windows.Forms.Padding(0);
            this.gridLearning.Name = "gridLearning";
            this.gridLearning.ReadOnly = true;
            this.gridLearning.RowHeadersVisible = false;
            this.gridLearning.Size = new System.Drawing.Size(652, 335);
            this.gridLearning.TabIndex = 2;
            // 
            // gridAttention
            // 
            this.gridAttention.AllowUserToAddRows = false;
            this.gridAttention.AllowUserToDeleteRows = false;
            this.gridAttention.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAttention.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAttention.Location = new System.Drawing.Point(858, 65);
            this.gridAttention.Name = "gridAttention";
            this.gridAttention.ReadOnly = true;
            this.gridAttention.Size = new System.Drawing.Size(101, 335);
            this.gridAttention.TabIndex = 3;
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStudentAdd.Location = new System.Drawing.Point(12, 406);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(177, 23);
            this.btnStudentAdd.TabIndex = 4;
            this.btnStudentAdd.Text = "Студент (+)";
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // btnEventAdd
            // 
            this.btnEventAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEventAdd.Location = new System.Drawing.Point(301, 406);
            this.btnEventAdd.Name = "btnEventAdd";
            this.btnEventAdd.Size = new System.Drawing.Size(100, 23);
            this.btnEventAdd.TabIndex = 5;
            this.btnEventAdd.Text = "Мероприятие (+)";
            this.btnEventAdd.UseVisualStyleBackColor = true;
            // 
            // btnGroupAdd
            // 
            this.btnGroupAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGroupAdd.Location = new System.Drawing.Point(195, 406);
            this.btnGroupAdd.Name = "btnGroupAdd";
            this.btnGroupAdd.Size = new System.Drawing.Size(100, 23);
            this.btnGroupAdd.TabIndex = 6;
            this.btnGroupAdd.Text = "Группа (+)";
            this.btnGroupAdd.UseVisualStyleBackColor = true;
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(9, 49);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(58, 13);
            this.lblStudents.TabIndex = 7;
            this.lblStudents.Text = "Студенты:";
            // 
            // lblAttention
            // 
            this.lblAttention.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAttention.AutoSize = true;
            this.lblAttention.Location = new System.Drawing.Point(855, 49);
            this.lblAttention.Name = "lblAttention";
            this.lblAttention.Size = new System.Drawing.Size(61, 13);
            this.lblAttention.TabIndex = 9;
            this.lblAttention.Text = "Внимание:";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(9, 9);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(45, 13);
            this.lblGroup.TabIndex = 10;
            this.lblGroup.Text = "Группа:";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabLearning);
            this.tabControlMain.Controls.Add(this.tabEvents);
            this.tabControlMain.Location = new System.Drawing.Point(192, 43);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.Padding = new System.Drawing.Point(0, 0);
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(660, 361);
            this.tabControlMain.TabIndex = 11;
            // 
            // tabLearning
            // 
            this.tabLearning.Controls.Add(this.gridLearning);
            this.tabLearning.Location = new System.Drawing.Point(4, 22);
            this.tabLearning.Margin = new System.Windows.Forms.Padding(0);
            this.tabLearning.Name = "tabLearning";
            this.tabLearning.Size = new System.Drawing.Size(652, 335);
            this.tabLearning.TabIndex = 0;
            this.tabLearning.Text = "Успевамость";
            this.tabLearning.UseVisualStyleBackColor = true;
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.gridEvents);
            this.tabEvents.Location = new System.Drawing.Point(4, 22);
            this.tabEvents.Margin = new System.Windows.Forms.Padding(0);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Size = new System.Drawing.Size(652, 335);
            this.tabEvents.TabIndex = 1;
            this.tabEvents.Text = "Мероприятия";
            this.tabEvents.UseVisualStyleBackColor = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "ФИО";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gridEvents
            // 
            this.gridEvents.AllowUserToAddRows = false;
            this.gridEvents.AllowUserToDeleteRows = false;
            this.gridEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEvents.Location = new System.Drawing.Point(0, 0);
            this.gridEvents.Name = "gridEvents";
            this.gridEvents.ReadOnly = true;
            this.gridEvents.Size = new System.Drawing.Size(652, 335);
            this.gridEvents.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 441);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblAttention);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.btnGroupAdd);
            this.Controls.Add(this.btnEventAdd);
            this.Controls.Add(this.btnStudentAdd);
            this.Controls.Add(this.gridAttention);
            this.Controls.Add(this.gridStudents);
            this.Controls.Add(this.cmbGroup);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "FormMain";
            this.Text = "Электронный журнал куратора";
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLearning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttention)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabLearning.ResumeLayout(false);
            this.tabEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.DataGridView gridStudents;
        private System.Windows.Forms.DataGridView gridLearning;
        private System.Windows.Forms.DataGridView gridAttention;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.Button btnEventAdd;
        private System.Windows.Forms.Button btnGroupAdd;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label lblAttention;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabLearning;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridView gridEvents;
    }
}


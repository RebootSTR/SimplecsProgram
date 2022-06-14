namespace SimplecsProgram
{
    partial class Form1
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
            this.canonButton = new System.Windows.Forms.Button();
            this.mathButton = new System.Windows.Forms.Button();
            this.limitTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.limitLessButton = new System.Windows.Forms.Button();
            this.limitMoreButton = new System.Windows.Forms.Button();
            this.argMoreButton = new System.Windows.Forms.Button();
            this.argLessButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.countLimitLabel = new System.Windows.Forms.Label();
            this.countArgsLabel = new System.Windows.Forms.Label();
            this.finMinButton = new System.Windows.Forms.Button();
            this.findMaxButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.funcTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionLabel = new System.Windows.Forms.Label();
            this.limitsLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.limitValuesTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.limitTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitValuesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // canonButton
            // 
            this.canonButton.Location = new System.Drawing.Point(102, 12);
            this.canonButton.Name = "canonButton";
            this.canonButton.Size = new System.Drawing.Size(87, 23);
            this.canonButton.TabIndex = 0;
            this.canonButton.Text = "Каноническая";
            this.canonButton.UseVisualStyleBackColor = true;
            this.canonButton.Click += new System.EventHandler(this.canonButton_Click);
            // 
            // mathButton
            // 
            this.mathButton.Location = new System.Drawing.Point(195, 12);
            this.mathButton.Name = "mathButton";
            this.mathButton.Size = new System.Drawing.Size(103, 23);
            this.mathButton.TabIndex = 1;
            this.mathButton.Text = "Математическая";
            this.mathButton.UseVisualStyleBackColor = true;
            this.mathButton.Click += new System.EventHandler(this.mathButton_Click);
            // 
            // limitTable
            // 
            this.limitTable.AllowUserToAddRows = false;
            this.limitTable.AllowUserToDeleteRows = false;
            this.limitTable.AllowUserToResizeColumns = false;
            this.limitTable.AllowUserToResizeRows = false;
            this.limitTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.limitTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.limitTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.limitTable.ColumnHeadersVisible = false;
            this.limitTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.limitTable.Location = new System.Drawing.Point(13, 72);
            this.limitTable.MultiSelect = false;
            this.limitTable.Name = "limitTable";
            this.limitTable.RowHeadersVisible = false;
            this.limitTable.Size = new System.Drawing.Size(231, 96);
            this.limitTable.TabIndex = 2;
            this.limitTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.limitTable_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(155, 286);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Кол-во ограничений:";
            // 
            // limitLessButton
            // 
            this.limitLessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.limitLessButton.Location = new System.Drawing.Point(328, 145);
            this.limitLessButton.Name = "limitLessButton";
            this.limitLessButton.Size = new System.Drawing.Size(64, 23);
            this.limitLessButton.TabIndex = 5;
            this.limitLessButton.Text = "меньше";
            this.limitLessButton.UseVisualStyleBackColor = true;
            this.limitLessButton.Click += new System.EventHandler(this.limitLessButton_Click);
            // 
            // limitMoreButton
            // 
            this.limitMoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.limitMoreButton.Location = new System.Drawing.Point(398, 145);
            this.limitMoreButton.Name = "limitMoreButton";
            this.limitMoreButton.Size = new System.Drawing.Size(64, 23);
            this.limitMoreButton.TabIndex = 6;
            this.limitMoreButton.Text = "больше";
            this.limitMoreButton.UseVisualStyleBackColor = true;
            this.limitMoreButton.Click += new System.EventHandler(this.limitMoreButton_Click);
            // 
            // argMoreButton
            // 
            this.argMoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.argMoreButton.Location = new System.Drawing.Point(398, 43);
            this.argMoreButton.Name = "argMoreButton";
            this.argMoreButton.Size = new System.Drawing.Size(64, 23);
            this.argMoreButton.TabIndex = 9;
            this.argMoreButton.Text = "больше";
            this.argMoreButton.UseVisualStyleBackColor = true;
            this.argMoreButton.Click += new System.EventHandler(this.argMoreButton_Click);
            // 
            // argLessButton
            // 
            this.argLessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.argLessButton.Location = new System.Drawing.Point(328, 43);
            this.argLessButton.Name = "argLessButton";
            this.argLessButton.Size = new System.Drawing.Size(64, 23);
            this.argLessButton.TabIndex = 8;
            this.argLessButton.Text = "меньше";
            this.argLessButton.UseVisualStyleBackColor = true;
            this.argLessButton.Click += new System.EventHandler(this.argLessButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кол-во переменных:";
            // 
            // countLimitLabel
            // 
            this.countLimitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.countLimitLabel.AutoSize = true;
            this.countLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLimitLabel.Location = new System.Drawing.Point(442, 117);
            this.countLimitLabel.Name = "countLimitLabel";
            this.countLimitLabel.Size = new System.Drawing.Size(17, 18);
            this.countLimitLabel.TabIndex = 10;
            this.countLimitLabel.Text = "3";
            // 
            // countArgsLabel
            // 
            this.countArgsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countArgsLabel.AutoSize = true;
            this.countArgsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countArgsLabel.Location = new System.Drawing.Point(441, 15);
            this.countArgsLabel.Name = "countArgsLabel";
            this.countArgsLabel.Size = new System.Drawing.Size(17, 18);
            this.countArgsLabel.TabIndex = 11;
            this.countArgsLabel.Text = "3";
            // 
            // finMinButton
            // 
            this.finMinButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finMinButton.Location = new System.Drawing.Point(315, 185);
            this.finMinButton.Name = "finMinButton";
            this.finMinButton.Size = new System.Drawing.Size(148, 23);
            this.finMinButton.TabIndex = 12;
            this.finMinButton.Text = "Найти минимум";
            this.finMinButton.UseVisualStyleBackColor = true;
            this.finMinButton.Click += new System.EventHandler(this.finMinButton_Click);
            // 
            // findMaxButton
            // 
            this.findMaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.findMaxButton.Location = new System.Drawing.Point(12, 185);
            this.findMaxButton.Name = "findMaxButton";
            this.findMaxButton.Size = new System.Drawing.Size(286, 23);
            this.findMaxButton.TabIndex = 13;
            this.findMaxButton.Text = "Найти максимум";
            this.findMaxButton.UseVisualStyleBackColor = true;
            this.findMaxButton.Click += new System.EventHandler(this.findMaxButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Форма записи:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Функция:";
            // 
            // funcTable
            // 
            this.funcTable.AllowUserToAddRows = false;
            this.funcTable.AllowUserToDeleteRows = false;
            this.funcTable.AllowUserToResizeColumns = false;
            this.funcTable.AllowUserToResizeRows = false;
            this.funcTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.funcTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.funcTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcTable.ColumnHeadersVisible = false;
            this.funcTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.funcTable.Location = new System.Drawing.Point(72, 41);
            this.funcTable.Name = "funcTable";
            this.funcTable.RowHeadersVisible = false;
            this.funcTable.Size = new System.Drawing.Size(239, 24);
            this.funcTable.TabIndex = 16;
            this.funcTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.funcTable_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // functionLabel
            // 
            this.functionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.functionLabel.AutoSize = true;
            this.functionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.functionLabel.Location = new System.Drawing.Point(12, 246);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(60, 20);
            this.functionLabel.TabIndex = 17;
            this.functionLabel.Text = "F(x) = ";
            // 
            // limitsLabel
            // 
            this.limitsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.limitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.limitsLabel.Location = new System.Drawing.Point(74, 285);
            this.limitsLabel.Name = "limitsLabel";
            this.limitsLabel.Size = new System.Drawing.Size(374, 168);
            this.limitsLabel.TabIndex = 19;
            this.limitsLabel.Text = "label8";
            this.limitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Microsoft Yi Baiti", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-38, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 328);
            this.label9.TabIndex = 20;
            this.label9.Text = "{";
            // 
            // limitValuesTable
            // 
            this.limitValuesTable.AllowUserToAddRows = false;
            this.limitValuesTable.AllowUserToDeleteRows = false;
            this.limitValuesTable.AllowUserToResizeColumns = false;
            this.limitValuesTable.AllowUserToResizeRows = false;
            this.limitValuesTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.limitValuesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.limitValuesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.limitValuesTable.ColumnHeadersVisible = false;
            this.limitValuesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.limitValuesTable.Location = new System.Drawing.Point(274, 72);
            this.limitValuesTable.MultiSelect = false;
            this.limitValuesTable.Name = "limitValuesTable";
            this.limitValuesTable.RowHeadersVisible = false;
            this.limitValuesTable.Size = new System.Drawing.Size(37, 96);
            this.limitValuesTable.TabIndex = 21;
            this.limitValuesTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.limitValuesTable_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(249, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 96);
            this.label3.TabIndex = 22;
            this.label3.Text = "<=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(385, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Теория";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::SimplecsProgram.Properties.Resources.Без_имени;
            this.pictureBox1.Location = new System.Drawing.Point(12, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.limitValuesTable);
            this.Controls.Add(this.functionLabel);
            this.Controls.Add(this.limitsLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.funcTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.findMaxButton);
            this.Controls.Add(this.finMinButton);
            this.Controls.Add(this.countArgsLabel);
            this.Controls.Add(this.countLimitLabel);
            this.Controls.Add(this.argMoreButton);
            this.Controls.Add(this.argLessButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.limitMoreButton);
            this.Controls.Add(this.limitLessButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mathButton);
            this.Controls.Add(this.canonButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.limitTable);
            this.Controls.Add(this.label9);
            this.MinimumSize = new System.Drawing.Size(470, 463);
            this.Name = "Form1";
            this.Text = "Симплекс программа. Рафиков А.Р. 2022.";
            ((System.ComponentModel.ISupportInitialize)(this.limitTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitValuesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button canonButton;
        public System.Windows.Forms.Button mathButton;
        public System.Windows.Forms.DataGridView limitTable;
        public System.Windows.Forms.Button limitLessButton;
        public System.Windows.Forms.Button limitMoreButton;
        public System.Windows.Forms.Button argMoreButton;
        public System.Windows.Forms.Button argLessButton;
        public System.Windows.Forms.Label countLimitLabel;
        public System.Windows.Forms.Label countArgsLabel;
        public System.Windows.Forms.Button finMinButton;
        public System.Windows.Forms.Button findMaxButton;
        public System.Windows.Forms.DataGridView funcTable;
        public System.Windows.Forms.Label functionLabel;
        public System.Windows.Forms.Label limitsLabel;
        public System.Windows.Forms.DataGridView limitValuesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}


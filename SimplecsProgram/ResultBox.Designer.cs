namespace SimplecsProgram
{
    partial class ResultBox
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
            this.title = new System.Windows.Forms.Label();
            this.showTablesButton = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(161, 27);
            this.title.TabIndex = 0;
            this.title.Text = "title";
            // 
            // showTablesButton
            // 
            this.showTablesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showTablesButton.Location = new System.Drawing.Point(12, 222);
            this.showTablesButton.Name = "showTablesButton";
            this.showTablesButton.Size = new System.Drawing.Size(161, 23);
            this.showTablesButton.TabIndex = 1;
            this.showTablesButton.Text = "Посмотреть таблицы";
            this.showTablesButton.UseVisualStyleBackColor = true;
            this.showTablesButton.Click += new System.EventHandler(this.showTablesButton_Click);
            // 
            // message
            // 
            this.message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message.Location = new System.Drawing.Point(12, 36);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(161, 190);
            this.message.TabIndex = 0;
            this.message.Text = "Message";
            // 
            // ResultBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 257);
            this.Controls.Add(this.showTablesButton);
            this.Controls.Add(this.message);
            this.Controls.Add(this.title);
            this.MinimumSize = new System.Drawing.Size(167, 239);
            this.Name = "ResultBox";
            this.Text = "ResultBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button showTablesButton;
        private System.Windows.Forms.Label message;
    }
}
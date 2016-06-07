namespace LibraryManagementSystem.UI.Reader
{
    partial class ReaderUI
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
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.requestedBookDataGridView = new System.Windows.Forms.DataGridView();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addBookIDTextBox = new System.Windows.Forms.TextBox();
            this.bookListGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.returnBookIDTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.readerNameTextBox = new System.Windows.Forms.TextBox();
            this.bookTakenTextBox = new System.Windows.Forms.TextBox();
            this.readerIDTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestedBookDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookListGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.label7);
            this.GroupBox.Controls.Add(this.requestedBookDataGridView);
            this.GroupBox.Controls.Add(this.clearButton);
            this.GroupBox.Controls.Add(this.addButton);
            this.GroupBox.Controls.Add(this.label1);
            this.GroupBox.Controls.Add(this.addBookIDTextBox);
            this.GroupBox.Location = new System.Drawing.Point(36, 288);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(609, 154);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Borrow Panel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Requested Book";
            // 
            // requestedBookDataGridView
            // 
            this.requestedBookDataGridView.AllowUserToAddRows = false;
            this.requestedBookDataGridView.AllowUserToDeleteRows = false;
            this.requestedBookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestedBookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4});
            this.requestedBookDataGridView.Location = new System.Drawing.Point(242, 56);
            this.requestedBookDataGridView.Name = "requestedBookDataGridView";
            this.requestedBookDataGridView.ReadOnly = true;
            this.requestedBookDataGridView.Size = new System.Drawing.Size(349, 48);
            this.requestedBookDataGridView.TabIndex = 3;
            this.requestedBookDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestedBookDataGridView_CellClick);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(161, 96);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(57, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(98, 96);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(57, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book ID";
            // 
            // addBookIDTextBox
            // 
            this.addBookIDTextBox.Location = new System.Drawing.Point(90, 44);
            this.addBookIDTextBox.Name = "addBookIDTextBox";
            this.addBookIDTextBox.ReadOnly = true;
            this.addBookIDTextBox.Size = new System.Drawing.Size(140, 20);
            this.addBookIDTextBox.TabIndex = 0;
            // 
            // bookListGridView
            // 
            this.bookListGridView.AllowUserToAddRows = false;
            this.bookListGridView.AllowUserToDeleteRows = false;
            this.bookListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column6,
            this.dataGridViewTextBoxColumn2,
            this.Column7,
            this.Column3});
            this.bookListGridView.Location = new System.Drawing.Point(68, 139);
            this.bookListGridView.Name = "bookListGridView";
            this.bookListGridView.ReadOnly = true;
            this.bookListGridView.Size = new System.Drawing.Size(547, 143);
            this.bookListGridView.TabIndex = 1;
            this.bookListGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookListGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "serial no";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Book ID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Book Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Author";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.returnButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.returnBookIDTextBox);
            this.groupBox1.Location = new System.Drawing.Point(36, 460);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "return Panel";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(132, 96);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(57, 23);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book ID";
            // 
            // returnBookIDTextBox
            // 
            this.returnBookIDTextBox.Location = new System.Drawing.Point(90, 44);
            this.returnBookIDTextBox.Name = "returnBookIDTextBox";
            this.returnBookIDTextBox.ReadOnly = true;
            this.returnBookIDTextBox.Size = new System.Drawing.Size(150, 20);
            this.returnBookIDTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.readerNameTextBox);
            this.groupBox2.Controls.Add(this.bookTakenTextBox);
            this.groupBox2.Controls.Add(this.readerIDTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(48, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BookReader Panel";
            // 
            // readerNameTextBox
            // 
            this.readerNameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.readerNameTextBox.Location = new System.Drawing.Point(140, 60);
            this.readerNameTextBox.Name = "readerNameTextBox";
            this.readerNameTextBox.ReadOnly = true;
            this.readerNameTextBox.Size = new System.Drawing.Size(141, 20);
            this.readerNameTextBox.TabIndex = 1;
            // 
            // bookTakenTextBox
            // 
            this.bookTakenTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bookTakenTextBox.Location = new System.Drawing.Point(362, 33);
            this.bookTakenTextBox.Name = "bookTakenTextBox";
            this.bookTakenTextBox.ReadOnly = true;
            this.bookTakenTextBox.Size = new System.Drawing.Size(71, 20);
            this.bookTakenTextBox.TabIndex = 1;
            // 
            // readerIDTextBox
            // 
            this.readerIDTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.readerIDTextBox.Location = new System.Drawing.Point(140, 33);
            this.readerIDTextBox.Name = "readerIDTextBox";
            this.readerIDTextBox.ReadOnly = true;
            this.readerIDTextBox.Size = new System.Drawing.Size(141, 20);
            this.readerIDTextBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "BookReader ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "BookReader Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Book Taken";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Book List";
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "serial number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "book ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "status";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ReaderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 626);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bookListGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.label6);
            this.Name = "ReaderUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookReader Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReaderUI_FormClosing);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestedBookDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookListGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addBookIDTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridView bookListGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox returnBookIDTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox readerNameTextBox;
        private System.Windows.Forms.TextBox bookTakenTextBox;
        private System.Windows.Forms.TextBox readerIDTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView requestedBookDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
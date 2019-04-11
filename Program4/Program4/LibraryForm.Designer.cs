namespace Program4
{
    partial class LibraryForm
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
            this.libraryBookInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.copyrightYearLabel = new System.Windows.Forms.Label();
            this.callNumberLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.copyrightYearTextBox = new System.Windows.Forms.TextBox();
            this.callNumberTextBox = new System.Windows.Forms.TextBox();
            this.libraryBookGroupBox = new System.Windows.Forms.GroupBox();
            this.libraryBookListBox = new System.Windows.Forms.ListBox();
            this.actionGroupBox = new System.Windows.Forms.GroupBox();
            this.addLibraryBookButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.libraryBookInformationGroupBox.SuspendLayout();
            this.libraryBookGroupBox.SuspendLayout();
            this.actionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // libraryBookInformationGroupBox
            // 
            this.libraryBookInformationGroupBox.Controls.Add(this.addLibraryBookButton);
            this.libraryBookInformationGroupBox.Controls.Add(this.callNumberTextBox);
            this.libraryBookInformationGroupBox.Controls.Add(this.copyrightYearTextBox);
            this.libraryBookInformationGroupBox.Controls.Add(this.publisherTextBox);
            this.libraryBookInformationGroupBox.Controls.Add(this.authorTextBox);
            this.libraryBookInformationGroupBox.Controls.Add(this.titleTextBox);
            this.libraryBookInformationGroupBox.Controls.Add(this.callNumberLabel);
            this.libraryBookInformationGroupBox.Controls.Add(this.copyrightYearLabel);
            this.libraryBookInformationGroupBox.Controls.Add(this.publisherLabel);
            this.libraryBookInformationGroupBox.Controls.Add(this.authorLabel);
            this.libraryBookInformationGroupBox.Controls.Add(this.titleLabel);
            this.libraryBookInformationGroupBox.Location = new System.Drawing.Point(13, 13);
            this.libraryBookInformationGroupBox.Name = "libraryBookInformationGroupBox";
            this.libraryBookInformationGroupBox.Size = new System.Drawing.Size(212, 207);
            this.libraryBookInformationGroupBox.TabIndex = 0;
            this.libraryBookInformationGroupBox.TabStop = false;
            this.libraryBookInformationGroupBox.Text = "Enter Library Book Information";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(66, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(55, 51);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author:";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(43, 77);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(53, 13);
            this.publisherLabel.TabIndex = 2;
            this.publisherLabel.Text = "Publisher:";
            // 
            // copyrightYearLabel
            // 
            this.copyrightYearLabel.AutoSize = true;
            this.copyrightYearLabel.Location = new System.Drawing.Point(17, 103);
            this.copyrightYearLabel.Name = "copyrightYearLabel";
            this.copyrightYearLabel.Size = new System.Drawing.Size(79, 13);
            this.copyrightYearLabel.TabIndex = 3;
            this.copyrightYearLabel.Text = "Copyright Year:";
            // 
            // callNumberLabel
            // 
            this.callNumberLabel.AutoSize = true;
            this.callNumberLabel.Location = new System.Drawing.Point(29, 129);
            this.callNumberLabel.Name = "callNumberLabel";
            this.callNumberLabel.Size = new System.Drawing.Size(67, 13);
            this.callNumberLabel.TabIndex = 4;
            this.callNumberLabel.Text = "Call Number:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(102, 22);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 5;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(102, 48);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(100, 20);
            this.authorTextBox.TabIndex = 6;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(102, 74);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(100, 20);
            this.publisherTextBox.TabIndex = 7;
            // 
            // copyrightYearTextBox
            // 
            this.copyrightYearTextBox.Location = new System.Drawing.Point(102, 100);
            this.copyrightYearTextBox.Name = "copyrightYearTextBox";
            this.copyrightYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.copyrightYearTextBox.TabIndex = 8;
            // 
            // callNumberTextBox
            // 
            this.callNumberTextBox.Location = new System.Drawing.Point(102, 126);
            this.callNumberTextBox.Name = "callNumberTextBox";
            this.callNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.callNumberTextBox.TabIndex = 9;
            // 
            // libraryBookGroupBox
            // 
            this.libraryBookGroupBox.Controls.Add(this.libraryBookListBox);
            this.libraryBookGroupBox.Location = new System.Drawing.Point(240, 13);
            this.libraryBookGroupBox.Name = "libraryBookGroupBox";
            this.libraryBookGroupBox.Size = new System.Drawing.Size(200, 207);
            this.libraryBookGroupBox.TabIndex = 1;
            this.libraryBookGroupBox.TabStop = false;
            this.libraryBookGroupBox.Text = "Select a Library Book";
            // 
            // libraryBookListBox
            // 
            this.libraryBookListBox.FormattingEnabled = true;
            this.libraryBookListBox.Location = new System.Drawing.Point(6, 20);
            this.libraryBookListBox.Name = "libraryBookListBox";
            this.libraryBookListBox.Size = new System.Drawing.Size(188, 186);
            this.libraryBookListBox.TabIndex = 0;
            // 
            // actionGroupBox
            // 
            this.actionGroupBox.Controls.Add(this.returnButton);
            this.actionGroupBox.Controls.Add(this.checkOutButton);
            this.actionGroupBox.Controls.Add(this.detailsButton);
            this.actionGroupBox.Location = new System.Drawing.Point(457, 13);
            this.actionGroupBox.Name = "actionGroupBox";
            this.actionGroupBox.Size = new System.Drawing.Size(99, 116);
            this.actionGroupBox.TabIndex = 2;
            this.actionGroupBox.TabStop = false;
            this.actionGroupBox.Text = "Select an Action";
            // 
            // addLibraryBookButton
            // 
            this.addLibraryBookButton.Location = new System.Drawing.Point(58, 166);
            this.addLibraryBookButton.Name = "addLibraryBookButton";
            this.addLibraryBookButton.Size = new System.Drawing.Size(97, 23);
            this.addLibraryBookButton.TabIndex = 10;
            this.addLibraryBookButton.Text = "Add Library Book";
            this.addLibraryBookButton.UseVisualStyleBackColor = true;
            this.addLibraryBookButton.Click += new System.EventHandler(this.addLibraryBookButton_Click);
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(6, 22);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(75, 23);
            this.detailsButton.TabIndex = 0;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(7, 52);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(75, 23);
            this.checkOutButton.TabIndex = 1;
            this.checkOutButton.Text = "Check Out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(7, 81);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 227);
            this.Controls.Add(this.actionGroupBox);
            this.Controls.Add(this.libraryBookGroupBox);
            this.Controls.Add(this.libraryBookInformationGroupBox);
            this.Name = "LibraryForm";
            this.Text = "Program 4";
            this.libraryBookInformationGroupBox.ResumeLayout(false);
            this.libraryBookInformationGroupBox.PerformLayout();
            this.libraryBookGroupBox.ResumeLayout(false);
            this.actionGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox libraryBookInformationGroupBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label copyrightYearLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox callNumberTextBox;
        private System.Windows.Forms.TextBox copyrightYearTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label callNumberLabel;
        private System.Windows.Forms.GroupBox libraryBookGroupBox;
        private System.Windows.Forms.ListBox libraryBookListBox;
        private System.Windows.Forms.GroupBox actionGroupBox;
        private System.Windows.Forms.Button addLibraryBookButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Button detailsButton;
    }
}


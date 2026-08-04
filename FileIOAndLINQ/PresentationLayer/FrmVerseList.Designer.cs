namespace FileIOAndLINQ.PresentationLayer
{
    partial class FrmVerseList
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
            mnsFileActions = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            grpAddVerse = new GroupBox();
            btnAddVerse = new Button();
            lblImportanceError = new Label();
            lblTextError = new Label();
            lblVerseError = new Label();
            lblMeaningError = new Label();
            lblChapterError = new Label();
            lblBookError = new Label();
            nudVerseImportance = new NumericUpDown();
            txtVerseMeaning = new TextBox();
            txtVerseText = new TextBox();
            txtVerseVerse = new TextBox();
            label6 = new Label();
            txtVerseChapter = new TextBox();
            cmbVerseBook = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpFilterAndSort = new GroupBox();
            rdoShowMostValuable = new RadioButton();
            rdoShowLeastValuable = new RadioButton();
            rdoShowAll = new RadioButton();
            trbNumberToShow = new TrackBar();
            dgvVerseDisplay = new DataGridView();
            mnsFileActions.SuspendLayout();
            grpAddVerse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudVerseImportance).BeginInit();
            grpFilterAndSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbNumberToShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVerseDisplay).BeginInit();
            SuspendLayout();
            // 
            // mnsFileActions
            // 
            mnsFileActions.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            mnsFileActions.Location = new Point(0, 0);
            mnsFileActions.Name = "mnsFileActions";
            mnsFileActions.Size = new Size(1163, 24);
            mnsFileActions.TabIndex = 0;
            mnsFileActions.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += TsmSaveClickEH;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(180, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += TsmLoadClickEh;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // grpAddVerse
            // 
            grpAddVerse.Controls.Add(btnAddVerse);
            grpAddVerse.Controls.Add(lblImportanceError);
            grpAddVerse.Controls.Add(lblTextError);
            grpAddVerse.Controls.Add(lblVerseError);
            grpAddVerse.Controls.Add(lblMeaningError);
            grpAddVerse.Controls.Add(lblChapterError);
            grpAddVerse.Controls.Add(lblBookError);
            grpAddVerse.Controls.Add(nudVerseImportance);
            grpAddVerse.Controls.Add(txtVerseMeaning);
            grpAddVerse.Controls.Add(txtVerseText);
            grpAddVerse.Controls.Add(txtVerseVerse);
            grpAddVerse.Controls.Add(label6);
            grpAddVerse.Controls.Add(txtVerseChapter);
            grpAddVerse.Controls.Add(cmbVerseBook);
            grpAddVerse.Controls.Add(label5);
            grpAddVerse.Controls.Add(label3);
            grpAddVerse.Controls.Add(label4);
            grpAddVerse.Controls.Add(label2);
            grpAddVerse.Controls.Add(label1);
            grpAddVerse.Location = new Point(12, 27);
            grpAddVerse.Name = "grpAddVerse";
            grpAddVerse.Size = new Size(357, 462);
            grpAddVerse.TabIndex = 1;
            grpAddVerse.TabStop = false;
            grpAddVerse.Text = "Add A Bible Verse";
            // 
            // btnAddVerse
            // 
            btnAddVerse.Location = new Point(131, 433);
            btnAddVerse.Name = "btnAddVerse";
            btnAddVerse.Size = new Size(75, 23);
            btnAddVerse.TabIndex = 18;
            btnAddVerse.Text = "Add";
            btnAddVerse.UseVisualStyleBackColor = true;
            btnAddVerse.Click += BtnAddVerseClickEH;
            // 
            // lblImportanceError
            // 
            lblImportanceError.AutoSize = true;
            lblImportanceError.ForeColor = Color.Red;
            lblImportanceError.Location = new Point(87, 406);
            lblImportanceError.Name = "lblImportanceError";
            lblImportanceError.Size = new Size(96, 15);
            lblImportanceError.TabIndex = 17;
            lblImportanceError.Text = "Importance Error";
            // 
            // lblTextError
            // 
            lblTextError.AutoSize = true;
            lblTextError.ForeColor = Color.Red;
            lblTextError.Location = new Point(87, 253);
            lblTextError.Name = "lblTextError";
            lblTextError.Size = new Size(56, 15);
            lblTextError.TabIndex = 15;
            lblTextError.Text = "Text Error";
            // 
            // lblVerseError
            // 
            lblVerseError.AutoSize = true;
            lblVerseError.ForeColor = Color.Red;
            lblVerseError.Location = new Point(87, 147);
            lblVerseError.Name = "lblVerseError";
            lblVerseError.Size = new Size(62, 15);
            lblVerseError.TabIndex = 14;
            lblVerseError.Text = "Verse Error";
            // 
            // lblMeaningError
            // 
            lblMeaningError.AutoSize = true;
            lblMeaningError.ForeColor = Color.Red;
            lblMeaningError.Location = new Point(87, 360);
            lblMeaningError.Name = "lblMeaningError";
            lblMeaningError.Size = new Size(82, 15);
            lblMeaningError.TabIndex = 16;
            lblMeaningError.Text = "Meaning Error";
            // 
            // lblChapterError
            // 
            lblChapterError.AutoSize = true;
            lblChapterError.ForeColor = Color.Red;
            lblChapterError.Location = new Point(87, 96);
            lblChapterError.Name = "lblChapterError";
            lblChapterError.Size = new Size(77, 15);
            lblChapterError.TabIndex = 13;
            lblChapterError.Text = "Chapter Error";
            // 
            // lblBookError
            // 
            lblBookError.AutoSize = true;
            lblBookError.ForeColor = Color.Red;
            lblBookError.Location = new Point(87, 48);
            lblBookError.Name = "lblBookError";
            lblBookError.Size = new Size(62, 15);
            lblBookError.TabIndex = 12;
            lblBookError.Text = "Book Error";
            // 
            // nudVerseImportance
            // 
            nudVerseImportance.Location = new Point(87, 380);
            nudVerseImportance.Name = "nudVerseImportance";
            nudVerseImportance.Size = new Size(257, 23);
            nudVerseImportance.TabIndex = 11;
            nudVerseImportance.Leave += NudVerseImportanceLeaveEH;
            // 
            // txtVerseMeaning
            // 
            txtVerseMeaning.Location = new Point(87, 274);
            txtVerseMeaning.Multiline = true;
            txtVerseMeaning.Name = "txtVerseMeaning";
            txtVerseMeaning.Size = new Size(257, 83);
            txtVerseMeaning.TabIndex = 10;
            txtVerseMeaning.Leave += TxtVerseMeaningLeaveEH;
            // 
            // txtVerseText
            // 
            txtVerseText.Location = new Point(87, 167);
            txtVerseText.Multiline = true;
            txtVerseText.Name = "txtVerseText";
            txtVerseText.Size = new Size(257, 83);
            txtVerseText.TabIndex = 9;
            txtVerseText.Leave += TxtVerseTextLeaveEH;
            // 
            // txtVerseVerse
            // 
            txtVerseVerse.Location = new Point(87, 121);
            txtVerseVerse.Name = "txtVerseVerse";
            txtVerseVerse.Size = new Size(257, 23);
            txtVerseVerse.TabIndex = 8;
            txtVerseVerse.Leave += TxtVerseVerseLeaveEH;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 277);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 4;
            label6.Text = "Meaning:";
            // 
            // txtVerseChapter
            // 
            txtVerseChapter.Location = new Point(87, 70);
            txtVerseChapter.Name = "txtVerseChapter";
            txtVerseChapter.Size = new Size(257, 23);
            txtVerseChapter.TabIndex = 7;
            txtVerseChapter.Leave += TxtVerseChapterLeaveEH;
            // 
            // cmbVerseBook
            // 
            cmbVerseBook.FormattingEnabled = true;
            cmbVerseBook.Location = new Point(87, 22);
            cmbVerseBook.Name = "cmbVerseBook";
            cmbVerseBook.Size = new Size(257, 23);
            cmbVerseBook.TabIndex = 6;
            cmbVerseBook.Leave += CmbVerseBookLeaveEH;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 382);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 5;
            label5.Text = "Importance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 170);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 3;
            label3.Text = "Text:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 124);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 2;
            label4.Text = "Verse:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 73);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Chapter:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 29);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Book:";
            // 
            // grpFilterAndSort
            // 
            grpFilterAndSort.Controls.Add(rdoShowMostValuable);
            grpFilterAndSort.Controls.Add(rdoShowLeastValuable);
            grpFilterAndSort.Controls.Add(rdoShowAll);
            grpFilterAndSort.Location = new Point(12, 495);
            grpFilterAndSort.Name = "grpFilterAndSort";
            grpFilterAndSort.Size = new Size(357, 169);
            grpFilterAndSort.TabIndex = 2;
            grpFilterAndSort.TabStop = false;
            grpFilterAndSort.Text = "Filter And Sort";
            // 
            // rdoShowMostValuable
            // 
            rdoShowMostValuable.AutoSize = true;
            rdoShowMostValuable.Location = new Point(10, 106);
            rdoShowMostValuable.Name = "rdoShowMostValuable";
            rdoShowMostValuable.Size = new Size(140, 19);
            rdoShowMostValuable.TabIndex = 2;
            rdoShowMostValuable.TabStop = true;
            rdoShowMostValuable.Text = "Show Most Important";
            rdoShowMostValuable.UseVisualStyleBackColor = true;
            // 
            // rdoShowLeastValuable
            // 
            rdoShowLeastValuable.AutoSize = true;
            rdoShowLeastValuable.Location = new Point(10, 68);
            rdoShowLeastValuable.Name = "rdoShowLeastValuable";
            rdoShowLeastValuable.Size = new Size(140, 19);
            rdoShowLeastValuable.TabIndex = 1;
            rdoShowLeastValuable.TabStop = true;
            rdoShowLeastValuable.Text = "Show Least Important";
            rdoShowLeastValuable.UseVisualStyleBackColor = true;
            // 
            // rdoShowAll
            // 
            rdoShowAll.AutoSize = true;
            rdoShowAll.Location = new Point(10, 31);
            rdoShowAll.Name = "rdoShowAll";
            rdoShowAll.Size = new Size(71, 19);
            rdoShowAll.TabIndex = 0;
            rdoShowAll.TabStop = true;
            rdoShowAll.Text = "Show All";
            rdoShowAll.UseVisualStyleBackColor = true;
            // 
            // trbNumberToShow
            // 
            trbNumberToShow.Location = new Point(12, 670);
            trbNumberToShow.Name = "trbNumberToShow";
            trbNumberToShow.Size = new Size(357, 45);
            trbNumberToShow.TabIndex = 3;
            // 
            // dgvVerseDisplay
            // 
            dgvVerseDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVerseDisplay.Location = new Point(375, 27);
            dgvVerseDisplay.Name = "dgvVerseDisplay";
            dgvVerseDisplay.Size = new Size(779, 518);
            dgvVerseDisplay.TabIndex = 4;
            // 
            // FrmVerseList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 762);
            Controls.Add(dgvVerseDisplay);
            Controls.Add(trbNumberToShow);
            Controls.Add(grpFilterAndSort);
            Controls.Add(grpAddVerse);
            Controls.Add(mnsFileActions);
            MainMenuStrip = mnsFileActions;
            Name = "FrmVerseList";
            Text = "FrmVerseList";
            mnsFileActions.ResumeLayout(false);
            mnsFileActions.PerformLayout();
            grpAddVerse.ResumeLayout(false);
            grpAddVerse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudVerseImportance).EndInit();
            grpFilterAndSort.ResumeLayout(false);
            grpFilterAndSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbNumberToShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVerseDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsFileActions;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private GroupBox grpAddVerse;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox cmbVerseBook;
        private TextBox txtVerseChapter;
        private TextBox txtVerseVerse;
        private TextBox txtVerseMeaning;
        private TextBox txtVerseText;
        private NumericUpDown nudVerseImportance;
        private Label lblChapterError;
        private Label lblBookError;
        private Label lblImportanceError;
        private Label lblTextError;
        private Label lblVerseError;
        private Label lblMeaningError;
        private GroupBox grpFilterAndSort;
        private RadioButton rdoShowMostValuable;
        private RadioButton rdoShowLeastValuable;
        private RadioButton rdoShowAll;
        private TrackBar trbNumberToShow;
        private DataGridView dgvVerseDisplay;
        private Button btnAddVerse;
    }
}
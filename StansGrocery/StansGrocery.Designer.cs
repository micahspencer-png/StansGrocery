namespace StansGrocery
{
    partial class StansGrocery
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ContextMenuStrip = new ContextMenuStrip(components);
            TopMenuStrip = new MenuStrip();
            MainToolTip = new ToolTip(components);
            fileToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            SearchButton = new Button();
            FilterGroupBox = new GroupBox();
            FilterByAisleRadioButton = new RadioButton();
            FilterByCategoryRadioButton = new RadioButton();
            FilterComboBox = new ComboBox();
            DisplayListBox = new ListBox();
            SearchTextBox = new TextBox();
            DisplayLabel = new Label();
            ContextMenuStrip.SuspendLayout();
            TopMenuStrip.SuspendLayout();
            FilterGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContextMenuStrip.ImageScalingSize = new Size(20, 20);
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { searchToolStripMenuItem1, exitToolStripMenuItem1 });
            ContextMenuStrip.Name = "ContextMenuStrip";
            ContextMenuStrip.Size = new Size(125, 52);
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(20, 20);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(996, 27);
            TopMenuStrip.TabIndex = 1;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(50, 23);
            fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(56, 23);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(224, 26);
            aboutToolStripMenuItem.Text = "About";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(224, 26);
            searchToolStripMenuItem.Text = "Search";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // searchToolStripMenuItem1
            // 
            searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            searchToolStripMenuItem1.Size = new Size(124, 24);
            searchToolStripMenuItem1.Text = "Search";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(124, 24);
            exitToolStripMenuItem1.Text = "Exit";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(118, 420);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(151, 65);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Accept";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // FilterGroupBox
            // 
            FilterGroupBox.Controls.Add(FilterByCategoryRadioButton);
            FilterGroupBox.Controls.Add(FilterByAisleRadioButton);
            FilterGroupBox.Location = new Point(593, 450);
            FilterGroupBox.Name = "FilterGroupBox";
            FilterGroupBox.Size = new Size(391, 97);
            FilterGroupBox.TabIndex = 3;
            FilterGroupBox.TabStop = false;
            FilterGroupBox.Text = "Filters";
            // 
            // FilterByAisleRadioButton
            // 
            FilterByAisleRadioButton.AutoSize = true;
            FilterByAisleRadioButton.Location = new Point(134, 23);
            FilterByAisleRadioButton.Name = "FilterByAisleRadioButton";
            FilterByAisleRadioButton.Size = new Size(62, 24);
            FilterByAisleRadioButton.TabIndex = 0;
            FilterByAisleRadioButton.TabStop = true;
            FilterByAisleRadioButton.Text = "Aisle";
            FilterByAisleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FilterByCategoryRadioButton
            // 
            FilterByCategoryRadioButton.AutoSize = true;
            FilterByCategoryRadioButton.Location = new Point(134, 53);
            FilterByCategoryRadioButton.Name = "FilterByCategoryRadioButton";
            FilterByCategoryRadioButton.Size = new Size(90, 24);
            FilterByCategoryRadioButton.TabIndex = 0;
            FilterByCategoryRadioButton.TabStop = true;
            FilterByCategoryRadioButton.Text = "Category";
            FilterByCategoryRadioButton.UseVisualStyleBackColor = true;
            // 
            // FilterComboBox
            // 
            FilterComboBox.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterComboBox.FormattingEnabled = true;
            FilterComboBox.Location = new Point(40, 84);
            FilterComboBox.Name = "FilterComboBox";
            FilterComboBox.Size = new Size(151, 27);
            FilterComboBox.TabIndex = 4;
            // 
            // DisplayListBox
            // 
            DisplayListBox.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DisplayListBox.FormattingEnabled = true;
            DisplayListBox.ItemHeight = 19;
            DisplayListBox.Location = new Point(419, 100);
            DisplayListBox.Name = "DisplayListBox";
            DisplayListBox.Size = new Size(508, 251);
            DisplayListBox.TabIndex = 5;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTextBox.Location = new Point(40, 172);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(155, 27);
            SearchTextBox.TabIndex = 6;
            // 
            // DisplayLabel
            // 
            DisplayLabel.AutoSize = true;
            DisplayLabel.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DisplayLabel.Location = new Point(457, 55);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(51, 19);
            DisplayLabel.TabIndex = 7;
            DisplayLabel.Text = "label1";
            // 
            // StansGrocery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 559);
            Controls.Add(DisplayLabel);
            Controls.Add(SearchTextBox);
            Controls.Add(DisplayListBox);
            Controls.Add(FilterComboBox);
            Controls.Add(SearchButton);
            Controls.Add(FilterGroupBox);
            Controls.Add(TopMenuStrip);
            MainMenuStrip = TopMenuStrip;
            Name = "StansGrocery";
            Text = "Stans Grocery";
            ContextMenuStrip.ResumeLayout(false);
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            FilterGroupBox.ResumeLayout(false);
            FilterGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip ContextMenuStrip;
        private MenuStrip TopMenuStrip;
        private ToolTip MainToolTip;
        private ToolStripMenuItem searchToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button SearchButton;
        private GroupBox FilterGroupBox;
        private RadioButton FilterByCategoryRadioButton;
        private RadioButton FilterByAisleRadioButton;
        private ComboBox FilterComboBox;
        private ListBox DisplayListBox;
        private TextBox SearchTextBox;
        private Label DisplayLabel;
    }
}

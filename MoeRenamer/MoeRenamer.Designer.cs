namespace MoeRenamer {
	partial class MoeRenamer {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoeRenamer));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnDestFolder = new System.Windows.Forms.Button();
			this.btnSourceFolder = new System.Windows.Forms.Button();
			this.tbDest = new System.Windows.Forms.TextBox();
			this.tbSource = new System.Windows.Forms.TextBox();
			this.lblDest = new System.Windows.Forms.Label();
			this.lblSource = new System.Windows.Forms.Label();
			this.lstDest = new System.Windows.Forms.ListView();
			this.newFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lstSource = new System.Windows.Forms.ListView();
			this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnClear = new System.Windows.Forms.Button();
			this.grpInsertRemove = new System.Windows.Forms.GroupBox();
			this.btnClearInsert = new System.Windows.Forms.Button();
			this.txtExactPos = new System.Windows.Forms.TextBox();
			this.lblExactPosition = new System.Windows.Forms.Label();
			this.radMove = new System.Windows.Forms.RadioButton();
			this.radRemove = new System.Windows.Forms.RadioButton();
			this.cmbNewPosition = new System.Windows.Forms.ComboBox();
			this.radInsert = new System.Windows.Forms.RadioButton();
			this.lblTextPosition = new System.Windows.Forms.Label();
			this.txtLength = new System.Windows.Forms.TextBox();
			this.lblLength = new System.Windows.Forms.Label();
			this.txtStartPos = new System.Windows.Forms.TextBox();
			this.lblStartPos = new System.Windows.Forms.Label();
			this.txtInsRemText = new System.Windows.Forms.TextBox();
			this.lblInsRemText = new System.Windows.Forms.Label();
			this.btnTestRename = new System.Windows.Forms.Button();
			this.grpPrefixSuffix = new System.Windows.Forms.GroupBox();
			this.btnClearPrefixSuffix = new System.Windows.Forms.Button();
			this.txtStartNumber = new System.Windows.Forms.TextBox();
			this.lblStartNumber = new System.Windows.Forms.Label();
			this.chkRandomize = new System.Windows.Forms.CheckBox();
			this.chkNumberFiles = new System.Windows.Forms.CheckBox();
			this.txtPadChar = new System.Windows.Forms.TextBox();
			this.lblPadChar = new System.Windows.Forms.Label();
			this.txtPadSize = new System.Windows.Forms.TextBox();
			this.lblPadSize = new System.Windows.Forms.Label();
			this.txtNewTextSep = new System.Windows.Forms.TextBox();
			this.lblNewTextSep = new System.Windows.Forms.Label();
			this.radSuffix = new System.Windows.Forms.RadioButton();
			this.radPrefix = new System.Windows.Forms.RadioButton();
			this.btnRenameFiles = new System.Windows.Forms.Button();
			this.grpMainRename = new System.Windows.Forms.GroupBox();
			this.txtReplChars = new System.Windows.Forms.TextBox();
			this.txtOrigChars = new System.Windows.Forms.TextBox();
			this.lblReplChars = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblOrigChars = new System.Windows.Forms.Label();
			this.txtNewExtension = new System.Windows.Forms.TextBox();
			this.btnClearChangeCase = new System.Windows.Forms.Button();
			this.radToCamel = new System.Windows.Forms.RadioButton();
			this.radToUpper = new System.Windows.Forms.RadioButton();
			this.radToLower = new System.Windows.Forms.RadioButton();
			this.lblChangeCase = new System.Windows.Forms.Label();
			this.chkDelDupSpace = new System.Windows.Forms.CheckBox();
			this.chkChangeExtension = new System.Windows.Forms.CheckBox();
			this.txtNewText = new System.Windows.Forms.TextBox();
			this.lblNewText = new System.Windows.Forms.Label();
			this.txtOldText = new System.Windows.Forms.TextBox();
			this.lblOldText = new System.Windows.Forms.Label();
			this.grpDefaultValues = new System.Windows.Forms.GroupBox();
			this.chkIncludeSep = new System.Windows.Forms.CheckBox();
			this.chkIgnoreExtension = new System.Windows.Forms.CheckBox();
			this.chkIgnoreCase = new System.Windows.Forms.CheckBox();
			this.txtDefaultDelimiter = new System.Windows.Forms.TextBox();
			this.lblDefaultDelimiter = new System.Windows.Forms.Label();
			this.txtDefaultSeparator = new System.Windows.Forms.TextBox();
			this.lblDefaultSeparator = new System.Windows.Forms.Label();
			this.toolTipRenamer = new System.Windows.Forms.ToolTip(this.components);
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.grpInsertRemove.SuspendLayout();
			this.grpPrefixSuffix.SuspendLayout();
			this.grpMainRename.SuspendLayout();
			this.grpDefaultValues.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.btnDestFolder);
			this.splitContainer1.Panel1.Controls.Add(this.btnSourceFolder);
			this.splitContainer1.Panel1.Controls.Add(this.tbDest);
			this.splitContainer1.Panel1.Controls.Add(this.tbSource);
			this.splitContainer1.Panel1.Controls.Add(this.lblDest);
			this.splitContainer1.Panel1.Controls.Add(this.lblSource);
			this.splitContainer1.Panel1.Controls.Add(this.lstDest);
			this.splitContainer1.Panel1.Controls.Add(this.lstSource);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.btnClear);
			this.splitContainer1.Panel2.Controls.Add(this.grpInsertRemove);
			this.splitContainer1.Panel2.Controls.Add(this.btnTestRename);
			this.splitContainer1.Panel2.Controls.Add(this.grpPrefixSuffix);
			this.splitContainer1.Panel2.Controls.Add(this.btnRenameFiles);
			this.splitContainer1.Panel2.Controls.Add(this.grpMainRename);
			this.splitContainer1.Panel2.Controls.Add(this.grpDefaultValues);
			this.splitContainer1.Size = new System.Drawing.Size(909, 679);
			this.splitContainer1.SplitterDistance = 536;
			this.splitContainer1.TabIndex = 0;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(12, 615);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(511, 22);
			this.richTextBox1.TabIndex = 9;
			this.richTextBox1.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 583);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(511, 32);
			this.label2.TabIndex = 8;
			this.label2.Text = "         1         2         3         4         5         6         7\r\n123456789" +
    "0123456789012345678901234567890123456789012345678901234567890";
			// 
			// btnDestFolder
			// 
			this.btnDestFolder.Location = new System.Drawing.Point(444, 281);
			this.btnDestFolder.Name = "btnDestFolder";
			this.btnDestFolder.Size = new System.Drawing.Size(89, 23);
			this.btnDestFolder.TabIndex = 7;
			this.btnDestFolder.Text = "Change Folder";
			this.btnDestFolder.UseVisualStyleBackColor = true;
			this.btnDestFolder.Click += new System.EventHandler(this.btnDestFolder_Click);
			// 
			// btnSourceFolder
			// 
			this.btnSourceFolder.Location = new System.Drawing.Point(458, 12);
			this.btnSourceFolder.Name = "btnSourceFolder";
			this.btnSourceFolder.Size = new System.Drawing.Size(75, 23);
			this.btnSourceFolder.TabIndex = 6;
			this.btnSourceFolder.Text = "Get Files";
			this.btnSourceFolder.UseVisualStyleBackColor = true;
			this.btnSourceFolder.Click += new System.EventHandler(this.btnSourceFolder_Click);
			// 
			// tbDest
			// 
			this.tbDest.Location = new System.Drawing.Point(102, 283);
			this.tbDest.Name = "tbDest";
			this.tbDest.Size = new System.Drawing.Size(336, 20);
			this.tbDest.TabIndex = 5;
			// 
			// tbSource
			// 
			this.tbSource.Location = new System.Drawing.Point(83, 14);
			this.tbSource.Name = "tbSource";
			this.tbSource.Size = new System.Drawing.Size(369, 20);
			this.tbSource.TabIndex = 4;
			this.tbSource.TextChanged += new System.EventHandler(this.tbSource_TextChanged);
			this.tbSource.DoubleClick += new System.EventHandler(this.tbSource_OnDoubleClick);
			// 
			// lblDest
			// 
			this.lblDest.AutoSize = true;
			this.lblDest.Location = new System.Drawing.Point(4, 286);
			this.lblDest.Name = "lblDest";
			this.lblDest.Size = new System.Drawing.Size(92, 13);
			this.lblDest.TabIndex = 3;
			this.lblDest.Text = "Destination Folder";
			// 
			// lblSource
			// 
			this.lblSource.AutoSize = true;
			this.lblSource.Location = new System.Drawing.Point(4, 17);
			this.lblSource.Name = "lblSource";
			this.lblSource.Size = new System.Drawing.Size(73, 13);
			this.lblSource.TabIndex = 2;
			this.lblSource.Text = "Source Folder";
			// 
			// lstDest
			// 
			this.lstDest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.newFileName});
			this.lstDest.Location = new System.Drawing.Point(3, 310);
			this.lstDest.Name = "lstDest";
			this.lstDest.Size = new System.Drawing.Size(530, 256);
			this.lstDest.TabIndex = 1;
			this.lstDest.UseCompatibleStateImageBehavior = false;
			this.lstDest.View = System.Windows.Forms.View.Details;
			// 
			// newFileName
			// 
			this.newFileName.Text = "New Filename";
			this.newFileName.Width = 522;
			// 
			// lstSource
			// 
			this.lstSource.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName});
			this.lstSource.Location = new System.Drawing.Point(3, 40);
			this.lstSource.Name = "lstSource";
			this.lstSource.Size = new System.Drawing.Size(530, 234);
			this.lstSource.TabIndex = 0;
			this.lstSource.UseCompatibleStateImageBehavior = false;
			this.lstSource.View = System.Windows.Forms.View.Details;
			this.lstSource.SelectedIndexChanged += new System.EventHandler(this.lstSource_SelectedIndexChanged);
			// 
			// FileName
			// 
			this.FileName.Text = "Original Filename";
			this.FileName.Width = 523;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(247, 644);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(90, 23);
			this.btnClear.TabIndex = 12;
			this.btnClear.Text = "Reset Form";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// grpInsertRemove
			// 
			this.grpInsertRemove.BackColor = System.Drawing.SystemColors.Control;
			this.grpInsertRemove.Controls.Add(this.btnClearInsert);
			this.grpInsertRemove.Controls.Add(this.txtExactPos);
			this.grpInsertRemove.Controls.Add(this.lblExactPosition);
			this.grpInsertRemove.Controls.Add(this.radMove);
			this.grpInsertRemove.Controls.Add(this.radRemove);
			this.grpInsertRemove.Controls.Add(this.cmbNewPosition);
			this.grpInsertRemove.Controls.Add(this.radInsert);
			this.grpInsertRemove.Controls.Add(this.lblTextPosition);
			this.grpInsertRemove.Controls.Add(this.txtLength);
			this.grpInsertRemove.Controls.Add(this.lblLength);
			this.grpInsertRemove.Controls.Add(this.txtStartPos);
			this.grpInsertRemove.Controls.Add(this.lblStartPos);
			this.grpInsertRemove.Controls.Add(this.txtInsRemText);
			this.grpInsertRemove.Controls.Add(this.lblInsRemText);
			this.grpInsertRemove.Location = new System.Drawing.Point(3, 368);
			this.grpInsertRemove.Name = "grpInsertRemove";
			this.grpInsertRemove.Size = new System.Drawing.Size(354, 131);
			this.grpInsertRemove.TabIndex = 2;
			this.grpInsertRemove.TabStop = false;
			this.grpInsertRemove.Text = "Insert / Remove / Move";
			// 
			// btnClearInsert
			// 
			this.btnClearInsert.Location = new System.Drawing.Point(295, 16);
			this.btnClearInsert.Name = "btnClearInsert";
			this.btnClearInsert.Size = new System.Drawing.Size(39, 23);
			this.btnClearInsert.TabIndex = 13;
			this.btnClearInsert.Text = "Clear";
			this.btnClearInsert.UseVisualStyleBackColor = true;
			this.btnClearInsert.Click += new System.EventHandler(this.btnClearInsert_Click);
			// 
			// txtExactPos
			// 
			this.txtExactPos.Enabled = false;
			this.txtExactPos.Location = new System.Drawing.Point(281, 96);
			this.txtExactPos.Name = "txtExactPos";
			this.txtExactPos.Size = new System.Drawing.Size(57, 20);
			this.txtExactPos.TabIndex = 10;
			this.txtExactPos.Text = "0";
			this.toolTipRenamer.SetToolTip(this.txtExactPos, "How many characters");
			// 
			// lblExactPosition
			// 
			this.lblExactPosition.AutoSize = true;
			this.lblExactPosition.Enabled = false;
			this.lblExactPosition.Location = new System.Drawing.Point(191, 99);
			this.lblExactPosition.Name = "lblExactPosition";
			this.lblExactPosition.Size = new System.Drawing.Size(77, 13);
			this.lblExactPosition.TabIndex = 9;
			this.lblExactPosition.Text = "Exact Position:";
			// 
			// radMove
			// 
			this.radMove.AutoSize = true;
			this.radMove.Location = new System.Drawing.Point(200, 19);
			this.radMove.Name = "radMove";
			this.radMove.Size = new System.Drawing.Size(52, 17);
			this.radMove.TabIndex = 8;
			this.radMove.TabStop = true;
			this.radMove.Text = "Move";
			this.toolTipRenamer.SetToolTip(this.radMove, "Select to move old text to new position");
			this.radMove.UseVisualStyleBackColor = true;
			this.radMove.CheckedChanged += new System.EventHandler(this.radMove_CheckedChanged);
			// 
			// radRemove
			// 
			this.radRemove.AutoSize = true;
			this.radRemove.Location = new System.Drawing.Point(102, 19);
			this.radRemove.Name = "radRemove";
			this.radRemove.Size = new System.Drawing.Size(65, 17);
			this.radRemove.TabIndex = 7;
			this.radRemove.TabStop = true;
			this.radRemove.Text = "Remove";
			this.toolTipRenamer.SetToolTip(this.radRemove, "Select to remove old text");
			this.radRemove.UseVisualStyleBackColor = true;
			this.radRemove.CheckedChanged += new System.EventHandler(this.radRemove_CheckedChanged);
			// 
			// cmbNewPosition
			// 
			this.cmbNewPosition.Enabled = false;
			this.cmbNewPosition.FormattingEnabled = true;
			this.cmbNewPosition.Items.AddRange(new object[] {
            "Beginning",
            "End",
            "Other"});
			this.cmbNewPosition.Location = new System.Drawing.Point(100, 94);
			this.cmbNewPosition.Name = "cmbNewPosition";
			this.cmbNewPosition.Size = new System.Drawing.Size(77, 21);
			this.cmbNewPosition.TabIndex = 5;
			this.toolTipRenamer.SetToolTip(this.cmbNewPosition, "Basic options for Beginning and Ending of string");
			this.cmbNewPosition.SelectedIndexChanged += new System.EventHandler(this.cmbNewPosition_SelectedIndexChanged);
			// 
			// radInsert
			// 
			this.radInsert.AutoSize = true;
			this.radInsert.Location = new System.Drawing.Point(10, 19);
			this.radInsert.Name = "radInsert";
			this.radInsert.Size = new System.Drawing.Size(51, 17);
			this.radInsert.TabIndex = 6;
			this.radInsert.TabStop = true;
			this.radInsert.Text = "Insert";
			this.toolTipRenamer.SetToolTip(this.radInsert, "Select to insert new text");
			this.radInsert.UseVisualStyleBackColor = true;
			this.radInsert.CheckedChanged += new System.EventHandler(this.radInsert_CheckedChanged);
			// 
			// lblTextPosition
			// 
			this.lblTextPosition.AutoSize = true;
			this.lblTextPosition.Enabled = false;
			this.lblTextPosition.Location = new System.Drawing.Point(7, 100);
			this.lblTextPosition.Name = "lblTextPosition";
			this.lblTextPosition.Size = new System.Drawing.Size(71, 13);
			this.lblTextPosition.TabIndex = 4;
			this.lblTextPosition.Text = "Text Position:";
			// 
			// txtLength
			// 
			this.txtLength.Enabled = false;
			this.txtLength.Location = new System.Drawing.Point(282, 68);
			this.txtLength.Name = "txtLength";
			this.txtLength.Size = new System.Drawing.Size(57, 20);
			this.txtLength.TabIndex = 5;
			this.txtLength.Text = "0";
			this.toolTipRenamer.SetToolTip(this.txtLength, "How many characters");
			this.txtLength.Validating += new System.ComponentModel.CancelEventHandler(this.txtLength_Validating);
			this.txtLength.Validated += new System.EventHandler(this.txtLength_Validated);
			// 
			// lblLength
			// 
			this.lblLength.AutoSize = true;
			this.lblLength.Enabled = false;
			this.lblLength.Location = new System.Drawing.Point(191, 71);
			this.lblLength.Name = "lblLength";
			this.lblLength.Size = new System.Drawing.Size(43, 13);
			this.lblLength.TabIndex = 4;
			this.lblLength.Text = "Length:";
			// 
			// txtStartPos
			// 
			this.txtStartPos.Enabled = false;
			this.txtStartPos.Location = new System.Drawing.Point(101, 68);
			this.txtStartPos.Name = "txtStartPos";
			this.txtStartPos.Size = new System.Drawing.Size(57, 20);
			this.txtStartPos.TabIndex = 3;
			this.txtStartPos.Text = "0";
			this.toolTipRenamer.SetToolTip(this.txtStartPos, "Enter the starting char position");
			// 
			// lblStartPos
			// 
			this.lblStartPos.AutoSize = true;
			this.lblStartPos.Enabled = false;
			this.lblStartPos.Location = new System.Drawing.Point(6, 71);
			this.lblStartPos.Name = "lblStartPos";
			this.lblStartPos.Size = new System.Drawing.Size(86, 13);
			this.lblStartPos.TabIndex = 2;
			this.lblStartPos.Text = "Starting Position:";
			// 
			// txtInsRemText
			// 
			this.txtInsRemText.Enabled = false;
			this.txtInsRemText.Location = new System.Drawing.Point(101, 42);
			this.txtInsRemText.Name = "txtInsRemText";
			this.txtInsRemText.Size = new System.Drawing.Size(238, 20);
			this.txtInsRemText.TabIndex = 1;
			this.toolTipRenamer.SetToolTip(this.txtInsRemText, "Text to insert, remove or move");
			// 
			// lblInsRemText
			// 
			this.lblInsRemText.AutoSize = true;
			this.lblInsRemText.Enabled = false;
			this.lblInsRemText.Location = new System.Drawing.Point(7, 45);
			this.lblInsRemText.Name = "lblInsRemText";
			this.lblInsRemText.Size = new System.Drawing.Size(87, 13);
			this.lblInsRemText.TabIndex = 0;
			this.lblInsRemText.Text = "Text to Ins/Rem:";
			// 
			// btnTestRename
			// 
			this.btnTestRename.Location = new System.Drawing.Point(15, 644);
			this.btnTestRename.Name = "btnTestRename";
			this.btnTestRename.Size = new System.Drawing.Size(90, 23);
			this.btnTestRename.TabIndex = 11;
			this.btnTestRename.Text = "Test Only";
			this.btnTestRename.UseVisualStyleBackColor = true;
			this.btnTestRename.Click += new System.EventHandler(this.btnTestRename_Click);
			// 
			// grpPrefixSuffix
			// 
			this.grpPrefixSuffix.BackColor = System.Drawing.SystemColors.Control;
			this.grpPrefixSuffix.Controls.Add(this.btnClearPrefixSuffix);
			this.grpPrefixSuffix.Controls.Add(this.txtStartNumber);
			this.grpPrefixSuffix.Controls.Add(this.lblStartNumber);
			this.grpPrefixSuffix.Controls.Add(this.chkRandomize);
			this.grpPrefixSuffix.Controls.Add(this.chkNumberFiles);
			this.grpPrefixSuffix.Controls.Add(this.txtPadChar);
			this.grpPrefixSuffix.Controls.Add(this.lblPadChar);
			this.grpPrefixSuffix.Controls.Add(this.txtPadSize);
			this.grpPrefixSuffix.Controls.Add(this.lblPadSize);
			this.grpPrefixSuffix.Controls.Add(this.txtNewTextSep);
			this.grpPrefixSuffix.Controls.Add(this.lblNewTextSep);
			this.grpPrefixSuffix.Controls.Add(this.radSuffix);
			this.grpPrefixSuffix.Controls.Add(this.radPrefix);
			this.grpPrefixSuffix.Location = new System.Drawing.Point(3, 215);
			this.grpPrefixSuffix.Name = "grpPrefixSuffix";
			this.grpPrefixSuffix.Size = new System.Drawing.Size(354, 147);
			this.grpPrefixSuffix.TabIndex = 1;
			this.grpPrefixSuffix.TabStop = false;
			this.grpPrefixSuffix.Text = "Prefix/Suffix";
			// 
			// btnClearPrefixSuffix
			// 
			this.btnClearPrefixSuffix.Location = new System.Drawing.Point(204, 17);
			this.btnClearPrefixSuffix.Name = "btnClearPrefixSuffix";
			this.btnClearPrefixSuffix.Size = new System.Drawing.Size(39, 23);
			this.btnClearPrefixSuffix.TabIndex = 12;
			this.btnClearPrefixSuffix.Text = "Clear";
			this.btnClearPrefixSuffix.UseVisualStyleBackColor = true;
			this.btnClearPrefixSuffix.Click += new System.EventHandler(this.btnClearPrefixSuffix_Click);
			// 
			// txtStartNumber
			// 
			this.txtStartNumber.Enabled = false;
			this.txtStartNumber.Location = new System.Drawing.Point(281, 77);
			this.txtStartNumber.Name = "txtStartNumber";
			this.txtStartNumber.Size = new System.Drawing.Size(60, 20);
			this.txtStartNumber.TabIndex = 11;
			this.txtStartNumber.Text = "1";
			this.toolTipRenamer.SetToolTip(this.txtStartNumber, "In case you want to start at something other then 1");
			// 
			// lblStartNumber
			// 
			this.lblStartNumber.AutoSize = true;
			this.lblStartNumber.Enabled = false;
			this.lblStartNumber.Location = new System.Drawing.Point(191, 80);
			this.lblStartNumber.Name = "lblStartNumber";
			this.lblStartNumber.Size = new System.Drawing.Size(69, 13);
			this.lblStartNumber.TabIndex = 10;
			this.lblStartNumber.Text = "First Number:";
			// 
			// chkRandomize
			// 
			this.chkRandomize.AutoSize = true;
			this.chkRandomize.Enabled = false;
			this.chkRandomize.Location = new System.Drawing.Point(102, 77);
			this.chkRandomize.Name = "chkRandomize";
			this.chkRandomize.Size = new System.Drawing.Size(79, 17);
			this.chkRandomize.TabIndex = 9;
			this.chkRandomize.Text = "Randomize";
			this.toolTipRenamer.SetToolTip(this.chkRandomize, "Check if you want those numbers to be randomized");
			this.chkRandomize.UseVisualStyleBackColor = true;
			// 
			// chkNumberFiles
			// 
			this.chkNumberFiles.AutoSize = true;
			this.chkNumberFiles.Enabled = false;
			this.chkNumberFiles.Location = new System.Drawing.Point(11, 79);
			this.chkNumberFiles.Name = "chkNumberFiles";
			this.chkNumberFiles.Size = new System.Drawing.Size(87, 17);
			this.chkNumberFiles.TabIndex = 8;
			this.chkNumberFiles.Text = "Number Files";
			this.toolTipRenamer.SetToolTip(this.chkNumberFiles, "Check if you want to generate automatic numbering");
			this.chkNumberFiles.UseVisualStyleBackColor = true;
			this.chkNumberFiles.CheckedChanged += new System.EventHandler(this.chkNumberFiles_CheckedChanged);
			// 
			// txtPadChar
			// 
			this.txtPadChar.Enabled = false;
			this.txtPadChar.Location = new System.Drawing.Point(281, 105);
			this.txtPadChar.Name = "txtPadChar";
			this.txtPadChar.Size = new System.Drawing.Size(60, 20);
			this.txtPadChar.TabIndex = 7;
			this.txtPadChar.Text = "0";
			this.toolTipRenamer.SetToolTip(this.txtPadChar, "Character to use for padding");
			// 
			// lblPadChar
			// 
			this.lblPadChar.AutoSize = true;
			this.lblPadChar.Enabled = false;
			this.lblPadChar.Location = new System.Drawing.Point(191, 108);
			this.lblPadChar.Name = "lblPadChar";
			this.lblPadChar.Size = new System.Drawing.Size(74, 13);
			this.lblPadChar.TabIndex = 6;
			this.lblPadChar.Text = "Padding Char:";
			// 
			// txtPadSize
			// 
			this.txtPadSize.Enabled = false;
			this.txtPadSize.Location = new System.Drawing.Point(102, 105);
			this.txtPadSize.Name = "txtPadSize";
			this.txtPadSize.Size = new System.Drawing.Size(58, 20);
			this.txtPadSize.TabIndex = 5;
			this.txtPadSize.Text = "4";
			this.toolTipRenamer.SetToolTip(this.txtPadSize, "Number of chars to pad value to");
			// 
			// lblPadSize
			// 
			this.lblPadSize.AutoSize = true;
			this.lblPadSize.Enabled = false;
			this.lblPadSize.Location = new System.Drawing.Point(8, 108);
			this.lblPadSize.Name = "lblPadSize";
			this.lblPadSize.Size = new System.Drawing.Size(72, 13);
			this.lblPadSize.TabIndex = 4;
			this.lblPadSize.Text = "Padding Size:";
			// 
			// txtNewTextSep
			// 
			this.txtNewTextSep.Enabled = false;
			this.txtNewTextSep.Location = new System.Drawing.Point(101, 47);
			this.txtNewTextSep.Name = "txtNewTextSep";
			this.txtNewTextSep.Size = new System.Drawing.Size(240, 20);
			this.txtNewTextSep.TabIndex = 3;
			this.toolTipRenamer.SetToolTip(this.txtNewTextSep, "The new text to add");
			// 
			// lblNewTextSep
			// 
			this.lblNewTextSep.AutoSize = true;
			this.lblNewTextSep.Enabled = false;
			this.lblNewTextSep.Location = new System.Drawing.Point(6, 50);
			this.lblNewTextSep.Name = "lblNewTextSep";
			this.lblNewTextSep.Size = new System.Drawing.Size(88, 13);
			this.lblNewTextSep.TabIndex = 2;
			this.lblNewTextSep.Text = "Text / Separator:";
			// 
			// radSuffix
			// 
			this.radSuffix.AutoSize = true;
			this.radSuffix.Location = new System.Drawing.Point(101, 20);
			this.radSuffix.Name = "radSuffix";
			this.radSuffix.Size = new System.Drawing.Size(51, 17);
			this.radSuffix.TabIndex = 1;
			this.radSuffix.TabStop = true;
			this.radSuffix.Text = "Suffix";
			this.toolTipRenamer.SetToolTip(this.radSuffix, "Select to add new text as a suffix");
			this.radSuffix.UseVisualStyleBackColor = true;
			this.radSuffix.CheckedChanged += new System.EventHandler(this.radSuffix_CheckedChanged);
			// 
			// radPrefix
			// 
			this.radPrefix.AutoSize = true;
			this.radPrefix.Location = new System.Drawing.Point(10, 20);
			this.radPrefix.Name = "radPrefix";
			this.radPrefix.Size = new System.Drawing.Size(51, 17);
			this.radPrefix.TabIndex = 0;
			this.radPrefix.TabStop = true;
			this.radPrefix.Text = "Prefix";
			this.toolTipRenamer.SetToolTip(this.radPrefix, "Select to add new text as a prefix");
			this.radPrefix.UseVisualStyleBackColor = true;
			this.radPrefix.CheckedChanged += new System.EventHandler(this.radPrefix_CheckedChanged);
			// 
			// btnRenameFiles
			// 
			this.btnRenameFiles.Location = new System.Drawing.Point(131, 644);
			this.btnRenameFiles.Name = "btnRenameFiles";
			this.btnRenameFiles.Size = new System.Drawing.Size(90, 23);
			this.btnRenameFiles.TabIndex = 10;
			this.btnRenameFiles.Text = "Rename Files";
			this.btnRenameFiles.UseVisualStyleBackColor = true;
			this.btnRenameFiles.Click += new System.EventHandler(this.btnRenameFiles_Click);
			// 
			// grpMainRename
			// 
			this.grpMainRename.BackColor = System.Drawing.SystemColors.Control;
			this.grpMainRename.Controls.Add(this.txtReplChars);
			this.grpMainRename.Controls.Add(this.txtOrigChars);
			this.grpMainRename.Controls.Add(this.lblReplChars);
			this.grpMainRename.Controls.Add(this.label3);
			this.grpMainRename.Controls.Add(this.lblOrigChars);
			this.grpMainRename.Controls.Add(this.txtNewExtension);
			this.grpMainRename.Controls.Add(this.btnClearChangeCase);
			this.grpMainRename.Controls.Add(this.radToCamel);
			this.grpMainRename.Controls.Add(this.radToUpper);
			this.grpMainRename.Controls.Add(this.radToLower);
			this.grpMainRename.Controls.Add(this.lblChangeCase);
			this.grpMainRename.Controls.Add(this.chkDelDupSpace);
			this.grpMainRename.Controls.Add(this.chkChangeExtension);
			this.grpMainRename.Controls.Add(this.txtNewText);
			this.grpMainRename.Controls.Add(this.lblNewText);
			this.grpMainRename.Controls.Add(this.txtOldText);
			this.grpMainRename.Controls.Add(this.lblOldText);
			this.grpMainRename.Location = new System.Drawing.Point(3, 13);
			this.grpMainRename.Name = "grpMainRename";
			this.grpMainRename.Size = new System.Drawing.Size(354, 196);
			this.grpMainRename.TabIndex = 0;
			this.grpMainRename.TabStop = false;
			this.grpMainRename.Text = "Main Options";
			// 
			// txtReplChars
			// 
			this.txtReplChars.Location = new System.Drawing.Point(289, 127);
			this.txtReplChars.Name = "txtReplChars";
			this.txtReplChars.Size = new System.Drawing.Size(52, 20);
			this.txtReplChars.TabIndex = 15;
			// 
			// txtOrigChars
			// 
			this.txtOrigChars.Location = new System.Drawing.Point(289, 102);
			this.txtOrigChars.Name = "txtOrigChars";
			this.txtOrigChars.Size = new System.Drawing.Size(52, 20);
			this.txtOrigChars.TabIndex = 14;
			// 
			// lblReplChars
			// 
			this.lblReplChars.AutoSize = true;
			this.lblReplChars.Location = new System.Drawing.Point(208, 130);
			this.lblReplChars.Name = "lblReplChars";
			this.lblReplChars.Size = new System.Drawing.Size(62, 13);
			this.lblReplChars.TabIndex = 17;
			this.lblReplChars.Text = "New Chars:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(191, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Replace Mult. Chars:";
			// 
			// lblOrigChars
			// 
			this.lblOrigChars.AutoSize = true;
			this.lblOrigChars.Location = new System.Drawing.Point(208, 105);
			this.lblOrigChars.Name = "lblOrigChars";
			this.lblOrigChars.Size = new System.Drawing.Size(75, 13);
			this.lblOrigChars.TabIndex = 16;
			this.lblOrigChars.Text = "Original Chars:";
			// 
			// txtNewExtension
			// 
			this.txtNewExtension.Location = new System.Drawing.Point(128, 78);
			this.txtNewExtension.Name = "txtNewExtension";
			this.txtNewExtension.Size = new System.Drawing.Size(51, 20);
			this.txtNewExtension.TabIndex = 13;
			this.txtNewExtension.TextChanged += new System.EventHandler(this.txtNewExtension_TextChanged);
			// 
			// btnClearChangeCase
			// 
			this.btnClearChangeCase.Location = new System.Drawing.Point(295, 170);
			this.btnClearChangeCase.Name = "btnClearChangeCase";
			this.btnClearChangeCase.Size = new System.Drawing.Size(39, 23);
			this.btnClearChangeCase.TabIndex = 12;
			this.btnClearChangeCase.Text = "Clear";
			this.btnClearChangeCase.UseVisualStyleBackColor = true;
			this.btnClearChangeCase.Click += new System.EventHandler(this.btnClearChangeCase_Click);
			// 
			// radToCamel
			// 
			this.radToCamel.AutoSize = true;
			this.radToCamel.Location = new System.Drawing.Point(200, 173);
			this.radToCamel.Name = "radToCamel";
			this.radToCamel.Size = new System.Drawing.Size(77, 17);
			this.radToCamel.TabIndex = 11;
			this.radToCamel.TabStop = true;
			this.radToCamel.Tag = "2";
			this.radToCamel.Text = "Camelcase";
			this.toolTipRenamer.SetToolTip(this.radToCamel, "Convert the entire result to Camel Case");
			this.radToCamel.UseVisualStyleBackColor = true;
			// 
			// radToUpper
			// 
			this.radToUpper.AutoSize = true;
			this.radToUpper.Location = new System.Drawing.Point(101, 173);
			this.radToUpper.Name = "radToUpper";
			this.radToUpper.Size = new System.Drawing.Size(77, 17);
			this.radToUpper.TabIndex = 10;
			this.radToUpper.TabStop = true;
			this.radToUpper.Tag = "1";
			this.radToUpper.Text = "Uppercase";
			this.toolTipRenamer.SetToolTip(this.radToUpper, "Convert the entire result to UPPERCASE");
			this.radToUpper.UseVisualStyleBackColor = true;
			// 
			// radToLower
			// 
			this.radToLower.AutoSize = true;
			this.radToLower.Location = new System.Drawing.Point(11, 173);
			this.radToLower.Name = "radToLower";
			this.radToLower.Size = new System.Drawing.Size(77, 17);
			this.radToLower.TabIndex = 9;
			this.radToLower.TabStop = true;
			this.radToLower.Tag = "0";
			this.radToLower.Text = "Lowercase";
			this.toolTipRenamer.SetToolTip(this.radToLower, "Convert the entire result to lowercase");
			this.radToLower.UseVisualStyleBackColor = true;
			// 
			// lblChangeCase
			// 
			this.lblChangeCase.AutoSize = true;
			this.lblChangeCase.Location = new System.Drawing.Point(8, 157);
			this.lblChangeCase.Name = "lblChangeCase";
			this.lblChangeCase.Size = new System.Drawing.Size(71, 13);
			this.lblChangeCase.TabIndex = 8;
			this.lblChangeCase.Text = "Change Case";
			// 
			// chkDelDupSpace
			// 
			this.chkDelDupSpace.AutoSize = true;
			this.chkDelDupSpace.Location = new System.Drawing.Point(12, 104);
			this.chkDelDupSpace.Name = "chkDelDupSpace";
			this.chkDelDupSpace.Size = new System.Drawing.Size(119, 17);
			this.chkDelDupSpace.TabIndex = 6;
			this.chkDelDupSpace.Text = "Delete Dup Spaces";
			this.toolTipRenamer.SetToolTip(this.chkDelDupSpace, "Delete duplicate spaces if found");
			this.chkDelDupSpace.UseVisualStyleBackColor = true;
			// 
			// chkChangeExtension
			// 
			this.chkChangeExtension.AutoSize = true;
			this.chkChangeExtension.Location = new System.Drawing.Point(12, 81);
			this.chkChangeExtension.Name = "chkChangeExtension";
			this.chkChangeExtension.Size = new System.Drawing.Size(112, 17);
			this.chkChangeExtension.TabIndex = 4;
			this.chkChangeExtension.Text = "Change Extension";
			this.toolTipRenamer.SetToolTip(this.chkChangeExtension, "Include the extension when renaming,\r\notherwise extension will be ignored");
			this.chkChangeExtension.UseVisualStyleBackColor = true;
			this.chkChangeExtension.CheckedChanged += new System.EventHandler(this.chkChangeExtension_CheckedChanged);
			// 
			// txtNewText
			// 
			this.txtNewText.Location = new System.Drawing.Point(102, 51);
			this.txtNewText.Name = "txtNewText";
			this.txtNewText.Size = new System.Drawing.Size(239, 20);
			this.txtNewText.TabIndex = 3;
			this.toolTipRenamer.SetToolTip(this.txtNewText, "New text to replace old text with");
			// 
			// lblNewText
			// 
			this.lblNewText.AutoSize = true;
			this.lblNewText.Location = new System.Drawing.Point(9, 54);
			this.lblNewText.Name = "lblNewText";
			this.lblNewText.Size = new System.Drawing.Size(56, 13);
			this.lblNewText.TabIndex = 2;
			this.lblNewText.Text = "New Text:";
			// 
			// txtOldText
			// 
			this.txtOldText.Location = new System.Drawing.Point(102, 25);
			this.txtOldText.Name = "txtOldText";
			this.txtOldText.Size = new System.Drawing.Size(239, 20);
			this.txtOldText.TabIndex = 1;
			this.toolTipRenamer.SetToolTip(this.txtOldText, "Old text to look for");
			// 
			// lblOldText
			// 
			this.lblOldText.AutoSize = true;
			this.lblOldText.Location = new System.Drawing.Point(9, 28);
			this.lblOldText.Name = "lblOldText";
			this.lblOldText.Size = new System.Drawing.Size(50, 13);
			this.lblOldText.TabIndex = 0;
			this.lblOldText.Text = "Old Text:";
			// 
			// grpDefaultValues
			// 
			this.grpDefaultValues.BackColor = System.Drawing.SystemColors.Control;
			this.grpDefaultValues.Controls.Add(this.chkIncludeSep);
			this.grpDefaultValues.Controls.Add(this.chkIgnoreExtension);
			this.grpDefaultValues.Controls.Add(this.chkIgnoreCase);
			this.grpDefaultValues.Controls.Add(this.txtDefaultDelimiter);
			this.grpDefaultValues.Controls.Add(this.lblDefaultDelimiter);
			this.grpDefaultValues.Controls.Add(this.txtDefaultSeparator);
			this.grpDefaultValues.Controls.Add(this.lblDefaultSeparator);
			this.grpDefaultValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.grpDefaultValues.Location = new System.Drawing.Point(3, 505);
			this.grpDefaultValues.Name = "grpDefaultValues";
			this.grpDefaultValues.Size = new System.Drawing.Size(354, 87);
			this.grpDefaultValues.TabIndex = 10;
			this.grpDefaultValues.TabStop = false;
			this.grpDefaultValues.Text = "Default Options";
			// 
			// chkIncludeSep
			// 
			this.chkIncludeSep.AutoSize = true;
			this.chkIncludeSep.Checked = true;
			this.chkIncludeSep.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkIncludeSep.Location = new System.Drawing.Point(12, 23);
			this.chkIncludeSep.Name = "chkIncludeSep";
			this.chkIncludeSep.Size = new System.Drawing.Size(110, 17);
			this.chkIncludeSep.TabIndex = 9;
			this.chkIncludeSep.Text = "Include Separator";
			this.toolTipRenamer.SetToolTip(this.chkIncludeSep, "Check to use the default separator");
			this.chkIncludeSep.UseVisualStyleBackColor = true;
			// 
			// chkIgnoreExtension
			// 
			this.chkIgnoreExtension.AutoSize = true;
			this.chkIgnoreExtension.Location = new System.Drawing.Point(138, 23);
			this.chkIgnoreExtension.Name = "chkIgnoreExtension";
			this.chkIgnoreExtension.Size = new System.Drawing.Size(105, 17);
			this.chkIgnoreExtension.TabIndex = 5;
			this.chkIgnoreExtension.Text = "Ignore Extension";
			this.chkIgnoreExtension.UseVisualStyleBackColor = true;
			// 
			// chkIgnoreCase
			// 
			this.chkIgnoreCase.AutoSize = true;
			this.chkIgnoreCase.Location = new System.Drawing.Point(259, 23);
			this.chkIgnoreCase.Name = "chkIgnoreCase";
			this.chkIgnoreCase.Size = new System.Drawing.Size(83, 17);
			this.chkIgnoreCase.TabIndex = 7;
			this.chkIgnoreCase.Text = "Ignore Case";
			this.chkIgnoreCase.UseVisualStyleBackColor = true;
			// 
			// txtDefaultDelimiter
			// 
			this.txtDefaultDelimiter.Location = new System.Drawing.Point(285, 46);
			this.txtDefaultDelimiter.Name = "txtDefaultDelimiter";
			this.txtDefaultDelimiter.Size = new System.Drawing.Size(56, 20);
			this.txtDefaultDelimiter.TabIndex = 4;
			this.txtDefaultDelimiter.Text = "^";
			this.toolTipRenamer.SetToolTip(this.txtDefaultDelimiter, "Character used to delimite a line for parsing");
			// 
			// lblDefaultDelimiter
			// 
			this.lblDefaultDelimiter.AutoSize = true;
			this.lblDefaultDelimiter.Location = new System.Drawing.Point(191, 49);
			this.lblDefaultDelimiter.Name = "lblDefaultDelimiter";
			this.lblDefaultDelimiter.Size = new System.Drawing.Size(87, 13);
			this.lblDefaultDelimiter.TabIndex = 3;
			this.lblDefaultDelimiter.Text = "Default Delimiter:";
			// 
			// txtDefaultSeparator
			// 
			this.txtDefaultSeparator.Location = new System.Drawing.Point(102, 46);
			this.txtDefaultSeparator.Name = "txtDefaultSeparator";
			this.txtDefaultSeparator.Size = new System.Drawing.Size(57, 20);
			this.txtDefaultSeparator.TabIndex = 6;
			this.txtDefaultSeparator.Text = "-";
			this.toolTipRenamer.SetToolTip(this.txtDefaultSeparator, "Character used to separate new from old");
			// 
			// lblDefaultSeparator
			// 
			this.lblDefaultSeparator.AutoSize = true;
			this.lblDefaultSeparator.Location = new System.Drawing.Point(9, 49);
			this.lblDefaultSeparator.Name = "lblDefaultSeparator";
			this.lblDefaultSeparator.Size = new System.Drawing.Size(93, 13);
			this.lblDefaultSeparator.TabIndex = 5;
			this.lblDefaultSeparator.Text = "Default Separator:";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Multiselect = true;
			this.openFileDialog1.SupportMultiDottedExtensions = true;
			this.openFileDialog1.Title = "Source Files";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// MoeRenamer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(909, 679);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MoeRenamer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MoeRenamer";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.grpInsertRemove.ResumeLayout(false);
			this.grpInsertRemove.PerformLayout();
			this.grpPrefixSuffix.ResumeLayout(false);
			this.grpPrefixSuffix.PerformLayout();
			this.grpMainRename.ResumeLayout(false);
			this.grpMainRename.PerformLayout();
			this.grpDefaultValues.ResumeLayout(false);
			this.grpDefaultValues.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label lblDest;
		private System.Windows.Forms.Label lblSource;
		private System.Windows.Forms.ListView lstDest;
		private System.Windows.Forms.ListView lstSource;
		private System.Windows.Forms.GroupBox grpPrefixSuffix;
		private System.Windows.Forms.RadioButton radSuffix;
		private System.Windows.Forms.RadioButton radPrefix;
		private System.Windows.Forms.GroupBox grpMainRename;
		private System.Windows.Forms.CheckBox chkIgnoreCase;
		private System.Windows.Forms.CheckBox chkDelDupSpace;
		private System.Windows.Forms.CheckBox chkIgnoreExtension;
		private System.Windows.Forms.CheckBox chkChangeExtension;
		private System.Windows.Forms.TextBox txtNewText;
		private System.Windows.Forms.Label lblNewText;
		private System.Windows.Forms.TextBox txtOldText;
		private System.Windows.Forms.Label lblOldText;
		private System.Windows.Forms.TextBox txtPadSize;
		private System.Windows.Forms.Label lblPadSize;
		private System.Windows.Forms.TextBox txtNewTextSep;
		private System.Windows.Forms.Label lblNewTextSep;
		private System.Windows.Forms.TextBox txtPadChar;
		private System.Windows.Forms.Label lblPadChar;
		private System.Windows.Forms.CheckBox chkRandomize;
		private System.Windows.Forms.CheckBox chkNumberFiles;
		private System.Windows.Forms.GroupBox grpInsertRemove;
		private System.Windows.Forms.RadioButton radRemove;
		private System.Windows.Forms.RadioButton radInsert;
		private System.Windows.Forms.TextBox txtLength;
		private System.Windows.Forms.Label lblLength;
		private System.Windows.Forms.TextBox txtStartPos;
		private System.Windows.Forms.Label lblStartPos;
		private System.Windows.Forms.TextBox txtInsRemText;
		private System.Windows.Forms.Label lblInsRemText;
		private System.Windows.Forms.TextBox txtStartNumber;
		private System.Windows.Forms.Label lblStartNumber;
		private System.Windows.Forms.CheckBox chkIncludeSep;
		private System.Windows.Forms.RadioButton radMove;
		private System.Windows.Forms.RadioButton radToCamel;
		private System.Windows.Forms.RadioButton radToUpper;
		private System.Windows.Forms.RadioButton radToLower;
		private System.Windows.Forms.Label lblChangeCase;
		private System.Windows.Forms.ToolTip toolTipRenamer;
		private System.Windows.Forms.TextBox txtDefaultSeparator;
		private System.Windows.Forms.Label lblDefaultSeparator;
		private System.Windows.Forms.TextBox txtDefaultDelimiter;
		private System.Windows.Forms.Label lblDefaultDelimiter;
		private System.Windows.Forms.ComboBox cmbNewPosition;
		private System.Windows.Forms.Label lblTextPosition;
		private System.Windows.Forms.TextBox txtExactPos;
		private System.Windows.Forms.Label lblExactPosition;
		private System.Windows.Forms.GroupBox grpDefaultValues;
		private System.Windows.Forms.Button btnDestFolder;
		private System.Windows.Forms.Button btnSourceFolder;
		private System.Windows.Forms.TextBox tbDest;
		private System.Windows.Forms.TextBox tbSource;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnTestRename;
		private System.Windows.Forms.Button btnRenameFiles;
		private System.Windows.Forms.Button btnClearChangeCase;
		private System.Windows.Forms.TextBox txtReplChars;
		private System.Windows.Forms.Label lblReplChars;
		private System.Windows.Forms.Label lblOrigChars;
		private System.Windows.Forms.TextBox txtOrigChars;
		private System.Windows.Forms.TextBox txtNewExtension;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnClearPrefixSuffix;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnClearInsert;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.ColumnHeader FileName;
		private System.Windows.Forms.ColumnHeader newFileName;
	}
}
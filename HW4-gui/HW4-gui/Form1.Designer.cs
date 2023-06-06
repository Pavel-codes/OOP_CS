namespace HW4_gui
{
    partial class Form1
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
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnCreateCustomFile = new System.Windows.Forms.Button();
            this.queListBox = new System.Windows.Forms.ListBox();
            this.dequeBtn = new System.Windows.Forms.Button();
            this.queFunctions = new System.Windows.Forms.GroupBox();
            this.showAllQue = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.radioButtonPPTX = new System.Windows.Forms.RadioButton();
            this.radioButtonPDF = new System.Windows.Forms.RadioButton();
            this.radioButtonDOCX = new System.Windows.Forms.RadioButton();
            this.radioButtonDOC = new System.Windows.Forms.RadioButton();
            this.radioButtonTXT = new System.Windows.Forms.RadioButton();
            this.showLargestFile = new System.Windows.Forms.Button();
            this.showByType = new System.Windows.Forms.Button();
            this.customFileOptions = new System.Windows.Forms.GroupBox();
            this.createFileFromData = new System.Windows.Forms.Button();
            this.lblfileData = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblfileName = new System.Windows.Forms.Label();
            this.extensionComboBox = new System.Windows.Forms.ComboBox();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.queFunctions.SuspendLayout();
            this.customFileOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(36, 32);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(141, 61);
            this.btnCreateFile.TabIndex = 0;
            this.btnCreateFile.Text = "Create default file";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnCreateCustomFile
            // 
            this.btnCreateCustomFile.Location = new System.Drawing.Point(36, 109);
            this.btnCreateCustomFile.Name = "btnCreateCustomFile";
            this.btnCreateCustomFile.Size = new System.Drawing.Size(141, 61);
            this.btnCreateCustomFile.TabIndex = 1;
            this.btnCreateCustomFile.Text = "Create custom file";
            this.btnCreateCustomFile.UseVisualStyleBackColor = true;
            this.btnCreateCustomFile.Click += new System.EventHandler(this.btnCreateCustomFile_Click);
            // 
            // queListBox
            // 
            this.queListBox.FormattingEnabled = true;
            this.queListBox.ItemHeight = 15;
            this.queListBox.Location = new System.Drawing.Point(271, 32);
            this.queListBox.Name = "queListBox";
            this.queListBox.Size = new System.Drawing.Size(328, 79);
            this.queListBox.TabIndex = 3;
            // 
            // dequeBtn
            // 
            this.dequeBtn.Location = new System.Drawing.Point(348, 133);
            this.dequeBtn.Name = "dequeBtn";
            this.dequeBtn.Size = new System.Drawing.Size(182, 67);
            this.dequeBtn.TabIndex = 4;
            this.dequeBtn.Text = "Dequeue";
            this.dequeBtn.UseVisualStyleBackColor = true;
            this.dequeBtn.Click += new System.EventHandler(this.dequeBtn_Click);
            // 
            // queFunctions
            // 
            this.queFunctions.Controls.Add(this.showAllQue);
            this.queFunctions.Controls.Add(this.display);
            this.queFunctions.Controls.Add(this.radioButtonPPTX);
            this.queFunctions.Controls.Add(this.radioButtonPDF);
            this.queFunctions.Controls.Add(this.radioButtonDOCX);
            this.queFunctions.Controls.Add(this.radioButtonDOC);
            this.queFunctions.Controls.Add(this.radioButtonTXT);
            this.queFunctions.Controls.Add(this.showLargestFile);
            this.queFunctions.Controls.Add(this.showByType);
            this.queFunctions.Controls.Add(this.dequeBtn);
            this.queFunctions.Controls.Add(this.queListBox);
            this.queFunctions.Controls.Add(this.btnCreateCustomFile);
            this.queFunctions.Controls.Add(this.btnCreateFile);
            this.queFunctions.Location = new System.Drawing.Point(84, 21);
            this.queFunctions.Name = "queFunctions";
            this.queFunctions.Size = new System.Drawing.Size(619, 413);
            this.queFunctions.TabIndex = 5;
            this.queFunctions.TabStop = false;
            this.queFunctions.Text = "Queue functions";
            // 
            // showAllQue
            // 
            this.showAllQue.Location = new System.Drawing.Point(36, 344);
            this.showAllQue.Name = "showAllQue";
            this.showAllQue.Size = new System.Drawing.Size(141, 61);
            this.showAllQue.TabIndex = 13;
            this.showAllQue.Text = "Show queue";
            this.showAllQue.UseVisualStyleBackColor = true;
            this.showAllQue.Click += new System.EventHandler(this.showAllQue_Click);
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.Location = new System.Drawing.Point(271, 14);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(45, 15);
            this.display.TabIndex = 12;
            this.display.Text = "Display";
            // 
            // radioButtonPPTX
            // 
            this.radioButtonPPTX.AutoSize = true;
            this.radioButtonPPTX.Location = new System.Drawing.Point(212, 378);
            this.radioButtonPPTX.Name = "radioButtonPPTX";
            this.radioButtonPPTX.Size = new System.Drawing.Size(52, 19);
            this.radioButtonPPTX.TabIndex = 11;
            this.radioButtonPPTX.TabStop = true;
            this.radioButtonPPTX.Text = "PPTX";
            this.radioButtonPPTX.UseVisualStyleBackColor = true;
            // 
            // radioButtonPDF
            // 
            this.radioButtonPDF.AutoSize = true;
            this.radioButtonPDF.Location = new System.Drawing.Point(212, 353);
            this.radioButtonPDF.Name = "radioButtonPDF";
            this.radioButtonPDF.Size = new System.Drawing.Size(46, 19);
            this.radioButtonPDF.TabIndex = 10;
            this.radioButtonPDF.TabStop = true;
            this.radioButtonPDF.Text = "PDF";
            this.radioButtonPDF.UseVisualStyleBackColor = true;
            // 
            // radioButtonDOCX
            // 
            this.radioButtonDOCX.AutoSize = true;
            this.radioButtonDOCX.Location = new System.Drawing.Point(212, 328);
            this.radioButtonDOCX.Name = "radioButtonDOCX";
            this.radioButtonDOCX.Size = new System.Drawing.Size(57, 19);
            this.radioButtonDOCX.TabIndex = 9;
            this.radioButtonDOCX.TabStop = true;
            this.radioButtonDOCX.Text = "DOCX";
            this.radioButtonDOCX.UseVisualStyleBackColor = true;
            // 
            // radioButtonDOC
            // 
            this.radioButtonDOC.AutoSize = true;
            this.radioButtonDOC.Location = new System.Drawing.Point(212, 303);
            this.radioButtonDOC.Name = "radioButtonDOC";
            this.radioButtonDOC.Size = new System.Drawing.Size(50, 19);
            this.radioButtonDOC.TabIndex = 8;
            this.radioButtonDOC.TabStop = true;
            this.radioButtonDOC.Text = "DOC";
            this.radioButtonDOC.UseVisualStyleBackColor = true;
            // 
            // radioButtonTXT
            // 
            this.radioButtonTXT.AutoSize = true;
            this.radioButtonTXT.Location = new System.Drawing.Point(212, 278);
            this.radioButtonTXT.Name = "radioButtonTXT";
            this.radioButtonTXT.Size = new System.Drawing.Size(44, 19);
            this.radioButtonTXT.TabIndex = 7;
            this.radioButtonTXT.TabStop = true;
            this.radioButtonTXT.Text = "TXT";
            this.radioButtonTXT.UseVisualStyleBackColor = true;
            // 
            // showLargestFile
            // 
            this.showLargestFile.Location = new System.Drawing.Point(36, 188);
            this.showLargestFile.Name = "showLargestFile";
            this.showLargestFile.Size = new System.Drawing.Size(141, 61);
            this.showLargestFile.TabIndex = 6;
            this.showLargestFile.Text = "Show biggest file";
            this.showLargestFile.UseVisualStyleBackColor = true;
            this.showLargestFile.Click += new System.EventHandler(this.showLargestFile_Click);
            // 
            // showByType
            // 
            this.showByType.Location = new System.Drawing.Point(36, 267);
            this.showByType.Name = "showByType";
            this.showByType.Size = new System.Drawing.Size(141, 61);
            this.showByType.TabIndex = 5;
            this.showByType.Text = "Show by type";
            this.showByType.UseVisualStyleBackColor = true;
            this.showByType.Click += new System.EventHandler(this.showByType_Click);
            // 
            // customFileOptions
            // 
            this.customFileOptions.Controls.Add(this.createFileFromData);
            this.customFileOptions.Controls.Add(this.lblfileData);
            this.customFileOptions.Controls.Add(this.lblExtension);
            this.customFileOptions.Controls.Add(this.lblfileName);
            this.customFileOptions.Controls.Add(this.extensionComboBox);
            this.customFileOptions.Controls.Add(this.dataTextBox);
            this.customFileOptions.Controls.Add(this.fileNameBox);
            this.customFileOptions.Location = new System.Drawing.Point(84, 12);
            this.customFileOptions.Name = "customFileOptions";
            this.customFileOptions.Size = new System.Drawing.Size(569, 281);
            this.customFileOptions.TabIndex = 9;
            this.customFileOptions.TabStop = false;
            this.customFileOptions.Text = "File information";
            this.customFileOptions.Visible = false;
            // 
            // createFileFromData
            // 
            this.createFileFromData.Location = new System.Drawing.Point(262, 232);
            this.createFileFromData.Name = "createFileFromData";
            this.createFileFromData.Size = new System.Drawing.Size(69, 27);
            this.createFileFromData.TabIndex = 12;
            this.createFileFromData.Text = "Create";
            this.createFileFromData.UseVisualStyleBackColor = true;
            this.createFileFromData.Click += new System.EventHandler(this.createFileFromData_Click);
            // 
            // lblfileData
            // 
            this.lblfileData.AutoSize = true;
            this.lblfileData.Location = new System.Drawing.Point(21, 94);
            this.lblfileData.Name = "lblfileData";
            this.lblfileData.Size = new System.Drawing.Size(31, 15);
            this.lblfileData.TabIndex = 11;
            this.lblfileData.Text = "Data";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(279, 41);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(58, 15);
            this.lblExtension.TabIndex = 10;
            this.lblExtension.Text = "Extension";
            // 
            // lblfileName
            // 
            this.lblfileName.AutoSize = true;
            this.lblfileName.Location = new System.Drawing.Point(6, 41);
            this.lblfileName.Name = "lblfileName";
            this.lblfileName.Size = new System.Drawing.Size(58, 15);
            this.lblfileName.TabIndex = 9;
            this.lblfileName.Text = "File name";
            // 
            // extensionComboBox
            // 
            this.extensionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.extensionComboBox.FormattingEnabled = true;
            this.extensionComboBox.Location = new System.Drawing.Point(343, 38);
            this.extensionComboBox.Name = "extensionComboBox";
            this.extensionComboBox.Size = new System.Drawing.Size(96, 23);
            this.extensionComboBox.TabIndex = 8;
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(65, 91);
            this.dataTextBox.Multiline = true;
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(465, 118);
            this.dataTextBox.TabIndex = 7;
            // 
            // fileNameBox
            // 
            this.fileNameBox.Location = new System.Drawing.Point(65, 38);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(182, 23);
            this.fileNameBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 459);
            this.Controls.Add(this.queFunctions);
            this.Controls.Add(this.customFileOptions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.queFunctions.ResumeLayout(false);
            this.queFunctions.PerformLayout();
            this.customFileOptions.ResumeLayout(false);
            this.customFileOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCreateFile;
        private Button btnCreateCustomFile;
        private ListBox queListBox;
        private Button dequeBtn;
        private GroupBox queFunctions;
        private TextBox fileNameBox;
        private TextBox dataTextBox;
        private ComboBox extensionComboBox;
        private GroupBox customFileOptions;
        private Label lblfileData;
        private Label lblExtension;
        private Label lblfileName;
        private Button createFileFromData;
        private Button showLargestFile;
        private Button showByType;
        private RadioButton radioButtonPPTX;
        private RadioButton radioButtonPDF;
        private RadioButton radioButtonDOCX;
        private RadioButton radioButtonDOC;
        private RadioButton radioButtonTXT;
        private Button showAllQue;
        private Label display;
    }
}
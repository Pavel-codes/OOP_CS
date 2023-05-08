namespace GuiAndClasses
{
    partial class frmCreateLesson
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
            this.grpCreateLesson = new System.Windows.Forms.GroupBox();
            this.btnCreateLesson = new System.Windows.Forms.Button();
            this.txtMaxStudents = new System.Windows.Forms.TextBox();
            this.lblMaxStudents = new System.Windows.Forms.Label();
            this.txtLessonName = new System.Windows.Forms.TextBox();
            this.lblLessonName = new System.Windows.Forms.Label();
            this.grpStudents = new System.Windows.Forms.GroupBox();
            this.grpAddGrade = new System.Windows.Forms.GroupBox();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.grpAddStudent = new System.Windows.Forms.GroupBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.lstLessons = new System.Windows.Forms.ListBox();
            this.grpLessons = new System.Windows.Forms.GroupBox();
            this.grpCreateLesson.SuspendLayout();
            this.grpStudents.SuspendLayout();
            this.grpAddGrade.SuspendLayout();
            this.grpAddStudent.SuspendLayout();
            this.grpLessons.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCreateLesson
            // 
            this.grpCreateLesson.Controls.Add(this.btnCreateLesson);
            this.grpCreateLesson.Controls.Add(this.txtMaxStudents);
            this.grpCreateLesson.Controls.Add(this.lblMaxStudents);
            this.grpCreateLesson.Controls.Add(this.txtLessonName);
            this.grpCreateLesson.Controls.Add(this.lblLessonName);
            this.grpCreateLesson.Location = new System.Drawing.Point(29, 18);
            this.grpCreateLesson.Margin = new System.Windows.Forms.Padding(2);
            this.grpCreateLesson.Name = "grpCreateLesson";
            this.grpCreateLesson.Padding = new System.Windows.Forms.Padding(2);
            this.grpCreateLesson.Size = new System.Drawing.Size(250, 105);
            this.grpCreateLesson.TabIndex = 0;
            this.grpCreateLesson.TabStop = false;
            this.grpCreateLesson.Text = "Create Class";
            // 
            // btnCreateLesson
            // 
            this.btnCreateLesson.Location = new System.Drawing.Point(8, 81);
            this.btnCreateLesson.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateLesson.Name = "btnCreateLesson";
            this.btnCreateLesson.Size = new System.Drawing.Size(56, 19);
            this.btnCreateLesson.TabIndex = 4;
            this.btnCreateLesson.Text = "Create Lesson";
            this.btnCreateLesson.UseVisualStyleBackColor = true;
            this.btnCreateLesson.Click += new System.EventHandler(this.btnCreateLesson_Click);
            // 
            // txtMaxStudents
            // 
            this.txtMaxStudents.Location = new System.Drawing.Point(108, 50);
            this.txtMaxStudents.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaxStudents.Name = "txtMaxStudents";
            this.txtMaxStudents.Size = new System.Drawing.Size(76, 20);
            this.txtMaxStudents.TabIndex = 3;
            // 
            // lblMaxStudents
            // 
            this.lblMaxStudents.AutoSize = true;
            this.lblMaxStudents.Location = new System.Drawing.Point(5, 53);
            this.lblMaxStudents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxStudents.Name = "lblMaxStudents";
            this.lblMaxStudents.Size = new System.Drawing.Size(100, 13);
            this.lblMaxStudents.TabIndex = 2;
            this.lblMaxStudents.Text = "Enter max students:";
            // 
            // txtLessonName
            // 
            this.txtLessonName.Location = new System.Drawing.Point(108, 26);
            this.txtLessonName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLessonName.Name = "txtLessonName";
            this.txtLessonName.Size = new System.Drawing.Size(76, 20);
            this.txtLessonName.TabIndex = 1;
            // 
            // lblLessonName
            // 
            this.lblLessonName.AutoSize = true;
            this.lblLessonName.Location = new System.Drawing.Point(5, 26);
            this.lblLessonName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLessonName.Name = "lblLessonName";
            this.lblLessonName.Size = new System.Drawing.Size(97, 13);
            this.lblLessonName.TabIndex = 0;
            this.lblLessonName.Text = "Enter lesson name:";
            // 
            // grpStudents
            // 
            this.grpStudents.Controls.Add(this.grpAddGrade);
            this.grpStudents.Controls.Add(this.btnRemoveStudent);
            this.grpStudents.Controls.Add(this.grpAddStudent);
            this.grpStudents.Controls.Add(this.lstStudents);
            this.grpStudents.Location = new System.Drawing.Point(29, 18);
            this.grpStudents.Margin = new System.Windows.Forms.Padding(2);
            this.grpStudents.Name = "grpStudents";
            this.grpStudents.Padding = new System.Windows.Forms.Padding(2);
            this.grpStudents.Size = new System.Drawing.Size(548, 206);
            this.grpStudents.TabIndex = 1;
            this.grpStudents.TabStop = false;
            this.grpStudents.Text = "Students";
            this.grpStudents.Visible = false;
            // 
            // grpAddGrade
            // 
            this.grpAddGrade.Controls.Add(this.btnAddGrade);
            this.grpAddGrade.Controls.Add(this.txtGrade);
            this.grpAddGrade.Controls.Add(this.lblGrade);
            this.grpAddGrade.Location = new System.Drawing.Point(294, 125);
            this.grpAddGrade.Margin = new System.Windows.Forms.Padding(2);
            this.grpAddGrade.Name = "grpAddGrade";
            this.grpAddGrade.Padding = new System.Windows.Forms.Padding(2);
            this.grpAddGrade.Size = new System.Drawing.Size(150, 58);
            this.grpAddGrade.TabIndex = 3;
            this.grpAddGrade.TabStop = false;
            this.grpAddGrade.Text = "Add Grade";
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Location = new System.Drawing.Point(8, 39);
            this.btnAddGrade.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(138, 19);
            this.btnAddGrade.TabIndex = 2;
            this.btnAddGrade.Text = "AddGrade";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(76, 18);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(71, 20);
            this.txtGrade.TabIndex = 1;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(5, 18);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(65, 13);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.Text = "Enter grade:";
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(16, 183);
            this.btnRemoveStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(56, 19);
            this.btnRemoveStudent.TabIndex = 2;
            this.btnRemoveStudent.Text = "Remove Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // grpAddStudent
            // 
            this.grpAddStudent.Controls.Add(this.btnAddStudent);
            this.grpAddStudent.Controls.Add(this.txtStudentName);
            this.grpAddStudent.Controls.Add(this.lblStudentName);
            this.grpAddStudent.Location = new System.Drawing.Point(17, 26);
            this.grpAddStudent.Margin = new System.Windows.Forms.Padding(2);
            this.grpAddStudent.Name = "grpAddStudent";
            this.grpAddStudent.Padding = new System.Windows.Forms.Padding(2);
            this.grpAddStudent.Size = new System.Drawing.Size(233, 81);
            this.grpAddStudent.TabIndex = 0;
            this.grpAddStudent.TabStop = false;
            this.grpAddStudent.Text = "Add Student";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(14, 58);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(188, 19);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(127, 27);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(76, 20);
            this.txtStudentName.TabIndex = 1;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(12, 27);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(109, 13);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Enter student\'s name:";
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(16, 125);
            this.lstStudents.Margin = new System.Windows.Forms.Padding(2);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(234, 43);
            this.lstStudents.TabIndex = 1;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Location = new System.Drawing.Point(213, 58);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(75, 23);
            this.btnAddLesson.TabIndex = 2;
            this.btnAddLesson.Text = "Add lesson";
            this.btnAddLesson.UseVisualStyleBackColor = true;
            this.btnAddLesson.Visible = false;
            this.btnAddLesson.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstLessons
            // 
            this.lstLessons.FormattingEnabled = true;
            this.lstLessons.Location = new System.Drawing.Point(18, 19);
            this.lstLessons.Name = "lstLessons";
            this.lstLessons.Size = new System.Drawing.Size(120, 95);
            this.lstLessons.TabIndex = 4;
            this.lstLessons.SelectedIndexChanged += new System.EventHandler(this.lstLessons_SelectedIndexChanged);
            // 
            // grpLessons
            // 
            this.grpLessons.Controls.Add(this.btnAddLesson);
            this.grpLessons.Controls.Add(this.lstLessons);
            this.grpLessons.Location = new System.Drawing.Point(29, 229);
            this.grpLessons.Name = "grpLessons";
            this.grpLessons.Size = new System.Drawing.Size(548, 125);
            this.grpLessons.TabIndex = 5;
            this.grpLessons.TabStop = false;
            this.grpLessons.Text = "Lessons";
            this.grpLessons.Visible = false;
            // 
            // frmCreateLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.grpLessons);
            this.Controls.Add(this.grpStudents);
            this.Controls.Add(this.grpCreateLesson);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCreateLesson";
            this.grpCreateLesson.ResumeLayout(false);
            this.grpCreateLesson.PerformLayout();
            this.grpStudents.ResumeLayout(false);
            this.grpAddGrade.ResumeLayout(false);
            this.grpAddGrade.PerformLayout();
            this.grpAddStudent.ResumeLayout(false);
            this.grpAddStudent.PerformLayout();
            this.grpLessons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCreateLesson;
        private System.Windows.Forms.Button btnCreateLesson;
        private System.Windows.Forms.TextBox txtMaxStudents;
        private System.Windows.Forms.Label lblMaxStudents;
        private System.Windows.Forms.TextBox txtLessonName;
        private System.Windows.Forms.Label lblLessonName;
        private System.Windows.Forms.GroupBox grpStudents;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.GroupBox grpAddStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.GroupBox grpAddGrade;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button btnAddLesson;
        private System.Windows.Forms.ListBox lstLessons;
        private System.Windows.Forms.GroupBox grpLessons;
    }
}

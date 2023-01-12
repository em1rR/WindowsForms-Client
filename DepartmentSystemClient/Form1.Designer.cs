namespace DepartmentSystemClient
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
            this.DGWStudentList = new System.Windows.Forms.DataGridView();
            this.btnGetStudentList = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtAddStudentNo = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxPutDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxSearchGraduate = new System.Windows.Forms.ComboBox();
            this.comboBoxPutGraduate = new System.Windows.Forms.ComboBox();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.comboBoxSearchGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.comboBoxPutGender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGWStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // DGWStudentList
            // 
            this.DGWStudentList.AllowUserToAddRows = false;
            this.DGWStudentList.AllowUserToDeleteRows = false;
            this.DGWStudentList.AllowUserToResizeColumns = false;
            this.DGWStudentList.AllowUserToResizeRows = false;
            this.DGWStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWStudentList.Location = new System.Drawing.Point(28, 75);
            this.DGWStudentList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGWStudentList.Name = "DGWStudentList";
            this.DGWStudentList.ReadOnly = true;
            this.DGWStudentList.RowHeadersWidth = 51;
            this.DGWStudentList.RowTemplate.Height = 29;
            this.DGWStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGWStudentList.Size = new System.Drawing.Size(606, 141);
            this.DGWStudentList.TabIndex = 0;
            this.DGWStudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGWStudentList_CellContentClick);
            // 
            // btnGetStudentList
            // 
            this.btnGetStudentList.Location = new System.Drawing.Point(665, 77);
            this.btnGetStudentList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetStudentList.Name = "btnGetStudentList";
            this.btnGetStudentList.Size = new System.Drawing.Size(82, 22);
            this.btnGetStudentList.TabIndex = 1;
            this.btnGetStudentList.Text = "Get Data";
            this.btnGetStudentList.UseVisualStyleBackColor = true;
            this.btnGetStudentList.Click += new System.EventHandler(this.btnGetStudentList_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(673, 270);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(82, 22);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtAddStudentNo
            // 
            this.txtAddStudentNo.Location = new System.Drawing.Point(28, 269);
            this.txtAddStudentNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddStudentNo.Name = "txtAddStudentNo";
            this.txtAddStudentNo.Size = new System.Drawing.Size(110, 23);
            this.txtAddStudentNo.TabIndex = 3;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(151, 270);
            this.txtAddName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(110, 23);
            this.txtAddName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Graduate Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Department Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Student No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Student No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Department Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Graduate Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Name";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(151, 38);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(110, 23);
            this.txtSearchName.TabIndex = 13;
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(28, 38);
            this.txtSearchId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(110, 23);
            this.txtSearchId.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(665, 38);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 22);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(278, 38);
            this.comboBoxDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(110, 23);
            this.comboBoxDepartment.TabIndex = 20;
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxPutDepartment
            // 
            this.comboBoxPutDepartment.FormattingEnabled = true;
            this.comboBoxPutDepartment.Location = new System.Drawing.Point(278, 270);
            this.comboBoxPutDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPutDepartment.Name = "comboBoxPutDepartment";
            this.comboBoxPutDepartment.Size = new System.Drawing.Size(110, 23);
            this.comboBoxPutDepartment.TabIndex = 21;
            // 
            // comboBoxSearchGraduate
            // 
            this.comboBoxSearchGraduate.FormattingEnabled = true;
            this.comboBoxSearchGraduate.Location = new System.Drawing.Point(402, 38);
            this.comboBoxSearchGraduate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSearchGraduate.Name = "comboBoxSearchGraduate";
            this.comboBoxSearchGraduate.Size = new System.Drawing.Size(110, 23);
            this.comboBoxSearchGraduate.TabIndex = 22;
            this.comboBoxSearchGraduate.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchGraduate_SelectedIndexChanged);
            // 
            // comboBoxPutGraduate
            // 
            this.comboBoxPutGraduate.FormattingEnabled = true;
            this.comboBoxPutGraduate.Location = new System.Drawing.Point(402, 270);
            this.comboBoxPutGraduate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPutGraduate.Name = "comboBoxPutGraduate";
            this.comboBoxPutGraduate.Size = new System.Drawing.Size(110, 23);
            this.comboBoxPutGraduate.TabIndex = 23;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(673, 303);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(82, 22);
            this.btnDeleteStudent.TabIndex = 24;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Location = new System.Drawing.Point(28, 228);
            this.btnNewStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(82, 22);
            this.btnNewStudent.TabIndex = 25;
            this.btnNewStudent.Text = "New Student";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // comboBoxSearchGender
            // 
            this.comboBoxSearchGender.FormattingEnabled = true;
            this.comboBoxSearchGender.Location = new System.Drawing.Point(524, 38);
            this.comboBoxSearchGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSearchGender.Name = "comboBoxSearchGender";
            this.comboBoxSearchGender.Size = new System.Drawing.Size(110, 23);
            this.comboBoxSearchGender.TabIndex = 26;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(524, 20);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 15);
            this.lblGender.TabIndex = 27;
            this.lblGender.Text = "Gender";
            // 
            // comboBoxPutGender
            // 
            this.comboBoxPutGender.FormattingEnabled = true;
            this.comboBoxPutGender.Location = new System.Drawing.Point(524, 270);
            this.comboBoxPutGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPutGender.Name = "comboBoxPutGender";
            this.comboBoxPutGender.Size = new System.Drawing.Size(110, 23);
            this.comboBoxPutGender.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Gender";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 340);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxPutGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.comboBoxSearchGender);
            this.Controls.Add(this.btnNewStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.comboBoxPutGraduate);
            this.Controls.Add(this.comboBoxSearchGraduate);
            this.Controls.Add(this.comboBoxPutDepartment);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.txtSearchId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.txtAddStudentNo);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnGetStudentList);
            this.Controls.Add(this.DGWStudentList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGWStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DGWStudentList;
        private Button btnGetStudentList;
        private Button btnAddStudent;
        private TextBox txtAddStudentNo;
        private TextBox txtAddName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtSearchName;
        private TextBox txtSearchId;
        private Button btnSearch;
        private ComboBox comboBoxDepartment;
        private ComboBox comboBoxPutDepartment;
        private ComboBox comboBoxSearchGraduate;
        private ComboBox comboBoxPutGraduate;
        private Button btnDeleteStudent;
        private Button btnNewStudent;
        private ComboBox comboBoxSearchGender;
        private Label lblGender;
        private ComboBox comboBoxPutGender;
        private Label label9;
    }
}
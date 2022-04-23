
namespace StudentWinApp
{
    partial class frmSubjectInClass
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
            this.cboClassList = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvSubjectList = new System.Windows.Forms.DataGridView();
            this.btnExits = new System.Windows.Forms.Button();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbSearchByName = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbSubjectName = new System.Windows.Forms.Label();
            this.lbSubjectID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectList)).BeginInit();
            this.SuspendLayout();
            // 
            // cboClassList
            // 
            this.cboClassList.FormattingEnabled = true;
            this.cboClassList.Location = new System.Drawing.Point(30, 32);
            this.cboClassList.Name = "cboClassList";
            this.cboClassList.Size = new System.Drawing.Size(286, 23);
            this.cboClassList.TabIndex = 93;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(696, 32);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 91;
            this.btnFilter.Text = "Search";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // dgvSubjectList
            // 
            this.dgvSubjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjectList.Location = new System.Drawing.Point(404, 114);
            this.dgvSubjectList.Name = "dgvSubjectList";
            this.dgvSubjectList.RowTemplate.Height = 25;
            this.dgvSubjectList.Size = new System.Drawing.Size(367, 153);
            this.dgvSubjectList.TabIndex = 87;
            // 
            // btnExits
            // 
            this.btnExits.Location = new System.Drawing.Point(696, 300);
            this.btnExits.Name = "btnExits";
            this.btnExits.Size = new System.Drawing.Size(75, 23);
            this.btnExits.TabIndex = 86;
            this.btnExits.Text = "Exits";
            this.btnExits.UseVisualStyleBackColor = true;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(30, 73);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(286, 23);
            this.btnAddSubject.TabIndex = 85;
            this.btnAddSubject.Text = "Add Subject";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(504, 69);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 23);
            this.btnLoad.TabIndex = 84;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // lbSearchByName
            // 
            this.lbSearchByName.AutoSize = true;
            this.lbSearchByName.Location = new System.Drawing.Point(404, 42);
            this.lbSearchByName.Name = "lbSearchByName";
            this.lbSearchByName.Size = new System.Drawing.Size(97, 15);
            this.lbSearchByName.TabIndex = 83;
            this.lbSearchByName.Text = "Search_By_Name";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(504, 33);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(186, 23);
            this.textBox7.TabIndex = 82;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(30, 244);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(286, 23);
            this.btnDelete.TabIndex = 81;
            this.btnDelete.Text = "Delete Subject in class";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(130, 174);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(186, 23);
            this.txtMemberName.TabIndex = 79;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(130, 134);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(186, 23);
            this.txtMemberID.TabIndex = 78;
            // 
            // lbSubjectName
            // 
            this.lbSubjectName.AutoSize = true;
            this.lbSubjectName.Location = new System.Drawing.Point(30, 182);
            this.lbSubjectName.Name = "lbSubjectName";
            this.lbSubjectName.Size = new System.Drawing.Size(81, 15);
            this.lbSubjectName.TabIndex = 73;
            this.lbSubjectName.Text = "Subject Name";
            // 
            // lbSubjectID
            // 
            this.lbSubjectID.AutoSize = true;
            this.lbSubjectID.Location = new System.Drawing.Point(30, 142);
            this.lbSubjectID.Name = "lbSubjectID";
            this.lbSubjectID.Size = new System.Drawing.Size(60, 15);
            this.lbSubjectID.TabIndex = 72;
            this.lbSubjectID.Text = "Subject ID";
            // 
            // SubjectInClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 349);
            this.Controls.Add(this.cboClassList);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dgvSubjectList);
            this.Controls.Add(this.btnExits);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbSearchByName);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbSubjectName);
            this.Controls.Add(this.lbSubjectID);
            this.Name = "SubjectInClass";
            this.Text = "SubjectInClass";
            this.Load += new System.EventHandler(this.SubjectInClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboClassList;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvSubjectList;
        private System.Windows.Forms.Button btnExits;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lbSearchByName;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbSubjectName;
        private System.Windows.Forms.Label lbSubjectID;
    }
}
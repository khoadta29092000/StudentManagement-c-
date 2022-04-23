
namespace StudentWinApp
{
    partial class frmSubjectManagement
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
            this.dgvSubjectList = new System.Windows.Forms.DataGridView();
            this.btnExits = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbSearchByName = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbAccountID = new System.Windows.Forms.Label();
            this.lbSubjectName = new System.Windows.Forms.Label();
            this.lbSubjectID = new System.Windows.Forms.Label();
            this.lbClassID = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubjectList
            // 
            this.dgvSubjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjectList.Location = new System.Drawing.Point(47, 235);
            this.dgvSubjectList.Name = "dgvSubjectList";
            this.dgvSubjectList.RowTemplate.Height = 25;
            this.dgvSubjectList.Size = new System.Drawing.Size(375, 214);
            this.dgvSubjectList.TabIndex = 42;
            // 
            // btnExits
            // 
            this.btnExits.Location = new System.Drawing.Point(338, 466);
            this.btnExits.Name = "btnExits";
            this.btnExits.Size = new System.Drawing.Size(75, 23);
            this.btnExits.TabIndex = 41;
            this.btnExits.Text = "Exits";
            this.btnExits.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(338, 206);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(199, 206);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 39;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(47, 206);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 38;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // lbSearchByName
            // 
            this.lbSearchByName.AutoSize = true;
            this.lbSearchByName.Location = new System.Drawing.Point(47, 179);
            this.lbSearchByName.Name = "lbSearchByName";
            this.lbSearchByName.Size = new System.Drawing.Size(97, 15);
            this.lbSearchByName.TabIndex = 37;
            this.lbSearchByName.Text = "Search_By_Name";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(147, 170);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(186, 23);
            this.textBox7.TabIndex = 36;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(338, 170);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(147, 104);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(186, 23);
            this.txtGender.TabIndex = 34;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(147, 61);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(186, 23);
            this.txtMemberName.TabIndex = 33;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(147, 21);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(186, 23);
            this.txtMemberID.TabIndex = 32;
            // 
            // lbAccountID
            // 
            this.lbAccountID.AutoSize = true;
            this.lbAccountID.Location = new System.Drawing.Point(47, 112);
            this.lbAccountID.Name = "lbAccountID";
            this.lbAccountID.Size = new System.Drawing.Size(47, 15);
            this.lbAccountID.TabIndex = 28;
            this.lbAccountID.Text = "Teacher";
            // 
            // lbSubjectName
            // 
            this.lbSubjectName.AutoSize = true;
            this.lbSubjectName.Location = new System.Drawing.Point(47, 69);
            this.lbSubjectName.Name = "lbSubjectName";
            this.lbSubjectName.Size = new System.Drawing.Size(81, 15);
            this.lbSubjectName.TabIndex = 27;
            this.lbSubjectName.Text = "Subject Name";
            // 
            // lbSubjectID
            // 
            this.lbSubjectID.AutoSize = true;
            this.lbSubjectID.Location = new System.Drawing.Point(47, 29);
            this.lbSubjectID.Name = "lbSubjectID";
            this.lbSubjectID.Size = new System.Drawing.Size(60, 15);
            this.lbSubjectID.TabIndex = 26;
            this.lbSubjectID.Text = "Subject ID";
            // 
            // lbClassID
            // 
            this.lbClassID.AutoSize = true;
            this.lbClassID.Location = new System.Drawing.Point(47, 146);
            this.lbClassID.Name = "lbClassID";
            this.lbClassID.Size = new System.Drawing.Size(34, 15);
            this.lbClassID.TabIndex = 43;
            this.lbClassID.Text = "Class";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(147, 141);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(186, 23);
            this.txtClassID.TabIndex = 44;
            // 
            // frmSubjectManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 512);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.lbClassID);
            this.Controls.Add(this.dgvSubjectList);
            this.Controls.Add(this.btnExits);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbSearchByName);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbAccountID);
            this.Controls.Add(this.lbSubjectName);
            this.Controls.Add(this.lbSubjectID);
            this.Name = "frmSubjectManagement";
            this.Text = "SubjectManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSubjectList;
        private System.Windows.Forms.Button btnExits;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lbSearchByName;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbAccountID;
        private System.Windows.Forms.Label lbSubjectName;
        private System.Windows.Forms.Label lbSubjectID;
        private System.Windows.Forms.Label lbClassID;
        private System.Windows.Forms.TextBox txtClassID;
    }
}
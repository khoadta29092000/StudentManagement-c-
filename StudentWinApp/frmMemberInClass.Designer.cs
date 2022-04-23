
namespace StudentWinApp
{
    partial class frmMemberInClass
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
            this.cbSearchByID = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.btnExits = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbSearchByName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.cboStudentList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSearchByID
            // 
            this.cbSearchByID.AutoSize = true;
            this.cbSearchByID.Location = new System.Drawing.Point(447, 96);
            this.cbSearchByID.Name = "cbSearchByID";
            this.cbSearchByID.Size = new System.Drawing.Size(91, 19);
            this.cbSearchByID.TabIndex = 70;
            this.cbSearchByID.Text = "Search By ID";
            this.cbSearchByID.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(739, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 69;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(173, 364);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(186, 23);
            this.txtPhone.TabIndex = 68;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(173, 321);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(186, 23);
            this.txtPassword.TabIndex = 67;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(173, 281);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 23);
            this.txtEmail.TabIndex = 66;
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(447, 137);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.RowTemplate.Height = 25;
            this.dgvMemberList.Size = new System.Drawing.Size(367, 306);
            this.dgvMemberList.TabIndex = 65;
            // 
            // btnExits
            // 
            this.btnExits.Location = new System.Drawing.Point(739, 484);
            this.btnExits.Name = "btnExits";
            this.btnExits.Size = new System.Drawing.Size(75, 23);
            this.btnExits.TabIndex = 64;
            this.btnExits.Text = "Exits";
            this.btnExits.UseVisualStyleBackColor = true;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(73, 96);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(286, 23);
            this.btnAddMember.TabIndex = 62;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(562, 92);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 61;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // lbSearchByName
            // 
            this.lbSearchByName.AutoSize = true;
            this.lbSearchByName.Location = new System.Drawing.Point(447, 65);
            this.lbSearchByName.Name = "lbSearchByName";
            this.lbSearchByName.Size = new System.Drawing.Size(97, 15);
            this.lbSearchByName.TabIndex = 60;
            this.lbSearchByName.Text = "Search_By_Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(547, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(186, 23);
            this.txtSearch.TabIndex = 59;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(107, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(230, 23);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Delete Student in class";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(173, 240);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(186, 23);
            this.txtGender.TabIndex = 57;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(173, 197);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(186, 23);
            this.txtMemberName.TabIndex = 56;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(173, 157);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(186, 23);
            this.txtMemberID.TabIndex = 55;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(73, 372);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(41, 15);
            this.lbPhone.TabIndex = 54;
            this.lbPhone.Text = "Phone";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(73, 327);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(57, 15);
            this.lbPassword.TabIndex = 53;
            this.lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(73, 289);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(36, 15);
            this.lbEmail.TabIndex = 52;
            this.lbEmail.Text = "Email";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(73, 248);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(45, 15);
            this.lbGender.TabIndex = 51;
            this.lbGender.Text = "Gender";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Location = new System.Drawing.Point(73, 205);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(87, 15);
            this.lbMemberName.TabIndex = 50;
            this.lbMemberName.Text = "Member Name";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(73, 165);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(66, 15);
            this.lbMemberID.TabIndex = 49;
            this.lbMemberID.Text = "Member ID";
            // 
            // cboStudentList
            // 
            this.cboStudentList.FormattingEnabled = true;
            this.cboStudentList.Location = new System.Drawing.Point(73, 55);
            this.cboStudentList.Name = "cboStudentList";
            this.cboStudentList.Size = new System.Drawing.Size(286, 23);
            this.cboStudentList.TabIndex = 71;
            // 
            // frmMemberInClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 552);
            this.Controls.Add(this.cboStudentList);
            this.Controls.Add(this.cbSearchByID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.btnExits);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbSearchByName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.lbMemberID);
            this.Name = "frmMemberInClass";
            this.Text = "frmMemberInClass";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbSearchByID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Button btnExits;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lbSearchByName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.ComboBox cboStudentList;
    }
}
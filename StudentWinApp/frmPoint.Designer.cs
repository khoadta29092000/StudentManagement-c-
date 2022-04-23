
namespace StudentWinApp
{
    partial class frmPoint
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
            this.lbSubjectID = new System.Windows.Forms.Label();
            this.lbAccountID = new System.Windows.Forms.Label();
            this.lbPoint15 = new System.Windows.Forms.Label();
            this.lbPoint60 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExits = new System.Windows.Forms.Button();
            this.txtSubjectID = new System.Windows.Forms.TextBox();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.txtPoint15 = new System.Windows.Forms.TextBox();
            this.txtPoint60 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbSubjectID
            // 
            this.lbSubjectID.AutoSize = true;
            this.lbSubjectID.Location = new System.Drawing.Point(19, 47);
            this.lbSubjectID.Name = "lbSubjectID";
            this.lbSubjectID.Size = new System.Drawing.Size(57, 15);
            this.lbSubjectID.TabIndex = 0;
            this.lbSubjectID.Text = "SubjectID";
            // 
            // lbAccountID
            // 
            this.lbAccountID.AutoSize = true;
            this.lbAccountID.Location = new System.Drawing.Point(19, 96);
            this.lbAccountID.Name = "lbAccountID";
            this.lbAccountID.Size = new System.Drawing.Size(63, 15);
            this.lbAccountID.TabIndex = 1;
            this.lbAccountID.Text = "AccountID";
            // 
            // lbPoint15
            // 
            this.lbPoint15.AutoSize = true;
            this.lbPoint15.Location = new System.Drawing.Point(19, 145);
            this.lbPoint15.Name = "lbPoint15";
            this.lbPoint15.Size = new System.Drawing.Size(93, 15);
            this.lbPoint15.TabIndex = 2;
            this.lbPoint15.Text = "Point(15Minute)";
            // 
            // lbPoint60
            // 
            this.lbPoint60.AutoSize = true;
            this.lbPoint60.Location = new System.Drawing.Point(19, 190);
            this.lbPoint60.Name = "lbPoint60";
            this.lbPoint60.Size = new System.Drawing.Size(81, 15);
            this.lbPoint60.TabIndex = 3;
            this.lbPoint60.Text = "Point(1Hours)";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(118, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExits
            // 
            this.btnExits.Location = new System.Drawing.Point(211, 237);
            this.btnExits.Name = "btnExits";
            this.btnExits.Size = new System.Drawing.Size(75, 23);
            this.btnExits.TabIndex = 5;
            this.btnExits.Text = "Exits";
            this.btnExits.UseVisualStyleBackColor = true;
            // 
            // txtSubjectID
            // 
            this.txtSubjectID.Location = new System.Drawing.Point(118, 39);
            this.txtSubjectID.Name = "txtSubjectID";
            this.txtSubjectID.Size = new System.Drawing.Size(168, 23);
            this.txtSubjectID.TabIndex = 7;
            // 
            // txtAccountID
            // 
            this.txtAccountID.Location = new System.Drawing.Point(118, 88);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(168, 23);
            this.txtAccountID.TabIndex = 8;
            // 
            // txtPoint15
            // 
            this.txtPoint15.Location = new System.Drawing.Point(118, 137);
            this.txtPoint15.Name = "txtPoint15";
            this.txtPoint15.Size = new System.Drawing.Size(168, 23);
            this.txtPoint15.TabIndex = 9;
            // 
            // txtPoint60
            // 
            this.txtPoint60.Location = new System.Drawing.Point(118, 182);
            this.txtPoint60.Name = "txtPoint60";
            this.txtPoint60.Size = new System.Drawing.Size(168, 23);
            this.txtPoint60.TabIndex = 10;
            // 
            // Point
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 276);
            this.Controls.Add(this.txtPoint60);
            this.Controls.Add(this.txtPoint15);
            this.Controls.Add(this.txtAccountID);
            this.Controls.Add(this.txtSubjectID);
            this.Controls.Add(this.btnExits);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbPoint60);
            this.Controls.Add(this.lbPoint15);
            this.Controls.Add(this.lbAccountID);
            this.Controls.Add(this.lbSubjectID);
            this.Name = "Point";
            this.Text = "Point";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSubjectID;
        private System.Windows.Forms.Label lbAccountID;
        private System.Windows.Forms.Label lbPoint15;
        private System.Windows.Forms.Label lbPoint60;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExits;
        private System.Windows.Forms.TextBox txtSubjectID;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.TextBox txtPoint15;
        private System.Windows.Forms.TextBox txtPoint60;
    }
}
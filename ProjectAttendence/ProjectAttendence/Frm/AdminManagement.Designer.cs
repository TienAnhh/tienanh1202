
namespace ProjectAttendence.Frm
{
    partial class AdminManagement
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
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnTimetable = new System.Windows.Forms.Button();
            this.btnListAccount = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubject
            // 
            this.btnSubject.Location = new System.Drawing.Point(37, 188);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(162, 51);
            this.btnSubject.TabIndex = 1;
            this.btnSubject.Text = "Manage Subject";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // btnClass
            // 
            this.btnClass.Location = new System.Drawing.Point(202, 79);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(163, 46);
            this.btnClass.TabIndex = 2;
            this.btnClass.Text = "Manage Class";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnTimetable
            // 
            this.btnTimetable.Location = new System.Drawing.Point(359, 188);
            this.btnTimetable.Name = "btnTimetable";
            this.btnTimetable.Size = new System.Drawing.Size(163, 51);
            this.btnTimetable.TabIndex = 3;
            this.btnTimetable.Text = "Manage Timtable";
            this.btnTimetable.UseVisualStyleBackColor = true;
            this.btnTimetable.Click += new System.EventHandler(this.btnTimetable_Click);
            // 
            // btnListAccount
            // 
            this.btnListAccount.Location = new System.Drawing.Point(202, 306);
            this.btnListAccount.Name = "btnListAccount";
            this.btnListAccount.Size = new System.Drawing.Size(162, 55);
            this.btnListAccount.TabIndex = 4;
            this.btnListAccount.Text = "Manage Account";
            this.btnListAccount.UseVisualStyleBackColor = true;
            this.btnListAccount.Click += new System.EventHandler(this.btnListAccount_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListAccount);
            this.Controls.Add(this.btnTimetable);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.btnSubject);
            this.Name = "AdminManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminManagement";
            this.Load += new System.EventHandler(this.AdminManagement_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnTimetable;
        private System.Windows.Forms.Button btnListAccount;
        private System.Windows.Forms.Button button1;
    }
}
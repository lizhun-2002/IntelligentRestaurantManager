namespace IntelligentRestaurantManager.UI
{
    partial class ProfileEditForm
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
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.labelOldPass = new System.Windows.Forms.Label();
            this.txtNewPassAgain = new System.Windows.Forms.TextBox();
            this.labelNewPassAgain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(179, 114);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(100, 21);
            this.txtNewPass.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(179, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 18;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(24, 116);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(108, 19);
            this.labelPass.TabIndex = 17;
            this.labelPass.Text = "New Password:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(24, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 19);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "Staff Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(165, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 30);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(41, 199);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(103, 30);
            this.btnOk.TabIndex = 20;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(179, 77);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(100, 21);
            this.txtOldPass.TabIndex = 23;
            // 
            // labelOldPass
            // 
            this.labelOldPass.AutoSize = true;
            this.labelOldPass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOldPass.Location = new System.Drawing.Point(24, 79);
            this.labelOldPass.Name = "labelOldPass";
            this.labelOldPass.Size = new System.Drawing.Size(127, 19);
            this.labelOldPass.TabIndex = 22;
            this.labelOldPass.Text = "Current Password:";
            // 
            // txtNewPassAgain
            // 
            this.txtNewPassAgain.Location = new System.Drawing.Point(179, 151);
            this.txtNewPassAgain.Name = "txtNewPassAgain";
            this.txtNewPassAgain.Size = new System.Drawing.Size(100, 21);
            this.txtNewPassAgain.TabIndex = 25;
            // 
            // labelNewPassAgain
            // 
            this.labelNewPassAgain.AutoSize = true;
            this.labelNewPassAgain.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPassAgain.Location = new System.Drawing.Point(24, 153);
            this.labelNewPassAgain.Name = "labelNewPassAgain";
            this.labelNewPassAgain.Size = new System.Drawing.Size(149, 19);
            this.labelNewPassAgain.TabIndex = 24;
            this.labelNewPassAgain.Text = "New Password Again:";
            // 
            // ProfileEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 253);
            this.Controls.Add(this.txtNewPassAgain);
            this.Controls.Add(this.labelNewPassAgain);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.labelOldPass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelName);
            this.Name = "ProfileEditForm";
            this.Text = "My Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label labelOldPass;
        private System.Windows.Forms.TextBox txtNewPassAgain;
        private System.Windows.Forms.Label labelNewPassAgain;
    }
}
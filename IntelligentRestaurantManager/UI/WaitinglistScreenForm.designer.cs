namespace IntelligentRestaurantManager.UI
{
    partial class WaitinglistScreenForm
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
            this.lbNumWaiting = new System.Windows.Forms.Label();
            this.lbWaitingPerson = new System.Windows.Forms.ListBox();
            this.lbCurrentTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNumWaiting
            // 
            this.lbNumWaiting.AutoSize = true;
            this.lbNumWaiting.Font = new System.Drawing.Font("Calibri", 20.25F);
            this.lbNumWaiting.Location = new System.Drawing.Point(17, 68);
            this.lbNumWaiting.Name = "lbNumWaiting";
            this.lbNumWaiting.Size = new System.Drawing.Size(81, 33);
            this.lbNumWaiting.TabIndex = 0;
            this.lbNumWaiting.Text = "label1";
            // 
            // lbWaitingPerson
            // 
            this.lbWaitingPerson.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbWaitingPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbWaitingPerson.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaitingPerson.FormattingEnabled = true;
            this.lbWaitingPerson.ItemHeight = 23;
            this.lbWaitingPerson.Location = new System.Drawing.Point(23, 125);
            this.lbWaitingPerson.Name = "lbWaitingPerson";
            this.lbWaitingPerson.Size = new System.Drawing.Size(428, 391);
            this.lbWaitingPerson.TabIndex = 1;
            // 
            // lbCurrentTime
            // 
            this.lbCurrentTime.AutoSize = true;
            this.lbCurrentTime.Font = new System.Drawing.Font("Calibri", 20.25F);
            this.lbCurrentTime.ForeColor = System.Drawing.Color.Blue;
            this.lbCurrentTime.Location = new System.Drawing.Point(17, 21);
            this.lbCurrentTime.Name = "lbCurrentTime";
            this.lbCurrentTime.Size = new System.Drawing.Size(81, 33);
            this.lbCurrentTime.TabIndex = 2;
            this.lbCurrentTime.Text = "label2";
            // 
            // WaitinglistScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 535);
            this.Controls.Add(this.lbCurrentTime);
            this.Controls.Add(this.lbWaitingPerson);
            this.Controls.Add(this.lbNumWaiting);
            this.Name = "WaitinglistScreenForm";
            this.Text = "WaitinglistScreenForm";
            this.Load += new System.EventHandler(this.WaitinglistScreenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumWaiting;
        private System.Windows.Forms.ListBox lbWaitingPerson;
        private System.Windows.Forms.Label lbCurrentTime;
    }
}
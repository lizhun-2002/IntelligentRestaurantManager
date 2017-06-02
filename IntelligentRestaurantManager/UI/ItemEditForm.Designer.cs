namespace IntelligentRestaurantManager.UI
{
    partial class ItemEditForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.nudAverageTimeCost = new System.Windows.Forms.NumericUpDown();
            this.nudItemId = new System.Windows.Forms.NumericUpDown();
            this.labelItemId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAverageTimeCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(178, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 30);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(54, 237);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(103, 30);
            this.btnOk.TabIndex = 24;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(181, 162);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 21);
            this.txtDescription.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(181, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 22;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(27, 95);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(45, 19);
            this.labelPass.TabIndex = 21;
            this.labelPass.Text = "Price:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(27, 63);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 19);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Name:";
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(181, 93);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 21);
            this.nudPrice.TabIndex = 28;
            // 
            // nudAverageTimeCost
            // 
            this.nudAverageTimeCost.Location = new System.Drawing.Point(181, 128);
            this.nudAverageTimeCost.Name = "nudAverageTimeCost";
            this.nudAverageTimeCost.Size = new System.Drawing.Size(120, 21);
            this.nudAverageTimeCost.TabIndex = 27;
            // 
            // nudItemId
            // 
            this.nudItemId.Location = new System.Drawing.Point(181, 27);
            this.nudItemId.Name = "nudItemId";
            this.nudItemId.Size = new System.Drawing.Size(120, 21);
            this.nudItemId.TabIndex = 26;
            // 
            // labelItemId
            // 
            this.labelItemId.AutoSize = true;
            this.labelItemId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemId.Location = new System.Drawing.Point(27, 28);
            this.labelItemId.Name = "labelItemId";
            this.labelItemId.Size = new System.Drawing.Size(60, 19);
            this.labelItemId.TabIndex = 29;
            this.labelItemId.Text = "Item ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Average Time Cost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 32;
            this.label3.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 33;
            this.label4.Text = "min";
            // 
            // ItemEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 292);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelItemId);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.nudAverageTimeCost);
            this.Controls.Add(this.nudItemId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelName);
            this.Name = "ItemEditForm";
            this.Text = "Input Item Information";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAverageTimeCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.NumericUpDown nudAverageTimeCost;
        private System.Windows.Forms.NumericUpDown nudItemId;
        private System.Windows.Forms.Label labelItemId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
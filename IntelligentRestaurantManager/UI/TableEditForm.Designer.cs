namespace IntelligentRestaurantManager.UI
{
    partial class TableEditForm
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
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelTabelId = new System.Windows.Forms.Label();
            this.labelLink1 = new System.Windows.Forms.Label();
            this.labelLink2 = new System.Windows.Forms.Label();
            this.labelLink3 = new System.Windows.Forms.Label();
            this.labelLink4 = new System.Windows.Forms.Label();
            this.nudTableId = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.nudLink2 = new System.Windows.Forms.NumericUpDown();
            this.nudLink1 = new System.Windows.Forms.NumericUpDown();
            this.nudLink4 = new System.Windows.Forms.NumericUpDown();
            this.nudLink3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudTableId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLink2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLink1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLink4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLink3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapacity.Location = new System.Drawing.Point(12, 63);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(69, 19);
            this.labelCapacity.TabIndex = 5;
            this.labelCapacity.Text = "Capacity:";
            // 
            // labelTabelId
            // 
            this.labelTabelId.AutoSize = true;
            this.labelTabelId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTabelId.Location = new System.Drawing.Point(12, 24);
            this.labelTabelId.Name = "labelTabelId";
            this.labelTabelId.Size = new System.Drawing.Size(64, 19);
            this.labelTabelId.TabIndex = 4;
            this.labelTabelId.Text = "Tabel Id:";
            // 
            // labelLink1
            // 
            this.labelLink1.AutoSize = true;
            this.labelLink1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLink1.Location = new System.Drawing.Point(12, 102);
            this.labelLink1.Name = "labelLink1";
            this.labelLink1.Size = new System.Drawing.Size(130, 19);
            this.labelLink1.TabIndex = 7;
            this.labelLink1.Text = "Linkable Table Id1:";
            // 
            // labelLink2
            // 
            this.labelLink2.AutoSize = true;
            this.labelLink2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLink2.Location = new System.Drawing.Point(12, 141);
            this.labelLink2.Name = "labelLink2";
            this.labelLink2.Size = new System.Drawing.Size(130, 19);
            this.labelLink2.TabIndex = 8;
            this.labelLink2.Text = "Linkable Table Id2:";
            // 
            // labelLink3
            // 
            this.labelLink3.AutoSize = true;
            this.labelLink3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLink3.Location = new System.Drawing.Point(12, 180);
            this.labelLink3.Name = "labelLink3";
            this.labelLink3.Size = new System.Drawing.Size(130, 19);
            this.labelLink3.TabIndex = 9;
            this.labelLink3.Text = "Linkable Table Id3:";
            // 
            // labelLink4
            // 
            this.labelLink4.AutoSize = true;
            this.labelLink4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLink4.Location = new System.Drawing.Point(12, 219);
            this.labelLink4.Name = "labelLink4";
            this.labelLink4.Size = new System.Drawing.Size(130, 19);
            this.labelLink4.TabIndex = 10;
            this.labelLink4.Text = "Linkable Table Id4:";
            // 
            // nudTableId
            // 
            this.nudTableId.Location = new System.Drawing.Point(179, 22);
            this.nudTableId.Name = "nudTableId";
            this.nudTableId.Size = new System.Drawing.Size(120, 21);
            this.nudTableId.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(179, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 30);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(55, 282);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(103, 30);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(179, 61);
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(120, 21);
            this.nudCapacity.TabIndex = 20;
            // 
            // nudLink2
            // 
            this.nudLink2.Location = new System.Drawing.Point(179, 139);
            this.nudLink2.Name = "nudLink2";
            this.nudLink2.Size = new System.Drawing.Size(120, 21);
            this.nudLink2.TabIndex = 22;
            // 
            // nudLink1
            // 
            this.nudLink1.Location = new System.Drawing.Point(179, 100);
            this.nudLink1.Name = "nudLink1";
            this.nudLink1.Size = new System.Drawing.Size(120, 21);
            this.nudLink1.TabIndex = 21;
            // 
            // nudLink4
            // 
            this.nudLink4.Location = new System.Drawing.Point(179, 217);
            this.nudLink4.Name = "nudLink4";
            this.nudLink4.Size = new System.Drawing.Size(120, 21);
            this.nudLink4.TabIndex = 24;
            // 
            // nudLink3
            // 
            this.nudLink3.Location = new System.Drawing.Point(179, 178);
            this.nudLink3.Name = "nudLink3";
            this.nudLink3.Size = new System.Drawing.Size(120, 21);
            this.nudLink3.TabIndex = 23;
            // 
            // TableEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 345);
            this.Controls.Add(this.nudLink4);
            this.Controls.Add(this.nudLink3);
            this.Controls.Add(this.nudLink2);
            this.Controls.Add(this.nudLink1);
            this.Controls.Add(this.nudCapacity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.nudTableId);
            this.Controls.Add(this.labelLink4);
            this.Controls.Add(this.labelLink3);
            this.Controls.Add(this.labelLink2);
            this.Controls.Add(this.labelLink1);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.labelTabelId);
            this.Name = "TableEditForm";
            this.Text = "Input Table Information";
            ((System.ComponentModel.ISupportInitialize)(this.nudTableId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLink2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLink1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLink4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLink3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelTabelId;
        private System.Windows.Forms.Label labelLink1;
        private System.Windows.Forms.Label labelLink2;
        private System.Windows.Forms.Label labelLink3;
        private System.Windows.Forms.Label labelLink4;
        private System.Windows.Forms.NumericUpDown nudTableId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.NumericUpDown nudLink2;
        private System.Windows.Forms.NumericUpDown nudLink1;
        private System.Windows.Forms.NumericUpDown nudLink4;
        private System.Windows.Forms.NumericUpDown nudLink3;
    }
}
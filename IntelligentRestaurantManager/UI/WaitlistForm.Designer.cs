namespace IntelligentRestaurantManager.UI
{
    partial class WaitlistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitlistForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTableId1 = new System.Windows.Forms.Label();
            this.btnAllocate = new System.Windows.Forms.Button();
            this.lbList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxWaiterName = new System.Windows.Forms.ComboBox();
            this.labelWaiterName = new System.Windows.Forms.Label();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNoOfPeople = new System.Windows.Forms.TextBox();
            this.labelNoOfPeople = new System.Windows.Forms.Label();
            this.nudTableId1 = new System.Windows.Forms.NumericUpDown();
            this.labelTableId3 = new System.Windows.Forms.Label();
            this.nudTableId2 = new System.Windows.Forms.NumericUpDown();
            this.labelTableId2 = new System.Windows.Forms.Label();
            this.nudTableId3 = new System.Windows.Forms.NumericUpDown();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTableId1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTableId2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTableId3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.nudNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 144);
            this.panel1.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(26, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(137, 87);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(78, 30);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // nudNumber
            // 
            this.nudNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumber.Location = new System.Drawing.Point(157, 33);
            this.nudNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(58, 27);
            this.nudNumber.TabIndex = 3;
            this.nudNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of People:";
            // 
            // labelTableId1
            // 
            this.labelTableId1.AutoSize = true;
            this.labelTableId1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableId1.Location = new System.Drawing.Point(23, 218);
            this.labelTableId1.Name = "labelTableId1";
            this.labelTableId1.Size = new System.Drawing.Size(78, 19);
            this.labelTableId1.TabIndex = 1;
            this.labelTableId1.Text = "Table ID 1:";
            // 
            // btnAllocate
            // 
            this.btnAllocate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllocate.Location = new System.Drawing.Point(74, 408);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(105, 84);
            this.btnAllocate.TabIndex = 7;
            this.btnAllocate.Text = "Allocate Table and Waiter";
            this.btnAllocate.UseVisualStyleBackColor = true;
            this.btnAllocate.Click += new System.EventHandler(this.btnAllocate_Click);
            // 
            // lbList
            // 
            this.lbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 19;
            this.lbList.Location = new System.Drawing.Point(0, 144);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(239, 394);
            this.lbList.TabIndex = 0;
            this.lbList.SelectedIndexChanged += new System.EventHandler(this.lbList_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbList);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 538);
            this.panel2.TabIndex = 9;
            // 
            // comboBoxWaiterName
            // 
            this.comboBoxWaiterName.FormattingEnabled = true;
            this.comboBoxWaiterName.Location = new System.Drawing.Point(152, 161);
            this.comboBoxWaiterName.Name = "comboBoxWaiterName";
            this.comboBoxWaiterName.Size = new System.Drawing.Size(70, 27);
            this.comboBoxWaiterName.TabIndex = 14;
            // 
            // labelWaiterName
            // 
            this.labelWaiterName.AutoSize = true;
            this.labelWaiterName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaiterName.Location = new System.Drawing.Point(23, 164);
            this.labelWaiterName.Name = "labelWaiterName";
            this.labelWaiterName.Size = new System.Drawing.Size(98, 19);
            this.labelWaiterName.TabIndex = 12;
            this.labelWaiterName.Text = "Waiter Name:";
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerId.Location = new System.Drawing.Point(23, 56);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(91, 19);
            this.labelCustomerId.TabIndex = 11;
            this.labelCustomerId.Text = "Customer Id:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNoOfPeople);
            this.groupBox1.Controls.Add(this.labelNoOfPeople);
            this.groupBox1.Controls.Add(this.nudTableId1);
            this.groupBox1.Controls.Add(this.labelTableId3);
            this.groupBox1.Controls.Add(this.nudTableId2);
            this.groupBox1.Controls.Add(this.labelTableId2);
            this.groupBox1.Controls.Add(this.nudTableId3);
            this.groupBox1.Controls.Add(this.txtCustomerId);
            this.groupBox1.Controls.Add(this.comboBoxWaiterName);
            this.groupBox1.Controls.Add(this.labelTableId1);
            this.groupBox1.Controls.Add(this.btnAllocate);
            this.groupBox1.Controls.Add(this.labelCustomerId);
            this.groupBox1.Controls.Add(this.labelWaiterName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(239, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 538);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Allocate Information";
            // 
            // txtNoOfPeople
            // 
            this.txtNoOfPeople.Location = new System.Drawing.Point(152, 107);
            this.txtNoOfPeople.Name = "txtNoOfPeople";
            this.txtNoOfPeople.Size = new System.Drawing.Size(70, 27);
            this.txtNoOfPeople.TabIndex = 25;
            // 
            // labelNoOfPeople
            // 
            this.labelNoOfPeople.AutoSize = true;
            this.labelNoOfPeople.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoOfPeople.Location = new System.Drawing.Point(23, 110);
            this.labelNoOfPeople.Name = "labelNoOfPeople";
            this.labelNoOfPeople.Size = new System.Drawing.Size(129, 19);
            this.labelNoOfPeople.TabIndex = 24;
            this.labelNoOfPeople.Text = "Number of People:";
            // 
            // nudTableId1
            // 
            this.nudTableId1.Location = new System.Drawing.Point(152, 215);
            this.nudTableId1.Name = "nudTableId1";
            this.nudTableId1.Size = new System.Drawing.Size(69, 27);
            this.nudTableId1.TabIndex = 23;
            // 
            // labelTableId3
            // 
            this.labelTableId3.AutoSize = true;
            this.labelTableId3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableId3.Location = new System.Drawing.Point(23, 326);
            this.labelTableId3.Name = "labelTableId3";
            this.labelTableId3.Size = new System.Drawing.Size(78, 19);
            this.labelTableId3.TabIndex = 22;
            this.labelTableId3.Text = "Table ID 3:";
            // 
            // nudTableId2
            // 
            this.nudTableId2.Location = new System.Drawing.Point(152, 269);
            this.nudTableId2.Name = "nudTableId2";
            this.nudTableId2.Size = new System.Drawing.Size(69, 27);
            this.nudTableId2.TabIndex = 21;
            // 
            // labelTableId2
            // 
            this.labelTableId2.AutoSize = true;
            this.labelTableId2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableId2.Location = new System.Drawing.Point(23, 272);
            this.labelTableId2.Name = "labelTableId2";
            this.labelTableId2.Size = new System.Drawing.Size(78, 19);
            this.labelTableId2.TabIndex = 20;
            this.labelTableId2.Text = "Table ID 2:";
            // 
            // nudTableId3
            // 
            this.nudTableId3.Location = new System.Drawing.Point(152, 323);
            this.nudTableId3.Name = "nudTableId3";
            this.nudTableId3.Size = new System.Drawing.Size(69, 27);
            this.nudTableId3.TabIndex = 19;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(152, 53);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(70, 27);
            this.txtCustomerId.TabIndex = 16;
            // 
            // WaitlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 538);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WaitlistForm";
            this.Text = "Waiting List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTableId1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTableId2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTableId3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.Label labelTableId1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxWaiterName;
        private System.Windows.Forms.Label labelWaiterName;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.NumericUpDown nudTableId3;
        private System.Windows.Forms.NumericUpDown nudTableId2;
        private System.Windows.Forms.Label labelTableId2;
        private System.Windows.Forms.NumericUpDown nudTableId1;
        private System.Windows.Forms.Label labelTableId3;
        private System.Windows.Forms.TextBox txtNoOfPeople;
        private System.Windows.Forms.Label labelNoOfPeople;
    }
}
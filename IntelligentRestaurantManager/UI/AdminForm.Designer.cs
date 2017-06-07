namespace IntelligentRestaurantManager.UI
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageStaff = new System.Windows.Forms.TabPage();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.tabPageTable = new System.Windows.Forms.TabPage();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.tabPageItem = new System.Windows.Forms.TabPage();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.tabPageStatistics = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerVolume = new System.Windows.Forms.TextBox();
            this.txtTurnover = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPageItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPageStatistics.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageStaff);
            this.tabControl1.Controls.Add(this.tabPageTable);
            this.tabControl1.Controls.Add(this.tabPageItem);
            this.tabControl1.Controls.Add(this.tabPageStatistics);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 470);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageStaff
            // 
            this.tabPageStaff.Controls.Add(this.dgvStaff);
            this.tabPageStaff.Controls.Add(this.panel1);
            this.tabPageStaff.Location = new System.Drawing.Point(4, 28);
            this.tabPageStaff.Name = "tabPageStaff";
            this.tabPageStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStaff.Size = new System.Drawing.Size(762, 438);
            this.tabPageStaff.TabIndex = 0;
            this.tabPageStaff.Text = "Staff";
            this.tabPageStaff.UseVisualStyleBackColor = true;
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.AllowUserToOrderColumns = true;
            this.dgvStaff.AllowUserToResizeColumns = false;
            this.dgvStaff.AllowUserToResizeRows = false;
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.Location = new System.Drawing.Point(3, 3);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowTemplate.Height = 23;
            this.dgvStaff.Size = new System.Drawing.Size(649, 432);
            this.dgvStaff.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnEditStaff);
            this.panel1.Controls.Add(this.btnDeleteStaff);
            this.panel1.Controls.Add(this.btnAddStaff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(652, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 432);
            this.panel1.TabIndex = 1;
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStaff.Location = new System.Drawing.Point(16, 125);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(75, 30);
            this.btnEditStaff.TabIndex = 2;
            this.btnEditStaff.Text = "Edit";
            this.btnEditStaff.UseVisualStyleBackColor = true;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStaff.Location = new System.Drawing.Point(16, 72);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteStaff.TabIndex = 1;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.Location = new System.Drawing.Point(16, 18);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(75, 30);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.Text = "Add";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // tabPageTable
            // 
            this.tabPageTable.Controls.Add(this.dgvTable);
            this.tabPageTable.Controls.Add(this.panel2);
            this.tabPageTable.Location = new System.Drawing.Point(4, 28);
            this.tabPageTable.Name = "tabPageTable";
            this.tabPageTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTable.Size = new System.Drawing.Size(762, 438);
            this.tabPageTable.TabIndex = 1;
            this.tabPageTable.Text = "Table";
            this.tabPageTable.UseVisualStyleBackColor = true;
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AllowUserToOrderColumns = true;
            this.dgvTable.AllowUserToResizeColumns = false;
            this.dgvTable.AllowUserToResizeRows = false;
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTable.Location = new System.Drawing.Point(3, 3);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowTemplate.Height = 23;
            this.dgvTable.Size = new System.Drawing.Size(649, 432);
            this.dgvTable.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnEditTable);
            this.panel2.Controls.Add(this.btnDeleteTable);
            this.panel2.Controls.Add(this.btnAddTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(652, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 432);
            this.panel2.TabIndex = 2;
            // 
            // btnEditTable
            // 
            this.btnEditTable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTable.Location = new System.Drawing.Point(16, 125);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(75, 30);
            this.btnEditTable.TabIndex = 2;
            this.btnEditTable.Text = "Edit";
            this.btnEditTable.UseVisualStyleBackColor = true;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTable.Location = new System.Drawing.Point(16, 72);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteTable.TabIndex = 1;
            this.btnDeleteTable.Text = "Delete";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTable.Location = new System.Drawing.Point(16, 18);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(75, 30);
            this.btnAddTable.TabIndex = 0;
            this.btnAddTable.Text = "Add";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // tabPageItem
            // 
            this.tabPageItem.Controls.Add(this.dgvItem);
            this.tabPageItem.Controls.Add(this.panel3);
            this.tabPageItem.Location = new System.Drawing.Point(4, 28);
            this.tabPageItem.Name = "tabPageItem";
            this.tabPageItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageItem.Size = new System.Drawing.Size(762, 438);
            this.tabPageItem.TabIndex = 2;
            this.tabPageItem.Text = "Item";
            this.tabPageItem.UseVisualStyleBackColor = true;
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.AllowUserToOrderColumns = true;
            this.dgvItem.AllowUserToResizeColumns = false;
            this.dgvItem.AllowUserToResizeRows = false;
            this.dgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItem.Location = new System.Drawing.Point(3, 3);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowTemplate.Height = 23;
            this.dgvItem.Size = new System.Drawing.Size(649, 432);
            this.dgvItem.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnEditItem);
            this.panel3.Controls.Add(this.btnDeleteItem);
            this.panel3.Controls.Add(this.btnAddItem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(652, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(107, 432);
            this.panel3.TabIndex = 3;
            // 
            // btnEditItem
            // 
            this.btnEditItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditItem.Location = new System.Drawing.Point(16, 125);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(75, 30);
            this.btnEditItem.TabIndex = 2;
            this.btnEditItem.Text = "Edit";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Location = new System.Drawing.Point(16, 72);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteItem.TabIndex = 1;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(16, 18);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 30);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // tabPageStatistics
            // 
            this.tabPageStatistics.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageStatistics.Controls.Add(this.monthCalendar1);
            this.tabPageStatistics.Controls.Add(this.dgvStatistics);
            this.tabPageStatistics.Controls.Add(this.groupBox1);
            this.tabPageStatistics.Controls.Add(this.panel4);
            this.tabPageStatistics.Location = new System.Drawing.Point(4, 28);
            this.tabPageStatistics.Name = "tabPageStatistics";
            this.tabPageStatistics.Size = new System.Drawing.Size(762, 438);
            this.tabPageStatistics.TabIndex = 3;
            this.tabPageStatistics.Text = "Statistics";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtDate);
            this.panel4.Controls.Add(this.btnQuery);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(762, 57);
            this.panel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCustomerVolume);
            this.groupBox1.Controls.Add(this.txtTurnover);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 79);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Person";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "$";
            // 
            // txtCustomerVolume
            // 
            this.txtCustomerVolume.Location = new System.Drawing.Point(494, 34);
            this.txtCustomerVolume.Name = "txtCustomerVolume";
            this.txtCustomerVolume.Size = new System.Drawing.Size(100, 27);
            this.txtCustomerVolume.TabIndex = 6;
            // 
            // txtTurnover
            // 
            this.txtTurnover.Location = new System.Drawing.Point(101, 34);
            this.txtTurnover.Name = "txtTurnover";
            this.txtTurnover.Size = new System.Drawing.Size(100, 27);
            this.txtTurnover.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turnover:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Flow Volume:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select date:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(116, 18);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(220, 27);
            this.txtDate.TabIndex = 1;
            this.txtDate.Enter += new System.EventHandler(this.txtDate_Enter);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(389, 17);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 28);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(116, 49);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // dgvStatistics
            // 
            this.dgvStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatistics.Location = new System.Drawing.Point(0, 136);
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.RowTemplate.Height = 23;
            this.dgvStatistics.Size = new System.Drawing.Size(762, 302);
            this.dgvStatistics.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 470);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "Intelligent Restaurant Manager 2017";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPageTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabPageItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabPageStatistics.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageStaff;
        private System.Windows.Forms.TabPage tabPageTable;
        private System.Windows.Forms.TabPage tabPageItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TabPage tabPageStatistics;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerVolume;
        private System.Windows.Forms.TextBox txtTurnover;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dgvStatistics;
    }
}
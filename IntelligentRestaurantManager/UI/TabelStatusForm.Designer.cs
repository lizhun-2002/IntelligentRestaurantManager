namespace IntelligentRestaurantManager.UI
{
    partial class TabelStatusForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.allocateTableWaiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTableStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleaningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waitingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutIRMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxWaiterId = new System.Windows.Forms.ComboBox();
            this.comboBoxCustomerId = new System.Windows.Forms.ComboBox();
            this.btnCreateEdit = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.labelOrderId = new System.Windows.Forms.Label();
            this.labelWaiterName = new System.Windows.Forms.Label();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.labelTableStatus = new System.Windows.Forms.Label();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelTabelId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelLegend5 = new System.Windows.Forms.Label();
            this.labelLegend4 = new System.Windows.Forms.Label();
            this.labelLegend3 = new System.Windows.Forms.Label();
            this.labelLegend2 = new System.Windows.Forms.Label();
            this.labelLegend1 = new System.Windows.Forms.Label();
            this.btnLegend5 = new System.Windows.Forms.Button();
            this.btnLegend4 = new System.Windows.Forms.Button();
            this.btnLegend3 = new System.Windows.Forms.Button();
            this.btnLegend2 = new System.Windows.Forms.Button();
            this.btnLegend1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allocateTableWaiterToolStripMenuItem,
            this.createOrderToolStripMenuItem,
            this.setTableStatusToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 70);
            // 
            // allocateTableWaiterToolStripMenuItem
            // 
            this.allocateTableWaiterToolStripMenuItem.Name = "allocateTableWaiterToolStripMenuItem";
            this.allocateTableWaiterToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.allocateTableWaiterToolStripMenuItem.Text = "&Create Order";
            this.allocateTableWaiterToolStripMenuItem.Click += new System.EventHandler(this.allocateTableWaiterToolStripMenuItem_Click);
            // 
            // createOrderToolStripMenuItem
            // 
            this.createOrderToolStripMenuItem.Name = "createOrderToolStripMenuItem";
            this.createOrderToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.createOrderToolStripMenuItem.Text = "&Edit Order";
            // 
            // setTableStatusToolStripMenuItem
            // 
            this.setTableStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeToolStripMenuItem,
            this.orderingToolStripMenuItem,
            this.cleaningToolStripMenuItem,
            this.reservedToolStripMenuItem,
            this.breakdownToolStripMenuItem});
            this.setTableStatusToolStripMenuItem.Name = "setTableStatusToolStripMenuItem";
            this.setTableStatusToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.setTableStatusToolStripMenuItem.Text = "&Set Table Status";
            // 
            // activeToolStripMenuItem
            // 
            this.activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            this.activeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.activeToolStripMenuItem.Text = "&Active";
            // 
            // orderingToolStripMenuItem
            // 
            this.orderingToolStripMenuItem.Name = "orderingToolStripMenuItem";
            this.orderingToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.orderingToolStripMenuItem.Text = "&Ordering";
            // 
            // cleaningToolStripMenuItem
            // 
            this.cleaningToolStripMenuItem.Name = "cleaningToolStripMenuItem";
            this.cleaningToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cleaningToolStripMenuItem.Text = "&Cleaning";
            // 
            // reservedToolStripMenuItem
            // 
            this.reservedToolStripMenuItem.Name = "reservedToolStripMenuItem";
            this.reservedToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.reservedToolStripMenuItem.Text = "&Reserved";
            // 
            // breakdownToolStripMenuItem
            // 
            this.breakdownToolStripMenuItem.Name = "breakdownToolStripMenuItem";
            this.breakdownToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.breakdownToolStripMenuItem.Text = "&Breakdown";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.waitingListToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // waitingListToolStripMenuItem
            // 
            this.waitingListToolStripMenuItem.Name = "waitingListToolStripMenuItem";
            this.waitingListToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.waitingListToolStripMenuItem.Text = "&Waiting List";
            this.waitingListToolStripMenuItem.Click += new System.EventHandler(this.waitingListToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutIRMToolStripMenuItem,
            this.copyRightToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // aboutIRMToolStripMenuItem
            // 
            this.aboutIRMToolStripMenuItem.Name = "aboutIRMToolStripMenuItem";
            this.aboutIRMToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.aboutIRMToolStripMenuItem.Text = "About IRM";
            // 
            // copyRightToolStripMenuItem
            // 
            this.copyRightToolStripMenuItem.Name = "copyRightToolStripMenuItem";
            this.copyRightToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.copyRightToolStripMenuItem.Text = "Copyright";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxWaiterId);
            this.panel1.Controls.Add(this.comboBoxCustomerId);
            this.panel1.Controls.Add(this.btnCreateEdit);
            this.panel1.Controls.Add(this.btnCreateOrder);
            this.panel1.Controls.Add(this.labelOrderId);
            this.panel1.Controls.Add(this.labelWaiterName);
            this.panel1.Controls.Add(this.labelCustomerId);
            this.panel1.Controls.Add(this.labelTableStatus);
            this.panel1.Controls.Add(this.labelCapacity);
            this.panel1.Controls.Add(this.labelTabelId);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(625, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 575);
            this.panel1.TabIndex = 2;
            // 
            // comboBoxWaiterId
            // 
            this.comboBoxWaiterId.FormattingEnabled = true;
            this.comboBoxWaiterId.Location = new System.Drawing.Point(37, 165);
            this.comboBoxWaiterId.Name = "comboBoxWaiterId";
            this.comboBoxWaiterId.Size = new System.Drawing.Size(121, 20);
            this.comboBoxWaiterId.TabIndex = 10;
            // 
            // comboBoxCustomerId
            // 
            this.comboBoxCustomerId.FormattingEnabled = true;
            this.comboBoxCustomerId.Location = new System.Drawing.Point(37, 108);
            this.comboBoxCustomerId.Name = "comboBoxCustomerId";
            this.comboBoxCustomerId.Size = new System.Drawing.Size(121, 20);
            this.comboBoxCustomerId.TabIndex = 9;
            // 
            // btnCreateEdit
            // 
            this.btnCreateEdit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEdit.Location = new System.Drawing.Point(16, 308);
            this.btnCreateEdit.Name = "btnCreateEdit";
            this.btnCreateEdit.Size = new System.Drawing.Size(144, 30);
            this.btnCreateEdit.TabIndex = 8;
            this.btnCreateEdit.Text = "Create and Edit Order";
            this.btnCreateEdit.UseVisualStyleBackColor = true;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.Location = new System.Drawing.Point(16, 255);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(144, 30);
            this.btnCreateOrder.TabIndex = 7;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // labelOrderId
            // 
            this.labelOrderId.AutoSize = true;
            this.labelOrderId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderId.Location = new System.Drawing.Point(12, 205);
            this.labelOrderId.Name = "labelOrderId";
            this.labelOrderId.Size = new System.Drawing.Size(66, 19);
            this.labelOrderId.TabIndex = 6;
            this.labelOrderId.Text = "Order Id:";
            // 
            // labelWaiterName
            // 
            this.labelWaiterName.AutoSize = true;
            this.labelWaiterName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaiterName.Location = new System.Drawing.Point(12, 142);
            this.labelWaiterName.Name = "labelWaiterName";
            this.labelWaiterName.Size = new System.Drawing.Size(98, 19);
            this.labelWaiterName.TabIndex = 5;
            this.labelWaiterName.Text = "Waiter Name:";
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerId.Location = new System.Drawing.Point(12, 85);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(91, 19);
            this.labelCustomerId.TabIndex = 4;
            this.labelCustomerId.Text = "Customer Id:";
            // 
            // labelTableStatus
            // 
            this.labelTableStatus.AutoSize = true;
            this.labelTableStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableStatus.Location = new System.Drawing.Point(12, 62);
            this.labelTableStatus.Name = "labelTableStatus";
            this.labelTableStatus.Size = new System.Drawing.Size(92, 19);
            this.labelTableStatus.TabIndex = 3;
            this.labelTableStatus.Text = "Table Status:";
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapacity.Location = new System.Drawing.Point(12, 38);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(69, 19);
            this.labelCapacity.TabIndex = 2;
            this.labelCapacity.Text = "Capacity:";
            // 
            // labelTabelId
            // 
            this.labelTabelId.AutoSize = true;
            this.labelTabelId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTabelId.Location = new System.Drawing.Point(12, 14);
            this.labelTabelId.Name = "labelTabelId";
            this.labelTabelId.Size = new System.Drawing.Size(64, 19);
            this.labelTabelId.TabIndex = 1;
            this.labelTabelId.Text = "Tabel Id:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelLegend5);
            this.groupBox1.Controls.Add(this.labelLegend4);
            this.groupBox1.Controls.Add(this.labelLegend3);
            this.groupBox1.Controls.Add(this.labelLegend2);
            this.groupBox1.Controls.Add(this.labelLegend1);
            this.groupBox1.Controls.Add(this.btnLegend5);
            this.groupBox1.Controls.Add(this.btnLegend4);
            this.groupBox1.Controls.Add(this.btnLegend3);
            this.groupBox1.Controls.Add(this.btnLegend2);
            this.groupBox1.Controls.Add(this.btnLegend1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Legend";
            // 
            // labelLegend5
            // 
            this.labelLegend5.AutoSize = true;
            this.labelLegend5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegend5.Location = new System.Drawing.Point(48, 169);
            this.labelLegend5.Name = "labelLegend5";
            this.labelLegend5.Size = new System.Drawing.Size(68, 14);
            this.labelLegend5.TabIndex = 9;
            this.labelLegend5.Text = "Breakdown";
            // 
            // labelLegend4
            // 
            this.labelLegend4.AutoSize = true;
            this.labelLegend4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegend4.Location = new System.Drawing.Point(48, 134);
            this.labelLegend4.Name = "labelLegend4";
            this.labelLegend4.Size = new System.Drawing.Size(57, 14);
            this.labelLegend4.TabIndex = 8;
            this.labelLegend4.Text = "Reserved";
            // 
            // labelLegend3
            // 
            this.labelLegend3.AutoSize = true;
            this.labelLegend3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegend3.Location = new System.Drawing.Point(48, 99);
            this.labelLegend3.Name = "labelLegend3";
            this.labelLegend3.Size = new System.Drawing.Size(55, 14);
            this.labelLegend3.TabIndex = 7;
            this.labelLegend3.Text = "Cleaning";
            // 
            // labelLegend2
            // 
            this.labelLegend2.AutoSize = true;
            this.labelLegend2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegend2.Location = new System.Drawing.Point(48, 64);
            this.labelLegend2.Name = "labelLegend2";
            this.labelLegend2.Size = new System.Drawing.Size(54, 14);
            this.labelLegend2.TabIndex = 6;
            this.labelLegend2.Text = "Ordering";
            // 
            // labelLegend1
            // 
            this.labelLegend1.AutoSize = true;
            this.labelLegend1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegend1.Location = new System.Drawing.Point(48, 29);
            this.labelLegend1.Name = "labelLegend1";
            this.labelLegend1.Size = new System.Drawing.Size(38, 14);
            this.labelLegend1.TabIndex = 5;
            this.labelLegend1.Text = "Active";
            // 
            // btnLegend5
            // 
            this.btnLegend5.BackColor = System.Drawing.Color.White;
            this.btnLegend5.Location = new System.Drawing.Point(12, 160);
            this.btnLegend5.Name = "btnLegend5";
            this.btnLegend5.Size = new System.Drawing.Size(30, 30);
            this.btnLegend5.TabIndex = 4;
            this.btnLegend5.UseVisualStyleBackColor = false;
            // 
            // btnLegend4
            // 
            this.btnLegend4.BackColor = System.Drawing.Color.Violet;
            this.btnLegend4.Location = new System.Drawing.Point(12, 125);
            this.btnLegend4.Name = "btnLegend4";
            this.btnLegend4.Size = new System.Drawing.Size(30, 30);
            this.btnLegend4.TabIndex = 3;
            this.btnLegend4.UseVisualStyleBackColor = false;
            // 
            // btnLegend3
            // 
            this.btnLegend3.BackColor = System.Drawing.Color.LightBlue;
            this.btnLegend3.Location = new System.Drawing.Point(12, 90);
            this.btnLegend3.Name = "btnLegend3";
            this.btnLegend3.Size = new System.Drawing.Size(30, 30);
            this.btnLegend3.TabIndex = 2;
            this.btnLegend3.UseVisualStyleBackColor = false;
            // 
            // btnLegend2
            // 
            this.btnLegend2.BackColor = System.Drawing.Color.LightSalmon;
            this.btnLegend2.Location = new System.Drawing.Point(12, 55);
            this.btnLegend2.Name = "btnLegend2";
            this.btnLegend2.Size = new System.Drawing.Size(30, 30);
            this.btnLegend2.TabIndex = 1;
            this.btnLegend2.UseVisualStyleBackColor = false;
            // 
            // btnLegend1
            // 
            this.btnLegend1.BackColor = System.Drawing.Color.SpringGreen;
            this.btnLegend1.Location = new System.Drawing.Point(12, 20);
            this.btnLegend1.Name = "btnLegend1";
            this.btnLegend1.Size = new System.Drawing.Size(30, 30);
            this.btnLegend1.TabIndex = 0;
            this.btnLegend1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(625, 575);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // TabelStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 600);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TabelStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intelligent Restaurant Manager 2017";
            this.Load += new System.EventHandler(this.TabelStatusForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allocateTableWaiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setTableStatusToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waitingListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutIRMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyRightToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLegend5;
        private System.Windows.Forms.Button btnLegend4;
        private System.Windows.Forms.Button btnLegend3;
        private System.Windows.Forms.Button btnLegend2;
        private System.Windows.Forms.Button btnLegend1;
        private System.Windows.Forms.Label labelLegend5;
        private System.Windows.Forms.Label labelLegend4;
        private System.Windows.Forms.Label labelLegend3;
        private System.Windows.Forms.Label labelLegend2;
        private System.Windows.Forms.Label labelLegend1;
        private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleaningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakdownToolStripMenuItem;
        private System.Windows.Forms.Label labelOrderId;
        private System.Windows.Forms.Label labelWaiterName;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.Label labelTableStatus;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelTabelId;
        private System.Windows.Forms.Button btnCreateEdit;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.ComboBox comboBoxWaiterId;
        private System.Windows.Forms.ComboBox comboBoxCustomerId;
    }
}


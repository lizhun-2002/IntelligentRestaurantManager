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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.allocateTableWaiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTableStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(838, 600);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allocateTableWaiterToolStripMenuItem,
            this.createOrderToolStripMenuItem,
            this.setTableStatusToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(227, 70);
            // 
            // allocateTableWaiterToolStripMenuItem
            // 
            this.allocateTableWaiterToolStripMenuItem.Name = "allocateTableWaiterToolStripMenuItem";
            this.allocateTableWaiterToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.allocateTableWaiterToolStripMenuItem.Text = "Allocate Table and Waiter";
            this.allocateTableWaiterToolStripMenuItem.Click += new System.EventHandler(this.allocateTableWaiterToolStripMenuItem_Click);
            // 
            // createOrderToolStripMenuItem
            // 
            this.createOrderToolStripMenuItem.Name = "createOrderToolStripMenuItem";
            this.createOrderToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.createOrderToolStripMenuItem.Text = "Create Order";
            // 
            // setTableStatusToolStripMenuItem
            // 
            this.setTableStatusToolStripMenuItem.Name = "setTableStatusToolStripMenuItem";
            this.setTableStatusToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.setTableStatusToolStripMenuItem.Text = "Set Table Status";
            // 
            // TabelStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 600);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "TabelStatusForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TabelStatusForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allocateTableWaiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setTableStatusToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


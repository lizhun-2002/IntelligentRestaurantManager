namespace IntelligentRestaurantManager
{
    partial class OrderListForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderListForm));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listbox1FlashTimer = new System.Windows.Forms.Timer(this.components);
            this.orderCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Orders";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 35;
            this.listBox1.Location = new System.Drawing.Point(10, 48);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(308, 249);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 35;
            this.listBox2.Location = new System.Drawing.Point(353, 48);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(280, 249);
            this.listBox2.TabIndex = 3;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 35;
            this.listBox3.Location = new System.Drawing.Point(672, 48);
            this.listBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(298, 249);
            this.listBox3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(348, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Processing Orders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(667, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Finished Orders";
            // 
            // listbox1FlashTimer
            // 
            this.listbox1FlashTimer.Interval = 500;
            this.listbox1FlashTimer.Tick += new System.EventHandler(this.listbox1FlashTimer_Tick);
            // 
            // orderCheckTimer
            // 
            this.orderCheckTimer.Enabled = true;
            this.orderCheckTimer.Interval = 3000;
            this.orderCheckTimer.Tick += new System.EventHandler(this.orderCheckTimer_Tick);
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 312);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "OrderListForm";
            this.Text = "OrderListForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer listbox1FlashTimer;
        private System.Windows.Forms.Timer orderCheckTimer;
    }
}
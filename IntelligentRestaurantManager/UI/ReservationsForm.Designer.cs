namespace IntelligentRestaurantManager
{
    partial class ReservationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationsForm));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timeUd = new System.Windows.Forms.NumericUpDown();
            this.tableComboBox = new System.Windows.Forms.ComboBox();
            this.partyNumberUd = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.timeUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyNumberUd)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(21, 29);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(11, 14, 11, 14);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(269, 29);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 175);
            this.listBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 324);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Reservation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 262);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Remove Reservation";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 271);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 27);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Party Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Time(hr)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Table";
            // 
            // timeUd
            // 
            this.timeUd.Location = new System.Drawing.Point(215, 271);
            this.timeUd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.timeUd.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.timeUd.Name = "timeUd";
            this.timeUd.Size = new System.Drawing.Size(69, 27);
            this.timeUd.TabIndex = 14;
            this.timeUd.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // tableComboBox
            // 
            this.tableComboBox.FormattingEnabled = true;
            this.tableComboBox.Location = new System.Drawing.Point(63, 324);
            this.tableComboBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(77, 27);
            this.tableComboBox.TabIndex = 15;
            // 
            // partyNumberUd
            // 
            this.partyNumberUd.Location = new System.Drawing.Point(138, 271);
            this.partyNumberUd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.partyNumberUd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.partyNumberUd.Name = "partyNumberUd";
            this.partyNumberUd.Size = new System.Drawing.Size(69, 27);
            this.partyNumberUd.TabIndex = 16;
            this.partyNumberUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 391);
            this.Controls.Add(this.partyNumberUd);
            this.Controls.Add(this.tableComboBox);
            this.Controls.Add(this.timeUd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ReservationsForm";
            this.Text = "ReservationsForm";
            this.Load += new System.EventHandler(this.ReservationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyNumberUd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown timeUd;
        private System.Windows.Forms.ComboBox tableComboBox;
        private System.Windows.Forms.NumericUpDown partyNumberUd;
    }
}
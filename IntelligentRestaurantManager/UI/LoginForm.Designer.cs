namespace IntelligentRestaurantManager.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelCloseLogin = new System.Windows.Forms.Label();
            this.pbManager = new System.Windows.Forms.PictureBox();
            this.pbWaiter = new System.Windows.Forms.PictureBox();
            this.pbCook = new System.Windows.Forms.PictureBox();
            this.pbCustomer = new System.Windows.Forms.PictureBox();
            this.labelLogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWaiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(223, 83);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(75, 19);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(223, 136);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(71, 19);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(226, 112);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 21);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(226, 159);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(226, 198);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelCloseLogin
            // 
            this.labelCloseLogin.AutoSize = true;
            this.labelCloseLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelCloseLogin.Location = new System.Drawing.Point(371, 9);
            this.labelCloseLogin.Name = "labelCloseLogin";
            this.labelCloseLogin.Size = new System.Drawing.Size(17, 12);
            this.labelCloseLogin.TabIndex = 5;
            this.labelCloseLogin.Text = "×";
            this.labelCloseLogin.Click += new System.EventHandler(this.labelCloseLogin_Click);
            // 
            // pbManager
            // 
            this.pbManager.BackColor = System.Drawing.Color.Transparent;
            this.pbManager.Image = ((System.Drawing.Image)(resources.GetObject("pbManager.Image")));
            this.pbManager.Location = new System.Drawing.Point(1, 41);
            this.pbManager.Name = "pbManager";
            this.pbManager.Size = new System.Drawing.Size(200, 130);
            this.pbManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbManager.TabIndex = 6;
            this.pbManager.TabStop = false;
            this.pbManager.Click += new System.EventHandler(this.pbManager_Click);
            // 
            // pbWaiter
            // 
            this.pbWaiter.Image = ((System.Drawing.Image)(resources.GetObject("pbWaiter.Image")));
            this.pbWaiter.Location = new System.Drawing.Point(198, 41);
            this.pbWaiter.Name = "pbWaiter";
            this.pbWaiter.Size = new System.Drawing.Size(200, 130);
            this.pbWaiter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbWaiter.TabIndex = 7;
            this.pbWaiter.TabStop = false;
            this.pbWaiter.Click += new System.EventHandler(this.pbWaiter_Click);
            // 
            // pbCook
            // 
            this.pbCook.Image = ((System.Drawing.Image)(resources.GetObject("pbCook.Image")));
            this.pbCook.Location = new System.Drawing.Point(1, 169);
            this.pbCook.Name = "pbCook";
            this.pbCook.Size = new System.Drawing.Size(200, 130);
            this.pbCook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCook.TabIndex = 8;
            this.pbCook.TabStop = false;
            this.pbCook.Click += new System.EventHandler(this.pbCook_Click);
            // 
            // pbCustomer
            // 
            this.pbCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbCustomer.Image")));
            this.pbCustomer.Location = new System.Drawing.Point(198, 169);
            this.pbCustomer.Name = "pbCustomer";
            this.pbCustomer.Size = new System.Drawing.Size(200, 130);
            this.pbCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCustomer.TabIndex = 9;
            this.pbCustomer.TabStop = false;
            this.pbCustomer.Click += new System.EventHandler(this.pbCustomer_Click);
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Segoe Marker", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.Location = new System.Drawing.Point(62, 9);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(274, 24);
            this.labelLogo.TabIndex = 11;
            this.labelLogo.Text = "Intelligent Restaurant Manager 2017";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.pbCustomer);
            this.Controls.Add(this.pbCook);
            this.Controls.Add(this.labelCloseLogin);
            this.Controls.Add(this.pbWaiter);
            this.Controls.Add(this.pbManager);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWaiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelCloseLogin;
        private System.Windows.Forms.PictureBox pbManager;
        private System.Windows.Forms.PictureBox pbWaiter;
        private System.Windows.Forms.PictureBox pbCook;
        private System.Windows.Forms.PictureBox pbCustomer;
        private System.Windows.Forms.Label labelLogo;
    }
}
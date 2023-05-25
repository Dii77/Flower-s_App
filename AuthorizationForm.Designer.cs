namespace Flower_s_App
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserLogin = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.btn_Registration = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheckPassword = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.aboutApp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserLogin.Location = new System.Drawing.Point(362, 271);
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(174, 43);
            this.txtUserLogin.TabIndex = 2;
            this.txtUserLogin.TextChanged += new System.EventHandler(this.txtUserLogin_TextChanged);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassword.Location = new System.Drawing.Point(362, 356);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(124, 43);
            this.txtUserPassword.TabIndex = 3;
            this.txtUserPassword.UseSystemPasswordChar = true;
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Enter.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Enter.Location = new System.Drawing.Point(176, 474);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(360, 57);
            this.btn_Enter.TabIndex = 4;
            this.btn_Enter.Text = "Войти в систему";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // btn_Registration
            // 
            this.btn_Registration.BackColor = System.Drawing.Color.Wheat;
            this.btn_Registration.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registration.Location = new System.Drawing.Point(359, 537);
            this.btn_Registration.Name = "btn_Registration";
            this.btn_Registration.Size = new System.Drawing.Size(177, 44);
            this.btn_Registration.TabIndex = 5;
            this.btn_Registration.Text = "Регистрация";
            this.btn_Registration.UseVisualStyleBackColor = false;
            this.btn_Registration.Click += new System.EventHandler(this.btn_Registration_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Нет аккаунта?";
            // 
            // btnCheckPassword
            // 
            this.btnCheckPassword.BackColor = System.Drawing.Color.Pink;
            this.btnCheckPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckPassword.BackgroundImage")));
            this.btnCheckPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckPassword.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckPassword.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnCheckPassword.Location = new System.Drawing.Point(492, 356);
            this.btnCheckPassword.Name = "btnCheckPassword";
            this.btnCheckPassword.Size = new System.Drawing.Size(44, 44);
            this.btnCheckPassword.TabIndex = 7;
            this.btnCheckPassword.UseVisualStyleBackColor = false;
            this.btnCheckPassword.Click += new System.EventHandler(this.btnCheckPassword_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // aboutApp
            // 
            this.aboutApp.BackColor = System.Drawing.Color.Orchid;
            this.aboutApp.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.aboutApp.ForeColor = System.Drawing.Color.Lavender;
            this.aboutApp.Location = new System.Drawing.Point(176, 614);
            this.aboutApp.Name = "aboutApp";
            this.aboutApp.Size = new System.Drawing.Size(360, 42);
            this.aboutApp.TabIndex = 8;
            this.aboutApp.Text = "О программе";
            this.aboutApp.UseVisualStyleBackColor = false;
            this.aboutApp.Click += new System.EventHandler(this.aboutApp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(286, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(713, 816);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aboutApp);
            this.Controls.Add(this.btnCheckPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Registration);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtUserLogin;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Button btn_Registration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button aboutApp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
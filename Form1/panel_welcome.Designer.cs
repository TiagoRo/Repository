namespace Form1
{
    partial class panel_welcome
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
            this.btn_registo = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel_wel = new System.Windows.Forms.Panel();
            this.panel_wel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_registo
            // 
            this.btn_registo.BackColor = System.Drawing.Color.DarkGray;
            this.btn_registo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_registo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registo.Location = new System.Drawing.Point(251, 284);
            this.btn_registo.Name = "btn_registo";
            this.btn_registo.Size = new System.Drawing.Size(123, 42);
            this.btn_registo.TabIndex = 67;
            this.btn_registo.Text = "Registar";
            this.btn_registo.UseVisualStyleBackColor = false;
            this.btn_registo.Click += new System.EventHandler(this.btn_registo_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DarkGray;
            this.btn_login.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(251, 226);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(123, 42);
            this.btn_login.TabIndex = 66;
            this.btn_login.Text = "Iniciar Sessâo";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel_wel
            // 
            this.panel_wel.Controls.Add(this.btn_registo);
            this.panel_wel.Controls.Add(this.btn_login);
            this.panel_wel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_wel.Location = new System.Drawing.Point(0, 0);
            this.panel_wel.Name = "panel_wel";
            this.panel_wel.Size = new System.Drawing.Size(624, 596);
            this.panel_wel.TabIndex = 68;
            // 
            // panel_welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 596);
            this.Controls.Add(this.panel_wel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "panel_welcome";
            this.Text = "panel_welcome";
            this.panel_wel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_registo;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel panel_wel;
    }
}
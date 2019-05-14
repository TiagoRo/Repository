namespace Form1
{
    partial class Registar
    {
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registar));
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telemovelTextBox = new System.Windows.Forms.TextBox();
            this.radioBtnMacho = new System.Windows.Forms.RadioButton();
            this.radioBtnFemea = new System.Windows.Forms.RadioButton();
            this.adicionar = new System.Windows.Forms.Button();
            this.panel_registo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tl_username = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel_registo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userTextBox
            // 
            this.userTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.userTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTextBox.Location = new System.Drawing.Point(169, 208);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(325, 13);
            this.userTextBox.TabIndex = 5;
            this.userTextBox.Text = "Nome de Utilizador";
            this.userTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userTextBox.TextChanged += new System.EventHandler(this.userText);
            this.userTextBox.Enter += new System.EventHandler(this.userTextBox_Enter);
            this.userTextBox.Leave += new System.EventHandler(this.userTextBox_Leave);
            // 
            // passTextBox
            // 
            this.passTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.passTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passTextBox.Location = new System.Drawing.Point(165, 250);
            this.passTextBox.Multiline = true;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(325, 13);
            this.passTextBox.TabIndex = 6;
            this.passTextBox.Text = "Palavra Passe";
            this.passTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passTextBox.TextChanged += new System.EventHandler(this.passText);
            this.passTextBox.Enter += new System.EventHandler(this.passTextBox_Enter);
            this.passTextBox.Leave += new System.EventHandler(this.passTextBox_Leave);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Location = new System.Drawing.Point(165, 288);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(325, 13);
            this.emailTextBox.TabIndex = 7;
            this.emailTextBox.Text = "Email";
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailText);
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // telemovelTextBox
            // 
            this.telemovelTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.telemovelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telemovelTextBox.Location = new System.Drawing.Point(165, 330);
            this.telemovelTextBox.Multiline = true;
            this.telemovelTextBox.Name = "telemovelTextBox";
            this.telemovelTextBox.Size = new System.Drawing.Size(325, 13);
            this.telemovelTextBox.TabIndex = 9;
            this.telemovelTextBox.Text = "Telemovel";
            this.telemovelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.telemovelTextBox.TextChanged += new System.EventHandler(this.telemovelText);
            this.telemovelTextBox.Enter += new System.EventHandler(this.telemovelTextBox_Enter);
            this.telemovelTextBox.Leave += new System.EventHandler(this.telemovelTextBox_Leave);
            // 
            // radioBtnMacho
            // 
            this.radioBtnMacho.AutoSize = true;
            this.radioBtnMacho.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnMacho.Location = new System.Drawing.Point(255, 372);
            this.radioBtnMacho.Name = "radioBtnMacho";
            this.radioBtnMacho.Size = new System.Drawing.Size(58, 17);
            this.radioBtnMacho.TabIndex = 10;
            this.radioBtnMacho.TabStop = true;
            this.radioBtnMacho.Text = "Macho";
            this.radioBtnMacho.UseVisualStyleBackColor = false;
            this.radioBtnMacho.CheckedChanged += new System.EventHandler(this.radioBtnM);
            // 
            // radioBtnFemea
            // 
            this.radioBtnFemea.AutoSize = true;
            this.radioBtnFemea.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnFemea.Location = new System.Drawing.Point(349, 372);
            this.radioBtnFemea.Name = "radioBtnFemea";
            this.radioBtnFemea.Size = new System.Drawing.Size(57, 17);
            this.radioBtnFemea.TabIndex = 11;
            this.radioBtnFemea.TabStop = true;
            this.radioBtnFemea.Text = "Femea";
            this.radioBtnFemea.UseVisualStyleBackColor = false;
            this.radioBtnFemea.CheckedChanged += new System.EventHandler(this.radioBtnF);
            // 
            // adicionar
            // 
            this.adicionar.BackColor = System.Drawing.Color.DarkGray;
            this.adicionar.FlatAppearance.BorderSize = 0;
            this.adicionar.Location = new System.Drawing.Point(279, 420);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(86, 34);
            this.adicionar.TabIndex = 12;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = false;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // panel_registo
            // 
            this.panel_registo.BackColor = System.Drawing.Color.Transparent;
            this.panel_registo.Controls.Add(this.pictureBox1);
            this.panel_registo.Controls.Add(this.radioBtnFemea);
            this.panel_registo.Controls.Add(this.label1);
            this.panel_registo.Controls.Add(this.radioBtnMacho);
            this.panel_registo.Controls.Add(this.adicionar);
            this.panel_registo.Controls.Add(this.telemovelTextBox);
            this.panel_registo.Controls.Add(this.emailTextBox);
            this.panel_registo.Controls.Add(this.userTextBox);
            this.panel_registo.Controls.Add(this.passTextBox);
            this.panel_registo.Controls.Add(this.shapeContainer1);
            this.panel_registo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_registo.Location = new System.Drawing.Point(0, 0);
            this.panel_registo.Name = "panel_registo";
            this.panel_registo.Size = new System.Drawing.Size(640, 635);
            this.panel_registo.TabIndex = 66;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logotipo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1,
            this.tl_username});
            this.shapeContainer1.Size = new System.Drawing.Size(640, 635);
            this.shapeContainer1.TabIndex = 68;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 169;
            this.lineShape3.X2 = 490;
            this.lineShape3.Y1 = 343;
            this.lineShape3.Y2 = 343;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 167;
            this.lineShape2.X2 = 488;
            this.lineShape2.Y1 = 301;
            this.lineShape2.Y2 = 301;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 168;
            this.lineShape1.X2 = 489;
            this.lineShape1.Y1 = 263;
            this.lineShape1.Y2 = 263;
            // 
            // tl_username
            // 
            this.tl_username.Name = "tl_username";
            this.tl_username.X1 = 171;
            this.tl_username.X2 = 492;
            this.tl_username.Y1 = 221;
            this.tl_username.Y2 = 221;
            // 
            // Registar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 635);
            this.Controls.Add(this.panel_registo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registar";
            this.Text = "Form1";
            this.panel_registo.ResumeLayout(false);
            this.panel_registo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telemovelTextBox;
        private System.Windows.Forms.RadioButton radioBtnMacho;
        private System.Windows.Forms.RadioButton radioBtnFemea;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.Panel panel_registo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape tl_username;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}


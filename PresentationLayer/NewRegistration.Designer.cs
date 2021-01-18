using System;

namespace Alumn20
{
    partial class NewRegistration
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
            this.registerButton = new System.Windows.Forms.Button();
            this.acceptCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.degreeComboBox = new System.Windows.Forms.TextBox();
            this.creditsTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.personalNrTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.programcomboBox = new System.Windows.Forms.ComboBox();
            this.classescomboBox1 = new System.Windows.Forms.ComboBox();
            this.occupationcomboBox1 = new System.Windows.Forms.ComboBox();
            this.Errorlbl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(616, 414);
            this.registerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(107, 33);
            this.registerButton.TabIndex = 51;
            this.registerButton.Text = "Registrera";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click_1);
            // 
            // acceptCheckBox
            // 
            this.acceptCheckBox.AutoSize = true;
            this.acceptCheckBox.Location = new System.Drawing.Point(616, 370);
            this.acceptCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.acceptCheckBox.Name = "acceptCheckBox";
            this.acceptCheckBox.Size = new System.Drawing.Size(241, 21);
            this.acceptCheckBox.TabIndex = 50;
            this.acceptCheckBox.Text = "Jag accepterar användarvillkoren";
            this.acceptCheckBox.UseVisualStyleBackColor = true;
            this.acceptCheckBox.CheckedChanged += new System.EventHandler(this.acceptCheckBox_CheckedChanged_1);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(613, 313);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(189, 22);
            this.passwordTextBox.TabIndex = 49;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(613, 241);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(189, 22);
            this.userTextBox.TabIndex = 48;
            this.userTextBox.TextChanged += new System.EventHandler(this.userTextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(613, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 34);
            this.label13.TabIndex = 47;
            this.label13.Text = "Lösenord \r\n(Innehållande 10 tecken)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(611, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 34);
            this.label12.TabIndex = 46;
            this.label12.Text = "Välj användarnamn \r\n(max 10 tecken)";
            // 
            // degreeComboBox
            // 
            this.degreeComboBox.Location = new System.Drawing.Point(367, 430);
            this.degreeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.degreeComboBox.Name = "degreeComboBox";
            this.degreeComboBox.Size = new System.Drawing.Size(100, 22);
            this.degreeComboBox.TabIndex = 44;
            // 
            // creditsTextBox
            // 
            this.creditsTextBox.Location = new System.Drawing.Point(367, 391);
            this.creditsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.creditsTextBox.Name = "creditsTextBox";
            this.creditsTextBox.Size = new System.Drawing.Size(100, 22);
            this.creditsTextBox.TabIndex = 43;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(367, 302);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 22);
            this.emailTextBox.TabIndex = 40;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(367, 262);
            this.lastNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameBox.TabIndex = 39;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(367, 230);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 38;
            // 
            // personalNrTextBox
            // 
            this.personalNrTextBox.Location = new System.Drawing.Point(367, 197);
            this.personalNrTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personalNrTextBox.Name = "personalNrTextBox";
            this.personalNrTextBox.Size = new System.Drawing.Size(100, 22);
            this.personalNrTextBox.TabIndex = 37;
            this.personalNrTextBox.TextChanged += new System.EventHandler(this.personalNrTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(141, 465);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Vad arbetar du med idag?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(141, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Har du tagit examen?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Hur många HP har du läst?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Vilket år började du studera?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Mejladress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Efternamn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Namn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Personnummer: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Vad har du studerat?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fyll i uppgifter nedan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Registrering av ny Alumn";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(68, 38);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(149, 29);
            this.welcomeLabel.TabIndex = 52;
            this.welcomeLabel.Text = "Välkommen";
            // 
            // programcomboBox
            // 
            this.programcomboBox.FormattingEnabled = true;
            this.programcomboBox.Location = new System.Drawing.Point(367, 330);
            this.programcomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.programcomboBox.Name = "programcomboBox";
            this.programcomboBox.Size = new System.Drawing.Size(100, 24);
            this.programcomboBox.TabIndex = 53;
            // 
            // classescomboBox1
            // 
            this.classescomboBox1.FormattingEnabled = true;
            this.classescomboBox1.Location = new System.Drawing.Point(367, 361);
            this.classescomboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.classescomboBox1.Name = "classescomboBox1";
            this.classescomboBox1.Size = new System.Drawing.Size(100, 24);
            this.classescomboBox1.TabIndex = 53;
            // 
            // occupationcomboBox1
            // 
            this.occupationcomboBox1.FormattingEnabled = true;
            this.occupationcomboBox1.Location = new System.Drawing.Point(367, 462);
            this.occupationcomboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.occupationcomboBox1.Name = "occupationcomboBox1";
            this.occupationcomboBox1.Size = new System.Drawing.Size(100, 24);
            this.occupationcomboBox1.TabIndex = 53;
            // 
            // Errorlbl
            // 
            this.Errorlbl.Location = new System.Drawing.Point(772, 515);
            this.Errorlbl.Name = "Errorlbl";
            this.Errorlbl.Size = new System.Drawing.Size(95, 23);
            this.Errorlbl.TabIndex = 54;
            this.Errorlbl.Text = "ErrorButton";
            this.Errorlbl.UseVisualStyleBackColor = true;
            this.Errorlbl.Click += new System.EventHandler(this.Errorlbl_Click);
            // 
            // NewRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 550);
            this.Controls.Add(this.Errorlbl);
            this.Controls.Add(this.occupationcomboBox1);
            this.Controls.Add(this.classescomboBox1);
            this.Controls.Add(this.programcomboBox);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.acceptCheckBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.degreeComboBox);
            this.Controls.Add(this.creditsTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.personalNrTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewRegistration";
            this.Text = "NewRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.CheckBox acceptCheckBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox degreeComboBox;
        private System.Windows.Forms.TextBox creditsTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox personalNrTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.ComboBox programcomboBox;
        private System.Windows.Forms.ComboBox classescomboBox1;
        private System.Windows.Forms.ComboBox occupationcomboBox1;
        private System.Windows.Forms.Button Errorlbl;

        public EventHandler registerButton_Click { get; private set; }
    }
}
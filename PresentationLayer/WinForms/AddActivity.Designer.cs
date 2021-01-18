namespace PresentationLayer.WinForms
{
    partial class AddActivity
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
            this.CreateActivitybtn = new System.Windows.Forms.Button();
            this.EndDatetxtBox = new System.Windows.Forms.TextBox();
            this.StartDatetxtBox = new System.Windows.Forms.TextBox();
            this.ActivityCreatorTxtBox = new System.Windows.Forms.TextBox();
            this.EventIDTxtBox = new System.Windows.Forms.TextBox();
            this.ActivityNameTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VerifyCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Returnbtn = new System.Windows.Forms.Button();
            this.Feedbacklbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateActivitybtn
            // 
            this.CreateActivitybtn.Enabled = false;
            this.CreateActivitybtn.Location = new System.Drawing.Point(621, 391);
            this.CreateActivitybtn.Margin = new System.Windows.Forms.Padding(2);
            this.CreateActivitybtn.Name = "CreateActivitybtn";
            this.CreateActivitybtn.Size = new System.Drawing.Size(119, 29);
            this.CreateActivitybtn.TabIndex = 44;
            this.CreateActivitybtn.Text = "Skapa aktivitet";
            this.CreateActivitybtn.UseVisualStyleBackColor = true;
            this.CreateActivitybtn.Click += new System.EventHandler(this.CreateActivitybtn_Click);
            // 
            // EndDatetxtBox
            // 
            this.EndDatetxtBox.Location = new System.Drawing.Point(335, 272);
            this.EndDatetxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.EndDatetxtBox.Name = "EndDatetxtBox";
            this.EndDatetxtBox.Size = new System.Drawing.Size(112, 20);
            this.EndDatetxtBox.TabIndex = 42;
            // 
            // StartDatetxtBox
            // 
            this.StartDatetxtBox.Location = new System.Drawing.Point(335, 225);
            this.StartDatetxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.StartDatetxtBox.Name = "StartDatetxtBox";
            this.StartDatetxtBox.Size = new System.Drawing.Size(112, 20);
            this.StartDatetxtBox.TabIndex = 41;
            // 
            // ActivityCreatorTxtBox
            // 
            this.ActivityCreatorTxtBox.Location = new System.Drawing.Point(335, 175);
            this.ActivityCreatorTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.ActivityCreatorTxtBox.Name = "ActivityCreatorTxtBox";
            this.ActivityCreatorTxtBox.Size = new System.Drawing.Size(112, 20);
            this.ActivityCreatorTxtBox.TabIndex = 40;
            // 
            // EventIDTxtBox
            // 
            this.EventIDTxtBox.Location = new System.Drawing.Point(335, 129);
            this.EventIDTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.EventIDTxtBox.Name = "EventIDTxtBox";
            this.EventIDTxtBox.Size = new System.Drawing.Size(112, 20);
            this.EventIDTxtBox.TabIndex = 39;
            // 
            // ActivityNameTxtBox
            // 
            this.ActivityNameTxtBox.Location = new System.Drawing.Point(335, 85);
            this.ActivityNameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.ActivityNameTxtBox.Name = "ActivityNameTxtBox";
            this.ActivityNameTxtBox.Size = new System.Drawing.Size(112, 20);
            this.ActivityNameTxtBox.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "AktivitetId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Slutdatum för aktivitet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Startdatum av aktivitet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Skaparen av aktiviteten:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Namn på aktivitet:";
            // 
            // VerifyCheckbox
            // 
            this.VerifyCheckbox.AutoSize = true;
            this.VerifyCheckbox.Location = new System.Drawing.Point(501, 356);
            this.VerifyCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.VerifyCheckbox.Name = "VerifyCheckbox";
            this.VerifyCheckbox.Size = new System.Drawing.Size(139, 17);
            this.VerifyCheckbox.TabIndex = 31;
            this.VerifyCheckbox.Text = "Stämmer informationen?";
            this.VerifyCheckbox.UseVisualStyleBackColor = true;
            this.VerifyCheckbox.CheckedChanged += new System.EventHandler(this.VerifyCheckbox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Fyll i nedan för att lägga till aktivitet";
            // 
            // Returnbtn
            // 
            this.Returnbtn.Location = new System.Drawing.Point(501, 391);
            this.Returnbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Returnbtn.Name = "Returnbtn";
            this.Returnbtn.Size = new System.Drawing.Size(119, 29);
            this.Returnbtn.TabIndex = 44;
            this.Returnbtn.Text = "Tillbaka";
            this.Returnbtn.UseVisualStyleBackColor = true;
            this.Returnbtn.Click += new System.EventHandler(this.Returnbtn_Click);
            // 
            // Feedbacklbl
            // 
            this.Feedbacklbl.AutoSize = true;
            this.Feedbacklbl.Location = new System.Drawing.Point(501, 425);
            this.Feedbacklbl.Name = "Feedbacklbl";
            this.Feedbacklbl.Size = new System.Drawing.Size(65, 13);
            this.Feedbacklbl.TabIndex = 45;
            this.Feedbacklbl.Text = "Feedbacklbl";
            this.Feedbacklbl.Visible = false;
            // 
            // AddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Feedbacklbl);
            this.Controls.Add(this.Returnbtn);
            this.Controls.Add(this.CreateActivitybtn);
            this.Controls.Add(this.EndDatetxtBox);
            this.Controls.Add(this.StartDatetxtBox);
            this.Controls.Add(this.ActivityCreatorTxtBox);
            this.Controls.Add(this.EventIDTxtBox);
            this.Controls.Add(this.ActivityNameTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VerifyCheckbox);
            this.Controls.Add(this.label1);
            this.Name = "AddActivity";
            this.Text = "AddActivity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateActivitybtn;
        private System.Windows.Forms.TextBox EndDatetxtBox;
        private System.Windows.Forms.TextBox StartDatetxtBox;
        private System.Windows.Forms.TextBox ActivityCreatorTxtBox;
        private System.Windows.Forms.TextBox EventIDTxtBox;
        private System.Windows.Forms.TextBox ActivityNameTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox VerifyCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Returnbtn;
        private System.Windows.Forms.Label Feedbacklbl;
    }
}
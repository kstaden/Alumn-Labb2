namespace PresentationLayer.WinForms
{
    partial class AlumnView
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
            this.Observerlbl = new System.Windows.Forms.Label();
            this.LoggedInAslbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogOutbtn = new System.Windows.Forms.Button();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ActivityDatagridview = new System.Windows.Forms.DataGridView();
            this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ChangeThemelbl = new System.Windows.Forms.Label();
            this.Themebox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityDatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Observerlbl
            // 
            this.Observerlbl.AutoSize = true;
            this.Observerlbl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Observerlbl.Location = new System.Drawing.Point(11, 27);
            this.Observerlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Observerlbl.Name = "Observerlbl";
            this.Observerlbl.Size = new System.Drawing.Size(131, 26);
            this.Observerlbl.TabIndex = 17;
            this.Observerlbl.Text = "Oberser Pattern.\r\nValt tema: AppWorkspace";
            // 
            // LoggedInAslbl
            // 
            this.LoggedInAslbl.AutoSize = true;
            this.LoggedInAslbl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LoggedInAslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggedInAslbl.Location = new System.Drawing.Point(185, 47);
            this.LoggedInAslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoggedInAslbl.Name = "LoggedInAslbl";
            this.LoggedInAslbl.Size = new System.Drawing.Size(78, 13);
            this.LoggedInAslbl.TabIndex = 16;
            this.LoggedInAslbl.Text = "InloggningsID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Välkommen Alumn";
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.Location = new System.Drawing.Point(268, 336);
            this.LogOutbtn.Margin = new System.Windows.Forms.Padding(2);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.Size = new System.Drawing.Size(70, 26);
            this.LogOutbtn.TabIndex = 24;
            this.LogOutbtn.Text = "logga ut";
            this.LogOutbtn.UseVisualStyleBackColor = true;
            this.LogOutbtn.Click += new System.EventHandler(this.LogOutbtn_Click);
            // 
            // Registerbtn
            // 
            this.Registerbtn.Location = new System.Drawing.Point(264, 143);
            this.Registerbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(70, 28);
            this.Registerbtn.TabIndex = 23;
            this.Registerbtn.Text = "Registrera";
            this.Registerbtn.UseVisualStyleBackColor = true;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(63, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 26);
            this.label6.TabIndex = 22;
            this.label6.Text = "Välj aktivitet, klicka sedan på knappen registrera.\r\nDetta för att bli registrera" +
    "d på aktiviteten.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Aktiviteter";
            // 
            // ActivityDatagridview
            // 
            this.ActivityDatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ActivityDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActivityDatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checkbox});
            this.ActivityDatagridview.Location = new System.Drawing.Point(66, 143);
            this.ActivityDatagridview.Name = "ActivityDatagridview";
            this.ActivityDatagridview.Size = new System.Drawing.Size(197, 219);
            this.ActivityDatagridview.TabIndex = 25;
            // 
            // Checkbox
            // 
            this.Checkbox.HeaderText = "Välj";
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Width = 30;
            // 
            // ChangeThemelbl
            // 
            this.ChangeThemelbl.AutoSize = true;
            this.ChangeThemelbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ChangeThemelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeThemelbl.Location = new System.Drawing.Point(12, 9);
            this.ChangeThemelbl.Name = "ChangeThemelbl";
            this.ChangeThemelbl.Size = new System.Drawing.Size(77, 16);
            this.ChangeThemelbl.TabIndex = 27;
            this.ChangeThemelbl.Text = "Ändra tema";
            // 
            // Themebox
            // 
            this.Themebox.FormattingEnabled = true;
            this.Themebox.Items.AddRange(new object[] {
            "Red",
            "Blue"});
            this.Themebox.Location = new System.Drawing.Point(95, 4);
            this.Themebox.Name = "Themebox";
            this.Themebox.Size = new System.Drawing.Size(121, 21);
            this.Themebox.TabIndex = 26;
            this.Themebox.Text = "Absolute Themes";
            this.Themebox.SelectedIndexChanged += new System.EventHandler(this.Themebox_SelectedIndexChanged_1);
            // 
            // AlumnView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 399);
            this.Controls.Add(this.ChangeThemelbl);
            this.Controls.Add(this.Themebox);
            this.Controls.Add(this.ActivityDatagridview);
            this.Controls.Add(this.LogOutbtn);
            this.Controls.Add(this.Registerbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Observerlbl);
            this.Controls.Add(this.LoggedInAslbl);
            this.Controls.Add(this.label1);
            this.Name = "AlumnView";
            this.Text = "AlumnView";
            ((System.ComponentModel.ISupportInitialize)(this.ActivityDatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Observerlbl;
        private System.Windows.Forms.Label LoggedInAslbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOutbtn;
        private System.Windows.Forms.Button Registerbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ActivityDatagridview;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
        private System.Windows.Forms.Label ChangeThemelbl;
        private System.Windows.Forms.ComboBox Themebox;
    }
}
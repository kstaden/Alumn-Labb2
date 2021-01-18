namespace PresentationLayer.WinForms
{
    partial class ViewForAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ActivityDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.RegisteredDataGridView = new System.Windows.Forms.DataGridView();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.CreateActivitybtn = new System.Windows.Forms.Button();
            this.DeleteActivitybtn = new System.Windows.Forms.Button();
            this.SearchForEventslbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisteredDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Välkommen till Alumns hemsida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Aktiviteter";
            // 
            // ActivityDataGridView
            // 
            this.ActivityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActivityDataGridView.Location = new System.Drawing.Point(37, 119);
            this.ActivityDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.ActivityDataGridView.Name = "ActivityDataGridView";
            this.ActivityDataGridView.RowTemplate.Height = 24;
            this.ActivityDataGridView.Size = new System.Drawing.Size(306, 122);
            this.ActivityDataGridView.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Registrerade alumner";
            // 
            // RegisteredDataGridView
            // 
            this.RegisteredDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegisteredDataGridView.Location = new System.Drawing.Point(359, 119);
            this.RegisteredDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.RegisteredDataGridView.Name = "RegisteredDataGridView";
            this.RegisteredDataGridView.RowTemplate.Height = 24;
            this.RegisteredDataGridView.Size = new System.Drawing.Size(301, 122);
            this.RegisteredDataGridView.TabIndex = 16;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(601, 96);
            this.Searchbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(43, 19);
            this.Searchbtn.TabIndex = 20;
            this.Searchbtn.Text = "Sök";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(585, 246);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 21;
            this.Exitbtn.Text = "Avsluta";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // CreateActivitybtn
            // 
            this.CreateActivitybtn.Location = new System.Drawing.Point(92, 93);
            this.CreateActivitybtn.Margin = new System.Windows.Forms.Padding(2);
            this.CreateActivitybtn.Name = "CreateActivitybtn";
            this.CreateActivitybtn.Size = new System.Drawing.Size(117, 24);
            this.CreateActivitybtn.TabIndex = 19;
            this.CreateActivitybtn.Text = "Skapa aktivitet";
            this.CreateActivitybtn.UseVisualStyleBackColor = true;
            this.CreateActivitybtn.Click += new System.EventHandler(this.CreateActivitybtn_Click);
            // 
            // DeleteActivitybtn
            // 
            this.DeleteActivitybtn.Location = new System.Drawing.Point(213, 93);
            this.DeleteActivitybtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteActivitybtn.Name = "DeleteActivitybtn";
            this.DeleteActivitybtn.Size = new System.Drawing.Size(117, 24);
            this.DeleteActivitybtn.TabIndex = 19;
            this.DeleteActivitybtn.Text = "Ta bort aktivitet";
            this.DeleteActivitybtn.UseVisualStyleBackColor = true;
            this.DeleteActivitybtn.Click += new System.EventHandler(this.DeleteActivitybtn_Click);
            // 
            // SearchForEventslbl
            // 
            this.SearchForEventslbl.AutoSize = true;
            this.SearchForEventslbl.Location = new System.Drawing.Point(500, 79);
            this.SearchForEventslbl.Name = "SearchForEventslbl";
            this.SearchForEventslbl.Size = new System.Drawing.Size(80, 13);
            this.SearchForEventslbl.TabIndex = 23;
            this.SearchForEventslbl.Text = "Sök på eventId";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(492, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // ViewForAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 297);
            this.Controls.Add(this.SearchForEventslbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.DeleteActivitybtn);
            this.Controls.Add(this.CreateActivitybtn);
            this.Controls.Add(this.RegisteredDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ActivityDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewForAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewForAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.ActivityDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisteredDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ActivityDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView RegisteredDataGridView;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button CreateActivitybtn;
        private System.Windows.Forms.Button DeleteActivitybtn;
        private System.Windows.Forms.Label SearchForEventslbl;
        private System.Windows.Forms.TextBox textBox1;
    }
}
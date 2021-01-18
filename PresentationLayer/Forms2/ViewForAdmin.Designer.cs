namespace Alumn20
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EventsDataGridView = new System.Windows.Forms.DataGridView();
            this.ActivityDataGridView = new System.Windows.Forms.DataGridView();
            this.RegisteredDataGridView = new System.Windows.Forms.DataGridView();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EventsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisteredDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(724, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Sök";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Registrerade alumner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Aktiviteter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Välkommen till Alumns hemsida";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EventsDataGridView
            // 
            this.EventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventsDataGridView.Location = new System.Drawing.Point(107, 320);
            this.EventsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EventsDataGridView.Name = "EventsDataGridView";
            this.EventsDataGridView.RowTemplate.Height = 24;
            this.EventsDataGridView.Size = new System.Drawing.Size(300, 150);
            this.EventsDataGridView.TabIndex = 10;
            this.EventsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // ActivityDataGridView
            // 
            this.ActivityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActivityDataGridView.Location = new System.Drawing.Point(107, 112);
            this.ActivityDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActivityDataGridView.Name = "ActivityDataGridView";
            this.ActivityDataGridView.RowTemplate.Height = 24;
            this.ActivityDataGridView.Size = new System.Drawing.Size(300, 150);
            this.ActivityDataGridView.TabIndex = 9;
            this.ActivityDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // RegisteredDataGridView
            // 
            this.RegisteredDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegisteredDataGridView.Location = new System.Drawing.Point(493, 112);
            this.RegisteredDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisteredDataGridView.Name = "RegisteredDataGridView";
            this.RegisteredDataGridView.RowTemplate.Height = 24;
            this.RegisteredDataGridView.Size = new System.Drawing.Size(287, 150);
            this.RegisteredDataGridView.TabIndex = 8;
            this.RegisteredDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegisteredDataGridView_CellContentClick);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(724, 466);
            this.Exitbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(100, 28);
            this.Exitbtn.TabIndex = 16;
            this.Exitbtn.Text = "Avsluta";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            
            // 
            // updateButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(167, 291);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(108, 23);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Ta Bort event";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // ViewForAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 546);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventsDataGridView);
            this.Controls.Add(this.ActivityDataGridView);
            this.Controls.Add(this.RegisteredDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewForAdmin";
            this.Text = "AdminView";
            ((System.ComponentModel.ISupportInitialize)(this.EventsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisteredDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView EventsDataGridView;
        private System.Windows.Forms.DataGridView ActivityDataGridView;
        private System.Windows.Forms.DataGridView RegisteredDataGridView;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button deleteButton;
    }
}
using BusinessLayer.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.WinForms
{
    public partial class AddActivity : Form
    {
        AdminController adminController = new AdminController();
        BindingSource bindingSource = new BindingSource();
        public string UserId { get; set; }
        List<string> form = new List<string>();
        public AddActivity(string userId)
        {
            InitializeComponent();
            UserId = userId;
        }

        private void VerifyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CreateActivitybtn.Enabled = true;
        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            ViewForAdmin viewForAdmin = new ViewForAdmin(UserId);
            viewForAdmin.Show();
            this.Hide();
        }

        private void CreateActivitybtn_Click(object sender, EventArgs e)
        {
            AddData();
        }
        public void AddData()
        {
            form.Add(ActivityNameTxtBox.Text);
            form.Add(ActivityCreatorTxtBox.Text);
            form.Add(StartDatetxtBox.Text);
            form.Add(EndDatetxtBox.Text);
            form.Add(EventIDTxtBox.Text);
            adminController.CreateActivity(form);
            Feedbacklbl.Text = "Aktiviteten har skapats!\nDu kan nu återvända.";
            Feedbacklbl.Visible = true;
        }
    }
}

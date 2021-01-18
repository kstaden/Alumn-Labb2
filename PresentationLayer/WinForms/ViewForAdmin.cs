using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Controller;
using BusinessLayer;

namespace PresentationLayer.WinForms
{
    public partial class ViewForAdmin : Form
    {
        AdminController adminController = new AdminController();
        BindingSource activitySource = new BindingSource();
        BindingSource connectedSource = new BindingSource();

        public string UserID { get; set; }
        public ViewForAdmin(string userId)
        {
            UserID = userId;
            InitializeComponent();
            ShowActivities();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void ShowActivities()
        {
            activitySource.DataSource = adminController.GetEvents();
            ActivityDataGridView.DataSource = activitySource.DataSource;
            ActivityDataGridView.Columns["EventSet_Information"].Visible = false;
            ActivityDataGridView.Columns["EventSet_Activity"].Visible = false;
            ActivityDataGridView.Columns["events"].Visible = false;
            ActivityDataGridView.Columns["UserSets"].Visible = false;
        }
        public void ShowConnectedAlumnis()
        {
            connectedSource.DataSource = adminController.GetConnectedAlumnis(textBox1.Text);
            RegisteredDataGridView.DataSource = connectedSource.DataSource;
            if (RegisteredDataGridView.DataSource != null)
            {
                RegisteredDataGridView.Columns["UserSet_Alumni"].Visible = false;
                RegisteredDataGridView.Columns["UserSet_Employee"].Visible = false;
                RegisteredDataGridView.Columns["EventSets"].Visible = false;
                RegisteredDataGridView.Columns["users"].Visible = false;
                RegisteredDataGridView.Columns["AdminRights"].Visible = false;
                RegisteredDataGridView.Columns["PhoneNumber"].Visible = false;
            }
            else MessageBox.Show("Ingen registrerad till aktivitet/vald akvititet existererar inte!");
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            ShowConnectedAlumnis();
        }

        private void CreateActivitybtn_Click(object sender, EventArgs e)
        {
            AddActivity addActivityForm = new AddActivity(UserID);
            this.Hide();
            addActivityForm.Show();
        }

        private void DeleteActivitybtn_Click(object sender, EventArgs e)
        {
            if (ActivityDataGridView.CurrentRow != null)
            {
                adminController.DeleteEvent(ActivityDataGridView.CurrentRow.Cells["EventId"].Value.ToString());
                ShowActivities();
            }
        }
    }
}

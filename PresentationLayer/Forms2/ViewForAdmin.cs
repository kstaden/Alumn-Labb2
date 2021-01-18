using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.Controllers;

namespace Alumn20
{
    public partial class ViewForAdmin : Form
    {
        private Session userSession;
        AdminController adminController = new AdminController();
        BindingSource eventSource = new BindingSource();
        BindingSource activitySource = new BindingSource();
        BindingSource connectedSource = new BindingSource();

        public string UserID { get; set; }
        public string InloggadSomlbl { get; set; }
        public string Username { get; internal set; }
        public string Password { get; internal set; }

        public ViewForAdmin()
        {
            InitializeComponent();
            ShowEvents();
        }

        public ViewForAdmin(Session userSession)
        {
            this.userSession = userSession;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public ViewForAdmin(string userid)
        {
            UserID = userid;
            InitializeComponent();
            InloggadSomlbl = "Inloggad som " + UserID.ToUpper();
            //ShowActivities();
            ShowEvents();


        }
        public void ShowEvents()
        {
            //eventSource.DataSource = adminController.GetEvents();
            EventsDataGridView.DataSource = eventSource.DataSource;
            EventsDataGridView.Columns["User"].Visible = false;

        }
        //public void ShowActivities()
        //{
        //    activitySource.DataSource = adminController.GetActivities();
        //    ActivityDataGridView.DataSource = activitySource.DataSource;
        //    ActivityDataGridView.Columns["User"].Visible = false;
        //}
        public void ShowConnectedAlumns()
        {
            //connectedSource.DataSource = AdminController.GetConnectedAlumns(textBox1.Text);
            RegisteredDataGridView.DataSource = connectedSource.DataSource;
            if (RegisteredDataGridView.DataSource != null)
            {
                RegisteredDataGridView.Columns["users"].Visible = false;
                RegisteredDataGridView.Columns["Password"].Visible = false;
                RegisteredDataGridView.Columns["AdminRights"].Visible = false;
                RegisteredDataGridView.Columns["Event"].Visible = false;
            }
            else MessageBox.Show("Ingen registrerad till aktivitet/vald akvititet existererar inte!");

        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            LogIN loginForm = new LogIN();
            this.Hide();
            loginForm.Show();
        }

        private void AddActivitybtn_Click(object sender, EventArgs e)
        {
            AddActivity addActivity = new AddActivity(UserID);
            this.Hide();
            addActivity.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (EventsDataGridView.CurrentRow != null)
            {
                //adminController.DeleteEvent(EventsDataGridView.CurrentRow.Cells["EventId"].Value.ToString());
                ShowEvents();
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            ShowConnectedAlumns();
        }

        private void EventsDatagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegisteredDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

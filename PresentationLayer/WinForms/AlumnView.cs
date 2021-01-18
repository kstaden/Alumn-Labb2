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
using PresentationLayer.Observer;
using BusinessLayer.Interface;

namespace PresentationLayer.WinForms
{
    public partial class AlumnView : Form
    {
        AlumniViewController alumniviewController = new AlumniViewController();
        Session userSession = new Session();
        BindingSource activitySource = new BindingSource();
        BindingSource test = new BindingSource();
        ISubject subject = new PresentationLayer.Observer.Subject();
        public string userID;
        public AlumnView(Session userSession, string userId)
        {
            InitializeComponent();
            this.userSession = userSession;           
            ShowActivities();
            userID = userId;
            LoggedInAslbl.Text = "Inloggad som: " + userID.ToUpper();

            PresentationLayer.Observer.Observer obi = new PresentationLayer.Observer.Observer(Observerlbl);
            subject.Register(obi);
        }
        public void ShowActivities()
        {
            activitySource.DataSource = alumniviewController.GetActivities();
            ActivityDatagridview.DataSource = activitySource.DataSource;
            ActivityDatagridview.Columns["EventSet_Information"].Visible = false;
            ActivityDatagridview.Columns["EventSet_Activity"].Visible = false;
            ActivityDatagridview.Columns["events"].Visible = false;
            ActivityDatagridview.Columns["UserSets"].Visible = false;
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ActivityDatagridview.Rows)
            {
                if (Convert.ToBoolean(row.Cells[Checkbox.Name].Value) == true)
                {
                    //if (Convert.ToBoolean(row.Cells[Checkbox.Name].Value.)
                    //{

                    //}
                    alumniviewController.FindEventId(ActivityDatagridview.CurrentRow.Cells["EventId"].FormattedValue.ToString(), userID);

                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    if (chk.Value == chk.FalseValue)
                    {
                        chk.Value = chk.TrueValue;
                    }
                    else chk.Value = chk.FalseValue;
                    MessageBox.Show(string.Format("{0} registrerad till aktivitet {1}", userID, ActivityDatagridview.CurrentRow.Cells["Name"].FormattedValue.ToString()));
                }
            }
        }

        private void Themebox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Themebox.SelectedIndex == 0)
            {
                subject.Changed(Observerlbl.Text = "Red");
                this.BackColor = Color.Red;

            }
            else if (Themebox.SelectedIndex == 1)
            {
                subject.Changed(Observerlbl.Text = "Blue");
                this.BackColor = Color.Blue;
            }
        }
    }
}

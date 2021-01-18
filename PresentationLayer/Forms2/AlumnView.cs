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

namespace Alumn20
{
    public partial class AlumnView : Form
    {

        AlumnController alumnController = new AlumnController();
        Session userSession = new Session();
        BindingSource activitySource = new BindingSource();
        BindingSource test = new BindingSource();
        ISubject subject = new Subject();
        public string Observerlbl { get; set; }
        public string LoggedInAslbl { get; set; }
        public string userID { get; private set; }
        public object Username { get; internal set; }
        public object Password { get; internal set; }

        public AlumnView(Session userSession, string id)
        {
            InitializeComponent();
            this.userSession = userSession;
            LoggedInAslbl = "Inloggad som: " + id.ToUpper();
            ShowActivities();
            userID = id;

            Observer obi = new Observer(Observerlbl);
            subject.Register(obi);
        }

        public AlumnView()
        {
        }

        public void ShowActivities()
        {
            activitySource.DataSource = alumnController.GetActivities();
            ActivityDatagridview.DataSource = activitySource.DataSource;
            ActivityDatagridview.Columns["User"].Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LogIN loginform = new LogIN();
            this.Dispose();
            loginform.Show();
        }
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void Themebox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (Themebox.SelectedIndex == 0)
        //    {
        //        subject.Changed(Observerlbl.Text = "Blue");
        //        this.BackColor = Color.Blue;

        //    }
        //    else if (Themebox.SelectedIndex == 1)
        //    {
        //        subject.Changed(Observerlbl.Text = "Light Pink");
        //        this.BackColor = Color.LightPink;
        //    }
        //}

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ActivityDatagridview.Rows)
            {
             
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    if (chk.Value == chk.FalseValue)
                    {
                        chk.Value = chk.TrueValue;
                    }
                    else chk.Value = chk.FalseValue;
                    MessageBox.Show(string.Format("{0} registrerad till aktivitet {1}", userID, ActivityDatagridview.CurrentRow.Cells["Name"].FormattedValue.ToString()));
                }
            }

        private void ActivityDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }










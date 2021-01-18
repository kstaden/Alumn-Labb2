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
    public partial class LogInForm : Form
    {
        BindingSource BindingSource = new BindingSource();
        LoginController LoginController = new LoginController();
        List<string> data = new List<string>();
        Session userSession = new Session();
        public LogInForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            NewRegistration newRegistration = new NewRegistration(firstNameBox.Text, lastName.Text);
            newRegistration.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            ValidateUserInput();
        }
        public void ValidateUserInput()
        {
            if (userIdBox.Text.Length < 1 && passwordBox.Text.Length < 1)
            {
                MessageBox.Show("Vänligen fyll i dina uppgifter");
            }
            else TryCreateSession();
        }
        public void TryCreateSession()
        {
            userSession = LoginController.CreateSession(userIdBox.Text, passwordBox.Text);
            if (userSession == null)
            {
                MessageBox.Show("Fel användarnamn eller lösenord!!");
            }
            else if (userSession.AdminSession == true)
            {
                ViewForAdmin adminView = new ViewForAdmin(userIdBox.Text);
                this.Hide();
                adminView.Show();
            }
            else if (userSession.AdminSession == false)
            {
                AlumnView alumni = new AlumnView(userSession, userIdBox.Text);
                this.Hide();
                alumni.Show();
            }
        }
    }
}

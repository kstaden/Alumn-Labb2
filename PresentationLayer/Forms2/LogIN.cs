using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Alumn20
{
    public partial class LogIN : Form
    {
        BindingSource BindingSource = new BindingSource();
        LogINController LogINController = new LogINController();
        List<string> data = new List<string>();
        Session userSession = new Session();

        public LogIN()
        {
            InitializeComponent();
        }

        private void LogIN_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (firstNameBox.Text.Length > 1 && lastNameBox.Text.Length > 1)
            {
                this.Hide();
                NewRegistration newregistration = new NewRegistration(firstNameBox.Text, lastNameBox.Text);
                newregistration.Show();
            }
            else
            {
                firstNameBox.Text = "Det är inte ditt namn!";
                lastNameBox.Text = "";
            }
        }
        public void TryCreateSession()
        {
            userSession = LogINController.CreateSession(userIdBox.Text, passwordBox.Text);
            if (userSession == null)
            {
                MessageBox.Show("Fel användarnamn eller lösenord!!");
            }
            else if (userSession.AdminSession == true)
            {
                ViewForAdmin viewforadmin = new ViewForAdmin(userIdBox.Text);
                this.Hide();
                viewforadmin.Show();
            }
            else if (userSession.AdminSession == false)
            {
                AlumnView alumn = new AlumnView(userSession, userIdBox.Text);
                this.Hide();
                alumn.Show();
            }
         
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            ValidateUserInput();
        }

        public void CheckUserStatus()
        {
            if (LogINController.session.AdminSession == true)
            {
                ViewForAdmin viewforadmin = new ViewForAdmin(userIdBox.Text);
                this.Hide();
                viewforadmin.Show();
            }
            else MessageBox.Show("Inte Admin");
        }
        public void ValidateUserInput()
        {
            if (userIdBox.Text.Length < 1 && passwordBox.Text.Length < 1)
            {
                MessageBox.Show("Vänligen fyll i dina uppgifter");
            }
            if (userIdBox.Text == "22")
            {
                ViewForAdmin va = new ViewForAdmin();

            }
            else if (passwordBox.Text == "admincode")
            {
                ViewForAdmin va = new ViewForAdmin();
                va.Show();
            }
            else
            {
                MessageBox.Show("Wrong code");
            }
        }
            
        
            //else TryCreateSession();
            //} 

        private void userIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInButtonClick_Click(object sender, EventArgs e)
        {
            ValidateUserInput();
           
        }
   

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            if (userIdBox.Text == "2")
            {
                ViewForAdmin va = new ViewForAdmin();
                
            }
            else if (passwordBox.Text == "admincode")
            {
                ViewForAdmin va = new ViewForAdmin();
                va.Show();
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                ValidateUserInput();
            }
        }

        private void firstNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }



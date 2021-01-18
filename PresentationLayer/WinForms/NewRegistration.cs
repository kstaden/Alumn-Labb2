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

namespace PresentationLayer.WinForms
{
    public partial class NewRegistration : Form
    {
        RegisterController registerController = new RegisterController();
        BindingSource programSource = new BindingSource();
        BindingSource classSource = new BindingSource();
        BindingSource occupationSource = new BindingSource();

        int formCount = 12;
        string[] name = new string[2];
        bool IsValidated = false;

        public NewRegistration(string förNamn, string efterNamn)
        {
            InitializeComponent();
            name[0] = förNamn;
            name[1] = efterNamn;
            UpdateProgramMenu();
            UpdateClassesMenu();
            UpdateOccupationsMenu();
        }
        public void UpdateProgramMenu()
        {
            programSource.DataSource = registerController.GetPrograms();
            programcomboBox.DataSource = programSource.DataSource;
            programcomboBox.DisplayMember = "Name";
            programcomboBox.ValueMember = "Name";
        }
        public void UpdateClassesMenu()
        {
            classSource.DataSource = registerController.GetClasses();
            classescomboBox1.DataSource = classSource.DataSource;
            classescomboBox1.DisplayMember = "ClassYearId";
            classescomboBox1.ValueMember = "ClassYearId";
        }

        public void UpdateOccupationsMenu()
        {
            occupationSource.DataSource = registerController.GetOccupations();
            occupationcomboBox1.DataSource = occupationSource.DataSource;
            occupationcomboBox1.DisplayMember = "Name";
            occupationcomboBox1.ValueMember = "Name";
        }

        private void AcceptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            registerButton.Enabled = true;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string[] form = ValidateForm();

            if (IsValidated)
            {
                registerController.CreateAlumni(form);
                errorLabel.ForeColor = Color.FromName("Green");
                errorLabel.Text = "Registreringen Lyckades";
            }
            else
            {
                errorLabel.ForeColor = Color.FromName("Red");
                errorLabel.Text = "Vänligen fyll i alla fält korrekt för att fortsätta!";
            }
            Feedbacklbl.Visible = true;
            Feedbacklbl.Text = "Kontot har skapats, du kan nu återvända till inloggninsskärm!";
        }
        public string[] ValidateForm()
        {
            IsValidated = true;

            string[] tempInfo = new string[formCount + 2];

            tempInfo[1] = name[0];
            tempInfo[2] = name[1];

            tempInfo[4] = programcomboBox.Text;
            tempInfo[5] = classescomboBox1.Text;
            tempInfo[8] = occupationcomboBox1.Text;
            int credits;

            if (!Int32.TryParse(creditsTextBox.Text, out credits))
            {
                creditsTextBox.ForeColor = Color.FromName("Red");
                creditsTextBox.Text = "Felaktigt format på högskolepoäng.";
                IsValidated = false;
            }
            else
            {
                tempInfo[6] = credits.ToString();
            }

            if (DegreeCombobx.Text == "Ja")
            {
                tempInfo[7] = "true";
            }
            else
            {
                tempInfo[7] = "false";
            }
            tempInfo[0] = new String(personalNrTextBox.Text.Where(x => Char.IsDigit(x)).ToArray());
            if (tempInfo[7].Length >= 10)
            {
                personalNrTextBox.ForeColor = Color.FromName("Red");
                personalNrTextBox.Text = "Felaktigt format på personnummer.";
                IsValidated = false;
            }
            tempInfo[3] = emailTextBox.Text;
            if (tempInfo[3].Length < 5 || !tempInfo[3].Contains("@"))
            {
                emailTextBox.ForeColor = Color.FromName("Red");
                emailTextBox.Text = "Felaktigt format på emailadress.";
                IsValidated = false;
            }
            tempInfo[9] = userTextBox.Text;
            if (!registerController.ValidUserId(tempInfo[9]))
            {
                userTextBox.ForeColor = Color.FromName("Red");
                userTextBox.Text = "Användar Id redan Upptaget.";
                IsValidated = false;
            }
            else if (tempInfo[9].Length > 12)
            {
                userTextBox.ForeColor = Color.FromName("Red");
                userTextBox.Text = "Användar Id får vara max 12 tecken.";
                IsValidated = false;
            }

            tempInfo[10] = passwordTextBox.Text;
            if (tempInfo[10].Length < 6 || tempInfo[10].Length > 12)
            {
                passwordTextBox.ForeColor = Color.FromName("Red");
                passwordTextBox.Text = "Lösenordet får vara mellan 6 och 12 tecken.";
                IsValidated = false;
            }

            return tempInfo;
        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }
    }
}

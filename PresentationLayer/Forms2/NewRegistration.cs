using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessEntities;
using BusinessLayer;
using System.Linq;

namespace Alumn20
{
    public partial class NewRegistration : Form
    {

        int formCount = 13;
        string[] name = new string[2];
        bool IsValidated = false;

        BindingSource programSource = new BindingSource();
        BindingSource classSource = new BindingSource();
        BindingSource occupationSource = new BindingSource();

        BusinessEntities.RegisterController registercontroller = new BusinessEntities.RegisterController();

        public NewRegistration(string firstName, string lastName)
        {
            InitializeComponent();

            name[0] = firstName;
            name[1] = lastName;

            welcomeLabel.Text = "Welcome " + firstName + " " + lastName + "!";
            UpdateProgramMenu();
            UpdateClassesMenu();
            UpdateOccupationsMenu();
        }

        public void UpdateProgramMenu()
        {
            programSource.DataSource = registercontroller.GetPrograms();
            programcomboBox.DataSource = programSource.DataSource;
            programcomboBox.DisplayMember = "Name";
            programcomboBox.ValueMember = "Name";
        }

        public void UpdateClassesMenu()
        {
            classSource.DataSource = registercontroller.GetClasses();
            classescomboBox1.DataSource = classSource.DataSource;
            classescomboBox1.DisplayMember = "ClassYearId";
            classescomboBox1.ValueMember = "ClassYearId";
        }

        public void UpdateOccupationsMenu()
        {
            occupationSource.DataSource = registercontroller.GetOccupations();
            occupationcomboBox1.DataSource = occupationSource.DataSource;
            occupationcomboBox1.DisplayMember = "Name";
            occupationcomboBox1.ValueMember = "Name";
        }

        private void acceptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            registerButton.Enabled = !registerButton.Enabled;
        }

        private void registerButton_Click1(object sender, EventArgs e)
        {
            string[] form = ValidateForm();

            if (IsValidated)
            {
                registercontroller.CreateAlumn(form);
                Errorlbl.Visible = true;
                Errorlbl.ForeColor = Color.Green;
                Errorlbl.Text = "Registreringen Lyckades";
            }
            else
            {
                Errorlbl.Visible = true;
                Errorlbl.ForeColor = Color.Red;
                Errorlbl.Text = "Vänligen fyll i alla fält korrekt för att fortsätta!";
            }
        }

        public string[] ValidateForm()
        {
            IsValidated = true;

            string[] tempInfo = new string[formCount + 2];

            tempInfo[0] = name[0];
            tempInfo[1] = name[1];

            tempInfo[2] = programcomboBox.Text;
            tempInfo[3] = classescomboBox1.Text;
            tempInfo[4] = occupationcomboBox1.Text;
            int credits;

            if (!Int32.TryParse(creditsTextBox.Text, out credits))
            {
                creditsTextBox.ForeColor = Color.FromName("Red");
                creditsTextBox.Text = "Felaktigt format på högskolepoäng.";
                IsValidated = false;
            }
            else
            {
                tempInfo[5] = credits.ToString();
            }

            if (degreeComboBox.Text == "Ja")
            {
                tempInfo[6] = "true";
            }
            else
            {
                tempInfo[6] = "false";
            }


            tempInfo[7] = new String(personalNrTextBox.Text.Where(x => Char.IsDigit(x)).ToArray());
            if (tempInfo[7].Length != 10)
            {
                personalNrTextBox.ForeColor = Color.FromName("Red");
                personalNrTextBox.Text = "Felaktigt format på personnummer.";
                IsValidated = false;
            }


            tempInfo[8] = emailTextBox.Text;
            if (tempInfo[9].Length < 5 || !tempInfo[9].Contains("@"))
            {
                emailTextBox.ForeColor = Color.FromName("Red");
                emailTextBox.Text = "Felaktigt format på emailadress.";
                IsValidated = false;
            }


            tempInfo[9] = userTextBox.Text;
            if (!registercontroller.ValidUserId(tempInfo[11]))
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

            tempInfo[11] = passwordTextBox.Text;
            if (tempInfo[10].Length < 6 || tempInfo[14].Length > 12)
            {
                passwordTextBox.ForeColor = Color.FromName("Red");
                passwordTextBox.Text = "Lösenordet får vara mellan 6 och 12 tecken.";
                IsValidated = false;
            }

            return tempInfo;
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            LogIN loginForm = new LogIN();
            loginForm.Show();
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void personalNrTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click_1(object sender, EventArgs e)
        {

        }

        private void acceptCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Errorlbl_Click(object sender, EventArgs e)
        {

        }
    }
}

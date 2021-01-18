using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Controllers;

namespace Alumn20
{
    public partial class AddActivity : Form
    {
        public AddActivity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddData();
            MessageBox.Show("Datan har lagts till, var vänlig och återvänd till menyn");
        }
        AdminController AdminController = new AdminController();
        BindingSource bindingSource = new BindingSource();
        public string UserId { get; set; }
        List<string> form = new List<string>();


        public AddActivity(string userid)
        {
            UserId = userid;
            InitializeComponent();
        }
        public void AddData()
        {
            form.Add(ActivityNameTxtBox.Text);
            form.Add(ActivityCreatorTxtBox.Text);
            form.Add(MaxParticipantstxtbox.Text);
            form.Add(StartDatetxtBox.Text);
            form.Add(EndDatetxtBox.Text);
            form.Add(EventIDTxtBox.Text);
            //AdminController.CreateActivity(form);
        }

        private void ActivityCreatortxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EventIDTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartDatetxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActivityNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EndDatetxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaxParticipantstxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}


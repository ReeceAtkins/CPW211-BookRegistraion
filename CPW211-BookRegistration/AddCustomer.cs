using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPW211_BookRegistration
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string title = txtTitle.Text;
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                DateTime dateOfBirth = dtpDateOfBirth.Value.Date;

                Customer cusToAdd = new Customer(title, firstName, lastName, dateOfBirth);

                int count = CustomerDB.Add(cusToAdd);

                if (count > 0)
                {
                    MessageBox.Show($"{cusToAdd.FullName} has been added succesfully!");
                    ResetForm();
                }
                else
                {
                    MessageBox.Show($"We are experiencing some database issues. Please try again later!");
                }
            }
        }

        private bool IsValid()
        {
            DateTime dateOfBirth = dtpDateOfBirth.Value;

            if (!Validator.IsPresent(txtTitle) ||
                !Validator.IsPresent(txtFirstName) ||
                !Validator.IsPresent(txtLastName))
            {
                lblErrorMsg.Text = "Please don't leave any blank!";
                return false;
            }
            else if (dateOfBirth >= DateTime.Today)
            {
                lblErrorMsg.Text = "Date of birth should not be today or after!";
                return false;
            }
            else
            {
                lblErrorMsg.Text = "";
                return true;
            }
        }

        private void ResetForm()
        {
            txtTitle.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            dtpDateOfBirth.Value = DateTime.Today;
            lblErrorMsg.Text = "";
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            lblErrorMsg.Text = "";
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            lblErrorMsg.Text = "";
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lblErrorMsg.Text = "";
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            lblErrorMsg.Text = "";
        }
    }
}

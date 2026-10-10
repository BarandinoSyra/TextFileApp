using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileApp
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string studentNo = txtStudentNo.Text;
            string fullName = $"{txtLastName.Text}, {txtFirstName.Text}, {txtMI.Text}.";
            string program = cmbProgram.Text;
            string gender = cmbGender.Text;
            string age = txtAge.Text;
            string birthday = dtpBirthday.Value.ToString("yyyy-MM-dd");
            string contactNo = txtContactNo.Text;

            string[] registrationDetails = {
                "Student No.:" + studentNo,
                "Full Name:" + fullName,
                "Program: " + program,
                "Gender: " + gender,
                "Age: " + age,
                "Birthday: " + birthday,
                "Contact No." + contactNo

            };
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = studentNo + ".txt";
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, fileName)))
            {

                foreach (string line in registrationDetails)
                {
                    outputFile.WriteLine(line);
                }
            }

            MessageBox.Show("Registration text file successfully generated!");

        }

    }
}


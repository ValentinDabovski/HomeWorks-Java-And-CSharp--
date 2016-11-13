namespace HospitamSystem.WFClient
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.Entity;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using HospitalSystem.Data;
    using HospitalSystem.Models;

    public partial class Form1 : Form
    {
        private HospitalContext context = new HospitalContext();

        private Patient patient;
        private Medicament medicament;
        private Diagnose diagnose;
        private Visitation visitation;

        public Form1()
        {
            InitializeComponent();

            var migrationStategy = new MigrateDatabaseToLatestVersion<HospitalContext, HospitalSystem.Data.Migrations.Configuration>();
            Database.SetInitializer(migrationStategy);

        }
        private void FirstNameButton_Click(object sender, EventArgs e)
        {
            var patientFirstName = this.FirtNameTextBox.Text;
            var patientLastName = this.LastNameTextBox.Text;
            var patientAddress = this.AddressTextBox.Text;
            var patientEmail = this.EmailTextBox.Text;
            DateTime patientDateOfBirth = Convert.ToDateTime(this.DateOfBirthTextBox.Text);
            // byte[] patientProfilePicture = File.ReadAllBytes(this.PictureBox.ToString()); // ??? picture
            bool patientMedicalInsurance = HasInsuranse(this.InsuranceTextBox);

            patient = new Patient()
            {
                FirstName = patientFirstName,
                LastName = patientLastName,
                Address = patientAddress,
                Email = patientEmail,
                DateOfBirth = patientDateOfBirth,
                // ProfilePicture = patientProfilePicture, // ??? picture
                HasmedicalInsurance = patientMedicalInsurance,

            };
            context.Patients.Add(patient);



            medicament = new Medicament()
            {
                Name = this.MedicamentsTextBox.Text,

            };
            context.Medicaments.Add(medicament);



            diagnose = new Diagnose()
            {
                Name = this.DiagnoseTextBox.Text,
                Comments = this.DiagnoseCommentsTextBox.Text
            };
            context.Diagnoses.Add(diagnose);



            visitation = new Visitation()
            {
                Date = Convert.ToDateTime(this.VisitationDateTextBox.Text),
                Comments = this.VisitationCommentsTextBox.Text
            };
            context.Visitations.Add(visitation);


            context.SaveChanges();
        }

        private bool HasInsuranse(ListBox listBox)
        {
            if (listBox.Text == "yes")
            {
                return true;
            }
            return false;
        }
    }
}

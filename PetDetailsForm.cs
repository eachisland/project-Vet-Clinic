using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectVetClinic
{
    public partial class PetDetailsForm : Form
    {
        private readonly Ianimal selectedPet;

        public PetDetailsForm(Ianimal pet)
        {
            InitializeComponent();
            selectedPet = pet;
        }

        private void PetDetailsForm_Load(object sender, EventArgs e)
        {
            FillPetInfo();
        }

        private void FillPetInfo()
        {
            labelPetsName.Text = selectedPet.Name;
            textBoxType.Text = selectedPet is Cat ? "Cat" : "Dog";
            dateTimePickerBirthday.Text = selectedPet.Birthday.ToShortDateString();
            textBoxBreed.Text = selectedPet.Breed;
            textBoxColor.Text = selectedPet.Color;
            textBoxWeight.Text = $"{selectedPet.Weight} kg";
            textBoxMedHistory.Text = selectedPet.MedicalHistory;
            textBoxStatus.Text = selectedPet.Status.ToString();

            if (selectedPet is Cat cat)
            {
                labelFavToy.Visible = true;
                textBoxFavToy.Visible = true;
                textBoxFavToy.Text = cat.FavoriteToy;
            }
            else
            {
                labelFavToy.Visible = false;
                textBoxFavToy.Visible = false;
            }

            if (selectedPet.Image != null)
            {
                pictureBoxImage.Image = Image.FromFile(selectedPet.Image);
            }

            buttonAdopt.Enabled = selectedPet.Status == Status.NotAdopted;
        }

        private void buttonAdopt_Click(object sender, EventArgs e)
        {
            selectedPet.Status = Status.Adopted;
            textBoxStatus.Text = selectedPet.Status.ToString();
            buttonAdopt.Enabled = false;
        }
    }
}

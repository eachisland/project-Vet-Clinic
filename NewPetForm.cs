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
    public partial class NewPetForm : Form
    {
        private string petImage;
        public Ianimal Animal { get; private set; }

        public NewPetForm()
        {
            InitializeComponent();
        }

        private void radioButtonDog_CheckedChanged(object sender, EventArgs e)
        {
            labelFavToy.Visible = textBoxFavToy.Visible = false;
        }

        private void radioButtonCat_CheckedChanged(object sender, EventArgs e)
        {
            labelFavToy.Visible = textBoxFavToy.Visible = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckIfInputsAreValid())
                return;

            Animal = CreateNewAnimal();
            if (Animal != null)
                DialogResult = DialogResult.OK;
        }

        private bool CheckIfInputsAreValid()
        {
            return CheckIfValid(textBoxName, 3, labelInfoName)
                && CheckIfValid(textBoxBreed, 5, labelInfoBreed)
                && CheckIfValid(textBoxColor, 3, labelInfoColor)
                && CheckIfValid(textBoxMedHistory, 10, labelInfoMedHistory)
                && CheckIfValidDouble(textBoxWeight, labelInfoWeight, 0.5)
                && CheckIfNotEmpty(petImage, labelInfoImage);
        }

        private static bool CheckIfValid(TextBox textBox, int minLength, Label errorLabel)
        {
            bool isValid = textBox.Text.Length >= minLength;
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private static void ShowValidationError(Label label, bool isValid)
        {
            label.Visible = !isValid;
        }

        private static bool CheckIfValidDouble(TextBox textBox, Label errorLabel, double min)
        {
            if (double.TryParse(textBox.Text, out double value) && value >= min)
            {
                ShowValidationError(errorLabel, true);
                return true;
            }

            ShowValidationError(errorLabel, false);
            return false;
        }

        private static bool CheckIfNotEmpty(string value, Label errorLabel)
        {
            bool isValid = !string.IsNullOrWhiteSpace(value);
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private Ianimal CreateNewAnimal()
        {
            string name = textBoxName.Text;
            DateTime birthday = dateTimePickerBirthday.Value;
            string breed = textBoxBreed.Text;
            string medicalHistory = textBoxMedHistory.Text;
            double weight = double.Parse(textBoxWeight.Text);
            string color = textBoxColor.Text;

            if (radioButtonCat.Checked)
            {
                return CreateCat(name, birthday, breed, medicalHistory, weight, color);
            }

            return new Dog(name, birthday, breed, medicalHistory, weight, color, petImage);
        }

        private Cat CreateCat(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color)
        {
            string favoriteToy = textBoxFavToy.Text;
            if (favoriteToy.Length < 3)
                return null;

            return new Cat(name, birthday, breed, medicalHistory, weight, color, favoriteToy, petImage);
        }

        private void textBoxImage_MouseDown(object sender, MouseEventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                petImage = openFileDialog.FileName;
                textBoxImage.Text = Path.GetFileName(petImage);
            }
        }
    }
}

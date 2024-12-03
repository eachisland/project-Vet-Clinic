using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vet_Clinic
{
    public partial class NewPet : Form
    {
        private string petImage;
        public NewPet()
        {
            InitializeComponent();
        }

        public Animal Animal { get; set; }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.label8.Visible = false;
            this.textBox7.Visible = false;
            this.FavouriteToyValidation.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.label8.Visible = true;
            this.textBox7.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckIfInputsAreValid())
            {
                return;
            }
            Animal newAnimal = CreateNewAnimal();
            if (newAnimal != null)
            {
                this.Animal = newAnimal;
                DialogResult = DialogResult.OK;
            }
        }

        private bool CheckIfInputsAreValid()
        => CheckIfValid(this.textBox1, 3, this.NameValidation) &&
             CheckIfValid(this.textBox2, 5, this.BreedValidation) &&
             CheckIfValid(this.textBox3, 10, this.MedicalValidation) &&
             CheckIfValid(this.textBox5, 3, this.ColorValidation) &&
             CheckIfValidDouble(this.textBox4, this.WeightValidation, 0.5) &&
             CheckIfNotEmpty(this.petImage, this.ImageValidation);

        private static bool CheckIfValid(TextBox textbox, int minLenght, Label errorLabel)
        {
            bool isValid = textbox.Text.Trim().Length > minLenght;
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private static void ShowValidationError(Label label, bool isValid)
        {
            label.Visible = isValid;
        }

        private static bool CheckIfValidDouble(TextBox textBox, Label errorLabel, double min)
        {
            bool isValid = double.TryParse(textBox.Text.Trim(), out double parsedValue)
                && parsedValue > min;
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private static bool CheckIfNotEmpty(string value, Label errorLabel)
        {
            bool isValid = !string.IsNullOrEmpty(value?.Trim());
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private Animal CreateNewAnimal()
        {
            string name = this.textBox1.Text.Trim();
            string breed = this.textBox2.Text.Trim();
            string medicalHistory = this.textBox3.Text.Trim();
            string color = this.textBox5.Text.Trim();
            DateTime birthday = DateTime.Parse(this.dateTimePicker1.Text.Trim());
            double weight = double.Parse(this.textBox4.Text.Trim());

            Animal Animal;
            if (this.radioButton2.Checked)
            {
                Animal = CreateCat(name, birthday, breed, medicalHistory, weight, color);
            }
            else
            {
                Animal = new Dog(name, birthday, breed, medicalHistory, weight, color);
            }
            Animal.Image = petImage;
            return Animal;
        }

        private Cat CreateCat(string name, DateTime birthday, string breed,
            string medicalHistory, double weight, string color)
        {
            string favToy = this.textBox7.Text.Trim();
            if (!CheckIfValid(this.textBox7, 3, this.FavouriteToyValidation))
            {
                return null;
            }
            return new Cat(name, birthday, breed, medicalHistory, weight, color, favToy);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg;" +
                " *.png; *.bmp ";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                petImage = openFileDialog.FileName;
                this.textBox6.Text = Path.GetFileName(petImage);
            }
        }
    }
}

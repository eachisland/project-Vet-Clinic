using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vet_Clinic
{
    public partial class PetDetails : Form
    {
        private readonly Animal pet;
        public PetDetails(Animal pet)
        {
            InitializeComponent();
            this.pet = pet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pet.Status = Status.Adopted;
            this.textBox6.Text = pet.Status.ToString();
            this.button1.Enabled = false;
        }
        private void FillPetInfo(object sender, EventArgs e)
        {
            this.label1.Text = pet.Name;
            this.textBox1.Text = pet.GetType().Name;
            this.dateTimePicker1.Text = pet.Birthday.ToString();
            this.textBox2.Text = pet.Breed;
            this.textBox5.Text = pet.Color;
            this.textBox4.Text = pet.Weight.ToString();
            this.textBox3.Text = pet.MedicalHistory;
            this.textBox6.Text = pet.Status.ToString();

            if (!string.IsNullOrEmpty(pet.Image) && File.Exists(pet.Image))
            {
                this.pictureBox1.Image = Image.FromFile(pet.Image);
            }

            if (pet is Cat cat)
            {
                this.textBox7.Text = cat.FavoriteToy;
            }
            else
            {
                this.textBox7.Visible = false;
                this.label8.Visible = false;
            }
        }
    }
}

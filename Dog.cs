using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVetClinic
{
    public class Dog : Ianimal
    {
        public string Name { get; }
        public DateTime Birthday { get; }
        public string Breed { get; }
        public string MedicalHistory { get; }
        public double Weight { get; }
        public string Color { get; }
        public string Image { get; set; }
        public Status Status { get; set; }

        public Dog(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color, string image = null)
        {
            Name = name;
            Birthday = birthday;
            Breed = breed;
            MedicalHistory = medicalHistory;
            Weight = weight;
            Color = color;
            Image = image;
            Status = Status.NotAdopted;
        }
    }

}

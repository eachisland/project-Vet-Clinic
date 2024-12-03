namespace Vet_Clinic
{
    public partial class IndexForm : Form
    {
        private readonly List<Animal> pets = new()
        {
            new Cat ("Fluffy", new DateTime(2018, 5, 15), "Persian", "Regular checkups", 4.5, "Golden", "Feather wand"),
            new Dog ("Buddy", new DateTime(2016, 8, 20), "Golden Retriever", "Vaccinated", 25.5, "Golden")
        };
        public IndexForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Animal selectedPet = pets[this.listView1.SelectedItems[0].Index];
            if (selectedPet != null)
            {
                using PetDetails detailsForm = new(selectedPet);
                detailsForm.ShowDialog();
            }
        }

        private void OLoad(object sender, EventArgs e)
        {
            LoadAllPets();
        }

        private void ListView1MouseClick(object sender, MouseEventArgs e)
        {
            Animal selectedPet = pets[this.listView1.SelectedItems[0].Index];
            if (selectedPet != null)
            {
                using PetDetails detailsForm = new(selectedPet);
                detailsForm.ShowDialog();
            }
        }

        private void LoadAllPets()
        {
            this.listView1.Clear();
            foreach (var pet in pets)
            {
                this.listView1.Items.Add(pet.Name, pet.GetType() == typeof(Cat) ? 0 : 1);
            }
        }

        private void AddPetButton_Click(object sender, EventArgs e)
        {
            using (NewPet newPetForm = new())
            {
                if (newPetForm.ShowDialog() == DialogResult.OK)
                {
                    this.pets.Add(newPetForm.Animal);
                }
            }
            LoadAllPets();
        }
    }

}

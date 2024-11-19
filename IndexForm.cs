namespace ProjectVetClinic
{
    public partial class IndexForm : Form
    {
        private readonly List<Ianimal> pets = new()
    {
        new Cat("Fluffy", new DateTime(2018, 5, 15), "Persian", "Regular checkups", 4.5, "Golden", "Feather wand"),
        new Dog("Buddy", new DateTime(2016, 8, 20), "Golden Retriever", "Vaccinated", 25.5, "Golden")
    };

        public IndexForm()
        {
            InitializeComponent();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            LoadAllPets();
        }

        private void LoadAllPets()
        {
            listViewPets.Items.Clear();
            foreach (var pet in pets)
            {
                listViewPets.Items.Add(pet.Name, pet is Cat ? 0 : 1);
            }
        }

        private void listViewPets_MouseClick(object sender, MouseEventArgs e)
        {
            if (listViewPets.SelectedItems.Count > 0)
            {
                Ianimal selectedPet = pets[listViewPets.SelectedItems[0].Index];
                using PetDetailsForm detailsForm = new(selectedPet);
                detailsForm.ShowDialog();
            }
        }

        private void buttonAddNewPet_Click(object sender, EventArgs e)
        {
            using (NewPetForm newPetForm = new())
            {
              if (newPetForm.ShowDialog() == DialogResult.OK)
              {
                pets.Add(newPetForm.Animal);
              }
            }
            LoadAllPets();
        }
    }

}
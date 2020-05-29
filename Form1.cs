using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTrein
{
    public partial class Form1 : Form
    {
        Train train = new Train();
        public List<Animal> Animals = new List<Animal>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddAnimalbtn_Click(object sender, EventArgs e)
        {
            if (!carnivoreRbtn.Checked && !herbivoreRbtn.Checked || !smallRbtn.Checked && !mediumRbtn.Checked && !bigRbtn.Checked)
            {
                MessageBox.Show("You need to select the values for your animal!");
            } else 
            {
                bool isCarnivore = carnivoreRbtn.Checked;
                Animal.Sizes Size;

                if (smallRbtn.Checked)
                {
                    Size = Animal.Sizes.small;
                } else if (mediumRbtn.Checked)
                {
                    Size = Animal.Sizes.medium;
                } else
                {
                    Size = Animal.Sizes.big;
                }

                Animal newAnimal = new Animal(Size, isCarnivore);

                Animals.Add(newAnimal);
                Animallist.Items.Add(newAnimal);
            }
        }

        private void Animallist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Animallist.SelectedItem != null)
            {
                Animallist.Items.Remove(Animallist.SelectedItem);
            }
        }

        private void Orginisebtn_Click(object sender, EventArgs e)
        {
            train.Wagons.Clear();

            train.FillWagon(Animals);

            Wagonlist.Items.Clear();
            foreach (Wagon selectedWagon in train.Wagons)
            {
                Wagonlist.Items.Add(selectedWagon);
            }
        }

        private void Wagonlist_MouseClick(object sender, MouseEventArgs e)
        {           
            int selectedWagon = Wagonlist.SelectedIndex;
            List<Animal> AnimalInWagon = train.Wagons[selectedWagon].Animals;
            string toDisplay = string.Join(Environment.NewLine, AnimalInWagon);
            MessageBox.Show(toDisplay);
        }
    }
}

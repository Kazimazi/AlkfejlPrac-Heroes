using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Heroes.Controller;
using Heroes.Model;

namespace Heroes
{
    public partial class AddHero : Form
    {
        private readonly HeroesController controller;
        private readonly int heroID;
        private readonly bool isModification = false;

        public AddHero(HeroesController controller)
        {
            InitializeComponent();
            powerComboBox.Items.AddRange(new string[] {
                "Maga altal keszitett",
                "Szerzett",
                "Veleszuletett"
            });
            powerComboBox.SelectedIndex = 0;
            this.controller = controller;
        }

        public AddHero(HeroesController controller, Hero hero) : this(controller)
        {
            isModification = true;
            heroID = hero.ID;

            nameTextBox.Text = hero.Name;
            heroNameTextBox.Text = hero.HeroName;
            ageNumbericUpDown.Value = hero.Age;
            powerComboBox.SelectedItem = powerComboBox.Items.IndexOf(hero.Power);
            addButton.Text = "Modify";
        }

        private void addHero_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string heroName = heroNameTextBox.Text;
            string power = powerComboBox.SelectedItem.ToString();
            int age = (int) (ageNumbericUpDown.Value);

            if (name == string.Empty || heroName == string.Empty)
            {
                MessageBox.Show("Kotelezo megadni a hos nevet", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
                return;
            }

            Hero hero = new Hero
            {
                Name = name,
                HeroName = heroName,
                Age = age,
                Power = power
            };

            bool result = false;
            if (isModification)
            {
                hero.ID = heroID;
                result = controller.ModifyHero(hero);
            } 
            else
            {
                result = controller.AddHero(hero);
            }

            if (!result)
            {
                MessageBox.Show("Problema merult fel a muvelet elvegzese kozben!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
            }
        }
    }
}

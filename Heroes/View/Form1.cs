using Heroes.Controller;
using Heroes.DAO;
using Heroes.Model;
using Heroes.ViewModel;

namespace Heroes
{
    public partial class Form1 : Form
    {
        private readonly HeroesController controller;

        public Form1()
        {
            InitializeComponent();
            this.toolStripMenuItem1.Click += AddHeroMenuItem_Click;
            this.toolStripMenuItem2.Click += ListMenuItem_Click;

            // controller = new HeroesController(new HeroesMemoryDao());
            controller = new HeroesController(new HeroesAdoDao());
        }

        private void AddHeroMenuItem_Click(object sender, System.EventArgs e)
        {
            using var addHeroForm = new AddHero(controller);
            addHeroForm.ShowDialog();
        }

        private void ListMenuItem_Click(object? sender, EventArgs e)
        {
            var heroes = controller.GetHeroes();

            heroesDataGridView.DataSource = null;
            heroesDataGridView.DataSource = heroes;
            heroesDataGridView.Visible = true;
        }

        private void itemClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(heroesDataGridView.CurrentRow.DataBoundItem is Hero hero)) return;
            using var addHeroForm = new AddHero(controller, hero);
            addHeroForm.ShowDialog();
        }
    }
}
using Heroes.DAO;
using Heroes.Model;

namespace Heroes.Controller
{
    public class HeroesController
    {
        private readonly IHeroesDao dao;
        public HeroesController(IHeroesDao heroesDao)
        {
            dao = heroesDao;
        }

        public bool AddHero(Hero hero)
        {
            // int id = dao.HeroesCount();
            // hero.ID = id;

            return dao.AddHero(hero);
        }

        public bool ModifyHero(Hero hero)
        {
            return dao.ModifyHero(hero);
        }

        public IEnumerable<Hero> GetHeroes()
        {
            return dao.GetHeroes();
        }

        public Hero GetHero(int heroId)
        {
            return dao.GetHero(heroId);
        }
    }
}

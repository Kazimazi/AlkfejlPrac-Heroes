using System.Data.SQLite;
using Heroes.Model;

namespace Heroes.DAO
{
    class HeroesAdoDao : IHeroesDao
    {
        private const string CONN_STRING = @"Data Source=../../../../DB/heroes.db;";

        public bool AddHero(Hero hero)
        {
            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "insert into Heroes " +
                "(Name, HeroName, Power, Age) values " +
                "(@name, @heroName, @power, @age);";
            command.Parameters.Add("name", System.Data.DbType.String).Value = hero.Name;
            command.Parameters.Add("heroName", System.Data.DbType.String).Value = hero.HeroName;
            command.Parameters.Add("power", System.Data.DbType.String).Value = hero.Power;
            command.Parameters.Add("age", System.Data.DbType.Int32).Value = hero.Age;

            bool result = true;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                result = false;
            }

            connection.Close();
            return result;
        }

        public Hero GetHero(int heroId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Hero> GetHeroes()
        {
            List<Hero> heroes = new List<Hero>();

            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "select * from Heroes";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                heroes.Add(new Hero
                {
                    ID = reader.GetInt32(reader.GetOrdinal("ID")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    HeroName = reader.GetString(reader.GetOrdinal("HeroName")),
                    Power = reader.GetString(reader.GetOrdinal("Power")),
                    Age = reader.GetInt32(reader.GetOrdinal("Age")),
                });
            }

            connection.Close();

            return heroes;
        }

        public int HeroesCount()
        {
            throw new NotImplementedException();
        }

        public bool ModifyHero(Hero hero)
        {
            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "update Heroes set " +
                "Name=@name, HeroName=@heroName, Power=@power, Age=@age " +
                "where ID=@id;";
            command.Parameters.Add("name", System.Data.DbType.String).Value = hero.Name;
            command.Parameters.Add("heroName", System.Data.DbType.String).Value = hero.HeroName;
            command.Parameters.Add("power", System.Data.DbType.String).Value = hero.Power;
            command.Parameters.Add("age", System.Data.DbType.Int32).Value = hero.Age;
            command.Parameters.Add("id", System.Data.DbType.Int32).Value = hero.ID;

            bool result = true;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                result = false;
            }

            connection.Close();
            return result;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Synevo_test_project.Entites;
using System.Collections.Generic;
using System.Linq;

namespace Synevo_test_project.Data.Repository
{
    public class PokemonOrderRepository : IPokemonOrderRepository
    {
        private readonly AppDBContent _appDBContent;

        public PokemonOrderRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        private DbSet<PokemonOrder> _pokemons => _appDBContent.Set<PokemonOrder>();

        public void Delete(PokemonOrder pokemonOrder)
        {
            _pokemons.Remove(pokemonOrder);
            _appDBContent.SaveChanges();
        }

        public IList<PokemonResult> GetAll()
        {
            var result = _pokemons.GroupBy(x => x.Email).Select(x =>
                new PokemonResult
                {
                    Email = x.Key,
                    Count = x.Count(),
                    LastTime = x.Select(x => x.CreatedTime).Max()
                }) ;

            return result.ToList();
        }

        public void Insert(PokemonOrder pokemonOrder)
        {
            _pokemons.Add(pokemonOrder);
            _appDBContent.SaveChanges();
        }

        public void Update(PokemonOrder pokemonOrder)
        {
            _pokemons.Update(pokemonOrder);
            _appDBContent.SaveChanges();
        }
    }
}
 
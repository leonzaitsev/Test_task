using Synevo_test_project.Entites;
using System.Collections.Generic;

namespace Synevo_test_project.Data
{
    public interface IPokemonOrderRepository
    {
        IList<PokemonResult> GetAll();
        void Delete(PokemonOrder pokemonOrder);
        void Insert(PokemonOrder pokemonOrder);
        void Update(PokemonOrder pokemonOrder);
    }
}
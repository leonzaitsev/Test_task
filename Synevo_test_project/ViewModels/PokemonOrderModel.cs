using System.ComponentModel.DataAnnotations;

namespace Synevo_test_project.ViewModels
{
    public class PokemonOrderModel
    {
         public int Id { get; set; }
        public string Email { get; set; }
         public string Name { get; set; }
         public string Phone { get; set; }
    }
}

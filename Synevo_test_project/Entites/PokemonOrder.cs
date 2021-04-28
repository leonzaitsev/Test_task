using System;


namespace Synevo_test_project.Entites
{
    public class PokemonOrder
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public DateTime CreatedTime {get; set;}
    }
}

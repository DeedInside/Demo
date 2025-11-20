using Modul_2.Models.Users;

namespace Modul_2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string ARC { get; set; }
        public DateOnly DataOrder { get; set; }
        public DateTime DataDelevery { get; set; }
        public PickPoint PickPoint { get; set; }
        public User User { get; set; }
        public int Key { get; set; }
        public StatusOrder Status { get; set; } 
    }
}

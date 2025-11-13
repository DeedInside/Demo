namespace Modul_2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login {  get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Login} : {Password}";
        }
    }
}

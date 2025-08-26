namespace PersonnageLoLApi.Models
{
    public class PersonnageLoL
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public int PV { get; set; }
        public int Attaque { get; set; }
    }
}
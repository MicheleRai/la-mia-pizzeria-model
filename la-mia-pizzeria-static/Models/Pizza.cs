namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public Pizza(string name, string description, string foto, double prezzo)
        {
            Name = name;
            Description = description;
            Foto = foto;
            Prezzo = prezzo;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Foto { get; set; }
        public double Prezzo { get; set; }
    }
}

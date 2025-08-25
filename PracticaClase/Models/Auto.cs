namespace PracticaClase.Models
{
    public class Auto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public string Color { get; set; }
        public Auto(string marca, string modelo, int anio, string color)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Color = color;
        }
        public override string ToString()
        {
            return $"{Anio} {Marca} {Modelo} - Color: {Color}";
        }
    }
}

namespace ProyectoFinal.Models
{
    public class Mago : ISuperheroe
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; }
        public string PoderEspecial { get; set; }
        public Mago(string nombre)
        {
            Nombre = nombre;
            Tipo = "Mago";
            Fuerza = 3;
            Salud = 5;
            PoderEspecial = "Lanza hechizos";
        }

        public string Atacar() => "Lanza un hechizo mágico";
        public string Defender() => "Se protege con un escudo mágico";
    }
}

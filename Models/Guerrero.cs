namespace ProyectoFinal.Models
{
    public class Guerrero  :ISuperheroe
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; }
        public string PoderEspecial { get; set; }

        public Guerrero(string nombre)
        {
            Nombre = nombre;
            Tipo = "Guerrero";
            Fuerza = 7;
            Salud = 5;
            PoderEspecial = "Golpe fuerte";
        }

        public string Atacar() => "Golpea con su espada";
        public string Defender() => "Se defiende con un escudo de hierro";
    }
}

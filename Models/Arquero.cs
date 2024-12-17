namespace ProyectoFinal.Models
{
    public class Arquero : ISuperheroe
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; }
        public string PoderEspecial { get; set; }

        public Arquero(string nombre)
        {
            Nombre = nombre;
            Tipo = "Arquero";
            Fuerza = 5;
            Salud = 5;
            PoderEspecial = "Dispara flechas con gran puntería";
        }

        public string Atacar() => "Dispara una flecha certera";
        public string Defender() => "Se defiende con su arco y escudo";
    }
}

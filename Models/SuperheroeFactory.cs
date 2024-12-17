namespace ProyectoFinal.Models
{
    public static class SuperheroeFactory
    {
        public static ISuperheroe CrearSuperheroe(string Nombre, string Tipo)
        {
            return Tipo.ToLower() switch
            {
                "mago" => new Mago(Nombre),
                "guerrero" => new Guerrero(Nombre),
                "arquero" => new Arquero(Nombre),
                _ => throw new ArgumentException("Tipo de héroe no reconocido")
            };
        }
    }
}

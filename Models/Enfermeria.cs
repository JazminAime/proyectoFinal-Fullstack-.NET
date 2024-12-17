namespace ProyectoFinal.Models
{
    public class Enfermeria
    {
        private static readonly Enfermeria _instancia = new Enfermeria();
        private int _visitasRestantes = 5;
        private Enfermeria() { }
        public static Enfermeria ObtenerInstancia() => _instancia;
        public bool VisitarEnfermeria(ref int saludActual, int cantidadVisitas)
        {
            if (_visitasRestantes <= 0)
            {
                return false;
            }
            for (int i = 0; i < cantidadVisitas; i++)
            {
                if (_visitasRestantes > 0 && saludActual < 5) 
                {
                    saludActual++;
                    _visitasRestantes--; 
                }
            }
            return true; 
        }
        public int GetVisitasRestantes() => _visitasRestantes;
    }
}

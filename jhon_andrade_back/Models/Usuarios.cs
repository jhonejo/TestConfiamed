namespace jhon_andrade_back.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public int ItemPendiente { get; set; }
        public int ItemCompletos { get; set; }
        public int ItemRelevante { get; set; }
    }
}

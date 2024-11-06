using System;

namespace jhon_andrade_back.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Relevancia { get; set; }
        public string Estado { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyectox.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]

        public string Nombre { get; set; }

        [Range(0, 9000)]
        public float costoEquipo { get; set; }

       // public Boolean  { get; set; }

        public string Pais { get; set; }

        public string Liga {  get; set; }


        public int Titulos { get; set; }

        


        public DateTime Fundacion { get; set; }


       // public Celular? Celular { get; set; }

       // [ForeignKey("Celular")]

        //public int IdCelular { get; set; }
    }
}

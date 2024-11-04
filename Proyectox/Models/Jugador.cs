using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyectox.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]


        public string Nombre { get; set; }
        [Range(0, 300)]
        public int Edad { get; set; }

        [Range(0, 2023)]
        public int Goles { get; set; }


        [Range(0, 2023)]
        
        public int Asistencias { get; set; }
        [MaxLength(21)]
        public string Posicion { get; set; }


        public Equipo? Equipo { get; set; }
        [ForeignKey("Equipo")]

        public int IdEquipo { get; set; }


    }
}

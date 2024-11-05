using System.ComponentModel.DataAnnotations;

namespace Proyectox.Models
{
    public class Liga
    {


        [Key]
            public int Id { get; set; }
        [MaxLength(21)]
            public string Nombre { get; set; }
        [MaxLength(21)]
            public string Pais { get; set; }
            
            // Relación uno a muchos: una liga tiene múltiples equipos
           // public ICollection<Equipo> Equipos { get; set; }
        

    }
}

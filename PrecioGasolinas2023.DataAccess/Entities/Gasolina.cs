using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrecioGasolinas2023.DataAccess.Entities
{
    [Table("Gasolina")]
    public partial class Gasolina
    {
        public Gasolina() { }

        [Key]
        [Column("GasolinaId")]
        public int GasolinaId { get; set; }

        [Column("GasolineraName")]
        public string GasolinaName { get; set; }

        [Column("GasolineraAddress")]
        public string GasolinaAddress { get; set; }

        [Column("Product")]
        public string Product { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Price")]
        public string Price { get;set; }
    }
}

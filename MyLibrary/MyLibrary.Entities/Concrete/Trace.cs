using MyLibrary.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Entities.Concrete
{
    [Table("Traces")]
    public class Trace: IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        // public int BookId { get; set; }
        [Required]
        public int ShelfNo { get; set; }
        [Required]
        public int RowNo { get; set; }
        [Required]
        public int ColumnNo { get; set; }
        
        public int BookId { get; set; }
        public virtual Book Book { get; set; }



    }
}

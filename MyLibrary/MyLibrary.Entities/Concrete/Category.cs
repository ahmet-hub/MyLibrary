using MyLibrary.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Entities.Concrete
{
    [Table("Categories")]
    public class Category: IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string Title  { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}

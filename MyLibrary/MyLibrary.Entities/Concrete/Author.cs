using MyLibrary.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Entities.Concrete
{
    [Table("Authors")]
    public class Author:IEntity
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,StringLength(75)]
        public string Name { get; set; }
        
        
        public virtual List<Book> Books { get; set; }

    }
}

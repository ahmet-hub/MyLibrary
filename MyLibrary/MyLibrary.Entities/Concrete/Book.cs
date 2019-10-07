using MyLibrary.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Entities.Concrete
{
    [Table ("Books")]
    public class Book: IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string Name { get; set; }
        // [Required]
        public DateTime PublishYear { get; set; }
       // [Required, StringLength(20)]
        public string Publisher { get; set; }
       // [Required]
        public int AuthorId { get; set; }
        //[Required]

        public int  CategoryId { get; set; }
        public virtual Author Author { get; set; }

        public virtual Category Category { get; set; }
       


    }
}

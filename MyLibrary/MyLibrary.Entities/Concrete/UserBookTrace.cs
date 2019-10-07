using MyLibrary.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Entities.Concrete
{
    [Table("UserBookTraces")]
    public class UserBookTrace: IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime TakenDate { get; set; }
        [Required]
        public DateTime ReturnDate { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int  BookId { get; set; }
        public virtual LibraryUser User { get; set; }
        public virtual Book Book { get; set; }

    }
}

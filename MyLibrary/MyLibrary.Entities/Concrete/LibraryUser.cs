using MyLibrary.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Entities.Concrete
{
    [Table("LibraryUsers")]
    public class LibraryUser: IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string Name { get; set; }
        [Required, StringLength(20)]
        public string LastName { get; set; }
        [Required, StringLength(30)]
        public string Email { get; set; }
        [Required, StringLength(30)]
        public string Phone  { get; set; }
        



    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ders23.Models
{
    public class Post
    {   [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(50)")]
        public string Title { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public string Content { get; set; }
        
        public DateTime CreatedAt { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string CreatedBy { get; set; }

    }
}

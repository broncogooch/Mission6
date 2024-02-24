using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public int? CategoryId {  get; set; }
        public Category? Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter a valid year")]
        [Range(1888, 2024)]
        public string Year { get; set; }
        public string ? Director { get; set; }
        public string ? Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Required]
        public bool CopiedToPlex {  get; set; }
        [MaxLength(25)]
        public string? Notes { get; set; }
        
    }
}

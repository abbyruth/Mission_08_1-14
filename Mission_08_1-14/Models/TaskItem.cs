using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission_08_1_14.Models {
    public class TaskItem {
        [Key]
        [Required]
        public int TaskId { get; set; }

        [Required(ErrorMessage="Please enter a description of your task")]
        public string? TaskDescription { get; set; }

        public string? DueDate { get; set; }

        [Required(ErrorMessage = "Please select a valid quadrant based on urgency and importance")]
        public int? Quadrant {  get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; } // Our foreign key CategoryId...
        public Category? Category { get; set; } // ...which links to a Category object

        public bool? Completed { get; set; }
    }
}

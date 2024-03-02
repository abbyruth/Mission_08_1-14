using System.ComponentModel.DataAnnotations;

namespace Mission_08_1_14.Models {
    public class Category {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}

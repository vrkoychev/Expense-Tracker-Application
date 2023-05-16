using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker_Application.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string Icon { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(10)")]
        public string Type { get; set; } = "Expense";
    }
}

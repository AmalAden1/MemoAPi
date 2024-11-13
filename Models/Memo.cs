using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace MemoAPi.Models
{
    public class Memo
    {

        [Key]
        public int Id { get; set; }
        [Required]

        public string Note { get; set; }
        [Required]
        
        public bool Important { get; set; }

        public DateTime Created { get; set; }

    }
}

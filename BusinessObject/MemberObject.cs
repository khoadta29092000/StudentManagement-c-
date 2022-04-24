using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject
{
    public class MemberObject
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountID { get; set; }
        [Required]
        [StringLength(40)]
        public bool? isTeacher { get; set; }
     
        public  string? AccountName { get; set; }
       
        public string? Email { get; set; }
 
        public string? Password { get; set; }
       
        public bool? Gender { get; set; }
      
        public decimal? Phone { get; set; }
       
    }
}

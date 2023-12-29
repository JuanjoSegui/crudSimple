using System.ComponentModel.DataAnnotations;

namespace crudSimple.Dtos
{
    public class CustomerDto
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$")]
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string Address { get; set; }

       
    }
}

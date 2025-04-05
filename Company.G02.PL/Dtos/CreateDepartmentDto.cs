using System.ComponentModel.DataAnnotations;

namespace Company.G02.PL.Dtos
{
    public class CreateDepartmentDto
    {
        [Required(ErrorMessage = "Code is Required !")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Name is Required !")]
        public string Name { get; set; }

        [Required(ErrorMessage = "CreatAt is Required !")]
        public DateTime CreatAt { get; set; }
    }
}

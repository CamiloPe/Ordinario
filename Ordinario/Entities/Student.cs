using System.ComponentModel.DataAnnotations;

namespace Ordinario.Entities
{
    public class Student
    {
        #region propiedades autoimplementadas
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [StringLength(250)]
        public string Photo { get; set; }
        public string PhoneNumber { get; set; }
        public string birthDate{ get; set; }
        public string CellphoneNumber { get; set; }
        public string Email { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        #endregion
    }
}

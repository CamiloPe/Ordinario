using System.ComponentModel.DataAnnotations;

namespace Ordinario.Entities
{
    public class Major
    {
        #region propiedades autoimplementadas
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string description{ get; set; }
        [StringLength(250)]
        public string Photo { get; set; }
        public string Email { get; set; }
        public string CellphoneNumber { get; set; }

        #endregion
    }
}

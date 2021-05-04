using System.ComponentModel.DataAnnotations;

namespace Ordinario.Entities
{
    public class Company
    {
        #region Propiedades
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(250)]
        public string Adress { get; set; }
        [Required]
        [StringLength(30)]
        public string postalCode { get; set; }
        [Required]
        [StringLength(30)]
        public string phoneNumber { get; set; }
        [StringLength(100)]
        public string webSite { get; set; }
        [Required]
        [StringLength(150)]
        public string Email { get; set; }
        [StringLength(250)]
        public string Photo { get; set; }

        #endregion
    }
}


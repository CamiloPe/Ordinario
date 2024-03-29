﻿using System.ComponentModel.DataAnnotations;

namespace Ordinario.Entities
{
    public class Adviser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [StringLength(20)]
        public string CellPhoneNumber { get; set; }
        [StringLength(250)]
        public string Photo { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
        [StringLength(30)]
        public string Department { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }

    }
}


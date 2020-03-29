using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quality.JWT.Models.Entities
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre Requerido")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Range(18,60,ErrorMessage = "No tiene permitido salir.. esta en cuarentena")]
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}

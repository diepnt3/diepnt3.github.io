using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B2Registation.Models
{
    public class Student
{
        [Required(ErrorMessage = "Please enter you Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter you EmailAddress")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please enter you Phone")]
        public int Phone { get; set; }
        public string hadDegree { get; set; }
    }
}

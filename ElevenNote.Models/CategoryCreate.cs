using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryCreate
    {
        [Required]
        [MinLength(3, ErrorMessage = "Please enter at least 3 characters.")]
        public string Name { get; set; }
    }
}

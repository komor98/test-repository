using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestGit1.Models.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public int User_Id { get; set; }

        public string Date { get; set; }
    }
}

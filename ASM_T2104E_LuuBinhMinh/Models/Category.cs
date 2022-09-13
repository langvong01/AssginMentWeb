using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASM_T2104E_LuuBinhMinh.Models
{
    public class Category
    {
        [Key]
        [Display(Name = "ID")]
        public int CategoryId { get; set; }
        [Required]
        [Display(Name = "tên Category ")]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
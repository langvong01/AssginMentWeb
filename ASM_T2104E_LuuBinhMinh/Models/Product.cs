using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASM_T2104E_LuuBinhMinh.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "ID")]
        public int ProductId { get; set; }

        [Required]
        [StringLength(32, MinimumLength = 3, ErrorMessage = "Tên phải lớn hơn 2 và nhỏ hơn 32 ")]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[0-9]{1,12}$", ErrorMessage = "Giá phải là số ")]
        [Range(1, 100, ErrorMessage = "Giá phải lớn hơn 1")]
        public double Price { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Số lượng phải lớn hơn 0 ")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Ngày lên kệ hàng ")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
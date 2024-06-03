using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DqdBaiDanhGiaGiuaKy.Models
{
    public class DqdProduct
    {
        [DisplayName(" DQD- Tieu De")]
        [Required(ErrorMessage = "DQD- Hay Nhap Tieu De")]
        public int Id { get; set; }

       

        [DisplayName(" DQD- Tên")]
        [Required(ErrorMessage = " DQD- Vui lòng nhập tên")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Tên phải dài từ 5 đến 100 ký tự")]
        [RegularExpression(@"^[A-ZÀÁÂẨÃÈÉÊẾËÌÍĨỊÒÓÔÕÖÙÚŨỤƯỲÝỶỸ\s]+$", ErrorMessage = "Tên chỉ chứa ký tự viết hoa và khoảng trắng")]
        public string Name { get; set; }

        

        [DisplayName(" DQD- Ảnh")]
        [Required(ErrorMessage = "DQD- Hãy Nhập ẢNh")]
        public string Image { get; set; }

        

        [DisplayName(" DQD- Số")]
        [Required(ErrorMessage = " DQD- Vui lòng nhập số")]
        [Range(1, 100, ErrorMessage = "Số phải nằm trong khoảng từ 1 đến 100")]
        public int Quantity { get; set; }

        

        [DisplayName(" DQD- Số")]
        [Required(ErrorMessage = "Vui lòng nhập số")]
        public int Price { get; set; }

        
        [DisplayName(" DQD- Hoat Dong")]
        [Required(ErrorMessage = " DQD- Vui lòng Nhap Hoat Dong")]
        public string isActive { get; set; }

    }
}

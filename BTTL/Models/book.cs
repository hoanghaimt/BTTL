namespace BTTL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("book")]
    public partial class book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

       [Required(ErrorMessage ="ID Không được để trống")]

        public int Id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Tên tác giả không quá 30 ký tự")]
        public string Author { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Tiêu Đề Không quá 100 ký tự")]
        public string Tittel { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Nội dung không được để trống ")]
        public string Description { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Hình ảnh không được để trống")]

        public string ImageCover { get; set; }

        [Required(ErrorMessage = "Giá Sách từ 1000 đến 1000000")]
        public int? Price { get; set; }
    }
}

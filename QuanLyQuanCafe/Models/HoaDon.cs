namespace QuanLyQuanCafe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            DoanhThus = new HashSet<DoanhThu>();
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        [StringLength(20)]
        public string MaHD { get; set; }

        [Required]
        [StringLength(20)]
        public string MaBan { get; set; }

        [Required]
        [StringLength(20)]
        public string MaNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayLap { get; set; }

        public DateTime GioVaoHD { get; set; }

        public DateTime GioRaHD { get; set; }

        public decimal TongTien { get; set; }

        [StringLength(50)]
        public string TrangThaiHD { get; set; }

        [Required]
        [StringLength(255)]
        public string GhiChuHD { get; set; }

        public virtual Ban Ban { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoanhThu> DoanhThus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}

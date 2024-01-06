using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DongTrungHieu261.Models;
[Table("SinhVien")]
public class SinhVien{
    [Key]
    [Display(Name = "Mã Sinh Viên")]
    public string? MaSinhVien { get; set; }
     [Display(Name = "Họ Tên")]
    public string? HoTen { get; set; }
     [Display(Name = "Mã Lớp")]
    public string? MaLop { get; set; }

    [ForeignKey("maLop")]
    public LopHoc? LopHoc { get; set; }

}
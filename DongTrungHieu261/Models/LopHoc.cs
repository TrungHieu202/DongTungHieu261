using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DongTrungHieu261.Models;
[Table("LopHoc")]
public class LopHoc{
    [Key]
    [Display(Name = "Mã Lớp")]
    public string? MaLop { get; set; }
     [Display(Name = "Tên Lớp")]
    public string? TenLop { get; set; }
     [Display(Name = "Số Sinh Viên")]
    public string? SoSinhVien { get; set; }
}
using System.ComponentModel.DataAnnotations;
namespace CanVanTu_0958_2425_BaiThi;
{
    public class Student
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
}
}
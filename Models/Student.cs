using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NguyenHongQuan489.Models;
[Table("Students")]
public class Student
{
    [Key]
    public string MaHS {get; set;}
    [ForeignKey("MaHS")]
    public string TenHS {get; set;}
    public string Address {get; set;}
}
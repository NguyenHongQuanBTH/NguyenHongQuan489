using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NguyenHongQuan489.Models;
[Table("Personss")]
public class Person
{
    [Key]
    public string MaNV {get; set;}
    public string TenNV {get; set;}
    public string Address {get; set;}
}
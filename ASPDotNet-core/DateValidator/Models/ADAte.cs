using System.ComponentModel.DataAnnotations;
namespace DateValidator.Models;


public class ADate
{
    [Required]
    public DateTime MyDate {get; set;}

}
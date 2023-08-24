using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GalloTube.Models;
public class AppUser : IdentityUser
{
    [Required]
    [StringLength(60)]
    public string Name { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }   

    [StringLength(200)]
    public string ProfilePicture { get; set; }
}
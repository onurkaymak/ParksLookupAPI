namespace ParksLookupAPI.Models;
using System.ComponentModel.DataAnnotations;

public class SignInDto
{
  [Required]
  public string Email { get; set; }
  [Required]
  public string Password { get; set; }
}
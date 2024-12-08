using System.ComponentModel.DataAnnotations;

namespace NexusDigital.Users.Dto;

public class ChangeUserLanguageDto
{
    [Required]
    public string LanguageName { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace azuretest.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
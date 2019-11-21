using System.ComponentModel.DataAnnotations;

namespace taskManager.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
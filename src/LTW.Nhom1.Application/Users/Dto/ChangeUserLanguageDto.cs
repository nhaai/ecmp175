using System.ComponentModel.DataAnnotations;

namespace LTW.Nhom1.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
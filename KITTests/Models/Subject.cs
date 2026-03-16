using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KITTests.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [Display(Name = "科目名")]
        [Column(TypeName = "ntext")]
        [Required(ErrorMessage = "科目名は必須です．")]
        public string? Name { get; set; }

        [Display(Name = "担当教員")]
        [Column(TypeName = "ntext")]
        public string? TeacherName { get; set; }

        [Display(Name = "年度")]
        [Required(ErrorMessage = "年度指定は必須です．")]
        public int AcademicYear { get; set; } = DateTime.Now.Year;

        [Display(Name = "春学期の場合はチェックがつきます．")]
        [Required(ErrorMessage = "学期を指定してください．")]
        public bool Semester { get; set; } = true;

        public ICollection<TestData> TestData { get; } = new HashSet<TestData>();
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KITTests.Models
{
    public class TestData
    {
        public int Id { get; set; }

        [Display(Name = "ファイルのパス")]
        [Column(TypeName = "ntext")]
        [DataType(DataType.ImageUrl)]
        public string? FilePath { get; set; }

        [Display(Name = "問題内容")]
        [Column(TypeName = "ntext")]
        [DataType(DataType.MultilineText)]
        public string? Content { get; set; }

        [Display(Name = "投稿日")]
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.Today;

        [Display(Name = "投稿者")]
        [Column(TypeName = "text")]
        [Required(ErrorMessage = "投稿者の名前は必ず入力してください．")]
        public string? Uploader { get; set; }

        public int SubjectId { get; set; }

        [Display(Name = "試験日")]
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        public DateTime ExamDate { get; set; } = DateTime.Today;

        public Subject Subject { get; set; } = null!;
    }
}

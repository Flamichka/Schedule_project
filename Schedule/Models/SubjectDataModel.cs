using System.ComponentModel.DataAnnotations;

namespace Schedule.Models
    //Модель таблицы Предмет
{
    public class SubjectDataModel
    {
        [Key] [Required] public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public int Type { get; set; }
        [Required] public bool Pz { get; set; } = false;
        [Required] public bool Lz { get; set; } = false;
        [Required] public bool L { get; set; } = false;
        [Required] public string Teacher1 { get; set; }
        [Required] public string Teacher2 { get; set; }
        [Required] public string Teacher3 { get; set; }
        [Required] public string Teacher4 { get; set; }
       
    }
}

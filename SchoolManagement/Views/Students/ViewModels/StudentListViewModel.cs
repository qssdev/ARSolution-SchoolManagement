using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Views.Students.ViewModels
{
    public class StudentListViewModel
    {
        [DisplayName("Student Name")]
        public string StudentName { get; set; }
        
        [DisplayName("Student Email")]
        public string StudentEmail { get; set; }

        [DisplayName("Professor Name")]
        public string ProfessorName { get; set; }
        
        [DisplayName("Professor Email")]
        public string ProfessorEmail { get; set; }
        
        [DisplayName("Class Name")]
        public string ClassName { get; set; }
    }
}

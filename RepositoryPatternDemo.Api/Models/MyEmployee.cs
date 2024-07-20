using System.ComponentModel.DataAnnotations;

namespace RepositoryPatternDemo.Api.Models
{
    public class MyEmployee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public Nullable<int> Salary { get; set; }
        public string Dept { get; set; }
    }
}

namespace RepositoryPatternDemo.Api.Models.Dtos
{
    public class AddEmployeeDto
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public Nullable<int> Salary { get; set; }
        public string Dept { get; set; }
    }
}

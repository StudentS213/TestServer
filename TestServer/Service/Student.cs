using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestShared;

namespace TestServer.Service
{
    [Table("students", Schema = "public")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public StudentDto ToDto()
        {
            return new StudentDto()
            {
                Id = Id,
                Name = Name,
                Surname = Surname,
                Age = Age
            };
        }
    }
}

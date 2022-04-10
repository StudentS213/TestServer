using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestShared;

namespace TestServer.Service
{
    [Table("marks", Schema = "public")]
    public class Mark
    {
        [Key]
        public int Id { get; set; }

        public int Value { get; set; }
        public DateTime DateTime { get; set; }

        public Student Student { get; set; }
        public Subject Subject { get; set; }

        public MarkDto ToDto()
        {
            return new MarkDto()
            {
                DateTime = DateTime,
                Value = Value,
                Student = Student.ToDto(),
                Subject = Subject.ToDto(),
                Id = Id
            };
        }
    }
}

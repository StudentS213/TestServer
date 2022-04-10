using System;

namespace TestShared
{
    public class MarkDto
    {
        public int Id { get; set; }
        public StudentDto Student { get; set; }
        public SubjectDto Subject { get; set; }

        public int Value { get; set; }
        public DateTime DateTime { get; set; }
    }
}

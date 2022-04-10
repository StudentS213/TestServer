using System.Collections.Generic;
using System.Linq;
using TestShared;

namespace TestServer.Service
{
    public class StudentsService
    {
        private readonly SchoolDataContext dataContext;

        public StudentsService(SchoolDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IEnumerable<StudentDto> GetStudents()
        {
            return dataContext.Students.Select(x => x.ToDto()).ToList();
        }

        public StudentDto GetStudentById(int id)
        {
            return dataContext.Students.FirstOrDefault(x => x.Id == id)?.ToDto();
        }
    }
}

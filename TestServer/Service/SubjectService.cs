using System;
using System.Collections.Generic;
using System.Linq;
using TestShared;

namespace TestServer.Service
{
    public class SubjectService
    {
        private readonly SchoolDataContext dataContext;

        public SubjectService(SchoolDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IEnumerable<SubjectDto> GetSubjects()
        {
            return dataContext.Subjects.ToList().Select(x => x.ToDto()).ToList();
        }

        public SubjectDto GetSubjectById(int id)
        {
            return dataContext.Subjects.FirstOrDefault(x => x.Id == id)?
                                       .ToDto();
        }
    }
}

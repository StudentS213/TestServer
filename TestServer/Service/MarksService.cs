using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TestShared;

namespace TestServer.Service
{
    public class MarksService
    {
        private readonly SchoolDataContext dataContext;

        public MarksService(SchoolDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IEnumerable<MarkDto> GetMarks()
        {
            return dataContext.Marks
                              .Include(x => x.Subject)
                              .Include(x => x.Student)
                              .Select(x => x.ToDto())
                              .ToList();
        }
    }
}

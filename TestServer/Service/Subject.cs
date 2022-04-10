using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestShared;

namespace TestServer.Service
{
    [Table("subject", Schema = "public")]
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


        public Subject()
        {

        }
        public Subject(SubjectDto dto)
        {
            CopyInfoSub(dto);
        }

        public void CopyInfoSub(SubjectDto dto)
        {
            Name = dto.Name;
            Id = dto.Uid;
        }

        public SubjectDto ToDto()
        {
            return new SubjectDto()
            {
                Uid = Id,
                Name = Name,
            };
        }
    }
}

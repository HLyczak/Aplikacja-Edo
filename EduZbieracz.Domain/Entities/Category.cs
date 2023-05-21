using EduZbieracz.Domain.Common;

namespace EduZbieracz.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public string DisplayName { get; set; }
        public ICollection<Post> Posts { get; set; }
    }

}
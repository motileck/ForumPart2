using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumPart2.Common.Abstractions;

namespace ForumPart2.DAL.Entites
{
    public class Post : IIdentityEntity<Guid>

    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}

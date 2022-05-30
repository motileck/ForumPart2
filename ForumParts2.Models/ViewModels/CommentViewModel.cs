using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumParts2.Models.ViewModels
{
    public class CommentViewModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Body { get; set; }
        public Guid PostId { get; set; }
    }
}

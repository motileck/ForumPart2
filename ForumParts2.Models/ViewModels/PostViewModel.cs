using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumParts2.Models.ViewModels
{
    public class PostViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
    }
}

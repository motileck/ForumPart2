using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumPart2.Common.Abstractions
{
    public interface IIdentityEntity<Tkey>
    {
        public Tkey Id { get; set; }

    }
}

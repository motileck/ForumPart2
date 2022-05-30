using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumPart2.Common.Abstractions.Services
{
    public interface IBaseGet<Tkey, TViewModel>
    {
        Task<TViewModel> GetByIdAsync(Tkey key);
        
    }
}

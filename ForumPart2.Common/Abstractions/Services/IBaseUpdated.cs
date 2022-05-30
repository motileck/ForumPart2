using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumPart2.Common.Abstractions.Services
{
    public interface IBaseUpdated<TUpdateModel, TViewModel>
    {
        Task<TViewModel> UpdateAsync(TUpdateModel model);
    }
}

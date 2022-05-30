using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumPart2.Common.Abstractions.Services
{
    public interface IBaseService<Tkey,TViewModel, TPostModel, TUpdateModel> : 
        IBaseGet<Tkey,TViewModel>, 
        IBaseCreate<TPostModel, TViewModel>, 
        IBaseDeleted<Tkey>,
        IBaseUpdated<TUpdateModel, TViewModel>
    {

    }
}

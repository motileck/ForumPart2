using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumPart2.Common.Abstractions.Services;
using ForumParts2.Models.CreateModels;
using ForumParts2.Models.UpdateModels;
using ForumParts2.Models.ViewModels;

namespace ForumPart2.Services.Abstractions
{
    public interface ICommentService : IBaseService<Guid, CommentViewModel, CommentCreateModel, CommentUpdateModel>
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ForumPart2.Common.Implementations.Services;
using ForumPart2.DAL;
using ForumPart2.DAL.Entites;
using ForumPart2.Services.Abstractions;
using ForumParts2.Models.CreateModels;
using ForumParts2.Models.UpdateModels;
using ForumParts2.Models.ViewModels;

namespace ForumPart2.Services.Implementations
{
    public class CommentService : BaseService<Comment, Guid, CommentViewModel, CommentCreateModel, CommentUpdateModel>, ICommentService
    {
        public CommentService(IContextFactory contextFactory, IMapper mapper) : base(contextFactory, mapper)
        {

        }
    }
}

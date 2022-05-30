using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ForumPart2.DAL.Entites;
using ForumParts2.Models.UpdateModels;
using ForumParts2.Models.ViewModels;

namespace ForumPart2.Services.ModelProfiles
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<Comment, CommentViewModel>();
            CreateMap<CommentViewModel, Comment>().ReverseMap();
            CreateMap<CommentUpdateModel, Comment>().ReverseMap();
        }
    }
}

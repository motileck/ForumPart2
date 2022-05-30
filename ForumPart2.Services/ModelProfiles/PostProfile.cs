using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ForumPart2.DAL.Entites;
using ForumParts2.Models.CreateModels;
using ForumParts2.Models.UpdateModels;
using ForumParts2.Models.ViewModels;

namespace ForumPart2.Services.ModelProfiles
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Post, PostViewModel>();
            CreateMap<PostCreateModel, Post>().ReverseMap();
            CreateMap<PostUpdateModel, Post>().ReverseMap();
        }
    }
}

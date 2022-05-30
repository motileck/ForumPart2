using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ForumPart2.Common.Abstractions.Services;
using ForumPart2.DAL;

namespace ForumPart2.Common.Implementations.Services
{
    public class BaseService<TEntity,Tkey, TViewModel, TPostModel, TUpdateModel> : 
        IBaseService<Tkey, TViewModel, TPostModel, TUpdateModel> where TEntity : class where TViewModel : class where TPostModel : class where TUpdateModel : class
    {
        private readonly IContextFactory _contextFactory;
        private readonly IMapper _mapper;

        public BaseService(IContextFactory contextFactory, IMapper mapper)
        {
            _contextFactory = contextFactory;
            _mapper = mapper;
        }

        public virtual async Task<TViewModel> GetByIdAsync(Tkey key)
        {
            await using var context = await _contextFactory.GetContextAsync();
            var dbSet = context.Set<TEntity>();
            var entity = await dbSet.FindAsync(key);
            return _mapper.Map<TViewModel>(entity);
        }

        public virtual async Task<TViewModel> CreateAsync(TPostModel PostModel)
        {
            await using var context = await _contextFactory.GetContextAsync();
            var dbSet = context.Set<TEntity>();
            var postEntity = _mapper.Map<TEntity>(PostModel);
            var entity = await dbSet.AddAsync(postEntity);
            await context.SaveChangesAsync();
            return _mapper.Map<TViewModel>(postEntity);
        }

        public virtual async Task DeleteByIdAsync(Tkey key)
        {
            await using var context = await _contextFactory.GetContextAsync();
            var dbSet = context.Set<TEntity>();
            var entity = await dbSet.FindAsync(key);
            dbSet.Remove(entity);
            await context.SaveChangesAsync();
            
        }

        public virtual async Task<TViewModel> UpdateAsync(TUpdateModel model)
        {
            await using var context = await _contextFactory.GetContextAsync();
            var dbSet = context.Set<TEntity>();
            var postEntity = _mapper.Map<TEntity>(model);
            var entity =  dbSet.Update(postEntity);
            await context.SaveChangesAsync();
            return _mapper.Map<TViewModel>(postEntity);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumPart2.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace ForumPart2.DAL
{
    public class ContextFactory : IContextFactory
    {
        private readonly IDbContextFactory<ApplicationDBContext> dbContextFactory;

        public ContextFactory(IDbContextFactory<ApplicationDBContext> dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }
        public async Task<ApplicationDBContext> GetContextAsync()
        {
            return await dbContextFactory.CreateDbContextAsync().ConfigureAwait(false);
        }
    }

    public interface IContextFactory
    {
        Task<ApplicationDBContext> GetContextAsync ();
    }
}

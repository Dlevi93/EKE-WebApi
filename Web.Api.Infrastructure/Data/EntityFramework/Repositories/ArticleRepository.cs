using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Interfaces.Gateways.Repositories;

namespace Web.Api.Infrastructure.Data.EntityFramework.Repositories
{
    internal sealed class ArticleRepository : IArticleRepository
    {
        private readonly IMapper _mapper;
        private ApplicationDbContext Context { get; }

        public ArticleRepository(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            Context = context;
        }

        public async Task<List<Article>> GetAll()
        {
            return await Context.Set<Article>().ToListAsync();
        }
    }
}

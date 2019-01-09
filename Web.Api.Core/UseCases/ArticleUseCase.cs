using System;
using System.Threading.Tasks;
using Web.Api.Core.Dto.UseCaseRequests;
using Web.Api.Core.Dto.UseCaseResponses;
using Web.Api.Core.Infrastructure;
using Web.Api.Core.Interfaces;
using Web.Api.Core.Interfaces.Gateways.Repositories;
using Web.Api.Core.Interfaces.UseCases;

namespace Web.Api.Core.UseCases
{
    public sealed class ArticleUseCase : IArticleUseCase
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleUseCase(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public async Task<bool> Handle(ArticleRequest message, IOutputPort<ArticleResponse> outputPort)
        {
            switch (message.RequestType)
            {
                case ArticleRequestType.GetAll:
                    var articleList = await _articleRepository.GetAll();
                    break;
                case ArticleRequestType.GetById:
                    break;
                default:
                    return false;
            }
            outputPort.Handle(new ArticleResponse());
            return true;
        }
    }
}

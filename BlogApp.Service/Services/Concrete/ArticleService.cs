using AutoMapper;
using BlogApp.Data.UnitOfWorks;
using BlogApp.Entity.DTOs.Articles;
using BlogApp.Entity.Entities;
using BlogApp.Service.Services.Abstractions;

namespace BlogApp.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ArticleService(IUnitOfWork unitOfWork,IMapper mapper )
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync()
        {
            
           var articles= await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.isDeleted,x => x.Category);
            var map = mapper.Map<List<ArticleDto>>(articles);
            return map;


        }
    }
}

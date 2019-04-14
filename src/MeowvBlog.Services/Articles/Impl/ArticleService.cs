﻿using MeowvBlog.Core.Domain.Repositories;

namespace MeowvBlog.Services.Articles.Impl
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
    }
}
﻿using Examine;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Infrastructure.Examine;

namespace Umbraco.Docs.Samples.Web.CustomIndexing
{
    public class ExamineComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.AddExamineLuceneIndex<ProductIndex, ConfigurationEnabledDirectoryFactory>("ProductIndex");

            builder.Services.AddSingleton<ProductIndexValueSetBuilder>();

            builder.Services.AddSingleton<IIndexPopulator, ProductIndexPopulator>();
        }
    }
}
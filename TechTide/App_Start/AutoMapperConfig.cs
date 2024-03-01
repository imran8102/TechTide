using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using CMSArticle.ModelsLayer;
using TechTide.Views.ViewModels;

namespace CMSArticle.App_Start
{
    public class AutoMapperConfig
    {
        public static IMapper mapper;

        public static void Configuration()
        {
            MapperConfiguration configuration = new MapperConfiguration(t =>
            {
                t.CreateMap<Category, CategoryViewModel>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
                t.CreateMap<CategoryViewModel, Category>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
            });
            mapper = configuration.CreateMapper();
        }
    }

}
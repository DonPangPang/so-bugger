using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace SoBugger.WebApi.Extensions
{
    public static class AutoMapperExtensions
    {
        private static IMapper Mapper = null!;

        public static void Configure(IApplicationBuilder app)
        {
            Mapper = app.ApplicationServices.GetRequiredService<IMapper>();
        }

        public static TDestination MapTo<TDestination>(this object source)
        {
            return Mapper.Map<TDestination>(source);
        }

        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
        {
            return Mapper.Map(source, destination);
        }

        public static void Map<T>(this object obj, T dest)
        {
            Mapper.Map(obj, dest);
        }

        public static IQueryable<TDestination> MapTo<TDestination>(this IQueryable source)
        {
            return Mapper.ProjectTo<TDestination>(source);
        }

        public static IQueryable<TOut> Map<TIn, TOut>(this IQueryable<TIn> source)
        {
            return Mapper.ProjectTo<TOut>(source);
        }
    }
}
using ParsiBin.Domain.Entities.Base;

namespace ParsiBin.Application.Common.Caching
{
    public static class CacheKeyServiceExtensions
    {
        public static string GetCacheKey<TEntity>(this ICacheKeyService cacheKeyService, object id, bool includeTenantId = true)
        where TEntity : IBaseEntity =>
            cacheKeyService.GetCacheKey(typeof(TEntity).Name, id, includeTenantId);
    }
}

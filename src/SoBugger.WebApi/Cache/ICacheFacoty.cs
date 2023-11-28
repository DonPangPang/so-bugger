namespace SoBugger.WebApi.Cache;

public interface ICacheFacoty
{
}

public class CacheFactory : ICacheFacoty
{

}

public interface ICacheService
{

}

public interface IMemoryCacheService : ICacheService
{

}

public interface IRedisCacheService : ICacheService
{

}

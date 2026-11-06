

//Creating Decorator class (adding caching functionality to the existing userRepository class)

public class cachedUserRepository : IuserRepository
{
    private readonly IuserRepository _userRepository;
    private readonly IMemoryCache _cache; //image this miscorosoft extention

    public cachedUserRepository(IuserRepository userRepository,IMemoryCache cache)
    {
        _userRepository = userRepository;
        _cache = cache;
    }

    public async Task<string> GetUserNameAsync(int Id)
    {
        string cacheKey=$"user_{Id}";
        // 1. chaeck if the data exists in cache
        if(_cache.TryGetValue(cacheKey,out string cacheName))
        {
            return $"{cacheName} from Cache";
        }

        // 2.Fallback to the original repository if not found in cache
        var userName= await _userRepository.GetUserNameAsync(Id);

        // 3. Store the result in cache for future requests
        _cache.Set(cacheKey,userName);
        return userName;
    }
}
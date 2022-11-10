using Stepan_Lesson_V1.api.data.dao.common.user;
using Stepan_Lesson_V1.api.service.common.common.validation.compositor;
using Stepan_Lesson_V1.api.service.common.main.user;

namespace Stepan_Lesson_V1.api.service.general;

public static class RomashkaDi
{
    private static readonly Dictionary<string, object> TypeNameToSingletonInstance = new()
    {
        { nameof(IUserService), _createUserService() }
    };
    
    private static readonly Dictionary<string, Func<object>> TypeNameToInstanceFunc = new()
    {
        { nameof(UserService), _createUserService }
    };

    private static UserService _createUserService()
    {
        return new UserService();
    }

    public static T  Get<T>() where T : class
    {
        string nameOfClass = typeof(T).Name;

        try
        {
            var singletonInstance = TypeNameToSingletonInstance[nameOfClass] as T;
            if (singletonInstance != null)
            {
                return singletonInstance;
            }
            
            throw new Exception("Type is registered with other singleton instance");
        }
        catch (Exception e)
        {
            var instanceFunc = TypeNameToInstanceFunc[nameOfClass];
            var instance = instanceFunc() as T;
            if (instance != null)
            {
                return instance;
            }

            throw new Exception("Type is registered with other instance");
        }
    }
}
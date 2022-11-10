using Stepan_Lesson_V1.api.data.dao.common.user;
using Stepan_Lesson_V1.api.data.dto.common.city;
using Stepan_Lesson_V1.api.data.dto.common.country;
using Stepan_Lesson_V1.api.data.dto.common.user;
using Stepan_Lesson_V1.api.service.common.common;
using Stepan_Lesson_V1.api.service.common.main.user;
using Stepan_Lesson_V1.api.service.general;

namespace Stepan_Lesson_V1.api.controller.common.user;

public class UserController
{
    private readonly IUserService _userService;
    
    
    internal UserController(IUserService userService)
    {
        _userService = userService;
    }
    
    public UserController()
    {
        _userService = RomashkaDi.Get<IUserService>();
    }

    public Response<User> Create(UserDto user)
    {
        return _userService.Create(user);
    }

    public Response<User> Update(UserDto user)
    {
        return _userService.Update(user);
    }

}
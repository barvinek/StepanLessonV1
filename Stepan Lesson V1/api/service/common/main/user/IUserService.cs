using Stepan_Lesson_V1.api.data.dao.common.user;
using Stepan_Lesson_V1.api.data.dto.common.user;
using Stepan_Lesson_V1.api.service.common.common;

namespace Stepan_Lesson_V1.api.service.common.main.user;

public interface IUserService
{
    Response<User> Create(UserDto user);
    Response<User> Update(UserDto user);
}
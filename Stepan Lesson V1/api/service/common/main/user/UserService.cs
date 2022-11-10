using Stepan_Lesson_V1.api.data.dao.common.city;
using Stepan_Lesson_V1.api.data.dao.common.country;
using Stepan_Lesson_V1.api.data.dao.common.user;
using Stepan_Lesson_V1.api.data.dto.common.user;
using Stepan_Lesson_V1.api.service.common.common;
using Stepan_Lesson_V1.api.service.common.common.validation.extensions;

namespace Stepan_Lesson_V1.api.service.common.main.user;

[GenerateFactory("CreateInstance")]
public class UserService : IUserService, IGenerateFactory
{
    public static object CreateInstance()
    {
        return new UserService();
    }

    public Response<User> Create(UserDto user)
    {
        var userName = user.Name;
        var isUserNameValid = userName.Maximum(30).Validate();
        var phoneNumber = user.PhoneNumber;
        var isPhoneNumberValid = phoneNumber.Numbers().Validate();
        if (!isUserNameValid || !isPhoneNumberValid)
        {
            return Response<User>.Error.ValidationError();
        }

        var country = new Country(user.City.Country.Name);
        var city = new City(user.City.Name, country);
        var newUser = new User(22, userName, user.PhoneNumber, city);

        var response = Response<User>.Success.Ok(newUser);
        return response;
    }

    public Response<User> Update(UserDto user)
    {
        var country = new Country(user.City.Country.Name);
        var city = new City(user.City.Name, country);
        var newUser = new User(33, user.Name, user.PhoneNumber, city);

        var response = Response<User>.Error.NotFound();
        return response;
    }
}
using Stepan_Lesson_V1.api.data.dto.common.city;

namespace Stepan_Lesson_V1.api.data.dto.common.user;

public record UserDto(string Name, string PhoneNumber, CityDto City);
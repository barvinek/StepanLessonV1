using Stepan_Lesson_V1.api.data.dao.common.city;

namespace Stepan_Lesson_V1.api.data.dao.common.user;

public record User(int Id, string Name, string PhoneNumber, City City);
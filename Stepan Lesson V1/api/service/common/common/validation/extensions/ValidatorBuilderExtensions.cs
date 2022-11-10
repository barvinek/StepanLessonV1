using Stepan_Lesson_V1.api.service.common.common.validation.compositor;
using Stepan_Lesson_V1.api.service.common.common.validation.main;

namespace Stepan_Lesson_V1.api.service.common.common.validation.extensions;

public static class ValidatorBuilderExtensions
{
    public static CompositeValidationsBuilder Maximum(this CompositeValidationsBuilder builder, int value)
    {
        return builder.Add(Validator.Length._maximum(value));
    }
    
    public static CompositeValidationsBuilder Numbers(this CompositeValidationsBuilder builder)
    {
        return builder.Add(Validator.Format._numbers());
    }
}
using Stepan_Lesson_V1.api.service.common.common.validation.compositor;
using Stepan_Lesson_V1.api.service.common.common.validation.main;

namespace Stepan_Lesson_V1.api.service.common.common.validation.extensions;

public static class ValidationExtensions
{
    private static CompositeValidationsBuilder Add(this string text, Validator validator)
    {
        return new CompositeValidationsBuilder(text).Add(validator);
    }
    
    public static CompositeValidationsBuilder Maximum(this string text, int value)
    {
        return text.Add(Validator.Length._maximum(value));
    }
    
    public static CompositeValidationsBuilder Numbers(this string text)
    {
        return text.Add(Validator.Format._numbers());
    }
}
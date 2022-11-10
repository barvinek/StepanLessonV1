using Stepan_Lesson_V1.api.service.common.common.validation.main;

namespace Stepan_Lesson_V1.api.service.common.common.validation.compositor;

public class ValidationCompositor
{
    private readonly List<Validator> _validators;

    public ValidationCompositor(List<Validator> validators)
    {
        _validators = validators;
    }

    public bool Validate(string text)
    {
        foreach (var validator in _validators)
        {
            var validationResult = validator.Validate(text);
            if (!validationResult) return false;
        }

        return true;
    }

    public bool Validate(params string[] texts)
    {
        foreach (var text in texts)
        {
            foreach (var validator in _validators)
            {
                var validationResult = validator.Validate(text);
                if (!validationResult) return false;
            }
        }

        return true;
    }
}
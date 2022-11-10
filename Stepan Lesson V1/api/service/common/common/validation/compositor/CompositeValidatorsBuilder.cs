using Stepan_Lesson_V1.api.service.common.common.validation.main;

namespace Stepan_Lesson_V1.api.service.common.common.validation.compositor;

public class CompositeValidationsBuilder
{
    private readonly List<Validator> _validators = new();
    private readonly string _text;

    public CompositeValidationsBuilder(string text)
    {
        _text = text;
    }
    
    public CompositeValidationsBuilder Add(Validator validator)
    {
        _validators.Add(validator);
        return this;
    }

    private ValidationCompositor Build()
    {
        return new ValidationCompositor(_validators);
    }
        
    public bool Validate()
    {
        return Build().Validate(_text);
    }

    public bool Validate(params string[] texts)
    {
        return Build().Validate(texts);
    }
}
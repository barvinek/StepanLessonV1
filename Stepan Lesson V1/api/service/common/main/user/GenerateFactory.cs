namespace Stepan_Lesson_V1.api.service.common.main.user;

public class GenerateFactory : Attribute
{
    public string InstanceCreatorFunc { get; }
    public GenerateFactory(string instanceCreatorFunc)
    {
        InstanceCreatorFunc = instanceCreatorFunc;
    }
}
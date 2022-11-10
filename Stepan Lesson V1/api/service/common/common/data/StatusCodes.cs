namespace Stepan_Lesson_V1.api.service.common.common;

public static class StatusCodes
{
    public static class Error
    {
        public const int NotFound = 404;
        public const int ValidationError = 1001;
    }

    public static class Success
    {
        public const int Ok = 200;
        public const int Exist = 205;
        
    }

}
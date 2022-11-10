namespace Stepan_Lesson_V1.api.service.common.common;

public abstract record Response<T>
{
    public int Status { get; }

    private Response(int status)
    {
        Status = status;
    }

    public record Success : Response<T>
    {
        public T Value { get; }

        private Success(int status, T value) : base(status)
        {
            Value = value;
        }

        public static Success Ok(T value)
        {
            return new Success(StatusCodes.Success.Ok, value);
        }

        public static Success Exist(T value)
        {
            return new Success(StatusCodes.Success.Exist, value);
        }
    }

    public record Error : Response<T>
    {
        private Error(int status) : base(status)
        {
        }

        public static Error NotFound()
        {
            return new Error(StatusCodes.Error.NotFound);
        }

        public static Error ValidationError()
        {
            return new Error(StatusCodes.Error.ValidationError);
        }
    }
}
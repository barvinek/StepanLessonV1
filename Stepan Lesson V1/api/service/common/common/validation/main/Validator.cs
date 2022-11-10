namespace Stepan_Lesson_V1.api.service.common.common.validation.main;

public abstract class Validator
{
    private Validator()
    {
    }

    public abstract bool Validate(string text);

    public abstract class Length : Validator
    {
        private Length()
        {
        }

        public static Maximum _maximum(int value)
        {
            return new Maximum(value);
        }

        public sealed class Maximum : Length
        {
            private readonly int _value;

            public Maximum(int value)
            {
                _value = value;
            }

            public override bool Validate(string text)
            {
                return text.Length <= _value;
            }
        }
    }

    public abstract class Format : Validator
    {
        private Format()
        {
        }

        public static Numbers _numbers()
        {
            return new Numbers();
        }

        public sealed class Numbers : Format
        {
            public static bool IsDigit(string number)
            {
                if (number[0] is '+')
                {
                    string onlyDigits = number.Remove(0);
                    foreach (var i in onlyDigits)
                    {
                        if (i is < '0' or > '9')
                            return false;
                    }
                }

                return true;
            }

            public static bool IsPhoneNumber(string number)
            {
                return number[0] == '+' && number[1] == '4' && number[2] == '8' && number.Length == 12 &&
                       IsDigit(number);
            }

            public override bool Validate(string text)
            {
                return IsPhoneNumber(text);
            }
        }
    }
}
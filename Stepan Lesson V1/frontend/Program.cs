// See https://aka.ms/new-console-template for more information

using Stepan_Lesson_V1.api.controller.common.user;
using Stepan_Lesson_V1.api.data.dao.common.user;
using Stepan_Lesson_V1.api.data.dto.common.city;
using Stepan_Lesson_V1.api.data.dto.common.country;
using Stepan_Lesson_V1.api.data.dto.common.user;
using Stepan_Lesson_V1.api.service.common.common;

var userController = new UserController();

var countryDto = new CountryDto("Polska");
var cityDto = new CityDto("Rzeszow", countryDto);
var userDto = new UserDto("Stepan", "+3802565983", cityDto);
var userDtoValidationError = new UserDto("StepanStepanStepanStepanStepanStepanStepanStepanStepanStepanStepanStepanStepanStepanStepan", "+3802565983", cityDto);
var userPhoneNumberValidation = new UserDto("Stepan", "+48884689379", cityDto);

var responseOk = userController.Create(userDto); 
var responseValidationError = userController.Create(userDtoValidationError); 
var responseNotFound = userController.Update(userDto);
var responseUserPhoneNumberValidation = userController.Create(userPhoneNumberValidation);

var responses = new List<Response<User>> { responseOk, responseValidationError, responseNotFound, responseUserPhoneNumberValidation};

foreach (var response in responses)
{
    switch (response)
    {
        case Response<User>.Success responseSuccess:
        {
            var userId = responseSuccess.Value.Id;
            Console.WriteLine("Success user created with ID: " + userId);
            break;
        }
        case Response<User>.Error responseError:
            Console.WriteLine("Error: " + responseError.Status);
            break;
    }
}
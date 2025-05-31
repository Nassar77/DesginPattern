using Chain_of_Responsibility;

var emailValidator = new EmailValidator();
var passwordValidator = new PasswordValidator();
var roleValidator = new RoleValidator();

// تكوين السلسلة
emailValidator.SetNext(passwordValidator);
passwordValidator.SetNext(roleValidator);

// اختبار الطلب
var request = new Request { Email = "test@example.com", Password = "123456", Role = "Admin" };
emailValidator.Handle(request);

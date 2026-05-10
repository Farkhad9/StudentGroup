using FluentValidation;
using StudentGroup.Dtos.StudentDtos;

namespace StudentGroup.Validations
{
    public class StudentUpdateDtoValidator : AbstractValidator<StudentCreateDto>
    {
    
        public StudentUpdateDtoValidator()
        {
            RuleFor(s => s.FullName)
                .NotEmpty().WithMessage("FullName boş ola bilməz.")
                .MinimumLength(3).WithMessage("FullName minimum 3 simvol olmalıdır.");

            RuleFor(s => s.Age)
                .InclusiveBetween(16, 60).WithMessage("Age 16 və 60 arasında olmalıdır.");

            RuleFor(s => s.Email)
                .NotEmpty().WithMessage("Email boş ola bilməz.")
                .EmailAddress().WithMessage("Email düzgün formatda olmalıdır.");

            RuleFor(s => s.GroupId)
                .GreaterThan(0).WithMessage("GroupId düzgün deyil.");
        }
    }
}

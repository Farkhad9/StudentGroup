using FluentValidation;
using StudentGroup.Dtos.GroupDtos;

namespace StudentGroup.Validators
{
    public class GroupUpdateDtoValidator : AbstractValidator<GroupUpdateDto>
    {
        public GroupUpdateDtoValidator()
        {
            RuleFor(g => g.Name)
                .NotEmpty().WithMessage("Name boş ola bilməz.")
                .MinimumLength(2).WithMessage("Name minimum 2 simvol olmalıdır.");
        }
    }
}
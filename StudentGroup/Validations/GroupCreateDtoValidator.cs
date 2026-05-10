using FluentValidation;
using StudentGroup.Dtos.GroupDtos;

namespace StudentGroup.Validations
{
    public class GroupCreateDtoValidator : AbstractValidator<GroupCreateDto>
    {
        public GroupCreateDtoValidator()
        {
            RuleFor(g => g.Name)
                .NotEmpty().WithMessage("Name boş ola bilməz.")
                .MinimumLength(2).WithMessage("Name minimum 2 simvol olmalıdır.");
        }
    }
}

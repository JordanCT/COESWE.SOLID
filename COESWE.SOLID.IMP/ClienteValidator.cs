using FluentValidation;

namespace COESWE.SOLID.IMP
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(x => x.ApellidoPaterno).NotEmpty()
                .WithMessage("El Apellido Paterno no puede estar vacío");
            RuleFor(x => x.ApellidoMaterno).NotEmpty()
                .WithMessage("El Apellido Materno no puede estar vacío");
            RuleFor(x => x.Nombres).NotEmpty()
                .WithMessage("El Nombre no puede estar vacío");
        }
    }
}

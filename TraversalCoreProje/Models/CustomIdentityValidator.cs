using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProje.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length) => new IdentityError 
        {
            Code = "PasswordTooShort", 
            Description = $"Parola en az {length} karakter olmalıdır" 
        };
        public override IdentityError PasswordRequiresUpper () => new IdentityError
        {
            Code = "PasswordRequiresUpper",
            Description = $"Parola en az 1 büyük karakter olmalıdır"
        };
        public override IdentityError PasswordRequiresLower() => new IdentityError
        {
            Code = "PasswordRequiresUpper",
            Description = $"Parola en az 1 küçük karakter olmalıdır"
        };
        public override IdentityError PasswordRequiresNonAlphanumeric() => new IdentityError
        {
            Code = "PasswordRequiresUpper",
            Description = $"Parola en az 1 sembol olmalıdır"
        };
    }
}

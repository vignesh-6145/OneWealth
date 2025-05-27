using System;

using FluentValidation;

using OneWealth.Business.DTO.Users;
using OneWealth.Repository.DataModels;

namespace OneWealth.Business.Validators;

public class UserRegistrationValidator : AbstractValidator<UserRegistrationDto>
{
    public UserRegistrationValidator()
    {
        RuleFor(obj => obj.UserName)
            .NotNull()
            .WithErrorCode(UserValidationErrors.UserNameInvalid)
            .WithMessage(UserValidationErrors.UserNameInvalidMessage)
            .NotEmpty()
            .WithErrorCode(UserValidationErrors.UserNameInvalid)
            .WithMessage(UserValidationErrors.UserNameInvalidMessage)
            .MinimumLength(3)
            .WithErrorCode(UserValidationErrors.UserNameMiLengthValidation)
            .WithMessage(UserValidationErrors.UserNameMiLengthValidationMessage)
            .MaximumLength(100)
            .WithErrorCode(UserValidationErrors.UserNameLengthExceeded)
            .WithMessage(UserValidationErrors.UserNameLengthExceededMessage)
            .Matches("^(?![._])[a-zA-Z0-9._]+(?<![._])$")
            .WithErrorCode(UserValidationErrors.UserNameInvalidStartEnd)
            .WithMessage(UserValidationErrors.UserNameInvalidStartEndMessage)
            .Matches("^(?!.*[._]{2})")
            .WithErrorCode(UserValidationErrors.UserNameInvalidConsequtiveSplCharacters)
            .WithMessage(UserValidationErrors.UserNameInvalidConsequtiveSplCharactersMessage);

        RuleFor(obj => obj.FirstName)
            .NotNull()
            .WithErrorCode(UserValidationErrors.NameInvalid)
            .WithMessage(UserValidationErrors.NameInvalidMessage)
            .MaximumLength(100)
            .WithErrorCode(UserValidationErrors.NameLengthExceeded)
            .WithMessage(UserValidationErrors.NameLengthExceededMessage)
            .Matches("^[a-zA-Z]+$")
            .WithErrorCode(UserValidationErrors.NameInvalidCharacters)
            .WithMessage(UserValidationErrors.NameInvalidCharactersMessage);

        RuleFor(obj => obj.LastName)
            .NotNull()
            .WithErrorCode(UserValidationErrors.NameInvalid)
            .WithMessage(UserValidationErrors.NameInvalidMessage)
            .MaximumLength(100)
            .WithErrorCode(UserValidationErrors.NameLengthExceeded)
            .WithMessage(UserValidationErrors.NameLengthExceededMessage)
            .Matches("^[a-zA-Z]+$")
            .WithErrorCode(UserValidationErrors.NameInvalidCharacters)
            .WithMessage(UserValidationErrors.NameInvalidCharactersMessage);

        RuleFor(obj => obj.MiddleName)
            .MaximumLength(100)
            .WithErrorCode(UserValidationErrors.NameLengthExceeded)
            .WithMessage(UserValidationErrors.NameLengthExceededMessage);

        RuleFor(obj => obj.Gender)
            .NotNull()
            .WithErrorCode(UserValidationErrors.InvalidGenderNull)
            .WithMessage(UserValidationErrors.InvalidGenderNullMessage)
            .IsInEnum()
            .WithErrorCode(UserValidationErrors.InvalidGender)
            .WithMessage(UserValidationErrors.InvalidGenderMessage);

        RuleFor(obj => obj.DateOfBirth)
            .NotNull()
            .WithErrorCode(UserValidationErrors.DateNotNull)
            .WithMessage(UserValidationErrors.DateNotNullMessage)
            .Must(IsNotAFutureDob)
            .WithErrorCode(UserValidationErrors.DOBFuture)
            .WithMessage(UserValidationErrors.DOBFutureMessage);

        RuleFor(obj => obj.Email)
            .NotNull()
            .WithErrorCode(UserValidationErrors.EmailNotNull)
            .WithMessage(UserValidationErrors.EmailNotNullMessage)
            .EmailAddress()
            .WithErrorCode(UserValidationErrors.InvalidEmail)
            .WithMessage(UserValidationErrors.InvalidEmailMessage);

        RuleFor(obj => obj.Mobile)
            .NotNull()
            .WithErrorCode(UserValidationErrors.MobileNotNull)
            .WithMessage(UserValidationErrors.MailNotNullMessage)
            .Matches("^[0-9]{10,15}$")
            .WithErrorCode(UserValidationErrors.InvalidPhone)
            .WithMessage(UserValidationErrors.InvalidPhoneMessage);

        RuleFor(obj => obj.address)
            .NotNull()
            .WithErrorCode(UserValidationErrors.AddressNotNull)
            .WithMessage(UserValidationErrors.AddressNotNullMessage)
            .SetValidator(new AddressValidator());

        RuleFor(obj => obj.Pan)
            .NotNull()
            .WithErrorCode(UserValidationErrors.PanNotNull)
            .WithMessage(UserValidationErrors.PanNotNullMessage)
            .NotEmpty()
            .WithErrorCode(UserValidationErrors.PanNotNull)
            .WithMessage(UserValidationErrors.PanNotNullMessage)
            .Matches("^[a-zA-Z0-9]+$")
            .WithErrorCode(UserValidationErrors.InvalidPanCharacters)
            .WithMessage(UserValidationErrors.InvalidPanCharactersMessage)
            .MaximumLength(10)
            .WithErrorCode(UserValidationErrors.InvalidPan)
            .WithMessage(UserValidationErrors.InvalidPanMessage);
        
        RuleFor(obj => obj.Aadhar)
            .NotNull()
            .WithErrorCode(UserValidationErrors.AadharNotNull)
            .WithMessage(UserValidationErrors.AadharNotNull)
            .NotEmpty()
            .WithErrorCode(UserValidationErrors.AadharNotNull)
            .WithMessage(UserValidationErrors.AadharNotNullMessage)
            .Matches("^[a-zA-Z0-9]+$")
            .WithErrorCode(UserValidationErrors.InvalidPanCharacters)
            .WithMessage(UserValidationErrors.InvalidPanCharactersMessage)
            .MaximumLength(15)
            .WithErrorCode(UserValidationErrors.InvalidAadhar)
            .WithMessage(UserValidationErrors.InvalidAadharMessage);

    }
    public static bool IsNotAFutureDob(DateOnly dob)
    {
        return dob < DateOnly.FromDateTime(DateTime.Now);
    }

}

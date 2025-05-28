using System;

using FluentValidation;

using OneWealth.Business.DTO.Users;

namespace OneWealth.Business.Validators;

public class AddressValidator:AbstractValidator<AddressDto?>
{
    public AddressValidator()
    {
        RuleFor(obj => obj.AddressLine1)
            .NotNull()
            .WithErrorCode(AddressValidationErrors.InvalidAddress)
            .WithMessage(AddressValidationErrors.InvalidAddressMessage)
            .NotEmpty()
            .WithErrorCode(AddressValidationErrors.InvalidAddress)
            .WithMessage(AddressValidationErrors.InvalidAddressMessage)
            .MaximumLength(255)
            .WithErrorCode(AddressValidationErrors.AddessMaximumLength)
            .WithMessage(AddressValidationErrors.AddessMaximumLengthMessage);

        RuleFor(obj => obj.AddressLine2)
            .MaximumLength(255)
            .WithErrorCode(AddressValidationErrors.AddessMaximumLength)
            .WithMessage(AddressValidationErrors.AddessMaximumLengthMessage);

        RuleFor(obj => obj.City)
            .NotNull()
            .WithErrorCode(AddressValidationErrors.InvalidCity)
            .WithMessage(AddressValidationErrors.InvalidCityMessage)
            .NotEmpty()
            .WithErrorCode(AddressValidationErrors.InvalidCity)
            .WithMessage(AddressValidationErrors.InvalidCityMessage)
            .MaximumLength(255)
            .WithErrorCode(AddressValidationErrors.CityMaximumLengthExceeded)
            .WithMessage(AddressValidationErrors.CityMaximumLengthExceededMessage);

        RuleFor(obj => obj.Country)
            .NotNull()
            .WithErrorCode(AddressValidationErrors.InvalidCountry)
            .WithMessage(AddressValidationErrors.InvalidCountryMessage)
            .NotEmpty()
            .WithErrorCode(AddressValidationErrors.InvalidCountry)
            .WithMessage(AddressValidationErrors.InvalidCountryMessage)
            .MaximumLength(255)
            .WithErrorCode(AddressValidationErrors.CountryMaximumLengthExceeded)
            .WithMessage(AddressValidationErrors.CountryMaximumLengthExceededMessage);
        
        RuleFor(obj => obj.Pincode)
            .NotNull()
            .WithErrorCode(AddressValidationErrors.InvalidPincode)
            .WithMessage(AddressValidationErrors.InvalidPincodeMessage)
            .NotEmpty()
            .WithErrorCode(AddressValidationErrors.InvalidPincode)
            .WithMessage(AddressValidationErrors.InvalidPincodeMessage)
            .MaximumLength(12)
            .WithErrorCode(AddressValidationErrors.PincodeMaximumLength)
            .WithMessage(AddressValidationErrors.PincodeMaximumLengthMessage);
    }
}

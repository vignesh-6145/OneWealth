using System;

using FluentValidation;

using OneWealth.Business.DTO.Users;

namespace OneWealth.Business.Validators;


public static class UserValidationErrors
{
    public readonly static string AddressNotNull = "USER_A01";
    public readonly static string AddressNotNullMessage = "Address is required";
    #region  User Name Validations
    public readonly static string UserNameInvalid = "USER_UN01";
    public readonly static string UserNameInvalidMessage = "UserName cannot be null or empty";
    public readonly static string UserNameLengthExceeded = "USER_UN02";
    public readonly static string UserNameLengthExceededMessage = "UserName cannot exceed 100 characters";
    public readonly static string UserNameMiLengthValidation = "USER_UN03";
    public readonly static string UserNameMiLengthValidationMessage = "UserName should be atleast of 3 characters";
    public readonly static string UserNameInvalidConsequtiveSplCharacters = "USER_UN04";
    public readonly static string UserNameInvalidConsequtiveSplCharactersMessage = "Username cannot contain consecutive dots or underscores.";
    public readonly static string UserNameInvalidStartEnd = "USER_UN05";
    public readonly static string UserNameInvalidStartEndMessage = "Username cannot start or end with a dot or underscore.";
    #endregion

    #region  Name Validations
    public readonly static string NameInvalid = "USER_N01";
    public readonly static string NameInvalidMessage = "FirstName/LastName cannot be null or empty";
    public readonly static string NameLengthExceeded = "USER_N02";
    public readonly static string NameLengthExceededMessage = "FirstName/LastName cannot exceed 100 characters";
    public readonly static string NameInvalidCharacters = "USER_N03";
    public readonly static string NameInvalidCharactersMessage = "FirstName/LastName cannot contain special characters";
    #endregion

    #region  DOB Validations
    public readonly static string DateNotNull = "USER_DOB01";
    public readonly static string DateNotNullMessage = "DateofBirth is required";
    public readonly static string DOBFuture = "USER_DOB02";
    public readonly static string DOBFutureMessage = "DateOfBirth Can't be a future date";

    #endregion
    #region  DOB Validations
    public readonly static string EmailNotNull = "USER_E01";
    public readonly static string EmailNotNullMessage = "Email is required";
    public readonly static string InvalidEmail = "USER_E02";
    public readonly static string InvalidEmailMessage = "Email Can't be a future date";
    #endregion
    #region  Mobile Validations
    public readonly static string MobileNotNull = "USER_PN01";
    public readonly static string MailNotNullMessage = "Mobile is required";
    public readonly static string InvalidPhone = "USER_E02";
    public readonly static string InvalidPhoneMessage = "Please enter a valid mobile number";
    #endregion

    #region  PI Validations
    public readonly static string PanNotNull = "USER_PI01";
    public readonly static string PanNotNullMessage = "PAN is required";
    public readonly static string AadharNotNull = "USER_PI02";
    public readonly static string AadharNotNullMessage = "Aadhar is required";
    public readonly static string InvalidPan = "USER_PI03";
    public readonly static string InvalidPanMessage = "PAN cannot exceed 10 characters";
    public readonly static string InvalidAadhar = "USER_PI04";
    public readonly static string InvalidAadharMessage = "Aadhar cannot exceed 12 characters";
    public readonly static string InvalidPanCharacters = "USER_PI06";
    public readonly static string InvalidPanCharactersMessage = "PAN/Aadhar cannot contain special characters";
    public readonly static string InvalidGender = "USER_PI07";
    public readonly static string InvalidGenderMessage = "Please enter a valid Gender";
    public readonly static string InvalidGenderNull = "USER_PI08";
    public readonly static string InvalidGenderNullMessage = "Gneder is required";
    #endregion
}

public static class AddressValidationErrors
{
    public readonly static string InvalidAddress = "ADDRESS_A01";
    public readonly static string InvalidAddressMessage = "Address line 1 cannot be null or empty";
    public readonly static string AddessMaximumLength = "ADDRESS_A02";
    public readonly static string AddessMaximumLengthMessage = "Address line  cannot be null or empty";
    public readonly static string InvalidCity = "ADDRESS_A03";
    public readonly static string InvalidCityMessage = "City  cannot be null or empty";
    public readonly static string InvalidCountry = "ADDRESS_A04";
    public readonly static string InvalidCountryMessage = "City  cannot be null or empty";

    public readonly static string CityMaximumLengthExceeded = "ADDRESS_A05";
    public readonly static string CityMaximumLengthExceededMessage = "City name should not exceed 50 characters";
    public readonly static string CountryMaximumLengthExceeded = "ADDRESS_A05";
    public readonly static string CountryMaximumLengthExceededMessage = "City name should not exceed 50 characters";

    public readonly static string InvalidPincode = "ADDRESS_A06";
    public readonly static string InvalidPincodeMessage = "Pincode cannot be null or empty";
    public readonly static string PincodeMaximumLength = "ADDRESS_A07";
    public readonly static string PincodeMaximumLengthMessage = "Pincode should not exceed 12 characters";
}
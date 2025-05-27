using System;
using System.Text.Json.Serialization;

using OneWealth.Business.Constants;
using OneWealth.Business.Enums;

namespace OneWealth.Business.DTO.Users;

public class UserRegistrationDto
{
    public string UserName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? MiddleName { get; set; }
    public DateOnly JoingingDate { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Mobile { get; set; } = string.Empty;
    public Gender Gender { get; set; } = Gender.DONTDISCLOSE;
    public string Password { get; set; } = string.Empty;

    public decimal? AnnualIncome { get; set; }
    public string? JobTitle { get; set; }
    public string? Employer { get; set; }
    public string? InvestmentGoal { get; set; }

    public string? Pan { get; set; }
    public string? Aadhar { get; set; } = ConstantVariables.MASKED_AADHAR;

    [JsonPropertyName("Address")]
    public AddressDto? address { get; set; }

}

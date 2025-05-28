using System;

using OneWealth.Business.Constants;

namespace OneWealth.Business.DTO.Users;

public class AddressDto
{
    public string AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string City { get; set; } = string.Empty;
    public string Country { get; set; } = ConstantVariables.DEFAULT_COUNTRY;
    public string Pincode { get; set; } = string.Empty;
}

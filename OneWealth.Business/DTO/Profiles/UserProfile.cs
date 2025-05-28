using System;
using System.Runtime.InteropServices;
using System.Text;

using AutoMapper;

using OneWealth.Business.DTO.Users;
using OneWealth.Repository.DataModels;

namespace OneWealth.Business.DTO.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        //UserRegistrationDTO to user
        CreateMap<UserRegistrationDto, User>()
            .ForMember(dest =>
                dest.Jod,
                opt => opt.MapFrom(src => src.JoingingDate))
            .ForMember(dest =>
                dest.Dob,
                opt => opt.MapFrom(src => src.DateOfBirth))
            .ForMember(dest =>
                dest.Gender,
                opt => opt.MapFrom(src => src.Gender.ToString()[0]));

        //UserRegistrationDTO to userFinancialProfile
        CreateMap<UserRegistrationDto, UserInformation>()
            .ForMember( dest => dest.Aadhar,
                opt => opt.MapFrom( src => ParseAadharNumber(src.Aadhar)))
            .ForMember(dest => dest.AddressLine1,
                opt => opt.MapFrom(src => src.address.AddressLine1))
            .ForMember(dest => dest.AddressLine2,
                opt => opt.MapFrom(src => src.address.AddressLine2))
            .ForMember(dest => dest.City,
                opt => opt.MapFrom(src => src.address.City))
            .ForMember(dest => dest.Country,
                opt => opt.MapFrom(src => src.address.Country))
            .ForMember(dest => dest.Pincode,
                opt => opt.MapFrom(src => src.address.Pincode));

        //UserRegistrationDTO to userInformation
        CreateMap<UserRegistrationDto, UserFinancialProfile>()
        .ForMember(dest => dest.Title,
            opt => opt.MapFrom(src => src.JobTitle));
    }

    public static string ParseAadharNumber(string? aadhar)
    {
        if (string.IsNullOrEmpty(aadhar))
            return "";

        var parsedAadhar = new StringBuilder();

        if (aadhar.Contains('-', StringComparison.InvariantCultureIgnoreCase))
        {
            parsedAadhar.AppendJoin("", aadhar.Split("-"));

        }
        else
        {
            parsedAadhar.Append(aadhar);
        }

        return parsedAadhar.ToString();
    }

}

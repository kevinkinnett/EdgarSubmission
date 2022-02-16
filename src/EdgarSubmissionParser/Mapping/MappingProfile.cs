using AutoMapper;
using EdgarSubmissionParser.Model;

namespace EdgarSubmissionParser.Mapping;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<edgarSubmissionFormDataInvstOrSec, Output>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.name))
            .ForMember(dest => dest.Lei, opt => opt.MapFrom(src => src.lei))
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.title))
            .ForMember(dest => dest.Cusip, opt => opt.MapFrom(src => src.cusip))
            .ForMember(dest => dest.Balance, opt => opt.MapFrom(src => src.balance))
            .ForMember(dest => dest.Units, opt => opt.MapFrom(src => src.units))
            .ForMember(dest => dest.CurCd, opt => opt.MapFrom(src => src.curCd))
            .ForMember(dest => dest.ValUsd, opt => opt.MapFrom(src => src.valUSD))
            .ForMember(dest => dest.PctVal, opt => opt.MapFrom(src => src.pctVal))
            .ForMember(dest => dest.PayoffProfile, opt => opt.MapFrom(src => src.payoffProfile))
            .ForMember(dest => dest.AssetCat, opt => opt.MapFrom(src => src.assetCat))
            .ForMember(dest => dest.InvCountry, opt => opt.MapFrom(src => src.invCountry))
            .ForMember(dest => dest.IsRestrictedSec, opt => opt.MapFrom(src => src.isRestrictedSec))
            .ForMember(dest => dest.FairValLevel, opt => opt.MapFrom(src => src.fairValLevel));
    }
}

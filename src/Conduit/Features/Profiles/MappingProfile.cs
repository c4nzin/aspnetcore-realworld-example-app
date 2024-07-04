using AutoMapper;

namespace Conduit.Features.Profiles;

//ok

public class MappingProfile : AutoMapper.Profile
{
    public MappingProfile() => CreateMap<Domain.Person, Profile>(MemberList.None);
}

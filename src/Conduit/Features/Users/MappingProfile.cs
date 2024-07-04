using AutoMapper;

namespace Conduit.Features.Users;

public class MappingProfile : Profile
//ok
{
    public MappingProfile() => CreateMap<Domain.Person, User>(MemberList.None);
}

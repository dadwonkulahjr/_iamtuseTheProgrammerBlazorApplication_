using AutoMapper;
using tuseTheProgrammerBlazor.Models;
using tuseTheProgrammerBlazorApplication.Models;

namespace tuseTheProgrammerBlazorApplication.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EditEmployeeModel>()
                .ForMember(destinationMember: dest => dest.ConfirmedEmail,
                opt => opt.MapFrom(src => src.Email));
            CreateMap<EditEmployeeModel, Employee>();
        }
    }
}

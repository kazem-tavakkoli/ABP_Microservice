using AtrinGol.Contract.Models.Contracts;
using AutoMapper;

namespace AtrinGol.Contract;

public class ContractApplicationAutoMapperProfile : Profile
{
    public ContractApplicationAutoMapperProfile()
    {
        CreateMap<Models.Contracts.Contract, ContractDto>(MemberList.Destination);
        CreateMap<CreateUpdateContractDto, Models.Contracts.Contract>(MemberList.Source);
    }
}

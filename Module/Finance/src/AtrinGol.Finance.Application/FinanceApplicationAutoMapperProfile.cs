using AtrinGol.Finance.Model.Finances;
using AutoMapper;

namespace AtrinGol.Finance;

public class FinanceApplicationAutoMapperProfile : Profile
{
    public FinanceApplicationAutoMapperProfile()
    {
        CreateMap<Models.Finances.Finance, FinanceDto>(MemberList.Destination);
        CreateMap<CreateUpdateFinanceDto, Models.Finances.Finance>(MemberList.Source);
    }
}

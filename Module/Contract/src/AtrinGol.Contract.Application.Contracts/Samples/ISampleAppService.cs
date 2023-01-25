using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace AtrinGol.Contract.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}

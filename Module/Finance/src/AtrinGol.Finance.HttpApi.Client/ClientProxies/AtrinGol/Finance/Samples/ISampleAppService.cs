// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using AtrinGol.Finance.Samples;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

// ReSharper disable once CheckNamespace
namespace AtrinGol.Finance.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using AtrinGol.Contract.Models.Contracts;
using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;
using Volo.Abp.ObjectExtending;

// ReSharper disable once CheckNamespace
namespace AtrinGol.Contract.Models.Contracts;

public class CreateUpdateContractDto
{
    public string Title { get; set; }

    public int Order { get; set; }

    public string Description { get; set; }
}
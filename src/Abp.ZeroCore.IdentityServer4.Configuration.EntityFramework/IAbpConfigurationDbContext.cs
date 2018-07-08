﻿// Project: Abp.ZeroCore.IdentityServer4.Configuration.EntityFramework
// File: IAbpConfigurationDbContext.cs
// 
// Copyright 2018 Mjollnir<mjollnir@59k.org>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using Abp.IdentityServer4.Entities;
using Microsoft.EntityFrameworkCore;

namespace Abp.IdentityServer4
{
    public interface IAbpConfigurationDbContext
    {
        DbSet<Client> Clients { get; set; }

        DbSet<IdentityResource> IdentityResources { get; set; }

        DbSet<ApiResource> ApiResources { get; set; }
    }
}

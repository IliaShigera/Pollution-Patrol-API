﻿global using System.Text;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using PollutionPatrol.API.Middlewares;
global using PollutionPatrol.API.Extensions;
global using PollutionPatrol.BuildingBlocks.Application.Exceptions;
global using PollutionPatrol.BuildingBlocks.Domain.Exceptions;
global using PollutionPatrol.BuildingBlocks.Infrastructure;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.IdentityModel.Tokens;
global using Microsoft.OpenApi.Models;
global using Newtonsoft.Json;
global using Serilog;
global using Serilog.Formatting.Compact;
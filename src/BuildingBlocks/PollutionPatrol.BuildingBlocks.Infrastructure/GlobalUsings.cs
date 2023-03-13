﻿global using PollutionPatrol.BuildingBlocks.Domain.Interfaces;
global using PollutionPatrol.BuildingBlocks.Domain.Models;
global using PollutionPatrol.BuildingBlocks.Application.Email;
global using PollutionPatrol.BuildingBlocks.Application.Options;
global using PollutionPatrol.BuildingBlocks.Application.FileAccess;
global using PollutionPatrol.BuildingBlocks.Infrastructure.DomainEventsDispatching;
global using PollutionPatrol.BuildingBlocks.Infrastructure.Email;
global using PollutionPatrol.BuildingBlocks.Infrastructure.FileAccess;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.Options;
global using Microsoft.AspNetCore.Http;
global using MimeKit;
global using MailKit.Net.Smtp;
global using MediatR;
global using System.Reflection;
global using Dropbox.Api;
global using Dropbox.Api.Files;
global using FFMpegCore;

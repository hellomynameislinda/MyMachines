﻿using Microsoft.EntityFrameworkCore;
using MyMachines.Data;
using MyMachines.Components;
using MyMachines.Repositories;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<MyMachinesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyMachinesContext") ?? throw new InvalidOperationException("Connection string 'MyMachinesContext' not found.")));

builder.Services.AddTransient<IMachineRepository, MachineRepository>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

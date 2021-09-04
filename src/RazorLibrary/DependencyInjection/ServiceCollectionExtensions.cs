using Microsoft.Extensions.DependencyInjection;
using RazorLibrary.Interfaces;
using RazorLibrary.Model;
using RazorLibrary.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorLibrary.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRazorLibrary(this IServiceCollection services)
        {
            services.AddTransient<IRazorEngine, RazorEngine>();
            services.AddTransient<IHtmlGenerator<NotificationModel>, NotificationHtmlGenerator>();
        }
    }
}

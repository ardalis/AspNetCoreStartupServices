using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace Ardalis.ListStartupServices
{
    public class ServiceConfig
    {
        public List<ServiceDescriptor> Services { get; set; } = new List<ServiceDescriptor>();
    }
}
